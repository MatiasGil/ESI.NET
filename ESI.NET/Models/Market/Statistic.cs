using Newtonsoft.Json;
using System;

namespace ESI.NET.Models.Market
{
    public class Statistic
    {
        [JsonProperty("average")]
        public decimal Average { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("highest")]
        public decimal Highest { get; set; }

        [JsonProperty("lowest")]
        public decimal Lowest { get; set; }

        [JsonProperty("order_count")]
        public long OrderCount { get; set; }

        [JsonProperty("volume")]
        public long Volume { get; set; }
    }
}