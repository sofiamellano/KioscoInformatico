using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KioscoInformaticoServices.Models;

public partial class Producto
{
    public int Id { get; set; }

    [Required]
    public string Nombre { get; set; } = null!;

    [Required]
    public decimal Precio { get; set; }
    public bool Eliminado { get; set; } = false;
    public bool Oferta { get; set; } = false;
    public override string ToString() => Nombre;
    //  public virtual ICollection<DetalleCompra> DetallesCompras { get; set; } = new List<DetalleCompra>();

    // public virtual ICollection<DetalleVenta> DetallesVenta { get; set; } = new List<DetalleVenta>();
}
