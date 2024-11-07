using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Conexion
{
    public int IdConexion { get; set; }

    public int IdSistema { get; set; }

    public string IpPeticion { get; set; } = null!;

    public string IpCliente { get; set; } = null!;

    public bool EsProxy { get; set; }

    public string Usuario { get; set; } = null!;

    public string Autenticacion { get; set; } = null!;

    public DateTime Fecha { get; set; }

    public string Navegador { get; set; } = null!;

    public string Host { get; set; } = null!;

    public string? SessionId { get; set; }

    public DateTime? FechaFinSession { get; set; }

    public virtual Sistema IdSistemaNavigation { get; set; } = null!;
}
