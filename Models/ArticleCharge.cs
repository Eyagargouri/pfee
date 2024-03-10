using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ArticleCharge
{
    public string Aref { get; set; } = null!;

    public string NCharge { get; set; } = null!;

    public string? TCharge { get; set; }

    public decimal? Valeur { get; set; }

    public decimal? TotalCharge { get; set; }
}
