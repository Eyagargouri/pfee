using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class PrdNomenclature
{
    public string Aref { get; set; } = null!;

    public string ArefCom { get; set; } = null!;

    public double QteUtilise { get; set; }

    public int? IdPf { get; set; }

    public int? IdPfp { get; set; }
}
