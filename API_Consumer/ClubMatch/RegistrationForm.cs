using API_Consumer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_Consumer.ClubMatch
{
    public partial class RegistrationForm : InitForm
    {
        public int matchId { get; set; }

        public bool isLive { get; set; }

        public RegistrationForm()
        {
            InitializeComponent();
        }

        public void ShowRegistrations()
        {
            p_Register.Visible = true;

            string url = ApiEndPoint + "match/" + (isLive ? "live/" : "") + matchId.ToString();

            var cekanje = new Waiting();

            // upali čekanje
            cekanje.Show();

            //var watch = System.Diagnostics.Stopwatch.StartNew();
            Registrations.Registrations mec = API.GetData.getApiData<Registrations.Registrations>(url);

            #region Labele na formi
            l_MatchID.Text = matchId.ToString();

            l_StartTime.Text = CommonFunctions.FromUnixTime(mec.StartTime);
            l_BoardCount.Text = mec.Boards.ToString();

            l_Description.Text = mec.Description;

            l_Team1.Text = mec.Teams.Team1.Name;
            l_Team2.Text = mec.Teams.Team2.Name;

            l_Autostart.Text = mec.Settings.Autostart ? "Da" : "Ne";


            if (mec.Settings.TimeControl.Contains("/")) {
                l_Tempo.Text =  (int.Parse(mec.Settings.TimeControl.Split('/')[1]) / 86400).ToString() + "d";
            } else
            {
                l_Tempo.Text = (int.Parse(mec.Settings.TimeControl) / 60).ToString() + "m";
            }

            l_MinGames.Text = mec.Settings.MinRequiredGames.ToString();
            l_MinPlayers.Text = mec.Settings.MinTeamPlayers.ToString();
            l_Type.Text = mec.Settings.Rules.ToString() == "chess960" ? "960" : "Standard";

            #endregion

            var igraci2 = from b in mec.Teams.Team2.Players
                         //from c in mec.Teams.Team2.Players
                         orderby b.Rating descending
                         select new Registrations.Player()
                         {
                             Username = b.Username,
                             Rd = b.Rd,
                             Status = b.Status,
                             TimeoutPercent = b.TimeoutPercent,
                             Rating = b.Rating
                         };
            var igraci1 = from b in mec.Teams.Team1.Players
                              //from c in mec.Teams.Team2.Players
                          orderby b.Rating descending
                          select new Registrations.Player()
                          {
                              Username = b.Username,
                              Rd = b.Rd,
                              Status = b.Status,
                              TimeoutPercent = b.TimeoutPercent,
                              Rating = b.Rating
                          };

            var tabele = new List<dynamic>();

            if (igraci1.Count() >= igraci2.Count())
            {
                for (int i = 0; i < igraci1.Count(); i++)
                {
                    if (i >= igraci2.Count())
                    {
                        tabele.Add(new
                        {
                            t1_Username = igraci1.ElementAt(i).Username,
                            t1_Status = igraci1.ElementAt(i).Status,
                            t1_TimeoutPercent = igraci1.ElementAt(i).TimeoutPercent,
                            t1_Rd = igraci1.ElementAt(i).Rd,
                            t1_Rating = igraci1.ElementAt(i).Rating,

                            
                            
                            t2_Rating = new long(),
                            t2_Rd = new double(),
                            t2_TimeoutPercent = new double(),
                            t2_Status = new Registrations.Status(),
                            t2_Username = "",
                        });
                    }
                    else
                    {
                        tabele.Add(new
                        {
                            t1_Username = igraci1.ElementAt(i).Username,
                            t1_Status = igraci1.ElementAt(i).Status,
                            t1_TimeoutPercent = igraci1.ElementAt(i).TimeoutPercent,
                            t1_Rd = igraci1.ElementAt(i).Rd,
                            t1_Rating = igraci1.ElementAt(i).Rating,
                            t2_Rating = igraci2.ElementAt(i).Rating,
                            t2_Rd = igraci2.ElementAt(i).Rd,
                            t2_TimeoutPercent = igraci2.ElementAt(i).TimeoutPercent,
                            t2_Status = igraci2.ElementAt(i).Status,
                            t2_Username = igraci2.ElementAt(i).Username
                        });
                    }
                }
            }
            else
            {
                for (int i = 0; i < igraci2.Count(); i++)
                {
                    if (i >= igraci1.Count())
                    {
                        tabele.Add(new
                        {
                            t1_Username = "",
                            t1_Status = new Registrations.Status(),
                            t1_TimeoutPercent = new double(),
                            t1_Rd = new double(),
                            t1_Rating = new long(),
                            
 
                            t2_Rating = igraci2.ElementAt(i).Rating,
                            t2_Rd = igraci2.ElementAt(i).Rd,
                            t2_TimeoutPercent = igraci2.ElementAt(i).TimeoutPercent,
                            t2_Status = igraci2.ElementAt(i).Status,
                            t2_Username = igraci2.ElementAt(i).Username


                        });
                    } else
                    {
                        tabele.Add(new
                        {
                            t1_Username = igraci1.ElementAt(i).Username,
                            t1_Status = igraci1.ElementAt(i).Status,
                            t1_TimeoutPercent = igraci1.ElementAt(i).TimeoutPercent,
                            t1_Rd = igraci1.ElementAt(i).Rd,
                            t1_Rating = igraci1.ElementAt(i).Rating,
                            t2_Rating = igraci2.ElementAt(i).Rating,
                            t2_Rd = igraci2.ElementAt(i).Rd,
                            t2_TimeoutPercent = igraci2.ElementAt(i).TimeoutPercent,
                            t2_Status = igraci2.ElementAt(i).Status,
                            t2_Username = igraci2.ElementAt(i).Username
                        });
                    }
                }
            }

            var source = new BindingSource();
            source.DataSource = mec;
            dgv_Register.Refresh();
            dgv_Register.DataSource = null;
            dgv_Register.DataSource = tabele;

            dgv_Register.Columns[0].HeaderText = mec.Teams.Team1.Name;
            dgv_Register.Columns[1].HeaderText = "Tip korisnika";
            dgv_Register.Columns[2].HeaderText = "TO %";
            dgv_Register.Columns[3].HeaderText = "RD";
            dgv_Register.Columns[4].HeaderText = "Rejting";
            dgv_Register.Columns[5].HeaderText = "Rejting";
            dgv_Register.Columns[6].HeaderText = "RD";
            dgv_Register.Columns[7].HeaderText = "TO %";
            dgv_Register.Columns[8].HeaderText = "Tip korisnika";
            dgv_Register.Columns[9].HeaderText = mec.Teams.Team2.Name;



            for (int i = 0; i < dgv_Register.ColumnCount; i++)
            {
                dgv_Register.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            
            cekanje.Close();
        }

        private void RegistrationForm_Shown(object sender, EventArgs e)
        {
            this.ShowRegistrations();
        }

        private void dgv_Register_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CommonFunctions.showRightMenu(sender, e);
        }

        private void dgv_Register_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CommonFunctions.viewPlayer(sender, 0, 9);
        }

        private void btn_Registration_Refresh_Click(object sender, EventArgs e)
        {
            this.ShowRegistrations();
        }
    }
}
