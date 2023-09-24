using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConesaApp.Database.Migrations
{
    public partial class prueba2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Clientes_clienteID",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Polizas_polizaID",
                table: "Vehiculos");

            migrationBuilder.RenameColumn(
                name: "polizaID",
                table: "Vehiculos",
                newName: "PolizaID");

            migrationBuilder.RenameColumn(
                name: "clienteID",
                table: "Vehiculos",
                newName: "ClienteID");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculos_polizaID",
                table: "Vehiculos",
                newName: "IX_Vehiculos_PolizaID");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculos_clienteID",
                table: "Vehiculos",
                newName: "IX_Vehiculos_ClienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Clientes_ClienteID",
                table: "Vehiculos",
                column: "ClienteID",
                principalTable: "Clientes",
                principalColumn: "clienteID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Polizas_PolizaID",
                table: "Vehiculos",
                column: "PolizaID",
                principalTable: "Polizas",
                principalColumn: "polizaID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Clientes_ClienteID",
                table: "Vehiculos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vehiculos_Polizas_PolizaID",
                table: "Vehiculos");

            migrationBuilder.RenameColumn(
                name: "PolizaID",
                table: "Vehiculos",
                newName: "polizaID");

            migrationBuilder.RenameColumn(
                name: "ClienteID",
                table: "Vehiculos",
                newName: "clienteID");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculos_PolizaID",
                table: "Vehiculos",
                newName: "IX_Vehiculos_polizaID");

            migrationBuilder.RenameIndex(
                name: "IX_Vehiculos_ClienteID",
                table: "Vehiculos",
                newName: "IX_Vehiculos_clienteID");

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Clientes_clienteID",
                table: "Vehiculos",
                column: "clienteID",
                principalTable: "Clientes",
                principalColumn: "clienteID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vehiculos_Polizas_polizaID",
                table: "Vehiculos",
                column: "polizaID",
                principalTable: "Polizas",
                principalColumn: "polizaID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
