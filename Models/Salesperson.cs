using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BeSpokedBikes.Models
{
    public class Salesperson
    {
        public static int count = 1;
        public int SalespersonId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        public DateTime TerminationDate { get; set; }
        public string Manager { get; set; }

        [NotMapped]
        public virtual ICollection<Sale> Sales { get; set; }
        [NotMapped]
        public static HashSet<Salesperson> salespeople {get; set;}

        public Salesperson(string FirstName, string LastName, string Address, string PhoneNumber, DateTime StartDate, DateTime TerminationDate, string Manager)
        {
            this.SalespersonId = count;
            count++;
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
        public Salesperson()
        {

        }


        public List<Salesperson> GetSalespeople()
        {
            return salespeople.ToList();
        }
    }
}
