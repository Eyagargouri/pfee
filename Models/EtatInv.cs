using System;
using System.Collections.Generic;

namespace CRM;

public partial class EtatInv
{
    public string Aref { get; set; } = null!;

    public string? Adesignation { get; set; }

    public string? Sref { get; set; }

    public decimal? QteInv1 { get; set; }

    public double? QteInv2 { get; set; }

    public double? QteInv3 { get; set; }

    public double? QteEcart { get; set; }

    public string? Depot { get; set; }

    public bool? EtatInv1 { get; set; }

    public DateTime? DateOuvInv { get; set; }

    public DateTime? InvDate { get; set; }

    public decimal? QteAs { get; set; }

    public string RefInv { get; set; } = null!;

    public bool? Abloque { get; set; }

    public bool? Compt1 { get; set; }

    public bool? Compt2 { get; set; }

    public bool? Compt3 { get; set; }
}
