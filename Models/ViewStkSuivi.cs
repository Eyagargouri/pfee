using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ViewStkSuivi
{
    public string Aref { get; set; } = null!;

    public string? Adesignation { get; set; }

    public decimal? ApuventeHt { get; set; }

    public double Tva { get; set; }

    public decimal? Apvttc { get; set; }

    public decimal? AqteStock { get; set; }

    public string? Datedebutpromov { get; set; }

    public string? Datefinpromov { get; set; }

    public string? Datedebutpromoa { get; set; }

    public string? Datefinpromoa { get; set; }

    public string? PromoVente { get; set; }

    public string? PromoVenteGratuite { get; set; }

    public string? PromoWeb { get; set; }

    public string? PromoAchat { get; set; }

    public string? PromoAchatGratuite { get; set; }

    public int QtePromoVente { get; set; }

    public int QtePromoVenteGratuite { get; set; }

    public int QtePromoAchat { get; set; }

    public int QtePromoAchatGratuite { get; set; }

    public int QteStkGratuite { get; set; }
}
