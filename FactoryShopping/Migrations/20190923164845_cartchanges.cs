using Microsoft.EntityFrameworkCore.Migrations;

namespace FactoryShopping.Migrations
{
    public partial class cartchanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "CartTotal",
                table: "cart",
                type: "decimal(10,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "ProductImage",
                table: "cart",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "cart",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CartTotal",
                table: "cart");

            migrationBuilder.DropColumn(
                name: "ProductImage",
                table: "cart");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "cart");
        }
    }
}
