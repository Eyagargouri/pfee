using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class EtatCaparClientFamilleArticle
{
    public double DocTxDevise { get; set; }

    public string? Afamille { get; set; }

    public string DocRef { get; set; } = null!;

    public string DocType { get; set; } = null!;

    public string? Tiers { get; set; }

    public double? Doctotalht { get; set; }

    public DateTime? DocDate { get; set; }
}
