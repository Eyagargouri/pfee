using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ConfigSociete
{
    public string? NSoc { get; set; }

    public string? ASoc { get; set; }

    public string? TSoc { get; set; }

    public string? FSoc { get; set; }

    public string? MSoc { get; set; }

    public string? SSoc { get; set; }

    public string? EmSoc { get; set; }

    public string? MfSoc { get; set; }

    public string? RcSoc { get; set; }

    public string? CapSoc { get; set; }

    public string? LName { get; set; }

    public byte[]? LSoc { get; set; }

    public decimal? MinMarge { get; set; }

    public decimal? TimberFiscal { get; set; }

    public string? Bcv { get; set; }

    public string? Blv { get; set; }

    public string? Fav { get; set; }

    public string? Dev { get; set; }

    public string? Fpv { get; set; }

    public string? Brv { get; set; }

    public string? Bpv { get; set; }

    public string? Faav { get; set; }

    public string? Bca { get; set; }

    public string? Bla { get; set; }

    public string? Faa { get; set; }

    public string? Bes { get; set; }

    public string? Bss { get; set; }

    public string? Enc { get; set; }

    public string? Denc { get; set; }

    public string? NbChiffre { get; set; }

    public string? Dde { get; set; }

    public string? Bra { get; set; }

    public string? Faaa { get; set; }

    public bool? PunitV { get; set; }

    public bool? PunitA { get; set; }

    public int? RetraitStock { get; set; }

    public string? Msmtp { get; set; }

    public string? Mlogin { get; set; }

    public string? Mpw { get; set; }

    public string? ServerName { get; set; }

    public string? UserId { get; set; }

    public string? Password { get; set; }

    public bool? IntegrationSecurite { get; set; }

    public string? FormatDoc { get; set; }

    public bool? ActiverMail { get; set; }

    public int? Heurev { get; set; }

    public int? Minutev { get; set; }

    public int? Secondev { get; set; }

    public string? Ddevise { get; set; }

    public bool? BlocInv { get; set; }

    public bool? Fodec { get; set; }

    public double? MargeMinDevis { get; set; }

    public decimal? PerteGain { get; set; }

    public decimal? TauxInterret { get; set; }

    public string? Activite { get; set; }

    public string? Ville { get; set; }

    public string? Rue { get; set; }

    public string? Numero { get; set; }

    public string? CodePosta { get; set; }

    public DateTime? DateFinBilan { get; set; }
}
