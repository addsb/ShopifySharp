using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopifySharp
{
    public class CheckoutShippingLine : ShippingLine
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("handle")]
        public string Handle { get; set; }
    }
}
