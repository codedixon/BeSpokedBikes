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
        public HashSet<string> Products { get; set; }
        
        public Product(string Name, string Manufacturer, string Style, int PurchasePrice, int SalePrice, int Quantity, decimal CommissionPercentage)
        {
            this.Name = Name;
            this.Manufacturer = Manufacturer;
            this.Style = Style;
            this.PurchasePrice = PurchasePrice;
            this.SalePrice = SalePrice;
            this.Quantity = Quantity;
            this.CommissionPercentage = CommissionPercentage;
            Products.Add(Name);
            //Different manufacturers can sell the same product at different prices with different quantities, that's why I'm specifically only adding product names to this hashset
        }

        public List<string> displayall()
        {
            return Products.ToList();
        }
    }
}
