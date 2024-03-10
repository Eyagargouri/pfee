using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class Crmcampagne
{
    public int UniqueId { get; set; }

    public string? Crmtype { get; set; }

    public string? Des { get; set; }

    public DateTime? DateCreation { get; set; }

    public DateTime? DatePrevu { get; set; }

    public DateTime? DocLancement { get; set; }

    public DateTime? DocCloture { get; set; }

    public string? Lcol1 { get; set; }

    public string? Lcol2 { get; set; }

    public string? Lcol3 { get; set; }

    public bool? EtatBp { get; set; }

    public bool? EtatBp1 { get; set; }

    public string? LetatBp { get; set; }

    public string? LetatBp1 { get; set; }

    public string? Rtf { get; set; }

    public string? Txt { get; set; }

    public string? Ref { get; set; }

    public DateTime? DateMail { get; set; }
}
