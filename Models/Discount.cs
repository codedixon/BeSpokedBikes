using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeSpokedBikes.Models
{
    public class Discount
    {
        [Required]
        public Product Product { get; set; }
        
        [Required]
        public int ProductId { get; set; }
       
        [Required]
        public DateTime StartDate { get; set; }
        
        public DateTime EndDate { get; set; }
      
        [Required]
        public decimal DiscountPercentage { get; set; }
    }
}
