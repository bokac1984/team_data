using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace API_Consumer.Clubs
{
    public class Matches
    {
        public List<Finished> finished { get; set; }
        public List<InProgress> in_progress { get; set; }
        public List<Registered> registered { get; set; }
    }
    public class Finished : IMatchType
    {
        [JsonProperty("@id")]
        public string Id { get; set; }
        public string name { get; set; }
        public string opponent { get; set; }
        public int start_time { get; set; }
        public string result { get; set; }
    }

    public class InProgress : IMatchType
    {
        public string name { get; set; }
        [JsonProperty("@id")]
        public string Id { get; set; }
        public string opponent { get; set; }
        public int start_time { get; set; }
        public string result { get; set; }
    }

    public class Registered : IMatchType
    {
        public string name { get; set; }
        [JsonProperty("@id")]
        public string Id { get; set; }
        public string opponent { get; set; }
        public int start_time { get; set; }
        public string result { get; set ; }
    }


}
