using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ContactsAut
{
    public string Ref { get; set; } = null!;

    public string? Tcontact { get; set; }

    public string Valeur { get; set; } = null!;
}
