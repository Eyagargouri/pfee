using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ConditionPayement
{
    public int? UniqueId { get; set; }

    public string DocType { get; set; } = null!;

    public string DocRef { get; set; } = null!;

    public int NumLigne { get; set; }

    public int TxReglement { get; set; }

    public string Description { get; set; } = null!;
}
