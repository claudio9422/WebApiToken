using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class TblTarea
{
    public int IdTarea { get; set; }

    public int? IdTipoTarea { get; set; }

    public string? NombreTarea { get; set; }

    public string? DescripcionTarea { get; set; }

    public DateTime? FechaSolicitud { get; set; }

    public DateTime? FechaInicioTarea { get; set; }

    public DateTime? FechaTerminoTarea { get; set; }

    public string? Solicitante { get; set; }

    public string? AsignadaA { get; set; }

    public int? IdEstadoTarea { get; set; }
}
