using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class SynthéseDesPrixOld
{
    public int UniqueId { get; set; }

    public int Uniqueid1 { get; set; }

    public string DocRef { get; set; } = null!;

    public string DocArt { get; set; } = null!;

    public string? DocArtDesignation { get; set; }

    public decimal? PrixNet { get; set; }

    public double? DocQte { get; set; }

    public double? MontantNet { get; set; }

    public decimal? TotalFrais { get; set; }

    public decimal? Frais { get; set; }

    public decimal? FraisUnitaire { get; set; }

    public decimal? PuRevient { get; set; }

    public decimal? PrixTotalRevient { get; set; }

    public decimal? Marque { get; set; }

    public decimal? PrixRevientArticle { get; set; }

    public decimal? PrixVteArticle { get; set; }

    public decimal? PrixVteDonné { get; set; }

    public decimal? PrixVteCalculé { get; set; }

    public decimal? PrixVteTtc { get; set; }

    public int? DocProjet { get; set; }

    public DateTime? DocDate { get; set; }

    public string? CraisonSocial { get; set; }

    public string? Cref { get; set; }
}
