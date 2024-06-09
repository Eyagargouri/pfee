using System;
using System.Collections.Generic;

namespace CRM;

public partial class FactureVNr
{
    public string DocRef { get; set; } = null!;

    public DateTime? DocDate { get; set; }

    public string? DocTiers { get; set; }

    public DateTime? DocLancement { get; set; }

    public decimal? DocNetaPayer { get; set; }
}
