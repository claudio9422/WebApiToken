using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class UsuarioAnovo
{
    public int IdUsuarioAnovo { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public bool? Vigente { get; set; }
}
