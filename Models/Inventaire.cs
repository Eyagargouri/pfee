using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class Inventaire
{
    public string Idinv { get; set; } = null!;

    public string RefInv { get; set; } = null!;

    public DateTime? DateOuvInv { get; set; }

    public bool? EtatInv { get; set; }

    public bool? RazartNinv { get; set; }

    public bool? Compt1 { get; set; }

    public bool? Compt2 { get; set; }

    public bool? Compt3 { get; set; }

    public string? ModeInv { get; set; }

    public string? Depot { get; set; }

    public virtual ICollection<InventaireDetail> InventaireDetails { get; set; } = new List<InventaireDetail>();
}
