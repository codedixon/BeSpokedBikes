using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeSpokedBikes.Models
{
    public class Sales
    {
        public Product product { get; set; }
        public Salesperson salesperson { get; set; }
        public Customer customer { get; set; }
        public DateTime SalesDate { get; set; }
    }
}
