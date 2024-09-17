using KioscoInformaticoServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioscoInformaticoServices.Class
{
    public static class ApiEndpoints
    {
        public static string Cliente { get; set; } = "clientes";
        public static string Compra { get; set; } = "compras";
        public static string Producto { get; set; } = "productos";
        public static string Proveedor { get; set; } = "proveedores";
        public static string Venta { get; set; } = "ventas";
        public static string DetallesVenta { get; set; } = "detallesventas";
        public static string DetallesCompra { get; set; } = "detallescompra";
        public static string Localidad { get; set; } = "localidades";

        public static string GetEndpoint(string name)
        {
            return name switch
            {
                nameof(Cliente) => Cliente,
                nameof(Compra) => Compra,
                nameof(Producto) => Producto,
                nameof(Proveedor) => Proveedor,
                nameof(Venta) => Venta,
                nameof(DetallesVenta) => DetallesVenta,
                nameof(DetallesCompra) => DetallesCompra,
                nameof(Localidad) => Localidad,
                _ => throw new ArgumentException($"Endpoint '{name}' no está definido.")
            };
        }
    }

}
