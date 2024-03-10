using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ArticleRemiseTaxe
{
    public string Aref { get; set; } = null!;

    public string NRemTaxe { get; set; } = null!;

    public double? VRemTaxe { get; set; }

    public decimal? TotalRemTaxe { get; set; }

    public string TypeRT { get; set; } = null!;

    public int? OOrder { get; set; }
}
