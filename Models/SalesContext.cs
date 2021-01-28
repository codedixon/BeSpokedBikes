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

        protected override void OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlServer("Data Source=Sales.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Salesperson>(
            entity =>
            {
                entity.HasMany(s => s.Sales)
                    .WithOne(p => p.Salesperson)
                    .HasForeignKey("SaleId");
            });

            modelBuilder.Entity<Customer>(
         entity =>
         {
             entity.HasMany(s => s.Sales)
                 .WithOne(c => c.Customer)
                 .HasForeignKey("CustomerId");
         });

            modelBuilder.Entity<Sale>(
                entity =>
            {
                entity.HasOne(p => p.Product)
                .WithMany(s => s.Sales)
                .HasForeignKey("ProductId");
            });

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
