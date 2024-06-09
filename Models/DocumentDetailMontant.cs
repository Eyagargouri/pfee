using System;
using System.Collections.Generic;

namespace CRM;

public partial class DocumentDetailMontant
{
    public string DocType { get; set; } = null!;

    public string DocRef { get; set; } = null!;

    public string DocTiers { get; set; } = null!;

    public decimal? DocNetaPayer { get; set; }
}
