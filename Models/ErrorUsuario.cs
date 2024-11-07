using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class ErrorUsuario
{
    public int IdErrorUsuario { get; set; }

    public int IdErrorSistema { get; set; }

    public int IdSistema { get; set; }

    public string Ticket { get; set; } = null!;

    public DateTime FechaError { get; set; }

    public string DescripcionUsuario { get; set; } = null!;

    public string Usuario { get; set; } = null!;

    public int IdEstadoTicket { get; set; }

    public byte[]? Screenshot { get; set; }

    public string RevisadoPor { get; set; } = null!;

    public DateTime? FechaPrimeraRevision { get; set; }

    public string? Solucion { get; set; }

    public DateTime? FechaSolucion { get; set; }
}
