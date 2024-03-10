using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class HistoriqueCloture
{
    public int UniqueId { get; set; }

    public DateTime? DateCloture { get; set; }

    public string? MontantCloture { get; set; }

    public bool EtatCloture { get; set; }
}
