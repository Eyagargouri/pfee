using System;
using System.Collections.Generic;

namespace CRM;

public partial class ListeDesVirement
{
    public string? UniqueId { get; set; }

    public string? Tiers { get; set; }

    public string? RaisonSocial { get; set; }

    public string? ModeReg { get; set; }

    public decimal? MontantPiece { get; set; }

    public decimal? MontantAffecter { get; set; }

    public decimal? Reste { get; set; }

    public DateTime? DateEch { get; set; }

    public string? Npieces { get; set; }

    public string? Bpieces { get; set; }

    public string? Ppieces { get; set; }
}
