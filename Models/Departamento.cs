using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Departamento
{
    public int IdDepartamento { get; set; }

    public string Departamento1 { get; set; } = null!;

    public string? CodigoPostal { get; set; }

    public int IdPais { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<Ciudad> Ciudads { get; set; } = new List<Ciudad>();

    public virtual Pai IdPaisNavigation { get; set; } = null!;

    public virtual ICollection<Provincium> Provincia { get; set; } = new List<Provincium>();
}
