using System;
using System.Collections.Generic;

namespace CRM;

public partial class DocumentControlDetail
{
    public int UniqueId { get; set; }

    public string CodeDoc { get; set; } = null!;

    public string? Designation { get; set; }

    public string? Commentaire { get; set; }

    public string? Min { get; set; }

    public string? Max { get; set; }
}
