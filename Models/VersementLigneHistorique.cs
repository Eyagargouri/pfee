using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class VersementLigneHistorique
{
    public string Action { get; set; } = null!;

    public string BordRef { get; set; } = null!;

    public long BordRefDoc { get; set; }

    public DateTime? BordDateEch { get; set; }

    public string? BordTiers { get; set; }

    public decimal? BordMontDoc { get; set; }

    public string? Ppieces { get; set; }

    public string? Bordrefdoc1 { get; set; }

    public DateTime? ActionDate { get; set; }
}
