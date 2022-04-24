using Newtonsoft.Json;

namespace CotacaoDolaHG
{
    public class Market
    {

        public Market() 
        {
            this.Currency = new Currency();
        }
        [JsonProperty(PropertyName = "currencies")]
        public Currency Currency { get; set; }
    }
}
