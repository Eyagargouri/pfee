using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ViewValidationOrganigrammeDum
{
    public string? EmatSup { get; set; }

    public string? Valeur { get; set; }

    public DateTime? DateDeb { get; set; }

    public decimal? NbreJour { get; set; }

    public DateOnly? DateFin { get; set; }

    public string? Codetiers { get; set; }

    public string Tiers { get; set; } = null!;

    public string? EmatSup2 { get; set; }

    public string? Sup2 { get; set; }

    public string? Ref { get; set; }

    public string? Matricule { get; set; }
}
