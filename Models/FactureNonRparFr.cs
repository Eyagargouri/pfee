using System;
using System.Collections.Generic;

namespace CRM;

public partial class FactureNonRparFr
{
    public int UniqueId { get; set; }

    public string? DocType { get; set; }

    public string? RefDoc { get; set; }

    public string? ReTiers { get; set; }

    public string Tiers { get; set; } = null!;

    public decimal? Montant { get; set; }

    public string? DateCréation { get; set; }

    public string RefExt { get; set; } = null!;

    public decimal? Reste { get; set; }
}
