using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopifySharp
{
    public class CheckoutOrder : Order
    {
        /// <summary>
        /// The URL pointing to the order status web page. The URL will be null unless the order was created from a checkout.
        /// </summary>
        [JsonProperty("status_url")]
        public string StatusUrl { get; set; }
    }
}
