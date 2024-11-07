using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class UsuarioPai
{
    public int IdUsuarioPais { get; set; }

    public int IdUsuario { get; set; }

    public int IdPais { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Pai IdPaisNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
