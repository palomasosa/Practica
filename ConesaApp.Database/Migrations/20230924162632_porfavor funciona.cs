using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConesaApp.Database.Migrations
{
    public partial class porfavorfunciona : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Clientes_clienteID",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Polizas_polizaID",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Usuarios_usuarioID",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_Coberturas_coberturaID",
                table: "Polizas");

            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_Empresas_empresaID",
                table: "Polizas");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_PolizaID",
                table: "Vehiculos");

            migrationBuilder.RenameColumn(
                name: "patente",
                table: "Vehiculos",
                newName: "Patente");

            migrationBuilder.RenameColumn(
                name: "marca",
                table: "Vehiculos",
                newName: "Marca");

            migrationBuilder.RenameColumn(
                name: "año",
                table: "Vehiculos",
                newName: "Año");

            migrationBuilder.RenameColumn(
                name: "vehiculoID",
                table: "Vehiculos",
                newName: "VehiculoID");

            migrationBuilder.RenameColumn(
                name: "valorCuota",
                table: "Polizas",
                newName: "ValorCuota");

            migrationBuilder.RenameColumn(
                name: "valorAsegurado",
                table: "Polizas",
                newName: "ValorAsegurado");

            migrationBuilder.RenameColumn(
                name: "nroPoliza",
                table: "Polizas",
                newName: "NroPoliza");

            migrationBuilder.RenameColumn(
                name: "inicioVigencia",
                table: "Polizas",
                newName: "InicioVigencia");

            migrationBuilder.RenameColumn(
                name: "finVigencia",
                table: "Polizas",
                newName: "FinVigencia");

            migrationBuilder.RenameColumn(
                name: "empresaID",
                table: "Polizas",
                newName: "EmpresaID");

            migrationBuilder.RenameColumn(
                name: "coberturaID",
                table: "Polizas",
                newName: "CoberturaID");

            migrationBuilder.RenameColumn(
                name: "polizaID",
                table: "Polizas",
                newName: "PolizaID");

            migrationBuilder.RenameIndex(
                name: "IX_Polizas_empresaID",
                table: "Polizas",
                newName: "IX_Polizas_EmpresaID");

            migrationBuilder.RenameIndex(
                name: "IX_Polizas_coberturaID",
                table: "Polizas",
                newName: "IX_Polizas_CoberturaID");

            migrationBuilder.RenameColumn(
                name: "usuarioID",
                table: "Pagos",
                newName: "UsuarioID");

            migrationBuilder.RenameColumn(
                name: "polizaID",
                table: "Pagos",
                newName: "PolizaID");

            migrationBuilder.RenameColumn(
                name: "monto",
                table: "Pagos",
                newName: "Monto");

            migrationBuilder.RenameColumn(
                name: "metodoID",
                table: "Pagos",
                newName: "MetodoID");

            migrationBuilder.RenameColumn(
                name: "fecha",
                table: "Pagos",
                newName: "Fecha");

            migrationBuilder.RenameColumn(
                name: "clienteID",
                table: "Pagos",
                newName: "ClienteID");

            migrationBuilder.RenameColumn(
                name: "pagoID",
                table: "Pagos",
                newName: "PagoID");

            migrationBuilder.RenameIndex(
                name: "IX_Pagos_usuarioID",
                table: "Pagos",
                newName: "IX_Pagos_UsuarioID");

            migrationBuilder.RenameIndex(
                name: "IX_Pagos_polizaID",
                table: "Pagos",
                newName: "IX_Pagos_PolizaID");

            migrationBuilder.RenameIndex(
                name: "IX_Pagos_clienteID",
                table: "Pagos",
                newName: "IX_Pagos_ClienteID");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Empresas",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "empresaID",
                table: "Empresas",
                newName: "EmpresaID");

            migrationBuilder.RenameColumn(
                name: "tipo",
                table: "Coberturas",
                newName: "Tipo");

            migrationBuilder.RenameColumn(
                name: "coberturaID",
                table: "Coberturas",
                newName: "CoberturaID");

            migrationBuilder.RenameColumn(
                name: "telefono",
                table: "Clientes",
                newName: "Telefono");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Clientes",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "mail",
                table: "Clientes",
                newName: "Mail");

            migrationBuilder.RenameColumn(
                name: "direccion",
                table: "Clientes",
                newName: "Direccion");

            migrationBuilder.RenameColumn(
                name: "ciudad",
                table: "Clientes",
                newName: "Ciudad");

            migrationBuilder.RenameColumn(
                name: "apellido",
                table: "Clientes",
                newName: "Apellido");

            migrationBuilder.RenameColumn(
                name: "clienteID",
                table: "Clientes",
                newName: "ClienteID");

            migrationBuilder.AlterColumn<string>(
                name: "Patente",
                table: "Vehiculos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "mail",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "contraseña",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "metodo",
                table: "MetodoPagos",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Tipo",
                table: "Coberturas",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Telefono",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Nombre",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Direccion",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Apellido",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_PolizaID",
                table: "Vehiculos",
                column: "PolizaID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Clientes_ClienteID",
                table: "Pagos",
                column: "ClienteID",
                principalTable: "Clientes",
                principalColumn: "ClienteID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Polizas_PolizaID",
                table: "Pagos",
                column: "PolizaID",
                principalTable: "Polizas",
                principalColumn: "PolizaID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Usuarios_UsuarioID",
                table: "Pagos",
                column: "UsuarioID",
                principalTable: "Usuarios",
                principalColumn: "usuarioID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_Coberturas_CoberturaID",
                table: "Polizas",
                column: "CoberturaID",
                principalTable: "Coberturas",
                principalColumn: "CoberturaID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_Empresas_EmpresaID",
                table: "Polizas",
                column: "EmpresaID",
                principalTable: "Empresas",
                principalColumn: "EmpresaID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Clientes_ClienteID",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Polizas_PolizaID",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Pagos_Usuarios_UsuarioID",
                table: "Pagos");

            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_Coberturas_CoberturaID",
                table: "Polizas");

            migrationBuilder.DropForeignKey(
                name: "FK_Polizas_Empresas_EmpresaID",
                table: "Polizas");

            migrationBuilder.DropIndex(
                name: "IX_Vehiculos_PolizaID",
                table: "Vehiculos");

            migrationBuilder.RenameColumn(
                name: "Patente",
                table: "Vehiculos",
                newName: "patente");

            migrationBuilder.RenameColumn(
                name: "Marca",
                table: "Vehiculos",
                newName: "marca");

            migrationBuilder.RenameColumn(
                name: "Año",
                table: "Vehiculos",
                newName: "año");

            migrationBuilder.RenameColumn(
                name: "VehiculoID",
                table: "Vehiculos",
                newName: "vehiculoID");

            migrationBuilder.RenameColumn(
                name: "ValorCuota",
                table: "Polizas",
                newName: "valorCuota");

            migrationBuilder.RenameColumn(
                name: "ValorAsegurado",
                table: "Polizas",
                newName: "valorAsegurado");

            migrationBuilder.RenameColumn(
                name: "NroPoliza",
                table: "Polizas",
                newName: "nroPoliza");

            migrationBuilder.RenameColumn(
                name: "InicioVigencia",
                table: "Polizas",
                newName: "inicioVigencia");

            migrationBuilder.RenameColumn(
                name: "FinVigencia",
                table: "Polizas",
                newName: "finVigencia");

            migrationBuilder.RenameColumn(
                name: "EmpresaID",
                table: "Polizas",
                newName: "empresaID");

            migrationBuilder.RenameColumn(
                name: "CoberturaID",
                table: "Polizas",
                newName: "coberturaID");

            migrationBuilder.RenameColumn(
                name: "PolizaID",
                table: "Polizas",
                newName: "polizaID");

            migrationBuilder.RenameIndex(
                name: "IX_Polizas_EmpresaID",
                table: "Polizas",
                newName: "IX_Polizas_empresaID");

            migrationBuilder.RenameIndex(
                name: "IX_Polizas_CoberturaID",
                table: "Polizas",
                newName: "IX_Polizas_coberturaID");

            migrationBuilder.RenameColumn(
                name: "UsuarioID",
                table: "Pagos",
                newName: "usuarioID");

            migrationBuilder.RenameColumn(
                name: "PolizaID",
                table: "Pagos",
                newName: "polizaID");

            migrationBuilder.RenameColumn(
                name: "Monto",
                table: "Pagos",
                newName: "monto");

            migrationBuilder.RenameColumn(
                name: "MetodoID",
                table: "Pagos",
                newName: "metodoID");

            migrationBuilder.RenameColumn(
                name: "Fecha",
                table: "Pagos",
                newName: "fecha");

            migrationBuilder.RenameColumn(
                name: "ClienteID",
                table: "Pagos",
                newName: "clienteID");

            migrationBuilder.RenameColumn(
                name: "PagoID",
                table: "Pagos",
                newName: "pagoID");

            migrationBuilder.RenameIndex(
                name: "IX_Pagos_UsuarioID",
                table: "Pagos",
                newName: "IX_Pagos_usuarioID");

            migrationBuilder.RenameIndex(
                name: "IX_Pagos_PolizaID",
                table: "Pagos",
                newName: "IX_Pagos_polizaID");

            migrationBuilder.RenameIndex(
                name: "IX_Pagos_ClienteID",
                table: "Pagos",
                newName: "IX_Pagos_clienteID");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Empresas",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "EmpresaID",
                table: "Empresas",
                newName: "empresaID");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Coberturas",
                newName: "tipo");

            migrationBuilder.RenameColumn(
                name: "CoberturaID",
                table: "Coberturas",
                newName: "coberturaID");

            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "Clientes",
                newName: "telefono");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Clientes",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Mail",
                table: "Clientes",
                newName: "mail");

            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "Clientes",
                newName: "direccion");

            migrationBuilder.RenameColumn(
                name: "Ciudad",
                table: "Clientes",
                newName: "ciudad");

            migrationBuilder.RenameColumn(
                name: "Apellido",
                table: "Clientes",
                newName: "apellido");

            migrationBuilder.RenameColumn(
                name: "ClienteID",
                table: "Clientes",
                newName: "clienteID");

            migrationBuilder.AlterColumn<string>(
                name: "patente",
                table: "Vehiculos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "mail",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "contraseña",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "metodo",
                table: "MetodoPagos",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Empresas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "tipo",
                table: "Coberturas",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "telefono",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "nombre",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "direccion",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "apellido",
                table: "Clientes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Vehiculos_PolizaID",
                table: "Vehiculos",
                column: "PolizaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Clientes_clienteID",
                table: "Pagos",
                column: "clienteID",
                principalTable: "Clientes",
                principalColumn: "clienteID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Polizas_polizaID",
                table: "Pagos",
                column: "polizaID",
                principalTable: "Polizas",
                principalColumn: "polizaID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Pagos_Usuarios_usuarioID",
                table: "Pagos",
                column: "usuarioID",
                principalTable: "Usuarios",
                principalColumn: "usuarioID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_Coberturas_coberturaID",
                table: "Polizas",
                column: "coberturaID",
                principalTable: "Coberturas",
                principalColumn: "coberturaID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Polizas_Empresas_empresaID",
                table: "Polizas",
                column: "empresaID",
                principalTable: "Empresas",
                principalColumn: "empresaID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
