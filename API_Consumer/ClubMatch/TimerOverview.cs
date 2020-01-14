using API_Consumer.ClubMatch.Registrations;
using API_Consumer.Common;
using API_Consumer.CSV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace API_Consumer.ClubMatch
{
    public partial class TimerOverview : InitForm
    {
        DateTime runTime;

        List<CronData> cr;

        public TimerOverview()
        {
            InitializeComponent();
            timer1.Interval = 250;
        }

        private void TimerOverview_Shown(object sender, EventArgs e)
        {
            ShowDgvData();
        }

        private void ShowDgvData()
        {
            List<CronData> cr = CSVManager.ReadCSVFromFile();
            var bindingList = new BindingList<CronData>(cr);
            var source = new BindingSource(bindingList, null);
            dgv_CronData.DataSource = source;
            dgv_CronData.Refresh();

            for (int i = 0; i < dgv_CronData.ColumnCount; i++)
            {
                dgv_CronData.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void btn_NewMatch_Click(object sender, EventArgs e)
        {
            TimerDownlaod f = new TimerDownlaod();
            f.Show();
        }

        private void btn_StartTimer_Click(object sender, EventArgs e)
        {
            timer1.Start();
            btn_StartTimer.Enabled = false;
            btn_StopTimer.Enabled = true;
            pg_Working.Visible = true;
        }

        private void btn_StopTimer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            btn_StartTimer.Enabled = true;
            btn_StopTimer.Enabled = false;
            pg_Working.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime nowTime = DateTime.Now;
            cr = CSVManager.GetActiveJobs();

            if (cr.Count == 0)
                return;

            runTime = new DateTime(nowTime.Year, nowTime.Month, nowTime.Day, cr[0].hours, cr[0].minutes, 0);

            if (DateTime.Now.Hour == runTime.Hour && DateTime.Now.Minute == runTime.Minute)
            {
                RegistrationManager RegMan = new RegistrationManager(api.getClubOpenRegistrations(cr[0].matchID.ToString()), CommonFunctions, cr[0].matchID.ToString());

                RegMan.PrepareData();

                CSVManager.UpdateOrInsertCSV(cr[0].matchID.ToString());

                // start on different thread
                Task mytask = Task.Run(() =>
                {
                    StatusPoruka.Text = RegMan.ExportToExcel();
                });

                ShowDgvData();
            }
        }

        private void TimerOverview_FormClosed(object sender, FormClosedEventArgs e)
        {
            timer1.Stop();
        }
    }
}
