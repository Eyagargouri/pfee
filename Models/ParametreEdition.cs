using System;
using System.Collections.Generic;

namespace CRM;

public partial class ParametreEdition
{
    public string Designation { get; set; } = null!;

    public string ParametreRpt { get; set; } = null!;

    public int? OrderRpt { get; set; }

    public string TypeChamp { get; set; } = null!;

    public string? Requete { get; set; }

    public bool? Bouton { get; set; }

    public int? Ligne { get; set; }

    public string? Formulaire { get; set; }
}
