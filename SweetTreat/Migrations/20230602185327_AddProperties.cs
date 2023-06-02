using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SweetTreat.Migrations
{
    public partial class AddProperties : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TreatDescription",
                table: "Treats",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "FlavorDescription",
                table: "Flavors",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TreatDescription",
                table: "Treats");

            migrationBuilder.DropColumn(
                name: "FlavorDescription",
                table: "Flavors");
        }
    }
}
