using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class VencoursFr
{
    public int UniqueId { get; set; }

    public string? DocType { get; set; }

    public string? RefDoc { get; set; }

    public string? ReTiers { get; set; }

    public string Tiers { get; set; } = null!;

    public decimal? Reste { get; set; }

    public string? DateCréation { get; set; }

    public DateTime? Echeance { get; set; }

    public double? Devise { get; set; }
}
