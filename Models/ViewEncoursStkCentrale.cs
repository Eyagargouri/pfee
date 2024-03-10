using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ViewEncoursStkCentrale
{
    public string Aref { get; set; } = null!;

    public string? Adesignation { get; set; }

    public decimal? Pvht { get; set; }

    public decimal? QteDisponible { get; set; }

    public decimal? QteRes { get; set; }

    public decimal? QteDep { get; set; }

    public decimal? QteTousDep { get; set; }

    public decimal? Pvttc { get; set; }

    public double? AtauxTvav { get; set; }
}
