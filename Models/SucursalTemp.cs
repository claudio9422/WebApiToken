using System;
using System.Collections.Generic;

namespace WebApi.Models;

public partial class SucursalTemp
{
    public int IdSucursal { get; set; }

    public string CodigoSucursal { get; set; } = null!;

    public string? RutSucursal { get; set; }

    public string Nombre { get; set; } = null!;

    public string Direccion { get; set; } = null!;

    public string Ciudad { get; set; } = null!;
}
