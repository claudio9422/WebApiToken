using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class CentroCosto
{
    public int IdCentroCosto { get; set; }

    public string Nombre { get; set; } = null!;

    public virtual ICollection<Usuario> Usuarios { get; set; } = new List<Usuario>();
}
