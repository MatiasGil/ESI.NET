using Newtonsoft.Json;

namespace ESI.NET.Models.Bookmarks
{
    public class Folder
    {
        /// <summary>
        /// Not returned in /characters/{character_id}/bookmarks/
        /// </summary>
        [JsonProperty("creator_id")]
        public int CreatorId { get; set; }

        [JsonProperty("folder_id")]
        public int FolderId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}