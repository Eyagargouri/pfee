﻿using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class UtilisateurEdition
{
    public int IdTypeU { get; set; }

    public string Menu { get; set; } = null!;

    public string? Parent { get; set; }
}
