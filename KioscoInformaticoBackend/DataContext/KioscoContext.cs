﻿using System;
using System.Collections.Generic;
using KioscoInformaticoServices.Enums;
using KioscoInformaticoServices.Models;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace KioscoInformaticoBackend.DataContext;

public partial class KioscoContext : DbContext
{   
    public KioscoContext()
    {
    }

    public KioscoContext(DbContextOptions<KioscoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Compra> Compras { get; set; }

    public virtual DbSet<DetalleCompra> Detallescompras { get; set; }

    public virtual DbSet<DetalleVenta> Detallesventas { get; set; }

    public virtual DbSet<Localidad> Localidades { get; set; }

    public virtual DbSet<Producto> Productos { get; set; }

    public virtual DbSet<Proveedor> Proveedores { get; set; }

    public virtual DbSet<Venta> Ventas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var configuration = new ConfigurationBuilder()
                                //.SetBasePath(Directory.GetCurrentDirectory()) Especifica para escritorio
                                .AddJsonFile("appsettings.json")
                                .Build();
        string? cadenaConexion = configuration.GetConnectionString("mysqlRemoto");

        optionsBuilder.UseMySql(cadenaConexion, ServerVersion.AutoDetect(cadenaConexion));
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        #region Configuracion de tablas
        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("clientes");

            entity.HasIndex(e => e.LocalidadId, "IX_Clientes_LocalidadId");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.FechaNacimiento).HasMaxLength(6);
            entity.Property(e => e.LocalidadId).HasColumnType("int(11)");

