using System;
using System.Collections.Generic;

namespace CRM;

public partial class Edition
{
    public string EdType { get; set; } = null!;

    public string EdNom { get; set; } = null!;

    public string? EdNomRtp { get; set; }

    public string? Menu { get; set; }

    public string? Smenu { get; set; }

    public string? Ordre { get; set; }

    public string? UserEdition { get; set; }
}
