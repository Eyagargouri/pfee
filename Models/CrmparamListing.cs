using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class CrmparamListing
{
    public int UniqueId { get; set; }

    public string? Type { get; set; }

    public bool? Cinsert { get; set; }

    public bool? CreadOnly { get; set; }

    public bool? Cnumber { get; set; }

    public bool? CdateTime { get; set; }

    public bool? Cmultiple { get; set; }

    public bool? Caddition { get; set; }

    public bool? Ctotal { get; set; }

    public bool? Caction { get; set; }

    public bool? CcomboBox { get; set; }

    public bool? CcomboBoxChange { get; set; }

    public string CtitreColonne { get; set; } = null!;

    public int? Corder { get; set; }

    public bool? CcheckBox { get; set; }

    public string? Formule { get; set; }
}
