using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ViewInfoNivAe3liste
{
    public int UniqueId { get; set; }

    public string? Ref { get; set; }

    public string? RefTiers { get; set; }

    public string? Tiers { get; set; }

    public DateTime? Date { get; set; }

    public decimal? Tht { get; set; }
}
