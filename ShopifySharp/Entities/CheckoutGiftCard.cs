using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopifySharp
{
    public class CheckoutGiftCard : GiftCard
    {
        /// <summary>
        /// The amount of the gift card used by this checkout in presentment currency.
        /// </summary>
        [JsonProperty("amount_used")]
        public decimal? AmountUsed { get; set; }
    }
}
