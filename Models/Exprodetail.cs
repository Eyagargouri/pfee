using System;
using System.Collections.Generic;

namespace CRM;

public partial class Exprodetail
{
    public int UniqueId { get; set; }

    public int DocAnnee { get; set; }

    public string DocType { get; set; } = null!;

    public string DocRef { get; set; } = null!;

    public string DocArt { get; set; } = null!;

    public decimal? DocPunit { get; set; }

    public double? DocQte { get; set; }

    public double? DocRemise { get; set; }

    public double? DocQteProm { get; set; }

    public double? DocRemiseProm { get; set; }

    public decimal? DocTotalHt { get; set; }

    public double? DocTxTva { get; set; }

    public decimal? DocTotalTva { get; set; }

    public double? DocTxFodec { get; set; }

    public decimal? DocTotalFodec { get; set; }

    public decimal? DocTotalTtc { get; set; }

    public string? DocCommentaire { get; set; }

    public double DocLong { get; set; }

    public double DocLarg { get; set; }

    public int? DocNumLigne { get; set; }

    public bool? EtatService { get; set; }

    public int UniqueIddoc { get; set; }

    public int? IdligneExt { get; set; }

    public decimal? DocPrevient { get; set; }

    public double? AqteStock { get; set; }

    public string? ParentRef { get; set; }

    public string? Date { get; set; }

    public string? Lot { get; set; }

    public string? DocArtDesignation { get; set; }

    public string? Col1 { get; set; }

    public string? Col2 { get; set; }

    public string? Col3 { get; set; }

    public string? Col4 { get; set; }

    public int? Col5 { get; set; }
}
