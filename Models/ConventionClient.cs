using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ConventionClient
{
    public string Cref { get; set; } = null!;

    public string Aref { get; set; } = null!;

    public decimal Apvttc { get; set; }

    public double? Aremise { get; set; }
}
