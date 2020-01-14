using API_Consumer.Common;
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
    public partial class TimerDownlaod : InitForm
    {
        public string MatchID { get; set; }
        public TimerDownlaod()
        {
            InitializeComponent();
            MatchID = "";
        }

        private void btn_StartTimer_Click(object sender, EventArgs e)
        {
            string checkedCB = cb_Registrations.Checked == true ? "1" : "0";
            DateTime? _datetime = tm_picker.Value;

            var line = string.Format("{0};{1};{2};{3};{4}", _datetime.Value.Hour, _datetime.Value.Minute, tbMatchId.Text, checkedCB, "0");

            CSV.CSVManager.UpdateOrInsertCSV(line, true);

            MessageBox.Show("Uspješno sačuvano");

            Close();
        }

        private void TimerDownlaod_Shown(object sender, EventArgs e)
        {
            if (MatchID != "")
            {
                tbMatchId.Text = MatchID;
            }
        }
    }
}
