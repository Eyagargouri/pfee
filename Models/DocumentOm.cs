using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class DocumentOm
{
    public int UniqueIddoc { get; set; }

    public string DocRef { get; set; } = null!;

    public string DocType { get; set; } = null!;

    public string Expr1 { get; set; } = null!;

    public string DocArt { get; set; } = null!;

    public double? DocQte { get; set; }

    public string? Adesignation { get; set; }

    public DateTime? DocDateEcheance { get; set; }
}
