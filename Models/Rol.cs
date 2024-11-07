using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Rol
{
    public int IdRol { get; set; }

    public string Descripcion { get; set; } = null!;

    public int IdSistema { get; set; }

    public virtual Sistema IdSistemaNavigation { get; set; } = null!;

    public virtual ICollection<RolSucursal> RolSucursals { get; set; } = new List<RolSucursal>();

    public virtual ICollection<Permiso> IdPermisos { get; set; } = new List<Permiso>();

    public virtual ICollection<Usuario> Idusuarios { get; set; } = new List<Usuario>();
}
