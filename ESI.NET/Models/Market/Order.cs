using Newtonsoft.Json;
using System;

namespace ESI.NET.Models.Market
{
    public class Order
    {
        /// <summary>
        /// Only returned in /characters/{character_id}/orders/
        /// </summary>
        [JsonProperty("account_id")]
        public int AccountId { get; set; }

        [JsonProperty("duration")]
        public int Duration { get; set; }

        /// <summary>
        /// Returned in /characters/{character_id}/orders/ and /corporations/{corporation_id}/orders/
        /// </summary>
        [JsonProperty("escrow")]
        public decimal Escrow { get; set; }

        [JsonProperty("is_buy_order")]
        public bool IsBuyOrder { get; set; }

        /// <summary>
        /// Only returned in /characters/{character_id}/orders/
        /// </summary>
        [JsonProperty("is_corp")]
        public bool IsCorp { get; set; }

        /// <summary>
        /// Only returned in /characters/{character_id}/orders/history/
        /// </summary>
        [JsonProperty("is_corporation")]
        public bool IsCorporation { get; set; }

        [JsonProperty("issued")]
        public DateTime Issued { get; set; }

        [JsonProperty("location_id")]
        public long LocationId { get; set; }

        [JsonProperty("min_volume")]
        public int MinVolume { get; set; }

        [JsonProperty("order_id")]
        public long OrderId { get; set; }

        [JsonProperty("price")]
        public decimal Price { get; set; }

        [JsonProperty("range")]
        public string Range { get; set; }

        /// <summary>
        /// Only returned in /characters/{character_id}/orders/
        /// </summary>
        [JsonProperty("region_id")]
        public int RegionId { get; set; }

        /// <summary>
        /// Returned in /characters/{character_id}/orders/ and /corporations/{corporation_id}/orders/
        /// </summary>
        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("type_id")]
        public int TypeId { get; set; }

        [JsonProperty("volume_remain")]
        public int VolumeRemain { get; set; }

        [JsonProperty("volume_total")]
        public int VolumeTotal { get; set; }

        /// <summary>
        /// Only returned in /corporations/{corporation_id}/orders/
        /// </summary>
        [JsonProperty("wallet_division")]
        public int WalletDivision { get; set; }
    }
}