using Newtonsoft.Json;

namespace ESI.NET.Models.Universe
{
    public class Region
    {
        [JsonProperty("constellations")]
        public int[] Constellations { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("region_id")]
        public int RegionId { get; set; }
    }
}