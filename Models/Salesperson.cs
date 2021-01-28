using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeSpokedBikes.Models
{
    public class Salesperson
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime TerminationDate { get; set; }
        public string Manager { get; set; }
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
