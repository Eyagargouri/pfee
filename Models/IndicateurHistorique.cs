using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class IndicateurHistorique
{
    public int UniqueId { get; set; }

    public int? IdIndicateur { get; set; }

    public DateTime? DateVal { get; set; }

    public decimal? Valeur { get; set; }
}
