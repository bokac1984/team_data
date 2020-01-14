using API_Consumer.Common;
using System;
using Player;
using System.Windows.Forms;

namespace API_Consumer.Players
{
    public partial class PlayerViewById : InitForm
    {

        public string _PlayerName { get; set; }
        public PlayerViewById()
        {
            InitializeComponent();
            pb_ProfileImage.LoadAsync("https://dummyimage.com/109X118/919191/b50e0e.png&text=Nema+slike");
        }

        public void PretrazSaDrugeForme()
        {
            tb_PlayerName.Text = _PlayerName;
            btn_Pretrazi.PerformClick();

            tb_PlayerName.Enabled = false;
            btn_Pretrazi.Enabled = false;
        }

        private void btn_Pretrazi_Click(object sender, EventArgs e)
        {
            string urlInfo = ApiEndPoint + "player/" + tb_PlayerName.Text;
            string urlStats = ApiEndPoint + "player/" + tb_PlayerName.Text + "/stats";

            try
            {
                PlayerInfo info = API.GetData.getApiData<PlayerInfo>(urlInfo);

                PlayerStats stats = API.GetData.getApiData<PlayerStats>(urlStats);

                if (info.Avatar != null)
                {
                    pb_ProfileImage.LoadAsync(info.Avatar.ToString());
                }


                l_username.Text = info.Username;
                l_name.Text = info.Name;
                l_location.Text = info.Location;
                l_joined.Text = CommonFunctions.FromUnixTime(info.Joined);
                l_lastOnline.Text = CommonFunctions.FromUnixTime(info.LastOnline);
                l_status.Text = info.Status;
                l_IgraVec.Text = Math.Round((CommonFunctions.FromUnixTimeDateTime(info.LastOnline) - CommonFunctions.FromUnixTimeDateTime(info.Joined)).TotalDays / 365, 2).ToString() + " g";

                #region Dnevni šah
                if (stats.Chess_Daily != null)
                {
                    l_DailyRating.Text = stats.Chess_Daily.Last.Rating.ToString();
                    l_DailyDate.Text = CommonFunctions.FromUnixTime(stats.Chess_Daily.Last.Date);
                    l_RD_Chess_Daily.Text = stats.Chess_Daily.Last.Rd.ToString();
                    l_highestDailyRating.Text = stats.Chess_Daily.Best.Rating.ToString();
                    l_HighestRatingDate.Text = CommonFunctions.FromUnixTime(stats.Chess_Daily.Best.Date);

                    l_GamesCount.Text = stats.Chess_Daily.Record.Win.ToString() + "W/" + stats.Chess_Daily.Record.Loss.ToString()
                        + "L/" + stats.Chess_Daily.Record.Draw.ToString() + "D";
                    l_TOCount.Text = stats.Chess_Daily.Record.TimeoutPercent.ToString();
                    double tpr = (double)stats.Chess_Daily.Record.TimePerMove;
                    l_TimePerMove.Text = Math.Round((tpr / 60 / 60), 2).ToString() + " h";

                }

                if (stats.Chess960_Daily != null)
                {
                    l_Chess960_DailyRating.Text = stats.Chess960_Daily.Last.Rating.ToString();
                    l_Chess960_DailyDate.Text = CommonFunctions.FromUnixTime(stats.Chess960_Daily.Last.Date);
                    l_RD_Chess960_Daily.Text = stats.Chess960_Daily.Last.Rd.ToString();
                    l_highestChess960_DailyRating.Text = stats.Chess960_Daily.Best.Rating.ToString();
                    l_Chess960_DailyHighestRatingDate.Text = CommonFunctions.FromUnixTime(stats.Chess960_Daily.Best.Date);

                    l_Chess960_DailyGamesCount.Text = stats.Chess960_Daily.Record.Win.ToString() + "W/" + stats.Chess960_Daily.Record.Loss.ToString()
                        + "L/" + stats.Chess960_Daily.Record.Draw.ToString() +"D";
                    l_Chess960_DailyTOCount.Text = stats.Chess960_Daily.Record.TimeoutPercent.ToString();
                    double tpr = (double)stats.Chess960_Daily.Record.TimePerMove;
                    l_Chess960_DailyTimePerMove.Text = Math.Round((tpr / 60 / 60), 2).ToString() + " h";
                }

                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška: " + ex.Message);
            }
        }

        private void tb_PlayerName_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                btn_Pretrazi_Click(sender, e);
            }
        }
    }
}
