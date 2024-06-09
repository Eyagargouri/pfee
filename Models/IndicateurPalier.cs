﻿using System;
using System.Collections.Generic;

namespace CRM;

public partial class IndicateurPalier
{
    public int IdIndicateur { get; set; }

    public int NumPalier { get; set; }

    public int? ValeurMin { get; set; }

    public int? ValeurMax { get; set; }

    public string? Designation { get; set; }

    public string? Couleur { get; set; }

    public int? InnerRadius { get; set; }

    public int? OuterRadius { get; set; }
}
