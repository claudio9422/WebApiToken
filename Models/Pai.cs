using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Pai
{
    public int IdPais { get; set; }

    public string? Pais { get; set; }

    public string? RutaImagen { get; set; }

    public bool? Activo { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public bool? Inicio { get; set; }

    public string? CodigoAlfa2 { get; set; }

    public string? HorarioAtencion { get; set; }

    public string? CorreoSoporte { get; set; }

    public string? Folder { get; set; }

    public virtual ICollection<Departamento> Departamentos { get; set; } = new List<Departamento>();

    public virtual ICollection<UsuarioPai> UsuarioPais { get; set; } = new List<UsuarioPai>();
}
