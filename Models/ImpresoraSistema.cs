using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class ImpresoraSistema
{
    public int IdSistema { get; set; }

    public string NombreEquipoLocal { get; set; } = null!;

    public string NombreImpresora { get; set; } = null!;

    public string? Referencia { get; set; }
}
