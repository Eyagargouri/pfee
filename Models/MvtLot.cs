using System;
using System.Collections.Generic;

namespace CRM;

public partial class MvtLot
{
    public string? DocArtDesignation { get; set; }

    public string DocRef { get; set; } = null!;

    public string DocArt { get; set; } = null!;

    public double? DocQte { get; set; }

    public int Expr1 { get; set; }

    public DateTime? DocDate { get; set; }

    public string? RefSouDest { get; set; }

    public string? RefSouDest1 { get; set; }

    public bool? SourceActive { get; set; }

    public bool? DestinationActive { get; set; }

    public string? Adesignation { get; set; }

    public decimal? DocTotalHt { get; set; }

    public double? DocTxFodec { get; set; }

    public decimal? DocPunit { get; set; }

    public double? DocRemise { get; set; }
}
