using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ArticleTypePrixHistorique
{
    public string RefArt { get; set; } = null!;

    public string NTypePrix { get; set; } = null!;

    public double? QteD { get; set; }

    public double? QteFin { get; set; }

    public bool? Val { get; set; }

    public double? Marge { get; set; }

    public double? Remise { get; set; }

    public decimal? PrixtypeHt { get; set; }

    public decimal? Prixtype { get; set; }

    public int? UniqueId { get; set; }

    public DateTime? DateOperation { get; set; }
}
