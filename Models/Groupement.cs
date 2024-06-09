using System;
using System.Collections.Generic;

namespace CRM;

public partial class Groupement
{
    public string Gtype { get; set; } = null!;

    public string Gref { get; set; } = null!;

    public DateTime? Gdate { get; set; }

    public string? Gcomm { get; set; }

    public decimal? Gmontant { get; set; }

    public string? Gtiers { get; set; }

    public virtual ICollection<GroupementDetail> GroupementDetails { get; set; } = new List<GroupementDetail>();
}
