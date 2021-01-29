﻿// <auto-generated />
using System;
using BeSpokedBikes.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeSpokedBikes.Migrations
{
    [DbContext(typeof(SalesContext))]
    [Migration("20210129194051_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("BeSpokedBikes.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Address = "483 Edgewood Ave",
                            FirstName = "Rashaad",
                            LastName = "Dixon",
                            PhoneNumber = "7812431464",
                            StartDate = new DateTime(1996, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 2,
                            Address = "News Station 44",
                            FirstName = "Ron",
                            LastName = "Burgundy",
                            PhoneNumber = "5082531684",
                            StartDate = new DateTime(2015, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 3,
                            Address = "Star Circuit",
                            FirstName = "Mario",
                            LastName = "Kart",
                            PhoneNumber = "3454321111",
                            StartDate = new DateTime(2019, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 4,
                            Address = "Villian Castle",
                            FirstName = "Princess",
                            LastName = "Peach",
                            PhoneNumber = "5815431564",
                            StartDate = new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 5,
                            Address = "The Forest",
                            FirstName = "Luigi",
                            LastName = "Green",
                            PhoneNumber = "6818431964",
                            StartDate = new DateTime(2013, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 6,
                            Address = "101 State Farm Street",
                            FirstName = "Christopher",
                            LastName = "Paul",
                            PhoneNumber = "1812451462",
                            StartDate = new DateTime(2009, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 7,
                            Address = "Robot Planet",
                            FirstName = "Optimus",
                            LastName = "Prime",
                            PhoneNumber = "5812433465",
                            StartDate = new DateTime(2002, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 8,
                            Address = "The Ocean Street",
                            FirstName = "Dasani",
                            LastName = "Water",
                            PhoneNumber = "7812434469",
                            StartDate = new DateTime(1998, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 9,
                            Address = "The Cabinet Ave",
                            FirstName = "Canned",
                            LastName = "Soup",
                            PhoneNumber = "9812431484",
                            StartDate = new DateTime(2004, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            CustomerId = 10,
                            Address = "Sonics House",
                            FirstName = "Dr",
                            LastName = "Robotnik",
                            PhoneNumber = "4812331064",
                            StartDate = new DateTime(1999, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("BeSpokedBikes.Models.Discount", b =>
                {
                    b.Property<int>("DiscountId")
                        .HasColumnType("int");

                    b.Property<decimal>("DiscountPercentage")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("DiscountId");

                    b.ToTable("Discount");
                });

            modelBuilder.Entity("BeSpokedBikes.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("CommissionPercentage")
                        .HasColumnType("float");

                    b.Property<int>("DiscountId")
                        .HasColumnType("int");

                    b.Property<string>("Manufacturer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PurchasePrice")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("SalePrice")
                        .HasColumnType("int");

                    b.Property<string>("Style")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CommissionPercentage = 0.65000000000000002,
                            DiscountId = 0,
                            Manufacturer = "Alchemy",
                            Name = "Bicycle",
                            PurchasePrice = 65,
                            Quantity = 52,
                            SalePrice = 110,
                            Style = "Mountain"
                        },
                        new
                        {
                            ProductId = 2,
                            CommissionPercentage = 0.27000000000000002,
                            DiscountId = 0,
                            Manufacturer = "Cannondale",
                            Name = "ATV",
                            PurchasePrice = 45,
                            Quantity = 42,
                            SalePrice = 80,
                            Style = "Hybrid"
                        },
                        new
                        {
                            ProductId = 3,
                            CommissionPercentage = 0.55000000000000004,
                            DiscountId = 0,
                            Manufacturer = "Co-Op",
                            Name = "Unicyle",
                            PurchasePrice = 25,
                            Quantity = 12,
                            SalePrice = 100,
                            Style = "Mountain"
                        },
                        new
                        {
                            ProductId = 4,
                            CommissionPercentage = 0.45000000000000001,
                            DiscountId = 0,
                            Manufacturer = "Alchemy",
                            Name = "Dirt Bike",
                            PurchasePrice = 85,
                            Quantity = 62,
                            SalePrice = 250,
                            Style = "Electric"
                        },
                        new
                        {
                            ProductId = 5,
                            CommissionPercentage = 0.5,
                            DiscountId = 0,
                            Manufacturer = "Cube",
                            Name = "Wheel",
                            PurchasePrice = 105,
                            Quantity = 100,
                            SalePrice = 310,
                            Style = "Mountain"
                        },
                        new
                        {
                            ProductId = 6,
                            CommissionPercentage = 0.10000000000000001,
                            DiscountId = 0,
                            Manufacturer = "Alchemy",
                            Name = "Tricycle",
                            PurchasePrice = 75,
                            Quantity = 240,
                            SalePrice = 110,
                            Style = "Folding"
                        },
                        new
                        {
                            ProductId = 10,
                            CommissionPercentage = 0.20000000000000001,
                            DiscountId = 0,
                            Manufacturer = "Colnago",
                            Name = "Skateboard",
                            PurchasePrice = 55,
                            Quantity = 220,
                            SalePrice = 140,
                            Style = "Touring"
                        },
                        new
                        {
                            ProductId = 7,
                            CommissionPercentage = 0.14999999999999999,
                            DiscountId = 0,
                            Manufacturer = "Bianchi",
                            Name = "Motorcycle",
                            PurchasePrice = 15,
                            Quantity = 105,
                            SalePrice = 150,
                            Style = "Mountain"
                        },
                        new
                        {
                            ProductId = 8,
                            CommissionPercentage = 0.050000000000000003,
                            DiscountId = 0,
                            Manufacturer = "Felt",
                            Name = "Biped",
                            PurchasePrice = 150,
                            Quantity = 65,
                            SalePrice = 200,
                            Style = "Tandem"
                        },
                        new
                        {
                            ProductId = 9,
                            CommissionPercentage = 0.12,
                            DiscountId = 0,
                            Manufacturer = "Priority",
                            Name = "Zoom",
                            PurchasePrice = 35,
                            Quantity = 84,
                            SalePrice = 190,
                            Style = "BMX"
                        });
                });

            modelBuilder.Entity("BeSpokedBikes.Models.Sale", b =>
                {
                    b.Property<int>("SaleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<DateTime>("SalesDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SalespersonId")
                        .HasColumnType("int");

                    b.HasKey("SaleId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SalespersonId");

                    b.ToTable("Sales");

                    b.HasData(
                        new
                        {
                            SaleId = 1,
                            CustomerId = 1,
                            ProductId = 6,
                            SalesDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SalespersonId = 5
                        },
                        new
                        {
                            SaleId = 2,
                            CustomerId = 8,
                            ProductId = 7,
                            SalesDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SalespersonId = 3
                        },
                        new
                        {
                            SaleId = 3,
                            CustomerId = 9,
                            ProductId = 4,
                            SalesDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SalespersonId = 4
                        },
                        new
                        {
                            SaleId = 4,
                            CustomerId = 5,
                            ProductId = 5,
                            SalesDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SalespersonId = 1
                        },
                        new
                        {
                            SaleId = 5,
                            CustomerId = 4,
                            ProductId = 6,
                            SalesDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SalespersonId = 6
                        },
                        new
                        {
                            SaleId = 6,
                            CustomerId = 9,
                            ProductId = 4,
                            SalesDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SalespersonId = 1
                        },
                        new
                        {
                            SaleId = 7,
                            CustomerId = 2,
                            ProductId = 3,
                            SalesDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SalespersonId = 5
                        },
                        new
                        {
                            SaleId = 8,
                            CustomerId = 7,
                            ProductId = 8,
                            SalesDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SalespersonId = 2
                        },
                        new
                        {
                            SaleId = 9,
                            CustomerId = 8,
                            ProductId = 5,
                            SalesDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SalespersonId = 5
                        },
                        new
                        {
                            SaleId = 10,
                            CustomerId = 6,
                            ProductId = 5,
                            SalesDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SalespersonId = 5
                        },
                        new
                        {
                            SaleId = 11,
                            CustomerId = 7,
                            ProductId = 8,
                            SalesDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SalespersonId = 3
                        },
                        new
                        {
                            SaleId = 12,
                            CustomerId = 2,
                            ProductId = 4,
                            SalesDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SalespersonId = 3
                        },
                        new
                        {
                            SaleId = 13,
                            CustomerId = 1,
                            ProductId = 4,
                            SalesDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SalespersonId = 3
                        },
                        new
                        {
                            SaleId = 14,
                            CustomerId = 3,
                            ProductId = 8,
                            SalesDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SalespersonId = 5
                        },
                        new
                        {
                            SaleId = 15,
                            CustomerId = 1,
                            ProductId = 3,
                            SalesDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SalespersonId = 3
                        },
                        new
                        {
                            SaleId = 16,
                            CustomerId = 7,
                            ProductId = 3,
                            SalesDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SalespersonId = 5
                        },
                        new
                        {
                            SaleId = 17,
                            CustomerId = 1,
                            ProductId = 7,
                            SalesDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SalespersonId = 6
                        },
                        new
                        {
                            SaleId = 18,
                            CustomerId = 1,
                            ProductId = 6,
                            SalesDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SalespersonId = 6
                        },
                        new
                        {
                            SaleId = 19,
                            CustomerId = 7,
                            ProductId = 4,
                            SalesDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SalespersonId = 2
                        },
                        new
                        {
                            SaleId = 20,
                            CustomerId = 2,
                            ProductId = 5,
                            SalesDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            SalespersonId = 6
                        });
                });

            modelBuilder.Entity("BeSpokedBikes.Models.Salesperson", b =>
                {
                    b.Property<int>("SalespersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Manager")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TerminationDate")
                        .HasColumnType("datetime2");

                    b.HasKey("SalespersonId");

                    b.ToTable("Salespeople");

                    b.HasData(
                        new
                        {
                            SalespersonId = 1,
                            Address = "22 Edgewood Ave",
                            FirstName = "John",
                            LastName = "Mitt",
                            Manager = "Brady",
                            PhoneNumber = "7532221323",
                            StartDate = new DateTime(2002, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TerminationDate = new DateTime(2015, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            SalespersonId = 2,
                            Address = "32 Ram Ave",
                            FirstName = "Tim",
                            LastName = "Schmitt",
                            Manager = "Mahomes",
                            PhoneNumber = "1532221323",
                            StartDate = new DateTime(2019, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TerminationDate = new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            SalespersonId = 3,
                            Address = "38 Elephant Way",
                            FirstName = "Jim",
                            LastName = "Fitt",
                            Manager = "Manning",
                            PhoneNumber = "9532221323",
                            StartDate = new DateTime(2007, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TerminationDate = new DateTime(2012, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            SalespersonId = 4,
                            Address = "46 Crocodile Street",
                            FirstName = "Kim",
                            LastName = "Critt",
                            Manager = "Manning",
                            PhoneNumber = "8532221323",
                            StartDate = new DateTime(1998, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TerminationDate = new DateTime(2000, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            SalespersonId = 5,
                            Address = "62 Hawk Lane",
                            FirstName = "Lam",
                            LastName = "Bill",
                            Manager = "Rodgers",
                            PhoneNumber = "2532221323",
                            StartDate = new DateTime(2005, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TerminationDate = new DateTime(2004, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            SalespersonId = 6,
                            Address = "82 Zebra Street",
                            FirstName = "Sam",
                            LastName = "Phil",
                            Manager = "Jackson",
                            PhoneNumber = "4532521323",
                            StartDate = new DateTime(2012, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TerminationDate = new DateTime(2013, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("BeSpokedBikes.Models.Discount", b =>
                {
                    b.HasOne("BeSpokedBikes.Models.Product", "Product")
                        .WithMany("Discounts")
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("BeSpokedBikes.Models.Sale", b =>
                {
                    b.HasOne("BeSpokedBikes.Models.Customer", "Customer")
                        .WithMany("Sales")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeSpokedBikes.Models.Product", "Product")
                        .WithMany("Sales")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BeSpokedBikes.Models.Salesperson", "Salesperson")
                        .WithMany("Sales")
                        .HasForeignKey("SalespersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Product");

                    b.Navigation("Salesperson");
                });

            modelBuilder.Entity("BeSpokedBikes.Models.Customer", b =>
                {
                    b.Navigation("Sales");
                });

            modelBuilder.Entity("BeSpokedBikes.Models.Product", b =>
                {
                    b.Navigation("Discounts");

                    b.Navigation("Sales");
                });

            modelBuilder.Entity("BeSpokedBikes.Models.Salesperson", b =>
                {
                    b.Navigation("Sales");
                });
#pragma warning restore 612, 618
        }
    }
}