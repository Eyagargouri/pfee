using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class CalculPmp
{
    public int UniqueId { get; set; }

    public DateTime? DocDate { get; set; }

    public string? DocArt { get; set; }

    public double? Qte { get; set; }

    public decimal? Revient { get; set; }

    public string Type { get; set; } = null!;
}
