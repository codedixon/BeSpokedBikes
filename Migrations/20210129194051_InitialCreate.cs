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
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Style = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PurchasePrice = table.Column<int>(type: "int", nullable: false),
                    SalePrice = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CommissionPercentage = table.Column<double>(type: "float", nullable: false),
                    DiscountId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "Salespeople",
                columns: table => new
                {
                    SalespersonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TerminationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Manager = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salespeople", x => x.SalespersonId);
                });

            migrationBuilder.CreateTable(
                name: "Discount",
                columns: table => new
                {
                    DiscountId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DiscountPercentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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
                    SaleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SalespersonId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    SalesDate = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                values: new object[,]
                {
                    { 1, "483 Edgewood Ave", "Rashaad", "Dixon", "7812431464", new DateTime(1996, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "News Station 44", "Ron", "Burgundy", "5082531684", new DateTime(2015, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Star Circuit", "Mario", "Kart", "3454321111", new DateTime(2019, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "Villian Castle", "Princess", "Peach", "5815431564", new DateTime(2019, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "The Forest", "Luigi", "Green", "6818431964", new DateTime(2013, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "101 State Farm Street", "Christopher", "Paul", "1812451462", new DateTime(2009, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, "Robot Planet", "Optimus", "Prime", "5812433465", new DateTime(2002, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, "The Ocean Street", "Dasani", "Water", "7812434469", new DateTime(1998, 6, 7, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, "The Cabinet Ave", "Canned", "Soup", "9812431484", new DateTime(2004, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, "Sonics House", "Dr", "Robotnik", "4812331064", new DateTime(1999, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CommissionPercentage", "DiscountId", "Manufacturer", "Name", "PurchasePrice", "Quantity", "SalePrice", "Style" },
                values: new object[,]
                {
                    { 9, 0.12, 0, "Priority", "Zoom", 35, 84, 190, "BMX" },
                    { 8, 0.050000000000000003, 0, "Felt", "Biped", 150, 65, 200, "Tandem" },
                    { 7, 0.14999999999999999, 0, "Bianchi", "Motorcycle", 15, 105, 150, "Mountain" },
                    { 10, 0.20000000000000001, 0, "Colnago", "Skateboard", 55, 220, 140, "Touring" },
                    { 6, 0.10000000000000001, 0, "Alchemy", "Tricycle", 75, 240, 110, "Folding" },
                    { 3, 0.55000000000000004, 0, "Co-Op", "Unicyle", 25, 12, 100, "Mountain" },
                    { 4, 0.45000000000000001, 0, "Alchemy", "Dirt Bike", 85, 62, 250, "Electric" },
                    { 2, 0.27000000000000002, 0, "Cannondale", "ATV", 45, 42, 80, "Hybrid" },
                    { 1, 0.65000000000000002, 0, "Alchemy", "Bicycle", 65, 52, 110, "Mountain" },
                    { 5, 0.5, 0, "Cube", "Wheel", 105, 100, 310, "Mountain" }
                });

            migrationBuilder.InsertData(
                table: "Salespeople",
                columns: new[] { "SalespersonId", "Address", "FirstName", "LastName", "Manager", "PhoneNumber", "StartDate", "TerminationDate" },
                values: new object[,]
                {
                    { 5, "62 Hawk Lane", "Lam", "Bill", "Rodgers", "2532221323", new DateTime(2005, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2004, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 1, "22 Edgewood Ave", "John", "Mitt", "Brady", "7532221323", new DateTime(2002, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2015, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "32 Ram Ave", "Tim", "Schmitt", "Mahomes", "1532221323", new DateTime(2019, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "38 Elephant Way", "Jim", "Fitt", "Manning", "9532221323", new DateTime(2007, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2012, 8, 11, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "46 Crocodile Street", "Kim", "Critt", "Manning", "8532221323", new DateTime(1998, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2000, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, "82 Zebra Street", "Sam", "Phil", "Jackson", "4532521323", new DateTime(2012, 4, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2013, 3, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "SaleId", "CustomerId", "ProductId", "SalesDate", "SalespersonId" },
                values: new object[,]
                {
                    { 4, 5, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 17, 1, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 5, 4, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 16, 7, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 14, 3, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 10, 6, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 9, 8, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 7, 2, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 1, 1, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 3, 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 15, 1, 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, 1, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 12, 2, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 11, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 2, 8, 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, 7, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 8, 7, 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 6, 9, 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 18, 1, 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 20, 2, 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 }
                });

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
