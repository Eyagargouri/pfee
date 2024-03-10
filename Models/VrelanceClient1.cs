using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class VrelanceClient1
{
    public int UniqueId { get; set; }

    public string? DocType { get; set; }

    public string? Reference { get; set; }

    public string? Code { get; set; }

    public string? Client { get; set; }

    public decimal? Total { get; set; }

    public decimal? Montantreglé { get; set; }

    public decimal? TotalAvance { get; set; }

    public decimal? Reste { get; set; }

    public DateTime? DateCréation { get; set; }

    public DateTime? DateRecouvrement { get; set; }

    public DateTime? DateEcheance { get; set; }

    public DateTime? Date { get; set; }

    public string? ModeRegTier { get; set; }

    public string Commercial { get; set; } = null!;

    public string? DocRepresentant { get; set; }

    public int Etat { get; set; }
}
