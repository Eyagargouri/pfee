using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class BcnabeulEncour
{
    public int UniqueId { get; set; }

    public string DocRef { get; set; } = null!;

    public string? Date { get; set; }

    public string DocType { get; set; } = null!;

    public string? RefTiers { get; set; }

    public string? RaisonSocial { get; set; }

    public string? DateEch { get; set; }

    public string? RefExt { get; set; }

    public decimal? DocTotalHt { get; set; }

    public decimal? DocTotalTva { get; set; }

    public decimal? NetàPayer { get; set; }

    public int? Année { get; set; }
}
