using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Menu
{
    public int IdSistema { get; set; }

    public int MenuId { get; set; }

    public string Descripcion { get; set; } = null!;

    public int? PadreId { get; set; }

    public int? Posicion { get; set; }

    public string? Icono { get; set; }

    public bool Habilitado { get; set; }

    public string Ruta { get; set; } = null!;

    public string? Pagina { get; set; }

    public string? Parametros { get; set; }

    public string? DescripcionIngles { get; set; }

    public virtual Sistema IdSistemaNavigation { get; set; } = null!;
}
