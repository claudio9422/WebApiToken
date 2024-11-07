using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Empresa
{
    public int IdEmpresa { get; set; }

    public string Rut { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Ciudad { get; set; } = null!;

    public string? CodigoSucursal { get; set; }

    public string? RutaLogo { get; set; }

    public string? Giro { get; set; }

    public string? Fono { get; set; }

    public bool? Estado { get; set; }

    public int? IdPais { get; set; }

    public virtual ICollection<Usuario> IdUsuarios { get; set; } = new List<Usuario>();
}
