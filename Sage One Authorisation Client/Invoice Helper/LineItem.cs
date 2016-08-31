using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sage_One_Authorisation_Client.Invoice_Helper
{
    public class LineItem
    {
        [JsonProperty("description")]
        public int Description { get; set; }

        [JsonProperty("quantity")]
        public double Quantity { get; set; }

        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }

        [JsonProperty("discount_percentage")]
        public double DiscountPercentage { get; set; }

        [JsonProperty("$key")]
        public int Key { get; set; }
    }
}
