﻿using System;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Linq;
using API_Consumer.Common;
using System.ComponentModel;
using API_Consumer.ClubMatch;

namespace API_Consumer.Clubs
{

    public partial class Clubs : InitForm
    {
        public string ClubName { get; set; }

        
        public Clubs()
        {
            InitializeComponent();
        }

        private void Clubs_Shown(object sender, EventArgs e)
        {
            try
            {
                var cekanje = new Waiting();
                // upali čekanje
                cekanje.Show();
                // prikupi podatke od API
                // endpoint za mečeve 
                ClubObjekt klub = api.GetClubObjekt(ClubName);

                Matches mec = api.GetMatches(ClubName);

                cekanje.Close();

                lbl_KlubNazivVrednost.Text = klub.name;
                lbl_NumPlayersValue.Text = klub.members_count.ToString();

                lbl_FinishedCount.Text = mec.finished.Count.ToString();
                l_InProgress.Text = mec.in_progress.Count.ToString();
                l_Registration.Text = mec.registered.Count.ToString();

                FillGridWithData<Finished>(dgvFinished, mec.finished);
                FillGridWithData<InProgress>(dgvInProgress, mec.in_progress);
                FillGridWithData<Registered>(dgv_Registrations, mec.registered);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desila se greška prilikom prikupljanja podataka o klubu. Provjerite naziv i pokušajte ponovo!" + ex.Message);
                this.Close();
            }
        }

        public void FillGridWithData<T> (DataGridView dgv, List<T> data) where T : IMatchType
        {
            dgv.ColumnCount = 5;
            dgv.Columns[0].Name = "ID";
            dgv.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[1].Name = "Names";
            dgv.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[2].Name = "Protivnik";
            dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[3].Name = "Početak";
            dgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[4].Name = "Rezultat";
            dgv.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            string[] finished = new string[5];

            foreach (var matchItem in data)
            {
                finished[0] = matchItem.Id.ToString();
                finished[1] = matchItem.name;
                finished[2] = matchItem.opponent;
                finished[3] = CommonFunctions.FromUnixTime(matchItem.start_time);
                finished[4] = matchItem.result;

                dgv.Rows.Add(finished);
            }
            dgv.DataBindingComplete += (o, _) =>
            {
                var dataGridView = o as DataGridView;
                if (dataGridView != null)
                {
                    dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            };

            dgv.RowPrePaint += new DataGridViewRowPrePaintEventHandler(changeColorOfLiveMatchRows);

            dgv.Sort(dgv.Columns[3], ListSortDirection.Descending);
        }

        private void changeColorOfLiveMatchRows(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            var dataGridView = sender as DataGridView;
            if (dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString().Contains("live"))
            {
                dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightSeaGreen;
            }
            else
            {
                dataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.AliceBlue;
            }
        }

        private void dgvFinished_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int lastSegment = int.Parse(CommonFunctions.getLastPart(dgvFinished.Rows[e.RowIndex].Cells[0].Value.ToString()));
                ClubMatch.ClubMatchForm forma = new ClubMatch.ClubMatchForm
                {
                    matchId = lastSegment,
                    isLive = CommonFunctions.isLiveMatch(dgvFinished.Rows[e.RowIndex].Cells[0].Value.ToString())
                };

                forma.Show();

            } catch (Exception ex)
            {
                MessageBox.Show("Greška, zovi Bokca, ovo je greška: " + ex.ToString());
            }

        }

        private void dgvFinished_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CommonFunctions.showRightMenu(sender, e);
        }

        private void dgvInProgress_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CommonFunctions.showRightMenu(sender, e);
        }

        private void dgvInProgress_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int lastSegment = int.Parse(CommonFunctions.getLastPart(dgvInProgress.Rows[e.RowIndex].Cells[0].Value.ToString()));

                ClubMatch.ClubMatchForm forma = new ClubMatch.ClubMatchForm
                {
                    matchId = lastSegment
                };

                forma.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška, zovi Bokca, ovo je greška: " + ex.ToString());
            }
        }

        private void dgv_Registrations_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int lastSegment = int.Parse(CommonFunctions.getLastPart(dgv_Registrations.Rows[e.RowIndex].Cells[0].Value.ToString()));
                RegistrationForm forma = new RegistrationForm
                {
                    matchId = lastSegment,
                    isLive = dgv_Registrations.Rows[e.RowIndex].Cells[0].Value.ToString().Contains("live")
                };

                forma.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška, zovi Bokca, ovo je greška: " + ex.ToString());
            }
        }

        private void dgv_Registrations_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CommonFunctions.showRightMenu(sender, e);
        }

        private void btn_Activity_Click(object sender, EventArgs e)
        {
            var froma = new MemberActivity(){
                ma_ClubName = ClubName
            };

            froma.Show();
        }

        private void btn_AutoDownload_Click(object sender, EventArgs e)
        {
            TimerDownlaod d = new TimerDownlaod();
            d.MatchID = CommonFunctions.getLastPart(dgv_Registrations.Rows[dgv_Registrations.CurrentCell.RowIndex].Cells[0].Value.ToString());
            d.Show();
        }

        private void tabCtrl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabCtrl1.SelectedTab == tabCtrl1.TabPages[2])
            {
                btn_AutoDownload.Visible = true;
            } else
            {
                btn_AutoDownload.Visible = false;
            }
        }
    }
}
