using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class VrelanceClientBft
{
    public int UniqueId { get; set; }

    public string? DocType { get; set; }

    public string Type { get; set; } = null!;

    public string? Reference { get; set; }

    public string? Code { get; set; }

    public string? Client { get; set; }

    public decimal? Total { get; set; }

    public decimal? Montantreglé { get; set; }

    public decimal? Reste { get; set; }

    public string? DateCréation { get; set; }

    public string? DateRecouvrement { get; set; }

    public string? Date { get; set; }

    public string? ModeRegTier { get; set; }

    public string? DocRepresentant { get; set; }
}
