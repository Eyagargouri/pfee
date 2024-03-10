using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class Alert
{
    public int IdAlert { get; set; }

    public string Alert1 { get; set; } = null!;

    public string? AlertText { get; set; }

    public string? Ntable { get; set; }

    public string? Nchamp { get; set; }

    public string? Bande { get; set; }

    public decimal? Val { get; set; }
}
