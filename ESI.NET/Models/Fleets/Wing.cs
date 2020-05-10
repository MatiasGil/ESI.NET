using Newtonsoft.Json;
using System.Collections.Generic;

namespace ESI.NET.Models.Fleets
{
    public class Squad
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Wing
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("squads")]
        public List<Squad> Squads { get; set; } = new List<Squad>();
    }
}