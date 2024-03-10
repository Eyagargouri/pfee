using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class TiersCarteVisiteGroup
{
    public int? UniqueId { get; set; }

    public bool? Active { get; set; }

    /// <summary>
    /// 2:Sum
    /// 3:Min
    /// 4:Max
    /// 5:Last
    /// 6:First
    /// 7:Count
    /// 8:Avg
    /// 9:StDev
    /// 10:Var
    /// </summary>
    public string? Fonction { get; set; }

    public string? Colonne { get; set; }

    /// <summary>
    /// Group Header Row
    /// Top Summary Rows
    /// Bottom Summary Rows
    /// </summary>
    public string? TopBottom { get; set; }

    public int? RowNum { get; set; }
}
