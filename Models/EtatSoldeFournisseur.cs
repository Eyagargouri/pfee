using System;
using System.Collections.Generic;

namespace CRM;

public partial class EtatSoldeFournisseur
{
    public string? DocType { get; set; }

    public string? DocRef { get; set; }

    public DateTime? DocDate { get; set; }

    public string? DocTiers { get; set; }

    public decimal? DocTotalHt { get; set; }

    public decimal? DocTotalRemise { get; set; }

    public decimal? DocTotalTva { get; set; }

    public decimal? DocMontant { get; set; }

    public DateTime? DocDateEcheance { get; set; }

    public string? DocRefExt { get; set; }

    public string? DocMntLettre { get; set; }

    public decimal? DocNetaPayer { get; set; }

    public double? DocTauxRem { get; set; }

    public decimal? DocValRem { get; set; }

    public int NumCarnet { get; set; }

    public double? DocTxDevise { get; set; }

    public string? ModeReg { get; set; }

    public string? Npiece { get; set; }

    public DateTime? DateVers { get; set; }

    public int? Expr1 { get; set; }

    public long? UniqueId { get; set; }

    public DateTime? DateI { get; set; }

    public string TypeImpaye { get; set; } = null!;

    public int? NumEncAffec { get; set; }

    public decimal Reste { get; set; }

    public string? Commentaire { get; set; }

    public string? Bpieces { get; set; }

    public double? DocTauxDevise { get; set; }

    public DateTime? DateAnnuler { get; set; }
}
