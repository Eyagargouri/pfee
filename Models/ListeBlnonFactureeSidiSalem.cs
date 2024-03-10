using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ListeBlnonFactureeSidiSalem
{
    public string DocType { get; set; } = null!;

    public int UniqueId { get; set; }

    public string RaisonSocial { get; set; } = null!;

    public string? RefDoc { get; set; }

    public DateTime? Date { get; set; }

    public string? RefTiers { get; set; }

    public decimal? Montant { get; set; }

    public string Nptiers { get; set; } = null!;

    public string? RefExt { get; set; }

    public int? Année { get; set; }

    public string? Commentaire { get; set; }

    public string? Utilisateur { get; set; }

    public string? Facture { get; set; }

    public int Etat { get; set; }
}
