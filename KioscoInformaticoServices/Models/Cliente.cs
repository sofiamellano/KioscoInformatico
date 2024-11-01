using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace KioscoInformaticoServices.Models;

public partial class Cliente
{
    public int Id { get; set; }
    [Required(ErrorMessage = "El campo Nombre es Obligatorio.")]
    public string Nombre { get; set; } = null!;
    [Required(ErrorMessage = "El campo Direccion es Obligatorio.")]
    public string Direccion { get; set; } = null!;

    public string Telefonos { get; set; } = null!;

    public DateTime FechaNacimiento { get; set; }
    [Required(ErrorMessage = "Debe seleccionar una Localidad.")]
    public int? LocalidadId { get; set; }

    public virtual Localidad? Localidad { get; set; }
    public bool Eliminado { get; set; } = false;
    public override string ToString()
    {
        return Nombre;
    }

    //  public virtual ICollection<Venta> Venta { get; set; } = new List<Venta>();
}
