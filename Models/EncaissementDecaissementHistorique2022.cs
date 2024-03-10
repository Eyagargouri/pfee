using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class EncaissementDecaissementHistorique2022
{
    public int? UniqueIdEncDec { get; set; }

    public long? NumEncDec { get; set; }

    public string? TypeEncDec { get; set; }

    public string? DocTiers { get; set; }

    public string? DocType { get; set; }

    public string? DocRef { get; set; }

    public string? ModeReg { get; set; }

    public DateTime? DateR { get; set; }

    public DateTime? DateEch { get; set; }

    public decimal? MontantR { get; set; }

    public string? Npieces { get; set; }

    public string? Ppieces { get; set; }

    public string? Bpieces { get; set; }

    public string? Caisse { get; set; }

    public string? Breception { get; set; }

    public string? Rib { get; set; }

    public DateTime? DateV { get; set; }

    public DateTime? DateP { get; set; }

    public DateTime? Etat { get; set; }

    public bool? VisibleEd { get; set; }

    public string? NumDoc { get; set; }

    public int? NumEncAffec { get; set; }

    public string? Commentaire { get; set; }

    public int? NumCarnet { get; set; }

    public int? UniqueId { get; set; }

    public DateTime? DateI { get; set; }

    public string? Imputation { get; set; }

    public string? DocMntLettre { get; set; }

    public string? Pdecommentaire { get; set; }

    public bool? Impri { get; set; }

    public bool? Signe { get; set; }

    public bool? Accuse { get; set; }

    public DateTime? DateEch2 { get; set; }

    public DateTime? DateAnnuler { get; set; }

    public string? Imput1 { get; set; }

    public string? Ribp { get; set; }

    public string? Action { get; set; }

    public DateTime? ActionDate { get; set; }
}
