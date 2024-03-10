using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class TypeUtilisateur
{
    public int IdtypeU { get; set; }

    public string? NTypeU { get; set; }

    public virtual ICollection<UtilisateurApplication> UtilisateurApplications { get; set; } = new List<UtilisateurApplication>();
}
