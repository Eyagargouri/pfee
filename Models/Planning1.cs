using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class Planning1
{
    public int UniqueId { get; set; }

    public string? AllDay { get; set; }

    public string? AllowDelete { get; set; }

    public string? AllowEdit { get; set; }

    public decimal? BackGroundId { get; set; }

    public decimal? StatusId { get; set; }

    public string? Description { get; set; }

    public string? Location { get; set; }

    public string? Summary { get; set; }

    public string? Start { get; set; }

    public string? End { get; set; }

    public decimal? RecurrenceCount { get; set; }

    public string? RecurrenceStart { get; set; }

    public string? RecurrenceEnd { get; set; }

    public string? RecurrenceFrequency { get; set; }

    public decimal? RecurrenceInterval { get; set; }

    public string? HeurePla { get; set; }

    public bool? Affichage { get; set; }

    public string? Terrain { get; set; }

    public string? DocTiers { get; set; }

    public bool? Abonnement { get; set; }

    public string? Idab { get; set; }
}
