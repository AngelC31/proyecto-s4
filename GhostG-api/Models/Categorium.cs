using System;
using System.Collections.Generic;

namespace GhostG_api.Models;

public partial class Categorium
{
    public int IdCategoria { get; set; }

    public string Tipo { get; set; } = null!;

    public string Duracion { get; set; } = null!;

    public double Precio { get; set; }

    public virtual ICollection<DetEjercicio> DetEjercicios { get; } = new List<DetEjercicio>();

    public virtual ICollection<Suscripcion> Suscripcions { get; } = new List<Suscripcion>();
}
