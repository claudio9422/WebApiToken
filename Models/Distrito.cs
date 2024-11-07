using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Distrito
{
    public int IdDistrito { get; set; }

    public string Distrito1 { get; set; } = null!;

    public string? CodigoPostal { get; set; }

    public int IdProvincia { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Provincium IdProvinciaNavigation { get; set; } = null!;
}
