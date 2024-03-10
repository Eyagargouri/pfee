using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class RapportActivite
{
    public decimal? Nbre { get; set; }

    public int? Semaine { get; set; }

    public string Type { get; set; } = null!;
}
