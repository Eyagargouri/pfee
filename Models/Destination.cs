using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class Destination
{
    public string RefD { get; set; } = null!;

    public string Cref { get; set; } = null!;

    public string TypeD { get; set; } = null!;

    public string NDest { get; set; } = null!;

    public string? PaysD { get; set; }

    public string? VilleD { get; set; }

    public string? AdresseD { get; set; }
}
