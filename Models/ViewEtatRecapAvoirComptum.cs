using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ViewEtatRecapAvoirComptum
{
    public DateTime? DocDate { get; set; }

    public string DocType { get; set; } = null!;

    public string? DocTiers { get; set; }

    public string DocNptiers { get; set; } = null!;

    public string Cnom { get; set; } = null!;

    public string Cprenom { get; set; } = null!;

    public string CraisonSocial { get; set; } = null!;

    public string DocRef { get; set; } = null!;

    public decimal? TotalLigne { get; set; }

    public decimal? TotalEntet { get; set; }

    public double? DocTxTva { get; set; }

    public decimal? DocNetaPayer { get; set; }

    public bool? TimberFiscal { get; set; }

    public double? ValTimberFiscal { get; set; }

    public string TypeClient { get; set; } = null!;
}
