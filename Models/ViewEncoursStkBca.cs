using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ViewEncoursStkBca
{
    public int UniqueId { get; set; }

    public string? Date { get; set; }

    public string? RefTiers { get; set; }

    public string? RaisonSocial { get; set; }

    public double Qte { get; set; }

    public double Total { get; set; }

    public DateTime? Dateliv { get; set; }

    public string? Etape { get; set; }

    public string DocType { get; set; } = null!;

    public string DocRef { get; set; } = null!;

    public string? Docart { get; set; }

    public string? DocArtDesignation { get; set; }

    public int Idlg { get; set; }

    public double? DocTxDevise { get; set; }

    public string? DocDevise { get; set; }

    public long? Maxech { get; set; }

    public decimal? PxUnit { get; set; }

    public bool? DocEtatBp { get; set; }

    public string Type { get; set; } = null!;
}
