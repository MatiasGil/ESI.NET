using Newtonsoft.Json;

namespace ESI.NET.Models.Universe
{
    public class Race
    {
        [JsonProperty("alliance_id")]
        public int AllianceId { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("race_id")]
        public int RaceId { get; set; }
    }
}