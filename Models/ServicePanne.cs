using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ServicePanne
{
    public int Id { get; set; }

    public string Panne { get; set; } = null!;

    public string Idservice { get; set; } = null!;

    public int? Ordre { get; set; }
}
