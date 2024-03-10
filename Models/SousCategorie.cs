using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class SousCategorie
{
    public string NSousCat { get; set; } = null!;

    public string? PrefixCat { get; set; }

    public string NCat { get; set; } = null!;
}
