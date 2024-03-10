using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class BudgetPlafond
{
    public int UniqueId { get; set; }

    public string? BudgetType { get; set; }

    public string? Des { get; set; }

    public DateTime? DateCreation { get; set; }

    public DateTime? DatePrevu { get; set; }

    public DateTime? DocLancement { get; set; }

    public DateTime? DocCloture { get; set; }

    public string? Lcol1 { get; set; }

    public string? Lcol2 { get; set; }

    public string? Lcol3 { get; set; }

    public string? Lcol4 { get; set; }

    public string? Lcol5 { get; set; }

    public string? Lcol6 { get; set; }

    public string? Lcol7 { get; set; }

    public string? Lcol8 { get; set; }

    public bool? EtatBp { get; set; }

    public bool? EtatBp1 { get; set; }

    public string? LetatBp { get; set; }

    public string? LetatBp1 { get; set; }

    public int? Annee { get; set; }

    public int? Mois { get; set; }

    public string? Rib { get; set; }

    public string? Breception { get; set; }

    public bool? EtatBpCompta { get; set; }
}
