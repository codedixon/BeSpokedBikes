using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BeSpokedBikes.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Manufacturer = table.Column<string>(type: "TEXT", nullable: false),
                    Style = table.Column<string>(type: "TEXT", nullable: true),
                    PurchasePrice = table.Column<int>(type: "INTEGER", nullable: false),
                    SalePrice = table.Column<int>(type: "INTEGER", nullable: false),
                    Quantity = table.Column<int>(type: "INTEGER", nullable: false),
                    CommissionPercentage = table.Column<double>(type: "REAL", nullable: false),
                    DiscountId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Salespeople",
                columns: table => new
                {
                    SalespersonId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    TerminationDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Manager = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salespeople", x => x.SalespersonId);
                });

            migrationBuilder.CreateTable(
                name: "Discount",
                columns: table => new
                {
                    DiscountId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    StartDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    EndDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DiscountPercentage = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discount", x => x.DiscountId);
                    table.ForeignKey(
                        name: "FK_Discount_Products_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sales",
                columns: table => new
                {
                    SaleId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    SalespersonId = table.Column<int>(type: "INTEGER", nullable: false),
                    CustomerId = table.Column<int>(type: "INTEGER", nullable: false),
                    SalesDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales", x => x.SaleId);
                    table.ForeignKey(
                        name: "FK_Sales_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sales_Salespeople_SalespersonId",
                        column: x => x.SalespersonId,
                        principalTable: "Salespeople",
                        principalColumn: "SalespersonId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "FirstName", "LastName", "PhoneNumber", "StartDate" },
                values: new object[] { 1, "483 Edgewood Ave", "Rashaad", "Dixon", "7812431464", new DateTime(1995, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "FirstName", "LastName", "PhoneNumber", "StartDate" },
                values: new object[] { 2, "News Station 44", "Ron", "Burgundy", "5082531684", new DateTime(2016, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "FirstName", "LastName", "PhoneNumber", "StartDate" },
                values: new object[] { 3, "Star Circuit", "Mario", "Kart", "3454321111", new DateTime(1995, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "FirstName", "LastName", "PhoneNumber", "StartDate" },
                values: new object[] { 4, "Villian Castle", "Princess", "Peach", "5815431564", new DateTime(2003, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "FirstName", "LastName", "PhoneNumber", "StartDate" },
                values: new object[] { 5, "The Forest", "Luigi", "Green", "6818431964", new DateTime(2015, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "FirstName", "LastName", "PhoneNumber", "StartDate" },
                values: new object[] { 6, "101 State Farm Street", "Christopher", "Paul", "1812451462", new DateTime(1998, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "FirstName", "LastName", "PhoneNumber", "StartDate" },
                values: new object[] { 7, "Robot Planet", "Optimus", "Prime", "5812433465", new DateTime(2001, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "FirstName", "LastName", "PhoneNumber", "StartDate" },
                values: new object[] { 8, "The Ocean Street", "Dasani", "Water", "7812434469", new DateTime(2001, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "FirstName", "LastName", "PhoneNumber", "StartDate" },
                values: new object[] { 9, "The Cabinet Ave", "Canned", "Soup", "9812431484", new DateTime(2001, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "FirstName", "LastName", "PhoneNumber", "StartDate" },
                values: new object[] { 10, "Sonics House", "Dr", "Robotnik", "4812331064", new DateTime(2019, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CommissionPercentage", "DiscountId", "Manufacturer", "Name", "PurchasePrice", "Quantity", "SalePrice", "Style" },
                values: new object[] { 9, 0.12, 0, "Priority", "Zoom", 35, 84, 190, "BMX" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CommissionPercentage", "DiscountId", "Manufacturer", "Name", "PurchasePrice", "Quantity", "SalePrice", "Style" },
                values: new object[] { 8, 0.050000000000000003, 0, "Felt", "Biped", 150, 65, 200, "Tandem" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CommissionPercentage", "DiscountId", "Manufacturer", "Name", "PurchasePrice", "Quantity", "SalePrice", "Style" },
                values: new object[] { 7, 0.14999999999999999, 0, "Bianchi", "Motorcycle", 15, 105, 150, "Mountain" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CommissionPercentage", "DiscountId", "Manufacturer", "Name", "PurchasePrice", "Quantity", "SalePrice", "Style" },
                values: new object[] { 10, 0.20000000000000001, 0, "Colnago", "Skateboard", 55, 220, 140, "Touring" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CommissionPercentage", "DiscountId", "Manufacturer", "Name", "PurchasePrice", "Quantity", "SalePrice", "Style" },
                values: new object[] { 6, 0.10000000000000001, 0, "Alchemy", "Tricycle", 75, 240, 110, "Folding" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CommissionPercentage", "DiscountId", "Manufacturer", "Name", "PurchasePrice", "Quantity", "SalePrice", "Style" },
                values: new object[] { 3, 0.55000000000000004, 0, "Co-Op", "Unicyle", 25, 12, 100, "Mountain" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CommissionPercentage", "DiscountId", "Manufacturer", "Name", "PurchasePrice", "Quantity", "SalePrice", "Style" },
                values: new object[] { 4, 0.45000000000000001, 0, "Alchemy", "Dirt Bike", 85, 62, 250, "Electric" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CommissionPercentage", "DiscountId", "Manufacturer", "Name", "PurchasePrice", "Quantity", "SalePrice", "Style" },
                values: new object[] { 2, 0.27000000000000002, 0, "Cannondale", "ATV", 45, 42, 80, "Hybrid" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CommissionPercentage", "DiscountId", "Manufacturer", "Name", "PurchasePrice", "Quantity", "SalePrice", "Style" },
                values: new object[] { 1, 0.65000000000000002, 0, "Alchemy", "Bicycle", 65, 52, 110, "Mountain" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CommissionPercentage", "DiscountId", "Manufacturer", "Name", "PurchasePrice", "Quantity", "SalePrice", "Style" },
                values: new object[] { 5, 0.5, 0, "Cube", "Wheel", 105, 100, 310, "Mountain" });

            migrationBuilder.InsertData(
                table: "Salespeople",
                columns: new[] { "SalespersonId", "Address", "FirstName", "LastName", "Manager", "PhoneNumber", "StartDate", "TerminationDate" },
                values: new object[] { 5, "62 Hawk Lane", "Lam", "Bill", "Rodgers", "2532221323", new DateTime(2007, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1997, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Salespeople",
                columns: new[] { "SalespersonId", "Address", "FirstName", "LastName", "Manager", "PhoneNumber", "StartDate", "TerminationDate" },
                values: new object[] { 1, "22 Edgewood Ave", "John", "Mitt", "Brady", "7532221323", new DateTime(1998, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Salespeople",
                columns: new[] { "SalespersonId", "Address", "FirstName", "LastName", "Manager", "PhoneNumber", "StartDate", "TerminationDate" },
                values: new object[] { 2, "32 Ram Ave", "Tim", "Schmitt", "Mahomes", "1532221323", new DateTime(1995, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Salespeople",
                columns: new[] { "SalespersonId", "Address", "FirstName", "LastName", "Manager", "PhoneNumber", "StartDate", "TerminationDate" },
                values: new object[] { 3, "38 Elephant Way", "Jim", "Fitt", "Manning", "9532221323", new DateTime(2007, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2007, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Salespeople",
                columns: new[] { "SalespersonId", "Address", "FirstName", "LastName", "Manager", "PhoneNumber", "StartDate", "TerminationDate" },
                values: new object[] { 4, "46 Crocodile Street", "Kim", "Critt", "Manning", "8532221323", new DateTime(2002, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2003, 7, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Salespeople",
                columns: new[] { "SalespersonId", "Address", "FirstName", "LastName", "Manager", "PhoneNumber", "StartDate", "TerminationDate" },
                values: new object[] { 6, "82 Zebra Street", "Sam", "Phil", "Jackson", "4532521323", new DateTime(2016, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "ProductId", "SalesDate", "SalespersonId" },
                values: new object[] { 8, 2, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "ProductId", "SalesDate", "SalespersonId" },
                values: new object[] { 9, 4, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "ProductId", "SalesDate", "SalespersonId" },
                values: new object[] { 6, 1, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "ProductId", "SalesDate", "SalespersonId" },
                values: new object[] { 1, 3, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "ProductId", "SalesDate", "SalespersonId" },
                values: new object[] { 15, 1, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "ProductId", "SalesDate", "SalespersonId" },
                values: new object[] { 14, 7, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "ProductId", "SalesDate", "SalespersonId" },
                values: new object[] { 7, 7, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "ProductId", "SalesDate", "SalespersonId" },
                values: new object[] { 3, 8, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "ProductId", "SalesDate", "SalespersonId" },
                values: new object[] { 20, 7, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "ProductId", "SalesDate", "SalespersonId" },
                values: new object[] { 12, 5, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "ProductId", "SalesDate", "SalespersonId" },
                values: new object[] { 18, 6, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "ProductId", "SalesDate", "SalespersonId" },
                values: new object[] { 17, 1, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "ProductId", "SalesDate", "SalespersonId" },
                values: new object[] { 4, 8, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "ProductId", "SalesDate", "SalespersonId" },
                values: new object[] { 5, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "ProductId", "SalesDate", "SalespersonId" },
                values: new object[] { 2, 9, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "ProductId", "SalesDate", "SalespersonId" },
                values: new object[] { 19, 1, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "ProductId", "SalesDate", "SalespersonId" },
                values: new object[] { 13, 8, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "ProductId", "SalesDate", "SalespersonId" },
                values: new object[] { 11, 3, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "ProductId", "SalesDate", "SalespersonId" },
                values: new object[] { 10, 5, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "ProductId", "SalesDate", "SalespersonId" },
                values: new object[] { 16, 2, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 });

            migrationBuilder.CreateIndex(
                name: "IX_Sales_CustomerId",
                table: "Sales",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProductId",
                table: "Sales",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Sales_SalespersonId",
                table: "Sales",
                column: "SalespersonId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Discount");

            migrationBuilder.DropTable(
                name: "Sales");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Salespeople");
        }
    }
}
