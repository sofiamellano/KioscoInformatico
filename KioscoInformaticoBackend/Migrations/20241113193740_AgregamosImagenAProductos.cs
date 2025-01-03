﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KioscoInformaticoBackend.Migrations
{
    /// <inheritdoc />
    public partial class AgregamosImagenAProductos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Localidades_LocalidadId",
                table: "Clientes");

            migrationBuilder.AddColumn<string>(
                name: "Imagen",
                table: "Productos",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "Compras",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Iva",
                table: "Compras",
                type: "decimal(65,30)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "LocalidadId",
                table: "Clientes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Iva", "Total" },
                values: new object[] { 21m, 1000m });

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Iva", "Total" },
                values: new object[] { 10m, 2000m });

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Iva", "Total" },
                values: new object[] { 5m, 3000m });

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Iva", "Total" },
                values: new object[] { 0m, 4000m });

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 1,
                column: "Imagen",
                value: "");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 2,
                column: "Imagen",
                value: "");

            migrationBuilder.UpdateData(
                table: "Productos",
                keyColumn: "Id",
                keyValue: 3,
                column: "Imagen",
                value: "");

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 11, 13, 16, 37, 39, 22, DateTimeKind.Local).AddTicks(3777));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 11, 13, 16, 37, 39, 22, DateTimeKind.Local).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 11, 13, 16, 37, 39, 22, DateTimeKind.Local).AddTicks(3792));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2024, 11, 13, 16, 37, 39, 22, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.CreateIndex(
                name: "IX_Detallescompras_CompraId",
                table: "Detallescompras",
                column: "CompraId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Localidades_LocalidadId",
                table: "Clientes",
                column: "LocalidadId",
                principalTable: "Localidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Detallescompras_Compras_CompraId",
                table: "Detallescompras",
                column: "CompraId",
                principalTable: "Compras",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Localidades_LocalidadId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_Detallescompras_Compras_CompraId",
                table: "Detallescompras");

            migrationBuilder.DropIndex(
                name: "IX_Detallescompras_CompraId",
                table: "Detallescompras");

            migrationBuilder.DropColumn(
                name: "Imagen",
                table: "Productos");

            migrationBuilder.AlterColumn<int>(
                name: "Total",
                table: "Compras",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<int>(
                name: "Iva",
                table: "Compras",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.AlterColumn<int>(
                name: "LocalidadId",
                table: "Clientes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Iva", "Total" },
                values: new object[] { 21, 1000 });

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Iva", "Total" },
                values: new object[] { 10, 2000 });

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Iva", "Total" },
                values: new object[] { 5, 3000 });

            migrationBuilder.UpdateData(
                table: "Compras",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Iva", "Total" },
                values: new object[] { 0, 4000 });

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Fecha",
                value: new DateTime(2024, 10, 8, 16, 22, 17, 170, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Fecha",
                value: new DateTime(2024, 10, 8, 16, 22, 17, 170, DateTimeKind.Local).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 3,
                column: "Fecha",
                value: new DateTime(2024, 10, 8, 16, 22, 17, 170, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "Ventas",
                keyColumn: "Id",
                keyValue: 4,
                column: "Fecha",
                value: new DateTime(2024, 10, 8, 16, 22, 17, 170, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Localidades_LocalidadId",
                table: "Clientes",
                column: "LocalidadId",
                principalTable: "Localidades",
                principalColumn: "Id");
        }
    }
}
