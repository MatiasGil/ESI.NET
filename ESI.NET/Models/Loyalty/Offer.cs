using Newtonsoft.Json;
using System.Collections.Generic;

namespace ESI.NET.Models.Loyalty
{
    public class Item
    {
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("type_id")]
        public int TypeId { get; set; }
    }

    public class Offer
    {
        [JsonProperty("ak_cost")]
        public int AkCost { get; set; }

        [JsonProperty("isk_cost")]
        public long IskCost { get; set; }

        [JsonProperty("lp_cost")]
        public int LpCost { get; set; }

        [JsonProperty("offer_id")]
        public int OfferId { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("required_items")]
        public List<Item> RequiredItems { get; set; } = new List<Item>();

        [JsonProperty("type_id")]
        public int TypeId { get; set; }
    }
}