using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class VvisiteClient
{
    public int UniqueId { get; set; }

    public bool? Choix { get; set; }

    public string? Des { get; set; }

    public DateTime? DocLancement { get; set; }

    public DateTime? DatePrevu { get; set; }

    public string? Cref { get; set; }

    public string? Rsocial { get; set; }

    public string? Ville { get; set; }

    public string? Secteur { get; set; }

    public string ListeType { get; set; } = null!;

    public string? ListeId { get; set; }

    public string? Txt { get; set; }

    public int Etat { get; set; }

    public string Lcol2 { get; set; } = null!;
}
