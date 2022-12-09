using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityAssetTracking3
{
    internal class Asset
    {
        public int Id {get; set;}
        public string Type {get; set;}
        public string Brand {get; set;}
        public string Model {get; set;}
        public DateTime PurchaseDate {get; set;}
        public string Office { get; set;}
        public double Price { get; set;}
        public string Currency { get; set; }
        public double ExchangeRate { get; set;}

    }
}
