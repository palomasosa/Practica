using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConesaApp.Database.Migrations
{
    public partial class actualizacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Actualizado",
                table: "Polizas",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Actualizado",
                table: "Polizas");
        }
    }
}
