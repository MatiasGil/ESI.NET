using Newtonsoft.Json;

namespace ESI.NET.Models.Market
{
    public class Group
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("market_group_id")]
        public int MarketGroupId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parent_group_id")]
        public int ParentGroupId { get; set; }

        [JsonProperty("types")]
        public int[] Types { get; set; }
    }
}