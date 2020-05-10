using Newtonsoft.Json;

namespace ESI.NET.Models.Wallet
{
    public class Wallet
    {
        [JsonProperty("balance")]
        public decimal Balance { get; set; }

        [JsonProperty("division")]
        public int Division { get; set; }
    }
}