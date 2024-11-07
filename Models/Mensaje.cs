using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Mensaje
{
    public int IdMensaje { get; set; }

    public string Mensaje1 { get; set; } = null!;

    public bool Habilitado { get; set; }
}
