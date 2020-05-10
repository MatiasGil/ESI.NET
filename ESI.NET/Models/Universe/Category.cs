using Newtonsoft.Json;

namespace ESI.NET.Models.Universe
{
    public class Category
    {
        [JsonProperty("groups")]
        public long[] Groups { get; set; }

        [JsonProperty("category_id")]
        public long Id { get; set; }

        [JsonProperty("published")]
        public bool IsPublished { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}