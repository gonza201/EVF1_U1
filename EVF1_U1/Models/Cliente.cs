using System;
using System.Collections.Generic;

namespace EVF1_U1.Models;

public partial class Cliente
{
    public string Rut { get; set; } = null!;

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Correo { get; set; }

    public int? Telefono { get; set; }

    public string? Direccion { get; set; }
}
