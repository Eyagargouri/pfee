using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class DocumentCritere
{
    public string CritNom { get; set; } = null!;

    public string? CritDocument { get; set; }

    public string? CritRequete { get; set; }
}
