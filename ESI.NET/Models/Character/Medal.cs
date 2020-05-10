using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ESI.NET.Models.Character
{
    public class GraphicLayer
    {
        [JsonProperty("color")]
        public int Color { get; set; }

        [JsonProperty("graphic")]
        public string Graphic { get; set; }

        [JsonProperty("layer")]
        public int Layer { get; set; }

        [JsonProperty("part")]
        public int Part { get; set; }
    }

    public class Medal
    {
        [JsonProperty("corporation_id")]
        public long CorporationId { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("graphics")]
        public List<GraphicLayer> Graphics { get; set; } = new List<GraphicLayer>();

        [JsonProperty("medal_id")]
        public long Id { get; set; }

        [JsonProperty("issuer_id")]
        public long IssuerId { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }
    }
}