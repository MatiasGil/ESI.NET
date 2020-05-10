using Newtonsoft.Json;
using System.Collections.Generic;

namespace ESI.NET.Models.Insurance
{
    public class Insurance
    {
        [JsonProperty("levels")]
        public List<Levels> Levels { get; set; } = new List<Levels>();

        [JsonProperty("type_id")]
        public int TypeID { get; set; }
    }

    public class Levels
    {
        [JsonProperty("cost")]
        public double Cost { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("payout")]
        public double Payout { get; set; }
    }
}