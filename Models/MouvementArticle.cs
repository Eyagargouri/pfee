using System;
using System.Collections.Generic;

namespace CRM;

public partial class MouvementArticle
{
    public int UniqueId { get; set; }

    public string Typ { get; set; } = null!;

    public string? DocRef { get; set; }

    public string? DocType { get; set; }

    public string DocArt { get; set; } = null!;

    public DateTime? DocDate { get; set; }

    public string? Entrées { get; set; }

    public string? Sorties { get; set; }

    public double? DocQte { get; set; }

    public decimal? DocTotalHt { get; set; }

    public string? CraisonSocial { get; set; }

    public string LibDoc { get; set; } = null!;

    public string? RefSouDest { get; set; }
}
