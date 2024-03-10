using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ViewBordTest
{
    public int UniqueIdEncDec { get; set; }

    public string? RefTiers { get; set; }

    public string? RaisonSocial { get; set; }

    public string? RéférenceBordereau { get; set; }

    public decimal Montant { get; set; }

    public string? Tel { get; set; }

    public string? Date { get; set; }

    public string? Commentaire { get; set; }

    public string? DateEch { get; set; }

    public string? Banque { get; set; }

    public string? NPiece { get; set; }

    public decimal? Acompte { get; set; }

    public string? DateVersement { get; set; }

    public string? ModePay { get; set; }

    public string? Etat { get; set; }

    public string? DateP { get; set; }

    public string? DateI { get; set; }

    public long? NumEncDec { get; set; }
}
