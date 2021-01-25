using API_Consumer.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_Consumer.Clubs
{
    public partial class ClubManagement : InitForm
    {
        public ClubManagement()
        {
            InitializeComponent();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            string url = ApiEndPoint + "club/" + tb_ClubName.Text;
            ClubInfo klub;
            try
            {
                klub = API.GetData.getApiData<ClubInfo>(url);

                if (klub == null || klub.Id == null)
                {
                    throw new NotImplementedException();
                }
            }
            catch
            {
                MessageBox.Show("Provjerite naziv kluba, došlo je do greške.");

                return;
            }


            MyClubs a = getMyClubs();

            if (a.Clubs == null)
            {
                List<ClubInfo> t = new List<ClubInfo>();
                t.Add(klub);
                a.Clubs = t;
            }
            else
            {
                var urlClubExists = a.Clubs.Any(x => x.Id == klub.Id);

                if (urlClubExists)
                {
                    MessageBox.Show("Već ste dodali taj klub!");
                    return;
                }
                else
                {
                    a.Clubs.Add(klub);
                }
            }

            SaveSettings(a);

            ShowSettingsInGrid();

            tb_ClubName.Text = "";
        }

        private void ClubManagement_Shown(object sender, EventArgs e)
        {
            try
            {
                ShowSettingsInGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private MyClubs getMyClubs()
        {
            string Clubs = Properties.Settings.Default.MyClubs;

            if (Clubs == "")
            {
                return new MyClubs();
            }

            return JsonConvert.DeserializeObject<MyClubs>(Properties.Settings.Default.MyClubs);
        }

        private void ShowSettingsInGrid()
        {
            try
            {
                MyClubs mk = getMyClubs();
                var bindingList = new BindingList<ClubInfo>(mk.Clubs);
                var source = new BindingSource(bindingList, null);
                dgv_Clubs.DataSource = source;
                dgv_Clubs.Refresh();

                for (int i = 0; i < dgv_Clubs.ColumnCount; i++)
                {
                    dgv_Clubs.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                ShowClubInfo();
            }
            catch
            {
                MessageBox.Show("Nije nađen ni jedan klub!");
            }
        }

        private void dgv_Clubs_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridView dgv = (DataGridView)sender;

                int ColIndex = dgv.CurrentCell.ColumnIndex;
                int RowIndex = dgv.CurrentCell.RowIndex;

                string klub = CommonFunctions.getLastPart(dgv.Rows[dgv.CurrentCell.RowIndex].Cells[0].Value.ToString());
                Clubs _clubs = new Clubs();
                _clubs.ClubName = klub;

                _clubs.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška, zovi Bokca, ovo je greška: " + ex.ToString());
            }
        }

        private void SaveSettings(MyClubs mk)
        {
            string vrednost = JsonConvert.SerializeObject(mk);
            Properties.Settings.Default.MyClubs = vrednost;
            Properties.Settings.Default.Save(); // Saves settings in application configuration file
            Properties.Settings.Default.Reload();
        }

        private void btn_DeleteMyClub_Click(object sender, EventArgs e)
        {
            //Properties.Settings.Default.Reset();
            if (MessageBox.Show("Da li ste sigurni u ovo?", "Brisanje kluba", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dgv_Clubs.SelectedCells.Count > 0)
                {
                    int selectedrowindex = dgv_Clubs.SelectedCells[0].RowIndex;
                    DataGridViewRow selectedRow = dgv_Clubs.Rows[selectedrowindex];
                    Uri clubId;

                    Uri.TryCreate(selectedRow.Cells[0].Value.ToString(), UriKind.Absolute, out clubId);

                    MyClubs mk = getMyClubs();
                    mk.Clubs.RemoveAll(x => x.Id == clubId);

                    Properties.Settings.Default.Reset();

                    SaveSettings(mk);

                    ShowSettingsInGrid();
                }
            }
        }

        private void dgv_Clubs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowClubInfo();
        }

        private void ShowClubInfo()
        {
            int selectedrowindex = dgv_Clubs.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dgv_Clubs.Rows[selectedrowindex];
            string image = selectedRow.Cells[11].Value != null ? selectedRow.Cells[11].Value.ToString() : "";
            try
            {
                pb_ClubIcon.LoadAsync(image);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            l_Name.Text = selectedRow.Cells[1].Value.ToString();
            l_MembersCount.Text = selectedRow.Cells[6].Value.ToString();
            l_AvgDailyRating.Text = selectedRow.Cells[5].Value == null ? "" : selectedRow.Cells[5].Value.ToString();
            l_Created.Text = CommonFunctions.FromUnixTime((long)selectedRow.Cells[7].Value);
            l_LastActivity.Text = CommonFunctions.FromUnixTime((long)selectedRow.Cells[8].Value);
            //l_Description.Text = selectedRow.Cells[11].Value != null ? selectedRow.Cells[11].Value.ToString() : "";
        }

        private void dgv_Clubs_SelectionChanged(object sender, EventArgs e)
        {
            //ShowClubInfo();
        }

        private void tb_ClubName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_Add_Click(sender, e);
            }
        }
    }
}
