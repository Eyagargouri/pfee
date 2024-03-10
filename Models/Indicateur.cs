using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class Indicateur
{
    public int UniqueId { get; set; }

    public string? Titre { get; set; }

    public bool? Active { get; set; }

    public int? Order { get; set; }

    public string? Ntype { get; set; }

    public string? TypeAff { get; set; }

    public string? ProcSelect { get; set; }

    public int? BaseArcStart { get; set; }

    public int? BaseArcEnd { get; set; }

    public int? Pas { get; set; }

    public string? UserInd { get; set; }

    public int? Tbbasearcstart { get; set; }

    public int? Tbbasearcend { get; set; }

    public string? Proc1 { get; set; }
}
