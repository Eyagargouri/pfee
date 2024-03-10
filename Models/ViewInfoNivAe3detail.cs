using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ViewInfoNivAe3detail
{
    public int UniqueId { get; set; }

    public string Article { get; set; } = null!;

    public string? Designation { get; set; }

    public double? Qte { get; set; }

    public double QteRestante { get; set; }

    public decimal? Px { get; set; }

    public decimal? Tht { get; set; }
}
