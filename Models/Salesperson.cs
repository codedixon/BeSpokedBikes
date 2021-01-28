using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeSpokedBikes.Models
{
    public class Salesperson
    {
        [Required]
        public int SalespersonId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public int SaleId { get; set; }
        public DateTime TerminationDate { get; set; }
        public string Manager { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
        public HashSet<Salesperson> salespeople {get; set;}

        public Salesperson(string FirstName, string LastName, string Address, string PhoneNumber, DateTime StartDate, DateTime TerminationDate, string Manager)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
            this.StartDate = StartDate;
            this.TerminationDate = TerminationDate;
            this.Manager = Manager;
            salespeople.Add(this);
            //adds specific object being referenced
        }

        public List<Salesperson> GetSalespeople()
        {
            return salespeople.ToList();
        }
    }
}
