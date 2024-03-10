using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class CritereDestSecteur
{
    public string Type { get; set; } = null!;

    public string Ref { get; set; } = null!;

    public string? NType { get; set; }

    public string? PType { get; set; }

    public string? VType { get; set; }

    public string? RefType { get; set; }
}
