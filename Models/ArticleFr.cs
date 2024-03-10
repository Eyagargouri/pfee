using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ArticleFr
{
    public string Aref { get; set; } = null!;

    public string Fref { get; set; } = null!;

    public string? CodeAf { get; set; }

    public decimal? PrixF { get; set; }

    public string? DelaiRecep { get; set; }

    public double? RemiseF { get; set; }

    public double? Tvaf { get; set; }
}
