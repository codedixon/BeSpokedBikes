using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BeSpokedBikes.Models
{
    public class Product
    {
        public static int count = 1;
        public int ProductId { get; set; }

        [Required]
        public string Name { get; set; }
        [Required]
        public string Manufacturer { get; set; }
        public string Style { get; set; }
        public int PurchasePrice { get; set; }
        [Required]
        public int SalePrice { get; set; }
        public int Quantity { get; set; }
        public double CommissionPercentage { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public virtual ICollection<Discount> Discounts { get; set; }
        public int DiscountId { get; set; }
        [NotMapped]
        public static HashSet<string> Products { get; set; }


        public Product(string Name, string Manufacturer, string Style, int PurchasePrice, int SalePrice, int Quantity, double CommissionPercentage)
        {
            this.Name = Name;
            this.Manufacturer = Manufacturer;
            this.Style = Style;
            this.PurchasePrice = PurchasePrice;
            this.SalePrice = SalePrice;
            this.Quantity = Quantity;
            this.CommissionPercentage = CommissionPercentage;
            Products.Add(Name);
            //Different manufacturers can sell the same product at different prices with different quantities, that's why I'm specifically only adding product names to this Dictionary
        }

        public Product()
        {

        }
        //public List<string> displayall()
        //{
        //    return Products.Keys.ToList();
        //}
    }
}
