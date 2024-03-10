using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class EtatDesFacturesExoTva
{
    public string DocRef { get; set; } = null!;

    public string DocType { get; set; } = null!;

    public string? DocTiers { get; set; }

    public DateTime? DocDate { get; set; }

    public string? CraisonSocial { get; set; }

    public string? Cnom { get; set; }

    public string? Cprenom { get; set; }

    public string? Ctva { get; set; }

    public bool? TimberFiscal { get; set; }

    public decimal? DocTotalHt { get; set; }

    public decimal? DocTotalTva { get; set; }

    public decimal? DocNetaPayer { get; set; }

    public decimal? DocMontant { get; set; }

    public bool? DocForfitaire { get; set; }

    public double? ValTimberFiscal { get; set; }

    public string? RefSouDest { get; set; }

    public string Type { get; set; } = null!;
}
