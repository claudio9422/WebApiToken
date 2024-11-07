using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class ErrorSistema
{
    public int IdError { get; set; }

    public int? IdUsuario { get; set; }

    public int IdSistema { get; set; }

    public string LoginUsuario { get; set; } = null!;

    public string Url { get; set; } = null!;

    public string Ipusuario { get; set; } = null!;

    public string Iphost { get; set; } = null!;

    public string MensajeError { get; set; } = null!;

    public DateTime FechaError { get; set; }

    public int? IdTipoError { get; set; }

    public string? TypeException { get; set; }

    public virtual Sistema IdSistemaNavigation { get; set; } = null!;

    public virtual TipoError? IdTipoErrorNavigation { get; set; }
}
