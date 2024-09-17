﻿using System;
using System.Collections.Generic;

namespace KioscoInformaticoServices.Models;

public partial class Detallescompra
{
    public int Id { get; set; }

    public int ProductoId { get; set; }

    public decimal PrecioUnitario { get; set; }

    public int Cantidad { get; set; }

    public int CompraId { get; set; }

    public virtual Producto Producto { get; set; }
}
