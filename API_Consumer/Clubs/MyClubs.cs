namespace API_Consumer.Clubs
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    [Serializable]
    public partial class ClubInfo
    {
        [JsonProperty("@id")]
        public Uri Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("club_id")]
        public long ClubId { get; set; }

        [JsonProperty("country")]
        public Uri Country { get; set; }

        [JsonProperty("average_daily_rating")]
        public long AverageDailyRating { get; set; }

        [JsonProperty("members_count")]
        public long MembersCount { get; set; }

        [JsonProperty("created")]
        public long Created { get; set; }

        [JsonProperty("last_activity")]
        public long LastActivity { get; set; }

        [JsonProperty("admin")]
        public List<Uri> Admin { get; set; }

        [JsonProperty("visibility")]
        public string Visibility { get; set; }

        [JsonProperty("join_request")]
        public Uri JoinRequest { get; set; }

        [JsonProperty("icon")]
        public Uri Icon { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    [Serializable]
    public partial class MyClubs
    {
        public List<ClubInfo> Clubs { get; set; }
    }
}
