using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Ciudad
{
    public int IdCiudad { get; set; }

    public string Ciudad1 { get; set; } = null!;

    public int IdDepartamento { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Departamento IdDepartamentoNavigation { get; set; } = null!;
}
