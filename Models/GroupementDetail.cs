using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class GroupementDetail
{
    public string Gtype { get; set; } = null!;

    public string Gref { get; set; } = null!;

    public string DocType { get; set; } = null!;

    public string DocRef { get; set; } = null!;

    public DateTime? DocDate { get; set; }

    public decimal? Montant { get; set; }

    public virtual Groupement Groupement { get; set; } = null!;
}
