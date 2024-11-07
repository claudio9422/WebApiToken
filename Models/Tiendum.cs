using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Tiendum
{
    public int IdTienda { get; set; }

    public int IdEmpresa { get; set; }

    public int IdContacto { get; set; }

    public string Codigo { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public DateTime? FechaCreacion { get; set; }

    public DateTime? FechaActualizacion { get; set; }

    public bool? Activa { get; set; }

    public string? CreadaPor { get; set; }

    public string? ActualizadaPor { get; set; }

    public int? IdSistema { get; set; }
}
