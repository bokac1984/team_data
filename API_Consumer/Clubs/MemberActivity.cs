using API_Consumer.Common;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Player;

namespace API_Consumer.Clubs
{
    public partial class MemberActivity : InitForm
    {
        private Activity _memberActivity;

        private HashSet<MemberDataForGrid> _hs_members;

        private int membersCount;

        public string ma_ClubName { get; set; }

        public MemberActivity()
        {
            InitializeComponent();
        }

        private void DisplayInformation()
        {
            l_Weekly.Text = _memberActivity.Weekly.Count.ToString();
            l_Monthly.Text = _memberActivity.Monthly.Count.ToString();
            l_AllTime.Text = _memberActivity.AllTime.Count.ToString();
        }

        private void MemberActivity_Shown(object sender, EventArgs e)
        {
            _memberActivity = api.getPlayerActivity(ma_ClubName);

            membersCount = _memberActivity.Weekly.Count + _memberActivity.Monthly.Count + _memberActivity.AllTime.Count;

            DisplayInformation();
        }

        private async void btn_ShowInfo_Click(object sender, EventArgs e)
        {
            pg_APIFetch.Visible = true;
            progress_Label.Visible = true;

            pg_APIFetch.Maximum = membersCount;
            pg_APIFetch.Step = 1;

            var progress = new Progress<int>(v =>
            {
                // This lambda is executed in context of UI thread,
                // so it can safely update form controls
                pg_APIFetch.Value = v;
            });

            await Task.Run(() => DoWork(progress));

            pg_APIFetch.Visible = false;
            progress_Label.Visible = false;

            var source = new BindingSource();
            source.DataSource = _hs_members;
            dgv_Info.DataSource = source;

            CommonFunctions.ResizeColumns(dgv_Info);

            btn_ExcelExport.Enabled = true;
        }

        private void dgv_Info_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CommonFunctions.showRightMenu(sender, e);
        }

        private void DoWork(IProgress<int> progress)
        {
            _hs_members = new HashSet<MemberDataForGrid>();
            List<Member> allMembers = new List<Member>();
            var a = from aa in _memberActivity.AllTime
                    select new Member()
                    {
                        Username = aa.Username,
                        Joined = aa.Joined
                    };

            allMembers.AddRange(a.ToList<Member>());

            var b = from bb in _memberActivity.Weekly
                    select new Member()
                    {
                        Username = bb.Username,
                        Joined = bb.Joined
                    };
            allMembers.AddRange(b.ToList<Member>());

            var c = from cc in _memberActivity.Monthly
                    select new Member()
                    {
                        Username = cc.Username,
                        Joined = cc.Joined
                    };
            allMembers.AddRange(c.ToList<Member>());

            foreach (var item in allMembers)
            {
                MemberDataForGrid memberDataItem = new MemberDataForGrid();
                memberDataItem.Username = item.Username;
                memberDataItem.LastOnline = CommonFunctions.FromUnixTime(item.LastOnline);
                memberDataItem.Joined = CommonFunctions.FromUnixTime(item.Joined);
                memberDataItem.ChallengeWaiting = item.ChallengeWaiting;
                memberDataItem.GamesToMove = item.GamesToMove;
                memberDataItem.NewMessages = item.NewMessages;
                memberDataItem.Notifications = item.Notifications;
                memberDataItem.JoinedSite = "";
                _hs_members.Add(memberDataItem);
            }

            int countMembers = _hs_members.Count;
            int i = 1;

            foreach (var m in _hs_members)
            {
                Notices n = api.GetNoticesForPlayer(m.Username);
                Player.PlayerInfo playerInfo = api.GetPlayerInfo(m.Username);
                PlayerStats playerStats = api.GetPlayerStats(m.Username);

                m.GamesToMove = n.GamesToMove;
                m.ChallengeWaiting = n.ChallengeWaiting;
                m.NewMessages = n.NewMessages;
                m.Notifications = n.Notifications;
                m.LastOnline = CommonFunctions.FromUnixTime(playerInfo.LastOnline);
                m.JoinedSite = CommonFunctions.FromUnixTime(playerInfo.Joined);
                if (playerStats.Chess960_Daily != null)
                {
                    m.Broj960Partija = playerStats.Chess960_Daily.Record.Win + playerStats.Chess960_Daily.Record.Loss + playerStats.Chess960_Daily.Record.Draw;
                    m.Current960Rating = playerStats.Chess960_Daily.Last.Rating;
                    m.TimePerMove960 = Math.Round(((double)playerStats.Chess960_Daily.Record.TimePerMove / 60 / 60), 2);
                } 
                else
                {
                    m.Broj960Partija = 0;
                    m.Current960Rating = 0;
                    m.TimePerMove960 = 0;
                }
                if (playerStats.Chess_Daily != null)
                {
                    m.BrojDnevnihPartija = playerStats.Chess_Daily.Record.Win + playerStats.Chess_Daily.Record.Loss + playerStats.Chess_Daily.Record.Draw;
                    m.CurrentDailyRating = playerStats.Chess_Daily.Last.Rating;
                    m.TimePerMoveDaily = Math.Round(((double)playerStats.Chess_Daily.Record.TimePerMove / 60 / 60), 2);
                }
                else
                {
                    m.BrojDnevnihPartija = 0;
                    m.CurrentDailyRating = 0;
                    m.TimePerMoveDaily = 0;
                }

                progress_Label.Text = i.ToString() + "/" + countMembers.ToString();
                progress.Report(i);
                i++;
            }
        }

