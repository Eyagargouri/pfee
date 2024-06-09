using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class UtilisateurApplication
{
    public string? Ematricule{ get; set; } = null!;

    public int? IdtypeUser { get; set; }

    public string Login { get; set; } = null!;

    public string Motdepasse { get; set; } = null!;

    public bool ActiverCompte { get; set; }

    public bool? ActiverColonneDgv { get; set; }

    public bool? ActiverArticle { get; set; }

    public bool? ActiverTiers { get; set; }

    public string? Motdepasse2 { get; set; }

    public bool? ActiveAvoir { get; set; }

    public bool? ActiveAvoirTic { get; set; }

    public virtual Employee? Employee { get; set; }

    public virtual TypeUtilisateur? IdtypeUserNavigation { get; set; } = null!;
}
