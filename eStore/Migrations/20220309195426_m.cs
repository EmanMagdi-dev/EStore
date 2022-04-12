using Microsoft.EntityFrameworkCore.Migrations;

namespace eStore.Migrations
{
    public partial class m : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailableQuantity",
                table: "Products");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AvailableQuantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
