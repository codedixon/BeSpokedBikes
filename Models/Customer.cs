using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeSpokedBikes.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime StartDate { get; set; }
        public static List<Customer> allcustomers { get; set; }
        public Customer()
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
            this.StartDate = StartDate;
            allcustomers.Add(this);
        }

        public static List<Customer> displaycustomers()
        {
            return allcustomers;
        }
    }
}
