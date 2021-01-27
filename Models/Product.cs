using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeSpokedBikes.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Style { get; set; }
        public int PurchasePrice { get; set; }
        public int SalePrice { get; set; }
        public int Quantity { get; set; }
        public decimal CommissionPercentage { get; set; }
    }
}
