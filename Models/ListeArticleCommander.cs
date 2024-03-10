using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ListeArticleCommander
{
    public int? UniqueId { get; set; }

    public string Aref { get; set; } = null!;

    public string? Adesignation { get; set; }

    public string? Afamille { get; set; }

    public string? Asfamille { get; set; }

    public decimal AqteStock { get; set; }

    public double? AstockMax { get; set; }

    public double AstockMin { get; set; }

    public string? AuniteVnt { get; set; }

    public string? DocType { get; set; }

    public double? QtReserver { get; set; }

    public decimal? StockDisponible { get; set; }

    public double EnCoursArrivage { get; set; }

    public double EnCoursAchat { get; set; }
}
