using Newtonsoft.Json;

namespace Account_Manager.DTO
{
    public class SummonerDTO
    {
        public class SummonerDTOResponse
        {
            [JsonProperty("id")]
            public string Id { get; set; }
            [JsonProperty("revisionDate")]
            public long RevisionDate { get; set; }
        }
    }
}
