using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class ToolTipMensajeUsuario
{
    public int IdToolTipMensajeUsuario { get; set; }

    public int IdToolTipMensaje { get; set; }

    public int IdUsuario { get; set; }

    public int IdSistema { get; set; }

    public bool Habilitado { get; set; }
}
