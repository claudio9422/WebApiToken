using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class UsuarioSistemaSupervisor
{
    public int IdSistema { get; set; }

    public int IdUsuarioSupervisor { get; set; }

    public int IdUsuario { get; set; }

    public virtual UsuarioSistema UsuarioSistema { get; set; } = null!;
}
