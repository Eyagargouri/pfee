using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class UtilisateurAlert
{
    public string Alert { get; set; } = null!;

    public int IdtypeUser { get; set; }

    public int? TypeBande { get; set; }
}
