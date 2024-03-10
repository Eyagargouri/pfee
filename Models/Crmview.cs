using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class Crmview
{
    public string? DocRef { get; set; }

    public DateTime? DocDate { get; set; }

    public string? DocTiers { get; set; }

    public string? Crmtype { get; set; }

    public string? IdCampagne { get; set; }

    public string? Des { get; set; }

    public DateTime? DateCreation { get; set; }

    public DateTime? DatePrevu { get; set; }

    public string? Rtf { get; set; }

    public string? Txt { get; set; }

    public DateTime? DocLancement { get; set; }

    public DateTime? DocCloture { get; set; }

    public string? Lcol1 { get; set; }

    public string? Lcol2 { get; set; }

    public bool? EtatBp { get; set; }

    public bool? EtatBp1 { get; set; }

    public string? LetatBp { get; set; }

    public string? LetatBp1 { get; set; }

    public string? ListeType { get; set; }

    public string? DocArt { get; set; }

    public decimal? DocPunit { get; set; }

    public double? DocQte { get; set; }

    public double? DocRemise { get; set; }

    public decimal? DocTotalHt { get; set; }

    public double? DocTxTva { get; set; }

    public decimal? DocTotalTva { get; set; }

    public decimal? DocTotalTtc { get; set; }

    public string? DocType { get; set; }

    public string? Ref { get; set; }

    public string? Cnom { get; set; }

    public string? Cprenom { get; set; }

    public string? CraisonSocial { get; set; }

    public string? Cref { get; set; }

    public string? Expr1 { get; set; }

    public string? Expr2 { get; set; }

    public string? Expr3 { get; set; }

    public int UniqueId { get; set; }

    public int IdtypeUser { get; set; }
}
