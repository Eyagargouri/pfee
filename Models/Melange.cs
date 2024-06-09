using System;
using System.Collections.Generic;

namespace CRM;

public partial class Melange
{
    public int UniqueId { get; set; }

    public string DateLancement { get; set; } = null!;

    public string DateCloture { get; set; } = null!;

    public string? Date { get; set; }

    public string DocType { get; set; } = null!;

    public string Lot { get; set; } = null!;

    public string? Mélange { get; set; }

    public string? QteMélange { get; set; }

    public string? QteReste { get; set; }

    public string? Qteconsommation { get; set; }

    public double? QteresteConsommation { get; set; }

    public string? Ocdocref { get; set; }

    public string? Ocrecipientdocart { get; set; }

    public double? Ocrecipientdocqte { get; set; }

    public string? Unite { get; set; }

    public DateTime? OcdocdocDate { get; set; }

    public string? OmnomencDocArt { get; set; }

    public double? OmnomencQte { get; set; }

    public string? LotOm { get; set; }

    public string? OmlqteDocArt { get; set; }

    public double? Omlqte { get; set; }

    public string? Expr1 { get; set; }

    public string? OmlqteLotLotArt { get; set; }

    public double? Expr2 { get; set; }

    public decimal? OmlqteLotPrix { get; set; }

    public string? Expr3 { get; set; }

    public string? BefqteDocArt { get; set; }

    public double? Befqte { get; set; }

    public DateTime? BefdocDate { get; set; }

    public string? BefOc { get; set; }

    public string? Bef { get; set; }

    public decimal? Befprix { get; set; }

    public string? RefTiers { get; set; }

    public string? DateEch { get; set; }

    public int? Année { get; set; }
}
