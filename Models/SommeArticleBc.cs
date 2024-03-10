using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class SommeArticleBc
{
    public string Article { get; set; } = null!;

    public decimal Janvier { get; set; }

    public decimal Février { get; set; }

    public decimal Mars { get; set; }

    public decimal Avril { get; set; }

    public decimal Mai { get; set; }

    public decimal Juin { get; set; }

    public decimal Juillet { get; set; }

    public decimal Août { get; set; }

    public decimal Septembre { get; set; }

    public decimal Octobre { get; set; }

    public decimal Novembre { get; set; }

    public decimal Décembre { get; set; }

    public decimal Total { get; set; }
}
