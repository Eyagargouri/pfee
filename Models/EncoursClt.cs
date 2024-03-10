using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class EncoursClt
{
    public int? UniqueId { get; set; }

    public string? Cref { get; set; }

    public string? DocRef { get; set; }

    public string? DocType { get; set; }

    public DateTime? DocDate { get; set; }

    public DateTime? DateEch { get; set; }

    public decimal? MontantR { get; set; }

    public decimal? Reste { get; set; }

    public decimal? DocNetaPayer { get; set; }

    public DateTime? DateI { get; set; }

    public string? Expr2 { get; set; }

    public string? Expr3 { get; set; }

    public DateTime? Expr1 { get; set; }

    public string? Expr4 { get; set; }

    public DateTime? DocDateEcheance { get; set; }

    public string? ModeReg { get; set; }

    public string? Npieces { get; set; }

    public DateTime? DateRegImp { get; set; }
}
