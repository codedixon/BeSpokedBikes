using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeSpokedBikes.Models
{
    public class Sales
    {
        public Product Product { get; set; }
        public Salesperson Salesperson { get; set; }
        public Customer Customer { get; set; }
        public DateTime SalesDate { get; set; }
        public List<Sales> allsales { get; set; }

        public Sales(Product product, Salesperson salesperson, Customer customer, DateTime salesdate)
        {
            this.Product = product;
            this.Salesperson = salesperson;
            this.Customer = customer;
            this.SalesDate = salesdate;
            allsales.Add(this);
        }

        public List<Sales> GetSales()
        {
            return allsales;
        }

        public Sales CreateSale(Product product, Salesperson salesperson, Customer customer)
        {
            Sales newsale = new Sales(product, salesperson, customer, DateTime.Now);
            allsales.Add(newsale);
            return newsale;
        }
    }
}
