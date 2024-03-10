using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class Budget
{
    public int UniqueId { get; set; }

    public int Annee { get; set; }

    public int Mois { get; set; }

    public decimal Budget1 { get; set; }

    public decimal BudgetJ { get; set; }

    public string Rib { get; set; } = null!;

    public string? Breception { get; set; }
}
