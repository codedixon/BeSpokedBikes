using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeSpokedBikes.Models
{
    public class Customer
    {
        public static int CustomerCount { get; set; }
        [Required]
        public int CustomerId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public virtual ICollection<Sale> Sales { get; set; }

        //public static List<Customer> allcustomers { get; set; }
        public Customer(string FirstName, string LastName, string Address, string PhoneNumber, DateTime StartDate)
        {
            CustomerCount++;
            this.CustomerId = CustomerCount;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
            this.StartDate = StartDate;
            //allcustomers.Add(this);
        }

        public Customer()
        {

        }

        //public static List<Customer> displaycustomers()
        //{
        //    return allcustomers;
        //}
    }
}
