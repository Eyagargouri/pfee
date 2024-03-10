using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class TypeTier
{
    public string CodeType { get; set; } = null!;

    public string LibType { get; set; } = null!;

    public bool? Psolde { get; set; }

    public bool? Plocal { get; set; }

    public bool? Pcontact { get; set; }

    public bool? Pfidelite { get; set; }

    public bool? Pcompte { get; set; }

    public bool? TiersStat { get; set; }

    public bool? Convention { get; set; }

    public string? Vbouton { get; set; }

    public string? ProcRecherche { get; set; }
}
