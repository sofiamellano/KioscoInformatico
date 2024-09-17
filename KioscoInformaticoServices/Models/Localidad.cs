﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KioscoInformaticoServices.Models;

public partial class Localidad
{
    public int Id { get; set; }

    [Required]
    public string Nombre { get; set; } = null!;

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Proveedor> Proveedores { get; set; } = new List<Proveedor>();
}
