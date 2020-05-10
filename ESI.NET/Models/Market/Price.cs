using Newtonsoft.Json;

namespace ESI.NET.Models.Market
{
    public class Price
    {
        [JsonProperty("adjusted_price")]
        public decimal AdjustedPrice { get; set; }

        [JsonProperty("average_price")]
        public decimal AveragePrice { get; set; }

        [JsonProperty("type_id")]
        public int TypeId { get; set; }
    }
}