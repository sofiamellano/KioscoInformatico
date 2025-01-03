﻿// <auto-generated />
using System;
using KioscoInformaticoBackend.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KioscoInformaticoBackend.Migrations
{
    [DbContext(typeof(KioscoContext))]
    partial class KioscoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("KioscoInformaticoServices.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime(6)");

                    b.Property<int?>("LocalidadId")
                        .IsRequired()
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefonos")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("LocalidadId");

                    b.ToTable("Clientes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Direccion = "Calle Falsa 123",
                            Eliminado = false,
                            FechaNacimiento = new DateTime(1985, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocalidadId = 1,
                            Nombre = "Juan Pérez",
                            Telefonos = "123456789"
                        },
                        new
                        {
                            Id = 2,
                            Direccion = "Avenida Siempre Viva 742",
                            Eliminado = false,
                            FechaNacimiento = new DateTime(1990, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocalidadId = 2,
                            Nombre = "María López",
                            Telefonos = "987654321"
                        },
                        new
                        {
                            Id = 3,
                            Direccion = "Boulevard de los Sueños Rotos 101",
                            Eliminado = false,
                            FechaNacimiento = new DateTime(1978, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocalidadId = 3,
                            Nombre = "Carlos García",
                            Telefonos = "555666777"
                        },
                        new
                        {
                            Id = 4,
                            Direccion = "Ruta Nacional 19 Km 58",
                            Eliminado = false,
                            FechaNacimiento = new DateTime(2000, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocalidadId = 1,
                            Nombre = "Ana Martínez",
                            Telefonos = "444555666"
                        },
                        new
                        {
                            Id = 5,
                            Direccion = "Calle del Sol 456",
                            Eliminado = false,
                            FechaNacimiento = new DateTime(1995, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            LocalidadId = 2,
                            Nombre = "Pedro Fernández",
                            Telefonos = "333444555"
                        });
                });

            modelBuilder.Entity("KioscoInformaticoServices.Models.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FormaDePago")
                        .HasColumnType("int");

                    b.Property<decimal>("Iva")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int?>("ProveedorID")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("ProveedorID");

                    b.ToTable("Compras");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Eliminado = false,
                            Fecha = new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FormaDePago = 0,
                            Iva = 21m,
                            ProveedorID = 1,
                            Total = 1000m
                        },
                        new
                        {
                            Id = 2,
                            Eliminado = false,
                            Fecha = new DateTime(2021, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FormaDePago = 2,
                            Iva = 10m,
                            ProveedorID = 2,
                            Total = 2000m
                        },
                        new
                        {
                            Id = 3,
                            Eliminado = false,
                            Fecha = new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FormaDePago = 1,
                            Iva = 5m,
                            ProveedorID = 3,
                            Total = 3000m
                        },
                        new
                        {
                            Id = 4,
                            Eliminado = false,
                            Fecha = new DateTime(2021, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            FormaDePago = 3,
                            Iva = 0m,
                            ProveedorID = 4,
                            Total = 4000m
                        });
                });

            modelBuilder.Entity("KioscoInformaticoServices.Models.DetalleCompra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("CompraId")
                        .HasColumnType("int");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompraId");

                    b.HasIndex("ProductoId");

                    b.ToTable("Detallescompras");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cantidad = 1,
                            CompraId = 1,
                            Eliminado = false,
                            PrecioUnitario = 2650m,
                            ProductoId = 1
                        },
                        new
                        {
                            Id = 2,
                            Cantidad = 2,
                            CompraId = 2,
                            Eliminado = false,
                            PrecioUnitario = 2450m,
                            ProductoId = 2
                        },
                        new
                        {
                            Id = 3,
                            Cantidad = 1,
                            CompraId = 3,
                            Eliminado = false,
                            PrecioUnitario = 2550m,
                            ProductoId = 3
                        });
                });

            modelBuilder.Entity("KioscoInformaticoServices.Models.DetalleVenta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("PrecioUnitario")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<int>("VentaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProductoId");

                    b.HasIndex("VentaId");

                    b.ToTable("Detallesventas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cantidad = 1,
                            Eliminado = false,
                            PrecioUnitario = 2650m,
                            ProductoId = 1,
                            VentaId = 1
                        },
                        new
                        {
                            Id = 2,
                            Cantidad = 2,
                            Eliminado = false,
                            PrecioUnitario = 2450m,
                            ProductoId = 2,
                            VentaId = 2
                        },
                        new
                        {
                            Id = 3,
                            Cantidad = 1,
                            Eliminado = false,
                            PrecioUnitario = 2550m,
                            ProductoId = 3,
                            VentaId = 3
                        });
                });

            modelBuilder.Entity("KioscoInformaticoServices.Models.Localidad", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Localidades");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Eliminado = false,
                            Nombre = "San Justo"
                        },
                        new
                        {
                            Id = 2,
                            Eliminado = false,
                            Nombre = "Videla"
                        },
                        new
                        {
                            Id = 3,
                            Eliminado = false,
                            Nombre = "Escalada"
                        });
                });

            modelBuilder.Entity("KioscoInformaticoServices.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Imagen")
                        .HasColumnType("longtext");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Oferta")
                        .HasColumnType("tinyint(1)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Eliminado = false,
                            Imagen = "",
                            Nombre = "Coca Cola 2lts",
                            Oferta = false,
                            Precio = 2650m
                        },
                        new
                        {
                            Id = 2,
                            Eliminado = false,
                            Imagen = "",
                            Nombre = "Sprite 2lts",
                            Oferta = false,
                            Precio = 2450m
                        },
                        new
                        {
                            Id = 3,
                            Eliminado = false,
                            Imagen = "",
                            Nombre = "Fanta 2lts",
                            Oferta = false,
                            Precio = 2550m
                        });
                });

            modelBuilder.Entity("KioscoInformaticoServices.Models.Proveedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Cbu")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CondicionIva")
                        .HasColumnType("int");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<int?>("LocalidadId")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Telefonos")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("LocalidadId");

                    b.ToTable("Proveedores");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Cbu = "0000003100010000000001",
                            CondicionIva = 1,
                            Direccion = "Calle 1",
                            Eliminado = false,
                            LocalidadId = 1,
                            Nombre = "Proveedor A",
                            Telefonos = "111111111"
                        },
                        new
                        {
                            Id = 2,
                            Cbu = "0000003100010000000002",
                            CondicionIva = 6,
                            Direccion = "Calle 2",
                            Eliminado = false,
                            LocalidadId = 2,
                            Nombre = "Proveedor B",
                            Telefonos = "222222222"
                        },
                        new
                        {
                            Id = 3,
                            Cbu = "0000003100010000000003",
                            CondicionIva = 5,
                            Direccion = "Calle 3",
                            Eliminado = false,
                            LocalidadId = 3,
                            Nombre = "Proveedor C",
                            Telefonos = "333333333"
                        },
                        new
                        {
                            Id = 4,
                            Cbu = "0000003100010000000004",
                            CondicionIva = 3,
                            Direccion = "Calle 4",
                            Eliminado = false,
                            LocalidadId = 3,
                            Nombre = "Proveedor D",
                            Telefonos = "444444444"
                        },
                        new
                        {
                            Id = 5,
                            Cbu = "0000003100010000000005",
                            CondicionIva = 4,
                            Direccion = "Calle 5",
                            Eliminado = false,
                            LocalidadId = 2,
                            Nombre = "Proveedor E",
                            Telefonos = "555555555"
                        },
                        new
                        {
                            Id = 6,
                            Cbu = "0000003100010000000006",
                            CondicionIva = 2,
                            Direccion = "Calle 6",
                            Eliminado = false,
                            LocalidadId = 1,
                            Nombre = "Proveedor F",
                            Telefonos = "666666666"
                        },
                        new
                        {
                            Id = 7,
                            Cbu = "0000003100010000000007",
                            CondicionIva = 1,
                            Direccion = "Calle 7",
                            Eliminado = false,
                            LocalidadId = 2,
                            Nombre = "Proveedor G",
                            Telefonos = "777777777"
                        },
                        new
                        {
                            Id = 8,
                            Cbu = "0000003100010000000008",
                            CondicionIva = 7,
                            Direccion = "Calle 8",
                            Eliminado = false,
                            LocalidadId = 1,
                            Nombre = "Proveedor H",
                            Telefonos = "888888888"
                        },
                        new
                        {
                            Id = 9,
                            Cbu = "0000003100010000000009",
                            CondicionIva = 6,
                            Direccion = "Calle 9",
                            Eliminado = false,
                            LocalidadId = 3,
                            Nombre = "Proveedor I",
                            Telefonos = "999999999"
                        },
                        new
                        {
                            Id = 10,
                            Cbu = "0000003100010000000010",
                            CondicionIva = 3,
                            Direccion = "Calle 10",
                            Eliminado = false,
                            LocalidadId = 1,
                            Nombre = "Proveedor J",
                            Telefonos = "101010101"
                        });
                });

            modelBuilder.Entity("KioscoInformaticoServices.Models.Venta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ClienteId")
                        .HasColumnType("int");

                    b.Property<bool>("Eliminado")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FormaPago")
                        .HasColumnType("int");

                    b.Property<decimal>("Iva")
                        .HasColumnType("decimal(65,30)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("Id");

                    b.HasIndex("ClienteId");

                    b.ToTable("Ventas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClienteId = 1,
                            Eliminado = false,
                            Fecha = new DateTime(2024, 11, 13, 16, 37, 39, 22, DateTimeKind.Local).AddTicks(3777),
                            FormaPago = 0,
                            Iva = 21m,
                            Total = 3000m
                        },
                        new
                        {
                            Id = 2,
                            ClienteId = 2,
                            Eliminado = false,
                            Fecha = new DateTime(2024, 11, 13, 16, 37, 39, 22, DateTimeKind.Local).AddTicks(3789),
                            FormaPago = 1,
                            Iva = 10m,
                            Total = 5000m
                        },
                        new
                        {
                            Id = 3,
                            ClienteId = 3,
                            Eliminado = false,
                            Fecha = new DateTime(2024, 11, 13, 16, 37, 39, 22, DateTimeKind.Local).AddTicks(3792),
                            FormaPago = 2,
                            Iva = 21m,
                            Total = 8000m
                        },
                        new
                        {
                            Id = 4,
                            ClienteId = 4,
                            Eliminado = false,
                            Fecha = new DateTime(2024, 11, 13, 16, 37, 39, 22, DateTimeKind.Local).AddTicks(3796),
                            FormaPago = 3,
                            Iva = 0m,
                            Total = 10000m
                        });
                });

            modelBuilder.Entity("KioscoInformaticoServices.Models.Cliente", b =>
                {
                    b.HasOne("KioscoInformaticoServices.Models.Localidad", "Localidad")
                        .WithMany()
                        .HasForeignKey("LocalidadId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Localidad");
                });

            modelBuilder.Entity("KioscoInformaticoServices.Models.Compra", b =>
                {
                    b.HasOne("KioscoInformaticoServices.Models.Proveedor", "Proveedor")
                        .WithMany()
                        .HasForeignKey("ProveedorID");

                    b.Navigation("Proveedor");
                });

            modelBuilder.Entity("KioscoInformaticoServices.Models.DetalleCompra", b =>
                {
                    b.HasOne("KioscoInformaticoServices.Models.Compra", "Compra")
                        .WithMany("Detallescompra")
                        .HasForeignKey("CompraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KioscoInformaticoServices.Models.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Compra");

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("KioscoInformaticoServices.Models.DetalleVenta", b =>
                {
                    b.HasOne("KioscoInformaticoServices.Models.Producto", "Producto")
                        .WithMany()
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("KioscoInformaticoServices.Models.Venta", "Venta")
                        .WithMany("Detallesventa")
                        .HasForeignKey("VentaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");

                    b.Navigation("Venta");
                });

            modelBuilder.Entity("KioscoInformaticoServices.Models.Proveedor", b =>
                {
                    b.HasOne("KioscoInformaticoServices.Models.Localidad", "Localidad")
                        .WithMany()
                        .HasForeignKey("LocalidadId");

                    b.Navigation("Localidad");
                });

            modelBuilder.Entity("KioscoInformaticoServices.Models.Venta", b =>
                {
                    b.HasOne("KioscoInformaticoServices.Models.Cliente", "Cliente")
                        .WithMany()
                        .HasForeignKey("ClienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("KioscoInformaticoServices.Models.Compra", b =>
                {
                    b.Navigation("Detallescompra");
                });

            modelBuilder.Entity("KioscoInformaticoServices.Models.Venta", b =>
                {
                    b.Navigation("Detallesventa");
                });
#pragma warning restore 612, 618
        }
    }
}
