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
        public List<Sale> allsales { get; set; }

        public Sale(Product product, Salesperson salesperson, Customer customer, DateTime salesdate)
        {
            this.Product = product;
            this.Salesperson = salesperson;
            this.Customer = customer;
            this.SalesDate = salesdate;
            allsales.Add(this);
        }

        public List<Sale> GetSales()
        {
            return allsales;
        }

        public Sale CreateSale(Product product, Salesperson salesperson, Customer customer)
        {
            Sale newsale = new Sale(product, salesperson, customer, DateTime.Now);
            allsales.Add(newsale);
            return newsale;
        }
    }
}
