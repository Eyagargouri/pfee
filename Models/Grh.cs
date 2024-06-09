using System;
using System.Collections.Generic;

namespace CRM;

public partial class Grh
{
    public int Uniqueid { get; set; }

    public string? TypeGrh { get; set; }

    public string? CodeTiers { get; set; }

    public string? Des { get; set; }

    public string? Aup { get; set; }

    public string? Moydep { get; set; }

    public string? Duree { get; set; }

    public string? Obj { get; set; }

    public DateTime? DateDeb { get; set; }

    public DateTime? DateFin { get; set; }

    public string? HeurDeb { get; set; }

    public string? HeurFin { get; set; }

    public decimal? NbreJour { get; set; }

    public DateTime? DateL { get; set; }

    public DateTime? DateC { get; set; }

    public string? Categorie { get; set; }

    public bool? EtatBp { get; set; }

    public bool? EtatBp1 { get; set; }

    public string? Ref { get; set; }
    public bool? Validation { get; set; }

    public virtual Employee? CodeTiersNavigation { get; set; }
}
