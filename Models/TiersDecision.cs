using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class TiersDecision
{
    public string TrRef { get; set; } = null!;

    public string NumDecision { get; set; } = null!;

    public DateTime? DateDebut { get; set; }

    public DateTime? DateFin { get; set; }

    public string? Comm { get; set; }
}
