using System;
using API_Consumer.Common;
using API_Consumer.Cron;
using API_Consumer.Players;

namespace API_Consumer
{
    public partial class MainForm : InitForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void kreirajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void dodajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clubs.Clubs _clubs = new Clubs.Clubs();
            _clubs.ClubName = "bosnia-and-herzegovina";

            _clubs.Show();
        }

        private void pregledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clubs.ClubView _ClubView = new Clubs.ClubView();
            _ClubView.Show(); // ne znam šta je ovo
        }

        private void dodajToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClubMatch.ClubMatchForm _ClubMatchForm = new ClubMatch.ClubMatchForm();
            _ClubMatchForm.Show();
        }

        private void pregledToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ClubMatch.ClubMatchView _ClubMatchView = new ClubMatch.ClubMatchView();
            _ClubMatchView.Show();
        }

        private void pretražiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clubs.ClubView _ClubView = new Clubs.ClubView();

            _ClubView.Show();
        }

        private void pomoćToolStripMenuItem_Click(object sender, EventArgs e)
        {

            About.Help _Help = new About.Help();
            _Help.Show();
        }

        private void pretraziIgracaMenuItem_Click(object sender, EventArgs e)
        {
            PlayerViewById a = new PlayerViewById();

            a.Show();
        }

        private void dodajTimToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mnu_MyTeams_Click(object sender, EventArgs e)
        {
            Clubs.ClubManagement forma = new Clubs.ClubManagement();

            forma.Show();
        }

        private void timerDownload_Click(object sender, EventArgs e)
        {
            ClubMatch.TimerDownlaod forma = new ClubMatch.TimerDownlaod();

            forma.Show();
        }

        private void pregledToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClubMatch.TimerOverview f = new ClubMatch.TimerOverview();
            f.Show();
        }

        private void mnu_Locations_Click(object sender, EventArgs e)
        {
            CronFileLocations l = new CronFileLocations();
            l.Show();
        }
    }
}
