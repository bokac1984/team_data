using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Consumer.ClubMatch
{
    public class GameInProgress
    {
        public class Game
        {
            public string url { get; set; }
            public int move_by { get; set; }
            public string pgn { get; set; }
            public string time_control { get; set; }
            public int last_activity { get; set; }
            public bool rated { get; set; }
            public string turn { get; set; }
            public string fen { get; set; }
            public int start_time { get; set; }
            public int end_time { get; set; }
            public string time_class { get; set; }
            public string rules { get; set; }
            public object white { get; set; }
            public object black { get; set; }
            public string match { get; set; }
        }
        /// <summary>
        /// 
        /// Samo za mečeve u toku
        /// </summary>
        public class Board
        {
            public List<Game> games { get; set; }
        }
    }
}
