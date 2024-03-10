using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class SyntheseDesPrix
{
    public decimal? Amarge { get; set; }

    public decimal? AprevientHt { get; set; }

    public int UniqueId { get; set; }

    public string DocRef { get; set; } = null!;

    public DateTime? DocDate { get; set; }

    public double? DocTxDevise { get; set; }

    public int? DocProjet { get; set; }

    public string DocArt { get; set; } = null!;

    public decimal? DocPunit { get; set; }

    public double? DocQte { get; set; }

    public decimal? DocTotalTtc { get; set; }

    public decimal? DocPrevient { get; set; }

    public string? DocArtDesignation { get; set; }

    public string? Cref { get; set; }

    public string? CraisonSocial { get; set; }

    public decimal? Apvttc { get; set; }

    public decimal Frais { get; set; }
}
