using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ViewFactureExo
{
    public string? DocTiers { get; set; }

    public string DocRef { get; set; } = null!;

    public string DocType { get; set; } = null!;

    public decimal? DocTotalHt { get; set; }

    public DateTime? DateDebut { get; set; }

    public DateTime? DateFin { get; set; }

    public DateTime? DocDate { get; set; }

    public string NumDecision { get; set; } = null!;

    public string? CraisonSocial { get; set; }

    public decimal? DocNetaPayer { get; set; }

    public double? ValTimberFiscal { get; set; }

    public string Expr1 { get; set; } = null!;
}
