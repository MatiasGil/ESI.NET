using Newtonsoft.Json;
using System.Collections.Generic;

namespace ESI.NET.Models.FactionWarfare
{
    public class CharacterTotal
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("character_id")]
        public int CharacterId { get; set; }
    }

    public class CorporationTotal
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("corporation_id")]
        public int CorporationId { get; set; }
    }

    public class FactionTotal
    {
        [JsonProperty("amount")]
        public int Amount { get; set; }

        [JsonProperty("faction_id")]
        public int FactionId { get; set; }
    }

    public class Leaderboards<T>
    {
        [JsonProperty("kills")]
        public Summary<T> Kills { get; set; }

        [JsonProperty("victory_points")]
        public Summary<T> VictoryPoints { get; set; }
    }

    public class Summary<T>
    {
        [JsonProperty("active_total")]
        public List<T> ActiveTotal { get; set; } = new List<T>();

        [JsonProperty("last_week")]
        public List<T> LastWeek { get; set; } = new List<T>();

        [JsonProperty("yesterday")]
        public List<T> Yesterday { get; set; } = new List<T>();
    }
}