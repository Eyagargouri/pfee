using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class Crmliste
{
    public int UniqueId { get; set; }

    public int? IdAction { get; set; }

    public string? IdCampagne { get; set; }

    public string? Crmtype { get; set; }

    public string? ListeType { get; set; }

    public string? Code { get; set; }

    public string? Ref { get; set; }

    public string? CodeListe { get; set; }

    public string? Commentaire { get; set; }
}
