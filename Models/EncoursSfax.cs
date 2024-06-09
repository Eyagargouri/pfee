using System;
using System.Collections.Generic;

namespace CRM;

public partial class EncoursSfax
{
    public long? Référence { get; set; }

    public string? Date { get; set; }

    public string DocTiers { get; set; } = null!;

    public decimal? Montant { get; set; }

    public string? Ppieces { get; set; }

    public string? NumP { get; set; }

    public int? Expr1 { get; set; }

    public string? ModeReg { get; set; }

    public string TypeEncDec { get; set; } = null!;

    public DateTime? DateV { get; set; }

    public DateTime? DateR { get; set; }
}
