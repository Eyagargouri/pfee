using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ViewListeEncaissement
{
    public int UniqueIdEncDec { get; set; }

    public long? NumEncDec { get; set; }

    public string TypeEncDec { get; set; } = null!;

    public string DocTiers { get; set; } = null!;

    public string? DocType { get; set; }

    public string? DocRef { get; set; }

    public string? ModeReg { get; set; }

    public DateTime? DateR { get; set; }

    public DateTime? DateEch { get; set; }

    public decimal? MontantR { get; set; }

    public string? Npieces { get; set; }

    public string? Cref { get; set; }

    public string? Cf { get; set; }

    public string? TypeC { get; set; }

    public string? Cnom { get; set; }

    public string? Cprenom { get; set; }

    public string? CraisonSocial { get; set; }
}
