using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShopifySharp
{
    public class PresentmentMoney
    {
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("amount")]
        public decimal? Amount { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }
    }
}
