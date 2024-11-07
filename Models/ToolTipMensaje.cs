using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class ToolTipMensaje
{
    public int IdToolTipMensaje { get; set; }

    public string Mensaje { get; set; } = null!;

    public bool Habilitado { get; set; }

    public string? Pagina { get; set; }

    public string? ControlId { get; set; }

    public string? Posicion { get; set; }
}
