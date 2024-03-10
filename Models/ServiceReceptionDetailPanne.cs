using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ServiceReceptionDetailPanne
{
    public int Id { get; set; }

    public string BonReception { get; set; } = null!;

    public int IdServicePanne { get; set; }
}
