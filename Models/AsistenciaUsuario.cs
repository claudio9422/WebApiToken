using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class AsistenciaUsuario
{
    public int IdAsistencia { get; set; }

    public int IdUsuario { get; set; }

    public int DiasTrabajados { get; set; }

    public int Ausencias { get; set; }

    public int Licencia { get; set; }

    public int Vacaciones { get; set; }

    public virtual Asistencia IdAsistenciaNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
