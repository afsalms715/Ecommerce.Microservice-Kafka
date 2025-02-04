using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Ecommerce.ProductService.Migrations
{
    /// <inheritdoc />
    public partial class producttable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "Name", "Price", "Status", "Stock" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crocs", 1750m, true, 20 },
                    { 2, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nike", 1790m, true, 30 },
                    { 3, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adidas", 1650m, true, 10 },
                    { 4, new DateTime(2021, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "NewBalance", 2750m, true, 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
