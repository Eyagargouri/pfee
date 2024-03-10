using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class UtilisateurImg
{
    public string Ematricule { get; set; } = null!;

    public byte[]? Img { get; set; }
}
