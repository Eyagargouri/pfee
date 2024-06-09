using System;
using System.Collections.Generic;

namespace CRM;

public partial class EtatStockDepotFamille
{
    public string Depot { get; set; } = null!;

    public string? Aref { get; set; }

    public string? Désignation { get; set; }

    public string? Famille { get; set; }

    public decimal? Stock { get; set; }

    public decimal? Pvht { get; set; }

    public double? Remise { get; set; }

    public decimal? PUVntTtc { get; set; }

    public decimal? Prix1 { get; set; }

    public decimal? Prix2 { get; set; }

    public decimal? Prix3 { get; set; }
}
