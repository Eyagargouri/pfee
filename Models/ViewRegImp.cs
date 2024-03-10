using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ViewRegImp
{
    public int UniqueIdEncDec { get; set; }

    public decimal? MontantR { get; set; }

    public string? Pdecommentaire { get; set; }

    public DateTime? DateR { get; set; }

    public string DocTiers { get; set; } = null!;

    public string? CraisonSocial { get; set; }

    public string? DocRef { get; set; }

    public string TypeEncDec { get; set; } = null!;
}
