using RestSharp;
using static Account_Manager.DTO.SummonerDTO;
using static Account_Manager.API_KEYS.API_Keys;

namespace Account_Manager.Services
{
    public class SummonerService
    {
        static string apiRequest = "https://euw1.api.riotgames.com/lol/summoner/v4/summoners/";
        RestClient client = new RestClient(apiRequest);
        public SummonerDTOResponse GetSummonerDTO(string SummonerName)
        {
            var request = new RestRequest("by-name/{summonerName}")
                .AddParameter("summonerName", SummonerName, ParameterType.UrlSegment)
                .AddParameter("api_key", RiotGamesAPI);
            var response = client.Execute<SummonerDTOResponse>(request);

            if (!response.IsSuccessful)
            {
                return default;
            }
            return response.Data;
        }
    }
}
