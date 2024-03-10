using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class RessourceMatCritere
{
    public string Ref { get; set; } = null!;

    public string NCriters { get; set; } = null!;

    public string? Valeur { get; set; }
}
