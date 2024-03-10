using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ArticleSource
{
    public string Aref { get; set; } = null!;

    public string Sref { get; set; } = null!;

    public decimal? QteAs { get; set; }
}
