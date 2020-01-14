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

namespace API_Consumer.Cron
{
    public partial class CronFileLocations : InitForm
    {
        public CronFileLocations()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Cron_Location = tb_Cron.Text;
            Properties.Settings.Default.Excel_location = tb_Excel.Text;
            Properties.Settings.Default.Save(); // Saves settings in application configuration file
            Properties.Settings.Default.Reload();

            this.Close();
        }

        private void CronFileLocations_Shown(object sender, EventArgs e)
        {
            tb_Cron.Text = Properties.Settings.Default.Cron_Location;
            tb_Excel.Text = Properties.Settings.Default.Excel_location;
        }
    }
}
