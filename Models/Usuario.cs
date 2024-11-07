using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Telefono { get; set; } = null!;

    public string? Telefono2 { get; set; }

    public string PasswordProvisorio { get; set; } = null!;

    public bool Activo { get; set; }

    public string? Sucursal { get; set; }

    public bool UsuarioInterno { get; set; }

    public string? EmailPivot { get; set; }

    public int? Rut { get; set; }

    public DateTime? FechaIngreso { get; set; }

    public int? CentroCosto { get; set; }

    public bool? PuedeResetearClave { get; set; }

    public string? Dv { get; set; }

    public string? RutaFirma { get; set; }

    public string? Cedula { get; set; }

    public string? TechId { get; set; }

    public bool? EsUsuarioFinal { get; set; }

    public virtual CentroCosto? CentroCostoNavigation { get; set; }

    public virtual ICollection<UsuarioPai> UsuarioPais { get; set; } = new List<UsuarioPai>();

    public virtual ICollection<UsuarioSistema> UsuarioSistemas { get; set; } = new List<UsuarioSistema>();

    public virtual ICollection<Empresa> IdEmpresas { get; set; } = new List<Empresa>();

    public virtual ICollection<Rol> IdRols { get; set; } = new List<Rol>();

    public virtual ICollection<Usuario> IdUsuarioSupervisors { get; set; } = new List<Usuario>();

    public virtual ICollection<Usuario> IdUsuarios { get; set; } = new List<Usuario>();
}
