using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class TiersCarteVisiteNiveau
{
    public int? UniqueId { get; set; }

    public bool? Active { get; set; }

    public string? ProcNiv1 { get; set; }

    public string? ProcNiv2 { get; set; }

    public string? ColonneRelation { get; set; }

    public bool? ChampDeJointureVisibleNiveau1 { get; set; }

    public bool? ChampDeJointureVisibleNiveau2 { get; set; }
}
