using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class DecEmpA1
{
    public string? Identifiant { get; set; }

    public string Nom { get; set; } = null!;

    public string? Fonction { get; set; }

    public string? Adresse { get; set; }

    public string Sexe { get; set; } = null!;

    public string? SituationFamiliale { get; set; }

    public short? Nb { get; set; }

    public string? DateDeb { get; set; }

    public string? DateFin { get; set; }

    public int? Dure { get; set; }

    public decimal? RevenuImp { get; set; }

    public decimal? Retenu { get; set; }

    public decimal? NetServi { get; set; }

    public decimal? Contribution { get; set; }
}
