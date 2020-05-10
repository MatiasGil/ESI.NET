using Newtonsoft.Json;

namespace ESI.NET.Models.FactionWarfare
{
    public class War
    {
        [JsonProperty("against_id")]
        public int AgainstId { get; set; }

        [JsonProperty("faction_id")]
        public int FactionId { get; set; }
    }
}