using Newtonsoft.Json;
using System;

namespace Player
{
    public partial class PlayerInfo
    {
        public Uri Avatar { get; set; }
        public long PlayerId { get; set; }
        public Uri Id { get; set; }
        public Uri Url { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public long Followers { get; set; }
        public Uri Country { get; set; }
        public string Location { get; set; }

        [JsonProperty("last_online", Required = Required.Always)]
        public long LastOnline { get; set; }
        public long Joined { get; set; }
        public string Status { get; set; }
        public bool IsStreamer { get; set; }
    }
}
