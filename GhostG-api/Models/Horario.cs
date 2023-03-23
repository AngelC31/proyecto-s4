using System;
using System.Collections.Generic;

namespace GhostG_api.Models;

public partial class Horario
{
    public int IdHorario { get; set; }

    public string? Turno { get; set; }

    public virtual ICollection<Instructor> Instructors { get; } = new List<Instructor>();
}
