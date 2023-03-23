using System;
using System.Collections.Generic;

namespace GhostG_api.Models;

public partial class Vista2
{
    public int Detalle { get; set; }

    public string Nivel { get; set; } = null!;

    public string Enfoque { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string? Horario { get; set; }
}
