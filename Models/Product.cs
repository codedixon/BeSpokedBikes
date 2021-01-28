using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeSpokedBikes.Models
{
    public class Product
    {
        public static int NumberOfProducts { get; private set; } = 0;
        public int id { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Style { get; set; }
        public int PurchasePrice { get; set; }
        public int SalePrice { get; set; }
        public int Quantity { get; set; }
        public decimal CommissionPercentage { get; set; }
        public Dictionary<string, int> Products { get; set; }
        
        public Product(string Name, string Manufacturer, string Style, int PurchasePrice, int SalePrice, int Quantity, decimal CommissionPercentage)
        {
            if (!Products.ContainsKey(Name))
            {
                NumberOfProducts++;
                this.id = NumberOfProducts;
                Products.Add(Name, this.id);
            } else
            {
                this.id = Products[this.Name];
            }

            this.Name = Name;
            this.Manufacturer = Manufacturer;
            this.Style = Style;
            this.PurchasePrice = PurchasePrice;
            this.SalePrice = SalePrice;
            this.Quantity = Quantity;
            this.CommissionPercentage = CommissionPercentage;
            
            //Different manufacturers can sell the same product at different prices with different quantities, that's why I'm specifically only adding product names to this Dictionary
        }

        public List<string> displayall()
        {
            return Products.Keys.ToList();
        }
    }
}