        private void dgv_Info_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CommonFunctions.viewPlayer(sender, 0, 0);
        }

        private void btn_ExcelExport_Click(object sender, EventArgs e)
        {
            try
            {
                using (ExcelPackage excelPackage = new ExcelPackage())
                {
                    //create a new Worksheet
                    ExcelWorksheet ws = excelPackage.Workbook.Worksheets.Add("Sheet 1");

                    string nazivFajla = ma_ClubName + "_" + DateTime.Now.ToString("yyyyMMdd_hhmm") + ".xlsx";
                    string filePath = Properties.Settings.Default.Excel_location + nazivFajla;

                    var headerCells = ws.Cells[1, 1, 1, 14];
                    var headerFont = headerCells.Style.Font;
                    headerFont.Bold = true;

                    headerCells.Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thick;

                    if (File.Exists(filePath))
                    {
                        throw new Exception("već postoji fajl");
                    }

                    ws.Cells["A1"].Value = "Igrač";
                    ws.Cells["B1"].Value = "Pristupio Sajtu";
                    ws.Cells["C1"].Value = "Pristupio Klubu";
                    ws.Cells["D1"].Value = "Bio online";
                    ws.Cells["E1"].Value = "ChallengeWaiting";
                    ws.Cells["F1"].Value = "Čeka se na potez";
                    ws.Cells["G1"].Value = "Nova poruka";
                    ws.Cells["H1"].Value = "Obavještenje";
                    ws.Cells["I1"].Value = "Broj Dnevnih partija";
                    ws.Cells["J1"].Value = "Rejting Dnevni";
                    ws.Cells["K1"].Value = "h/potez Dnevni";
                    ws.Cells["L1"].Value = "Broj 960 partija";
                    ws.Cells["M1"].Value = "Rejting 960";
                    ws.Cells["N1"].Value = "h/potez 960";

                    int i = 2;

                    foreach (var item in _hs_members)
                    {
                        ws.Cells["A" + i.ToString()].Value = item.Username;
                        ws.Cells["B" + i.ToString()].Value = item.JoinedSite;
                        ws.Cells["B" + i.ToString()].Style.Numberformat.Format = "yyyy-mm-dd hh:mm:ss";
                        ws.Cells["C" + i.ToString()].Value = item.Joined;
                        ws.Cells["C" + i.ToString()].Style.Numberformat.Format = "yyyy-mm-dd hh:mm:ss";
                        ws.Cells["D" + i.ToString()].Value = item.LastOnline;
                        ws.Cells["D" + i.ToString()].Style.Numberformat.Format = "yyyy-mm-dd hh:mm:ss";
                        ws.Cells["E" + i.ToString()].Value = item.ChallengeWaiting;
                        ws.Cells["F" + i.ToString()].Value = item.GamesToMove;
                        ws.Cells["G" + i.ToString()].Value = item.NewMessages;
                        ws.Cells["H" + i.ToString()].Value = item.Notifications;
                        ws.Cells["I" + i.ToString()].Value = item.BrojDnevnihPartija;
                        ws.Cells["J" + i.ToString()].Value = item.CurrentDailyRating;
                        ws.Cells["K" + i.ToString()].Value = item.TimePerMoveDaily;
                        ws.Cells["L" + i.ToString()].Value = item.Broj960Partija;
                        ws.Cells["M" + i.ToString()].Value = item.Current960Rating;
                        ws.Cells["N" + i.ToString()].Value = item.TimePerMove960;
                        i++;
                    }

                    ws.Cells.AutoFitColumns();

                    //convert the excel package to a byte array
                    byte[] bin = excelPackage.GetAsByteArray();

                    //write the file to the disk
                    File.WriteAllBytes(filePath, bin);
                    statusna_labela.Text = "Excel saved!";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }
    }
}
