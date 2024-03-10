using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ContactsC
{
    public string? Ref { get; set; }

    public string Tcontact { get; set; } = null!;

    public string Valeur { get; set; } = null!;
}
