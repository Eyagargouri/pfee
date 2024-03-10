using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class TiersCarteVisite
{
    public int UniqueId { get; set; }

    public string? Titre { get; set; }

    public bool? Active { get; set; }

    public int? Order { get; set; }

    public string? Ntype { get; set; }

    public string? TypeAff { get; set; }

    public string? ProcSelect { get; set; }

    public string? Color { get; set; }

    public bool? DocumentBc { get; set; }

    public bool? Param { get; set; }

    public string? ParamName { get; set; }

    public string? ParamCode { get; set; }

    public string? UserInf { get; set; }
}
