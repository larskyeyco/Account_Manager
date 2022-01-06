using Newtonsoft.Json;

namespace Account_Manager.DTO
{
    public class LeagueEntryDTO
    {
        public class AllRanks
        {
            [JsonProperty("queueType")]
            public string QueueType { get; set; }
            [JsonProperty("tier")]
            public string Tier { get; set; }
            [JsonProperty("rank")]
            public string Rank { get; set; }
            [JsonProperty("leaguePoints")]
            public int LeaguePoints { get; set; }
            [JsonProperty("wins")]
            public int Wins { get; set; }
            [JsonProperty("losses")]
            public int Losses { get; set; }
            [JsonProperty("summonerName")]
            public string SummonerName { get; set; }
        }
    }
}
