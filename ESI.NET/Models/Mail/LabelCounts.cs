using Newtonsoft.Json;
using System.Collections.Generic;

namespace ESI.NET.Models.Mail
{
    public class Label
    {
        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("label_id")]
        public int LabelId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("unread_count")]
        public int UnreadCount { get; set; }
    }

    public class LabelCounts
    {
        [JsonProperty("labels")]
        public List<Label> Labels { get; set; } = new List<Label>();

        [JsonProperty("total_unread_count")]
        public int TotalUnreadCount { get; set; }
    }
}