          //  entity.HasOne(d => d.Localidad).WithMany(p => p.Clientes)
            //    .HasForeignKey(d => d.LocalidadId)
           //     .HasConstraintName("FK_Clientes_Localidades_LocalidadId");
        });

        modelBuilder.Entity<Compra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("compras");

            entity.HasIndex(e => e.ProveedorID, "IX_Compras_ProveedorID");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Fecha).HasMaxLength(6);
            entity.Property(e => e.FormaDePago).HasColumnType("int(11)");
            entity.Property(e => e.Iva).HasColumnType("int(11)");
            entity.Property(e => e.ProveedorID)
                .HasColumnType("int(11)")
                .HasColumnName("ProveedorID");
            entity.Property(e => e.Total).HasColumnType("int(11)");

            entity.HasOne(d => d.Proveedor).WithMany(p => p.Compras)
                .HasForeignKey(d => d.ProveedorID)
                .HasConstraintName("FK_Compras_Proveedores_ProveedorID");
        });

        modelBuilder.Entity<DetalleCompra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("detallescompras");

            entity.HasIndex(e => e.ProductoId, "IX_DetallesCompras_ProductoId");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Cantidad).HasColumnType("int(11)");
            entity.Property(e => e.CompraId).HasColumnType("int(11)");
            entity.Property(e => e.ProductoId).HasColumnType("int(11)");

            entity.HasOne(d => d.Producto).WithMany(p => p.DetallesCompras)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK_DetallesCompras_Productos_ProductoId");
        });

        modelBuilder.Entity<DetalleVenta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("detallesventas");

            entity.HasIndex(e => e.ProductoId, "IX_DetallesVentas_ProductoId");

            entity.HasIndex(e => e.VentaId, "IX_DetallesVentas_VentaId");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.Cantidad).HasColumnType("int(11)");
            entity.Property(e => e.ProductoId).HasColumnType("int(11)");
            entity.Property(e => e.VentaId).HasColumnType("int(11)");

            entity.HasOne(d => d.Producto).WithMany(p => p.DetallesVenta)
                .HasForeignKey(d => d.ProductoId)
                .HasConstraintName("FK_DetallesVentas_Productos_ProductoId");

            entity.HasOne(d => d.Venta).WithMany(p => p.Detallesventa)
                .HasForeignKey(d => d.VentaId)
                .HasConstraintName("FK_DetallesVentas_Ventas_VentaId");
        });

        modelBuilder.Entity<Localidad>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("localidades");

            entity.Property(e => e.Id).HasColumnType("int(11)");
        });

        modelBuilder.Entity<Producto>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("productos");

            entity.Property(e => e.Id).HasColumnType("int(11)");
        });

        modelBuilder.Entity<Proveedor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("proveedores");

            entity.HasIndex(e => e.LocalidadId, "IX_Proveedores_LocalidadId");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.CondicionIva).HasColumnType("int(11)");
            entity.Property(e => e.LocalidadId).HasColumnType("int(11)");

         //   entity.HasOne(d => d.Localidad).WithMany(p => p.Proveedores)
         //       .HasForeignKey(d => d.LocalidadId)
         //       .HasConstraintName("FK_Proveedores_Localidades_LocalidadId");
        });

        modelBuilder.Entity<Venta>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("ventas");

            entity.HasIndex(e => e.ClienteId, "IX_Ventas_ClienteId");

            entity.Property(e => e.Id).HasColumnType("int(11)");
            entity.Property(e => e.ClienteId).HasColumnType("int(11)");
            entity.Property(e => e.Fecha).HasMaxLength(6);
            entity.Property(e => e.FormaPago).HasColumnType("int(11)");

         //   entity.HasOne(d => d.Cliente).WithMany(p => p.Venta)
           //     .HasForeignKey(d => d.ClienteId)
             //   .HasConstraintName("FK_Ventas_Clientes_ClienteId");
        });
        #endregion

        #region Datos Semilla
        //carga de datos semilla Productos
        modelBuilder.Entity<Producto>().HasData(
            new Producto() { Id = 1, Nombre = "Coca Cola 2lts", Precio = 2650 },
            new Producto() { Id = 2, Nombre = "Sprite 2lts", Precio = 2450 },
            new Producto() { Id = 3, Nombre = "Fanta 2lts", Precio = 2550 }
            );
        //carga de datos semilla de localidades
        modelBuilder.Entity<Localidad>().HasData(
            new Localidad() { Id = 1, Nombre = "San Justo" },
            new Localidad() { Id = 2, Nombre = "Videla" },
            new Localidad() { Id = 3, Nombre = "Escalada" }
            );
        //carga de datos semilla de clientes
        modelBuilder.Entity<Cliente>().HasData(
        new Cliente
        {
            Id = 1,
            Nombre = "Juan Pérez",
            Direccion = "Calle Falsa 123",
            Telefonos = "123456789",
            FechaNacimiento = new DateTime(1985, 5, 15),
            LocalidadId = 1
        },
        new Cliente
        {
            Id = 2,
            Nombre = "María López",
            Direccion = "Avenida Siempre Viva 742",
            Telefonos = "987654321",
            FechaNacimiento = new DateTime(1990, 8, 25),
            LocalidadId = 2
        },
        new Cliente
        {
            Id = 3,
            Nombre = "Carlos García",
            Direccion = "Boulevard de los Sueños Rotos 101",
            Telefonos = "555666777",
            FechaNacimiento = new DateTime(1978, 2, 3),
            LocalidadId = 3
        },
        new Cliente
        {
            Id = 4,
            Nombre = "Ana Martínez",
            Direccion = "Ruta Nacional 19 Km 58",
            Telefonos = "444555666",
            FechaNacimiento = new DateTime(2000, 12, 12),
            LocalidadId = 1
        },
        new Cliente
        {
            Id = 5,
            Nombre = "Pedro Fernández",
            Direccion = "Calle del Sol 456",
            Telefonos = "333444555",
            FechaNacimiento = new DateTime(1995, 7, 30),
            LocalidadId = 2
        }
        );
        //Carga de datos semillas de ventas
        modelBuilder.Entity<Venta>().HasData(

            new Venta() { Id = 1, FormaPago = FormaDePagoEnum.Efectivo, Iva = 21m, Total = 3000m, ClienteId = 1, Fecha = DateTime.Now },
            new Venta() { Id = 2, FormaPago = FormaDePagoEnum.Tarjeta_Credito, Iva = 10, Total = 5000m, ClienteId = 2, Fecha = DateTime.Now },
            new Venta() { Id = 3, FormaPago = FormaDePagoEnum.Tarjeta_Debito, Iva = 21, Total = 8000m, ClienteId = 3, Fecha = DateTime.Now },
            new Venta() { Id = 4, FormaPago = FormaDePagoEnum.Transferencia, Iva = 0, Total = 10000m, ClienteId = 4, Fecha = DateTime.Now }
        );
        //carga de datos semilla de proveedores
        modelBuilder.Entity<Proveedor>().HasData(
        new Proveedor
        {
            Id = 1,
            Nombre = "Proveedor A",
            Direccion = "Calle 1",
            Telefonos = "111111111",
            Cbu = "0000003100010000000001",
            CondicionIva = CondicionIvaEnum.ResponsableInscripto,
            LocalidadId = 1
        },
        new Proveedor
        {
            Id = 2,
            Nombre = "Proveedor B",
            Direccion = "Calle 2",
            Telefonos = "222222222",
            Cbu = "0000003100010000000002",
            CondicionIva = CondicionIvaEnum.Monotributista,
            LocalidadId = 2
        },
        new Proveedor
        {
            Id = 3,
            Nombre = "Proveedor C",
            Direccion = "Calle 3",
            Telefonos = "333333333",
            Cbu = "0000003100010000000003",
            CondicionIva = CondicionIvaEnum.ConsumidorFinal,
            LocalidadId = 3
        },
        new Proveedor
        {
            Id = 4,
            Nombre = "Proveedor D",
            Direccion = "Calle 4",
            Telefonos = "444444444",
            Cbu = "0000003100010000000004",
            CondicionIva = CondicionIvaEnum.Exento,
            LocalidadId = 3
        },
        new Proveedor
        {
            Id = 5,
            Nombre = "Proveedor E",
            Direccion = "Calle 5",
            Telefonos = "555555555",
            Cbu = "0000003100010000000005",
            CondicionIva = CondicionIvaEnum.NoResponsable,
            LocalidadId = 2
        },
        new Proveedor
        {
            Id = 6,
            Nombre = "Proveedor F",
            Direccion = "Calle 6",
            Telefonos = "666666666",
            Cbu = "0000003100010000000006",
            CondicionIva = CondicionIvaEnum.ResponsableNoInscripto,
            LocalidadId = 1
        },
        new Proveedor
        {
            Id = 7,
            Nombre = "Proveedor G",
            Direccion = "Calle 7",
            Telefonos = "777777777",
            Cbu = "0000003100010000000007",
            CondicionIva = CondicionIvaEnum.ResponsableInscripto,
            LocalidadId = 2
        },
        new Proveedor
        {
            Id = 8,
            Nombre = "Proveedor H",
            Direccion = "Calle 8",
            Telefonos = "888888888",
            Cbu = "0000003100010000000008",
            CondicionIva = CondicionIvaEnum.SujetoNoCategorizado,
            LocalidadId = 1
        },
        new Proveedor
        {
            Id = 9,
            Nombre = "Proveedor I",
            Direccion = "Calle 9",
            Telefonos = "999999999",
            Cbu = "0000003100010000000009",
            CondicionIva = CondicionIvaEnum.Monotributista,
            LocalidadId = 3
        },
        new Proveedor
        {
            Id = 10,
            Nombre = "Proveedor J",
            Direccion = "Calle 10",
            Telefonos = "101010101",
            Cbu = "0000003100010000000010",
            CondicionIva = CondicionIvaEnum.Exento,
            LocalidadId = 1
        }
    );
        //carga de datos semilla de compras
        modelBuilder.Entity<Compra>().HasData(
            new Compra
            {
                Id = 1,
                FormaDePago = FormaDePagoEnum.Efectivo,
                Iva = 21,
                Total = 1000,
                Fecha = new DateTime(2021, 5, 15),
                ProveedorID = 1
            },
            new Compra
            {
                Id = 2,
                FormaDePago = FormaDePagoEnum.Tarjeta_Debito,
                Iva = 10,
                Total = 2000,
                Fecha = new DateTime(2021, 5, 16),
                ProveedorID = 2
            },
            new Compra
            {
                Id = 3,
                FormaDePago = FormaDePagoEnum.Tarjeta_Credito,
                Iva = 5,
                Total = 3000,
                Fecha = new DateTime(2021, 5, 17),
                ProveedorID = 3
            },
            new Compra
            {
                Id = 4,
                FormaDePago = FormaDePagoEnum.Transferencia,
                Iva = 0,
                Total = 4000,
                Fecha = new DateTime(2021, 5, 18),
                ProveedorID = 4
            }
        );
        //carga de datos semilla de detalle compra
        modelBuilder.Entity<DetalleCompra>().HasData(
            new DetalleCompra { Id = 1, ProductoId = 1, PrecioUnitario = 2650, Cantidad = 1, CompraId = 1 },
            new DetalleCompra { Id = 2, ProductoId = 2, PrecioUnitario = 2450, Cantidad = 2, CompraId = 2 },
            new DetalleCompra { Id = 3, ProductoId = 3, PrecioUnitario = 2550, Cantidad = 1, CompraId = 3 }
            );
        //carga de datos semilla de detalle venta
        modelBuilder.Entity<DetalleVenta>().HasData(
            new DetalleVenta { Id = 1, VentaId = 1, ProductoId = 1, Cantidad = 1, PrecioUnitario = 2650 },
            new DetalleVenta { Id = 2, VentaId = 2, ProductoId = 2, Cantidad = 2, PrecioUnitario = 2450 },
            new DetalleVenta { Id = 3, VentaId = 3, ProductoId = 3, Cantidad = 1, PrecioUnitario = 2550 }
            );
        #endregion

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
