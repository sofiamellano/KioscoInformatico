﻿using System;
using System.Collections.Generic;

namespace KioscoInformaticoServices.Models;

public partial class DetalleCompra
{
    public int Id { get; set; }

    public virtual Producto? Producto { get; set; }

    public decimal PrecioUnitario { get; set; }

    public int Cantidad { get; set; }

    public decimal Subtotal => Cantidad * PrecioUnitario;

    public int CompraId { get; set; }

    public int ProductoId { get; set; }

    public virtual Compra? Compra { get; set; } = null!;

    public bool Eliminado { get; set; } = false;
}
