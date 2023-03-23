using System;
using System.Collections.Generic;

namespace GhostG_api.Models;

public partial class Rutina
{
    public int IdRutina { get; set; }

    public string Nivel { get; set; } = null!;

    public string Enfoque { get; set; } = null!;

    public virtual ICollection<DetEjercicio> DetEjercicios { get; } = new List<DetEjercicio>();
}
