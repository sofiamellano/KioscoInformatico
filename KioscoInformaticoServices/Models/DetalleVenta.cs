﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace KioscoInformaticoServices.Models;

public partial class DetalleVenta
{
    public int Id { get; set; }

    public virtual Producto? Producto { get; set; } = null!;

    public decimal PrecioUnitario { get; set; }

    public int Cantidad { get; set; }

    [NotMapped]
    public decimal Subtotal => Cantidad * PrecioUnitario;

    public int VentaId { get; set; }

    public int ProductoId { get; set; }

    public virtual Venta? Venta { get; set; } = null!;
    public bool Eliminado { get; set; } = false;
}