using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class EnCoursLcaAe3
{
    public string? DocArt { get; set; }

    public string? Designation { get; set; }

    public decimal Punit { get; set; }

    public double Qte { get; set; }

    public double Exc { get; set; }

    public decimal? DocTotalHt { get; set; }

    public decimal? DocTotalTtc { get; set; }

    public string? Réference { get; set; }

    public int UniqueId { get; set; }

    public decimal? AqteStock { get; set; }

    public string? DocTiers { get; set; }

    public string? Fournisseur { get; set; }

    public DateTime? DocDate { get; set; }

    public double? DocTxDevise { get; set; }
}
