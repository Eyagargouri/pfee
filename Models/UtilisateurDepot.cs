using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class UtilisateurDepot
{
    public string Depot { get; set; } = null!;

    public int IdTypeUser { get; set; }
}
