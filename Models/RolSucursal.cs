using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class RolSucursal
{
    public int IdRolSucursal { get; set; }

    public int? IdRol { get; set; }

    public int? IdSucursal { get; set; }

    public virtual Rol? IdRolNavigation { get; set; }
}
