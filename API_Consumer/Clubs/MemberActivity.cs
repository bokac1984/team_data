using API_Consumer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_Consumer.Clubs
{
    public partial class MemberActivity : InitForm
    {
        private Activity _memberActivity;

        private HashSet<Member> _hs_members;

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
        }

        private void dgv_Info_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CommonFunctions.showRightMenu(sender, e);
        }

        private void DoWork(IProgress<int> progress)
        {
            _hs_members = new HashSet<Member>();
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
                _hs_members.Add(item);
            }

            int countMembers = _hs_members.Count;
            int i = 1;

            foreach (var m in _hs_members)
            {
                Notices n = api.GetNoticesForPlayer(m.Username);

                m.GamesToMove = n.GamesToMove;
                m.ChallengeWaiting = n.ChallengeWaiting;
                m.NewMessages = n.NewMessages;
                m.Notifications = n.Notifications;

                progress.Report(i++);

                progress_Label.Text = i.ToString() + "/" + countMembers.ToString();               
            }
        }

        private void dgv_Info_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CommonFunctions.viewPlayer(sender, 0, 0);
        }
    }
}
