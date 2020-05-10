using Newtonsoft.Json;

namespace ESI.NET.Models.Universe
{
    public class Group
    {
        [JsonProperty("category_id")]
        public int CategoryId { get; set; }

        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("published")]
        public bool Published { get; set; }

        [JsonProperty("types")]
        public int[] Types { get; set; }
    }
}