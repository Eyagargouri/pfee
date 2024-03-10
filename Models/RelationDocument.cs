using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class RelationDocument
{
    public string CodeDoc { get; set; } = null!;

    public string CodeDocR { get; set; } = null!;

    public string? ProcDoc { get; set; }

    public string? SelectionLigne { get; set; }
}
