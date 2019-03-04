using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopifySharp
{
    public class SubtotalPriceSet
    {
        [JsonProperty("shop_money")]
        public ShopMoney ShopMoney { get; set; }

        [JsonProperty("presentment_money")]
        public PresentmentMoney PresentmentMoney { get; set; }
    }
}
