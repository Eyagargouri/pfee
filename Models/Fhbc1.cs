using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class Fhbc1
{
    public DateTime? Date { get; set; }

    public string? NbJours { get; set; }

    public string? Nature { get; set; }

    public string? CodeTiers { get; set; }

    public string? Numint { get; set; }

    public double? MtNominale { get; set; }

    public double? Solde { get; set; }

    public DateTime? Echeance { get; set; }
}
