using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class DocumentDc
{
    public string DocRef { get; set; } = null!;

    public string DocType { get; set; } = null!;

    public string NParametre { get; set; } = null!;

    public string? ValParametre { get; set; }
}
