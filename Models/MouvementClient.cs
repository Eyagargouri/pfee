using System;
using System.Collections.Generic;

namespace CRM;

public partial class MouvementClient
{
    public int? UniqueId { get; set; }

    public string? DocType { get; set; }

    public string? RefDoc { get; set; }

    public string? RefTiers { get; set; }

    public string? Tiers { get; set; }

    public decimal? Total { get; set; }

    public decimal? Montantreglé { get; set; }

    public int? NbreJoursRecouvert { get; set; }

    public decimal? Reste { get; set; }

    public DateTime? DateCréation { get; set; }

    public DateTime? DateRecouvrement { get; set; }

    public DateTime? DateEcheance { get; set; }

    public DateTime? Date { get; set; }

    public string? ModeRegTier { get; set; }

    public string? DocRepresentant { get; set; }
}
