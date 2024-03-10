using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ViewQtcommander
{
    public string? Aref { get; set; }

    public string? Adesignation { get; set; }

    public string? Afamille { get; set; }

    public string? Asfamille { get; set; }

    public decimal AqteStock { get; set; }

    public double AstockMax { get; set; }

    public double AstockMin { get; set; }

    public string? AuniteVnt { get; set; }

    public string? DocType { get; set; }

    public decimal? QtReserver { get; set; }

    public decimal? StockDisponible { get; set; }

    public double EnCoursArrivage { get; set; }

    public double EnCoursAchat { get; set; }

    public double EncoursBca { get; set; }

    public double EncoursLca { get; set; }
}
