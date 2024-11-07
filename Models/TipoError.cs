using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class TipoError
{
    public int IdTipoError { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<DiccionarioError> DiccionarioErrors { get; set; } = new List<DiccionarioError>();

    public virtual ICollection<ErrorSistema> ErrorSistemas { get; set; } = new List<ErrorSistema>();
}
