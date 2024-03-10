using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class Bcaencour
{
    public int UniqueId { get; set; }

    public string RefrenceBca { get; set; } = null!;

    public DateTime? DocDate { get; set; }

    public string? CraisonSocial { get; set; }

    public string RefArticle { get; set; } = null!;

    public string? Docartdesignation { get; set; }

    public double QtenonCommander { get; set; }

    public double? DocTotalHt { get; set; }

    public string? DateLev { get; set; }

    public DateTime? Datefacturationprevu { get; set; }

    public string Docdevise { get; set; } = null!;

    public int? Docprojet { get; set; }

    public string Doctype { get; set; } = null!;

    public double? DocTxDevise { get; set; }
}
