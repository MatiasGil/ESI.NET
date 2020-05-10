using Newtonsoft.Json;

namespace ESI.NET.Models.Opportunities
{
    public class Task
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("notification")]
        public string Notification { get; set; }

        [JsonProperty("task_id")]
        public int TaskId { get; set; }
    }
}