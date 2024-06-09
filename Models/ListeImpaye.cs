﻿using System;
using System.Collections.Generic;

namespace CRM;

public partial class ListeImpaye
{
    public int UniqueId { get; set; }

    public string? DocType { get; set; }

    public string? DocRef { get; set; }

    public string? RefTiers { get; set; }

    public string Tiers { get; set; } = null!;

    public decimal? Total { get; set; }

    public decimal? MontantReglé { get; set; }

    public int? NbreJoursRecouvert { get; set; }

    public decimal? Reste { get; set; }

    public string? DateCréation { get; set; }

    public string? DateRecouvrement { get; set; }

    public string? DateEcheance { get; set; }

    public string? Date { get; set; }

    public string? ModeRegTier { get; set; }

    public string? DocRepresentant { get; set; }

    public string? Npiece { get; set; }

    public string? Modereg { get; set; }
}
