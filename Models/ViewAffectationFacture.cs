using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ViewAffectationFacture
{
    public string? IdCampagne { get; set; }

    public string? Etat { get; set; }

    public string? Action { get; set; }

    public string? Commentaire { get; set; }

    public string? Type { get; set; }

    public string? Reference { get; set; }

    public string? DateFact { get; set; }

    public string? Client { get; set; }

    public string? Total { get; set; }

    public DateTime? DateCreation { get; set; }

    public string? Ref { get; set; }

    public string? CraisonSocial { get; set; }

    public string? Cnom { get; set; }

    public string? Cprenom { get; set; }

    public string? Cref { get; set; }

    public string? Crmtype { get; set; }
}
