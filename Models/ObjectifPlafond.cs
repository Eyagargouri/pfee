using System;
using System.Collections.Generic;

namespace CRM;

public partial class ObjectifPlafond
{
    public int UniqueId { get; set; }

    public string? ObjectifType { get; set; }

    public DateTime? DateCreation { get; set; }

    public DateTime? DatePrevu { get; set; }

    public DateTime? DocLancement { get; set; }

    public DateTime? DocCloture { get; set; }

    public string? Lcol1 { get; set; }

    public string? Lcol2 { get; set; }

    public string? Lcol3 { get; set; }

    public bool? EtatBp { get; set; }

    public bool? EtatBp1 { get; set; }

    public string? LetatBp { get; set; }

    public string? LetatBp1 { get; set; }

    public int? Annee { get; set; }

    public int? Mois { get; set; }

    public string? Commercial { get; set; }
}
