using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeSpokedBikes.Models
{
    public class SalesContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Salesperson> Salespeople { get; set; }
        public DbSet<Sale> Sales { get; set; }

        private Random gen = new Random();
        DateTime RandomDay()
        {
            DateTime start = new DateTime(1995, 1, 1);
            int range = (DateTime.Today - start).Days;
            return start.AddDays(gen.Next(range));
        }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlite("Data Source=biking.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var rand = new Random();

            modelBuilder.Entity<Salesperson>().HasData(
           new Salesperson { SalespersonId = 1, FirstName = "John", LastName = "Mitt", Address = "22 Edgewood Ave", PhoneNumber = "7532221323", StartDate = RandomDay(), TerminationDate = RandomDay(), Manager = "Brady" },
           new Salesperson { SalespersonId = 2, FirstName = "Tim", LastName = "Schmitt", Address = "32 Ram Ave", PhoneNumber = "1532221323", StartDate = RandomDay(), TerminationDate = RandomDay(), Manager = "Mahomes" },
           new Salesperson { SalespersonId = 3, FirstName = "Jim", LastName = "Fitt", Address = "38 Elephant Way", PhoneNumber = "9532221323", StartDate = RandomDay(), TerminationDate = RandomDay(), Manager = "Manning" },
           new Salesperson { SalespersonId = 4, FirstName = "Kim", LastName = "Critt", Address = "46 Crocodile Street", PhoneNumber = "8532221323", StartDate = RandomDay(), TerminationDate = RandomDay(), Manager = "Manning" },
           new Salesperson { SalespersonId = 5, FirstName = "Lam", LastName = "Bill", Address = "62 Hawk Lane", PhoneNumber = "2532221323", StartDate = RandomDay(), TerminationDate = RandomDay(), Manager = "Rodgers" },
           new Salesperson { SalespersonId = 6, FirstName = "Sam", LastName = "Phil", Address = "82 Zebra Street", PhoneNumber = "4532521323", StartDate = RandomDay(), TerminationDate = RandomDay(), Manager = "Jackson" }
       );
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Bicycle", Manufacturer = "Alchemy", Style = "Mountain", PurchasePrice = 65, SalePrice = 110, Quantity = 52, CommissionPercentage = 0.65 },
                new Product { ProductId = 2, Name = "ATV", Manufacturer = "Cannondale", Style = "Hybrid", PurchasePrice = 45, SalePrice = 80, Quantity = 42, CommissionPercentage = 0.27 },
                new Product { ProductId = 3, Name = "Unicyle", Manufacturer = "Co-Op", Style = "Mountain", PurchasePrice = 25, SalePrice = 100, Quantity = 12, CommissionPercentage = 0.55 },
                new Product { ProductId = 4, Name = "Dirt Bike", Manufacturer = "Alchemy", Style = "Electric", PurchasePrice = 85, SalePrice = 250, Quantity = 62, CommissionPercentage = 0.45 },
                new Product { ProductId = 5, Name = "Wheel", Manufacturer = "Cube", Style = "Mountain", PurchasePrice = 105, SalePrice = 310, Quantity = 100, CommissionPercentage = 0.50 },
                new Product { ProductId = 6, Name = "Tricycle", Manufacturer = "Alchemy", Style = "Folding", PurchasePrice = 75, SalePrice = 110, Quantity = 240, CommissionPercentage = 0.10 },
                new Product { ProductId = 10, Name = "Skateboard", Manufacturer = "Colnago", Style = "Touring", PurchasePrice = 55, SalePrice = 140, Quantity = 220, CommissionPercentage = 0.20 },
                new Product { ProductId = 7, Name = "Motorcycle", Manufacturer = "Bianchi", Style = "Mountain", PurchasePrice = 15, SalePrice = 150, Quantity = 105, CommissionPercentage = 0.15 },
                new Product { ProductId = 8, Name = "Biped", Manufacturer = "Felt", Style = "Tandem", PurchasePrice = 150, SalePrice = 200, Quantity = 65, CommissionPercentage = 0.05 },
                new Product { ProductId = 9, Name = "Zoom", Manufacturer = "Priority", Style = "BMX", PurchasePrice = 35, SalePrice = 190, Quantity = 84, CommissionPercentage = 0.12 }
            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, FirstName = "Rashaad", LastName = "Dixon", Address = "483 Edgewood Ave", PhoneNumber = "7812431464", StartDate = RandomDay() },
                new Customer{CustomerId = 2, FirstName = "Ron",LastName = "Burgundy", Address = "News Station 44", PhoneNumber = "5082531684", StartDate = RandomDay()},
                new Customer{CustomerId = 3, FirstName = "Mario", LastName = "Kart", Address = "Star Circuit", PhoneNumber = "3454321111", StartDate = RandomDay()},
                new Customer{ CustomerId = 4, FirstName = "Princess", LastName = "Peach", Address = "Villian Castle", PhoneNumber = "5815431564", StartDate = RandomDay()},
                new Customer{ CustomerId = 5, FirstName = "Luigi", LastName = "Green", Address = "The Forest", PhoneNumber = "6818431964", StartDate = RandomDay()},
                new Customer{ CustomerId = 6, FirstName = "Christopher", LastName = "Paul", Address = "101 State Farm Street", PhoneNumber = "1812451462", StartDate = RandomDay()},
                new Customer{ CustomerId = 7, FirstName = "Optimus", LastName = "Prime", Address = "Robot Planet", PhoneNumber = "5812433465", StartDate = RandomDay()},
                new Customer{ CustomerId = 8, FirstName = "Dasani", LastName = "Water", Address = "The Ocean Street", PhoneNumber = "7812434469", StartDate = RandomDay()},
                new Customer{ CustomerId = 9, FirstName = "Canned", LastName = "Soup", Address = "The Cabinet Ave", PhoneNumber = "9812431484", StartDate = RandomDay()},
                new Customer{ CustomerId = 10, FirstName = "Dr", LastName = "Robotnik", Address = "Sonics House", PhoneNumber = "4812331064", StartDate = RandomDay()}
            );

            modelBuilder.Entity<Sale>(
                entity =>
            {
                entity.HasOne(p => p.Product)
                .WithMany(s => s.Sales)
                .HasForeignKey("ProductId");

                entity.HasOne(c => c.Customer)
                    .WithMany(s => s.Sales)
                    .HasForeignKey("CustomerId");

                entity.HasOne(c => c.Salesperson)
                   .WithMany(s => s.Sales)
                   .HasForeignKey("SalespersonId");
            });

            modelBuilder.Entity<Sale>().HasData(
                    new Sale { SaleId = 1, ProductId = rand.Next(2, 9), CustomerId = rand.Next(1, 10), SalespersonId = rand.Next(1, 7) },
                    new Sale { SaleId = 2, ProductId = rand.Next(2, 9), CustomerId = rand.Next(1, 10), SalespersonId = rand.Next(1, 7) },
                    new Sale { SaleId = 3, ProductId = rand.Next(2, 9), CustomerId = rand.Next(1, 10), SalespersonId = rand.Next(1, 7) },
                    new Sale { SaleId = 4, ProductId = rand.Next(2, 9), CustomerId = rand.Next(1, 10), SalespersonId = rand.Next(1, 7) },
                    new Sale { SaleId = 5, ProductId = rand.Next(2, 9), CustomerId = rand.Next(1, 10), SalespersonId = rand.Next(1, 7) },
                    new Sale { SaleId = 6, ProductId = rand.Next(2, 9), CustomerId = rand.Next(1, 10), SalespersonId = rand.Next(1, 7) },
                    new Sale { SaleId = 7, ProductId = rand.Next(2, 9), CustomerId = rand.Next(1, 10), SalespersonId = rand.Next(1, 7) },
                    new Sale { SaleId = 8, ProductId = rand.Next(2, 9), CustomerId = rand.Next(1, 10), SalespersonId = rand.Next(1, 7) },
                    new Sale { SaleId = 9, ProductId = rand.Next(2, 9), CustomerId = rand.Next(1, 10), SalespersonId = rand.Next(1, 7) },
                    new Sale { SaleId = 10, ProductId = rand.Next(2, 9), CustomerId = rand.Next(1, 10), SalespersonId = rand.Next(1, 7) },
                    new Sale { SaleId = 11, ProductId = rand.Next(2, 9), CustomerId = rand.Next(1, 10), SalespersonId = rand.Next(1, 7) },
                    new Sale { SaleId = 12, ProductId = rand.Next(2, 9), CustomerId = rand.Next(1, 10), SalespersonId = rand.Next(1, 7) },
                    new Sale { SaleId = 13, ProductId = rand.Next(2, 9), CustomerId = rand.Next(1, 10), SalespersonId = rand.Next(1, 7) },
                    new Sale { SaleId = 14, ProductId = rand.Next(2, 9), CustomerId = rand.Next(1, 10), SalespersonId = rand.Next(1, 7) },
                    new Sale { SaleId = 15, ProductId = rand.Next(2, 9), CustomerId = rand.Next(1, 10), SalespersonId = rand.Next(1, 7) },
                    new Sale { SaleId = 16, ProductId = rand.Next(2, 9), CustomerId = rand.Next(1, 10), SalespersonId = rand.Next(1, 7) },
                    new Sale { SaleId = 17, ProductId = rand.Next(2, 9), CustomerId = rand.Next(1, 10), SalespersonId = rand.Next(1, 7) },
                    new Sale { SaleId = 18, ProductId = rand.Next(2, 9), CustomerId = rand.Next(1, 10), SalespersonId = rand.Next(1, 7) },
                    new Sale { SaleId = 19, ProductId = rand.Next(2, 9), CustomerId = rand.Next(1, 10), SalespersonId = rand.Next(1, 7) },
                    new Sale { SaleId = 20, ProductId = rand.Next(2, 9), CustomerId = rand.Next(1, 10), SalespersonId = rand.Next(1, 7) }
                    );

            modelBuilder.Entity<Discount>(
          entity =>
          {
              entity.HasOne(p => p.Product)
              .WithMany(d => d.Discounts)
              .HasForeignKey("DiscountId");
          });



            base.OnModelCreating(modelBuilder);
        }
    }
}
