using System;
using System.Collections.Generic;
using CRM.Models;

namespace CRM;

public partial class Employee
{
    public string Ematricule { get; set; } = null!;

    public string? Eprenom { get; set; }

    public string? Enom { get; set; }

    public string? Ecin { get; set; }

    public DateTime? EdateNaiss { get; set; }

    public string? Esexe { get; set; }

    public string? Enationalite { get; set; }

    public string? Epassport { get; set; }

    public string? Efonction { get; set; }

    public string? Ebadge { get; set; }

    public string? EmodePay { get; set; }

    public string? EsituationFam { get; set; }

    public string? Ebanque { get; set; }

    public string? EnumCompte { get; set; }

    public string? EcycleTravail { get; set; }

    public string? Eassurance { get; set; }

    public DateTime? EdateAssurance { get; set; }

    public string? EnumAssurance { get; set; }

    public bool? EchefFamille { get; set; }

    public DateTime? EdateMariage { get; set; }

    public string? EnomConjoint { get; set; }

    public string? Ecinconjoint { get; set; }

    public int? EnombreEnfant { get; set; }

    public int? EnombreCharge { get; set; }

    public string? CodeTiers { get; set; } = null!;

    public virtual UtilisateurApplication? EmatriculeNavigation { get; set; } = null!;

    public virtual ICollection<Grh> Grhs { get; set; } = new List<Grh>();
}
