using System;
using System.Collections.Generic;

namespace CRM;

public partial class EcartTransfert
{
    public string DocRef { get; set; } = null!;

    public string DocArt { get; set; } = null!;

    public double? QteEntree { get; set; }

    public double? QteSortie { get; set; }

    public double? Ecart { get; set; }

    public string? Ematricule { get; set; }

    public DateTime? DocDate { get; set; }
}
