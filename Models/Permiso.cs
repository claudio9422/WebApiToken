using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Permiso
{
    public int IdPermiso { get; set; }

    public int IdSistema { get; set; }

    public string TipoPermiso { get; set; } = null!;

    public string NombreElemento { get; set; } = null!;

    public virtual ICollection<Rol> IdRols { get; set; } = new List<Rol>();
}
