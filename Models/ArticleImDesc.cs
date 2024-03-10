using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ArticleImDesc
{
    public string Aref { get; set; } = null!;

    public byte[]? Pimage { get; set; }

    public string? Adescription { get; set; }
}
