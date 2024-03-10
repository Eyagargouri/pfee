using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ViewRepartitionDesFrai
{
    public int UniqueId { get; set; }

    public string? IdCampagne { get; set; }

    public string? Crmtype { get; set; }

    public string? Des { get; set; }

    public string? Col1 { get; set; }

    public string? Col2 { get; set; }

    public string? Col3 { get; set; }

    public string? Col4 { get; set; }

    public int? DocProjet { get; set; }
}
