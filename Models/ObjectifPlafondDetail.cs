using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ObjectifPlafondDetail
{
    public int UniqueId { get; set; }

    public int? UniqueIdObj { get; set; }

    public string? Param1 { get; set; }

    public string? Param2 { get; set; }

    public string? Param3 { get; set; }

    public string? Param4 { get; set; }

    public string? Param5 { get; set; }

    public string? Param6 { get; set; }

    public decimal? Objectif { get; set; }
}
