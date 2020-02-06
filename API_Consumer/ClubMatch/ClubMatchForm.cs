using System;
using System.Linq;
using System.Windows.Forms;
using API_Consumer.Clubs;
using API_Consumer.Common;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Drawing;
using System.Threading.Tasks;

namespace API_Consumer.ClubMatch
{
    public partial class ClubMatchForm : InitForm
    {
        public int matchId { get; set; }

        public bool isLive { get; set; }

        private int brojkolona;

        private List<Tabla> boardList;

        private ClubMatch mec;

        List<string> team1PlayersRemoved;
        List<string> team2PlayersRemoved;

        public ClubMatchForm()
        {
            InitializeComponent();

            brojkolona = 23; // broj kolona za grid
            List<string> team1PlayersRemoved = new List<string>();
            List<string> team2PlayersRemoved = new List<string>();
        }

        private void ClubMatchForm_Shown(object sender, EventArgs e)
        {
            ShowMatchData();
        }

        public async void ShowMatchData()
        {
            try
            {
                int closed1 = 0;
                int closed2 = 0;
                var watch = System.Diagnostics.Stopwatch.StartNew();
                tsl_Time.Text = "Generisanje prikaza podataka...";
                string[] finished = new string[brojkolona];
                //var cekanje = new Waiting();
                //var watch = System.Diagnostics.Stopwatch.StartNew();
                // upali čekanje
                //cekanje.Show();

                mec = api.GetClubMatch(matchId.ToString(), isLive);

                // skloni jer smo dobili podatke
                pg_APIFetch.Visible = true;
                l_DisplayCount.Visible = true;
                pg_APIFetch.Maximum = mec.boards;
                pg_APIFetch.Step = 1;
                var progress = new Progress<int>(v =>
                {
                    pg_APIFetch.Value = v;
                });

                await Task.Run(() => DoWork(progress));

                pg_APIFetch.Visible = false;
                l_DisplayCount.Visible = false;

                //cekanje.Close();

                #region datagrid kreiranje i punjenje

                l_MatchType.Text = mec.status == "finished" ? "Završen" : "U toku";
                l_MatchID.Text = matchId.ToString();

                l_BoardCount.Text = boardList.Count.ToString();

                l_Team1.Text = mec.teams.team1.name;
                l_Team2.Text = mec.teams.team2.name;

                l_BanTim1.Text = team1PlayersRemoved.Count.ToString();
                l_BanTim2.Text = team2PlayersRemoved.Count.ToString();

                double score1 = mec.teams.team1.score;
                double score2 = mec.teams.team2.score;

                l_ScoreTeam1.Text = mec.teams.team1.score.ToString();
                l_ScoreTeam2.Text = mec.teams.team2.score.ToString();

                l_Description.Text = mec.description;

                if (score1 > score2)
                {
                    l_ScoreTeam1.Font = new Font(l_ScoreTeam1.Font, FontStyle.Bold);
                }

                if (score2 > score1)
                {
                    l_ScoreTeam2.Font = new Font(l_ScoreTeam2.Font, FontStyle.Bold);
                }

                l_StartTime.Text = CommonFunctions.FromUnixTime(mec.start_time);
                l_EndTime.Text = CommonFunctions.FromUnixTime(mec.end_time);

                l_Duration.Text = Math.Round((CommonFunctions.FromUnixTimeDateTime(mec.end_time == 0 ? CommonFunctions.UnixNow() : mec.end_time) - CommonFunctions.FromUnixTimeDateTime(mec.start_time)).TotalDays, 2).ToString() + " dana";

                dgvMatch.ColumnCount = brojkolona;
                dgvMatch.Columns[0].Name = "Pocetak Meča";
                //dgvMatch.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvMatch.Columns[0].Width = 120;

                dgvMatch.Columns[1].Name = "Kraj Meča";
                //dgvMatch.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvMatch.Columns[1].Width = 120;

                dgvMatch.Columns[2].Name = "Trajanje (dana)";
                //dgvMatch.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvMatch.Columns[2].Width = 50;

                dgvMatch.Columns[3].Name = mec.teams.team1.name;
                dgvMatch.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvMatch.Columns[4].Name = "% TO";
                dgvMatch.Columns[4].Width = 35;

                dgvMatch.Columns[5].Name = "Rejting";
                //dgvMatch.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvMatch.Columns[5].Width = 70;

                dgvMatch.Columns[6].Name = "Boja";
                dgvMatch.Columns[6].Width = 35;

                dgvMatch.Columns[7].Name = "TO";
                dgvMatch.Columns[7].Width = 35;
                //dgvMatch.Columns[6].DefaultCellStyle.ForeColor = Color.Gray;

                dgvMatch.Columns[8].Name = ""; // score bijeli
                dgvMatch.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvMatch.Columns[8].Width = 20;

                dgvMatch.Columns[9].Name = ""; // score crni
                dgvMatch.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvMatch.Columns[9].Width = 20;

                dgvMatch.Columns[10].Name = "TO";
                dgvMatch.Columns[10].Width = 35;
                //dgvMatch.Columns[9].DefaultCellStyle.ForeColor = Color.Gray;

                dgvMatch.Columns[11].Name = "Boja";
                dgvMatch.Columns[11].Width = 35;

                dgvMatch.Columns[12].Name = "Rejting";
                //dgvMatch.Columns[12].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgvMatch.Columns[12].Width = 70;

                dgvMatch.Columns[13].Name = "% TO";
                dgvMatch.Columns[13].Width = 35;

                dgvMatch.Columns[14].Name = mec.teams.team2.name;
                dgvMatch.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvMatch.Columns[15].Name = "Tabla";
                dgvMatch.Columns[15].Width = 35;

                dgvMatch.Columns[16].Name = "Još se igra";
                dgvMatch.Columns[16].Width = 35;

                dgvMatch.Columns[17].Name = "Ban. Tim 1";
                dgvMatch.Columns[17].Width = 35;

                dgvMatch.Columns[18].Name = "Ban. Tim 2";
                dgvMatch.Columns[18].Width = 35;

                dgvMatch.Columns[19].Name = "ECO";
                dgvMatch.Columns[19].Width = 30;

                dgvMatch.Columns[20].Name = "URL";
                dgvMatch.Columns[20].Visible = false;

                dgvMatch.Columns[21].Name = "Status T1";
                dgvMatch.Columns[21].Visible = true;

                dgvMatch.Columns[22].Name = "Status T2";
                dgvMatch.Columns[22].Visible = true;

                int ToTim1 = 0;
                int ToTim2 = 0;

                foreach (var item in boardList)
                {
                    if (item.t1_played_as_white == "timeout" || item.t1_played_as_black == "timeout")
                    {
                        ToTim1++;
                    }
                    if (item.t2_played_as_white == "timeout" || item.t2_played_as_black == "timeout")
                    {
                        ToTim2++;
                    }

                    foreach (var game in item.tabla.games)
                    {
                        long endTime = game.end_time == 0 ? CommonFunctions.UnixNow() : game.end_time;
                        finished[0] = CommonFunctions.FromUnixTime(game.start_time);
                        finished[1] = CommonFunctions.FromUnixTime(endTime);
                        finished[2] = Math.Round((CommonFunctions.FromUnixTimeDateTime(endTime) - CommonFunctions.FromUnixTimeDateTime(game.start_time)).TotalDays, 2).ToString();
                        if (game.white.team == "team1")
                        {
                            finished[17] = team1PlayersRemoved.Contains(game.white.username.ToUpper()) ? "1" : "0";
                            finished[18] = team2PlayersRemoved.Contains(game.black.username.ToUpper()) ? "1" : "0";
                            finished[3] = game.white.username.ToString();
                            finished[4] = item.t1_timeout_percent.ToString();
                            finished[5] = game.white.rating.ToString();
                            finished[6] = "W";
                            if (game.white.username == "amuske" || game.black.username == "amuske")
                            {
                                Console.WriteLine("test");
                            }
                            if (game.white.result == "timeout")
                            {
                                finished[7] = "1";
                            }
                            else
                            {
                                finished[7] = "0";
                            }

                            if (team1PlayersRemoved.Contains(game.white.username.ToUpper()))
                            {
                                finished[8] = "0";
                                finished[9] = "1";
                            }
                            else if (team2PlayersRemoved.Contains(game.black.username.ToUpper()))
                            {
                                finished[8] = "1";
                                finished[9] = "0";
                            }
                            else
                            {
                                finished[8] = CommonFunctions.resultValue(game.white.result).ToString();
                                finished[9] = CommonFunctions.resultValue(game.black.result).ToString();
                            }

                            if (game.black.result == "timeout")
                            {
                                finished[10] = "1";
                            }
                            else
                            {
                                finished[10] = "0";
                            }

                            finished[11] = "B";
                            finished[12] = game.black.rating.ToString();
                            finished[13] = item.t2_timeout_percent.ToString();
                            finished[14] = game.black.username.ToString();
                        }
                        else
                        {
                            finished[17] = team1PlayersRemoved.Contains(game.black.username.ToUpper()) ? "1" : "0";
                            finished[18] = team2PlayersRemoved.Contains(game.white.username.ToUpper()) ? "1" : "0";
                            finished[3] = game.black.username.ToString();
                            finished[4] = item.t1_timeout_percent.ToString();
                            finished[5] = game.black.rating.ToString();
                            finished[6] = "B";

                            if (game.white.username == "amuske" || game.black.username == "amuske")
                            {
                                Console.WriteLine("test");
                            }
                            if (game.black.result == "timeout")
                            {
                                finished[7] = "1";
                            }
                            else
                            {
                                finished[7] = "0";
                            }

                            if (team1PlayersRemoved.Contains(game.black.username.ToUpper()))
                            {
                                finished[8] = "0";
                                finished[9] = "1";
                            }
                            else if (team2PlayersRemoved.Contains(game.white.username.ToUpper()))
                            {
                                finished[8] = "1";
                                finished[9] = "0";
                            }
                            else
                            {
                                finished[8] = CommonFunctions.resultValue(game.black.result).ToString();
                                finished[9] = CommonFunctions.resultValue(game.white.result).ToString();
                            }
                            if (game.white.result == "timeout")
                            {
                                finished[10] = "1";
                            }
                            else
                            {
                                finished[10] = "0";
                            }

                            finished[11] = "W";
                            finished[12] = game.white.rating.ToString();
                            finished[13] = item.t2_timeout_percent.ToString();
                            finished[14] = game.white.username.ToString();
                        }

                        finished[15] = item.board_number.ToString();
                        finished[16] = game.end_time == 0 ? "1" : "0";
                        finished[19] = game.eco != null ? game.eco.Segments.Last().Split('-')[0] : "";
                        finished[20] = game.url;

                        if (item.t1_status == "closed")
                        {
                            finished[21] = "1";
                            closed1++;
                        } else
                        {
                            finished[21] = "0";
                        }

                        if (item.t2_status == "closed")
                        {
                            finished[22] = "1";
                            closed2++;
                        }
                        else
                        {
                            finished[22] = "0";
                        }
                        dgvMatch.Rows.Add(finished);
                    }
                }
                dgvMatch.DataBindingComplete += (o, _) =>
                {
                    var dataGridView = o as DataGridView;
                    if (dataGridView != null)
                    {
                        dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                        dataGridView.Columns[dataGridView.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                };

                dgvMatch.Sort(dgvMatch.Columns[15], ListSortDirection.Ascending);

                l_TimedOutCount1.Text = ToTim1.ToString();
                l_TimedOutCount2.Text = ToTim2.ToString();
                l_Closed1.Text = (closed1/2).ToString(); // jer broji dva puta za jednog igrača
                l_Closed2.Text = (closed2/2).ToString();

                watch.Stop();
                var elapsedMs = watch.ElapsedMilliseconds;

                tsl_Time.Text = "Prikaz generisan za: " + (elapsedMs / 1000).ToString() + "s";
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Desila se greška kod pregleda meča, provjerite ID meča i pokušajte ponovo!" + ex.StackTrace + Environment.NewLine + ex.Message);
                this.Close();
            }

        }

        private void DoWork(IProgress<int> progress)
        {

            team1PlayersRemoved = new List<string>();
            team2PlayersRemoved = new List<string>();

            foreach (var item in mec.teams.team1.fair_play_removals)
            {
                team1PlayersRemoved.Add(item.ToUpper());
            }

            foreach (var item in mec.teams.team2.fair_play_removals)
            {
                team2PlayersRemoved.Add(item.ToUpper());
            }

            var team1 = from t in mec.teams.team1.players
                        select t;

            var team2 = from t in mec.teams.team2.players
                        select t;

            var boards = from t1 in team1
                         join t2 in team2 on t1.board equals t2.board
                         orderby t1.board
                         select new
                         {
                             t1_username = t1.username,
                             t1_status = t1.status,
                             t1_played_as_white = t1.played_as_white,
                             t1_played_as_black = t1.played_as_black,
                             t1_timeout_percent = t1.timeout_percent,
                             t2_username = t2.username,
                             t2_status = t2.status,
                             t2_played_as_white = t2.played_as_white,
                             t2_played_as_black = t2.played_as_black,
                             t2_timeout_percent = t2.timeout_percent,
                             board_url = t1.board,
                             board_number = int.Parse(CommonFunctions.getLastPart(t1.board))
                         };
            boardList = new List<Tabla>();
            dynamic Tabla = new ExpandoObject();

            var tabele = new List<dynamic>();

            int i = 1;
            foreach (var board in boards)
            {
                Tabla tt = new Tabla()
                {
                    t1_username = board.t1_username,
                    t1_played_as_black = board.t1_played_as_black,
                    t1_played_as_white = board.t1_played_as_white,
                    t1_status = board.t1_status,
                    t1_timeout_percent = board.t1_timeout_percent,
                    t2_played_as_black = board.t2_played_as_black,
                    t2_played_as_white = board.t2_played_as_white,
                    t2_status = board.t2_status,
                    t2_username = board.t2_username,
                    t2_timeout_percent = board.t2_timeout_percent,
                    board_url = board.board_url,
                    board_number = board.board_number
                };

                if (board.t1_played_as_white == null || board.t1_played_as_black == null)
                {
                    GameInProgress.Board bb = api.GetBoard<GameInProgress.Board>(board.board_url);
                    List<Game> games = new List<Game>();
                    foreach (var g in bb.games)
                    {
                        Game game1 = new Game();
                        Color w = new Color();
                        Color b = new Color();
                        if (g.white is string)
                        {
                            string username = CommonFunctions.getLastPart(g.white.ToString());
                            w.username = username;
                            w.result = "-"; // ako ga nema da stavi prazno za skor
                            w.status = "basic";
                            g.white = w;
                        }
                        else
                        {
                            w = CommonFunctions.getDeserializedObject<Color>(g.white);
                            g.white = b;
                        }

                        if (g.black is string)
                        {
                            string username = CommonFunctions.getLastPart(g.black.ToString());
                            b.username = username;
                            b.result = "-"; // isto i za crnog
                            b.status = "basic";
                            g.black = w;
                        }
                        else
                        {
                            b = CommonFunctions.getDeserializedObject<Color>(g.black);
                            g.black = b;
                        }

                        game1.start_time = g.start_time;
                        game1.end_time = g.end_time;
                        game1.url = g.url;
                        game1.white = w;
                        game1.black = b;

                        if (board.t1_username.ToUpper() == game1.black.username.ToUpper() && board.t2_username.ToUpper() == game1.white.username.ToUpper())
                        {
                            game1.black.team = "team1";
                            game1.white.team = "team2";
                        }
                        else
                        {
                            game1.black.team = "team2";
                            game1.white.team = "team1";
                        }

                        games.Add(game1);
                    }
                    tt.tabla = new Board() { games = games };
                }
                else
                {
                    Board b = api.GetBoard<Board>(board.board_url);
                    foreach (var item in b.games)
                    {
                        if (board.t1_username.ToUpper() == item.black.username.ToUpper() && board.t2_username.ToUpper() == item.white.username.ToUpper())
                        {
                            item.black.team = "team1";
                            item.white.team = "team2";
                        }
                        else
                        {
                            item.black.team = "team2";
                            item.white.team = "team1";
                        }
                    }
                    tt.tabla = b;
                }

                boardList.Add(tt);
                l_DisplayCount.Text = i.ToString() + "/" + mec.boards;
                progress.Report(i++);
            }
        }

        private void dgvMatch_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CommonFunctions.showRightMenu(sender, e);
        }

        private void dgvMatch_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CommonFunctions.viewPlayer(sender, 3, 14);
        }

        private void btn_GamePreview_Click(object sender, EventArgs e)
        {
            string boardUrl = dgvMatch.CurrentRow.Cells[20].Value.ToString();
            System.Diagnostics.Process.Start(boardUrl);
        }
    }
}
