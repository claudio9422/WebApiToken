using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class MensajeUsuario
{
    public int IdMensaje { get; set; }

    public int IdUsuario { get; set; }

    public int IdSistema { get; set; }

    public bool Mostrar { get; set; }

    public virtual Mensaje IdMensajeNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
