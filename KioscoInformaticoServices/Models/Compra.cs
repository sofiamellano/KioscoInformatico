﻿using KioscoInformaticoServices.Enums;
using System;
using System.Collections.Generic;

namespace KioscoInformaticoServices.Models;

public partial class Compra
{
    public int Id { get; set; }

    public FormaDePagoEnum FormaDePago { get; set; }

    public decimal Iva { get; set; }

    public decimal Total { get; set; }

    public DateTime Fecha { get; set; }

    public int? ProveedorID { get; set; }

    public virtual Proveedor? Proveedor { get; set; }
    public bool Eliminado { get; set; } = false;
    public virtual ICollection<DetalleCompra> Detallescompra { get; set; } = new List<DetalleCompra>();
}
