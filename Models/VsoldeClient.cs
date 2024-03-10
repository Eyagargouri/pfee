using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class VsoldeClient
{
    public int UniqueIdEncDec { get; set; }

    public string? DocTiers { get; set; }

    public string Ty { get; set; } = null!;

    public string? DocRef { get; set; }

    public string? DocType { get; set; }

    public DateTime? Docdate { get; set; }

    public string? DateEch { get; set; }

    public string? ModeReg { get; set; }

    public string? Npiece { get; set; }

    public string? Débit { get; set; }

    public string? Crédit { get; set; }

    public decimal? ResteDoc { get; set; }

    public decimal? ResteCheque { get; set; }
}
