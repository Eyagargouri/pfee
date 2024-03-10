using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class Bcencour
{
    public string Docref { get; set; } = null!;

    public decimal? DocTotalHt { get; set; }

    public string? CraisonSocial { get; set; }

    public DateTime? Docdate { get; set; }

    public string DocType { get; set; } = null!;

    public string? DocTiers { get; set; }

    public string? Ematricule { get; set; }
}
