using Newtonsoft.Json;
using ShopifySharp.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopifySharp
{
    public class CheckoutLineItem : LineItem
    {
        /// <summary>
        /// The key for the line item.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }

        /// <summary>
        /// The unique numeric identifier for the product in the fulfillment. Can be null if the original product associated with the order is deleted at a later date
        /// </summary>
        [JsonProperty("origin_location_id")]
        public long? OriginLocationId { get; set; }

        /// <summary>
        /// The object's unique id.
        /// </summary>
        /// <remarks>
        /// The CheckoutLineItem seem is using string instead of interger/long.
        /// </remarks>
        [JsonProperty("id")]
        public new string Id { get; set; }

        /// <summary>
        /// An array of custom information for an item that has been added to the cart.
        /// Often used to provide product customization options.
        /// An array of <see cref="TaxLine"/> objects, each of which details the taxes applicable to this <see cref="LineItem"/>.
        /// </summary>
        [JsonProperty("properties")]
        public new Dictionary<string, string> Properties { get; set; }
    }
}
