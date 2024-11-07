using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class MenuReporte
{
    public int IdMenu { get; set; }

    public string CodigoMenu { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public int IdPadre { get; set; }

    public int Posicion { get; set; }

    public string? Icono { get; set; }

    public bool Habilitado { get; set; }

    public string? RutaInforme { get; set; }

    public string? Pagina { get; set; }
}
