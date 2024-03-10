using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ViewEncoursTransfert
{
    public int UniqueId { get; set; }

    public string? Date { get; set; }

    public double Expr1 { get; set; }

    public double Total { get; set; }

    public string DocType { get; set; } = null!;

    public string RaisonSocial { get; set; } = null!;

    public string DocArt { get; set; } = null!;

    public string? DocArtDesignation { get; set; }

    public int Idlg { get; set; }
}
