﻿// <auto-generated />
using System;
using ConesaApp.Database.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConesaApp.Database.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.22")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ConesaApp.Database.Data.Entities.Cliente", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteID"), 1L, 1);

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteID");

                    b.HasIndex(new[] { "ClienteID" }, "clienteID_UQ")
                        .IsUnique();

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("ConesaApp.Database.Data.Entities.Cobertura", b =>
                {
                    b.Property<int>("CoberturaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CoberturaID"), 1L, 1);

                    b.Property<int?>("PolizaID")
                        .HasColumnType("int");

                    b.Property<string>("Tipo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CoberturaID");

                    b.HasIndex("PolizaID");

                    b.HasIndex(new[] { "CoberturaID" }, "coberturaID_UQ")
                        .IsUnique();

                    b.ToTable("Coberturas");
                });

            modelBuilder.Entity("ConesaApp.Database.Data.Entities.Empresa", b =>
                {
                    b.Property<int>("EmpresaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmpresaID"), 1L, 1);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmpresaID");

                    b.HasIndex(new[] { "EmpresaID" }, "empresaID_UQ")
                        .IsUnique();

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("ConesaApp.Database.Data.Entities.MetodoPago", b =>
                {
                    b.Property<int>("MetodoPagoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MetodoPagoID"), 1L, 1);

                    b.Property<string>("Metodo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MetodoPagoID");

                    b.HasIndex(new[] { "MetodoPagoID" }, "metodoPagoID_UQ")
                        .IsUnique();

                    b.ToTable("MetodoPagos");
                });

            modelBuilder.Entity("ConesaApp.Database.Data.Entities.Pagos", b =>
                {
                    b.Property<int>("PagoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PagoID"), 1L, 1);

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime2");

                    b.Property<int>("MetodoPagoID")
                        .HasColumnType("int");

                    b.Property<decimal>("Monto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PolizaID")
                        .HasColumnType("int");

                    b.Property<int>("UsuarioID")
                        .HasColumnType("int");

                    b.HasKey("PagoID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("MetodoPagoID");

                    b.HasIndex("PolizaID");

                    b.HasIndex("UsuarioID");

                    b.HasIndex(new[] { "PagoID" }, "pagoID_UQ")
                        .IsUnique();

                    b.ToTable("Pagos");
                });

            modelBuilder.Entity("ConesaApp.Database.Data.Entities.Poliza", b =>
                {
                    b.Property<int>("PolizaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PolizaID"), 1L, 1);

                    b.Property<bool>("Actualizado")
                        .HasColumnType("bit");

                    b.Property<int>("CoberturaID")
                        .HasColumnType("int");

                    b.Property<int>("EmpresaID")
                        .HasColumnType("int");

                    b.Property<DateTime>("FinVigencia")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("InicioVigencia")
                        .HasColumnType("datetime2");

                    b.Property<int>("NroPoliza")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorAsegurado")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ValorCuota")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("PolizaID");

                    b.HasIndex("CoberturaID");

                    b.HasIndex("EmpresaID");

                    b.HasIndex(new[] { "PolizaID" }, "polizaID_UQ")
                        .IsUnique();

                    b.ToTable("Polizas");
                });

            modelBuilder.Entity("ConesaApp.Database.Data.Entities.Usuario", b =>
                {
                    b.Property<int>("usuarioID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("usuarioID"), 1L, 1);

                    b.Property<string>("contraseña")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("mail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("usuarioID");

                    b.HasIndex(new[] { "usuarioID" }, "usuarioID_UQ")
                        .IsUnique();

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ConesaApp.Database.Data.Entities.Vehiculo", b =>
                {
                    b.Property<int>("VehiculoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VehiculoID"), 1L, 1);

                    b.Property<int?>("Año")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Patente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PolizaID")
                        .HasColumnType("int");

                    b.HasKey("VehiculoID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("PolizaID")
                        .IsUnique();

                    b.HasIndex(new[] { "VehiculoID" }, "vehiculoID_UQ")
                        .IsUnique();

                    b.ToTable("Vehiculos");
                });

            modelBuilder.Entity("ConesaApp.Database.Data.Entities.Cobertura", b =>
                {
                    b.HasOne("ConesaApp.Database.Data.Entities.Poliza", null)
                        .WithMany("cobertura")
                        .HasForeignKey("PolizaID")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("ConesaApp.Database.Data.Entities.Pagos", b =>
                {
                    b.HasOne("ConesaApp.Database.Data.Entities.Cliente", "Cliente")
                        .WithMany("Pagos")
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ConesaApp.Database.Data.Entities.MetodoPago", "MetodoPago")
                        .WithMany("Pagos")
                        .HasForeignKey("MetodoPagoID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ConesaApp.Database.Data.Entities.Poliza", "Poliza")
                        .WithMany("Pagos")
                        .HasForeignKey("PolizaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ConesaApp.Database.Data.Entities.Usuario", "Usuario")
                        .WithMany("Pagos")
                        .HasForeignKey("UsuarioID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("MetodoPago");

                    b.Navigation("Poliza");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("ConesaApp.Database.Data.Entities.Poliza", b =>
                {
                    b.HasOne("ConesaApp.Database.Data.Entities.Cobertura", "Cobertura")
                        .WithMany()
                        .HasForeignKey("CoberturaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ConesaApp.Database.Data.Entities.Empresa", "Empresa")
                        .WithMany("Polizas")
                        .HasForeignKey("EmpresaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cobertura");

                    b.Navigation("Empresa");
                });

            modelBuilder.Entity("ConesaApp.Database.Data.Entities.Vehiculo", b =>
                {
                    b.HasOne("ConesaApp.Database.Data.Entities.Cliente", "Cliente")
                        .WithMany("Vehiculos")
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ConesaApp.Database.Data.Entities.Poliza", "Poliza")
                        .WithOne("Vehiculo")
                        .HasForeignKey("ConesaApp.Database.Data.Entities.Vehiculo", "PolizaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cliente");

                    b.Navigation("Poliza");
                });

            modelBuilder.Entity("ConesaApp.Database.Data.Entities.Cliente", b =>
                {
                    b.Navigation("Pagos");

                    b.Navigation("Vehiculos");
                });

            modelBuilder.Entity("ConesaApp.Database.Data.Entities.Empresa", b =>
                {
                    b.Navigation("Polizas");
                });

            modelBuilder.Entity("ConesaApp.Database.Data.Entities.MetodoPago", b =>
                {
                    b.Navigation("Pagos");
                });

            modelBuilder.Entity("ConesaApp.Database.Data.Entities.Poliza", b =>
                {
                    b.Navigation("Pagos");

                    b.Navigation("Vehiculo");

                    b.Navigation("cobertura");
                });

            modelBuilder.Entity("ConesaApp.Database.Data.Entities.Usuario", b =>
                {
                    b.Navigation("Pagos");
                });
#pragma warning restore 612, 618
        }
    }
}
