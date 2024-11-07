using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class UsuarioSistema
{
    public int IdUsuario { get; set; }

    public int IdSistema { get; set; }

    public DateTime? FechaConeccion { get; set; }

    public bool Conectado { get; set; }

    public bool EsSupervisor { get; set; }

    public virtual Sistema IdSistemaNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<UsuarioSistemaSupervisor> UsuarioSistemaSupervisors { get; set; } = new List<UsuarioSistemaSupervisor>();
}
