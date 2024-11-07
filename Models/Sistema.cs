using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Sistema
{
    public int IdSistema { get; set; }

    public string Nombre { get; set; } = null!;

    public string? Logo { get; set; }

    public virtual ICollection<Conexion> Conexions { get; set; } = new List<Conexion>();

    public virtual ICollection<ErrorSistema> ErrorSistemas { get; set; } = new List<ErrorSistema>();

    public virtual ICollection<Rol> Rols { get; set; } = new List<Rol>();

    public virtual ICollection<UsuarioSistema> UsuarioSistemas { get; set; } = new List<UsuarioSistema>();
}
