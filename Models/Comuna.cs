using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Comuna
{
    public int IdComuna { get; set; }

    public int IdProvincia { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Codigo { get; set; }

    public bool RequiereOds { get; set; }
}
