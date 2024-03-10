using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class Parametre
{
    public string TParametre { get; set; } = null!;

    public string NParametre { get; set; } = null!;

    public int? OOrder { get; set; }

    public string? Col { get; set; }

    public int? Id { get; set; }

    public string? NomSociete { get; set; }

    public string? EntetBanque { get; set; }

    public string? TitulaireCompte { get; set; }

    public decimal? PlafEscompte { get; set; }
}
