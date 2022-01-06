using System.ComponentModel;
using Newtonsoft.Json;

namespace Account_Manager.ViewModels
{
    public class AllRanksViewModel : INotifyPropertyChanged
    {
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
        [JsonProperty("queueType")]
        public string QueueType { get; set; }
        [JsonProperty("summonerName")]
        public string SummonerName { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
