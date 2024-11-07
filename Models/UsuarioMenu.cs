using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class UsuarioMenu
{
    public int? IdUsuario { get; set; }

    public int? IdPadre { get; set; }

    public int? IdPermiso { get; set; }

    public bool? Estado { get; set; }
}
