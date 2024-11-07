using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Operador
{
    public int IdOperador { get; set; }

    public string CodigoOperador { get; set; } = null!;

    public string Descripcion { get; set; } = null!;
}
