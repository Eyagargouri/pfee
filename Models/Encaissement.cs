using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class Encaissement
{
    public double? IdRecDebit { get; set; }

    public double? IdRecCredit { get; set; }

    public double? Montant { get; set; }

    public string? IdDocSerieD { get; set; }

    public string? PrefixeD { get; set; }

    public double? DocumentD { get; set; }

    public string? IdDocSerieC { get; set; }

    public string? PrefixeC { get; set; }

    public double? DocumentC { get; set; }

    public string? Seried { get; set; }

    public string? Seriec { get; set; }

    public double? Ligned { get; set; }

    public double? Lignec { get; set; }

    public double? Nbrjv { get; set; }

    public double? DelaiVent { get; set; }

    public string? Encourvent { get; set; }

    public string? Poidsiniv { get; set; }

    public double? Identifant { get; set; }

    public string? Montantdev { get; set; }
}
