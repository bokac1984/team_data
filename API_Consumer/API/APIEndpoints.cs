using API_Consumer.ClubMatch.Registrations;
using API_Consumer.Clubs;
using System;
using System.Collections.Generic;
using API_Consumer.ClubMatch;
using Player;

namespace API_Consumer.API
{
    /// <summary>
    /// Represents class for communication with chess.com API
    /// </summary>
    public class APIEndPoints
    {
        private string _ApiEndPoint;

        public APIEndPoints(string ApiEPoint)
        {
            _ApiEndPoint = ApiEPoint;
        }

        public Activity getPlayerActivity(string clubName)
        {
            string memberUrl = _ApiEndPoint + "club/" + clubName + "/members";

            return GetData.getApiData<Activity>(memberUrl);
        }

        public Registrations getClubOpenRegistrations(string matchId)
        {
            string url = _ApiEndPoint + "match/" + matchId;
            return GetData.getApiData<Registrations>(url);
        }

        public ClubObjekt GetClubObjekt(string ClubName)
        {
            string clubUrl = _ApiEndPoint + "club/" + ClubName;
            return GetData.getApiData<ClubObjekt>(clubUrl);
        }

        public Matches GetMatches(string ClubName)
        {
            string MatchUrl = _ApiEndPoint + "club/" + ClubName + "/matches";
            return GetData.getApiData<Matches>(MatchUrl);
        }

        public ClubMatch.ClubMatch GetClubMatch(string matchId, bool isLive)
        {
            string url = _ApiEndPoint + "match/" + matchId;
            return GetData.getApiData<ClubMatch.ClubMatch>(url);
        }


        public T GetBoard<T>(string boardUrl)
        {
            return GetData.getApiData<T>(boardUrl);
        }

        public PlayerInfo GetPlayerInfo(string playerName)
        {
            string urlInfo = _ApiEndPoint + "player/" + playerName;
            return GetData.getApiData<PlayerInfo>(urlInfo);
        }

        public PlayerStats GetPlayerStats(string playerName)
        {
            string urlStats = _ApiEndPoint + "player/" + playerName + "/stats";
            return GetData.getApiData<PlayerStats>(urlStats);
        }

        public Notices GetNoticesForPlayer(string username)
        {
            string memberUrl = "https://api.chess.com/int/player/" + username + "/notices";

            return GetData.getApiData<Notices>(memberUrl);
        }
    }
}
