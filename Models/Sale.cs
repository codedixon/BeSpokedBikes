using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeSpokedBikes.Models
{
    public class Sale
    {
        [Required]
        public int SaleId { get; set; }
        public Product Product { get; set; }
        public int ProductId { get; set; }
        public Salesperson Salesperson { get; set; }
        public int SalespersonId { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public DateTime SalesDate { get; set; }
        public static List<Sale> allsales { get; set; }

        public static List<Sale> GetSales()
        {
            return allsales;
        }

        public Sale CreateSale(int productid, int salespersonid, int customerid)
        {
            Sale newsale = new Sale {ProductId = productid, SalespersonId = salespersonid, CustomerId = customerid };
            allsales.Add(newsale);
            return newsale;
        }
    }
}
