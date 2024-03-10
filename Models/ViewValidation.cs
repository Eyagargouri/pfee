﻿using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ViewValidation
{
    public string? EmatSup { get; set; }

    public string? Valeur { get; set; }

    public DateTime? DateDeb { get; set; }

    public DateTime? DateFin { get; set; }

    public string? Codetiers { get; set; }

    public string Tiers { get; set; } = null!;

    public string? EmatSup2 { get; set; }

    public string? Sup2 { get; set; }

    public string? Val2 { get; set; }
}
