using Newtonsoft.Json;
using System;

namespace ESI.NET.Models.Opportunities
{
    public class CompletedTask
    {
        [JsonProperty("completed_at")]
        public DateTime CompletedAt { get; set; }

        [JsonProperty("task_id")]
        public int TaskId { get; set; }
    }
}