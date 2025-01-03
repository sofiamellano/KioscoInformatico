﻿using KioscoInformaticoServices.Enums;
using System;
using System.Collections.Generic;

namespace KioscoInformaticoServices.Models;

public partial class Venta
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public int ClienteId { get; set; }
    public virtual Cliente? Cliente { get; set; } = null!;
    public FormaDePagoEnum FormaPago { get; set; }
    public decimal Iva { get; set; }
    public decimal Total { get; set; }
    public bool Eliminado { get; set; } = false;
    public virtual ICollection<DetalleVenta> Detallesventa { get; set; } = new List<DetalleVenta>();
}
