using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class RessourcesMateriel
{
    public string? Rmdesignation { get; set; }

    public string? Rmfonction { get; set; }

    public string Rmmatricule { get; set; } = null!;

    public string? Rmmarque { get; set; }

    public DateTime? RmdateAcquisition { get; set; }

    public double? RmcoutAcquisition { get; set; }

    public double? TxHoraire { get; set; }

    public double? Tonnage { get; set; }

    public double? Volume { get; set; }

    public string? ZoneRm { get; set; }

    public int UniqueId { get; set; }
}
