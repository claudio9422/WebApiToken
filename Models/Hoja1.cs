using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Hoja1
{
    public double? IdError { get; set; }

    public double? IdUsuario { get; set; }

    public double? IdSistema { get; set; }

    public string? LoginUsuario { get; set; }

    public string? Url { get; set; }

    public string? Ipusuario { get; set; }

    public string? Iphost { get; set; }

    public string? MensajeError { get; set; }

    public string? FechaError { get; set; }
}
