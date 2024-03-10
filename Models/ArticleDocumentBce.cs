using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ArticleDocumentBce
{
    public int? UniqueId { get; set; }

    public decimal? DocPunit { get; set; }

    public decimal? DocRemise { get; set; }

    public decimal? DocTotalHt { get; set; }

    public double? DocQte { get; set; }

    public DateTime? DocDate { get; set; }

    public decimal? Revient { get; set; }

    public string? DocArt { get; set; }

    public string? DocTiers { get; set; }

    public string? DocType { get; set; }

    public string? DocRef { get; set; }
}
