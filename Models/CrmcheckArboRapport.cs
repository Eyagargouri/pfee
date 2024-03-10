using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class CrmcheckArboRapport
{
    public int UniqueId { get; set; }

    public string? Ref { get; set; }

    public string? Type { get; set; }

    public string? Menu { get; set; }

    public string? Parent { get; set; }

    public int? Crmaction { get; set; }
}
