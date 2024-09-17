﻿using System;
using System.Collections.Generic;

namespace KioscoInformaticoServices.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string Nombre { get; set; } = null!;

    public decimal Precio { get; set; }

    public virtual ICollection<DetalleCompra> DetallesCompras { get; set; } = new List<DetalleCompra>();

    public virtual ICollection<DetalleVenta> DetallesVenta { get; set; } = new List<DetalleVenta>();
}
