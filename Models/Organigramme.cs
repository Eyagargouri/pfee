using System;
using System.Collections.Generic;

namespace CRM;

public partial class Organigramme
{
    public string Id { get; set; }

    public string? EmatriculeSubordonné { get; set; }

    public string? NomSubordonné { get; set; }

    public string? EmatriculeSupérieur { get; set; }

    public string? NomSupérieur { get; set; }

    public virtual Employee? IdNavigation { get; set; }
}
