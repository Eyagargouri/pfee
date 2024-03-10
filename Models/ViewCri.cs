using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ViewCri
{
    public string? Document { get; set; }

    public string? Code { get; set; }

    public string Client { get; set; } = null!;

    public string? TypeDePièce { get; set; }

    public decimal? Montant { get; set; }

    public string? NPieces { get; set; }

    public DateTime? Echeance { get; set; }

    public int? UniqueId { get; set; }

    public DateTime? DateCreation { get; set; }

    public string? Bq { get; set; }

    public string? Des { get; set; }

    public DateTime? Date { get; set; }
}
