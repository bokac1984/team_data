using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace API_Consumer.Clubs
{
    public class ClubObjekt
    {
        [JsonProperty("@id")]
        public string Id { get; set; }
        public string club_id { get; set; }
        public string name { get; set; }
        public string location { get; set; }
        public int average_daily_rating { get; set; }
        public int members_count { get; set; }
        public string created { get; set; }
        public string last_activity { get; set; }
        public string visibility { get; set; }
        public string icon { get; set; }
        public string description { get; set; }
    }
}
