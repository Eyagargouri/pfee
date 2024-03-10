using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class FileTier
{
    public string Cref { get; set; } = null!;

    public int UniqueIdfile { get; set; }

    public string? FileName { get; set; }

    public string? FileTitre { get; set; }
}
