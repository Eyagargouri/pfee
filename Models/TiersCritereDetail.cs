using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class TiersCritereDetail
{
    public string UniqueId { get; set; } = null!;

    public string CritCl { get; set; } = null!;

    public int? Coif { get; set; }

    public string? Designation { get; set; }

    public decimal? Score { get; set; }

    public string? Commentaire { get; set; }
}
