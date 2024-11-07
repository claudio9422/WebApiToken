using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class DiccionarioError
{
    public int IdDiccionarioError { get; set; }

    public string MensajeGeneral { get; set; } = null!;

    /// <summary>
    /// indica el significado del error
    /// </summary>
    public string Descripcion { get; set; } = null!;

    public int IdTipoError { get; set; }

    public virtual TipoError IdTipoErrorNavigation { get; set; } = null!;
}
