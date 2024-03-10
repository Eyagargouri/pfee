using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ViewImmobilisation
{
    public int UniqueId { get; set; }

    public DateTime? DateCreation { get; set; }

    public string? DescriptionImmo { get; set; }

    public DateTime? DateOperation { get; set; }

    public string? Code { get; set; }

    public string? Description2 { get; set; }

    public string? Lcol3 { get; set; }

    public string? Utilisateur { get; set; }

    public string? CodeCatégorie { get; set; }

    public string? DesCatégorie { get; set; }

    public string? CodeArticle { get; set; }

    public string? DesignationArt { get; set; }

    public string? Description { get; set; }

    public string? CodeDestination { get; set; }

    public string? Destination { get; set; }

    public string? CodeUser { get; set; }

    public string? User { get; set; }
}
