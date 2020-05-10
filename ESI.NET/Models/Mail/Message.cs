using Newtonsoft.Json;
using System.Collections.Generic;

namespace ESI.NET.Models.Mail
{
    public class Message
    {
        [JsonProperty("body")]
        public string Body { get; set; }

        [JsonProperty("from")]
        public int From { get; set; }

        [JsonProperty("labels")]
        public long[] Labels { get; set; }

        [JsonProperty("read")]
        public bool Read { get; set; }

        [JsonProperty("recipients")]
        public List<Recipient> Recipients { get; set; } = new List<Recipient>();

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }

    public class Recipient
    {
        [JsonProperty("recipient_id")]
        public int RecipientId { get; set; }

        [JsonProperty("recipient_type")]
        public string RecipientType { get; set; }
    }
}