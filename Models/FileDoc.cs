﻿using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class FileDoc
{
    public int UniqueId { get; set; }

    public int UniqueIdfile { get; set; }

    public string? FileName { get; set; }

    public string? FileTitre { get; set; }
}
