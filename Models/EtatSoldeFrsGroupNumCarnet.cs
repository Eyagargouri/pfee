using System;
using System.Collections.Generic;

namespace CRM;

public partial class EtatSoldeFrsGroupNumCarnet
{
    public string DocType { get; set; } = null!;

    public string? DocRef { get; set; }

    public DateTime? DocDate { get; set; }

    public DateTime? DocDateEcheance { get; set; }

    public string? DocTiers { get; set; }

    public decimal? DocMontant { get; set; }

    public DateTime? DateV { get; set; }

    public string? ModeReg { get; set; }

    public DateTime? DateI { get; set; }
}
