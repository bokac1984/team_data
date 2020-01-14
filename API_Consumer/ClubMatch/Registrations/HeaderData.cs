using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_Consumer.ClubMatch.Registrations
{
    public class HeaderData
    {
        public string MatchId { get; set; }

        public string Name { get; set; }

        public string StartTime { get; set; }

        public string BoardCount { get; set; }

        public string Description { get; set; }

        public string Team1Name { get; set; }

        public string Team2Name { get; set; }

        public string AutoStart { get; set; }

        public string Tempo { get; set; }

        public string MinGames { get; set; }

        public string MinPlayers { get; set; }

        public string MatchType { get; set; }
        public bool WL { get; set; }
        public bool EL { get; set; }
    }
}
