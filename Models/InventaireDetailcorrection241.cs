using System;
using System.Collections.Generic;

namespace CRM;

public partial class InventaireDetailcorrection241
{
    public string RefInv { get; set; } = null!;

    public string Aref { get; set; } = null!;

    public double? AqteStock { get; set; }

    public decimal? QteInv1 { get; set; }

    public double? QteInv2 { get; set; }

    public double? QteInv3 { get; set; }

    public double? QteEcart { get; set; }

    public decimal? ApuachatHt { get; set; }

    public DateTime? InvDate { get; set; }

    public int UniqueId { get; set; }

    public string? DocArtDesignation { get; set; }

    public string? ParentRef { get; set; }

    public int? DocNumLigne { get; set; }
}
