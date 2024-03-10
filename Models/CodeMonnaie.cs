using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class CodeMonnaie
{
    public int CodeM { get; set; }

    public string? DesignationM { get; set; }

    public string? AbreviationM { get; set; }

    public int? OrderM { get; set; }
}
