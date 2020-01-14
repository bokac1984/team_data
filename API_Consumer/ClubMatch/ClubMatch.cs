using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace API_Consumer.ClubMatch
{

    public class ClubMatch
    {
        [JsonProperty("@id")]
        public string Id { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public int start_time { get; set; }
        public int end_time { get; set; }
        public string status { get; set; }
        public int boards { get; set; }
        public Settings settings { get; set; }
        public Teams teams { get; set; }

        public string description { get; set; }
    }

    public class Settings
    {
        public string rules { get; set; }
        public string time_class { get; set; }
        public string time_control { get; set; }
        public int min_team_players { get; set; }
        public int min_required_games { get; set; }
        public bool autostart { get; set; }
    }

    public class Player
    {
        public string username { get; set; }
        public string stats { get; set; }
        public double timeout_percent { get; set; }
        public string status { get; set; }
        public string played_as_white { get; set; }
        public string played_as_black { get; set; }
        public string board { get; set; }
        public Board tabla { get; set; }
        public GameInProgress.Board game_in_progres { get; set; }
    }

    public class Team
    {
        public string ID { get; set; }
        public string name { get; set; }
        public string url { get; set; }
        public double score { get; set; }
        public List<Player> players { get; set; }
        public List<string> fair_play_removals { get; set; }
    }

    public class Teams
    {
        public Team team1 { get; set; }
        public Team team2 { get; set; }
    }

    /// <summary>
    /// Pojedinačna tabla ili ti ga partija na jednoj tabli
    /// </summary>
    public class Board
    {
        public List<Game> games { get; set; }
        public string url { get; set; }
        public BoardScores board_scores { get; set; }
    }

    public partial class BoardScores
    {
        public Score PlayerScore { get; set; }
    }

    public class Score
    {
        [JsonConverter(typeof(PlayerNameConverter))]
        public string playerName { get; set; }

        [JsonConverter(typeof(PlayerScoreConverter))]
        public float score { get; set; }
    }

    public class PlayerScoreConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var obj = JObject.Load(reader);
            IDictionary<string, JToken> json = obj;
            var item = json.First();
            Console.WriteLine("prošao ovdje");
            return item.Value;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }

    public class PlayerNameConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var obj = JObject.Load(reader);
            IDictionary<string, JToken> json = obj;
            var item = json.First();
            return item.Key;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }


    public class Color
    {
        [JsonProperty("@id")]
        public string Id { get; set; }
        public int rating { get; set; }
        public string result { get; set; }
        public string username { get; set; }
        public string team { get; set; }
        public string status { get; set; }
        public double timeout_percent { get; set; }
    }

    public class Game
    {
        public string url { get; set; }
        public string pgn { get; set; }
        public string time_control { get; set; }
        public int end_time { get; set; }
        public bool rated { get; set; }
        public string fen { get; set; }
        public int start_time { get; set; }
        public string time_class { get; set; }
        public string rules { get; set; }
        public Color white { get; set; }
        public Color black { get; set; }
        public string match { get; set; }
        public int board_number { get; set; }
        public Uri eco { get; set; }
    }


    public class Tabla
    {
        public string t1_username { get; set; }
        public string t1_stats { get; set; }
        public double t1_timeout_percent { get; set; }
        public string t1_status { get; set; }
        public string t1_played_as_white { get; set; }
        public string t1_played_as_black { get; set; }
        public string t2_username { get; set; }
        public string t2_stats { get; set; }
        public double t2_timeout_percent { get; set; }
        public string t2_status { get; set; }
        public string t2_played_as_white { get; set; }
        public string t2_played_as_black { get; set; }
        public string board_url { get; set; }
        public int board_number { get; set; }
        public Board tabla { get; set; }
        //public GameInProgress.Board game_in_progres { get; set; }
    }
}
