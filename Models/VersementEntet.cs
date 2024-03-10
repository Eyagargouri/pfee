using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class VersementEntet
{
    public string BordRef { get; set; } = null!;

    public string? BordType { get; set; }

    public DateTime? BordDate { get; set; }

    public DateTime? BordDateVers { get; set; }

    public string? BordTypeVers { get; set; }

    public string? BordBanque { get; set; }

    public string? BordNumCompte { get; set; }

    public string? BordModePaie { get; set; }

    public decimal? BordMontant { get; set; }

    public string? Commentaire { get; set; }

    public string? MntLettre { get; set; }

    public string? BordBanqExt { get; set; }

    public string? LabNumImp { get; set; }

    public int UniqueId { get; set; }

    public bool? IntegCompta { get; set; }

    public bool? IntegJourCa { get; set; }

    public bool? ValidationSihem { get; set; }
}
