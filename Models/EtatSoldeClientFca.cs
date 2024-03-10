using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class EtatSoldeClientFca
{
    public string? DocRef { get; set; }

    public string DocType { get; set; } = null!;
}
