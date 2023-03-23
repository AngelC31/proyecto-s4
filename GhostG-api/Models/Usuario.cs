using System;
using System.Collections.Generic;

namespace GhostG_api.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Correo { get; set; } = null!;

    public byte[] Contra { get; set; } = null!;

    public virtual ICollection<Suscripcion> Suscripcions { get; } = new List<Suscripcion>();
}
