using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class EtatSoldeDetailMoisAnc
{
    public int UniqueId { get; set; }

    public string? DocType { get; set; }

    public string? RefDoc { get; set; }

    public string? RefTiers { get; set; }

    public string? Tiers { get; set; }

    public decimal? Total { get; set; }

    public decimal? MontantReglé { get; set; }

    public decimal TotalAvance { get; set; }

    public decimal? Reste { get; set; }

    public DateTime? DateCréation { get; set; }

    public DateTime? DateRecouvrement { get; set; }

    public DateTime? Date { get; set; }

    public string? ModeRegTier { get; set; }
}
