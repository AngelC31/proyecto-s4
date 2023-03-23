using System;
using System.Collections.Generic;

namespace GhostG_api.Models;

public partial class Instructor
{
    public int IdInstructor { get; set; }

    public string NombreI { get; set; } = null!;

    public string ApellidoI { get; set; } = null!;

    public int? IdHorario { get; set; }

    public virtual ICollection<DetEjercicio> DetEjercicios { get; } = new List<DetEjercicio>();

    public virtual Horario? IdHorarioNavigation { get; set; }
}
