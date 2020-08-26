namespace API_Consumer.ClubMatch.Registrations
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class Registrations
    {
        [JsonProperty("@id")]
        public Uri Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("start_time")]
        public long StartTime { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("boards")]
        public long Boards { get; set; }

        [JsonProperty("settings")]
        public Settings Settings { get; set; }

        [JsonProperty("teams")]
        public Teams Teams { get; set; }
    }

    public partial class Settings
    {
        [JsonProperty("rules")]
        public string Rules { get; set; }

        [JsonProperty("time_class")]
        public string TimeClass { get; set; }

        [JsonProperty("time_control")]
        public string TimeControl { get; set; }

        [JsonProperty("min_team_players")]
        public long MinTeamPlayers { get; set; }

        [JsonProperty("min_required_games")]
        public long MinRequiredGames { get; set; }

        [JsonProperty("autostart")]
        public bool Autostart { get; set; }
    }

    public partial class Teams
    {
        [JsonProperty("team1")]
        public Team Team1 { get; set; }

        [JsonProperty("team2")]
        public Team Team2 { get; set; }
    }

    public partial class Team
    {
        [JsonProperty("@id")]
        public Uri Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("score")]
        public long Score { get; set; }

        [JsonProperty("players")]
        public List<Player> Players { get; set; }

        [JsonProperty("fair_play_removals")]
        public List<object> FairPlayRemovals { get; set; }

        [JsonProperty("locked")]
        public bool Locked { get; set; }
    }

    public partial class Player
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("rating")]
        public long Rating { get; set; }

        [JsonProperty("timeout_percent")]
        public double TimeoutPercent { get; set; }

        [JsonProperty("rd")]
        public double Rd { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }
    }

    public enum Status { Basic, Premium, Staff, Closed, ClosedFairPlay };

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                StatusConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class StatusConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Status) || t == typeof(Status?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "basic":
                    return Status.Basic;
                case "premium":
                    return Status.Premium;
                case "staff":
                    return Status.Premium;
                case "closed":
                    return Status.Closed;
                case "closed:fair_play_violations":
                    return Status.ClosedFairPlay;
            }
            throw new Exception("Cannot unmarshal type Status");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Status)untypedValue;
            switch (value)
            {
                case Status.Basic:
                    serializer.Serialize(writer, "basic");
                    return;
                case Status.Premium:
                    serializer.Serialize(writer, "premium");
                    return;
                case Status.Staff:
                    serializer.Serialize(writer, "staff");
                    return;
                case Status.Closed:
                    serializer.Serialize(writer, "closed");
                    return;
                case Status.ClosedFairPlay:
                    serializer.Serialize(writer, "closed:fair_play_violations");
                    return;
            }
            throw new Exception("Cannot marshal type Status");
        }

        public static readonly StatusConverter Singleton = new StatusConverter();
    }
}
