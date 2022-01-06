using RestSharp;
using System.Collections.Generic;
using static Account_Manager.DTO.LeagueEntryDTO;
using static Account_Manager.API_KEYS.API_Keys;

namespace Account_Manager.Services
{
    public class LeagueEntryService
    {
        static string apiRequest = "https://euw1.api.riotgames.com/lol/league/v4/entries/";
        RestClient client = new RestClient(apiRequest);
        public List<AllRanks> GetLeagueEntryDTO(string SummonerName)
        {
            var request = new RestRequest("by-summoner/{encryptedSummonerId}")
                .AddParameter("encryptedSummonerId", SummonerName, ParameterType.UrlSegment)
                .AddParameter("api_key", RiotGamesAPI);

            var response = client.Execute<List<AllRanks>>(request);

            if (!response.IsSuccessful)
            {
                return null;
            }
            return response.Data;
        }
        public class LeagueEntryDTOResponse
        {
            public ICollection<AllRanks> Ranks { get; set; }
        }
    }
}


