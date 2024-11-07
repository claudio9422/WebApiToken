using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Provincium
{
    public int IdProvincia { get; set; }

    public string Provincia { get; set; } = null!;

    public string? CodigoPostal { get; set; }

    public int IdDepartamento { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual ICollection<Distrito> Distritos { get; set; } = new List<Distrito>();

    public virtual Departamento IdDepartamentoNavigation { get; set; } = null!;
}
