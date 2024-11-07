using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class UsuarioTiendum
{
    public int IdTienda { get; set; }

    public int IdUsuario { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public int? IdSistema { get; set; }
}
