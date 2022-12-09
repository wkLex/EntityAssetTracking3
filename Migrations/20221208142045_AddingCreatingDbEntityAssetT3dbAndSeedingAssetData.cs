using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityAssetTracking3.Migrations
{
    public partial class AddingCreatingDbEntityAssetT3dbAndSeedingAssetData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Office = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExchangeRate = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "Brand", "Currency", "ExchangeRate", "Model", "Office", "Price", "PurchaseDate", "Type" },
                values: new object[,]
                {
                    { 1, "MacBook", "GBP", 1.1499999999999999, "Air", "England", 1800.0, new DateTime(2020, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop" },
                    { 2, "Asus", "EUR", 1.0, "B42", "Spain", 500.0, new DateTime(2018, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop" },
                    { 3, "Lenovo", "SEK", 0.089999999999999997, "Yoga 9", "Sweden", 6100.0, new DateTime(2019, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop" },
                    { 4, "HP", "SEK", 0.089999999999999997, "EliteBook", "Sweden", 17600.0, new DateTime(2021, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop" },
                    { 5, "Iphone", "SEK", 0.089999999999999997, "13 Pro", "Sweden", 13600.0, new DateTime(2021, 8, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone" },
                    { 6, "Samsung", "EUR", 1.0, "Galaxy", "Spain", 800.0, new DateTime(2019, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone" },
                    { 7, "Nokia", "SEK", 0.089999999999999997, "V Flip", "Sweden", 10300.0, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone" },
                    { 8, "Iphone", "EUR", 1.0, "12 Mini", "Spain", 980.0, new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone" },
                    { 9, "Asus", "GBP", 1.1499999999999999, "X515", "England", 700.0, new DateTime(2018, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Laptop" },
                    { 10, "Samsung", "SEK", 0.089999999999999997, "Flip2", "Sweden", 9800.0, new DateTime(2019, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Phone" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assets");
        }
    }
}
