using Newtonsoft.Json;
using System;

namespace ESI.NET.Models.Contracts
{
    public class Bid
    {
        [JsonProperty("amount")]
        public decimal Amount { get; set; }

        [JsonProperty("bidder_id")]
        public int BidderId { get; set; }

        [JsonProperty("bid_id")]
        public int BidId { get; set; }

        [JsonProperty("date_bid")]
        public DateTime DateBid { get; set; }
    }
}