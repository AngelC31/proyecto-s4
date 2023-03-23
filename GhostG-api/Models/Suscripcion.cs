using System;
using System.Collections.Generic;

namespace GhostG_api.Models;

public partial class Suscripcion
{
    public int IdSuscripcion { get; set; }

    public int IdUsuario { get; set; }

    public int IdCategoria { get; set; }

    public virtual Categorium IdCategoriaNavigation { get; set; } = null!;

    public virtual Usuario IdUsuarioNavigation { get; set; } = null!;
}
