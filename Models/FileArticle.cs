using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class FileArticle
{
    public string Aref { get; set; } = null!;

    public int UniqueIdfile { get; set; }

    public string? FileName { get; set; }

    public string? FileTitre { get; set; }
}
