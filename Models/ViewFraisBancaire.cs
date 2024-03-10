using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ViewFraisBancaire
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

    public string? Ppieces { get; set; }

    public string? Bpieces { get; set; }

    public string? Breception { get; set; }

    public string? Rib { get; set; }

    public DateTime? DateV { get; set; }

    public DateTime? DateP { get; set; }

    public DateTime? Etat { get; set; }

    public DateTime? DateI { get; set; }

    public string? Bordref { get; set; }

    public DateTime? BordDate { get; set; }

    public string? BordBanque { get; set; }

    public int? UniqueId { get; set; }
}
