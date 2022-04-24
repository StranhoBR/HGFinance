using Newtonsoft.Json;

namespace CotacaoDolaHG
{
    public class Currency
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "buy")]
        public decimal Buy { get; set; }

        [JsonProperty(PropertyName = "sell")]
        public decimal Sell { get; set; }

        [JsonProperty(PropertyName = "variation")]
        public decimal Variation { get; set; }
    }
}
