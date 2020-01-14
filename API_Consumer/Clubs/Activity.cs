namespace API_Consumer.Clubs
{
    using System;
    using System.Collections.Generic;

    using Newtonsoft.Json;


    public partial class Activity
    {
        [JsonProperty("weekly")]
        public List<Member> Weekly { get; set; }

        [JsonProperty("monthly")]
        public List<Member> Monthly { get; set; }

        [JsonProperty("all_time")]
        public List<Member> AllTime { get; set; }
    }

    public partial class Member
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("joined")]
        public long Joined { get; set; }

        public long Notifications { get; set; }

        public long NewMessages { get; set; }

        public long GamesToMove { get; set; }

        public long ChallengeWaiting { get; set; }

        public override int GetHashCode()
        {
            return (this.Joined == null ? 0 : this.Joined.GetHashCode())
               ^ (this.Username == null ? 0 : this.Username.GetHashCode());
        }
        public override bool Equals(object obj)
        {
            if (Object.ReferenceEquals(this, obj))
                return true;

            Member other = obj as Member;
            if (Object.ReferenceEquals(other, null))
                return false;

            return String.Equals(other.Joined, this.Joined)
                && String.Equals(other.Username, this.Username);
        }
    }

    public partial class Notices
    {
        [JsonProperty("notifications")]
        public long Notifications { get; set; }

        [JsonProperty("new_messages")]
        public long NewMessages { get; set; }

        [JsonProperty("games_to_move")]
        public long GamesToMove { get; set; }

        [JsonProperty("challenge_waiting")]
        public long ChallengeWaiting { get; set; }
    }

}