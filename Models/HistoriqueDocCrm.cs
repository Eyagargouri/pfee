using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class HistoriqueDocCrm
{
    public string? UniqueId { get; set; }

    public DateTime? DateEven { get; set; }

    public string? TypeEven { get; set; }

    public string? Ematricule { get; set; }

    public string? TypeF { get; set; }
}
