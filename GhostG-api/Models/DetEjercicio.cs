using System;
using System.Collections.Generic;

namespace GhostG_api.Models;

public partial class DetEjercicio
{
    public int IdDetalle { get; set; }

    public int? IdCategoria1 { get; set; }

    public int? IdRutina1 { get; set; }

    public int? IdInstructor1 { get; set; }

    public virtual Categorium? IdCategoria1Navigation { get; set; }

    public virtual Instructor? IdInstructor1Navigation { get; set; }

    public virtual Rutina? IdRutina1Navigation { get; set; }
}
