using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ServiceReception
{
    public int Id { get; set; }

    public string BonReception { get; set; } = null!;

    public int IdService { get; set; }

    public string Tiers { get; set; } = null!;

    public string? Marque { get; set; }

    public string? Model { get; set; }

    public string? NumSerie { get; set; }

    public string? Etat { get; set; }

    public DateTime? Date { get; set; }

    public string? Reference { get; set; }
}
