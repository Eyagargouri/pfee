using System;
using System.Collections.Generic;

namespace CRM.Models;

public partial class ArtFamille
{
    public double? Identifant { get; set; }

    public string? Intitule { get; set; }

    public string? Perissable { get; set; }

    public string? Stock { get; set; }

    public string? Reservation { get; set; }

    public double? NbrJourVie { get; set; }

    public string? CodeQte { get; set; }

    public string? CodeTarif { get; set; }

    public double? Dc { get; set; }

    public string? FvnD1 { get; set; }

    public string? FvnD2 { get; set; }

    public string? FvnD3 { get; set; }

    public double? Majoration { get; set; }

    public string? SaisieInt { get; set; }

    public string? SaisiePrix { get; set; }

    public string? SaisieUni { get; set; }

    public double? TaxeSup { get; set; }

    public double? Tpf1 { get; set; }

    public double? Tpf2 { get; set; }

    public double? Transport { get; set; }

    public double? Tva { get; set; }

    public string? UnitePub { get; set; }

    public string? UniteVte { get; set; }

    public string? UniteStok { get; set; }

    public double? UniteVteCoef { get; set; }

    public double? UnitePubCoef { get; set; }

    public string? UniteAchar { get; set; }

    public double? UniteAcharCeof { get; set; }

    public double? TauxMajor { get; set; }

    public string? AvoirFin { get; set; }

    public double? StkMinimal { get; set; }

    public double? StkMaximal { get; set; }

    public double? StkSecurite { get; set; }

    public double? PrixRevient { get; set; }

    public double? DelaiLiv { get; set; }

    public string? UniteDelai { get; set; }

    public double? QteminApprov { get; set; }

    public string? CodeImpCpte { get; set; }

    public double? CoefStkSec { get; set; }

    public double? CoefStkMax { get; set; }

    public string? CodePrix { get; set; }

    public double? Iddepartement { get; set; }

    public string? Modesaisie { get; set; }

    public string? SaisieTxrem { get; set; }

    public double? Niveau { get; set; }

    public double? Ordre { get; set; }

    public string? Saisqtegpq { get; set; }

    public string? Saisieprix1 { get; set; }

    public string? Nbpqnull { get; set; }

    public double? IdDimension { get; set; }

    public double? PrecisionQte { get; set; }

    public double? Txmarge { get; set; }

    public string? CodeqteFixe { get; set; }

    public string? ModifCodeqteFixe { get; set; }

    public string? ModifDim1 { get; set; }

    public string? ModifDim2 { get; set; }

    public string? ModifDim3 { get; set; }

    public string? ModifNbpnull { get; set; }

    public string? ModifFvn1 { get; set; }

    public string? ModifFvn2 { get; set; }

    public string? ModifFvn3 { get; set; }

    public string? ModifQtec { get; set; }

    public string? ModifFvnc { get; set; }

    public string? ModifModesaisie { get; set; }

    public string? ModifCodeqte { get; set; }

    public string? ModifCodeTarif { get; set; }

    public string? ModifDc { get; set; }

    public string? ModifMajoration { get; set; }

    public string? ModifSaisieInt { get; set; }

    public string? ModifSaisiePrix { get; set; }

    public string? ModifSaisieUni { get; set; }

    public string? ModifStock { get; set; }

    public string? ModifTaxeSup { get; set; }

    public string? ModifTpf1 { get; set; }

    public string? ModifTpf2 { get; set; }

    public string? ModifTransport { get; set; }

    public string? ModifTva { get; set; }

    public string? ModifUnitePub { get; set; }

    public string? ModifUniteVte { get; set; }

    public string? ModifTauxmajor { get; set; }

    public string? ModifDelailiv { get; set; }

    public string? ModifUnitedelai { get; set; }

    public string? ModifCodeimpcpte { get; set; }

    public string? ModifCodeprix { get; set; }

    public string? ModifIddepartement { get; set; }

    public string? ModifSaisieTxrem { get; set; }

    public string? ModifNiveau { get; set; }

    public string? ModifSaisieprix1 { get; set; }

    public string? ModifIddimension { get; set; }

    public string? ModifPrecisionQte { get; set; }

    public string? ModifTxmarge { get; set; }

    public string? ModifUnitestock { get; set; }

    public string? ModifPerissable { get; set; }

    public string? ModifNbrjourvie { get; set; }

    public double? Codefacturation { get; set; }

    public string? Modifcodefacturation { get; set; }

    public string? CommandeFerme { get; set; }

    public string? ModifCmdeFerme { get; set; }

    public double? Delaiappro { get; set; }

    public string? ModifDelaiappro { get; set; }

    public string? ModifUniteappro { get; set; }

    public string? Uniteappro { get; set; }

    public string? Unitejourvie { get; set; }

    public string? ModifUnitejourvie { get; set; }

    public double? Txrem { get; set; }

    public string? Maxtxrem { get; set; }

    public string? ModifTxrem { get; set; }

    public string? ModifMaxtxrem { get; set; }

    public double? NbrpieceMsu { get; set; }

    public string? ModifNbrpieceMsu { get; set; }

    public double? Dim1n { get; set; }

    public double? Dim1 { get; set; }

    public double? Dim2 { get; set; }

    public double? Dim3 { get; set; }

    public string? TypeQteappro { get; set; }

    public string? ModifTypeQteappro { get; set; }

    public string? Impdim1 { get; set; }

    public string? Impdim3 { get; set; }

    public string? Impdim2 { get; set; }

    public string? ModifImpdim1 { get; set; }

    public string? ModifImpdim3 { get; set; }

    public string? ModifImpdim2 { get; set; }

    public string? Impnbrpiece { get; set; }

    public string? Impqtecolis { get; set; }

    public string? ModifImpnbrpiece { get; set; }

    public string? ModifImpqtecolis { get; set; }

    public string? FormuleQte { get; set; }

    public string? ModifFormuleQte { get; set; }

    public string? ModifStkminimun { get; set; }

    public string? ModifStkmaximum { get; set; }

    public string? ModifStksecurite { get; set; }

    public string? Image { get; set; }

    public string? ModifImage { get; set; }

    public string? TarifDouanier { get; set; }

    public string? ModifTarifDouanier { get; set; }

    public string? UniteStatistique { get; set; }

    public string? ModifUniteStatistique { get; set; }

    public string? Groupe { get; set; }

    public string? ModifGroupe { get; set; }

    public string? AbrevGraphique { get; set; }

    public string? Achat { get; set; }

    public string? Vente { get; set; }

    public string? ModifVente { get; set; }

    public string? ModifAchat { get; set; }

    public string? ProductionM { get; set; }

    public string? ModifProductionM { get; set; }
}
