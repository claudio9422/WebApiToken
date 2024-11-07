using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Asistencia
{
    public int IdAsistencia { get; set; }

    public DateOnly Fecha { get; set; }

    public int DiasLaborales { get; set; }
}
