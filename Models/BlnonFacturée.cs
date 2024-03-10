using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class BlnonFacturée
{
    public int UniqueId { get; set; }

    public string DocType { get; set; } = null!;

    public string? Filiere { get; set; }

    public string DocRef { get; set; } = null!;

    public string? RefTiers { get; set; }

    public string Tiers { get; set; } = null!;

    public decimal? NetàPayer { get; set; }

    public string? Date { get; set; }
}
