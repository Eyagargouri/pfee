using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ReleveImpayeTuni
{
    public int UniqueId { get; set; }

    public string? BudgetType { get; set; }

    public string? Des { get; set; }

    public DateTime? DateCreation { get; set; }

    public string? DocRef { get; set; }

    public string? Cref { get; set; }

    public string? CraisonSocial { get; set; }

    public string? ModeReg { get; set; }

    public string? Bpieces { get; set; }

    public DateTime? DocDate { get; set; }

    public decimal? MontantR { get; set; }

    public int? NumEncAffec { get; set; }
}
