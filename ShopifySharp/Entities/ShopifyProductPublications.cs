using Newtonsoft.Json;

namespace ShopifySharp
{
    /// <summary>
    /// 
    /// </summary>
    public class ShopifyProductPublications : ShopifyObject
    {
        /// <summary>
        /// State the published status for this channel
        /// </summary>
        [JsonProperty("published")]
        public bool? Published { get; set; }

        /// <summary>
        /// The unique numeric identifier for the product channel.
        /// </summary>
        [JsonProperty("channel_id")]
        public long? ChannelId { get; set; }
    }
}
