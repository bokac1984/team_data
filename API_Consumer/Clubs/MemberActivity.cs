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

                m.GamesToMove = n.GamesToMove;
                m.ChallengeWaiting = n.ChallengeWaiting;
                m.NewMessages = n.NewMessages;
                m.Notifications = n.Notifications;
                m.LastOnline = CommonFunctions.FromUnixTime(playerInfo.LastOnline);
                m.JoinedSite = CommonFunctions.FromUnixTime(playerInfo.Joined);

                progress.Report(i++);

                progress_Label.Text = i.ToString() + "/" + countMembers.ToString();               
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

                    string nazivFajla = "aktivnost_new.xlsx";
                    string filePath = Properties.Settings.Default.Excel_location + nazivFajla;

                    if (File.Exists(filePath))
                    {
                        throw new Exception("već postoji fajl");
                    }

                    ws.Cells["A1"].Value = "Username";
                    ws.Cells["B1"].Value = "PristupioSajtu";
                    ws.Cells["C1"].Value = "PristupioKlubu";
                    ws.Cells["D1"].Value = "LastOnline";
                    ws.Cells["E1"].Value = "ChallengeWaiting";
                    ws.Cells["F1"].Value = "GamesToMove";
                    ws.Cells["G1"].Value = "NewMessages";
                    ws.Cells["H1"].Value = "Notifications";
                    

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
