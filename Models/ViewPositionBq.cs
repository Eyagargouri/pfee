using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ViewPositionBq
{
    public string? Col1 { get; set; }

    public string Value { get; set; } = null!;

    public int Mois { get; set; }

    public int? Annee { get; set; }
}
