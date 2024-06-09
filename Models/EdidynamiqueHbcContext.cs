using System;
using System.Collections.Generic;
using CRM.Models;
using Microsoft.EntityFrameworkCore;

namespace CRM;

public partial class EdidynamiqueHbcContext : DbContext
{
    public EdidynamiqueHbcContext()
    {
    }

    public EdidynamiqueHbcContext(DbContextOptions<EdidynamiqueHbcContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Agroimp> Agroimps { get; set; }

    public virtual DbSet<Alert> Alerts { get; set; }

    public virtual DbSet<AlertB> AlertBs { get; set; }

    public virtual DbSet<Art2> Art2s { get; set; }

    public virtual DbSet<ArtAcier> ArtAciers { get; set; }

    public virtual DbSet<ArtFamille> ArtFamilles { get; set; }

    public virtual DbSet<ArtFamille1> ArtFamilles1 { get; set; }

    public virtual DbSet<ArtSsFamille> ArtSsFamilles { get; set; }

    public virtual DbSet<Artdemarageprix> Artdemarageprixes { get; set; }

    public virtual DbSet<Article> Articles { get; set; }

    public virtual DbSet<Article17012018> Article17012018s { get; set; }

    public virtual DbSet<Article26042020> Article26042020s { get; set; }

    public virtual DbSet<Article3112> Article3112s { get; set; }

    public virtual DbSet<ArticleCharge> ArticleCharges { get; set; }

    public virtual DbSet<ArticleControlDetail> ArticleControlDetails { get; set; }

    public virtual DbSet<ArticleCriter> ArticleCriters { get; set; }

    public virtual DbSet<ArticleDocBce> ArticleDocBces { get; set; }

    public virtual DbSet<ArticleDocumentBce> ArticleDocumentBces { get; set; }

    public virtual DbSet<ArticleFr> ArticleFrs { get; set; }

    public virtual DbSet<ArticleHbc1> ArticleHbc1s { get; set; }

    public virtual DbSet<ArticleHistorique> ArticleHistoriques { get; set; }

    public virtual DbSet<ArticleImDesc> ArticleImDescs { get; set; }

    public virtual DbSet<ArticleInsertion08062023> ArticleInsertion08062023s { get; set; }

    public virtual DbSet<ArticleJob> ArticleJobs { get; set; }

    public virtual DbSet<ArticleNv2023> ArticleNv2023s { get; set; }

    public virtual DbSet<ArticlePmpinitial> ArticlePmpinitials { get; set; }

    public virtual DbSet<ArticleRemiseTaxe> ArticleRemiseTaxes { get; set; }

    public virtual DbSet<ArticleSelection> ArticleSelections { get; set; }

    public virtual DbSet<ArticleSifcol> ArticleSifcols { get; set; }

    public virtual DbSet<ArticleSite> ArticleSites { get; set; }

    public virtual DbSet<ArticleSource> ArticleSources { get; set; }

    public virtual DbSet<ArticleSourceBoumhal> ArticleSourceBoumhals { get; set; }

    public virtual DbSet<ArticleSourceCentral> ArticleSourceCentrals { get; set; }

    public virtual DbSet<ArticleSourceReserv> ArticleSourceReservs { get; set; }

    public virtual DbSet<ArticleSourceSidiSalem> ArticleSourceSidiSalems { get; set; }

    public virtual DbSet<ArticleTvamodif> ArticleTvamodifs { get; set; }

    public virtual DbSet<ArticleTypePrix> ArticleTypePrixes { get; set; }

    public virtual DbSet<ArticleTypePrixHistorique> ArticleTypePrixHistoriques { get; set; }

    public virtual DbSet<Articleorigine> Articleorigines { get; set; }

    public virtual DbSet<ArtinvEdi> ArtinvEdis { get; set; }

    public virtual DbSet<ArtinvNeg> ArtinvNegs { get; set; }

    public virtual DbSet<Artracc> Artraccs { get; set; }

    public virtual DbSet<Aut> Auts { get; set; }

    public virtual DbSet<Bca> Bcas { get; set; }

    public virtual DbSet<Bcaencour> Bcaencours { get; set; }

    public virtual DbSet<Bcencour> Bcencours { get; set; }

    public virtual DbSet<BcencourDetail> BcencourDetails { get; set; }

    public virtual DbSet<BcnabeulEncour> BcnabeulEncours { get; set; }

    public virtual DbSet<BcsfaxEncour> BcsfaxEncours { get; set; }

    public virtual DbSet<BcsousseEncour> BcsousseEncours { get; set; }

    public virtual DbSet<BctunisEncour> BctunisEncours { get; set; }

    public virtual DbSet<Bcv> Bcvs { get; set; }

    public virtual DbSet<Beneficeclient> Beneficeclients { get; set; }

    public virtual DbSet<Biat> Biats { get; set; }

    public virtual DbSet<Bkma1814> Bkma1814s { get; set; }

    public virtual DbSet<BlfcidligneExt> BlfcidligneExts { get; set; }

    public virtual DbSet<BlnonFacturée> BlnonFacturées { get; set; }

    public virtual DbSet<Budget> Budgets { get; set; }

    public virtual DbSet<BudgetPlafond> BudgetPlafonds { get; set; }

    public virtual DbSet<CaRegion> CaRegions { get; set; }

    public virtual DbSet<CalculPmp> CalculPmps { get; set; }

    public virtual DbSet<Carep> Careps { get; set; }

    public virtual DbSet<Categorie> Categories { get; set; }

    public virtual DbSet<Charge> Charges { get; set; }

    public virtual DbSet<ClientActif> ClientActifs { get; set; }

    public virtual DbSet<ClientBc> ClientBcs { get; set; }

    public virtual DbSet<Clientmod> Clientmods { get; set; }

    public virtual DbSet<ClientsActif> ClientsActifs { get; set; }

    public virtual DbSet<ClientsActif1> ClientsActifs1 { get; set; }

    public virtual DbSet<CodeMonnaie> CodeMonnaies { get; set; }

    public virtual DbSet<Command> Commands { get; set; }

    public virtual DbSet<ComptaIntegrationAutomatique> ComptaIntegrationAutomatiques { get; set; }

    

    public virtual DbSet<ConditionPayement> ConditionPayements { get; set; }

    public virtual DbSet<ConfigSociete> ConfigSocietes { get; set; }

    public virtual DbSet<ContactsAut> ContactsAuts { get; set; }

    public virtual DbSet<ContactsC> ContactsCs { get; set; }

    public virtual DbSet<ContactsF> ContactsFs { get; set; }

    public virtual DbSet<ConventionClient> ConventionClients { get; set; }

    public virtual DbSet<CritereDestSecteur> CritereDestSecteurs { get; set; }

    public virtual DbSet<Crmaction> Crmactions { get; set; }

    public virtual DbSet<Crmaction28072022Bkt22022> Crmaction28072022Bkt22022s { get; set; }

    public virtual DbSet<CrmactionLtc1101> CrmactionLtc1101s { get; set; }

    public virtual DbSet<CrmactionRapport> CrmactionRapports { get; set; }

    public virtual DbSet<Crmcampagne> Crmcampagnes { get; set; }

    public virtual DbSet<CrmcheckArbo> CrmcheckArbos { get; set; }

    public virtual DbSet<CrmcheckArbo05102020BkKoul> CrmcheckArbo05102020BkKouls { get; set; }

    public virtual DbSet<CrmcheckArboRapport> CrmcheckArboRapports { get; set; }

    public virtual DbSet<Crmliste> Crmlistes { get; set; }

    public virtual DbSet<CrmparamListing> CrmparamListings { get; set; }

    public virtual DbSet<Crmview> Crmviews { get; set; }

    public virtual DbSet<CumulDesAchatsSifcol> CumulDesAchatsSifcols { get; set; }

    public virtual DbSet<DecEmpA1> DecEmpA1s { get; set; }

    public virtual DbSet<DecEmpAnn12022> DecEmpAnn12022s { get; set; }

    public virtual DbSet<DecTrim1> DecTrim1s { get; set; }

    public virtual DbSet<Destination> Destinations { get; set; }

    public virtual DbSet<DetailBlencour> DetailBlencours { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<DocumentBonCommande> DocumentBonCommandes { get; set; }

    public virtual DbSet<DocumentBonCommande1> DocumentBonCommande1s { get; set; }

    public virtual DbSet<DocumentBonCommandeHistorique> DocumentBonCommandeHistoriques { get; set; }

    public virtual DbSet<DocumentBonCommandeHistorique2021> DocumentBonCommandeHistorique2021s { get; set; }

    public virtual DbSet<DocumentBonCommandeHistorique2022> DocumentBonCommandeHistorique2022s { get; set; }

    public virtual DbSet<DocumentBonCommandeTempDelete> DocumentBonCommandeTempDeletes { get; set; }

    public virtual DbSet<DocumentBonDeCommandeTemp> DocumentBonDeCommandeTemps { get; set; }

    public virtual DbSet<DocumentControl> DocumentControls { get; set; }

    public virtual DbSet<DocumentControlDetail> DocumentControlDetails { get; set; }

    public virtual DbSet<DocumentCritere> DocumentCriteres { get; set; }

    public virtual DbSet<DocumentDc> DocumentDcs { get; set; }

    public virtual DbSet<DocumentDetailCommande> DocumentDetailCommandes { get; set; }

    public virtual DbSet<DocumentDetailCommandeHistorique> DocumentDetailCommandeHistoriques { get; set; }

    public virtual DbSet<DocumentDetailCommandetemp> DocumentDetailCommandetemps { get; set; }

    public virtual DbSet<DocumentDetailMontant> DocumentDetailMontants { get; set; }

    public virtual DbSet<DocumentOm> DocumentOms { get; set; }

    public virtual DbSet<DocumentdetailCommandeHistorique2022> DocumentdetailCommandeHistorique2022s { get; set; }

    public virtual DbSet<Dso> Dsos { get; set; }

    public virtual DbSet<Dsoachat> Dsoachats { get; set; }

    public virtual DbSet<EcartTransfert> EcartTransferts { get; set; }

    public virtual DbSet<Edition> Editions { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EnCoursLcaAe3> EnCoursLcaAe3s { get; set; }

    public virtual DbSet<EncValideCarnet> EncValideCarnets { get; set; }

    public virtual DbSet<Encaissement> Encaissements { get; set; }

    public virtual DbSet<EncaissementDecaissement> EncaissementDecaissements { get; set; }

    public virtual DbSet<EncaissementDecaissement1> EncaissementDecaissement1s { get; set; }

    public virtual DbSet<EncaissementDecaissement29112020ModeregNullBk> EncaissementDecaissement29112020ModeregNullBks { get; set; }

    public virtual DbSet<EncaissementDecaissement4111001179> EncaissementDecaissement4111001179s { get; set; }

    public virtual DbSet<EncaissementDecaissementBk04022021> EncaissementDecaissementBk04022021s { get; set; }

    public virtual DbSet<EncaissementDecaissementHistorique> EncaissementDecaissementHistoriques { get; set; }

    public virtual DbSet<EncaissementDecaissementHistorique2021> EncaissementDecaissementHistorique2021s { get; set; }

    public virtual DbSet<EncaissementDecaissementHistorique2022> EncaissementDecaissementHistorique2022s { get; set; }

    public virtual DbSet<EncaissementDecaissementHistoriqueAnve> EncaissementDecaissementHistoriqueAnves { get; set; }

    public virtual DbSet<EncaissementPerte> EncaissementPertes { get; set; }

    public virtual DbSet<EncaissementdecaissementAnnulerBk11122020> EncaissementdecaissementAnnulerBk11122020s { get; set; }

    public virtual DbSet<Encdecpetroga> Encdecpetrogas { get; set; }

    public virtual DbSet<Encdecpetrogasgan> Encdecpetrogasgans { get; set; }

    public virtual DbSet<EncoursClt> EncoursClts { get; set; }

    public virtual DbSet<EncoursCltBlockage> EncoursCltBlockages { get; set; }

    public virtual DbSet<EncoursSfax> EncoursSfaxes { get; set; }

    public virtual DbSet<EtatCaparClientFamilleArticle> EtatCaparClientFamilleArticles { get; set; }

    public virtual DbSet<EtatDesFacturesExoTva> EtatDesFacturesExoTvas { get; set; }

    public virtual DbSet<EtatDesFacturesExoTvaOld> EtatDesFacturesExoTvaOlds { get; set; }

    public virtual DbSet<EtatInv> EtatInvs { get; set; }

    public virtual DbSet<EtatListeImpayeLtk> EtatListeImpayeLtks { get; set; }

    public virtual DbSet<EtatSoldeClient> EtatSoldeClients { get; set; }

    public virtual DbSet<EtatSoldeClientBlFc> EtatSoldeClientBlFcs { get; set; }

    public virtual DbSet<EtatSoldeClientBlaFca> EtatSoldeClientBlaFcas { get; set; }

    public virtual DbSet<EtatSoldeClientFca> EtatSoldeClientFcas { get; set; }

    public virtual DbSet<EtatSoldeClientGroupNumCarnet> EtatSoldeClientGroupNumCarnets { get; set; }

    public virtual DbSet<EtatSoldeDetailMoi> EtatSoldeDetailMois { get; set; }

    public virtual DbSet<EtatSoldeDetailMoisAnc> EtatSoldeDetailMoisAncs { get; set; }

    public virtual DbSet<EtatSoldeFournisseur> EtatSoldeFournisseurs { get; set; }

    public virtual DbSet<EtatSoldeFr> EtatSoldeFrs { get; set; }

    public virtual DbSet<EtatSoldeFrsGroupNumCarnet> EtatSoldeFrsGroupNumCarnets { get; set; }

    public virtual DbSet<EtatStockDepotFamille> EtatStockDepotFamilles { get; set; }

    public virtual DbSet<Expro> Expros { get; set; }

    public virtual DbSet<Exprodetail> Exprodetails { get; set; }

    public virtual DbSet<Factnonreg> Factnonregs { get; set; }

    public virtual DbSet<FactureNonRparFr> FactureNonRparFrs { get; set; }

    public virtual DbSet<FactureVNr> FactureVNrs { get; set; }

    public virtual DbSet<Fboumhal> Fboumhals { get; set; }

    public virtual DbSet<Fcentral> Fcentrals { get; set; }

    public virtual DbSet<Feuil1> Feuil1s { get; set; }

    public virtual DbSet<Feuil11> Feuil1s1 { get; set; }

    public virtual DbSet<Feuil111> Feuil111s { get; set; }

    public virtual DbSet<Feuil3> Feuil3s { get; set; }

    public virtual DbSet<Fhbc1> Fhbc1s { get; set; }

    public virtual DbSet<FileArticle> FileArticles { get; set; }

    public virtual DbSet<FileCrmaction> FileCrmactions { get; set; }

    public virtual DbSet<FileCrmactionRapport> FileCrmactionRapports { get; set; }

    public virtual DbSet<FileCrmcampagne> FileCrmcampagnes { get; set; }

    public virtual DbSet<FileDoc> FileDocs { get; set; }

    public virtual DbSet<FileGrh> FileGrhs { get; set; }

    public virtual DbSet<FileTier> FileTiers { get; set; }

    public virtual DbSet<Form> Forms { get; set; }

    public virtual DbSet<Gain3005> Gain3005s { get; set; }

    public virtual DbSet<Grh> Grhs { get; set; }

    public virtual DbSet<Groupement> Groupements { get; set; }

    public virtual DbSet<GroupementDetail> GroupementDetails { get; set; }

    public virtual DbSet<HistoriqueCloture> HistoriqueClotures { get; set; }

    public virtual DbSet<HistoriqueDoc> HistoriqueDocs { get; set; }

    public virtual DbSet<HistoriqueDoc2021> HistoriqueDoc2021s { get; set; }

    public virtual DbSet<HistoriqueDoc2022> HistoriqueDoc2022s { get; set; }

    public virtual DbSet<HistoriqueDocCrm> HistoriqueDocCrms { get; set; }

    public virtual DbSet<HistoriqueDocGrh> HistoriqueDocGrhs { get; set; }

    public virtual DbSet<HistoriqueFondCaisse> HistoriqueFondCaisses { get; set; }

    public virtual DbSet<HistoriqueModifTxMargeDevi> HistoriqueModifTxMargeDevis { get; set; }

    public virtual DbSet<Indicateur> Indicateurs { get; set; }

    public virtual DbSet<IndicateurHistorique> IndicateurHistoriques { get; set; }

    public virtual DbSet<IndicateurPalier> IndicateurPaliers { get; set; }

    public virtual DbSet<IndicateurPalier1> IndicateurPalier1s { get; set; }

    public virtual DbSet<IndicateurPalierTb> IndicateurPalierTbs { get; set; }

    public virtual DbSet<Invcorrect> Invcorrects { get; set; }

    public virtual DbSet<Invcorrect0101> Invcorrect0101s { get; set; }

    public virtual DbSet<Inventaire> Inventaires { get; set; }

    public virtual DbSet<InventaireDetail> InventaireDetails { get; set; }

    public virtual DbSet<InventaireDetailcorrection241> InventaireDetailcorrection241s { get; set; }

    public virtual DbSet<Invtunis3112> Invtunis3112s { get; set; }

    public virtual DbSet<ListClt2020> ListClt2020s { get; set; }

    public virtual DbSet<ListeArticleCommander> ListeArticleCommanders { get; set; }

    public virtual DbSet<ListeBlnonFactureeBoumhal> ListeBlnonFactureeBoumhals { get; set; }

    public virtual DbSet<ListeBlnonFactureeSidiSalem> ListeBlnonFactureeSidiSalems { get; set; }

    public virtual DbSet<ListeDesCheLib> ListeDesCheLibs { get; set; }

    public virtual DbSet<ListeDesEffLib> ListeDesEffLibs { get; set; }

    public virtual DbSet<ListeDesFacturesNonRéglèe> ListeDesFacturesNonRéglèes { get; set; }

    public virtual DbSet<ListeDesVirement> ListeDesVirements { get; set; }

    public virtual DbSet<ListeFactureReglée> ListeFactureReglées { get; set; }

    public virtual DbSet<ListeImpaye> ListeImpayes { get; set; }

    public virtual DbSet<ListedesArticlesCommanderAvecLesEn> ListedesArticlesCommanderAvecLesEns { get; set; }

    public virtual DbSet<Mabk1814> Mabk1814s { get; set; }

    public virtual DbSet<Melange> Melanges { get; set; }

    public virtual DbSet<ModelePrix> ModelePrixes { get; set; }

    public virtual DbSet<MouvementArticle> MouvementArticles { get; set; }

    public virtual DbSet<MouvementClient> MouvementClients { get; set; }

    public virtual DbSet<MvtFidelite> MvtFidelites { get; set; }

    public virtual DbSet<MvtLot> MvtLots { get; set; }

    public virtual DbSet<Nosbanque> Nosbanques { get; set; }

    public virtual DbSet<Nvclt> Nvclts { get; set; }

    public virtual DbSet<ObjectifPlafond> ObjectifPlafonds { get; set; }

    public virtual DbSet<ObjectifPlafondDetail> ObjectifPlafondDetails { get; set; }

    public virtual DbSet<ObjectifRep> ObjectifReps { get; set; }

    public virtual DbSet<Om> Oms { get; set; }

    public virtual DbSet<Organigramme> Organigrammes { get; set; }

    public virtual DbSet<Parametre> Parametres { get; set; }

    public virtual DbSet<ParametreEdition> ParametreEditions { get; set; }

    public virtual DbSet<ParametreSfc> ParametreSfcs { get; set; }

    public virtual DbSet<Planning> Plannings { get; set; }

    public virtual DbSet<Planning1> Planning1s { get; set; }

    public virtual DbSet<Pmp3112> Pmp3112s { get; set; }

    public virtual DbSet<PrdNomenclature> PrdNomenclatures { get; set; }

    public virtual DbSet<PvcPehd> PvcPehds { get; set; }

    public virtual DbSet<PvcPr> PvcPrs { get; set; }

    public virtual DbSet<RaccordASouder> RaccordASouders { get; set; }

    public virtual DbSet<RapportActivite> RapportActivites { get; set; }

    public virtual DbSet<RefD> RefDs { get; set; }

    public virtual DbSet<RelationDocument> RelationDocuments { get; set; }

    public virtual DbSet<ReleveImpayeTuni> ReleveImpayeTunis { get; set; }

    public virtual DbSet<RessourceMatCritere> RessourceMatCriteres { get; set; }

    public virtual DbSet<RessourcesMateriel> RessourcesMateriels { get; set; }

    public virtual DbSet<Rqeimed> Rqeimeds { get; set; }

    public virtual DbSet<Rqetarak> Rqetaraks { get; set; }

    public virtual DbSet<Secteur> Secteurs { get; set; }

    public virtual DbSet<ServicePanne> ServicePannes { get; set; }

    public virtual DbSet<ServiceReception> ServiceReceptions { get; set; }

    public virtual DbSet<ServiceReceptionDetailPanne> ServiceReceptionDetailPannes { get; set; }

    public virtual DbSet<Sheet1> Sheet1s { get; set; }

    public virtual DbSet<SoldeConge01012023> SoldeConge01012023s { get; set; }

    public virtual DbSet<SoldeInit> SoldeInits { get; set; }

    public virtual DbSet<SoldeInitialBrima> SoldeInitialBrimas { get; set; }

    public virtual DbSet<Somme1> Somme1s { get; set; }

    public virtual DbSet<SommeArticleBc> SommeArticleBcs { get; set; }

    public virtual DbSet<SommeArticleBl> SommeArticleBls { get; set; }

    public virtual DbSet<SousCategorie> SousCategories { get; set; }

    public virtual DbSet<SousFamille> SousFamilles { get; set; }

    public virtual DbSet<SyntheseDesPrix> SyntheseDesPrixes { get; set; }

    public virtual DbSet<SyntheseDesPrix2222> SyntheseDesPrix2222s { get; set; }

    public virtual DbSet<SynthéseDesPrixNew> SynthéseDesPrixNews { get; set; }

    public virtual DbSet<SynthéseDesPrixNewOld> SynthéseDesPrixNewOlds { get; set; }

    public virtual DbSet<SynthéseDesPrixOld> SynthéseDesPrixOlds { get; set; }

    public virtual DbSet<TVirementTemp> TVirementTemps { get; set; }

    public virtual DbSet<Table1> Table1s { get; set; }

    public virtual DbSet<TableTier> TableTiers { get; set; }

    public virtual DbSet<TableauCongeAnnee> TableauCongeAnnees { get; set; }

    public virtual DbSet<TauxTva> TauxTvas { get; set; }

    public virtual DbSet<TbcalculMarge> TbcalculMarges { get; set; }

    public virtual DbSet<Tcv> Tcvs { get; set; }

    public virtual DbSet<Tier> Tiers { get; set; }

    public virtual DbSet<Tiers30082018> Tiers30082018s { get; set; }

    public virtual DbSet<TiersCarteVisite> TiersCarteVisites { get; set; }

    public virtual DbSet<TiersCarteVisite23102021Err> TiersCarteVisite23102021Errs { get; set; }

    public virtual DbSet<TiersCarteVisiteGroup> TiersCarteVisiteGroups { get; set; }

    public virtual DbSet<TiersCarteVisiteNew> TiersCarteVisiteNews { get; set; }

    public virtual DbSet<TiersCarteVisiteNiveau> TiersCarteVisiteNiveaus { get; set; }

    public virtual DbSet<TiersCarteVisiteRt2610> TiersCarteVisiteRt2610s { get; set; }

    public virtual DbSet<TiersCritere> TiersCriteres { get; set; }

    public virtual DbSet<TiersCritereDetail> TiersCritereDetails { get; set; }

    public virtual DbSet<TiersDecision> TiersDecisions { get; set; }

    public virtual DbSet<TiersHistorique> TiersHistoriques { get; set; }

    public virtual DbSet<TiersPlusVente> TiersPlusVentes { get; set; }

    public virtual DbSet<Tige> Tiges { get; set; }

    public virtual DbSet<Timber> Timbers { get; set; }

    public virtual DbSet<TimeOrder> TimeOrders { get; set; }

    public virtual DbSet<TopRep> TopReps { get; set; }

    public virtual DbSet<TotVenteMoi> TotVenteMois { get; set; }

    public virtual DbSet<Tresorerieprevisionnelle> Tresorerieprevisionnelles { get; set; }

    public virtual DbSet<TubeInox> TubeInoxes { get; set; }

    public virtual DbSet<TypeContact> TypeContacts { get; set; }

    public virtual DbSet<TypeTier> TypeTiers { get; set; }

    public virtual DbSet<TypeUtilisateur> TypeUtilisateurs { get; set; }

    public virtual DbSet<UtilisateurAlert> UtilisateurAlerts { get; set; }

    public virtual DbSet<UtilisateurApplication> UtilisateurApplications { get; set; }

    public virtual DbSet<UtilisateurDepot> UtilisateurDepots { get; set; }

    public virtual DbSet<UtilisateurEdition> UtilisateurEditions { get; set; }

    public virtual DbSet<UtilisateurImg> UtilisateurImgs { get; set; }

    public virtual DbSet<UtilisateurMenu> UtilisateurMenus { get; set; }

    public virtual DbSet<ValeurCriter> ValeurCriters { get; set; }

    public virtual DbSet<ValeurTaxe> ValeurTaxes { get; set; }

    public virtual DbSet<VencoursClient> VencoursClients { get; set; }

    public virtual DbSet<VencoursClientBl> VencoursClientBls { get; set; }

    public virtual DbSet<VencoursClientBr> VencoursClientBrs { get; set; }

    public virtual DbSet<VencoursFr> VencoursFrs { get; set; }

    public virtual DbSet<VerifversementBanque> VerifversementBanques { get; set; }

    public virtual DbSet<VersementEntet> VersementEntets { get; set; }

    public virtual DbSet<VersementLigne> VersementLignes { get; set; }

    public virtual DbSet<VersementLigneHistorique> VersementLigneHistoriques { get; set; }

    public virtual DbSet<ViewAffectationFacture> ViewAffectationFactures { get; set; }

    public virtual DbSet<ViewBordTest> ViewBordTests { get; set; }

    public virtual DbSet<ViewCharesSociale> ViewCharesSociales { get; set; }

    public virtual DbSet<ViewCoutsFix> ViewCoutsFixes { get; set; }

    public virtual DbSet<ViewCra> ViewCras { get; set; }

    public virtual DbSet<ViewCri> ViewCris { get; set; }

    public virtual DbSet<ViewEncourStkBoumhal> ViewEncourStkBoumhals { get; set; }

    public virtual DbSet<ViewEncourStkBoumhalOld> ViewEncourStkBoumhalOlds { get; set; }

    public virtual DbSet<ViewEncourStkHbc> ViewEncourStkHbcs { get; set; }

    public virtual DbSet<ViewEncourStkHbcold> ViewEncourStkHbcolds { get; set; }

    public virtual DbSet<ViewEncoursStkBca> ViewEncoursStkBcas { get; set; }

    public virtual DbSet<ViewEncoursStkCentrale> ViewEncoursStkCentrales { get; set; }

    public virtual DbSet<ViewEncoursStkCentraleOld> ViewEncoursStkCentraleOlds { get; set; }

    public virtual DbSet<ViewEncoursStkLca> ViewEncoursStkLcas { get; set; }

    public virtual DbSet<ViewEncoursStkLca1> ViewEncoursStkLca1s { get; set; }

    public virtual DbSet<ViewEncoursStkSidiSalem> ViewEncoursStkSidiSalems { get; set; }

    public virtual DbSet<ViewEncoursStkSidiSalemOld> ViewEncoursStkSidiSalemOlds { get; set; }

    public virtual DbSet<ViewEncoursTransfert> ViewEncoursTransferts { get; set; }

    public virtual DbSet<ViewEtatRecapAvoirComptum> ViewEtatRecapAvoirCompta { get; set; }

    public virtual DbSet<ViewEtatRecapVenteComptum> ViewEtatRecapVenteCompta { get; set; }

    public virtual DbSet<ViewFactureExo> ViewFactureExos { get; set; }

    public virtual DbSet<ViewFraisBancaire> ViewFraisBancaires { get; set; }

    public virtual DbSet<ViewImmobilisation> ViewImmobilisations { get; set; }

    public virtual DbSet<ViewInfoNivAe3detail> ViewInfoNivAe3details { get; set; }

    public virtual DbSet<ViewInfoNivAe3liste> ViewInfoNivAe3listes { get; set; }

    public virtual DbSet<ViewListeEncaissement> ViewListeEncaissements { get; set; }

    public virtual DbSet<ViewListeRecouvrementRegle> ViewListeRecouvrementRegles { get; set; }

    public virtual DbSet<ViewListing> ViewListings { get; set; }

    public virtual DbSet<ViewOrganigramme> ViewOrganigrammes { get; set; }

    public virtual DbSet<ViewOrganigrammeDum> ViewOrganigrammeDa { get; set; }

    public virtual DbSet<ViewOrganigrammeOm> ViewOrganigrammeOms { get; set; }

    public virtual DbSet<ViewPeriodeFullyear> ViewPeriodeFullyears { get; set; }

    public virtual DbSet<ViewPositionBq> ViewPositionBqs { get; set; }

    public virtual DbSet<ViewQtcommander> ViewQtcommanders { get; set; }

    public virtual DbSet<ViewRegImp> ViewRegImps { get; set; }

    public virtual DbSet<ViewReleveGargouri> ViewReleveGargouris { get; set; }

    public virtual DbSet<ViewReleveRahma> ViewReleveRahmas { get; set; }

    public virtual DbSet<ViewRepartitionDesFrai> ViewRepartitionDesFrais { get; set; }

    public virtual DbSet<ViewStkSuivi> ViewStkSuivis { get; set; }

    public virtual DbSet<ViewValidation> ViewValidations { get; set; }

    public virtual DbSet<ViewValidationOrganigramme> ViewValidationOrganigrammes { get; set; }

    public virtual DbSet<ViewValidationOrganigrammeDum> ViewValidationOrganigrammeDa { get; set; }

    public virtual DbSet<ViewValidationOrganigrammeOm> ViewValidationOrganigrammeOms { get; set; }

    public virtual DbSet<VrelanceClient> VrelanceClients { get; set; }

    public virtual DbSet<VrelanceClient1> VrelanceClient1s { get; set; }

    public virtual DbSet<VrelanceClientBft> VrelanceClientBfts { get; set; }

    public virtual DbSet<VsoldeClient> VsoldeClients { get; set; }

    public virtual DbSet<VvisiteClient> VvisiteClients { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-G1FBNV1; Database=EDIDynamiqueHBC; Trusted_Connection=True; \n Trust Server Certificate=yes", x => x.UseNetTopologySuite());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Arabic_CI_AI");

        modelBuilder.Entity<Agroimp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("agroimp");

            entity.Property(e => e.DocAcompte).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocCloture).HasColumnType("smalldatetime");
            entity.Property(e => e.DocCommentaire)
                .UseCollation("French_CI_AI")
                .HasColumnType("ntext");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDateEcheance).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDest)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocDevise)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocEtatBp).HasColumnName("DocEtatBP");
            entity.Property(e => e.DocEtatBp1).HasColumnName("DocEtatBP1");
            entity.Property(e => e.DocHliv).HasColumnName("DocHLiv");
            entity.Property(e => e.DocLancement).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMatricule)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocMntLettre)
                .HasMaxLength(500)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocMontant).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocNetaPayer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocNptiers)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("DocNPTiers");
            entity.Property(e => e.DocNumDoc)
                .HasMaxLength(15)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocRefCaisse)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocRefExt).HasMaxLength(250);
            entity.Property(e => e.DocRepresentant).HasMaxLength(50);
            entity.Property(e => e.DocReste).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalRemise).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocTotalTva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalTVA");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocValFodec).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocValRem).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Ematricule)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MargeMinDoc).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Marque)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Modele).HasMaxLength(50);
            entity.Property(e => e.RefDev)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefSouDest)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefSouDest1)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Rmmatricule)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("RMMatricule");
            entity.Property(e => e.UniqueId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UniqueID");
        });

        modelBuilder.Entity<Alert>(entity =>
        {
            entity.HasKey(e => e.Alert1);

            entity.ToTable("Alert");

            entity.Property(e => e.Alert1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("Alert");
            entity.Property(e => e.AlertText)
                .HasMaxLength(250)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Bande).HasMaxLength(50);
            entity.Property(e => e.IdAlert).ValueGeneratedOnAdd();
            entity.Property(e => e.Nchamp)
                .HasMaxLength(250)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Ntable)
                .UseCollation("French_CI_AI")
                .HasColumnType("text")
                .HasColumnName("NTable");
            entity.Property(e => e.Val)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("val");
        });

        modelBuilder.Entity<AlertB>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AlertB");

            entity.Property(e => e.B).HasMaxLength(255);
            entity.Property(e => e.C).HasMaxLength(255);
            entity.Property(e => e.E).HasMaxLength(255);
            entity.Property(e => e.F).HasMaxLength(255);
        });

        modelBuilder.Entity<Art2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Art2", tb =>
                {
                    tb.HasTrigger("AFTERDeleteART");
                    tb.HasTrigger("ForINSERTArt");
                });

            entity.Property(e => e.Abloque).HasColumnName("ABloque");
            entity.Property(e => e.Acategorie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ACategorie");
            entity.Property(e => e.ActrlSt).HasColumnName("ACtrlST");
            entity.Property(e => e.AdateDebprom).HasColumnType("smalldatetime");
            entity.Property(e => e.AdateFinprom).HasColumnType("smalldatetime");
            entity.Property(e => e.Adesignation)
                .HasMaxLength(100)
                .HasColumnName("ADesignation");
            entity.Property(e => e.Afamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AFamille");
            entity.Property(e => e.Afodec).HasColumnName("AFodec");
            entity.Property(e => e.Amarge)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMarge");
            entity.Property(e => e.AmargeProm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMargeProm");
            entity.Property(e => e.AnbparColisage).HasColumnName("ANbparColisage");
            entity.Property(e => e.AnumRef).HasColumnName("ANumRef");
            entity.Property(e => e.Apnetht)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APNETHT");
            entity.Property(e => e.AprevientHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APRevientHT");
            entity.Property(e => e.AprevientTtc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APRevientTTC");
            entity.Property(e => e.AprixVntprom).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ApromStand).HasColumnName("APromStand");
            entity.Property(e => e.ApuachatHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APUAchatHT");
            entity.Property(e => e.ApuventeHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APUVenteHT");
            entity.Property(e => e.Apvttc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APVTTC");
            entity.Property(e => e.Apvttc1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("APVTTC1");
            entity.Property(e => e.AqteMinVente).HasColumnName("AQteMinVente");
            entity.Property(e => e.AqteMinprom).HasColumnName("AQteMinprom");
            entity.Property(e => e.AqteStock).HasColumnName("AQteStock");
            entity.Property(e => e.Aqteprom).HasColumnName("AQteprom");
            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ARef");
            entity.Property(e => e.Aremise).HasColumnName("ARemise");
            entity.Property(e => e.Aremiseprom).HasColumnName("ARemiseprom");
            entity.Property(e => e.Art)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ART");
            entity.Property(e => e.ArtNd).HasColumnName("ArtND");
            entity.Property(e => e.ArtParent)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ascategorie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ASCategorie");
            entity.Property(e => e.Asfamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ASFamille");
            entity.Property(e => e.AstockMin).HasColumnName("AStockMin");
            entity.Property(e => e.Astockable).HasColumnName("AStockable");
            entity.Property(e => e.AtauxTvav).HasColumnName("ATaux_TVAV");
            entity.Property(e => e.AuniteAch)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AUniteAch");
            entity.Property(e => e.AuniteVnt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AUniteVnt");
            entity.Property(e => e.AvalFodec)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AValFodec");
            entity.Property(e => e.AvalRemise)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AValRemise");
            entity.Property(e => e.Avalorisation).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BaseCalcul).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Button)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CodeBarreL)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CodeBarreParent)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CodeComptable)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.FrsPrincipal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdTp).HasColumnName("IdTP");
            entity.Property(e => e.NbrePf).HasColumnName("NbrePF");
            entity.Property(e => e.NomImage)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.Rpuaht).HasColumnName("RPUAHT");
            entity.Property(e => e.Tvamarge).HasColumnName("TVAMarge");
        });

        modelBuilder.Entity<ArtAcier>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ArtACIER");

            entity.Property(e => e.Aref)
                .HasMaxLength(255)
                .HasColumnName("ARef");
            entity.Property(e => e.AuniteVnt)
                .HasMaxLength(255)
                .HasColumnName("AUniteVnt");
            entity.Property(e => e.Categorie)
                .HasMaxLength(255)
                .HasColumnName("CATEGORIE");
            entity.Property(e => e.Des)
                .HasMaxLength(255)
                .HasColumnName("des");
            entity.Property(e => e.Famille).HasMaxLength(255);
            entity.Property(e => e.SFamille)
                .HasMaxLength(255)
                .HasColumnName("sFAMILLE ");
        });

        modelBuilder.Entity<ArtFamille>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Art_Famille");

            entity.Property(e => e.AbrevGraphique).HasColumnName("abrev_graphique");
            entity.Property(e => e.Achat).HasColumnName("achat");
            entity.Property(e => e.CodeQte).HasColumnName("CODE_QTE");
            entity.Property(e => e.CodeTarif).HasColumnName("CODE_TARIF");
            entity.Property(e => e.Codefacturation).HasColumnName("codefacturation");
            entity.Property(e => e.CodeqteFixe).HasColumnName("codeqte_fixe");
            entity.Property(e => e.CoefStkMax).HasColumnName("coef_stk_max");
            entity.Property(e => e.CoefStkSec).HasColumnName("coef_stk_sec");
            entity.Property(e => e.CommandeFerme).HasColumnName("commande_ferme");
            entity.Property(e => e.Dc).HasColumnName("DC");
            entity.Property(e => e.Delaiappro).HasColumnName("delaiappro");
            entity.Property(e => e.Dim1).HasColumnName("dim1");
            entity.Property(e => e.Dim1n).HasColumnName("dim1n");
            entity.Property(e => e.Dim2).HasColumnName("dim2");
            entity.Property(e => e.Dim3).HasColumnName("dim3");
            entity.Property(e => e.FormuleQte).HasColumnName("formule_qte");
            entity.Property(e => e.FvnD1).HasColumnName("FVN_D1");
            entity.Property(e => e.FvnD2).HasColumnName("FVN_D2");
            entity.Property(e => e.FvnD3).HasColumnName("FVN_D3");
            entity.Property(e => e.Groupe).HasColumnName("groupe");
            entity.Property(e => e.Iddepartement).HasColumnName("iddepartement");
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.Impdim1).HasColumnName("impdim1");
            entity.Property(e => e.Impdim2).HasColumnName("impdim2");
            entity.Property(e => e.Impdim3).HasColumnName("impdim3");
            entity.Property(e => e.Impnbrpiece).HasColumnName("impnbrpiece");
            entity.Property(e => e.Impqtecolis).HasColumnName("impqtecolis");
            entity.Property(e => e.Majoration).HasColumnName("MAJORATION");
            entity.Property(e => e.Maxtxrem).HasColumnName("maxtxrem");
            entity.Property(e => e.Modesaisie).HasColumnName("modesaisie");
            entity.Property(e => e.ModifAchat).HasColumnName("modif_achat");
            entity.Property(e => e.ModifCmdeFerme).HasColumnName("modif_cmde_ferme");
            entity.Property(e => e.ModifCodeTarif).HasColumnName("modif_code_tarif");
            entity.Property(e => e.ModifCodeimpcpte).HasColumnName("modif_codeimpcpte");
            entity.Property(e => e.ModifCodeprix).HasColumnName("modif_codeprix");
            entity.Property(e => e.ModifCodeqte).HasColumnName("modif_codeqte");
            entity.Property(e => e.ModifCodeqteFixe).HasColumnName("modif_codeqte_fixe");
            entity.Property(e => e.ModifDc).HasColumnName("modif_dc");
            entity.Property(e => e.ModifDelaiappro).HasColumnName("modif_delaiappro");
            entity.Property(e => e.ModifDelailiv).HasColumnName("modif_delailiv");
            entity.Property(e => e.ModifDim1).HasColumnName("modif_dim1");
            entity.Property(e => e.ModifDim2).HasColumnName("modif_dim2");
            entity.Property(e => e.ModifDim3).HasColumnName("modif_dim3");
            entity.Property(e => e.ModifFormuleQte).HasColumnName("modif_formule_qte");
            entity.Property(e => e.ModifFvn1).HasColumnName("modif_fvn1");
            entity.Property(e => e.ModifFvn2).HasColumnName("modif_fvn2");
            entity.Property(e => e.ModifFvn3).HasColumnName("modif_fvn3");
            entity.Property(e => e.ModifFvnc).HasColumnName("modif_fvnc");
            entity.Property(e => e.ModifGroupe).HasColumnName("modif_groupe");
            entity.Property(e => e.ModifIddepartement).HasColumnName("modif_iddepartement");
            entity.Property(e => e.ModifIddimension).HasColumnName("modif_iddimension");
            entity.Property(e => e.ModifImage).HasColumnName("modif_image");
            entity.Property(e => e.ModifImpdim1).HasColumnName("modif_impdim1");
            entity.Property(e => e.ModifImpdim2).HasColumnName("modif_impdim2");
            entity.Property(e => e.ModifImpdim3).HasColumnName("modif_impdim3");
            entity.Property(e => e.ModifImpnbrpiece).HasColumnName("modif_impnbrpiece");
            entity.Property(e => e.ModifImpqtecolis).HasColumnName("modif_impqtecolis");
            entity.Property(e => e.ModifMajoration).HasColumnName("modif_majoration");
            entity.Property(e => e.ModifMaxtxrem).HasColumnName("modif_maxtxrem");
            entity.Property(e => e.ModifModesaisie).HasColumnName("modif_modesaisie");
            entity.Property(e => e.ModifNbpnull).HasColumnName("modif_nbpnull");
            entity.Property(e => e.ModifNbrjourvie).HasColumnName("modif_nbrjourvie");
            entity.Property(e => e.ModifNbrpieceMsu).HasColumnName("modif_nbrpiece_msu");
            entity.Property(e => e.ModifNiveau).HasColumnName("modif_niveau");
            entity.Property(e => e.ModifPerissable).HasColumnName("modif_perissable");
            entity.Property(e => e.ModifPrecisionQte).HasColumnName("modif_precision_qte");
            entity.Property(e => e.ModifProductionM).HasColumnName("modif_production_m");
            entity.Property(e => e.ModifQtec).HasColumnName("modif_qtec");
            entity.Property(e => e.ModifSaisieInt).HasColumnName("modif_saisie_int");
            entity.Property(e => e.ModifSaisiePrix).HasColumnName("modif_saisie_prix");
            entity.Property(e => e.ModifSaisieTxrem).HasColumnName("modif_saisie_txrem");
            entity.Property(e => e.ModifSaisieUni).HasColumnName("modif_saisie_uni");
            entity.Property(e => e.ModifSaisieprix1).HasColumnName("modif_saisieprix");
            entity.Property(e => e.ModifStkmaximum).HasColumnName("modif_stkmaximum");
            entity.Property(e => e.ModifStkminimun).HasColumnName("modif_stkminimun");
            entity.Property(e => e.ModifStksecurite).HasColumnName("modif_stksecurite");
            entity.Property(e => e.ModifStock).HasColumnName("modif_stock");
            entity.Property(e => e.ModifTarifDouanier).HasColumnName("modif_TarifDouanier");
            entity.Property(e => e.ModifTauxmajor).HasColumnName("modif_tauxmajor");
            entity.Property(e => e.ModifTaxeSup).HasColumnName("modif_taxe_sup");
            entity.Property(e => e.ModifTpf1).HasColumnName("modif_tpf1");
            entity.Property(e => e.ModifTpf2).HasColumnName("modif_tpf2");
            entity.Property(e => e.ModifTransport).HasColumnName("modif_transport");
            entity.Property(e => e.ModifTva).HasColumnName("modif_tva");
            entity.Property(e => e.ModifTxmarge).HasColumnName("modif_txmarge");
            entity.Property(e => e.ModifTxrem).HasColumnName("modif_txrem");
            entity.Property(e => e.ModifTypeQteappro).HasColumnName("modif_type_qteappro");
            entity.Property(e => e.ModifUnitePub).HasColumnName("modif_unite_pub");
            entity.Property(e => e.ModifUniteStatistique).HasColumnName("modif_unite_statistique");
            entity.Property(e => e.ModifUniteVte).HasColumnName("modif_unite_vte");
            entity.Property(e => e.ModifUniteappro).HasColumnName("modif_uniteappro");
            entity.Property(e => e.ModifUnitedelai).HasColumnName("modif_unitedelai");
            entity.Property(e => e.ModifUnitejourvie).HasColumnName("modif_unitejourvie");
            entity.Property(e => e.ModifUnitestock).HasColumnName("modif_unitestock");
            entity.Property(e => e.ModifVente).HasColumnName("modif_vente");
            entity.Property(e => e.Modifcodefacturation).HasColumnName("modifcodefacturation");
            entity.Property(e => e.Nbpqnull).HasColumnName("nbpqnull");
            entity.Property(e => e.NbrpieceMsu).HasColumnName("nbrpiece_msu");
            entity.Property(e => e.Niveau).HasColumnName("niveau");
            entity.Property(e => e.Ordre).HasColumnName("ordre");
            entity.Property(e => e.PrecisionQte).HasColumnName("precision_qte");
            entity.Property(e => e.ProductionM).HasColumnName("production_m");
            entity.Property(e => e.Reservation).HasColumnName("RESERVATION");
            entity.Property(e => e.SaisieInt).HasColumnName("SAISIE_INT");
            entity.Property(e => e.SaisiePrix).HasColumnName("SAISIE_PRIX");
            entity.Property(e => e.SaisieTxrem).HasColumnName("saisie_txrem");
            entity.Property(e => e.SaisieUni).HasColumnName("SAISIE_UNI");
            entity.Property(e => e.Saisieprix1).HasColumnName("saisieprix");
            entity.Property(e => e.Saisqtegpq).HasColumnName("saisqtegpq");
            entity.Property(e => e.TaxeSup).HasColumnName("TAXE_SUP");
            entity.Property(e => e.Tpf1).HasColumnName("TPF1");
            entity.Property(e => e.Tpf2).HasColumnName("TPF2");
            entity.Property(e => e.Transport).HasColumnName("TRANSPORT");
            entity.Property(e => e.Tva).HasColumnName("TVA");
            entity.Property(e => e.Txmarge).HasColumnName("txmarge");
            entity.Property(e => e.Txrem).HasColumnName("txrem");
            entity.Property(e => e.TypeQteappro).HasColumnName("type_qteappro");
            entity.Property(e => e.UniteAchar).HasColumnName("Unite_Achar");
            entity.Property(e => e.UnitePub).HasColumnName("UNITE_PUB");
            entity.Property(e => e.UniteStatistique).HasColumnName("unite_statistique");
            entity.Property(e => e.UniteVte).HasColumnName("UNITE_VTE");
            entity.Property(e => e.Uniteappro).HasColumnName("uniteappro");
            entity.Property(e => e.Unitejourvie).HasColumnName("unitejourvie");
            entity.Property(e => e.Vente).HasColumnName("vente");
        });

        modelBuilder.Entity<ArtFamille1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ArtFamille");

            entity.Property(e => e.Aref)
                .HasMaxLength(255)
                .HasColumnName("ARef");
            entity.Property(e => e.Catégorie)
                .HasMaxLength(255)
                .HasColumnName("catégorie ");
            entity.Property(e => e.Désignation).HasMaxLength(255);
            entity.Property(e => e.Famille)
                .HasMaxLength(255)
                .HasColumnName("Famille ");
            entity.Property(e => e.SousCatégorie)
                .HasMaxLength(255)
                .HasColumnName("sous catégorie ");
            entity.Property(e => e.SousFamilles)
                .HasMaxLength(255)
                .HasColumnName("sous familles ");
        });

        modelBuilder.Entity<ArtSsFamille>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Art_SsFamille");

            entity.Property(e => e.AbrevGraphique).HasColumnName("abrev_graphique");
            entity.Property(e => e.Achat).HasColumnName("achat");
            entity.Property(e => e.CodeQte).HasColumnName("CODE_QTE");
            entity.Property(e => e.CodeTarif).HasColumnName("CODE_TARIF");
            entity.Property(e => e.Codefacturation).HasColumnName("codefacturation");
            entity.Property(e => e.CodeqteFixe).HasColumnName("codeqte_fixe");
            entity.Property(e => e.CoefStkMax).HasColumnName("coef_stk_max");
            entity.Property(e => e.CoefStkSec).HasColumnName("coef_stk_sec");
            entity.Property(e => e.CommandeFerme).HasColumnName("commande_ferme");
            entity.Property(e => e.Dc).HasColumnName("DC");
            entity.Property(e => e.Delaiappro).HasColumnName("delaiappro");
            entity.Property(e => e.Dim1).HasColumnName("dim1");
            entity.Property(e => e.Dim1n).HasColumnName("dim1n");
            entity.Property(e => e.Dim2).HasColumnName("dim2");
            entity.Property(e => e.Dim3).HasColumnName("dim3");
            entity.Property(e => e.FormuleQte).HasColumnName("formule_qte");
            entity.Property(e => e.FvnD1).HasColumnName("FVN_D1");
            entity.Property(e => e.FvnD2).HasColumnName("FVN_D2");
            entity.Property(e => e.FvnD3).HasColumnName("FVN_D3");
            entity.Property(e => e.Groupe).HasColumnName("groupe");
            entity.Property(e => e.Iddepartement).HasColumnName("iddepartement");
            entity.Property(e => e.Identifiant).HasColumnName("identifiant");
            entity.Property(e => e.Image).HasColumnName("image");
            entity.Property(e => e.Impdim1).HasColumnName("impdim1");
            entity.Property(e => e.Impdim2).HasColumnName("impdim2");
            entity.Property(e => e.Impdim3).HasColumnName("impdim3");
            entity.Property(e => e.Impnbrpiece).HasColumnName("impnbrpiece");
            entity.Property(e => e.Impqtecolis).HasColumnName("impqtecolis");
            entity.Property(e => e.Majoration).HasColumnName("MAJORATION");
            entity.Property(e => e.Maxtxrem).HasColumnName("maxtxrem");
            entity.Property(e => e.Modesaisie).HasColumnName("modesaisie");
            entity.Property(e => e.ModifAchat).HasColumnName("modif_achat");
            entity.Property(e => e.ModifCmdeFerme).HasColumnName("modif_cmde_ferme");
            entity.Property(e => e.ModifCodeTarif).HasColumnName("modif_code_tarif");
            entity.Property(e => e.ModifCodeimpcpte).HasColumnName("modif_codeimpcpte");
            entity.Property(e => e.ModifCodeprix).HasColumnName("modif_codeprix");
            entity.Property(e => e.ModifCodeqte).HasColumnName("modif_codeqte");
            entity.Property(e => e.ModifCodeqteFixe).HasColumnName("modif_codeqte_fixe");
            entity.Property(e => e.ModifDc).HasColumnName("modif_dc");
            entity.Property(e => e.ModifDelaiappro).HasColumnName("modif_delaiappro");
            entity.Property(e => e.ModifDelailiv).HasColumnName("modif_delailiv");
            entity.Property(e => e.ModifDim1).HasColumnName("modif_dim1");
            entity.Property(e => e.ModifDim2).HasColumnName("modif_dim2");
            entity.Property(e => e.ModifDim3).HasColumnName("modif_dim3");
            entity.Property(e => e.ModifFormuleQte).HasColumnName("modif_formule_qte");
            entity.Property(e => e.ModifFvn1).HasColumnName("modif_fvn1");
            entity.Property(e => e.ModifFvn2).HasColumnName("modif_fvn2");
            entity.Property(e => e.ModifFvn3).HasColumnName("modif_fvn3");
            entity.Property(e => e.ModifFvnc).HasColumnName("modif_fvnc");
            entity.Property(e => e.ModifIddepartement).HasColumnName("modif_iddepartement");
            entity.Property(e => e.ModifIddimension).HasColumnName("modif_iddimension");
            entity.Property(e => e.ModifImpdim1).HasColumnName("modif_impdim1");
            entity.Property(e => e.ModifImpdim2).HasColumnName("modif_impdim2");
            entity.Property(e => e.ModifImpdim3).HasColumnName("modif_impdim3");
            entity.Property(e => e.ModifImpnbrpiece).HasColumnName("modif_impnbrpiece");
            entity.Property(e => e.ModifImpqtecolis).HasColumnName("modif_impqtecolis");
            entity.Property(e => e.ModifMajoration).HasColumnName("modif_majoration");
            entity.Property(e => e.ModifMaxtxrem).HasColumnName("modif_maxtxrem");
            entity.Property(e => e.ModifModesaisie).HasColumnName("modif_modesaisie");
            entity.Property(e => e.ModifNbpnull).HasColumnName("modif_nbpnull");
            entity.Property(e => e.ModifNbrjourvie).HasColumnName("modif_nbrjourvie");
            entity.Property(e => e.ModifNbrpieceMsu).HasColumnName("modif_nbrpiece_msu");
            entity.Property(e => e.ModifNiveau).HasColumnName("modif_niveau");
            entity.Property(e => e.ModifPerissable).HasColumnName("modif_perissable");
            entity.Property(e => e.ModifPrecisionQte).HasColumnName("modif_precision_qte");
            entity.Property(e => e.ModifProductionM).HasColumnName("modif_production_m");
            entity.Property(e => e.ModifQtec).HasColumnName("modif_qtec");
            entity.Property(e => e.ModifSaisieInt).HasColumnName("modif_saisie_int");
            entity.Property(e => e.ModifSaisiePrix).HasColumnName("modif_saisie_prix");
            entity.Property(e => e.ModifSaisieTxrem).HasColumnName("modif_saisie_txrem");
            entity.Property(e => e.ModifSaisieUni).HasColumnName("modif_saisie_uni");
            entity.Property(e => e.ModifSaisieprix1).HasColumnName("modif_saisieprix");
            entity.Property(e => e.ModifStkmaximum).HasColumnName("modif_stkmaximum");
            entity.Property(e => e.ModifStkminimun).HasColumnName("modif_stkminimun");
            entity.Property(e => e.ModifStksecurite).HasColumnName("modif_stksecurite");
            entity.Property(e => e.ModifStock).HasColumnName("modif_stock");
            entity.Property(e => e.ModifTarifDouanier).HasColumnName("modif_TarifDouanier");
            entity.Property(e => e.ModifTauxmajor).HasColumnName("modif_tauxmajor");
            entity.Property(e => e.ModifTaxeSup).HasColumnName("modif_taxe_sup");
            entity.Property(e => e.ModifTpf1).HasColumnName("modif_tpf1");
            entity.Property(e => e.ModifTpf2).HasColumnName("modif_tpf2");
            entity.Property(e => e.ModifTransport).HasColumnName("modif_transport");
            entity.Property(e => e.ModifTva).HasColumnName("modif_tva");
            entity.Property(e => e.ModifTxmarge).HasColumnName("modif_txmarge");
            entity.Property(e => e.ModifTxrem).HasColumnName("modif_txrem");
            entity.Property(e => e.ModifTypeQteappro).HasColumnName("modif_type_qteappro");
            entity.Property(e => e.ModifUnitePub).HasColumnName("modif_unite_pub");
            entity.Property(e => e.ModifUniteVte).HasColumnName("modif_unite_vte");
            entity.Property(e => e.ModifUniteappro).HasColumnName("modif_uniteappro");
            entity.Property(e => e.ModifUnitedelai).HasColumnName("modif_unitedelai");
            entity.Property(e => e.ModifUnitejourvie).HasColumnName("modif_unitejourvie");
            entity.Property(e => e.ModifUnitestock).HasColumnName("modif_unitestock");
            entity.Property(e => e.ModifVente).HasColumnName("modif_vente");
            entity.Property(e => e.Modifcodefacturation).HasColumnName("modifcodefacturation");
            entity.Property(e => e.Nbpqnull).HasColumnName("nbpqnull");
            entity.Property(e => e.NbrpieceMsu).HasColumnName("nbrpiece_msu");
            entity.Property(e => e.Niveau).HasColumnName("niveau");
            entity.Property(e => e.Ordre).HasColumnName("ordre");
            entity.Property(e => e.PrecisionQte).HasColumnName("precision_qte");
            entity.Property(e => e.ProductionM).HasColumnName("production_m");
            entity.Property(e => e.Reservation).HasColumnName("RESERVATION");
            entity.Property(e => e.SaisieInt).HasColumnName("SAISIE_INT");
            entity.Property(e => e.SaisiePrix).HasColumnName("SAISIE_PRIX");
            entity.Property(e => e.SaisieTxrem).HasColumnName("saisie_txrem");
            entity.Property(e => e.SaisieUni).HasColumnName("SAISIE_UNI");
            entity.Property(e => e.Saisieprix1).HasColumnName("saisieprix");
            entity.Property(e => e.Saisqtegpq).HasColumnName("saisqtegpq");
            entity.Property(e => e.TaxeSup).HasColumnName("TAXE_SUP");
            entity.Property(e => e.Tpf1).HasColumnName("TPF1");
            entity.Property(e => e.Tpf2).HasColumnName("TPF2");
            entity.Property(e => e.Transport).HasColumnName("TRANSPORT");
            entity.Property(e => e.Tva).HasColumnName("TVA");
            entity.Property(e => e.Txmarge).HasColumnName("txmarge");
            entity.Property(e => e.Txrem).HasColumnName("txrem");
            entity.Property(e => e.TypeQteappro).HasColumnName("type_qteappro");
            entity.Property(e => e.UniteAchat).HasColumnName("Unite_Achat");
            entity.Property(e => e.UnitePub).HasColumnName("UNITE_PUB");
            entity.Property(e => e.UniteStatistique).HasColumnName("unite_statistique");
            entity.Property(e => e.UniteVte).HasColumnName("UNITE_VTE");
            entity.Property(e => e.Uniteappro).HasColumnName("uniteappro");
            entity.Property(e => e.Unitejourvie).HasColumnName("unitejourvie");
            entity.Property(e => e.Vente).HasColumnName("vente");
        });

        modelBuilder.Entity<Artdemarageprix>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("artdemarageprix");

            entity.Property(e => e.Adesignation)
                .HasMaxLength(200)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("ADesignation");
            entity.Property(e => e.ApuachatHt)
                .HasColumnType("numeric(10, 3)")
                .HasColumnName("APUAchatHT");
            entity.Property(e => e.Aref)
                .HasMaxLength(50)
                .IsUnicode(false)
                .UseCollation("French_CI_AS")
                .HasColumnName("ARef");
        });

        modelBuilder.Entity<Article>(entity =>
        {
            entity.HasKey(e => e.Aref).HasName("PK_ArticleSifcol");

            entity.ToTable("Article", tb =>
                {
                    tb.HasTrigger("AFTERDelUpdArticleHisto");
                    tb.HasTrigger("AfterInsertArticle");
                    tb.HasTrigger("AfterUpdateArticle");
                    tb.HasTrigger("OnInsertArticle");
                });

            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.Abloque).HasColumnName("ABloque");
            entity.Property(e => e.Acategorie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ACategorie");
            entity.Property(e => e.ActrlSt).HasColumnName("ACtrlST");
            entity.Property(e => e.AdateDebprom).HasColumnType("smalldatetime");
            entity.Property(e => e.AdateFinprom).HasColumnType("smalldatetime");
            entity.Property(e => e.Adesignation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("ADesignation");
            entity.Property(e => e.Afamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AFamille");
            entity.Property(e => e.Afodec).HasColumnName("AFodec");
            entity.Property(e => e.Amarge)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMarge");
            entity.Property(e => e.AmargeProm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMargeProm");
            entity.Property(e => e.AnbparColisage).HasColumnName("ANbparColisage");
            entity.Property(e => e.AnumRef).HasColumnName("ANumRef");
            entity.Property(e => e.ApUventeHt1)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ApUventeHT1");
            entity.Property(e => e.Apnetht)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APNETHT");
            entity.Property(e => e.AprevientHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APRevientHT");
            entity.Property(e => e.AprevientTtc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APRevientTTC");
            entity.Property(e => e.AprixVntprom).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ApromStand).HasColumnName("APromStand");
            entity.Property(e => e.ApuachatHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APUAchatHT");
            entity.Property(e => e.ApuventeHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APUVenteHT");
            entity.Property(e => e.Apvttc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APVTTC");
            entity.Property(e => e.Apvttc1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("APVTTC1");
            entity.Property(e => e.AqteMinVente).HasColumnName("AQteMinVente");
            entity.Property(e => e.AqteMinprom).HasColumnName("AQteMinprom");
            entity.Property(e => e.AqteStock)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("AQteStock");
            entity.Property(e => e.Aqteprom).HasColumnName("AQteprom");
            entity.Property(e => e.Aremise).HasColumnName("ARemise");
            entity.Property(e => e.Aremiseprom).HasColumnName("ARemiseprom");
            entity.Property(e => e.Art)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ART");
            entity.Property(e => e.ArtNd).HasColumnName("ArtND");
            entity.Property(e => e.ArtParent)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ascategorie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ASCategorie");
            entity.Property(e => e.Asfamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ASFamille");
            entity.Property(e => e.AstockMax).HasColumnName("AStockMax");
            entity.Property(e => e.AstockMin).HasColumnName("AStockMin");
            entity.Property(e => e.Astockable).HasColumnName("AStockable");
            entity.Property(e => e.AtauxRemisePromo)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ATauxRemisePromo");
            entity.Property(e => e.AtauxTvav).HasColumnName("ATaux_TVAV");
            entity.Property(e => e.AuniteAch)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AUniteAch");
            entity.Property(e => e.AuniteVnt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AUniteVnt");
            entity.Property(e => e.AvalFodec)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AValFodec");
            entity.Property(e => e.AvalRemise)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AValRemise");
            entity.Property(e => e.Avalorisation).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BaseCalcul).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Button)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CodeBarreL)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CodeBarreParent)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CodeComptable)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.FrsPrincipal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.IdP).ValueGeneratedOnAdd();
            entity.Property(e => e.IdTp).HasColumnName("IdTP");
            entity.Property(e => e.NbrePf).HasColumnName("NbrePF");
            entity.Property(e => e.NomImage)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.PmpBk)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("PMP_BK");
            entity.Property(e => e.PrevientPmp)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("PrevientPMP");
            entity.Property(e => e.Rpuaht).HasColumnName("RPUAHT");
            entity.Property(e => e.Tvamarge).HasColumnName("TVAMarge");
        });

        modelBuilder.Entity<Article17012018>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Article17012018");

            entity.Property(e => e.Abloque).HasColumnName("ABloque");
            entity.Property(e => e.Acategorie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ACategorie");
            entity.Property(e => e.ActrlSt).HasColumnName("ACtrlST");
            entity.Property(e => e.AdateDebprom).HasColumnType("smalldatetime");
            entity.Property(e => e.AdateFinprom).HasColumnType("smalldatetime");
            entity.Property(e => e.Adesignation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("ADesignation");
            entity.Property(e => e.Afamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AFamille");
            entity.Property(e => e.Afodec).HasColumnName("AFodec");
            entity.Property(e => e.Amarge)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMarge");
            entity.Property(e => e.AmargeProm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMargeProm");
            entity.Property(e => e.AnbparColisage).HasColumnName("ANbparColisage");
            entity.Property(e => e.AnumRef).HasColumnName("ANumRef");
            entity.Property(e => e.ApUventeHt1)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ApUventeHT1");
            entity.Property(e => e.Apnetht)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APNETHT");
            entity.Property(e => e.AprevientHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APRevientHT");
            entity.Property(e => e.AprevientTtc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APRevientTTC");
            entity.Property(e => e.AprixVntprom).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ApromStand).HasColumnName("APromStand");
            entity.Property(e => e.ApuachatHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APUAchatHT");
            entity.Property(e => e.ApuventeHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APUVenteHT");
            entity.Property(e => e.Apvttc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APVTTC");
            entity.Property(e => e.Apvttc1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("APVTTC1");
            entity.Property(e => e.AqteMinVente).HasColumnName("AQteMinVente");
            entity.Property(e => e.AqteMinprom).HasColumnName("AQteMinprom");
            entity.Property(e => e.AqteStock)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("AQteStock");
            entity.Property(e => e.Aqteprom).HasColumnName("AQteprom");
            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.Aremise).HasColumnName("ARemise");
            entity.Property(e => e.Aremiseprom).HasColumnName("ARemiseprom");
            entity.Property(e => e.Art)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ART");
            entity.Property(e => e.ArtNd).HasColumnName("ArtND");
            entity.Property(e => e.ArtParent)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ascategorie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ASCategorie");
            entity.Property(e => e.Asfamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ASFamille");
            entity.Property(e => e.AstockMax).HasColumnName("AStockMax");
            entity.Property(e => e.AstockMin).HasColumnName("AStockMin");
            entity.Property(e => e.Astockable).HasColumnName("AStockable");
            entity.Property(e => e.AtauxRemisePromo)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ATauxRemisePromo");
            entity.Property(e => e.AtauxTvav).HasColumnName("ATaux_TVAV");
            entity.Property(e => e.AuniteAch)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AUniteAch");
            entity.Property(e => e.AuniteVnt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AUniteVnt");
            entity.Property(e => e.AvalFodec)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AValFodec");
            entity.Property(e => e.AvalRemise)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AValRemise");
            entity.Property(e => e.Avalorisation).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BaseCalcul).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Button)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CodeBarreL)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CodeBarreParent)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CodeComptable)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.FrsPrincipal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.IdP).ValueGeneratedOnAdd();
            entity.Property(e => e.IdTp).HasColumnName("IdTP");
            entity.Property(e => e.NbrePf).HasColumnName("NbrePF");
            entity.Property(e => e.NomImage)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.PrevientPmp)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("PrevientPMP");
            entity.Property(e => e.Rpuaht).HasColumnName("RPUAHT");
            entity.Property(e => e.Tvamarge).HasColumnName("TVAMarge");
        });

        modelBuilder.Entity<Article26042020>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Article_26042020");

            entity.Property(e => e.Abloque).HasColumnName("ABloque");
            entity.Property(e => e.Acategorie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ACategorie");
            entity.Property(e => e.ActrlSt).HasColumnName("ACtrlST");
            entity.Property(e => e.AdateDebprom).HasColumnType("smalldatetime");
            entity.Property(e => e.AdateFinprom).HasColumnType("smalldatetime");
            entity.Property(e => e.Adesignation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("ADesignation");
            entity.Property(e => e.Afamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AFamille");
            entity.Property(e => e.Afodec).HasColumnName("AFodec");
            entity.Property(e => e.Amarge)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMarge");
            entity.Property(e => e.AmargeProm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMargeProm");
            entity.Property(e => e.AnbparColisage).HasColumnName("ANbparColisage");
            entity.Property(e => e.AnumRef).HasColumnName("ANumRef");
            entity.Property(e => e.ApUventeHt1)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ApUventeHT1");
            entity.Property(e => e.Apnetht)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APNETHT");
            entity.Property(e => e.AprevientHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APRevientHT");
            entity.Property(e => e.AprevientTtc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APRevientTTC");
            entity.Property(e => e.AprixVntprom).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ApromStand).HasColumnName("APromStand");
            entity.Property(e => e.ApuachatHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APUAchatHT");
            entity.Property(e => e.ApuventeHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APUVenteHT");
            entity.Property(e => e.Apvttc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APVTTC");
            entity.Property(e => e.Apvttc1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("APVTTC1");
            entity.Property(e => e.AqteMinVente).HasColumnName("AQteMinVente");
            entity.Property(e => e.AqteMinprom).HasColumnName("AQteMinprom");
            entity.Property(e => e.AqteStock)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("AQteStock");
            entity.Property(e => e.Aqteprom).HasColumnName("AQteprom");
            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.Aremise).HasColumnName("ARemise");
            entity.Property(e => e.Aremiseprom).HasColumnName("ARemiseprom");
            entity.Property(e => e.Art)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ART");
            entity.Property(e => e.ArtNd).HasColumnName("ArtND");
            entity.Property(e => e.ArtParent)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ascategorie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ASCategorie");
            entity.Property(e => e.Asfamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ASFamille");
            entity.Property(e => e.AstockMax).HasColumnName("AStockMax");
            entity.Property(e => e.AstockMin).HasColumnName("AStockMin");
            entity.Property(e => e.Astockable).HasColumnName("AStockable");
            entity.Property(e => e.AtauxRemisePromo)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ATauxRemisePromo");
            entity.Property(e => e.AtauxTvav).HasColumnName("ATaux_TVAV");
            entity.Property(e => e.AuniteAch)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AUniteAch");
            entity.Property(e => e.AuniteVnt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AUniteVnt");
            entity.Property(e => e.AvalFodec)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AValFodec");
            entity.Property(e => e.AvalRemise)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AValRemise");
            entity.Property(e => e.Avalorisation).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BaseCalcul).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Button)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CodeBarreL)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CodeBarreParent)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CodeComptable)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.FrsPrincipal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.IdP).ValueGeneratedOnAdd();
            entity.Property(e => e.IdTp).HasColumnName("IdTP");
            entity.Property(e => e.NbrePf).HasColumnName("NbrePF");
            entity.Property(e => e.NomImage)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.PrevientPmp)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("PrevientPMP");
            entity.Property(e => e.Rpuaht).HasColumnName("RPUAHT");
            entity.Property(e => e.Tvamarge).HasColumnName("TVAMarge");
        });

        modelBuilder.Entity<Article3112>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Article3112");

            entity.Property(e => e.Abloque).HasColumnName("ABloque");
            entity.Property(e => e.Acategorie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ACategorie");
            entity.Property(e => e.ActrlSt).HasColumnName("ACtrlST");
            entity.Property(e => e.AdateDebprom).HasColumnType("smalldatetime");
            entity.Property(e => e.AdateFinprom).HasColumnType("smalldatetime");
            entity.Property(e => e.Adesignation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("ADesignation");
            entity.Property(e => e.Afamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AFamille");
            entity.Property(e => e.Afodec).HasColumnName("AFodec");
            entity.Property(e => e.Amarge)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMarge");
            entity.Property(e => e.AmargeProm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMargeProm");
            entity.Property(e => e.AnbparColisage).HasColumnName("ANbparColisage");
            entity.Property(e => e.AnumRef).HasColumnName("ANumRef");
            entity.Property(e => e.ApUventeHt1)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ApUventeHT1");
            entity.Property(e => e.Apnetht)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APNETHT");
            entity.Property(e => e.AprevientHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APRevientHT");
            entity.Property(e => e.AprevientTtc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APRevientTTC");
            entity.Property(e => e.AprixVntprom).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ApromStand).HasColumnName("APromStand");
            entity.Property(e => e.ApuachatHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APUAchatHT");
            entity.Property(e => e.ApuventeHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APUVenteHT");
            entity.Property(e => e.Apvttc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APVTTC");
            entity.Property(e => e.Apvttc1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("APVTTC1");
            entity.Property(e => e.AqteMinVente).HasColumnName("AQteMinVente");
            entity.Property(e => e.AqteMinprom).HasColumnName("AQteMinprom");
            entity.Property(e => e.AqteStock)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("AQteStock");
            entity.Property(e => e.Aqteprom).HasColumnName("AQteprom");
            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.Aremise).HasColumnName("ARemise");
            entity.Property(e => e.Aremiseprom).HasColumnName("ARemiseprom");
            entity.Property(e => e.Art)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ART");
            entity.Property(e => e.ArtNd).HasColumnName("ArtND");
            entity.Property(e => e.ArtParent)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ascategorie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ASCategorie");
            entity.Property(e => e.Asfamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ASFamille");
            entity.Property(e => e.AstockMax).HasColumnName("AStockMax");
            entity.Property(e => e.AstockMin).HasColumnName("AStockMin");
            entity.Property(e => e.Astockable).HasColumnName("AStockable");
            entity.Property(e => e.AtauxRemisePromo)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ATauxRemisePromo");
            entity.Property(e => e.AtauxTvav).HasColumnName("ATaux_TVAV");
            entity.Property(e => e.AuniteAch)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AUniteAch");
            entity.Property(e => e.AuniteVnt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AUniteVnt");
            entity.Property(e => e.AvalFodec)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AValFodec");
            entity.Property(e => e.AvalRemise)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AValRemise");
            entity.Property(e => e.Avalorisation).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BaseCalcul).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Button)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CodeBarreL)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CodeBarreParent)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CodeComptable)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.FrsPrincipal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.IdP).ValueGeneratedOnAdd();
            entity.Property(e => e.IdTp).HasColumnName("IdTP");
            entity.Property(e => e.NbrePf).HasColumnName("NbrePF");
            entity.Property(e => e.NomImage)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.PrevientPmp)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("PrevientPMP");
            entity.Property(e => e.Rpuaht).HasColumnName("RPUAHT");
            entity.Property(e => e.Tvamarge).HasColumnName("TVAMarge");
        });

        modelBuilder.Entity<ArticleCharge>(entity =>
        {
            entity.HasKey(e => new { e.Aref, e.NCharge });

            entity.ToTable("ArticleCharge");

            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.NCharge)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("N_Charge");
            entity.Property(e => e.TCharge)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("T_Charge");
            entity.Property(e => e.TotalCharge)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("Total_Charge");
            entity.Property(e => e.Valeur).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<ArticleControlDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ArticleControlDetail");

            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.CodeDoc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Commentaire).HasMaxLength(255);
            entity.Property(e => e.Designation).HasMaxLength(255);
            entity.Property(e => e.Max)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Min)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ArticleCriter>(entity =>
        {
            entity.HasKey(e => new { e.Aref, e.NCriters });

            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.NCriters)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("N_criters");
            entity.Property(e => e.Valeur)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
        });

        modelBuilder.Entity<ArticleDocBce>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ArticleDocBCE");

            entity.Property(e => e.DocArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocPunit).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.DocRemise).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocType)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Revient).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<ArticleDocumentBce>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ArticleDocumentBCE");

            entity.Property(e => e.DocArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocPunit).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.DocRemise).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocType)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Revient).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<ArticleFr>(entity =>
        {
            entity.HasKey(e => new { e.Fref, e.Aref });

            entity.ToTable("ArticleFRS");

            entity.Property(e => e.Fref)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("FRef");
            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.CodeAf)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CodeAF");
            entity.Property(e => e.DelaiRecep)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.PrixF).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Tvaf).HasColumnName("TVAF");
        });

        modelBuilder.Entity<ArticleHbc1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ArticleHBC1");

            entity.Property(e => e.Designation).HasMaxLength(255);
            entity.Property(e => e.QteStk).HasMaxLength(255);
            entity.Property(e => e.RefArt).HasMaxLength(255);
        });

        modelBuilder.Entity<ArticleHistorique>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ArticleHistorique");

            entity.Property(e => e.Abloque).HasColumnName("ABloque");
            entity.Property(e => e.Acategorie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ACategorie");
            entity.Property(e => e.ActionA)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ActionDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ActrlSt).HasColumnName("ACtrlST");
            entity.Property(e => e.AdateDebprom).HasColumnType("smalldatetime");
            entity.Property(e => e.AdateFinprom).HasColumnType("smalldatetime");
            entity.Property(e => e.Adesignation)
                .HasMaxLength(100)
                .HasColumnName("ADesignation");
            entity.Property(e => e.Afamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AFamille");
            entity.Property(e => e.Afodec).HasColumnName("AFodec");
            entity.Property(e => e.Amarge)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMarge");
            entity.Property(e => e.AmargeProm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMargeProm");
            entity.Property(e => e.AnbparColisage).HasColumnName("ANbparColisage");
            entity.Property(e => e.AnumRef).HasColumnName("ANumRef");
            entity.Property(e => e.Apnetht)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APNETHT");
            entity.Property(e => e.AprevientHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APRevientHT");
            entity.Property(e => e.AprevientTtc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APRevientTTC");
            entity.Property(e => e.AprixVntprom).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ApromStand).HasColumnName("APromStand");
            entity.Property(e => e.ApuachatHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APUAchatHT");
            entity.Property(e => e.ApuventeHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APUVenteHT");
            entity.Property(e => e.Apvttc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APVTTC");
            entity.Property(e => e.Apvttc1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("APVTTC1");
            entity.Property(e => e.AqteMinVente).HasColumnName("AQteMinVente");
            entity.Property(e => e.AqteMinprom).HasColumnName("AQteMinprom");
            entity.Property(e => e.AqteStock)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("AQteStock");
            entity.Property(e => e.Aqteprom).HasColumnName("AQteprom");
            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ARef");
            entity.Property(e => e.Aremise).HasColumnName("ARemise");
            entity.Property(e => e.Aremiseprom).HasColumnName("ARemiseprom");
            entity.Property(e => e.Art)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ART");
            entity.Property(e => e.ArtNd).HasColumnName("ArtND");
            entity.Property(e => e.ArtParent)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ascategorie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ASCategorie");
            entity.Property(e => e.Asfamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ASFamille");
            entity.Property(e => e.AstockMax).HasColumnName("AStockMax");
            entity.Property(e => e.AstockMin).HasColumnName("AStockMin");
            entity.Property(e => e.Astockable).HasColumnName("AStockable");
            entity.Property(e => e.AtauxRemisePromo)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ATauxRemisePromo");
            entity.Property(e => e.AtauxTvav).HasColumnName("ATaux_TVAV");
            entity.Property(e => e.AuniteAch)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AUniteAch");
            entity.Property(e => e.AuniteVnt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("AUniteVnt");
            entity.Property(e => e.AvalFodec)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AValFodec");
            entity.Property(e => e.AvalRemise)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AValRemise");
            entity.Property(e => e.Avalorisation).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BaseCalcul).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Button)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CodeBarreL)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CodeBarreParent)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CodeComptable)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.FrsPrincipal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdTp).HasColumnName("IdTP");
            entity.Property(e => e.NbrePf).HasColumnName("NbrePF");
            entity.Property(e => e.NomImage)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.Rpuaht).HasColumnName("RPUAHT");
            entity.Property(e => e.Tvamarge).HasColumnName("TVAMarge");
        });

        modelBuilder.Entity<ArticleImDesc>(entity =>
        {
            entity.HasKey(e => e.Aref);

            entity.ToTable("ArticleImDesc");

            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.Adescription)
                .UseCollation("French_CI_AI")
                .HasColumnType("text")
                .HasColumnName("ADescription");
            entity.Property(e => e.Pimage).HasColumnType("image");
        });

        modelBuilder.Entity<ArticleInsertion08062023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Article_Insertion08062023");

            entity.Property(e => e.Catégorie)
                .HasMaxLength(255)
                .HasColumnName("catégorie");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Designation)
                .HasMaxLength(255)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Famille)
                .HasMaxLength(255)
                .HasColumnName("famille ");
            entity.Property(e => e.PuAchat).HasColumnName("PU Achat");
            entity.Property(e => e.Pvht).HasColumnName("PVHT");
            entity.Property(e => e.RefArticle)
                .HasMaxLength(255)
                .HasColumnName("Ref article");
            entity.Property(e => e.SousFamille)
                .HasMaxLength(255)
                .HasColumnName("sous famille ");
            entity.Property(e => e.TvaAchat).HasColumnName("TVA ACHAT");
            entity.Property(e => e.TvaVente).HasColumnName("TVA VENTE");
            entity.Property(e => e.Unite)
                .HasMaxLength(255)
                .HasColumnName("UNITE");
        });

        modelBuilder.Entity<ArticleJob>(entity =>
        {
            entity.HasKey(e => new { e.Aref, e.DateCopie });

            entity.ToTable("Article_Jobs");

            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.DateCopie).HasColumnType("smalldatetime");
            entity.Property(e => e.Abloque).HasColumnName("ABloque");
            entity.Property(e => e.Acategorie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ACategorie");
            entity.Property(e => e.ActrlSt).HasColumnName("ACtrlST");
            entity.Property(e => e.AdateDebprom).HasColumnType("smalldatetime");
            entity.Property(e => e.AdateFinprom).HasColumnType("smalldatetime");
            entity.Property(e => e.Adesignation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("ADesignation");
            entity.Property(e => e.Afamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AFamille");
            entity.Property(e => e.Afodec).HasColumnName("AFodec");
            entity.Property(e => e.Amarge)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMarge");
            entity.Property(e => e.AmargeProm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMargeProm");
            entity.Property(e => e.AnbparColisage).HasColumnName("ANbparColisage");
            entity.Property(e => e.AnumRef).HasColumnName("ANumRef");
            entity.Property(e => e.ApUventeHt1)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ApUventeHT1");
            entity.Property(e => e.Apnetht)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APNETHT");
            entity.Property(e => e.AprevientHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APRevientHT");
            entity.Property(e => e.AprevientTtc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APRevientTTC");
            entity.Property(e => e.AprixVntprom).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ApromStand).HasColumnName("APromStand");
            entity.Property(e => e.ApuachatHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APUAchatHT");
            entity.Property(e => e.ApuventeHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APUVenteHT");
            entity.Property(e => e.Apvttc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APVTTC");
            entity.Property(e => e.Apvttc1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("APVTTC1");
            entity.Property(e => e.AqteMinVente).HasColumnName("AQteMinVente");
            entity.Property(e => e.AqteMinprom).HasColumnName("AQteMinprom");
            entity.Property(e => e.AqteStock)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("AQteStock");
            entity.Property(e => e.Aqteprom).HasColumnName("AQteprom");
            entity.Property(e => e.Aremise).HasColumnName("ARemise");
            entity.Property(e => e.Aremiseprom).HasColumnName("ARemiseprom");
            entity.Property(e => e.Art)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ART");
            entity.Property(e => e.ArtNd).HasColumnName("ArtND");
            entity.Property(e => e.ArtParent)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ascategorie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ASCategorie");
            entity.Property(e => e.Asfamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ASFamille");
            entity.Property(e => e.AstockMax).HasColumnName("AStockMax");
            entity.Property(e => e.AstockMin).HasColumnName("AStockMin");
            entity.Property(e => e.Astockable).HasColumnName("AStockable");
            entity.Property(e => e.AtauxRemisePromo)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ATauxRemisePromo");
            entity.Property(e => e.AtauxTvav).HasColumnName("ATaux_TVAV");
            entity.Property(e => e.AuniteAch)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AUniteAch");
            entity.Property(e => e.AuniteVnt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AUniteVnt");
            entity.Property(e => e.AvalFodec)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AValFodec");
            entity.Property(e => e.AvalRemise)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AValRemise");
            entity.Property(e => e.Avalorisation).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BaseCalcul).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Button)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CodeBarreL)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CodeBarreParent)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CodeComptable)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.FrsPrincipal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.IdTp).HasColumnName("IdTP");
            entity.Property(e => e.NbrePf).HasColumnName("NbrePF");
            entity.Property(e => e.NomImage)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.PrevientPmp)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("PrevientPMP");
            entity.Property(e => e.Rpuaht).HasColumnName("RPUAHT");
            entity.Property(e => e.Tvamarge).HasColumnName("TVAMarge");
        });

        modelBuilder.Entity<ArticleNv2023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Article_Nv_2023");

            entity.Property(e => e.Catégorie)
                .HasMaxLength(255)
                .HasColumnName("catégorie");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("DESCRIPTION");
            entity.Property(e => e.Designation)
                .HasMaxLength(255)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Famille)
                .HasMaxLength(255)
                .HasColumnName("famille ");
            entity.Property(e => e.PuAchat).HasColumnName("PU Achat");
            entity.Property(e => e.Pvht).HasColumnName("PVHT");
            entity.Property(e => e.RefArticle)
                .HasMaxLength(255)
                .HasColumnName("Ref article");
            entity.Property(e => e.SousFamille)
                .HasMaxLength(255)
                .HasColumnName("sous famille ");
            entity.Property(e => e.Tva).HasColumnName("TVA");
        });

        modelBuilder.Entity<ArticlePmpinitial>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ArticlePMPInitial");

            entity.Property(e => e.RefArt).HasMaxLength(255);
            entity.Property(e => e.RevientPmp)
                .HasMaxLength(255)
                .HasColumnName("RevientPMP");
        });

        modelBuilder.Entity<ArticleRemiseTaxe>(entity =>
        {
            entity.HasKey(e => new { e.Aref, e.NRemTaxe, e.TypeRT });

            entity.ToTable("ArticleRemiseTaxe", tb => tb.HasTrigger("ForINSERTArticleRemiseTaxe"));

            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.NRemTaxe)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("N_RemTaxe");
            entity.Property(e => e.TypeRT)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("Type_R_T");
            entity.Property(e => e.OOrder).HasColumnName("O_Order");
            entity.Property(e => e.TotalRemTaxe).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.VRemTaxe).HasColumnName("V_RemTaxe");
        });

        modelBuilder.Entity<ArticleSelection>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ArticleSelection");

            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
        });

        modelBuilder.Entity<ArticleSifcol>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ArticleSifcol");

            entity.Property(e => e.Accqtezero).HasColumnName("accqtezero");
            entity.Property(e => e.Achat).HasColumnName("achat");
            entity.Property(e => e.An1).HasColumnName("an1");
            entity.Property(e => e.An2).HasColumnName("an2");
            entity.Property(e => e.An3).HasColumnName("an3");
            entity.Property(e => e.An4).HasColumnName("an4");
            entity.Property(e => e.An5).HasColumnName("an5");
            entity.Property(e => e.Blocage).HasColumnName("blocage");
            entity.Property(e => e.Choix).HasColumnName("choix");
            entity.Property(e => e.Cledepartition).HasColumnName("cledepartition");
            entity.Property(e => e.Code).HasColumnName("CODE");
            entity.Property(e => e.CodeQte).HasColumnName("CODE_QTE");
            entity.Property(e => e.CodeTarif).HasColumnName("CODE_TARIF");
            entity.Property(e => e.Codefacturation).HasColumnName("codefacturation");
            entity.Property(e => e.CodeqteFixe).HasColumnName("codeqte_fixe");
            entity.Property(e => e.CoefStkMax).HasColumnName("coef_stk_max");
            entity.Property(e => e.CoefStkSec).HasColumnName("coef_stk_sec");
            entity.Property(e => e.CommandeFerme).HasColumnName("commande_ferme");
            entity.Property(e => e.Contrat).HasColumnName("contrat");
            entity.Property(e => e.Cumulpu).HasColumnName("cumulpu");
            entity.Property(e => e.DateCre)
                .HasColumnType("datetime")
                .HasColumnName("date_cre");
            entity.Property(e => e.DateDerModif)
                .HasColumnType("datetime")
                .HasColumnName("date_der_modif");
            entity.Property(e => e.Datecreation)
                .HasColumnType("datetime")
                .HasColumnName("datecreation");
            entity.Property(e => e.Dated1)
                .HasColumnType("datetime")
                .HasColumnName("dated1");
            entity.Property(e => e.Dated2)
                .HasColumnType("datetime")
                .HasColumnName("dated2");
            entity.Property(e => e.Dc).HasColumnName("DC");
            entity.Property(e => e.DcAch).HasColumnName("DC_ach");
            entity.Property(e => e.Delaiappro).HasColumnName("delaiappro");
            entity.Property(e => e.Dim1).HasColumnName("dim1");
            entity.Property(e => e.Dim1n).HasColumnName("dim1n");
            entity.Property(e => e.Dim2).HasColumnName("dim2");
            entity.Property(e => e.Dim3).HasColumnName("dim3");
            entity.Property(e => e.Dimunique).HasColumnName("dimunique");
            entity.Property(e => e.Dprixa).HasColumnName("dprixa");
            entity.Property(e => e.Excel).HasColumnName("EXCEL");
            entity.Property(e => e.FormuleQte).HasColumnName("formule_qte");
            entity.Property(e => e.FvnD1).HasColumnName("FVN_D1");
            entity.Property(e => e.FvnD2).HasColumnName("FVN_D2");
            entity.Property(e => e.FvnD3).HasColumnName("FVN_D3");
            entity.Property(e => e.Idpays).HasColumnName("idpays");
            entity.Property(e => e.Impdim1).HasColumnName("impdim1");
            entity.Property(e => e.Impdim2).HasColumnName("impdim2");
            entity.Property(e => e.Impdim3).HasColumnName("impdim3");
            entity.Property(e => e.Impnbrpiece).HasColumnName("impnbrpiece");
            entity.Property(e => e.Impqtecolis).HasColumnName("impqtecolis");
            entity.Property(e => e.Intitule).HasColumnName("INTITULE");
            entity.Property(e => e.JourVie).HasColumnName("Jour_vie");
            entity.Property(e => e.Libelle).HasColumnName("LIBELLE");
            entity.Property(e => e.Majoration).HasColumnName("MAJORATION");
            entity.Property(e => e.Marque).HasColumnName("marque");
            entity.Property(e => e.Maxtxrem).HasColumnName("maxtxrem");
            entity.Property(e => e.Modesaisie).HasColumnName("modesaisie");
            entity.Property(e => e.ModifCodeqte).HasColumnName("modif_codeqte");
            entity.Property(e => e.ModifCodeqteFixe).HasColumnName("modif_codeqte_fixe");
            entity.Property(e => e.ModifDim1).HasColumnName("modif_dim1");
            entity.Property(e => e.ModifDim2).HasColumnName("modif_dim2");
            entity.Property(e => e.ModifDim3).HasColumnName("modif_dim3");
            entity.Property(e => e.ModifFvn1).HasColumnName("modif_fvn1");
            entity.Property(e => e.ModifFvn2).HasColumnName("modif_fvn2");
            entity.Property(e => e.ModifFvn3).HasColumnName("modif_fvn3");
            entity.Property(e => e.ModifFvnc).HasColumnName("modif_fvnc");
            entity.Property(e => e.ModifModesaisie).HasColumnName("modif_modesaisie");
            entity.Property(e => e.ModifNbpnull).HasColumnName("modif_nbpnull");
            entity.Property(e => e.ModifQtec).HasColumnName("modif_qtec");
            entity.Property(e => e.Multiligne).HasColumnName("multiligne");
            entity.Property(e => e.N1).HasColumnName("n1");
            entity.Property(e => e.N2).HasColumnName("n2");
            entity.Property(e => e.N3).HasColumnName("n3");
            entity.Property(e => e.N4).HasColumnName("n4");
            entity.Property(e => e.N5).HasColumnName("n5");
            entity.Property(e => e.Nature).HasColumnName("nature");
            entity.Property(e => e.Nbpqnull).HasColumnName("nbpqnull");
            entity.Property(e => e.NbrpieceMsu).HasColumnName("nbrpiece_msu");
            entity.Property(e => e.Niveau).HasColumnName("niveau");
            entity.Property(e => e.Pmpa).HasColumnName("pmpa");
            entity.Property(e => e.PoidUMat).HasColumnName("POID_U_MAT");
            entity.Property(e => e.PoidUTot).HasColumnName("POID_U_TOT");
            entity.Property(e => e.PrecisionQte).HasColumnName("precision_qte");
            entity.Property(e => e.PrixMarcheInf).HasColumnName("prix_marche_inf");
            entity.Property(e => e.PrixMarcheSup).HasColumnName("prix_marche_sup");
            entity.Property(e => e.Prixrevientc).HasColumnName("prixrevientc");
            entity.Property(e => e.Production).HasColumnName("production");
            entity.Property(e => e.ProductionM).HasColumnName("production_m");
            entity.Property(e => e.Pu1).HasColumnName("PU_1");
            entity.Property(e => e.Pu2).HasColumnName("PU_2");
            entity.Property(e => e.Pu3).HasColumnName("PU_3");
            entity.Property(e => e.Pu4).HasColumnName("PU_4");
            entity.Property(e => e.PuPublic).HasColumnName("PU_PUBLIC");
            entity.Property(e => e.Pua1).HasColumnName("pua_1");
            entity.Property(e => e.Pua2).HasColumnName("pua_2");
            entity.Property(e => e.Pua3).HasColumnName("pua_3");
            entity.Property(e => e.Pua4).HasColumnName("pua_4");
            entity.Property(e => e.QteColisage).HasColumnName("Qte_colisage");
            entity.Property(e => e.QteCons1).HasColumnName("QTE_CONS1");
            entity.Property(e => e.QteCons2).HasColumnName("QTE_CONS2");
            entity.Property(e => e.QteEconAchatAuto).HasColumnName("qte_econ_achat_auto");
            entity.Property(e => e.QteProduction).HasColumnName("qte_production");
            entity.Property(e => e.RefC).HasColumnName("REF_C");
            entity.Property(e => e.RefCons1).HasColumnName("REF_CONS1");
            entity.Property(e => e.RefCons2).HasColumnName("REF_CONS2");
            entity.Property(e => e.RefP).HasColumnName("REF_P");
            entity.Property(e => e.SaisieInt).HasColumnName("SAISIE_INT");
            entity.Property(e => e.SaisiePrix).HasColumnName("SAISIE_PRIX");
            entity.Property(e => e.SaisieTxrem).HasColumnName("saisie_txrem");
            entity.Property(e => e.SaisieUni).HasColumnName("SAISIE_UNI");
            entity.Property(e => e.Saisieprix1).HasColumnName("saisieprix");
            entity.Property(e => e.Saisqtegpq).HasColumnName("saisqtegpq");
            entity.Property(e => e.ServAdd).HasColumnName("SERV_ADD");
            entity.Property(e => e.Stock).HasColumnName("STOCK");
            entity.Property(e => e.StockMaxAuto).HasColumnName("stock_max_auto");
            entity.Property(e => e.StockMinAuto).HasColumnName("stock_min_auto");
            entity.Property(e => e.StockSecAuto).HasColumnName("stock_sec_auto");
            entity.Property(e => e.Tauxabais).HasColumnName("tauxabais");
            entity.Property(e => e.Tauxmarge).HasColumnName("tauxmarge");
            entity.Property(e => e.TaxeSup).HasColumnName("TAXE_SUP");
            entity.Property(e => e.TaxeSupAch).HasColumnName("taxe_sup_ach");
            entity.Property(e => e.Tolerenceprod).HasColumnName("tolerenceprod");
            entity.Property(e => e.Tpf1).HasColumnName("TPF1");
            entity.Property(e => e.Tpf1Ach).HasColumnName("tpf1_ach");
            entity.Property(e => e.Tpf2).HasColumnName("TPF2");
            entity.Property(e => e.Tpf2Ach).HasColumnName("tpf2_ach");
            entity.Property(e => e.TransfActif).HasColumnName("transf_actif");
            entity.Property(e => e.Transport).HasColumnName("TRANSPORT");
            entity.Property(e => e.TransportAch).HasColumnName("transport_ach");
            entity.Property(e => e.Tva).HasColumnName("TVA");
            entity.Property(e => e.TvaAch).HasColumnName("tva_ach");
            entity.Property(e => e.Txmarge).HasColumnName("txmarge");
            entity.Property(e => e.Txmargec).HasColumnName("txmargec");
            entity.Property(e => e.Txrem).HasColumnName("txrem");
            entity.Property(e => e.TypeColisage).HasColumnName("type_colisage");
            entity.Property(e => e.TypeQteappro).HasColumnName("type_qteappro");
            entity.Property(e => e.TypeQteproduction).HasColumnName("type_qteproduction");
            entity.Property(e => e.UniteAchat).HasColumnName("Unite_Achat");
            entity.Property(e => e.UnitePub).HasColumnName("UNITE_PUB");
            entity.Property(e => e.UniteVte).HasColumnName("UNITE_VTE");
            entity.Property(e => e.Uniteappro).HasColumnName("uniteappro");
            entity.Property(e => e.Unitejourvie).HasColumnName("unitejourvie");
            entity.Property(e => e.UtilisateurCreateur).HasColumnName("utilisateur_createur");
            entity.Property(e => e.UtilisateurModif).HasColumnName("utilisateur_modif");
            entity.Property(e => e.Vente).HasColumnName("vente");
            entity.Property(e => e.Volume).HasColumnName("volume");
        });

        modelBuilder.Entity<ArticleSite>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ARTICLE_SITE");

            entity.Property(e => e.Achat).HasColumnName("achat");
            entity.Property(e => e.Blocage).HasColumnName("blocage");
            entity.Property(e => e.Delaiappro).HasColumnName("delaiappro");
            entity.Property(e => e.Delailiv).HasColumnName("delailiv");
            entity.Property(e => e.Dln).HasColumnName("dln");
            entity.Property(e => e.Dprixa).HasColumnName("dprixa");
            entity.Property(e => e.Nature).HasColumnName("nature");
            entity.Property(e => e.Pmpa).HasColumnName("pmpa");
            entity.Property(e => e.Prixrevient).HasColumnName("prixrevient");
            entity.Property(e => e.Prixrevientc).HasColumnName("prixrevientc");
            entity.Property(e => e.ProductionM).HasColumnName("production_m");
            entity.Property(e => e.Pu1).HasColumnName("pu_1");
            entity.Property(e => e.Pu2).HasColumnName("pu_2");
            entity.Property(e => e.Pu3).HasColumnName("pu_3");
            entity.Property(e => e.Pu4).HasColumnName("pu_4");
            entity.Property(e => e.PuPublic).HasColumnName("pu_public");
            entity.Property(e => e.Pua1).HasColumnName("pua_1");
            entity.Property(e => e.Pua2).HasColumnName("pua_2");
            entity.Property(e => e.Pua3).HasColumnName("pua_3");
            entity.Property(e => e.Pua4).HasColumnName("pua_4");
            entity.Property(e => e.QteEconAchatAuto).HasColumnName("qte_econ_achat_auto");
            entity.Property(e => e.RefC).HasColumnName("REF_C");
            entity.Property(e => e.Site).HasColumnName("SITE");
            entity.Property(e => e.Stkmaximal).HasColumnName("stkmaximal");
            entity.Property(e => e.Stkminimal).HasColumnName("stkminimal");
            entity.Property(e => e.Stksecurite).HasColumnName("stksecurite");
            entity.Property(e => e.Stock).HasColumnName("stock");
            entity.Property(e => e.StockMaxAuto).HasColumnName("stock_max_auto");
            entity.Property(e => e.StockMinAuto).HasColumnName("stock_min_auto");
            entity.Property(e => e.StockSecAuto).HasColumnName("stock_sec_auto");
            entity.Property(e => e.Txmarge).HasColumnName("txmarge");
            entity.Property(e => e.Txmargec).HasColumnName("txmargec");
            entity.Property(e => e.Uniteappro).HasColumnName("uniteappro");
            entity.Property(e => e.Vente).HasColumnName("vente");
        });

        modelBuilder.Entity<ArticleSource>(entity =>
        {
            entity.HasKey(e => new { e.Aref, e.Sref });

            entity.ToTable("ArticleSource", tb => tb.HasTrigger("AfterUpdateArticleSource"));

            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.Sref)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("SRef");
            entity.Property(e => e.QteAs)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Qte_AS");
        });

        modelBuilder.Entity<ArticleSourceBoumhal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ArticleSourceBoumhal");

            entity.Property(e => e.CodeArt).HasMaxLength(250);
            entity.Property(e => e.Designation).HasMaxLength(250);
            entity.Property(e => e.QteStk).HasMaxLength(250);
        });

        modelBuilder.Entity<ArticleSourceCentral>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ArticleSourceCentral");

            entity.Property(e => e.CodeArt).HasMaxLength(250);
            entity.Property(e => e.Designation).HasMaxLength(250);
            entity.Property(e => e.QteStk).HasMaxLength(250);
        });

        modelBuilder.Entity<ArticleSourceReserv>(entity =>
        {
            entity.HasKey(e => new { e.Aref, e.Sref });

            entity.ToTable("ArticleSourceReserv", tb => tb.HasTrigger("AfterUpdateArticleSourceReserv"));

            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ARef");
            entity.Property(e => e.Sref)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("SRef");
            entity.Property(e => e.QteAs)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Qte_AS");
        });

        modelBuilder.Entity<ArticleSourceSidiSalem>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ArticleSourceSidiSalem");

            entity.Property(e => e.CodeArt).HasMaxLength(250);
            entity.Property(e => e.Designation).HasMaxLength(250);
            entity.Property(e => e.QteStk).HasMaxLength(250);
        });

        modelBuilder.Entity<ArticleTvamodif>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ArticleTVAModif");

            entity.Property(e => e.Abloque).HasColumnName("ABloque");
            entity.Property(e => e.Acategorie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ACategorie");
            entity.Property(e => e.ActrlSt).HasColumnName("ACtrlST");
            entity.Property(e => e.AdateDebprom).HasColumnType("smalldatetime");
            entity.Property(e => e.AdateFinprom).HasColumnType("smalldatetime");
            entity.Property(e => e.Adesignation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("ADesignation");
            entity.Property(e => e.Afamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AFamille");
            entity.Property(e => e.Afodec).HasColumnName("AFodec");
            entity.Property(e => e.Amarge)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMarge");
            entity.Property(e => e.AmargeProm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMargeProm");
            entity.Property(e => e.AnbparColisage).HasColumnName("ANbparColisage");
            entity.Property(e => e.AnumRef).HasColumnName("ANumRef");
            entity.Property(e => e.ApUventeHt1)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ApUventeHT1");
            entity.Property(e => e.Apnetht)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APNETHT");
            entity.Property(e => e.AprevientHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APRevientHT");
            entity.Property(e => e.AprevientTtc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APRevientTTC");
            entity.Property(e => e.AprixVntprom).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ApromStand).HasColumnName("APromStand");
            entity.Property(e => e.ApuachatHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APUAchatHT");
            entity.Property(e => e.ApuventeHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APUVenteHT");
            entity.Property(e => e.Apvttc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APVTTC");
            entity.Property(e => e.Apvttc1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("APVTTC1");
            entity.Property(e => e.AqteMinVente).HasColumnName("AQteMinVente");
            entity.Property(e => e.AqteMinprom).HasColumnName("AQteMinprom");
            entity.Property(e => e.AqteStock)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("AQteStock");
            entity.Property(e => e.Aqteprom).HasColumnName("AQteprom");
            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.Aremise).HasColumnName("ARemise");
            entity.Property(e => e.Aremiseprom).HasColumnName("ARemiseprom");
            entity.Property(e => e.Art)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ART");
            entity.Property(e => e.ArtNd).HasColumnName("ArtND");
            entity.Property(e => e.ArtParent)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ascategorie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ASCategorie");
            entity.Property(e => e.Asfamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ASFamille");
            entity.Property(e => e.AstockMax).HasColumnName("AStockMax");
            entity.Property(e => e.AstockMin).HasColumnName("AStockMin");
            entity.Property(e => e.Astockable).HasColumnName("AStockable");
            entity.Property(e => e.AtauxRemisePromo)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ATauxRemisePromo");
            entity.Property(e => e.AtauxTvav).HasColumnName("ATaux_TVAV");
            entity.Property(e => e.AuniteAch)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AUniteAch");
            entity.Property(e => e.AuniteVnt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AUniteVnt");
            entity.Property(e => e.AvalFodec)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AValFodec");
            entity.Property(e => e.AvalRemise)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AValRemise");
            entity.Property(e => e.Avalorisation).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BaseCalcul).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Button)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CodeBarreL)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CodeBarreParent)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CodeComptable)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.FrsPrincipal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.IdP).ValueGeneratedOnAdd();
            entity.Property(e => e.IdTp).HasColumnName("IdTP");
            entity.Property(e => e.NbrePf).HasColumnName("NbrePF");
            entity.Property(e => e.NomImage)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.PrevientPmp)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("PrevientPMP");
            entity.Property(e => e.Rpuaht).HasColumnName("RPUAHT");
            entity.Property(e => e.Tvamarge).HasColumnName("TVAMarge");
        });

        modelBuilder.Entity<ArticleTypePrix>(entity =>
        {
            entity.HasKey(e => new { e.Aref, e.NTypePrix });

            entity.ToTable("ArticleTypePrix");

            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.NTypePrix)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("N_TypePrix");
            entity.Property(e => e.Marge).HasColumnName("marge");
            entity.Property(e => e.Prixtype)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("prixtype");
            entity.Property(e => e.PrixtypeHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("prixtypeHT");
            entity.Property(e => e.QteD).HasColumnName("qteD");
            entity.Property(e => e.QteFin).HasColumnName("qteFin");
            entity.Property(e => e.Remise).HasColumnName("remise");
            entity.Property(e => e.RemiseCalculBk)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("RemiseCalculBK");
            entity.Property(e => e.Val).HasColumnName("val");
        });

        modelBuilder.Entity<ArticleTypePrixHistorique>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ArticleTypePrixHistorique");

            entity.Property(e => e.DateOperation).HasColumnType("smalldatetime");
            entity.Property(e => e.Marge).HasColumnName("marge");
            entity.Property(e => e.NTypePrix)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("N_TypePrix");
            entity.Property(e => e.Prixtype)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("prixtype");
            entity.Property(e => e.PrixtypeHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("prixtypeHT");
            entity.Property(e => e.QteD).HasColumnName("qteD");
            entity.Property(e => e.QteFin).HasColumnName("qteFin");
            entity.Property(e => e.RefArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Remise).HasColumnName("remise");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.Val).HasColumnName("val");
        });

        modelBuilder.Entity<Articleorigine>(entity =>
        {
            entity.HasKey(e => e.Aref).HasName("PK_Article");

            entity.ToTable("Articleorigine", tb =>
                {
                    tb.HasTrigger("AFTERDeleteA");
                    tb.HasTrigger("ForINSERTArticle");
                });

            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.Abloque).HasColumnName("ABloque");
            entity.Property(e => e.Acategorie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ACategorie");
            entity.Property(e => e.ActrlSt).HasColumnName("ACtrlST");
            entity.Property(e => e.AdateDebprom).HasColumnType("smalldatetime");
            entity.Property(e => e.AdateFinprom).HasColumnType("smalldatetime");
            entity.Property(e => e.Adesignation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("ADesignation");
            entity.Property(e => e.Afamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AFamille");
            entity.Property(e => e.Afodec).HasColumnName("AFodec");
            entity.Property(e => e.Amarge)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMarge");
            entity.Property(e => e.AmargeProm)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMargeProm");
            entity.Property(e => e.AnbparColisage).HasColumnName("ANbparColisage");
            entity.Property(e => e.AnumRef).HasColumnName("ANumRef");
            entity.Property(e => e.Apnetht)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APNETHT");
            entity.Property(e => e.AprevientHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APRevientHT");
            entity.Property(e => e.AprevientTtc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APRevientTTC");
            entity.Property(e => e.AprixVntprom).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ApromStand).HasColumnName("APromStand");
            entity.Property(e => e.ApuachatHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APUAchatHT");
            entity.Property(e => e.ApuventeHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APUVenteHT");
            entity.Property(e => e.Apvttc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APVTTC");
            entity.Property(e => e.Apvttc1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("APVTTC1");
            entity.Property(e => e.AqteMinVente).HasColumnName("AQteMinVente");
            entity.Property(e => e.AqteMinprom).HasColumnName("AQteMinprom");
            entity.Property(e => e.AqteStock)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("AQteStock");
            entity.Property(e => e.Aqteprom).HasColumnName("AQteprom");
            entity.Property(e => e.Aremise).HasColumnName("ARemise");
            entity.Property(e => e.Aremiseprom).HasColumnName("ARemiseprom");
            entity.Property(e => e.Art)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("ART");
            entity.Property(e => e.ArtNd).HasColumnName("ArtND");
            entity.Property(e => e.ArtParent)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ascategorie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ASCategorie");
            entity.Property(e => e.Asfamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ASFamille");
            entity.Property(e => e.AstockMax).HasColumnName("AStockMax");
            entity.Property(e => e.AstockMin).HasColumnName("AStockMin");
            entity.Property(e => e.Astockable).HasColumnName("AStockable");
            entity.Property(e => e.AtauxRemisePromo)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("ATauxRemisePromo");
            entity.Property(e => e.AtauxTvav).HasColumnName("ATaux_TVAV");
            entity.Property(e => e.AuniteAch)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AUniteAch");
            entity.Property(e => e.AuniteVnt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AUniteVnt");
            entity.Property(e => e.AvalFodec)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AValFodec");
            entity.Property(e => e.AvalRemise)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AValRemise");
            entity.Property(e => e.Avalorisation).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.BaseCalcul).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Button)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.CodeBarreL)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CodeBarreParent)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CodeComptable)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Color)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.FrsPrincipal)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.IdP).ValueGeneratedOnAdd();
            entity.Property(e => e.IdTp).HasColumnName("IdTP");
            entity.Property(e => e.NbrePf).HasColumnName("NbrePF");
            entity.Property(e => e.NomImage)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.Rpuaht).HasColumnName("RPUAHT");
            entity.Property(e => e.Tvamarge).HasColumnName("TVAMarge");
        });

        modelBuilder.Entity<ArtinvEdi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("artinvEDI");

            entity.Property(e => e.AprevientHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APRevientHT");
            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("aref");
        });

        modelBuilder.Entity<ArtinvNeg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("artinvNeg");

            entity.Property(e => e.Px)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("px");
            entity.Property(e => e.Qte)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("qte");
            entity.Property(e => e.Ref).HasMaxLength(50);
        });

        modelBuilder.Entity<Artracc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ARTRacc$");

            entity.Property(e => e.Aref)
                .HasMaxLength(255)
                .HasColumnName("ARef");
            entity.Property(e => e.Categorie)
                .HasMaxLength(255)
                .HasColumnName("CATEGORIE");
            entity.Property(e => e.Désignation)
                .HasMaxLength(255)
                .HasColumnName("________Désignation_________");
            entity.Property(e => e.Famille)
                .HasMaxLength(255)
                .HasColumnName("FAMILLE");
            entity.Property(e => e.SousCategorie)
                .HasMaxLength(255)
                .HasColumnName("SOUS CATEGORIE");
            entity.Property(e => e.SousFamille)
                .HasMaxLength(255)
                .HasColumnName("SOUS FAMILLE ");
        });

        modelBuilder.Entity<Aut>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AUT$");

            entity.Property(e => e.MatriculePaiePointeuse).HasColumnName("Matricule paie & pointeuse");
            entity.Property(e => e.NomEtPrénom)
                .HasMaxLength(255)
                .HasColumnName("Nom et prénom");
            entity.Property(e => e.Sup1Autorisation)
                .HasMaxLength(255)
                .HasColumnName("SUP 1 AUTORISATION");
            entity.Property(e => e.Sup2Autorisation)
                .HasMaxLength(255)
                .HasColumnName("SUP 2 AUTORISATION");
        });

        modelBuilder.Entity<Bca>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("bca");

            entity.Property(e => e.Ann).HasMaxLength(255);
            entity.Property(e => e.Art)
                .HasMaxLength(255)
                .HasColumnName("art");
            entity.Property(e => e.Clt).HasMaxLength(255);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Des)
                .HasMaxLength(255)
                .HasColumnName("des");
            entity.Property(e => e.Liv).HasColumnName("liv");
            entity.Property(e => e.Pu).HasColumnName("pu");
            entity.Property(e => e.Reste).HasColumnName("reste");
            entity.Property(e => e.Tot).HasColumnName("tot");
        });

        modelBuilder.Entity<Bcaencour>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BCAEncours");

            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.DateLev)
                .HasMaxLength(50)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("dateLev");
            entity.Property(e => e.Datefacturationprevu)
                .HasColumnType("smalldatetime")
                .HasColumnName("datefacturationprevu");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocTotalHt).HasColumnName("DocTotalHT");
            entity.Property(e => e.Docartdesignation)
                .HasMaxLength(250)
                .IsFixedLength()
                .HasColumnName("docartdesignation");
            entity.Property(e => e.Docdevise)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("docdevise");
            entity.Property(e => e.Docprojet).HasColumnName("docprojet");
            entity.Property(e => e.Doctype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("doctype");
            entity.Property(e => e.QtenonCommander).HasColumnName("QTENonCommander");
            entity.Property(e => e.RefArticle)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefrenceBca)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("RefrenceBCA");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<Bcencour>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BCEncours");

            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Docdate)
                .HasColumnType("smalldatetime")
                .HasColumnName("docdate");
            entity.Property(e => e.Docref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("docref");
            entity.Property(e => e.Ematricule)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
        });

        modelBuilder.Entity<BcencourDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BCEncourDetail");

            entity.Property(e => e.Article)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Designation)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocPunit).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Px).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Qte).HasColumnName("qte");
            entity.Property(e => e.Tht)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("THT");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<BcnabeulEncour>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BCNabeulEncours");

            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateEch)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalTva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalTVA");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NetàPayer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RaisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefExt).HasMaxLength(250);
            entity.Property(e => e.RefTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<BcsfaxEncour>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BCSfaxEncour");

            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateEch)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalTva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalTVA");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NetàPayer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RaisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefExt).HasMaxLength(250);
            entity.Property(e => e.RefTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<BcsousseEncour>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BCSousseEncours");

            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateEch)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalTva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalTVA");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NetàPayer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RaisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefExt).HasMaxLength(250);
            entity.Property(e => e.RefTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<BctunisEncour>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BCTunisEncours");

            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateEch)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalTva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalTVA");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NetàPayer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RaisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefExt).HasMaxLength(250);
            entity.Property(e => e.RefTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<Bcv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BCV");

            entity.Property(e => e.Ann).HasMaxLength(255);
            entity.Property(e => e.Art)
                .HasMaxLength(255)
                .HasColumnName("art");
            entity.Property(e => e.Clt).HasMaxLength(255);
            entity.Property(e => e.Date)
                .HasColumnType("datetime")
                .HasColumnName("date");
            entity.Property(e => e.Des)
                .HasMaxLength(255)
                .HasColumnName("des");
            entity.Property(e => e.Liv).HasColumnName("liv");
            entity.Property(e => e.Pu).HasColumnName("pu");
            entity.Property(e => e.Reste).HasColumnName("reste");
            entity.Property(e => e.Tot).HasColumnName("tot");
        });

        modelBuilder.Entity<Beneficeclient>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("beneficeclient");

            entity.Property(e => e.Benefice).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Client)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
        });

        modelBuilder.Entity<Biat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BIAT");

            entity.Property(e => e.Dater)
                .HasColumnType("datetime")
                .HasColumnName("dater");
            entity.Property(e => e.Ech)
                .HasColumnType("datetime")
                .HasColumnName("ech");
            entity.Property(e => e.Mode).HasMaxLength(255);
            entity.Property(e => e.Montant).HasColumnName("montant");
            entity.Property(e => e.Num)
                .HasMaxLength(255)
                .HasColumnName("num");
        });

        modelBuilder.Entity<Bkma1814>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("bkma1814");

            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Breception)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Caisse)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Commentaire).HasMaxLength(250);
            entity.Property(e => e.DateAnnuler).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch2).HasColumnType("smalldatetime");
            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateP).HasColumnType("smalldatetime");
            entity.Property(e => e.DateR).HasColumnType("smalldatetime");
            entity.Property(e => e.DateV).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMntLettre).HasMaxLength(500);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Docref1).HasMaxLength(20);
            entity.Property(e => e.Etat).HasColumnType("smalldatetime");
            entity.Property(e => e.Imput1)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("imput1");
            entity.Property(e => e.Imputation)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MontantR).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.NumEncDec2).HasMaxLength(20);
            entity.Property(e => e.Pdecommentaire)
                .HasMaxLength(250)
                .HasColumnName("PDECommentaire");
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Rib)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("RIB");
            entity.Property(e => e.Rib1).HasMaxLength(100);
            entity.Property(e => e.Ribp)
                .HasMaxLength(100)
                .HasColumnName("RIBP");
            entity.Property(e => e.Trc).HasColumnName("TRC");
            entity.Property(e => e.TypeEncDec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.UniqueIdEncDec).ValueGeneratedOnAdd();
            entity.Property(e => e.VisibleEd).HasColumnName("VisibleED");
        });

        modelBuilder.Entity<BlfcidligneExt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BLFCIdligneExt");

            entity.Property(e => e.Col1)
                .HasMaxLength(289)
                .UseCollation("French_CI_AI")
                .HasColumnName("col1");
            entity.Property(e => e.Col2)
                .HasMaxLength(10)
                .UseCollation("French_CI_AI")
                .HasColumnName("col2");
            entity.Property(e => e.Col3).HasColumnName("col3");
        });

        modelBuilder.Entity<BlnonFacturée>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BLNonFacturée");

            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Filiere)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NetàPayer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RefTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Tiers)
                .HasMaxLength(201)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<Budget>(entity =>
        {
            entity.HasKey(e => new { e.Annee, e.Mois, e.Rib });

            entity.ToTable("Budget");

            entity.Property(e => e.Rib)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RIB");
            entity.Property(e => e.Breception)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Budget1)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Budget");
            entity.Property(e => e.BudgetJ).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UniqueId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<BudgetPlafond>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BudgetPlafond", tb =>
                {
                    tb.HasTrigger("ForupdatedBudgetPlafond");
                    tb.HasTrigger("InsertedBudgetPlafond");
                    tb.HasTrigger("deletedBudgetPlafond");
                });

            entity.Property(e => e.Breception)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.BudgetType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DateCreation).HasColumnType("smalldatetime");
            entity.Property(e => e.DatePrevu).HasColumnType("smalldatetime");
            entity.Property(e => e.Des).HasMaxLength(250);
            entity.Property(e => e.DocCloture).HasColumnType("smalldatetime");
            entity.Property(e => e.DocLancement).HasColumnType("smalldatetime");
            entity.Property(e => e.EtatBp).HasColumnName("EtatBP");
            entity.Property(e => e.EtatBp1).HasColumnName("EtatBP1");
            entity.Property(e => e.Lcol1)
                .HasMaxLength(50)
                .HasColumnName("LCol1");
            entity.Property(e => e.Lcol2)
                .HasMaxLength(50)
                .HasColumnName("LCol2");
            entity.Property(e => e.Lcol3)
                .HasMaxLength(50)
                .HasColumnName("LCol3");
            entity.Property(e => e.Lcol4)
                .HasMaxLength(250)
                .HasColumnName("LCol4");
            entity.Property(e => e.Lcol5)
                .HasMaxLength(50)
                .HasColumnName("LCol5");
            entity.Property(e => e.Lcol6)
                .HasMaxLength(50)
                .HasColumnName("LCol6");
            entity.Property(e => e.Lcol7)
                .HasMaxLength(50)
                .HasColumnName("LCol7");
            entity.Property(e => e.Lcol8)
                .HasMaxLength(50)
                .HasColumnName("LCol8");
            entity.Property(e => e.LetatBp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEtatBP");
            entity.Property(e => e.LetatBp1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEtatBP1");
            entity.Property(e => e.Rib)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RIB");
            entity.Property(e => e.UniqueId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CaRegion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CA_Region");

            entity.Property(e => e.Cville)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CVille");
            entity.Property(e => e.Expr1).HasColumnType("decimal(38, 4)");
        });

        modelBuilder.Entity<CalculPmp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CalculPMP");

            entity.Property(e => e.DocArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Qte).HasColumnName("qte");
            entity.Property(e => e.Revient)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("revient");
            entity.Property(e => e.Type)
                .HasMaxLength(3)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<Carep>(entity =>
        {
            entity.HasKey(e => e.Code);

            entity.ToTable("CARep");

            entity.Property(e => e.Acategorie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ACategorie");
            entity.Property(e => e.Afamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AFamille");
            entity.Property(e => e.Annee)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Asfamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ASFamille");
            entity.Property(e => e.DocRepresentant)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocTiers)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Mois1).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Mois10).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Mois11).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Mois12).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Mois2).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Mois3).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Mois4).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Mois5).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Mois6).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Mois7).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Mois8).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Mois9).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<Categorie>(entity =>
        {
            entity.HasKey(e => e.IdCat);

            entity.ToTable("Categorie");

            entity.Property(e => e.IdCat)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ID_Cat");
            entity.Property(e => e.NCat)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("N_Cat");
        });

        modelBuilder.Entity<Charge>(entity =>
        {
            entity.HasKey(e => e.NCharge);

            entity.ToTable("Charge");

            entity.Property(e => e.NCharge)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("N_Charge");
            entity.Property(e => e.TCharge)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("T_Charge");
        });

        modelBuilder.Entity<ClientActif>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Client_Actif");

            entity.Property(e => e.Cnom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CNom");
            entity.Property(e => e.Cprenom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CPrenom");
            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.DocRepresentant)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
        });

        modelBuilder.Entity<ClientBc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Client_BCS");

            entity.Property(e => e.Cref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CRef");
        });

        modelBuilder.Entity<Clientmod>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Clientmod");

            entity.Property(e => e.Cref).HasMaxLength(20);
            entity.Property(e => e.Representant)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.SecteurActivite)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS")
                .HasColumnName("Secteur#Activite");
            entity.Property(e => e.Ville)
                .HasMaxLength(255)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<ClientsActif>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("'Clients Actifs$'");

            entity.Property(e => e.Ca).HasColumnName("CA");
            entity.Property(e => e.CaY1).HasColumnName("CA Y-1");
            entity.Property(e => e.RaisonSociale)
                .HasMaxLength(255)
                .HasColumnName("Raison Sociale");
            entity.Property(e => e.Secteur).HasMaxLength(255);
            entity.Property(e => e.TypeClient)
                .HasMaxLength(255)
                .HasColumnName("Type Client");
            entity.Property(e => e.ZoneDActivité)
                .HasMaxLength(255)
                .HasColumnName("Zone d'activité");
        });

        modelBuilder.Entity<ClientsActif1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ClientsActifs$");

            entity.Property(e => e.Ca).HasColumnName("CA");
            entity.Property(e => e.CaY1).HasColumnName("CA Y-1");
            entity.Property(e => e.Code).HasMaxLength(255);
            entity.Property(e => e.RaisonSociale)
                .HasMaxLength(255)
                .HasColumnName("Raison Sociale");
            entity.Property(e => e.Secteur).HasMaxLength(255);
            entity.Property(e => e.TypeClient)
                .HasMaxLength(255)
                .HasColumnName("Type Client");
            entity.Property(e => e.ZoneDActivité)
                .HasMaxLength(255)
                .HasColumnName("Zone d'activité");
        });

        modelBuilder.Entity<CodeMonnaie>(entity =>
        {
            entity.HasKey(e => e.CodeM);

            entity.ToTable("CodeMonnaie");

            entity.Property(e => e.CodeM).ValueGeneratedNever();
            entity.Property(e => e.AbreviationM)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.DesignationM)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<Command>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("command");

            entity.Property(e => e.Date).HasColumnType("smalldatetime");
            entity.Property(e => e.DateCréation).HasColumnType("smalldatetime");
            entity.Property(e => e.DateRecouvrement).HasColumnType("smalldatetime");
            entity.Property(e => e.DocRepresentant)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("French_CI_AI")
                .HasColumnName("Doc.Type");
            entity.Property(e => e.ModeRegTier)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MontantReglé)
                .HasColumnType("decimal(38, 3)")
                .HasColumnName("Montant.reglé");
            entity.Property(e => e.Nptiers)
                .HasMaxLength(100)
                .HasColumnName("NPTIERS");
            entity.Property(e => e.RefDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI")
                .HasColumnName("Ref.Doc");
            entity.Property(e => e.RefTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI")
                .HasColumnName("Ref.Tiers");
            entity.Property(e => e.Reste).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Tiers)
                .HasMaxLength(202)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Total).HasColumnType("decimal(20, 4)");
            entity.Property(e => e.TotalAvance)
                .HasColumnType("decimal(38, 3)")
                .HasColumnName("Total.Avance");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<ComptaIntegrationAutomatique>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ComptaIntegrationAutomatique");

            entity.Property(e => e.ChampCompta).HasMaxLength(500);
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

     

        modelBuilder.Entity<ConditionPayement>(entity =>
        {
            entity.HasKey(e => new { e.DocType, e.DocRef, e.NumLigne });

            entity.ToTable("ConditionPayement");

            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.DocRef)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Description)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<ConfigSociete>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ConfigSociete", tb => tb.HasTrigger("MAJ_Chiffre"));

            entity.Property(e => e.ASoc)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("A_Soc");
            entity.Property(e => e.Activite)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Bca)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("BCA");
            entity.Property(e => e.Bcv)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("BCV");
            entity.Property(e => e.Bes)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("BES");
            entity.Property(e => e.Bla)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("BLA");
            entity.Property(e => e.Blv)
                .HasMaxLength(50)
                .HasColumnName("BLV");
            entity.Property(e => e.Bpv)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("BPV");
            entity.Property(e => e.Bra)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("BRA");
            entity.Property(e => e.Brv)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("BRV");
            entity.Property(e => e.Bss)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("BSS");
            entity.Property(e => e.CapSoc)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("Cap_Soc");
            entity.Property(e => e.CodePosta)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("Code_Posta");
            entity.Property(e => e.DateFinBilan).HasColumnType("smalldatetime");
            entity.Property(e => e.Dde)
                .HasMaxLength(250)
                .HasColumnName("DDE");
            entity.Property(e => e.Ddevise)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("DDevise");
            entity.Property(e => e.Denc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("DENC");
            entity.Property(e => e.Dev)
                .HasMaxLength(50)
                .HasColumnName("DEV");
            entity.Property(e => e.EmSoc)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("EM_Soc");
            entity.Property(e => e.Enc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ENC");
            entity.Property(e => e.FSoc)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("F_Soc");
            entity.Property(e => e.Faa)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("FAA");
            entity.Property(e => e.Faaa)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("FAAA");
            entity.Property(e => e.Faav)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("FAAV");
            entity.Property(e => e.Fav)
                .HasMaxLength(50)
                .HasColumnName("FAV");
            entity.Property(e => e.FormatDoc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Fpv)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("FPV");
            entity.Property(e => e.IntegrationSecurite).HasDefaultValue(true);
            entity.Property(e => e.LName)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("L_Name");
            entity.Property(e => e.LSoc)
                .HasColumnType("image")
                .HasColumnName("L_Soc");
            entity.Property(e => e.MSoc)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("M_Soc");
            entity.Property(e => e.MfSoc)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("MF_Soc");
            entity.Property(e => e.MinMarge).HasColumnType("decimal(18, 5)");
            entity.Property(e => e.Mlogin)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS")
                .HasColumnName("MLOGIN");
            entity.Property(e => e.Mpw)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS")
                .HasColumnName("MPW");
            entity.Property(e => e.Msmtp)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS")
                .HasColumnName("MSMTP");
            entity.Property(e => e.NSoc)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("N_Soc");
            entity.Property(e => e.NbChiffre)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("NbCHIFFRE");
            entity.Property(e => e.Numero)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.Password)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.PerteGain).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.RcSoc)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("RC_Soc");
            entity.Property(e => e.Rue)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.SSoc)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("S_Soc");
            entity.Property(e => e.ServerName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.TSoc)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("T_Soc");
            entity.Property(e => e.TauxInterret).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TimberFiscal).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UserId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS")
                .HasColumnName("UserID");
            entity.Property(e => e.Ville)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<ContactsAut>(entity =>
        {
            entity.HasKey(e => new { e.Ref, e.Valeur });

            entity.ToTable("ContactsAut");

            entity.Property(e => e.Ref)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Valeur)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Tcontact)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("TContact");
        });

        modelBuilder.Entity<ContactsC>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ContactsC", tb =>
                {
                    tb.HasTrigger("AFTERDeleteContactC");
                    tb.HasTrigger("AFTERINSERTContactC");
                });

            entity.Property(e => e.Ref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Tcontact)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("TContact");
            entity.Property(e => e.Valeur)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("valeur");
        });

        modelBuilder.Entity<ContactsF>(entity =>
        {
            entity.HasKey(e => new { e.Ref, e.Valeur });

            entity.ToTable("ContactsF");

            entity.Property(e => e.Ref)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Valeur)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("valeur");
            entity.Property(e => e.Tcontact)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("TContact");
        });

        modelBuilder.Entity<ConventionClient>(entity =>
        {
            entity.HasKey(e => new { e.Cref, e.Aref });

            entity.ToTable("ConventionClient", tb => tb.HasTrigger("ForInsertConvClient"));

            entity.Property(e => e.Cref)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CRef");
            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.Apvttc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APVTTC");
            entity.Property(e => e.Aremise).HasColumnName("ARemise");
        });

        modelBuilder.Entity<CritereDestSecteur>(entity =>
        {
            entity.HasKey(e => new { e.Type, e.Ref });

            entity.ToTable("CritereDestSecteur");

            entity.Property(e => e.Type)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Ref)
                .HasMaxLength(10)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NType)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("N_Type");
            entity.Property(e => e.PType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("P_Type");
            entity.Property(e => e.RefType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("Ref_Type");
            entity.Property(e => e.VType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("V_Type");
        });

        modelBuilder.Entity<Crmaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CRMAction", tb =>
                {
                    tb.HasTrigger("AFTERInsertCRM");
                    tb.HasTrigger("DeletedCRMACTION");
                });

            entity.HasIndex(e => new { e.IdCampagne, e.Crmtype, e.DateCreation }, "NonClusteredIndex-20230529-091445").IsDescending(true, false, true);

            entity.Property(e => e.Col1).HasMaxLength(250);
            entity.Property(e => e.Col10).HasMaxLength(250);
            entity.Property(e => e.Col11).HasMaxLength(250);
            entity.Property(e => e.Col12).HasMaxLength(250);
            entity.Property(e => e.Col13).HasMaxLength(250);
            entity.Property(e => e.Col14).HasMaxLength(250);
            entity.Property(e => e.Col15).HasMaxLength(250);
            entity.Property(e => e.Col16).HasMaxLength(250);
            entity.Property(e => e.Col17).HasMaxLength(250);
            entity.Property(e => e.Col18).HasMaxLength(250);
            entity.Property(e => e.Col19).HasMaxLength(250);
            entity.Property(e => e.Col2).HasMaxLength(250);
            entity.Property(e => e.Col20).HasMaxLength(250);
            entity.Property(e => e.Col21).HasMaxLength(250);
            entity.Property(e => e.Col22).HasMaxLength(250);
            entity.Property(e => e.Col23).HasMaxLength(250);
            entity.Property(e => e.Col24).HasMaxLength(250);
            entity.Property(e => e.Col25).HasMaxLength(250);
            entity.Property(e => e.Col3).HasMaxLength(250);
            entity.Property(e => e.Col4).HasMaxLength(250);
            entity.Property(e => e.Col5).HasMaxLength(250);
            entity.Property(e => e.Col6).HasMaxLength(250);
            entity.Property(e => e.Col7).HasMaxLength(250);
            entity.Property(e => e.Col8).HasMaxLength(250);
            entity.Property(e => e.Col9).HasMaxLength(250);
            entity.Property(e => e.Crmtype)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CRMType");
            entity.Property(e => e.DateCreation).HasColumnType("smalldatetime");
            entity.Property(e => e.DatePrevu).HasColumnType("smalldatetime");
            entity.Property(e => e.Des).HasMaxLength(255);
            entity.Property(e => e.DocCloture).HasColumnType("smalldatetime");
            entity.Property(e => e.DocLancement).HasColumnType("smalldatetime");
            entity.Property(e => e.EtatBp).HasColumnName("EtatBP");
            entity.Property(e => e.EtatBp1).HasColumnName("EtatBP1");
            entity.Property(e => e.Lcol1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LCol1");
            entity.Property(e => e.Lcol2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LCol2");
            entity.Property(e => e.LetatBp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEtatBP");
            entity.Property(e => e.LetatBp1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEtatBP1");
            entity.Property(e => e.ListeType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Rtf).HasColumnName("RTF");
            entity.Property(e => e.UniqueId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Crmaction28072022Bkt22022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CRMAction_28072022_bkt22022");

            entity.Property(e => e.Col1).HasMaxLength(250);
            entity.Property(e => e.Col10).HasMaxLength(250);
            entity.Property(e => e.Col11).HasMaxLength(250);
            entity.Property(e => e.Col12).HasMaxLength(250);
            entity.Property(e => e.Col13).HasMaxLength(250);
            entity.Property(e => e.Col14).HasMaxLength(250);
            entity.Property(e => e.Col15).HasMaxLength(250);
            entity.Property(e => e.Col16).HasMaxLength(250);
            entity.Property(e => e.Col17).HasMaxLength(250);
            entity.Property(e => e.Col18).HasMaxLength(250);
            entity.Property(e => e.Col19).HasMaxLength(250);
            entity.Property(e => e.Col2).HasMaxLength(250);
            entity.Property(e => e.Col20).HasMaxLength(250);
            entity.Property(e => e.Col21).HasMaxLength(250);
            entity.Property(e => e.Col22).HasMaxLength(250);
            entity.Property(e => e.Col23).HasMaxLength(250);
            entity.Property(e => e.Col24).HasMaxLength(250);
            entity.Property(e => e.Col25).HasMaxLength(250);
            entity.Property(e => e.Col3).HasMaxLength(250);
            entity.Property(e => e.Col4).HasMaxLength(250);
            entity.Property(e => e.Col5).HasMaxLength(250);
            entity.Property(e => e.Col6).HasMaxLength(250);
            entity.Property(e => e.Col7).HasMaxLength(250);
            entity.Property(e => e.Col8).HasMaxLength(250);
            entity.Property(e => e.Col9).HasMaxLength(250);
            entity.Property(e => e.Crmtype)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CRMType");
            entity.Property(e => e.DateCreation).HasColumnType("smalldatetime");
            entity.Property(e => e.DatePrevu).HasColumnType("smalldatetime");
            entity.Property(e => e.Des).HasMaxLength(255);
            entity.Property(e => e.DocCloture).HasColumnType("smalldatetime");
            entity.Property(e => e.DocLancement).HasColumnType("smalldatetime");
            entity.Property(e => e.EtatBp).HasColumnName("EtatBP");
            entity.Property(e => e.EtatBp1).HasColumnName("EtatBP1");
            entity.Property(e => e.IdCampagne)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Lcol1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LCol1");
            entity.Property(e => e.Lcol2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LCol2");
            entity.Property(e => e.LetatBp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEtatBP");
            entity.Property(e => e.LetatBp1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEtatBP1");
            entity.Property(e => e.ListeType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Rtf).HasColumnName("RTF");
            entity.Property(e => e.UniqueId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrmactionLtc1101>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CRMActionLTC1101");

            entity.Property(e => e.Col1).HasMaxLength(250);
            entity.Property(e => e.Col10).HasMaxLength(250);
            entity.Property(e => e.Col11).HasMaxLength(250);
            entity.Property(e => e.Col2).HasMaxLength(250);
            entity.Property(e => e.Col3).HasMaxLength(250);
            entity.Property(e => e.Col4).HasMaxLength(250);
            entity.Property(e => e.Col5).HasMaxLength(250);
            entity.Property(e => e.Col6).HasMaxLength(250);
            entity.Property(e => e.Col7).HasMaxLength(250);
            entity.Property(e => e.Col8).HasMaxLength(250);
            entity.Property(e => e.Col9).HasMaxLength(250);
            entity.Property(e => e.Crmtype)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CRMType");
            entity.Property(e => e.DateCreation).HasColumnType("smalldatetime");
            entity.Property(e => e.DatePrevu).HasColumnType("smalldatetime");
            entity.Property(e => e.Des).HasMaxLength(255);
            entity.Property(e => e.DocCloture).HasColumnType("smalldatetime");
            entity.Property(e => e.DocLancement).HasColumnType("smalldatetime");
            entity.Property(e => e.EtatBp).HasColumnName("EtatBP");
            entity.Property(e => e.EtatBp1).HasColumnName("EtatBP1");
            entity.Property(e => e.IdCampagne)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Lcol1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LCol1");
            entity.Property(e => e.Lcol2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LCol2");
            entity.Property(e => e.LetatBp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEtatBP");
            entity.Property(e => e.LetatBp1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEtatBP1");
            entity.Property(e => e.ListeType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Rtf).HasColumnName("RTF");
            entity.Property(e => e.UniqueId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrmactionRapport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CRMActionRapport");

            entity.Property(e => e.Col1).HasMaxLength(250);
            entity.Property(e => e.Col10).HasMaxLength(250);
            entity.Property(e => e.Col11).HasMaxLength(250);
            entity.Property(e => e.Col12).HasMaxLength(250);
            entity.Property(e => e.Col13).HasMaxLength(250);
            entity.Property(e => e.Col14).HasMaxLength(250);
            entity.Property(e => e.Col15).HasMaxLength(250);
            entity.Property(e => e.Col16).HasMaxLength(250);
            entity.Property(e => e.Col17).HasMaxLength(250);
            entity.Property(e => e.Col18).HasMaxLength(250);
            entity.Property(e => e.Col19).HasMaxLength(250);
            entity.Property(e => e.Col2).HasMaxLength(250);
            entity.Property(e => e.Col20).HasMaxLength(250);
            entity.Property(e => e.Col21).HasMaxLength(250);
            entity.Property(e => e.Col22).HasMaxLength(250);
            entity.Property(e => e.Col23).HasMaxLength(250);
            entity.Property(e => e.Col24).HasMaxLength(250);
            entity.Property(e => e.Col25).HasMaxLength(250);
            entity.Property(e => e.Col26).HasMaxLength(250);
            entity.Property(e => e.Col27).HasMaxLength(250);
            entity.Property(e => e.Col28).HasMaxLength(250);
            entity.Property(e => e.Col29).HasMaxLength(250);
            entity.Property(e => e.Col3).HasMaxLength(250);
            entity.Property(e => e.Col30).HasMaxLength(250);
            entity.Property(e => e.Col31).HasMaxLength(250);
            entity.Property(e => e.Col32).HasMaxLength(250);
            entity.Property(e => e.Col33).HasMaxLength(250);
            entity.Property(e => e.Col34).HasMaxLength(250);
            entity.Property(e => e.Col35).HasMaxLength(250);
            entity.Property(e => e.Col36).HasMaxLength(250);
            entity.Property(e => e.Col37).HasMaxLength(250);
            entity.Property(e => e.Col38).HasMaxLength(250);
            entity.Property(e => e.Col39).HasMaxLength(250);
            entity.Property(e => e.Col4).HasMaxLength(250);
            entity.Property(e => e.Col40).HasMaxLength(250);
            entity.Property(e => e.Col41).HasMaxLength(250);
            entity.Property(e => e.Col42).HasMaxLength(250);
            entity.Property(e => e.Col43).HasMaxLength(250);
            entity.Property(e => e.Col44).HasMaxLength(250);
            entity.Property(e => e.Col45).HasMaxLength(250);
            entity.Property(e => e.Col5).HasMaxLength(250);
            entity.Property(e => e.Col6).HasMaxLength(250);
            entity.Property(e => e.Col7).HasMaxLength(250);
            entity.Property(e => e.Col8).HasMaxLength(250);
            entity.Property(e => e.Col9).HasMaxLength(250);
            entity.Property(e => e.Crmtype)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CRMType");
            entity.Property(e => e.DateCreation).HasColumnType("smalldatetime");
            entity.Property(e => e.DatePrevu).HasColumnType("smalldatetime");
            entity.Property(e => e.Des).HasMaxLength(255);
            entity.Property(e => e.DocCloture).HasColumnType("smalldatetime");
            entity.Property(e => e.DocLancement).HasColumnType("smalldatetime");
            entity.Property(e => e.EtatBp).HasColumnName("EtatBP");
            entity.Property(e => e.EtatBp1).HasColumnName("EtatBP1");
            entity.Property(e => e.IdCampagne)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Lcol1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LCol1");
            entity.Property(e => e.Lcol2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LCol2");
            entity.Property(e => e.LetatBp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEtatBP");
            entity.Property(e => e.LetatBp1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEtatBP1");
            entity.Property(e => e.ListeType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Rtf).HasColumnName("RTF");
            entity.Property(e => e.UniqueId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Crmcampagne>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CRMCampagne", tb =>
                {
                    tb.HasTrigger("AfterUpdateCRM");
                    tb.HasTrigger("OnInsertCRM");
                });

            entity.HasIndex(e => new { e.UniqueId, e.Crmtype, e.DateCreation }, "NonClusteredIndex-20230529-091516").IsDescending(true, false, true);

            entity.Property(e => e.Crmtype)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CRMType");
            entity.Property(e => e.DateCreation).HasColumnType("smalldatetime");
            entity.Property(e => e.DateMail).HasColumnType("smalldatetime");
            entity.Property(e => e.DatePrevu).HasColumnType("smalldatetime");
            entity.Property(e => e.Des).HasMaxLength(255);
            entity.Property(e => e.DocCloture).HasColumnType("smalldatetime");
            entity.Property(e => e.DocLancement).HasColumnType("smalldatetime");
            entity.Property(e => e.EtatBp).HasColumnName("EtatBP");
            entity.Property(e => e.EtatBp1).HasColumnName("EtatBP1");
            entity.Property(e => e.Lcol1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LCol1");
            entity.Property(e => e.Lcol2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LCol2");
            entity.Property(e => e.Lcol3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LCol3");
            entity.Property(e => e.LetatBp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEtatBP");
            entity.Property(e => e.LetatBp1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEtatBP1");
            entity.Property(e => e.Ref)
                .HasMaxLength(20)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Rtf).HasColumnName("RTF");
            entity.Property(e => e.UniqueId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrmcheckArbo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CRMCheckArbo", tb => tb.HasTrigger("AFTERINSERTCRMCheckArbo"));

            entity.HasIndex(e => new { e.UniqueId, e.Ref, e.Parent }, "NonClusteredIndex-20230529-104513").IsDescending(true, false, false);

            entity.Property(e => e.Crmaction).HasColumnName("CRMAction");
            entity.Property(e => e.Menu).HasMaxLength(250);
            entity.Property(e => e.Parent).HasMaxLength(250);
            entity.Property(e => e.Ref).HasMaxLength(250);
            entity.Property(e => e.Type).HasMaxLength(250);
            entity.Property(e => e.UniqueId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrmcheckArbo05102020BkKoul>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CRMCheckArbo_05_10_2020_bk_koul");

            entity.Property(e => e.Crmaction).HasColumnName("CRMAction");
            entity.Property(e => e.Menu).HasMaxLength(250);
            entity.Property(e => e.Parent).HasMaxLength(250);
            entity.Property(e => e.Ref).HasMaxLength(250);
            entity.Property(e => e.Type).HasMaxLength(250);
            entity.Property(e => e.UniqueId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrmcheckArboRapport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CRMCheckArboRapport");

            entity.Property(e => e.Crmaction).HasColumnName("CRMAction");
            entity.Property(e => e.Menu)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Parent)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ref)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniqueId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Crmliste>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CRMListe");

            entity.Property(e => e.Code)
                .HasMaxLength(250)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.CodeListe)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Commentaire).HasMaxLength(250);
            entity.Property(e => e.Crmtype)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CRMType");
            entity.Property(e => e.IdCampagne)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.ListeType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Ref).HasMaxLength(250);
            entity.Property(e => e.UniqueId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<CrmparamListing>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CRMParamListing");

            entity.Property(e => e.Caction).HasColumnName("CAction");
            entity.Property(e => e.Caddition).HasColumnName("CAddition");
            entity.Property(e => e.CcheckBox).HasColumnName("CCheckBox");
            entity.Property(e => e.CcomboBox).HasColumnName("CComboBox");
            entity.Property(e => e.CcomboBoxChange).HasColumnName("CComboBoxChange");
            entity.Property(e => e.CdateTime).HasColumnName("CDateTime");
            entity.Property(e => e.Cmultiple).HasColumnName("CMultiple");
            entity.Property(e => e.Cnumber).HasColumnName("CNumber");
            entity.Property(e => e.Corder).HasColumnName("COrder");
            entity.Property(e => e.CtitreColonne)
                .HasMaxLength(250)
                .HasColumnName("CTitreColonne");
            entity.Property(e => e.Ctotal).HasColumnName("CTotal");
            entity.Property(e => e.Type)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniqueId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Crmview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CRMView");

            entity.Property(e => e.Cnom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CNom");
            entity.Property(e => e.Cprenom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CPrenom");
            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.Cref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CRef");
            entity.Property(e => e.Crmtype)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CRMType");
            entity.Property(e => e.DateCreation).HasColumnType("smalldatetime");
            entity.Property(e => e.DatePrevu).HasColumnType("smalldatetime");
            entity.Property(e => e.Des).HasMaxLength(255);
            entity.Property(e => e.DocArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocCloture).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocLancement).HasColumnType("smalldatetime");
            entity.Property(e => e.DocPunit).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalTtc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalTTC");
            entity.Property(e => e.DocTotalTva).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.EtatBp).HasColumnName("EtatBP");
            entity.Property(e => e.EtatBp1).HasColumnName("EtatBP1");
            entity.Property(e => e.Expr1)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Expr2)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Expr3)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.IdCampagne)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdtypeUser).HasColumnName("IDTypeUser");
            entity.Property(e => e.Lcol1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LCol1");
            entity.Property(e => e.Lcol2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LCol2");
            entity.Property(e => e.LetatBp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEtatBP");
            entity.Property(e => e.LetatBp1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEtatBP1");
            entity.Property(e => e.ListeType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ref)
                .HasMaxLength(20)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Rtf).HasColumnName("RTF");
        });

        modelBuilder.Entity<CumulDesAchatsSifcol>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("CumulDesAchatsSifcol");

            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(38, 4)")
                .HasColumnName("DocTotalHT");
        });

        modelBuilder.Entity<DecEmpA1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("dec_emp_a1");

            entity.Property(e => e.Adresse)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Contribution)
                .HasColumnType("decimal(38, 3)")
                .HasColumnName("contribution");
            entity.Property(e => e.DateDeb).HasMaxLength(10);
            entity.Property(e => e.DateFin).HasMaxLength(10);
            entity.Property(e => e.Fonction)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Identifiant)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Nb).HasColumnName("NB");
            entity.Property(e => e.NetServi).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Nom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Retenu).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.RevenuImp).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Sexe)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.SituationFamiliale)
                .HasMaxLength(20)
                .UseCollation("French_CI_AS")
                .HasColumnName("Situation_Familiale");
        });

        modelBuilder.Entity<DecEmpAnn12022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Dec_Emp_Ann1_2022");

            entity.Property(e => e.CodeEmp).HasMaxLength(255);
            entity.Property(e => e.ContribCss).HasColumnName("CONTRIB CSS");
            entity.Property(e => e.DateDebut)
                .HasColumnType("datetime")
                .HasColumnName("DATE DEBUT");
            entity.Property(e => e.DateFin)
                .HasColumnType("datetime")
                .HasColumnName("DATE FIN");
            entity.Property(e => e.DerniereAdresse)
                .HasMaxLength(255)
                .HasColumnName("DERNIERE ADRESSE");
            entity.Property(e => e.EmploiOccupe)
                .HasMaxLength(255)
                .HasColumnName("EMPLOI OCCUPE");
            entity.Property(e => e.Enf).HasColumnName("ENF");
            entity.Property(e => e.F9).HasColumnType("datetime");
            entity.Property(e => e.MatrCin).HasColumnName("MATR/CIN");
            entity.Property(e => e.MontNetServi).HasColumnName("MONT NET SERVI");
            entity.Property(e => e.NomOuRaisonSociale)
                .HasMaxLength(255)
                .HasColumnName("NOM ou RAISON SOCIALE");
            entity.Property(e => e.RetenusOperes).HasColumnName("RETENUS OPERES");
            entity.Property(e => e.RevenuImposabl).HasColumnName("REVENU IMPOSABL");
            entity.Property(e => e.Sitf).HasColumnName("SITF");
        });

        modelBuilder.Entity<DecTrim1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DecTrim1");

            entity.Property(e => e.Adresse).HasMaxLength(250);
            entity.Property(e => e.Crmtype)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CRMType");
            entity.Property(e => e.DateAuto)
                .HasMaxLength(10)
                .HasColumnName("Date Auto");
            entity.Property(e => e.DateFact)
                .HasColumnType("smalldatetime")
                .HasColumnName("Date fact");
            entity.Property(e => e.IdCampagne)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MatFisc)
                .HasMaxLength(250)
                .HasColumnName("Mat Fisc");
            entity.Property(e => e.Mfclient)
                .HasMaxLength(250)
                .HasColumnName("MFClient");
            entity.Property(e => e.MtHt)
                .HasColumnType("numeric(14, 3)")
                .HasColumnName("Mt.Ht");
            entity.Property(e => e.MtTva)
                .HasColumnType("numeric(22, 6)")
                .HasColumnName("Mt.Tva");
            entity.Property(e => e.NumAutorisation)
                .HasMaxLength(250)
                .HasColumnName("Num.Autorisation");
            entity.Property(e => e.NumFact)
                .HasMaxLength(250)
                .HasColumnName("Num fact");
            entity.Property(e => e.RaisonSocial)
                .HasMaxLength(250)
                .HasColumnName("raison social");
            entity.Property(e => e.TxDc).HasColumnName("Tx.DC");
            entity.Property(e => e.TxFodec).HasColumnName("Tx.Fodec");
            entity.Property(e => e.TxTva)
                .HasColumnType("numeric(13, 2)")
                .HasColumnName("Tx Tva");
            entity.Property(e => e.TypeId)
                .HasMaxLength(250)
                .HasColumnName("Type id");
        });

        modelBuilder.Entity<Destination>(entity =>
        {
            entity.HasKey(e => new { e.RefD, e.Cref, e.TypeD });

            entity.ToTable("Destination");

            entity.Property(e => e.RefD)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Cref)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CRef");
            entity.Property(e => e.TypeD)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("Type_D");
            entity.Property(e => e.AdresseD)
                .HasMaxLength(200)
                .UseCollation("French_CI_AI")
                .HasColumnName("Adresse_D");
            entity.Property(e => e.NDest)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("N_dest");
            entity.Property(e => e.PaysD)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("Pays_D");
            entity.Property(e => e.VilleD)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("Ville_D");
        });

        modelBuilder.Entity<DetailBlencour>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DetailBLEncours");

            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateEch)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalTva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalTVA");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NetàPayer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.NomPrénom)
                .HasMaxLength(101)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RaisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefExt).HasMaxLength(250);
            entity.Property(e => e.RefTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Représentant).HasMaxLength(50);
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<Document>(entity =>
        {
            entity.HasKey(e => e.CodeDoc);

            entity.ToTable("Document");

            entity.Property(e => e.CodeDoc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Afarticle).HasColumnName("AFArticle");
            entity.Property(e => e.Afdocument).HasColumnName("AFDocument");
            entity.Property(e => e.BoutonV)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.CodeTiers)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Col1)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("COL1");
            entity.Property(e => e.Col2)
                .HasMaxLength(30)
                .IsFixedLength()
                .HasColumnName("COL2");
            entity.Property(e => e.Col3)
                .HasMaxLength(100)
                .HasColumnName("COL3");
            entity.Property(e => e.Col4)
                .HasMaxLength(100)
                .HasColumnName("COL4");
            entity.Property(e => e.DatagridviewV)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.DesEtatDoc)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.DesEtatDoc1)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Destination)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.DocTre)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.EtatDoc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.LibDoc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.ProcArticle)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Punit).HasColumnName("PUnit");
            entity.Property(e => e.Px).HasColumnName("PX");
            entity.Property(e => e.RechPx)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RechPX");
            entity.Property(e => e.RechercheArt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RechercheDoc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.RefExt)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Represent)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Representant)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Source)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Theme)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Transfert).HasColumnName("transfert");
            entity.Property(e => e.TypeAv)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS")
                .HasColumnName("TypeAV");
        });

        modelBuilder.Entity<DocumentBonCommande>(entity =>
        {
            entity.HasKey(e => e.UniqueId).HasName("PK_DocumentBonCommande_1");

            entity.ToTable("DocumentBonCommande", tb =>
                {
                    tb.HasTrigger("AFTERDelUpdDOCHisto");
                    tb.HasTrigger("AFTERINSERT");
                    tb.HasTrigger("AfterDeleteDBC");
                    tb.HasTrigger("AfterUpdateDBC");
                    tb.HasTrigger("DeletedDetailCommande");
                    tb.HasTrigger("ForInsertDBC");
                    tb.HasTrigger("OnInsertDBC");
                    tb.HasTrigger("OnUpdateDBC");
                });

            entity.HasIndex(e => e.DocTiers, "NonClusteredIndex-20161128-134210");

            entity.HasIndex(e => e.DocDate, "NonClusteredIndex-20200428-001054").IsDescending();

            entity.HasIndex(e => e.DocType, "NonClusteredIndex-20200428-001118");

            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.DocAcompte).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocCloture).HasColumnType("smalldatetime");
            entity.Property(e => e.DocCommentaire)
                .UseCollation("French_CI_AI")
                .HasColumnType("ntext");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDateEcheance).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDest)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocDevise)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocEtatBp).HasColumnName("DocEtatBP");
            entity.Property(e => e.DocEtatBp1).HasColumnName("DocEtatBP1");
            entity.Property(e => e.DocHliv).HasColumnName("DocHLiv");
            entity.Property(e => e.DocLancement).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMatricule)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocMntLettre)
                .HasMaxLength(500)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocMontant).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocNetaPayer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocNptiers)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("DocNPTiers");
            entity.Property(e => e.DocNumDoc)
                .HasMaxLength(15)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocRefCaisse)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocRefExt).HasMaxLength(250);
            entity.Property(e => e.DocRepresentant).HasMaxLength(50);
            entity.Property(e => e.DocReste).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalRemise).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocTotalTva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalTVA");
            entity.Property(e => e.DocTxDeviseNew).HasColumnName("DocTxDeviseNEW");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocValFodec).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocValRem).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Ematricule)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MargeMinDoc).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Marque)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Modele).HasMaxLength(50);
            entity.Property(e => e.RefDev)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefSouDest)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefSouDest1)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Rmmatricule)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("RMMatricule");
            entity.Property(e => e.TimberFiscal).HasDefaultValue(false);
        });

        modelBuilder.Entity<DocumentBonCommande1>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.ToTable("DocumentBonCommande1");

            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.DocAcompte).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocCloture).HasColumnType("smalldatetime");
            entity.Property(e => e.DocCommentaire)
                .UseCollation("French_CI_AI")
                .HasColumnType("ntext");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDateEcheance).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDest)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocDevise)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocEtatBp).HasColumnName("DocEtatBP");
            entity.Property(e => e.DocHliv).HasColumnName("DocHLiv");
            entity.Property(e => e.DocLancement).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMatricule)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocMntLettre)
                .HasMaxLength(500)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocMontant).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocNetaPayer).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocNptiers)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("DocNPTiers");
            entity.Property(e => e.DocNumDoc)
                .HasMaxLength(15)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocRefCaisse)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocRefExt)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocRepresentant)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocReste).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalRemise).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocTotalTva)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DocTotalTVA");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocValRem).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Ematricule)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Lot)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Marque)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Modele)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.RefDev)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefSouDest)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Rmmatricule)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("RMMatricule");
        });

        modelBuilder.Entity<DocumentBonCommandeHistorique>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DocumentBonCommandeHistorique");

            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ActionDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocAcompte).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocCloture).HasColumnType("smalldatetime");
            entity.Property(e => e.DocCommentaire).HasMaxLength(300);
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDateEcheance).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDest)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocDevise)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocEtatBp).HasColumnName("DocEtatBP");
            entity.Property(e => e.DocEtatBp1).HasColumnName("DocEtatBP1");
            entity.Property(e => e.DocHliv).HasColumnName("DocHLiv");
            entity.Property(e => e.DocLancement).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMatricule)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocMntLettre).HasMaxLength(500);
            entity.Property(e => e.DocMontant).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocNetaPayer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocNptiers)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("DocNPTiers");
            entity.Property(e => e.DocNumDoc).HasMaxLength(15);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocRefCaisse)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocRefExt).HasMaxLength(250);
            entity.Property(e => e.DocRepresentant).HasMaxLength(50);
            entity.Property(e => e.DocReste).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocTiers).HasMaxLength(20);
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalRemise).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocTotalTva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalTVA");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocValFodec).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocValRem).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Ematricule)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Marque)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Modele).HasMaxLength(50);
            entity.Property(e => e.RefDev)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RefSouDest)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RefSouDest1)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Rmmatricule)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("RMMatricule");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<DocumentBonCommandeHistorique2021>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DocumentBonCommandeHistorique2021");

            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ActionDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocAcompte).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocCloture).HasColumnType("smalldatetime");
            entity.Property(e => e.DocCommentaire).HasMaxLength(300);
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDateEcheance).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDest)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocDevise)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocEtatBp).HasColumnName("DocEtatBP");
            entity.Property(e => e.DocEtatBp1).HasColumnName("DocEtatBP1");
            entity.Property(e => e.DocHliv).HasColumnName("DocHLiv");
            entity.Property(e => e.DocLancement).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMatricule)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocMntLettre).HasMaxLength(500);
            entity.Property(e => e.DocMontant).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocNetaPayer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocNptiers)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("DocNPTiers");
            entity.Property(e => e.DocNumDoc).HasMaxLength(15);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocRefCaisse)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocRefExt).HasMaxLength(250);
            entity.Property(e => e.DocRepresentant).HasMaxLength(50);
            entity.Property(e => e.DocReste).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocTiers).HasMaxLength(20);
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalRemise).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocTotalTva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalTVA");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocValFodec).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocValRem).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Ematricule)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Marque)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Modele).HasMaxLength(50);
            entity.Property(e => e.RefDev)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RefSouDest)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RefSouDest1)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Rmmatricule)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("RMMatricule");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<DocumentBonCommandeHistorique2022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DocumentBonCommandeHistorique2022");

            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ActionDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocAcompte).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocCloture).HasColumnType("smalldatetime");
            entity.Property(e => e.DocCommentaire).HasMaxLength(300);
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDateEcheance).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDest)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocDevise)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocEtatBp).HasColumnName("DocEtatBP");
            entity.Property(e => e.DocEtatBp1).HasColumnName("DocEtatBP1");
            entity.Property(e => e.DocHliv).HasColumnName("DocHLiv");
            entity.Property(e => e.DocLancement).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMatricule)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocMntLettre).HasMaxLength(500);
            entity.Property(e => e.DocMontant).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocNetaPayer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocNptiers)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("DocNPTiers");
            entity.Property(e => e.DocNumDoc).HasMaxLength(15);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocRefCaisse)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocRefExt).HasMaxLength(250);
            entity.Property(e => e.DocRepresentant).HasMaxLength(50);
            entity.Property(e => e.DocReste).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocTiers).HasMaxLength(20);
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalRemise).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocTotalTva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalTVA");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocValFodec).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocValRem).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Ematricule)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Marque)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Modele).HasMaxLength(50);
            entity.Property(e => e.RefDev)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RefSouDest)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RefSouDest1)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Rmmatricule)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("RMMatricule");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<DocumentBonCommandeTempDelete>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DocumentBonCommandeTempDelete");

            entity.Property(e => e.RefSouDest)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.RefSouDest1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<DocumentBonDeCommandeTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DocumentBonDeCommandeTemp");

            entity.Property(e => e.DocAnnee)
                .HasMaxLength(255)
                .UseCollation("French_CI_AI")
                .HasColumnName("(DocAnnee)");
            entity.Property(e => e.DocDate)
                .HasColumnType("datetime")
                .HasColumnName("(DocDate)");
            entity.Property(e => e.DocDevise)
                .HasMaxLength(255)
                .HasColumnName("(DocDevise)");
            entity.Property(e => e.DocMontant).HasColumnName("(DocMontant)");
            entity.Property(e => e.DocRef).HasColumnName("(DocRef)");
            entity.Property(e => e.DocRefExt).HasColumnName("(DocRefExt)");
            entity.Property(e => e.DocRepresentant).HasColumnName("(DocRepresentant)");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(255)
                .UseCollation("French_CI_AI")
                .HasColumnName("(DocTiers)");
            entity.Property(e => e.DocTotalHt).HasColumnName("(DocTotalHT)");
            entity.Property(e => e.DocTotalRemise).HasColumnName("(DocTotalRemise)");
            entity.Property(e => e.DocTotalTva).HasColumnName("(DocTotalTVA)");
            entity.Property(e => e.DocType)
                .HasMaxLength(255)
                .UseCollation("French_CI_AI")
                .HasColumnName("(DocType)");
            entity.Property(e => e.F10).HasMaxLength(255);
            entity.Property(e => e.F100).HasMaxLength(255);
            entity.Property(e => e.F101).HasMaxLength(255);
            entity.Property(e => e.F102).HasMaxLength(255);
            entity.Property(e => e.F104).HasMaxLength(255);
            entity.Property(e => e.F105).HasMaxLength(255);
            entity.Property(e => e.F12).HasMaxLength(255);
            entity.Property(e => e.F14).HasColumnType("datetime");
            entity.Property(e => e.F19).HasMaxLength(255);
            entity.Property(e => e.F20).HasMaxLength(255);
            entity.Property(e => e.F21).HasMaxLength(255);
            entity.Property(e => e.F22).HasColumnType("datetime");
            entity.Property(e => e.F24).HasMaxLength(255);
            entity.Property(e => e.F26).HasMaxLength(255);
            entity.Property(e => e.F27).HasMaxLength(255);
            entity.Property(e => e.F29).HasMaxLength(255);
            entity.Property(e => e.F46).HasMaxLength(255);
            entity.Property(e => e.F47).HasMaxLength(255);
            entity.Property(e => e.F49)
                .HasMaxLength(255)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.F50)
                .HasMaxLength(255)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.F52).HasMaxLength(255);
            entity.Property(e => e.F53).HasColumnType("datetime");
            entity.Property(e => e.F54).HasMaxLength(255);
            entity.Property(e => e.F55).HasMaxLength(255);
            entity.Property(e => e.F56).HasMaxLength(255);
            entity.Property(e => e.F57).HasMaxLength(255);
            entity.Property(e => e.F59).HasMaxLength(255);
            entity.Property(e => e.F6).HasMaxLength(255);
            entity.Property(e => e.F60).HasMaxLength(255);
            entity.Property(e => e.F64).HasMaxLength(255);
            entity.Property(e => e.F65).HasColumnType("datetime");
            entity.Property(e => e.F66).HasColumnType("datetime");
            entity.Property(e => e.F67).HasMaxLength(255);
            entity.Property(e => e.F68).HasMaxLength(255);
            entity.Property(e => e.F7).HasColumnType("datetime");
            entity.Property(e => e.F75).HasMaxLength(255);
            entity.Property(e => e.F76).HasMaxLength(255);
            entity.Property(e => e.F77).HasMaxLength(255);
            entity.Property(e => e.F78).HasMaxLength(255);
            entity.Property(e => e.F79).HasColumnType("datetime");
            entity.Property(e => e.F8).HasMaxLength(255);
            entity.Property(e => e.F80).HasColumnType("datetime");
            entity.Property(e => e.F81).HasMaxLength(255);
            entity.Property(e => e.F82).HasMaxLength(255);
            entity.Property(e => e.F84).HasMaxLength(255);
            entity.Property(e => e.F86).HasMaxLength(255);
            entity.Property(e => e.F88).HasMaxLength(255);
            entity.Property(e => e.F9).HasMaxLength(255);
            entity.Property(e => e.F91).HasMaxLength(255);
            entity.Property(e => e.F93).HasMaxLength(255);
            entity.Property(e => e.F94).HasMaxLength(255);
            entity.Property(e => e.F95).HasMaxLength(255);
            entity.Property(e => e.F96).HasMaxLength(255);
            entity.Property(e => e.F97).HasMaxLength(255);
            entity.Property(e => e.F98).HasMaxLength(255);
            entity.Property(e => e.F99).HasMaxLength(255);
        });

        modelBuilder.Entity<DocumentControl>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DocumentControl");

            entity.Property(e => e.CodeDoc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Designation).HasMaxLength(255);
        });

        modelBuilder.Entity<DocumentControlDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DocumentControlDetail");

            entity.Property(e => e.CodeDoc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Commentaire).HasMaxLength(255);
            entity.Property(e => e.Designation).HasMaxLength(255);
            entity.Property(e => e.Max)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Min)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<DocumentCritere>(entity =>
        {
            entity.HasKey(e => e.CritNom);

            entity.ToTable("DocumentCritere");

            entity.Property(e => e.CritNom)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.CritDocument)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.CritRequete)
                .HasMaxLength(255)
                .IsFixedLength();
        });

        modelBuilder.Entity<DocumentDc>(entity =>
        {
            entity.HasKey(e => new { e.DocRef, e.DocType, e.NParametre });

            entity.ToTable("DocumentDC");

            entity.Property(e => e.DocRef)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NParametre)
                .HasMaxLength(250)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("N_Parametre");
            entity.Property(e => e.ValParametre)
                .HasMaxLength(250)
                .UseCollation("French_CI_AI")
                .HasColumnName("Val_Parametre");
        });

        modelBuilder.Entity<DocumentDetailCommande>(entity =>
        {
            entity.HasKey(e => new { e.UniqueId, e.DocType, e.DocRef, e.DocArt, e.DocLong, e.DocLarg });

            entity.ToTable("DocumentDetailCommande", tb =>
                {
                    tb.HasTrigger("AFTERDelUpdDETAILDOCHisto");
                    tb.HasTrigger("AfterDeleteDDC");
                    tb.HasTrigger("AfterInsertDDC");
                    tb.HasTrigger("AfterUpdateDDC");
                    tb.HasTrigger("InsertedDetailCommande");
                    tb.HasTrigger("MiseAJourStockDeletBSBE");
                });

            entity.HasIndex(e => e.DocArt, "IX_Article_DocumentDetailCommande");

            entity.HasIndex(e => e.DocType, "IX_DocType_DocumentDetailCommande");

            entity.HasIndex(e => e.IdligneExt, "IX_IdLnExt_DocumentDetailCommande").IsDescending();

            entity.HasIndex(e => e.ParentRef, "IX_ParentRef_DocumentDetailCommande");

            entity.HasIndex(e => e.UniqueIddoc, "IX_UniqueIdDoc_DocumentDetailCommande").IsDescending();

            entity.Property(e => e.UniqueId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UniqueID");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.AqteStock).HasColumnName("AQteStock");
            entity.Property(e => e.Col1)
                .HasMaxLength(50)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("COL1");
            entity.Property(e => e.Col2)
                .HasMaxLength(50)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("COL2");
            entity.Property(e => e.Col3)
                .HasMaxLength(50)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("COL3");
            entity.Property(e => e.Col4)
                .HasMaxLength(50)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("COL4");
            entity.Property(e => e.Col5).HasColumnName("COL5");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.DocArtDesignation)
                .HasMaxLength(250)
                .IsFixedLength();
            entity.Property(e => e.DocCommentaire).HasMaxLength(250);
            entity.Property(e => e.DocPrevient)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DocPRevient");
            entity.Property(e => e.DocPunit).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocTotalFodec).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalTtc)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DocTotalTTC");
            entity.Property(e => e.DocTotalTva).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.IdligneExt).HasColumnName("IDLigneExt");
            entity.Property(e => e.Lot)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ParentRef)
                .HasMaxLength(20)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueIddoc).HasColumnName("UniqueIDDoc");

            entity.HasOne(d => d.DocArtNavigation).WithMany(p => p.DocumentDetailCommandes)
                .HasForeignKey(d => d.DocArt)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DocumentDetailCommande_Article1");

            entity.HasOne(d => d.UniqueIddocNavigation).WithMany(p => p.DocumentDetailCommandes)
                .HasForeignKey(d => d.UniqueIddoc)
                .HasConstraintName("FK_DocumentDetailCommande_DocumentBonCommande");
        });

        modelBuilder.Entity<DocumentDetailCommandeHistorique>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DocumentDetailCommandeHistorique");

            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ActionDate).HasColumnType("smalldatetime");
            entity.Property(e => e.AqteStock).HasColumnName("AQteStock");
            entity.Property(e => e.Col1)
                .HasMaxLength(50)
                .HasColumnName("COL1");
            entity.Property(e => e.Col2)
                .HasMaxLength(50)
                .HasColumnName("COL2");
            entity.Property(e => e.Col3)
                .HasMaxLength(50)
                .HasColumnName("COL3");
            entity.Property(e => e.Col4)
                .HasMaxLength(50)
                .HasColumnName("COL4");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.DocArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocArtDesignation)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.DocCommentaire).HasMaxLength(250);
            entity.Property(e => e.DocPrevient)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DocPRevient");
            entity.Property(e => e.DocPunit).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocTotalFodec).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalTtc)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DocTotalTTC");
            entity.Property(e => e.DocTotalTva).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdligneExt).HasColumnName("IDLigneExt");
            entity.Property(e => e.Lot).HasMaxLength(50);
            entity.Property(e => e.ParentRef)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.UniqueIddoc).HasColumnName("UniqueIDDoc");
        });

        modelBuilder.Entity<DocumentDetailCommandetemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DocumentDetailCommandetemp");

            entity.Property(e => e.AssTaxSup).HasMaxLength(255);
            entity.Property(e => e.AssTpf1)
                .HasMaxLength(255)
                .HasColumnName("AssTPF1");
            entity.Property(e => e.AssTpf2)
                .HasMaxLength(255)
                .HasColumnName("AssTPF2");
            entity.Property(e => e.AssTransp).HasMaxLength(255);
            entity.Property(e => e.Bloque)
                .HasMaxLength(255)
                .HasColumnName("bloque");
            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("code");
            entity.Property(e => e.Codepaquet)
                .HasMaxLength(255)
                .HasColumnName("codepaquet");
            entity.Property(e => e.Codeqte)
                .HasMaxLength(255)
                .HasColumnName("codeqte");
            entity.Property(e => e.Commentaire)
                .HasMaxLength(255)
                .HasColumnName("commentaire");
            entity.Property(e => e.Dim1n)
                .HasMaxLength(255)
                .HasColumnName("dim1n");
            entity.Property(e => e.Documentlot).HasColumnName("documentlot");
            entity.Property(e => e.Dprixa).HasColumnName("dprixa");
            entity.Property(e => e.Etat)
                .HasMaxLength(255)
                .HasColumnName("etat");
            entity.Property(e => e.FamDocOrg).HasMaxLength(255);
            entity.Property(e => e.Gratuit)
                .HasMaxLength(255)
                .HasColumnName("gratuit");
            entity.Property(e => e.IdDc).HasColumnName("IdDC");
            entity.Property(e => e.IdDocSerieOrg).HasMaxLength(255);
            entity.Property(e => e.IdTpf1).HasColumnName("IdTPF1");
            entity.Property(e => e.IdTpf2).HasColumnName("IdTPF2");
            entity.Property(e => e.IdTva).HasColumnName("IdTVA");
            entity.Property(e => e.Iddocserie)
                .HasMaxLength(255)
                .UseCollation("French_CI_AI")
                .HasColumnName("iddocserie");
            entity.Property(e => e.Iddocserielot)
                .HasMaxLength(255)
                .HasColumnName("iddocserielot");
            entity.Property(e => e.Idpromotion).HasColumnName("idpromotion");
            entity.Property(e => e.Intitule).HasMaxLength(255);
            entity.Property(e => e.Libelle)
                .HasMaxLength(255)
                .HasColumnName("libelle");
            entity.Property(e => e.LignenumOrg).HasColumnName("lignenumOrg");
            entity.Property(e => e.Livdate).HasColumnType("datetime");
            entity.Property(e => e.MajbcomBrsurbl)
                .HasMaxLength(255)
                .HasColumnName("majbcom_brsurbl");
            entity.Property(e => e.ModeSaisie).HasMaxLength(255);
            entity.Property(e => e.Mtasstaxsup).HasColumnName("mtasstaxsup");
            entity.Property(e => e.Mtfrais).HasColumnName("mtfrais");
            entity.Property(e => e.Mtfraisunitaire)
                .HasMaxLength(255)
                .HasColumnName("mtfraisunitaire");
            entity.Property(e => e.MtfraisunitaireEffectif)
                .HasMaxLength(255)
                .HasColumnName("mtfraisunitaire_effectif");
            entity.Property(e => e.MthtDev).HasColumnName("Mtht_Dev");
            entity.Property(e => e.MtremDev).HasColumnName("Mtrem_Dev");
            entity.Property(e => e.MtremVentile)
                .HasMaxLength(255)
                .HasColumnName("mtrem_ventile");
            entity.Property(e => e.MttransportDev).HasColumnName("Mttransport_Dev");
            entity.Property(e => e.Mttvafrais).HasColumnName("mttvafrais");
            entity.Property(e => e.NbrpieceExe).HasColumnName("nbrpiece_exe");
            entity.Property(e => e.Numlignepaquet).HasColumnName("numlignepaquet");
            entity.Property(e => e.Numlignepaquetret).HasColumnName("numlignepaquetret");
            entity.Property(e => e.Numordre).HasColumnName("numordre");
            entity.Property(e => e.Pmpa).HasColumnName("pmpa");
            entity.Property(e => e.Pqglobal)
                .HasMaxLength(255)
                .HasColumnName("pqglobal");
            entity.Property(e => e.Prefixe)
                .HasMaxLength(255)
                .UseCollation("French_CI_AI")
                .HasColumnName("prefixe");
            entity.Property(e => e.PrefixeOrg).HasMaxLength(255);
            entity.Property(e => e.Prefixelot)
                .HasMaxLength(255)
                .HasColumnName("prefixelot");
            entity.Property(e => e.Prixrevient).HasColumnName("prixrevient");
            entity.Property(e => e.Prixrevientc)
                .HasMaxLength(255)
                .HasColumnName("prixrevientc");
            entity.Property(e => e.PrixrevientcEffectif)
                .HasMaxLength(255)
                .HasColumnName("prixrevientc_effectif");
            entity.Property(e => e.Prixuvtec)
                .HasMaxLength(255)
                .HasColumnName("prixuvtec");
            entity.Property(e => e.PrixuvtecEffectif)
                .HasMaxLength(255)
                .HasColumnName("prixuvtec_effectif");
            entity.Property(e => e.Prixuvted)
                .HasMaxLength(255)
                .HasColumnName("prixuvted");
            entity.Property(e => e.Pu).HasColumnName("PU");
            entity.Property(e => e.PuDev).HasColumnName("Pu_Dev");
            entity.Property(e => e.PuEffectif).HasColumnName("pu_effectif");
            entity.Property(e => e.PuOrg).HasColumnName("pu_org");
            entity.Property(e => e.Puttc).HasColumnName("puttc");
            entity.Property(e => e.Qte).HasColumnName("qte");
            entity.Property(e => e.QteExe).HasColumnName("qte_exe");
            entity.Property(e => e.QteRectif).HasColumnName("qte_rectif");
            entity.Property(e => e.RefC)
                .HasMaxLength(255)
                .UseCollation("French_CI_AI")
                .HasColumnName("Ref_C");
            entity.Property(e => e.ReglePrix).HasMaxLength(255);
            entity.Property(e => e.RegleQte).HasMaxLength(255);
            entity.Property(e => e.TauxDc).HasColumnName("TauxDC");
            entity.Property(e => e.TauxTpf1).HasColumnName("TauxTPF1");
            entity.Property(e => e.TauxTpf2).HasColumnName("TauxTPF2");
            entity.Property(e => e.TauxTva).HasColumnName("TauxTVA");
            entity.Property(e => e.Tauxfrais).HasColumnName("tauxfrais");
            entity.Property(e => e.Tauxmajore).HasColumnName("tauxmajore");
            entity.Property(e => e.Txmarge).HasColumnName("txmarge");
            entity.Property(e => e.TxmargeEffectif).HasColumnName("txmarge_effectif");
            entity.Property(e => e.Txmarged)
                .HasMaxLength(255)
                .HasColumnName("txmarged");
            entity.Property(e => e.Txtvafrais).HasColumnName("txtvafrais");
            entity.Property(e => e.Unite).HasMaxLength(255);
        });

        modelBuilder.Entity<DocumentDetailMontant>(entity =>
        {
            entity.HasKey(e => new { e.DocType, e.DocRef, e.DocTiers });

            entity.ToTable("DocumentDetailMontant");

            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.DocRef)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.DocTiers)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.DocNetaPayer).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<DocumentOm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("DocumentOM");

            entity.Property(e => e.Adesignation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("ADesignation");
            entity.Property(e => e.DocArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocDateEcheance).HasColumnType("smalldatetime");
            entity.Property(e => e.DocRef)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Expr1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueIddoc).HasColumnName("UniqueIDDoc");
        });

        modelBuilder.Entity<DocumentdetailCommandeHistorique2022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DocumentdetailCommandeHistorique2022");

            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ActionDate).HasColumnType("smalldatetime");
            entity.Property(e => e.AqteStock).HasColumnName("AQteStock");
            entity.Property(e => e.Col1)
                .HasMaxLength(50)
                .HasColumnName("COL1");
            entity.Property(e => e.Col2)
                .HasMaxLength(50)
                .HasColumnName("COL2");
            entity.Property(e => e.Col3)
                .HasMaxLength(50)
                .HasColumnName("COL3");
            entity.Property(e => e.Col4)
                .HasMaxLength(50)
                .HasColumnName("COL4");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.DocArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocArtDesignation)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.DocCommentaire).HasMaxLength(250);
            entity.Property(e => e.DocPrevient)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DocPRevient");
            entity.Property(e => e.DocPunit).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocTotalFodec).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalTtc)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DocTotalTTC");
            entity.Property(e => e.DocTotalTva).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdligneExt).HasColumnName("IDLigneExt");
            entity.Property(e => e.Lot).HasMaxLength(50);
            entity.Property(e => e.ParentRef)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.UniqueIddoc).HasColumnName("UniqueIDDoc");
        });

        modelBuilder.Entity<Dso>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DSO");

            entity.Property(e => e.Cattc)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("CATTC");
            entity.Property(e => e.Creance).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.CreanceFc)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("creanceFC");
            entity.Property(e => e.DateDso)
                .HasMaxLength(10)
                .HasColumnName("DateDSO");
            entity.Property(e => e.Dso1)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DSO");
            entity.Property(e => e.Impaye)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("impaye");
            entity.Property(e => e.Portefeuille).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<Dsoachat>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DSOAchat");

            entity.Property(e => e.Cattc)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("CATTC");
            entity.Property(e => e.Creance).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.CreanceFc)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("creanceFC");
            entity.Property(e => e.DateDso)
                .HasMaxLength(10)
                .HasColumnName("DateDSO");
            entity.Property(e => e.Dso)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DSO");
            entity.Property(e => e.Impaye)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("impaye");
            entity.Property(e => e.Portefeuille).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<EcartTransfert>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Ecart_Transfert");

            entity.Property(e => e.DocArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Ematricule)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("EMatricule");
            entity.Property(e => e.QteEntree).HasColumnName("qteEntree");
        });

        modelBuilder.Entity<Edition>(entity =>
        {
            entity.HasKey(e => e.EdNom);

            entity.ToTable("Edition");

            entity.Property(e => e.EdNom)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.EdNomRtp)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.EdType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Menu).HasMaxLength(50);
            entity.Property(e => e.Ordre).HasMaxLength(50);
            entity.Property(e => e.Smenu)
                .HasMaxLength(50)
                .HasColumnName("SMenu");
            entity.Property(e => e.UserEdition).HasMaxLength(250);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Ematricule);

            entity.ToTable("Employee", tb => tb.HasTrigger("AFTERDeleteE"));

            entity.HasIndex(e => e.Ematricule, "IX_Employee");

            entity.HasIndex(e => e.CodeTiers, "UC_CodeTiers").IsUnique();

            entity.Property(e => e.Ematricule)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("EMatricule");
            entity.Property(e => e.CodeTiers)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Eassurance)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("EAssurance");
            entity.Property(e => e.Ebadge)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("EBadge");
            entity.Property(e => e.Ebanque)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("EBanque");
            entity.Property(e => e.EchefFamille).HasColumnName("EChefFamille");
            entity.Property(e => e.Ecin)
                .HasMaxLength(15)
                .UseCollation("French_CI_AI")
                .HasColumnName("ECIN");
            entity.Property(e => e.Ecinconjoint)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ECINConjoint");
            entity.Property(e => e.EcycleTravail)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ECycleTravail");
            entity.Property(e => e.EdateAssurance)
                .HasColumnType("smalldatetime")
                .HasColumnName("EDateAssurance");
            entity.Property(e => e.EdateMariage)
                .HasColumnType("smalldatetime")
                .HasColumnName("EDateMariage");
            entity.Property(e => e.EdateNaiss)
                .HasColumnType("smalldatetime")
                .HasColumnName("EDateNaiss");
            entity.Property(e => e.Efonction)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("EFonction");
            entity.Property(e => e.EmodePay)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("EModePay");
            entity.Property(e => e.Enationalite)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ENationalite");
            entity.Property(e => e.Enom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("ENom");
            entity.Property(e => e.EnomConjoint)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ENomConjoint");
            entity.Property(e => e.EnombreCharge).HasColumnName("ENombreCharge");
            entity.Property(e => e.EnombreEnfant).HasColumnName("ENombreEnfant");
            entity.Property(e => e.EnumAssurance)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ENumAssurance");
            entity.Property(e => e.EnumCompte)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ENumCompte");
            entity.Property(e => e.Epassport)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("EPassport");
            entity.Property(e => e.Eprenom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("EPrenom");
            entity.Property(e => e.Esexe)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ESexe");
            entity.Property(e => e.EsituationFam)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ESituationFam");

            entity.HasOne(d => d.EmatriculeNavigation).WithOne(p => p.Employee)
                .HasForeignKey<Employee>(d => d.Ematricule)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_EMatricule");
        });

        modelBuilder.Entity<EnCoursLcaAe3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EnCoursLCA_AE3");

            entity.Property(e => e.AqteStock)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("AQteStock");
            entity.Property(e => e.Designation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalTtc)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DocTotalTTC");
            entity.Property(e => e.Exc).HasColumnName("exc");
            entity.Property(e => e.Fournisseur)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Punit).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Réference)
                .HasMaxLength(24)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<EncValideCarnet>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EncValideCarnet");
        });

        modelBuilder.Entity<Encaissement>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Encaissement");

            entity.Property(e => e.Encourvent)
                .HasMaxLength(255)
                .HasColumnName("encourvent");
            entity.Property(e => e.IdDocSerieC).HasMaxLength(255);
            entity.Property(e => e.IdDocSerieD).HasMaxLength(255);
            entity.Property(e => e.Lignec).HasColumnName("lignec");
            entity.Property(e => e.Ligned).HasColumnName("ligned");
            entity.Property(e => e.Montantdev)
                .HasMaxLength(255)
                .HasColumnName("montantdev");
            entity.Property(e => e.Poidsiniv)
                .HasMaxLength(255)
                .HasColumnName("poidsiniv");
            entity.Property(e => e.PrefixeC)
                .HasMaxLength(255)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.PrefixeD)
                .HasMaxLength(255)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Seriec)
                .HasMaxLength(255)
                .HasColumnName("seriec");
            entity.Property(e => e.Seried)
                .HasMaxLength(255)
                .HasColumnName("seried");
        });

        modelBuilder.Entity<EncaissementDecaissement>(entity =>
        {
            entity.HasKey(e => e.UniqueIdEncDec);

            entity.ToTable("EncaissementDecaissement", tb =>
                {
                    tb.HasTrigger("AFTERDelUpdEncDecHisto");
                    tb.HasTrigger("AFTERInsertEncDec");
                    tb.HasTrigger("DeleteEncaissementDecaissement");
                    tb.HasTrigger("ForUpdateEncDec");
                    tb.HasTrigger("InsertEncaissementDecaissement");
                });

            entity.HasIndex(e => new { e.DateR, e.DateI }, "date").IsDescending();

            entity.HasIndex(e => e.DocTiers, "doctiers");

            entity.HasIndex(e => e.DocType, "doctype");

            entity.HasIndex(e => e.Npieces, "npieces").IsDescending();

            entity.HasIndex(e => e.NumEncAffec, "numencaffec").IsDescending();

            entity.HasIndex(e => e.TypeEncDec, "typeencdec");

            entity.HasIndex(e => e.UniqueId, "uniqueid").IsDescending();

            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Breception)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Caisse)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Commentaire).HasMaxLength(250);
            entity.Property(e => e.DateAnnuler).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch2).HasColumnType("smalldatetime");
            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateP).HasColumnType("smalldatetime");
            entity.Property(e => e.DateR).HasColumnType("smalldatetime");
            entity.Property(e => e.DateV).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMntLettre).HasMaxLength(500);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Docref1).HasMaxLength(20);
            entity.Property(e => e.Etat).HasColumnType("smalldatetime");
            entity.Property(e => e.Imput1)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("imput1");
            entity.Property(e => e.Imputation)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MontantR).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.NumEncDec2).HasMaxLength(20);
            entity.Property(e => e.Pdecommentaire)
                .HasMaxLength(250)
                .HasColumnName("PDECommentaire");
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Rib)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("RIB");
            entity.Property(e => e.Rib1).HasMaxLength(100);
            entity.Property(e => e.Ribp)
                .HasMaxLength(100)
                .HasColumnName("RIBP");
            entity.Property(e => e.Trc).HasColumnName("TRC");
            entity.Property(e => e.TypeEncDec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.VisibleEd)
                .HasDefaultValue(false)
                .HasColumnName("VisibleED");
        });

        modelBuilder.Entity<EncaissementDecaissement1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EncaissementDecaissement1");

            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Breception)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Caisse)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Commentaire).HasMaxLength(250);
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateP).HasColumnType("smalldatetime");
            entity.Property(e => e.DateR).HasColumnType("smalldatetime");
            entity.Property(e => e.DateV).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMntLettre).HasMaxLength(500);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Etat).HasColumnType("smalldatetime");
            entity.Property(e => e.Imputation)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MontantR).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.NumEncDec).ValueGeneratedOnAdd();
            entity.Property(e => e.Pdecommentaire)
                .HasMaxLength(250)
                .HasColumnName("PDECommentaire");
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Rib)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("RIB");
            entity.Property(e => e.TypeEncDec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.VisibleEd)
                .HasDefaultValue(false)
                .HasColumnName("VisibleED");
        });

        modelBuilder.Entity<EncaissementDecaissement29112020ModeregNullBk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EncaissementDecaissement_29112020_Modereg_NULL_BK");

            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Breception)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Caisse)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Commentaire).HasMaxLength(250);
            entity.Property(e => e.DateAnnuler).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch2).HasColumnType("smalldatetime");
            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateP).HasColumnType("smalldatetime");
            entity.Property(e => e.DateR).HasColumnType("smalldatetime");
            entity.Property(e => e.DateV).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMntLettre).HasMaxLength(500);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Docref1).HasMaxLength(20);
            entity.Property(e => e.Etat).HasColumnType("smalldatetime");
            entity.Property(e => e.Imput1)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("imput1");
            entity.Property(e => e.Imputation)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MontantR).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.NumEncDec2).HasMaxLength(20);
            entity.Property(e => e.Pdecommentaire)
                .HasMaxLength(250)
                .HasColumnName("PDECommentaire");
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Rib)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("RIB");
            entity.Property(e => e.Rib1).HasMaxLength(100);
            entity.Property(e => e.Ribp)
                .HasMaxLength(100)
                .HasColumnName("RIBP");
            entity.Property(e => e.Trc).HasColumnName("TRC");
            entity.Property(e => e.TypeEncDec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.UniqueIdEncDec).ValueGeneratedOnAdd();
            entity.Property(e => e.VisibleEd).HasColumnName("VisibleED");
        });

        modelBuilder.Entity<EncaissementDecaissement4111001179>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EncaissementDecaissement_4111001179");

            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Breception)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Caisse)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Commentaire).HasMaxLength(250);
            entity.Property(e => e.DateAnnuler).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch2).HasColumnType("smalldatetime");
            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateP).HasColumnType("smalldatetime");
            entity.Property(e => e.DateR).HasColumnType("smalldatetime");
            entity.Property(e => e.DateV).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMntLettre).HasMaxLength(500);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Docref1).HasMaxLength(20);
            entity.Property(e => e.Etat).HasColumnType("smalldatetime");
            entity.Property(e => e.Imput1)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("imput1");
            entity.Property(e => e.Imputation)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MontantR).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.NumEncDec2).HasMaxLength(20);
            entity.Property(e => e.Pdecommentaire)
                .HasMaxLength(250)
                .HasColumnName("PDECommentaire");
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Rib)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("RIB");
            entity.Property(e => e.Rib1).HasMaxLength(100);
            entity.Property(e => e.Ribp)
                .HasMaxLength(100)
                .HasColumnName("RIBP");
            entity.Property(e => e.Trc).HasColumnName("TRC");
            entity.Property(e => e.TypeEncDec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.UniqueIdEncDec).ValueGeneratedOnAdd();
            entity.Property(e => e.VisibleEd).HasColumnName("VisibleED");
        });

        modelBuilder.Entity<EncaissementDecaissementBk04022021>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EncaissementDecaissement_bk_04022021");

            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Breception)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Caisse)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Commentaire).HasMaxLength(250);
            entity.Property(e => e.DateAnnuler).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch2).HasColumnType("smalldatetime");
            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateP).HasColumnType("smalldatetime");
            entity.Property(e => e.DateR).HasColumnType("smalldatetime");
            entity.Property(e => e.DateV).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMntLettre).HasMaxLength(500);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Docref1).HasMaxLength(20);
            entity.Property(e => e.Etat).HasColumnType("smalldatetime");
            entity.Property(e => e.Imput1)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("imput1");
            entity.Property(e => e.Imputation)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MontantR).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.NumEncDec2).HasMaxLength(20);
            entity.Property(e => e.Pdecommentaire)
                .HasMaxLength(250)
                .HasColumnName("PDECommentaire");
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Rib)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("RIB");
            entity.Property(e => e.Rib1).HasMaxLength(100);
            entity.Property(e => e.Ribp)
                .HasMaxLength(100)
                .HasColumnName("RIBP");
            entity.Property(e => e.Trc).HasColumnName("TRC");
            entity.Property(e => e.TypeEncDec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.UniqueIdEncDec).ValueGeneratedOnAdd();
            entity.Property(e => e.VisibleEd).HasColumnName("VisibleED");
        });

        modelBuilder.Entity<EncaissementDecaissementHistorique>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EncaissementDecaissementHistorique");

            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ActionDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Breception)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Caisse)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Commentaire).HasMaxLength(250);
            entity.Property(e => e.DateAnnuler).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch2).HasColumnType("smalldatetime");
            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateP).HasColumnType("smalldatetime");
            entity.Property(e => e.DateR).HasColumnType("smalldatetime");
            entity.Property(e => e.DateV).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMntLettre).HasMaxLength(500);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Etat).HasColumnType("smalldatetime");
            entity.Property(e => e.Imput1)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("imput1");
            entity.Property(e => e.Imputation)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MontantR).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Pdecommentaire)
                .HasMaxLength(250)
                .HasColumnName("PDECommentaire");
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Rib)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RIB");
            entity.Property(e => e.Ribp)
                .HasMaxLength(100)
                .HasColumnName("RIBP");
            entity.Property(e => e.TypeEncDec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.VisibleEd).HasColumnName("VisibleED");
        });

        modelBuilder.Entity<EncaissementDecaissementHistorique2021>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EncaissementDecaissementHistorique2021");

            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ActionDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Breception)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Caisse)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Commentaire).HasMaxLength(250);
            entity.Property(e => e.DateAnnuler).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch2).HasColumnType("smalldatetime");
            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateP).HasColumnType("smalldatetime");
            entity.Property(e => e.DateR).HasColumnType("smalldatetime");
            entity.Property(e => e.DateV).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMntLettre).HasMaxLength(500);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Etat).HasColumnType("smalldatetime");
            entity.Property(e => e.Imput1)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("imput1");
            entity.Property(e => e.Imputation)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MontantR).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Pdecommentaire)
                .HasMaxLength(250)
                .HasColumnName("PDECommentaire");
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Rib)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RIB");
            entity.Property(e => e.Ribp)
                .HasMaxLength(100)
                .HasColumnName("RIBP");
            entity.Property(e => e.TypeEncDec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.VisibleEd).HasColumnName("VisibleED");
        });

        modelBuilder.Entity<EncaissementDecaissementHistorique2022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EncaissementDecaissementHistorique2022");

            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ActionDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Breception)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Caisse)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Commentaire).HasMaxLength(250);
            entity.Property(e => e.DateAnnuler).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch2).HasColumnType("smalldatetime");
            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateP).HasColumnType("smalldatetime");
            entity.Property(e => e.DateR).HasColumnType("smalldatetime");
            entity.Property(e => e.DateV).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMntLettre).HasMaxLength(500);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Etat).HasColumnType("smalldatetime");
            entity.Property(e => e.Imput1)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("imput1");
            entity.Property(e => e.Imputation)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MontantR).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Pdecommentaire)
                .HasMaxLength(250)
                .HasColumnName("PDECommentaire");
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Rib)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RIB");
            entity.Property(e => e.Ribp)
                .HasMaxLength(100)
                .HasColumnName("RIBP");
            entity.Property(e => e.TypeEncDec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.VisibleEd).HasColumnName("VisibleED");
        });

        modelBuilder.Entity<EncaissementDecaissementHistoriqueAnve>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EncaissementDecaissementHistoriqueANVE");

            entity.Property(e => e.Action)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ActionDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Breception)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Caisse)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Commentaire).HasMaxLength(250);
            entity.Property(e => e.DateAnnuler).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch2).HasColumnType("smalldatetime");
            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateP).HasColumnType("smalldatetime");
            entity.Property(e => e.DateR).HasColumnType("smalldatetime");
            entity.Property(e => e.DateV).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMntLettre).HasMaxLength(500);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Etat).HasColumnType("smalldatetime");
            entity.Property(e => e.Imput1)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("imput1");
            entity.Property(e => e.Imputation)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MontantR).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Pdecommentaire)
                .HasMaxLength(250)
                .HasColumnName("PDECommentaire");
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Rib)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("RIB");
            entity.Property(e => e.Ribp)
                .HasMaxLength(100)
                .HasColumnName("RIBP");
            entity.Property(e => e.TypeEncDec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.VisibleEd).HasColumnName("VisibleED");
        });

        modelBuilder.Entity<EncaissementPerte>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("encaissementPerte");

            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Breception)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Caisse)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Commentaire).HasMaxLength(250);
            entity.Property(e => e.DateAnnuler).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch2).HasColumnType("smalldatetime");
            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateP).HasColumnType("smalldatetime");
            entity.Property(e => e.DateR).HasColumnType("smalldatetime");
            entity.Property(e => e.DateV).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMntLettre).HasMaxLength(500);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Etat).HasColumnType("smalldatetime");
            entity.Property(e => e.Imput1)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("imput1");
            entity.Property(e => e.Imputation)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MontantR).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Pdecommentaire)
                .HasMaxLength(250)
                .HasColumnName("PDECommentaire");
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Rib)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("RIB");
            entity.Property(e => e.Ribp)
                .HasMaxLength(100)
                .HasColumnName("RIBP");
            entity.Property(e => e.TypeEncDec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.UniqueIdEncDec).ValueGeneratedOnAdd();
            entity.Property(e => e.VisibleEd).HasColumnName("VisibleED");
        });

        modelBuilder.Entity<EncaissementdecaissementAnnulerBk11122020>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("encaissementdecaissement_Annuler_bk11122020");

            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Breception)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Caisse)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Commentaire).HasMaxLength(250);
            entity.Property(e => e.DateAnnuler).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch2).HasColumnType("smalldatetime");
            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateP).HasColumnType("smalldatetime");
            entity.Property(e => e.DateR).HasColumnType("smalldatetime");
            entity.Property(e => e.DateV).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMntLettre).HasMaxLength(500);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Docref1).HasMaxLength(20);
            entity.Property(e => e.Etat).HasColumnType("smalldatetime");
            entity.Property(e => e.Imput1)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("imput1");
            entity.Property(e => e.Imputation)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MontantR).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.NumEncDec2).HasMaxLength(20);
            entity.Property(e => e.Pdecommentaire)
                .HasMaxLength(250)
                .HasColumnName("PDECommentaire");
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Rib)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("RIB");
            entity.Property(e => e.Rib1).HasMaxLength(100);
            entity.Property(e => e.Ribp)
                .HasMaxLength(100)
                .HasColumnName("RIBP");
            entity.Property(e => e.Trc).HasColumnName("TRC");
            entity.Property(e => e.TypeEncDec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.UniqueIdEncDec).ValueGeneratedOnAdd();
            entity.Property(e => e.VisibleEd).HasColumnName("VisibleED");
        });

        modelBuilder.Entity<Encdecpetroga>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("encdecpetrogas");

            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Breception)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Caisse)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Commentaire).HasMaxLength(250);
            entity.Property(e => e.DateAnnuler).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch2).HasColumnType("smalldatetime");
            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateP).HasColumnType("smalldatetime");
            entity.Property(e => e.DateR).HasColumnType("smalldatetime");
            entity.Property(e => e.DateV).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMntLettre).HasMaxLength(500);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Docref1).HasMaxLength(20);
            entity.Property(e => e.Etat).HasColumnType("smalldatetime");
            entity.Property(e => e.Imput1)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("imput1");
            entity.Property(e => e.Imputation)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MontantR).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.NumEncDec2).HasMaxLength(20);
            entity.Property(e => e.Pdecommentaire)
                .HasMaxLength(250)
                .HasColumnName("PDECommentaire");
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Rib)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("RIB");
            entity.Property(e => e.Rib1).HasMaxLength(100);
            entity.Property(e => e.Ribp)
                .HasMaxLength(100)
                .HasColumnName("RIBP");
            entity.Property(e => e.Trc).HasColumnName("TRC");
            entity.Property(e => e.TypeEncDec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.UniqueIdEncDec).ValueGeneratedOnAdd();
            entity.Property(e => e.VisibleEd).HasColumnName("VisibleED");
        });

        modelBuilder.Entity<Encdecpetrogasgan>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("encdecpetrogasgan");

            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Breception)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Caisse)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Commentaire).HasMaxLength(250);
            entity.Property(e => e.DateAnnuler).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch2).HasColumnType("smalldatetime");
            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateP).HasColumnType("smalldatetime");
            entity.Property(e => e.DateR).HasColumnType("smalldatetime");
            entity.Property(e => e.DateV).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMntLettre).HasMaxLength(500);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Docref1).HasMaxLength(20);
            entity.Property(e => e.Etat).HasColumnType("smalldatetime");
            entity.Property(e => e.Imput1)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("imput1");
            entity.Property(e => e.Imputation)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MontantR).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.NumEncDec2).HasMaxLength(20);
            entity.Property(e => e.Pdecommentaire)
                .HasMaxLength(250)
                .HasColumnName("PDECommentaire");
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Rib)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("RIB");
            entity.Property(e => e.Rib1).HasMaxLength(100);
            entity.Property(e => e.Ribp)
                .HasMaxLength(100)
                .HasColumnName("RIBP");
            entity.Property(e => e.Trc).HasColumnName("TRC");
            entity.Property(e => e.TypeEncDec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.UniqueIdEncDec).ValueGeneratedOnAdd();
            entity.Property(e => e.VisibleEd).HasColumnName("VisibleED");
        });

        modelBuilder.Entity<EncoursClt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("encours_Clt");

            entity.Property(e => e.Cref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CRef");
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateRegImp).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDateEcheance).HasColumnType("smalldatetime");
            entity.Property(e => e.DocNetaPayer).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Expr1).HasColumnType("smalldatetime");
            entity.Property(e => e.Expr2)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Expr3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Expr4)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MontantR).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Reste).HasColumnType("decimal(20, 4)");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<EncoursCltBlockage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("encours_Clt_Blockage");

            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DateCréation)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DateEcheance)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DateRecouvrement)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocRepresentant)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.ModeRegTier)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Montantreglé).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.RefDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Reste).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Tiers)
                .HasMaxLength(202)
                .UseCollation("French_CI_AI")
                .HasColumnName("________________Tiers___________________");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<EncoursSfax>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Encours-Sfax");

            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateR).HasColumnType("smalldatetime");
            entity.Property(e => e.DateV).HasColumnType("smalldatetime");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Montant).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.NumP)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.TypeEncDec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
        });

        modelBuilder.Entity<EtatCaparClientFamilleArticle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EtatCAParClientFamilleArticle");

            entity.Property(e => e.Afamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AFamille");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Doctotalht).HasColumnName("doctotalht");
            entity.Property(e => e.Tiers)
                .HasMaxLength(224)
                .UseCollation("French_CI_AI")
                .HasColumnName("tiers");
        });

        modelBuilder.Entity<EtatDesFacturesExoTva>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EtatDesFacturesExoTVA");

            entity.Property(e => e.Cnom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CNom");
            entity.Property(e => e.Cprenom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CPrenom");
            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.Ctva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CTVA");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMontant).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocNetaPayer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalTva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalTVA");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefSouDest)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("type");
        });

        modelBuilder.Entity<EtatDesFacturesExoTvaOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EtatDesFacturesExoTVA_OLD");

            entity.Property(e => e.Cnom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CNom");
            entity.Property(e => e.Cprenom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CPrenom");
            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.Ctva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CTVA");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMontant).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocNetaPayer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalTva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalTVA");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Type)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("type");
        });

        modelBuilder.Entity<EtatInv>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Etat_INV");

            entity.Property(e => e.Abloque).HasColumnName("ABloque");
            entity.Property(e => e.Adesignation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("ADesignation");
            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.DateOuvInv).HasColumnType("datetime");
            entity.Property(e => e.Depot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.EtatInv1).HasColumnName("EtatInv");
            entity.Property(e => e.InvDate).HasColumnType("smalldatetime");
            entity.Property(e => e.QteAs)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Qte_AS");
            entity.Property(e => e.QteInv1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RefInv)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Sref)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("SRef");
        });

        modelBuilder.Entity<EtatListeImpayeLtk>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EtatListeImpaye_LTK");

            entity.Property(e => e.Col1)
                .HasMaxLength(250)
                .HasColumnName("col1");
            entity.Property(e => e.Col2)
                .HasMaxLength(250)
                .HasColumnName("col2");
            entity.Property(e => e.Col3)
                .HasMaxLength(250)
                .HasColumnName("col3");
            entity.Property(e => e.Col4)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("col4");
            entity.Property(e => e.Col5)
                .HasMaxLength(250)
                .HasColumnName("col5");
            entity.Property(e => e.Col6)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("col6");
            entity.Property(e => e.Col7)
                .HasMaxLength(250)
                .HasColumnName("col7");
            entity.Property(e => e.Col8)
                .HasMaxLength(250)
                .HasColumnName("col8");
            entity.Property(e => e.Col9)
                .HasMaxLength(250)
                .HasColumnName("col9");
            entity.Property(e => e.Uniqueid1)
                .HasMaxLength(250)
                .HasColumnName("uniqueid1");
        });

        modelBuilder.Entity<EtatSoldeClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EtatSoldeClient");

            entity.Property(e => e.DateAnnuler).HasColumnType("smalldatetime");
            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateVers).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDateEcheance).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMntLettre)
                .HasMaxLength(500)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocMontant).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.DocNetaPayer).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.DocRef)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocRefExt)
                .HasMaxLength(250)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalRemise).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocTotalTva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalTVA");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocValRem).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Npiece)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI")
                .HasColumnName("NPiece");
            entity.Property(e => e.Reste).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TypeImpaye)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<EtatSoldeClientBlFc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EtatSoldeClient_BL_FC");

            entity.Property(e => e.DocRef)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
        });

        modelBuilder.Entity<EtatSoldeClientBlaFca>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EtatSoldeClient_BLA_FCA");

            entity.Property(e => e.DocRef)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
        });

        modelBuilder.Entity<EtatSoldeClientFca>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EtatSoldeClient_FCA");

            entity.Property(e => e.DocRef)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
        });

        modelBuilder.Entity<EtatSoldeClientGroupNumCarnet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EtatSoldeClient_GroupNumCarnet");

            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateV).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDateEcheance).HasColumnType("smalldatetime");
            entity.Property(e => e.DocNetaPayer).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.DocRef)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.TypeImpaye)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<EtatSoldeDetailMoi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EtatSoldeDetailMois");

            entity.Property(e => e.Date).HasColumnType("smalldatetime");
            entity.Property(e => e.DateCréation).HasColumnType("smalldatetime");
            entity.Property(e => e.DateRecouvrement).HasColumnType("smalldatetime");
            entity.Property(e => e.DocType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("French_CI_AI")
                .HasColumnName("Doc.Type");
            entity.Property(e => e.ModeRegTier)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MontantReglé)
                .HasColumnType("decimal(38, 3)")
                .HasColumnName("Montant.reglé");
            entity.Property(e => e.RefDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("Ref.Doc");
            entity.Property(e => e.RefTiers)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("Ref.Tiers");
            entity.Property(e => e.Reste).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Tiers)
                .HasMaxLength(202)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Total).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.TotalAvance)
                .HasColumnType("decimal(38, 3)")
                .HasColumnName("Total.Avance");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<EtatSoldeDetailMoisAnc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EtatSoldeDetailMoisAnc");

            entity.Property(e => e.Date).HasColumnType("smalldatetime");
            entity.Property(e => e.DateCréation).HasColumnType("smalldatetime");
            entity.Property(e => e.DateRecouvrement).HasColumnType("smalldatetime");
            entity.Property(e => e.DocType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("French_CI_AI")
                .HasColumnName("Doc.Type");
            entity.Property(e => e.ModeRegTier)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.MontantReglé)
                .HasColumnType("decimal(38, 3)")
                .HasColumnName("Montant.reglé");
            entity.Property(e => e.RefDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("Ref.Doc");
            entity.Property(e => e.RefTiers)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("Ref.Tiers");
            entity.Property(e => e.Reste).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Tiers)
                .HasMaxLength(202)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Total).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.TotalAvance)
                .HasColumnType("decimal(38, 3)")
                .HasColumnName("Total.Avance");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<EtatSoldeFournisseur>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EtatSoldeFournisseur");

            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Commentaire)
                .HasMaxLength(250)
                .HasColumnName("commentaire");
            entity.Property(e => e.DateAnnuler)
                .HasColumnType("smalldatetime")
                .HasColumnName("dateAnnuler");
            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateVers).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDateEcheance).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMntLettre)
                .HasMaxLength(500)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocMontant).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.DocNetaPayer).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.DocRef)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocRefExt)
                .HasMaxLength(250)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalRemise).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocTotalTva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalTVA");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocValRem).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Npiece)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI")
                .HasColumnName("NPiece");
            entity.Property(e => e.Reste).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TypeImpaye)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<EtatSoldeFr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EtatSoldeFrs");

            entity.Property(e => e.DateVers).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDateEcheance).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMntLettre)
                .HasMaxLength(500)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocMontant).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.DocNetaPayer).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.DocRef)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocRefExt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalRemise).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocTotalTva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalTVA");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocValRem).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Npiece)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("NPiece");
        });

        modelBuilder.Entity<EtatSoldeFrsGroupNumCarnet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EtatSoldeFrs_GroupNumCarnet");

            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateV).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDateEcheance).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMontant).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.DocRef)
                .HasMaxLength(30)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
        });

        modelBuilder.Entity<EtatStockDepotFamille>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EtatStock-depot-famille");

            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.Depot)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Désignation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Famille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.PUVntTtc)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("P.U.Vnt.TTC");
            entity.Property(e => e.Prix1).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Prix2)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("prix2");
            entity.Property(e => e.Prix3)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("prix3");
            entity.Property(e => e.Pvht)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("PVHT");
            entity.Property(e => e.Stock).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<Expro>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("expro");

            entity.Property(e => e.DocAcompte).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocCloture).HasColumnType("smalldatetime");
            entity.Property(e => e.DocCommentaire)
                .UseCollation("French_CI_AI")
                .HasColumnType("ntext");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDateEcheance).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDest)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocDevise)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocEtatBp).HasColumnName("DocEtatBP");
            entity.Property(e => e.DocEtatBp1).HasColumnName("DocEtatBP1");
            entity.Property(e => e.DocHliv).HasColumnName("DocHLiv");
            entity.Property(e => e.DocLancement).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMatricule)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocMntLettre)
                .HasMaxLength(500)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocMontant).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocNetaPayer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocNptiers)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("DocNPTiers");
            entity.Property(e => e.DocNumDoc)
                .HasMaxLength(15)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocRefCaisse)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocRefExt).HasMaxLength(250);
            entity.Property(e => e.DocRepresentant).HasMaxLength(50);
            entity.Property(e => e.DocReste).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalRemise).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocTotalTva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalTVA");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocValFodec).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocValRem).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.Ematricule)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MargeMinDoc).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Marque)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Modele).HasMaxLength(50);
            entity.Property(e => e.RefDev)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefSouDest)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefSouDest1)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Rmmatricule)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("RMMatricule");
            entity.Property(e => e.UniqueId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UniqueID");
        });

        modelBuilder.Entity<Exprodetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("exprodetail");

            entity.Property(e => e.AqteStock).HasColumnName("AQteStock");
            entity.Property(e => e.Col1)
                .HasMaxLength(50)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("COL1");
            entity.Property(e => e.Col2)
                .HasMaxLength(50)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("COL2");
            entity.Property(e => e.Col3)
                .HasMaxLength(50)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("COL3");
            entity.Property(e => e.Col4)
                .HasMaxLength(50)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("COL4");
            entity.Property(e => e.Col5).HasColumnName("COL5");
            entity.Property(e => e.Date)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.DocArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocArtDesignation)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocCommentaire).HasMaxLength(250);
            entity.Property(e => e.DocPrevient)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DocPRevient");
            entity.Property(e => e.DocPunit).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTotalFodec).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalTtc)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DocTotalTTC");
            entity.Property(e => e.DocTotalTva).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.IdligneExt).HasColumnName("IDLigneExt");
            entity.Property(e => e.Lot)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ParentRef)
                .HasMaxLength(20)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UniqueID");
            entity.Property(e => e.UniqueIddoc).HasColumnName("UniqueIDDoc");
        });

        modelBuilder.Entity<Factnonreg>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Factnonreg");

            entity.Property(e => e.F1).HasColumnType("datetime");
            entity.Property(e => e.F2).HasMaxLength(255);
            entity.Property(e => e.F3).HasColumnType("datetime");
            entity.Property(e => e.F4).HasMaxLength(255);
        });

        modelBuilder.Entity<FactureNonRparFr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("FactureNonRParFRS");

            entity.Property(e => e.DateCréation)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Montant).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.ReTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefExt).HasMaxLength(250);
            entity.Property(e => e.Reste).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Tiers)
                .HasMaxLength(202)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<FactureVNr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Facture_V_NR");

            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocLancement).HasColumnType("smalldatetime");
            entity.Property(e => e.DocNetaPayer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocRef)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
        });

        modelBuilder.Entity<Fboumhal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FBoumhal");

            entity.Property(e => e.CodeTiers)
                .HasMaxLength(255)
                .HasColumnName("Code tiers");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Echeance)
                .HasColumnType("datetime")
                .HasColumnName("echeance");
            entity.Property(e => e.MtNominale).HasColumnName("Mt nominale");
            entity.Property(e => e.Nature).HasMaxLength(255);
            entity.Property(e => e.Numint).HasMaxLength(255);
        });

        modelBuilder.Entity<Fcentral>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FCentral");

            entity.Property(e => e.CodeTiers)
                .HasMaxLength(255)
                .HasColumnName("Code tiers");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Echeance)
                .HasColumnType("datetime")
                .HasColumnName("echeance");
            entity.Property(e => e.MtNominale).HasColumnName("Mt nominale");
            entity.Property(e => e.Numint).HasMaxLength(255);
        });

        modelBuilder.Entity<Feuil1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Feuil1$");

            entity.Property(e => e.Désignation)
                .HasMaxLength(255)
                .HasColumnName("Désignation ");
            entity.Property(e => e.Famille)
                .HasMaxLength(255)
                .HasColumnName("Famille ");
            entity.Property(e => e.Réf)
                .HasMaxLength(255)
                .HasColumnName("Réf#");
            entity.Property(e => e.SousFamille)
                .HasMaxLength(255)
                .HasColumnName("Sous famille");
        });

        modelBuilder.Entity<Feuil11>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Feuil1$$$");

            entity.Property(e => e.Categorie)
                .HasMaxLength(255)
                .HasColumnName("CATEGORIE ");
            entity.Property(e => e.Designation)
                .HasMaxLength(255)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Famille)
                .HasMaxLength(255)
                .HasColumnName("FAMILLE");
            entity.Property(e => e.Ref)
                .HasMaxLength(255)
                .HasColumnName("REF ");
            entity.Property(e => e.SousFamille)
                .HasMaxLength(255)
                .HasColumnName("SOUS FAMILLE ");
        });

        modelBuilder.Entity<Feuil111>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Feuil111$");

            entity.Property(e => e.MtNominale).HasColumnName("Mt nominale");
            entity.Property(e => e.Nature).HasMaxLength(255);
            entity.Property(e => e.NbJours).HasColumnName("Nb#jours");
            entity.Property(e => e.Numint).HasMaxLength(255);
            entity.Property(e => e.Tiers).HasMaxLength(255);
        });

        modelBuilder.Entity<Feuil3>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Feuil3$");

            entity.Property(e => e.Dater)
                .HasColumnType("datetime")
                .HasColumnName("dater");
            entity.Property(e => e.Ech)
                .HasColumnType("datetime")
                .HasColumnName("ech");
            entity.Property(e => e.Mode).HasMaxLength(255);
            entity.Property(e => e.Montant).HasColumnName("montant");
            entity.Property(e => e.Num)
                .HasMaxLength(255)
                .HasColumnName("num");
        });

        modelBuilder.Entity<Fhbc1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FHBC1");

            entity.Property(e => e.CodeTiers)
                .HasMaxLength(255)
                .HasColumnName("Code tiers");
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.Echeance)
                .HasColumnType("datetime")
                .HasColumnName("echeance");
            entity.Property(e => e.MtNominale).HasColumnName("Mt nominale");
            entity.Property(e => e.Nature).HasMaxLength(255);
            entity.Property(e => e.NbJours)
                .HasMaxLength(255)
                .HasColumnName("Nb#jours");
            entity.Property(e => e.Numint).HasMaxLength(255);
        });

        modelBuilder.Entity<FileArticle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FileArticle");

            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ARef");
            entity.Property(e => e.FileName)
                .HasMaxLength(256)
                .IsFixedLength();
            entity.Property(e => e.FileTitre)
                .HasMaxLength(256)
                .IsFixedLength();
            entity.Property(e => e.UniqueIdfile)
                .ValueGeneratedOnAdd()
                .HasColumnName("UniqueIDFile");
        });

        modelBuilder.Entity<FileCrmaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FileCRMAction");

            entity.Property(e => e.FileName)
                .HasMaxLength(256)
                .IsFixedLength();
            entity.Property(e => e.FileTitre)
                .HasMaxLength(256)
                .IsFixedLength();
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.UniqueIdfile)
                .ValueGeneratedOnAdd()
                .HasColumnName("UniqueIDFile");
        });

        modelBuilder.Entity<FileCrmactionRapport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FileCRMActionRapport");

            entity.Property(e => e.FileName)
                .HasMaxLength(256)
                .IsFixedLength();
            entity.Property(e => e.FileTitre)
                .HasMaxLength(256)
                .IsFixedLength();
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.UniqueIdfile)
                .ValueGeneratedOnAdd()
                .HasColumnName("UniqueIDFile");
        });

        modelBuilder.Entity<FileCrmcampagne>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FileCRMCampagne");

            entity.Property(e => e.FileName)
                .HasMaxLength(256)
                .IsFixedLength();
            entity.Property(e => e.FileTitre)
                .HasMaxLength(256)
                .IsFixedLength();
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.UniqueIdfile)
                .ValueGeneratedOnAdd()
                .HasColumnName("UniqueIDFile");
        });

        modelBuilder.Entity<FileDoc>(entity =>
        {
            entity.HasKey(e => new { e.UniqueId, e.UniqueIdfile });

            entity.ToTable("FileDoc");

            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.UniqueIdfile)
                .ValueGeneratedOnAdd()
                .HasColumnName("UniqueIDFile");
            entity.Property(e => e.FileName)
                .HasMaxLength(256)
                .IsFixedLength();
            entity.Property(e => e.FileTitre)
                .HasMaxLength(256)
                .IsFixedLength();
        });

        modelBuilder.Entity<FileGrh>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.ToTable("FileGRH");

            entity.Property(e => e.UniqueId)
                .ValueGeneratedNever()
                .HasColumnName("UniqueID");
            entity.Property(e => e.FileName)
                .HasMaxLength(256)
                .IsFixedLength();
            entity.Property(e => e.FileTitre)
                .HasMaxLength(256)
                .IsFixedLength();
        });

        modelBuilder.Entity<FileTier>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Cref)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CRef");
            entity.Property(e => e.FileName)
                .HasMaxLength(256)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.FileTitre)
                .HasMaxLength(256)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.UniqueIdfile)
                .ValueGeneratedOnAdd()
                .HasColumnName("UniqueIDFile");
        });

        modelBuilder.Entity<Form>(entity =>
        {
            entity.HasKey(e => new { e.IdtypeU, e.NomForm });

            entity.ToTable("Form");

            entity.Property(e => e.IdtypeU).HasColumnName("IDTypeU");
            entity.Property(e => e.NomForm)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("Nom_Form");
            entity.Property(e => e.Button)
                .HasMaxLength(14)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Datagridview)
                .HasMaxLength(25)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Formulaire)
                .HasMaxLength(40)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
        });

        modelBuilder.Entity<Gain3005>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("gain3005");

            entity.Property(e => e.Col1).HasMaxLength(250);
            entity.Property(e => e.Col10).HasMaxLength(250);
            entity.Property(e => e.Col11).HasMaxLength(250);
            entity.Property(e => e.Col12).HasMaxLength(250);
            entity.Property(e => e.Col13).HasMaxLength(250);
            entity.Property(e => e.Col14).HasMaxLength(250);
            entity.Property(e => e.Col15).HasMaxLength(250);
            entity.Property(e => e.Col16).HasMaxLength(250);
            entity.Property(e => e.Col17).HasMaxLength(250);
            entity.Property(e => e.Col18).HasMaxLength(250);
            entity.Property(e => e.Col19).HasMaxLength(250);
            entity.Property(e => e.Col2).HasMaxLength(250);
            entity.Property(e => e.Col20).HasMaxLength(250);
            entity.Property(e => e.Col21).HasMaxLength(250);
            entity.Property(e => e.Col22).HasMaxLength(250);
            entity.Property(e => e.Col23).HasMaxLength(250);
            entity.Property(e => e.Col24).HasMaxLength(250);
            entity.Property(e => e.Col25).HasMaxLength(250);
            entity.Property(e => e.Col3).HasMaxLength(250);
            entity.Property(e => e.Col4).HasMaxLength(250);
            entity.Property(e => e.Col5).HasMaxLength(250);
            entity.Property(e => e.Col6).HasMaxLength(250);
            entity.Property(e => e.Col7).HasMaxLength(250);
            entity.Property(e => e.Col8).HasMaxLength(250);
            entity.Property(e => e.Col9).HasMaxLength(250);
            entity.Property(e => e.Crmtype)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CRMType");
            entity.Property(e => e.DateCreation).HasColumnType("smalldatetime");
            entity.Property(e => e.DatePrevu).HasColumnType("smalldatetime");
            entity.Property(e => e.Des).HasMaxLength(255);
            entity.Property(e => e.DocCloture).HasColumnType("smalldatetime");
            entity.Property(e => e.DocLancement).HasColumnType("smalldatetime");
            entity.Property(e => e.EtatBp).HasColumnName("EtatBP");
            entity.Property(e => e.EtatBp1).HasColumnName("EtatBP1");
            entity.Property(e => e.Lcol1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LCol1");
            entity.Property(e => e.Lcol2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LCol2");
            entity.Property(e => e.LetatBp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEtatBP");
            entity.Property(e => e.LetatBp1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEtatBP1");
            entity.Property(e => e.ListeType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Rtf).HasColumnName("RTF");
            entity.Property(e => e.UniqueId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Grh>(entity =>
        {
            entity.HasKey(e => e.Uniqueid);

            entity.ToTable("GRH", tb =>
                {
                    tb.HasTrigger("InsertGRH");
                    tb.HasTrigger("OnInsertGRH");
                    tb.HasTrigger("UpdateGRH");
                    tb.HasTrigger("UpdateGRHMail");
                });

            entity.Property(e => e.Uniqueid).HasColumnName("uniqueid");
            entity.Property(e => e.Aup)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("AUP");
            entity.Property(e => e.Categorie).HasMaxLength(250);
            entity.Property(e => e.CodeTiers)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.DateC).HasColumnType("datetime");
            entity.Property(e => e.DateDeb)
                .HasColumnType("datetime")
                .HasColumnName("DateDEB");
            entity.Property(e => e.DateFin).HasColumnType("datetime");
            entity.Property(e => e.DateL).HasColumnType("datetime");
            entity.Property(e => e.Des).IsUnicode(false);
            entity.Property(e => e.Duree)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DUREE");
            entity.Property(e => e.EtatBp).HasColumnName("EtatBP");
            entity.Property(e => e.EtatBp1).HasColumnName("EtatBP1");
            entity.Property(e => e.HeurDeb).HasColumnType("text");
            entity.Property(e => e.HeurFin).HasColumnType("text");
            entity.Property(e => e.Moydep)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MOYDEP");
            entity.Property(e => e.NbreJour).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Obj)
                .HasMaxLength(250)
                .HasColumnName("OBJ");
            entity.Property(e => e.Ref)
                .HasMaxLength(250)
                .HasColumnName("ref");
            entity.Property(e => e.TypeGrh)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("TypeGRH");

            entity.HasOne(d => d.CodeTiersNavigation).WithMany(p => p.Grhs)
                .HasPrincipalKey(p => p.CodeTiers)
                .HasForeignKey(d => d.CodeTiers)
                .HasConstraintName("fk_CodeTiers");
        });

        modelBuilder.Entity<Groupement>(entity =>
        {
            entity.HasKey(e => new { e.Gtype, e.Gref });

            entity.ToTable("Groupement", tb =>
                {
                    tb.HasTrigger("DeleteDetailGroupement");
                    tb.HasTrigger("ForUpdateDeleteGroupement");
                });

            entity.Property(e => e.Gtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("GType");
            entity.Property(e => e.Gref)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("GRef");
            entity.Property(e => e.Gcomm)
                .HasMaxLength(200)
                .UseCollation("French_CI_AI")
                .HasColumnName("GComm");
            entity.Property(e => e.Gdate)
                .HasColumnType("smalldatetime")
                .HasColumnName("GDate");
            entity.Property(e => e.Gmontant)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("GMontant");
            entity.Property(e => e.Gtiers)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("GTiers");
        });

        modelBuilder.Entity<GroupementDetail>(entity =>
        {
            entity.HasKey(e => new { e.Gtype, e.Gref, e.DocType, e.DocRef }).HasName("PK_DetailGroupement");

            entity.ToTable("GroupementDetail");

            entity.Property(e => e.Gtype)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("GType");
            entity.Property(e => e.Gref)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("GRef");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocRef)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Montant).HasColumnType("decimal(18, 4)");

            entity.HasOne(d => d.Groupement).WithMany(p => p.GroupementDetails)
                .HasForeignKey(d => new { d.Gtype, d.Gref })
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_GroupementDetail_Groupement");
        });

        modelBuilder.Entity<HistoriqueCloture>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HistoriqueCloture");

            entity.Property(e => e.DateCloture).HasColumnType("datetime");
            entity.Property(e => e.MontantCloture).HasMaxLength(255);
            entity.Property(e => e.UniqueId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UniqueID");
        });

        modelBuilder.Entity<HistoriqueDoc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HistoriqueDoc", tb => tb.HasTrigger("AfterInsertHD"));

            entity.HasIndex(e => new { e.UniqueId, e.DateEven }, "NonClusteredIndex-20230917-202913").IsDescending(false, true);

            entity.Property(e => e.DateEven).HasColumnType("datetime");
            entity.Property(e => e.Ematricule)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("EMatricule");
            entity.Property(e => e.TypeEven)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.UniqueId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UniqueID");
        });

        modelBuilder.Entity<HistoriqueDoc2021>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HistoriqueDoc2021");

            entity.Property(e => e.DateEven).HasColumnType("datetime");
            entity.Property(e => e.Ematricule)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("EMatricule");
            entity.Property(e => e.TypeEven)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.UniqueId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UniqueID");
        });

        modelBuilder.Entity<HistoriqueDoc2022>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HistoriqueDoc2022");

            entity.Property(e => e.DateEven).HasColumnType("datetime");
            entity.Property(e => e.Ematricule)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("EMatricule");
            entity.Property(e => e.TypeEven)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.UniqueId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UniqueID");
        });

        modelBuilder.Entity<HistoriqueDocCrm>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HistoriqueDocCRM");

            entity.Property(e => e.DateEven).HasColumnType("datetime");
            entity.Property(e => e.Ematricule)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("EMatricule");
            entity.Property(e => e.TypeEven)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.TypeF)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("UniqueID");
        });

        modelBuilder.Entity<HistoriqueDocGrh>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HistoriqueDocGRH", tb => tb.HasTrigger("InserthistoriqueGRH"));

            entity.Property(e => e.DateEven).HasColumnType("datetime");
            entity.Property(e => e.Ematricule)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMatricule");
            entity.Property(e => e.TypeEven)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.TypeF)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniqueId)
                .HasMaxLength(12)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UniqueID");
        });

        modelBuilder.Entity<HistoriqueFondCaisse>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HistoriqueFondCaisse");

            entity.Property(e => e.ValeurFond).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<HistoriqueModifTxMargeDevi>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DateModif).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<Indicateur>(entity =>
        {
            entity.HasKey(e => e.UniqueId);

            entity.ToTable("Indicateur");

            entity.Property(e => e.Proc1)
                .HasMaxLength(100)
                .HasColumnName("proc1");
            entity.Property(e => e.ProcSelect).HasMaxLength(255);
            entity.Property(e => e.Tbbasearcend).HasColumnName("tbbasearcend");
            entity.Property(e => e.Tbbasearcstart).HasColumnName("tbbasearcstart");
            entity.Property(e => e.Titre).HasMaxLength(50);
            entity.Property(e => e.TypeAff).HasMaxLength(200);
            entity.Property(e => e.UserInd)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<IndicateurHistorique>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IndicateurHistorique");

            entity.Property(e => e.DateVal).HasColumnType("datetime");
            entity.Property(e => e.IdIndicateur).HasColumnName("Id_Indicateur");
            entity.Property(e => e.UniqueId).ValueGeneratedOnAdd();
            entity.Property(e => e.Valeur).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<IndicateurPalier>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IndicateurPalier");

            entity.Property(e => e.Couleur).HasMaxLength(50);
            entity.Property(e => e.Designation).IsUnicode(false);
            entity.Property(e => e.IdIndicateur).HasColumnName("ID_Indicateur");
            entity.Property(e => e.NumPalier).HasColumnName("Num_palier");
            entity.Property(e => e.ValeurMax).HasColumnName("Valeur_Max");
            entity.Property(e => e.ValeurMin).HasColumnName("Valeur_Min");
        });

        modelBuilder.Entity<IndicateurPalier1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IndicateurPalier1");

            entity.Property(e => e.Couleur).HasMaxLength(50);
            entity.Property(e => e.Designation).IsUnicode(false);
            entity.Property(e => e.IdIndicateur).HasColumnName("ID_Indicateur");
            entity.Property(e => e.NumPalier).HasColumnName("Num_palier");
            entity.Property(e => e.ValeurMax).HasColumnName("Valeur_Max");
            entity.Property(e => e.ValeurMin).HasColumnName("Valeur_Min");
        });

        modelBuilder.Entity<IndicateurPalierTb>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IndicateurPalierTB");

            entity.Property(e => e.Couleur).HasMaxLength(50);
            entity.Property(e => e.Designation).IsUnicode(false);
            entity.Property(e => e.IdIndicateur).HasColumnName("ID_Indicateur");
            entity.Property(e => e.NumPalier).HasColumnName("Num_palier");
            entity.Property(e => e.ValeurMax).HasColumnName("Valeur_Max");
            entity.Property(e => e.ValeurMin).HasColumnName("Valeur_Min");
        });

        modelBuilder.Entity<Invcorrect>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("INVCorrect");

            entity.Property(e => e.Art).HasMaxLength(50);
        });

        modelBuilder.Entity<Invcorrect0101>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("INVCorrect0101");

            entity.Property(e => e.Art).HasMaxLength(50);
        });

        modelBuilder.Entity<Inventaire>(entity =>
        {
            entity.HasKey(e => e.Idinv).HasName("PK_Inventaire_1");

            entity.ToTable("Inventaire", tb => tb.HasTrigger("AFTERDeleteINV"));

            entity.Property(e => e.Idinv)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("IDInv");
            entity.Property(e => e.DateOuvInv).HasColumnType("datetime");
            entity.Property(e => e.Depot)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.ModeInv)
                .HasMaxLength(200)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RazartNinv).HasColumnName("RAZArtNInv");
            entity.Property(e => e.RefInv)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
        });

        modelBuilder.Entity<InventaireDetail>(entity =>
        {
            entity.HasKey(e => new { e.RefInv, e.Aref });

            entity.ToTable("InventaireDetail");

            entity.Property(e => e.RefInv)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.ApuachatHt)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("APUAchatHT");
            entity.Property(e => e.AqteStock).HasColumnName("AQteStock");
            entity.Property(e => e.DocArtDesignation)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.InvDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ParentRef)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.QteInv1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.UniqueId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UniqueID");

            entity.HasOne(d => d.RefInvNavigation).WithMany(p => p.InventaireDetails)
                .HasForeignKey(d => d.RefInv)
                .HasConstraintName("FK_InventaireDetail_Inventaire");
        });

        modelBuilder.Entity<InventaireDetailcorrection241>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("InventaireDetailcorrection241");

            entity.Property(e => e.ApuachatHt)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("APUAchatHT");
            entity.Property(e => e.AqteStock).HasColumnName("AQteStock");
            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.DocArtDesignation)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.InvDate).HasColumnType("smalldatetime");
            entity.Property(e => e.ParentRef)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.QteInv1).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.RefInv)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UniqueID");
        });

        modelBuilder.Entity<Invtunis3112>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("INVTunis3112");

            entity.Property(e => e.Art).HasMaxLength(50);
            entity.Property(e => e.Qte).HasColumnName("QTE");
        });

        modelBuilder.Entity<ListClt2020>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("'LIST CLT 2020$'");

            entity.Property(e => e.Cref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CRef");
            entity.Property(e => e.Représentant).HasMaxLength(255);
            entity.Property(e => e.Rsocial)
                .HasMaxLength(255)
                .HasColumnName("RSocial");
            entity.Property(e => e.Secteur).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(255);
            entity.Property(e => e.Ville).HasMaxLength(255);
            entity.Property(e => e.ZoneActivite).HasMaxLength(255);
        });

        modelBuilder.Entity<ListeArticleCommander>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ListeArticleCommander");

            entity.Property(e => e.Adesignation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("ADesignation");
            entity.Property(e => e.Afamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AFamille");
            entity.Property(e => e.AqteStock)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("AQteStock");
            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.Asfamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ASFamille");
            entity.Property(e => e.AstockMax).HasColumnName("AStockMax");
            entity.Property(e => e.AstockMin).HasColumnName("AStockMin");
            entity.Property(e => e.AuniteVnt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AUniteVnt");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.QtReserver).HasColumnName("qt.Reserver");
            entity.Property(e => e.StockDisponible)
                .HasColumnType("decimal(22, 3)")
                .HasColumnName("Stock.Disponible");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<ListeBlnonFactureeBoumhal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ListeBLNonFactureeBoumhal");

            entity.Property(e => e.Commentaire)
                .UseCollation("French_CI_AI")
                .HasColumnType("ntext");
            entity.Property(e => e.Date).HasColumnType("smalldatetime");
            entity.Property(e => e.Facture)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Montant).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Nptiers)
                .HasMaxLength(100)
                .HasColumnName("NPTiers");
            entity.Property(e => e.RaisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI")
                .HasColumnName("Ref.Doc");
            entity.Property(e => e.RefExt)
                .HasMaxLength(250)
                .HasColumnName("Ref.Ext");
            entity.Property(e => e.RefTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI")
                .HasColumnName("Ref.Tiers");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.Utilisateur)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
        });

        modelBuilder.Entity<ListeBlnonFactureeSidiSalem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ListeBLNonFactureeSidiSalem");

            entity.Property(e => e.Commentaire)
                .UseCollation("French_CI_AI")
                .HasColumnType("ntext");
            entity.Property(e => e.Date).HasColumnType("smalldatetime");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Facture)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Montant).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Nptiers)
                .HasMaxLength(100)
                .HasColumnName("NPTiers");
            entity.Property(e => e.RaisonSocial)
                .HasMaxLength(200)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI")
                .HasColumnName("Ref.Doc");
            entity.Property(e => e.RefExt)
                .HasMaxLength(250)
                .HasColumnName("Ref.Ext");
            entity.Property(e => e.RefTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI")
                .HasColumnName("Ref.Tiers");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.Utilisateur)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
        });

        modelBuilder.Entity<ListeDesCheLib>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ListeDesCheLib");

            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MontantAffecter).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.MontantPiece).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RaisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Reste).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Tiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId)
                .HasMaxLength(30)
                .HasColumnName("UniqueID");
        });

        modelBuilder.Entity<ListeDesEffLib>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ListeDesEffLib");

            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MontantAffecter).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.MontantPiece).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RaisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Reste).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Tiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId)
                .HasMaxLength(30)
                .HasColumnName("UniqueID");
        });

        modelBuilder.Entity<ListeDesFacturesNonRéglèe>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ListeDesFacturesNonRéglèe");

            entity.Property(e => e.Date).HasColumnType("smalldatetime");
            entity.Property(e => e.DateCréation).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEcheance).HasColumnType("smalldatetime");
            entity.Property(e => e.DateRecouvrement).HasColumnType("smalldatetime");
            entity.Property(e => e.DocRepresentant)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.ModeRegTier)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Montantreglé).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.NbreJoursRecouvert).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.RefDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Reste).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Tiers)
                .HasMaxLength(202)
                .UseCollation("French_CI_AI")
                .HasColumnName("________________Tiers___________________");
            entity.Property(e => e.Total).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<ListeDesVirement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ListeDesVirement");

            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MontantAffecter).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.MontantPiece).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RaisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Reste).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Tiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId)
                .HasMaxLength(30)
                .HasColumnName("UniqueID");
        });

        modelBuilder.Entity<ListeFactureReglée>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ListeFactureReglées");

            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DateCréation)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DateEcheance)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DateRecouvrement)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocType)
                .HasMaxLength(7)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Montantreglé).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.RefDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Reste).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Tiers)
                .HasMaxLength(202)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Total).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<ListeImpaye>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ListeImpaye");

            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DateCréation)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DateEcheance)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DateRecouvrement)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocRepresentant)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(6)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.ModeRegTier)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Modereg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("French_CI_AI")
                .HasColumnName("modereg");
            entity.Property(e => e.MontantReglé)
                .HasColumnType("decimal(38, 3)")
                .HasColumnName("Montant.reglé");
            entity.Property(e => e.Npiece)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI")
                .HasColumnName("Ref.Tiers");
            entity.Property(e => e.Reste).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Tiers)
                .HasMaxLength(202)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<ListedesArticlesCommanderAvecLesEn>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ListedesArticlesCommanderAvecLesEn");

            entity.Property(e => e.Acategorie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ACategorie");
            entity.Property(e => e.Adesignation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("ADesignation");
            entity.Property(e => e.Afamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AFamille");
            entity.Property(e => e.AqteStock)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("AQteStock");
            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.Ascategorie)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ASCategorie");
            entity.Property(e => e.Asfamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ASFamille");
            entity.Property(e => e.AstockMax).HasColumnName("AStockMax");
            entity.Property(e => e.AstockMin).HasColumnName("AStockMin");
            entity.Property(e => e.AuniteVnt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AUniteVnt");
            entity.Property(e => e.EncoursBca).HasColumnName("EncoursBCA");
            entity.Property(e => e.EncoursLca).HasColumnName("EncoursLCA");
            entity.Property(e => e.QtReserver).HasColumnName("qt.Reserver");
            entity.Property(e => e.StockDisponible)
                .HasColumnType("decimal(22, 3)")
                .HasColumnName("Stock.Disponible");
        });

        modelBuilder.Entity<Mabk1814>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mabk1814");

            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Breception)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Caisse)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Commentaire).HasMaxLength(250);
            entity.Property(e => e.DateAnnuler).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch2).HasColumnType("smalldatetime");
            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateP).HasColumnType("smalldatetime");
            entity.Property(e => e.DateR).HasColumnType("smalldatetime");
            entity.Property(e => e.DateV).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMntLettre).HasMaxLength(500);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Docref1).HasMaxLength(20);
            entity.Property(e => e.Etat).HasColumnType("smalldatetime");
            entity.Property(e => e.Imput1)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("imput1");
            entity.Property(e => e.Imputation)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MontantR).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.NumEncDec2).HasMaxLength(20);
            entity.Property(e => e.Pdecommentaire)
                .HasMaxLength(250)
                .HasColumnName("PDECommentaire");
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Rib)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("RIB");
            entity.Property(e => e.Rib1).HasMaxLength(100);
            entity.Property(e => e.Ribp)
                .HasMaxLength(100)
                .HasColumnName("RIBP");
            entity.Property(e => e.Trc).HasColumnName("TRC");
            entity.Property(e => e.TypeEncDec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.UniqueIdEncDec).ValueGeneratedOnAdd();
            entity.Property(e => e.VisibleEd).HasColumnName("VisibleED");
        });

        modelBuilder.Entity<Melange>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Melange");

            entity.Property(e => e.Bef)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("BEF");
            entity.Property(e => e.BefOc)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("BEF_OC");
            entity.Property(e => e.BefdocDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("BEFDocDate");
            entity.Property(e => e.Befprix)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("BEFPrix");
            entity.Property(e => e.Befqte).HasColumnName("BEFQte");
            entity.Property(e => e.BefqteDocArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("BEFQteDocArt");
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateCloture)
                .HasMaxLength(14)
                .HasColumnName("Date_Cloture");
            entity.Property(e => e.DateEch)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateLancement)
                .HasMaxLength(14)
                .HasColumnName("Date_Lancement");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Expr1)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Expr3)
                .HasMaxLength(50)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Lot)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.LotOm)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .UseCollation("French_CI_AI")
                .HasColumnName("LotOM");
            entity.Property(e => e.Mélange)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.OcdocdocDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("OCDOCDocDate");
            entity.Property(e => e.Ocdocref)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("OCdocref");
            entity.Property(e => e.Ocrecipientdocart)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("OCrecipientdocart");
            entity.Property(e => e.Ocrecipientdocqte).HasColumnName("OCrecipientdocqte");
            entity.Property(e => e.Omlqte).HasColumnName("OMLQte");
            entity.Property(e => e.OmlqteDocArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("OMLQteDocArt");
            entity.Property(e => e.OmlqteLotLotArt)
                .HasMaxLength(100)
                .HasColumnName("OMLQteLotLotArt");
            entity.Property(e => e.OmlqteLotPrix)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("OMLQteLotPrix");
            entity.Property(e => e.OmnomencDocArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("OMNomencDocArt");
            entity.Property(e => e.OmnomencQte).HasColumnName("OMNomencQte");
            entity.Property(e => e.QteMélange)
                .HasMaxLength(18)
                .IsUnicode(false);
            entity.Property(e => e.QteReste)
                .HasMaxLength(18)
                .IsUnicode(false);
            entity.Property(e => e.Qteconsommation)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("QTEConsommation");
            entity.Property(e => e.QteresteConsommation).HasColumnName("QTEResteConsommation");
            entity.Property(e => e.RefTiers)
                .HasMaxLength(10)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.Unite)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
        });

        modelBuilder.Entity<ModelePrix>(entity =>
        {
            entity.HasKey(e => e.Idmodele);

            entity.ToTable("ModelePrix");

            entity.Property(e => e.Idmodele).HasColumnName("IDModele");
            entity.Property(e => e.DesPrix)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
        });

        modelBuilder.Entity<MouvementArticle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("MouvementArticle");

            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.DocArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Entrées).HasMaxLength(4000);
            entity.Property(e => e.LibDoc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefSouDest)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Sorties).HasMaxLength(4000);
            entity.Property(e => e.Typ)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("typ");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<MouvementClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Mouvement_Client");

            entity.Property(e => e.Date).HasColumnType("smalldatetime");
            entity.Property(e => e.DateCréation).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEcheance).HasColumnType("smalldatetime");
            entity.Property(e => e.DateRecouvrement).HasColumnType("smalldatetime");
            entity.Property(e => e.DocRepresentant)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.ModeRegTier)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Montantreglé).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.RefDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Reste).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Tiers)
                .HasMaxLength(202)
                .UseCollation("French_CI_AI")
                .HasColumnName("________________Tiers___________________");
            entity.Property(e => e.Total).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<MvtFidelite>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MvtFidelite");

            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS")
                .HasColumnName("ARef");
            entity.Property(e => e.Cref)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS")
                .HasColumnName("CRef");
            entity.Property(e => e.Mcredit).HasColumnName("MCredit");
            entity.Property(e => e.Mdebit).HasColumnName("MDebit");
            entity.Property(e => e.UniqueIddoc).HasColumnName("UniqueIDDoc");
        });

        modelBuilder.Entity<MvtLot>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Mvt_Lot");

            entity.Property(e => e.Adesignation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("ADesignation");
            entity.Property(e => e.DocArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocArtDesignation)
                .HasMaxLength(101)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocPunit).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocRef)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.RefSouDest)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefSouDest1)
                .HasMaxLength(20)
                .IsFixedLength();
        });

        modelBuilder.Entity<Nosbanque>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CodeAgence).HasColumnName("Code_agence");
            entity.Property(e => e.CodeBq).HasColumnName("Code_bq");
            entity.Property(e => e.Cpteeffdep).HasColumnName("cpteeffdep");
            entity.Property(e => e.Fax).HasColumnName("fax");
            entity.Property(e => e.Frais).HasColumnName("frais");
            entity.Property(e => e.IntDetailGlobalEnc).HasColumnName("IntDetailGlobalENC");
            entity.Property(e => e.IntDetailGlobalEsc).HasColumnName("IntDetailGlobalESC");
            entity.Property(e => e.Jalchqenc).HasColumnName("jalchqenc");
            entity.Property(e => e.Jaleffenc).HasColumnName("jaleffenc");
            entity.Property(e => e.Jaleffesc).HasColumnName("jaleffesc");
            entity.Property(e => e.Libelle).HasColumnName("libelle");
            entity.Property(e => e.Modelechq).HasColumnName("modelechq");
            entity.Property(e => e.Rib).HasColumnName("RIB");
            entity.Property(e => e.Tel1).HasColumnName("tel1");
            entity.Property(e => e.Tel2).HasColumnName("tel2");
            entity.Property(e => e.Tva).HasColumnName("tva");
            entity.Property(e => e.Typefichier).HasColumnName("typefichier");
        });

        modelBuilder.Entity<Nvclt>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("nvclt$");

            entity.Property(e => e.Cref)
                .HasMaxLength(255)
                .HasColumnName("CRef");
            entity.Property(e => e.Représentant).HasMaxLength(255);
            entity.Property(e => e.Rsocial)
                .HasMaxLength(255)
                .HasColumnName("RSocial");
            entity.Property(e => e.Secteur).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(255);
            entity.Property(e => e.Ville).HasMaxLength(255);
            entity.Property(e => e.ZoneActivite).HasMaxLength(255);
        });

        modelBuilder.Entity<ObjectifPlafond>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ObjectifPlafond");

            entity.Property(e => e.Commercial).HasMaxLength(50);
            entity.Property(e => e.DateCreation).HasColumnType("smalldatetime");
            entity.Property(e => e.DatePrevu).HasColumnType("smalldatetime");
            entity.Property(e => e.DocCloture).HasColumnType("smalldatetime");
            entity.Property(e => e.DocLancement).HasColumnType("smalldatetime");
            entity.Property(e => e.EtatBp).HasColumnName("EtatBP");
            entity.Property(e => e.EtatBp1).HasColumnName("EtatBP1");
            entity.Property(e => e.Lcol1)
                .HasMaxLength(50)
                .HasColumnName("LCol1");
            entity.Property(e => e.Lcol2)
                .HasMaxLength(50)
                .HasColumnName("LCol2");
            entity.Property(e => e.Lcol3)
                .HasMaxLength(50)
                .HasColumnName("LCol3");
            entity.Property(e => e.LetatBp)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEtatBP");
            entity.Property(e => e.LetatBp1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LEtatBP1");
            entity.Property(e => e.ObjectifType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniqueId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ObjectifPlafondDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ObjectifPlafondDetail");

            entity.Property(e => e.Objectif).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Param1).HasMaxLength(250);
            entity.Property(e => e.Param2).HasMaxLength(250);
            entity.Property(e => e.Param3).HasMaxLength(250);
            entity.Property(e => e.Param4).HasMaxLength(250);
            entity.Property(e => e.Param5).HasMaxLength(250);
            entity.Property(e => e.Param6).HasMaxLength(250);
            entity.Property(e => e.UniqueId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<ObjectifRep>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ObjectifRep");

            entity.Property(e => e.Cref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CRef");
            entity.Property(e => e.Expr1)
                .HasMaxLength(101)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Objectif).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.ObjectifType)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Om>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OM$");

            entity.Property(e => e.MatriculePaiePointeuse).HasColumnName("Matricule paie & pointeuse");
            entity.Property(e => e.NomEtPrénom)
                .HasMaxLength(255)
                .HasColumnName("Nom et prénom");
            entity.Property(e => e.Sup1Om)
                .HasMaxLength(255)
                .HasColumnName("SUP 1  OM");
            entity.Property(e => e.Sup2Om)
                .HasMaxLength(255)
                .HasColumnName("SUP 2 OM");
        });

        modelBuilder.Entity<Organigramme>(entity =>
        {
            entity
            
                .HasNoKey()
                .ToTable("Organigramme");
                 entity.HasKey(e => e.Id);
                 entity.Property(e => e.EmatriculeSubordonné)
                  
                  .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            
            entity.Property(e => e.EmatriculeSupérieur)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Id)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NomSubordonné).HasMaxLength(50);
            entity.Property(e => e.NomSupérieur).HasMaxLength(50);

            entity.HasOne(d => d.IdNavigation).WithMany()
                .HasForeignKey(d => d.Id)
                .HasConstraintName("FK_Matricule");
        });

        modelBuilder.Entity<Parametre>(entity =>
        {
            entity.HasKey(e => new { e.TParametre, e.NParametre });

            entity.ToTable("Parametre");

            entity.Property(e => e.TParametre)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("T_parametre");
            entity.Property(e => e.NParametre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("N_parametre");
            entity.Property(e => e.Col)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.EntetBanque)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.NomSociete)
                .HasMaxLength(100)
                .IsFixedLength();
            entity.Property(e => e.OOrder).HasColumnName("O_Order");
            entity.Property(e => e.PlafEscompte).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TitulaireCompte)
                .HasMaxLength(100)
                .IsFixedLength();
        });

        modelBuilder.Entity<ParametreEdition>(entity =>
        {
            entity.HasKey(e => e.Designation);

            entity.ToTable("ParametreEdition");

            entity.Property(e => e.Designation)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Formulaire)
                .HasMaxLength(30)
                .IsFixedLength();
            entity.Property(e => e.OrderRpt).HasColumnName("OrderRPT");
            entity.Property(e => e.ParametreRpt)
                .HasMaxLength(20)
                .IsFixedLength()
                .HasColumnName("ParametreRPT");
            entity.Property(e => e.Requete).HasColumnType("ntext");
            entity.Property(e => e.TypeChamp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ParametreSfc>(entity =>
        {
            entity.HasKey(e => new { e.TParametre, e.NParametre, e.ScParametre });

            entity.ToTable("ParametreSFC");

            entity.Property(e => e.TParametre)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("T_Parametre");
            entity.Property(e => e.NParametre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("N_Parametre");
            entity.Property(e => e.ScParametre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("SC_Parametre");
            entity.Property(e => e.CodeParametre)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("Code_Parametre");
        });

        modelBuilder.Entity<Planning>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Planning");

            entity.Property(e => e.AllDay)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.AllowDelete)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.AllowEdit)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.BackGroundId).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.End)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.HeurePla)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.RecurrenceCount).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.RecurrenceEnd)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.RecurrenceFrequency)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.RecurrenceInterval).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.RecurrenceStart)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Start)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.StatusId).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.Summary)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Terrain)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.UniqueId)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS");
        });

        modelBuilder.Entity<Planning1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Planning1");

            entity.Property(e => e.AllDay)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.AllowDelete)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.AllowEdit)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.BackGroundId).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.Description)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.End).HasMaxLength(50);
            entity.Property(e => e.HeurePla)
                .HasMaxLength(20)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Idab)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("IDAB");
            entity.Property(e => e.Location)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RecurrenceCount).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.RecurrenceEnd)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RecurrenceFrequency)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RecurrenceInterval).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.RecurrenceStart)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Start).HasMaxLength(50);
            entity.Property(e => e.StatusId).HasColumnType("decimal(10, 0)");
            entity.Property(e => e.Summary)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Terrain)
                .HasMaxLength(10)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Pmp3112>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("pmp3112");

            entity.Property(e => e.Adesignation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Pmp)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PMP");
        });

        modelBuilder.Entity<PrdNomenclature>(entity =>
        {
            entity.HasKey(e => new { e.Aref, e.ArefCom });

            entity.ToTable("PrdNomenclature");

            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS")
                .HasColumnName("ARef");
            entity.Property(e => e.ArefCom)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS")
                .HasColumnName("ARefCom");
            entity.Property(e => e.IdPf).HasColumnName("IdPF");
            entity.Property(e => e.IdPfp).HasColumnName("IdPFP");
        });

        modelBuilder.Entity<PvcPehd>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("'PVC PEHD$'");

            entity.Property(e => e.Aref)
                .HasMaxLength(255)
                .HasColumnName("ARef");
            entity.Property(e => e.Categorie)
                .HasMaxLength(255)
                .HasColumnName("CATEGORIE ");
            entity.Property(e => e.Désignation)
                .HasMaxLength(255)
                .HasColumnName("________Désignation_________");
            entity.Property(e => e.Famille).HasMaxLength(255);
            entity.Property(e => e.SousFamille)
                .HasMaxLength(255)
                .HasColumnName("SOUS FAMILLE ");
        });

        modelBuilder.Entity<PvcPr>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("'PVC PR$'");

            entity.Property(e => e.Aref)
                .HasMaxLength(255)
                .HasColumnName("ARef");
            entity.Property(e => e.Categorie)
                .HasMaxLength(255)
                .HasColumnName("CATEGORIE");
            entity.Property(e => e.Désignation)
                .HasMaxLength(255)
                .HasColumnName("________Désignation_________");
            entity.Property(e => e.Famille)
                .HasMaxLength(255)
                .HasColumnName("FAMILLE");
            entity.Property(e => e.SousFamille)
                .HasMaxLength(255)
                .HasColumnName("SOUS FAMILLE ");
        });

        modelBuilder.Entity<RaccordASouder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("'RACCORD A SOUDER$'");

            entity.Property(e => e.Aref)
                .HasMaxLength(255)
                .HasColumnName("ARef");
            entity.Property(e => e.Categorie)
                .HasMaxLength(255)
                .HasColumnName("CATEGORIE");
            entity.Property(e => e.Désignation)
                .HasMaxLength(255)
                .HasColumnName("________Désignation_________");
            entity.Property(e => e.Famille)
                .HasMaxLength(255)
                .HasColumnName("FAMILLE");
            entity.Property(e => e.SousCategorie)
                .HasMaxLength(255)
                .HasColumnName("SOUS CATEGORIE");
            entity.Property(e => e.SousFamille)
                .HasMaxLength(255)
                .HasColumnName("SOUS FAMILLE ");
        });

        modelBuilder.Entity<RapportActivite>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RapportActivite");

            entity.Property(e => e.Nbre).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.Semaine).HasColumnName("semaine");
            entity.Property(e => e.Type)
                .HasMaxLength(31)
                .IsUnicode(false)
                .HasColumnName("type");
        });

        modelBuilder.Entity<RefD>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RefD");

            entity.Property(e => e.Docrefext)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
        });

        modelBuilder.Entity<RelationDocument>(entity =>
        {
            entity.HasKey(e => new { e.CodeDoc, e.CodeDocR });

            entity.ToTable("RelationDocument");

            entity.Property(e => e.CodeDoc)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.CodeDocR)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.ProcDoc)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.SelectionLigne)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
        });

        modelBuilder.Entity<ReleveImpayeTuni>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ReleveImpayeTunis");

            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.BudgetType)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.Cref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CRef");
            entity.Property(e => e.DateCreation).HasColumnType("smalldatetime");
            entity.Property(e => e.Des).HasMaxLength(250);
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MontantR).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<RessourceMatCritere>(entity =>
        {
            entity.HasKey(e => new { e.Ref, e.NCriters });

            entity.ToTable("RessourceMatCritere");

            entity.Property(e => e.Ref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NCriters)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("N_criters");
            entity.Property(e => e.Valeur)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
        });

        modelBuilder.Entity<RessourcesMateriel>(entity =>
        {
            entity.HasKey(e => e.Rmmatricule);

            entity.ToTable("RessourcesMateriel");

            entity.Property(e => e.Rmmatricule)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("RMMatricule");
            entity.Property(e => e.RmcoutAcquisition).HasColumnName("RMCoutAcquisition");
            entity.Property(e => e.RmdateAcquisition)
                .HasColumnType("smalldatetime")
                .HasColumnName("RMDateAcquisition");
            entity.Property(e => e.Rmdesignation)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("RMDesignation");
            entity.Property(e => e.Rmfonction)
                .HasMaxLength(255)
                .UseCollation("French_CI_AI")
                .HasColumnName("RMFonction");
            entity.Property(e => e.Rmmarque)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("RMMarque");
            entity.Property(e => e.UniqueId).ValueGeneratedOnAdd();
            entity.Property(e => e.ZoneRm)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<Rqeimed>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RQEIMED");

            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Breception)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Caisse)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Commentaire).HasMaxLength(250);
            entity.Property(e => e.DateAnnuler).HasColumnType("smalldatetime");
            entity.Property(e => e.DateCreation).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch2).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEven).HasColumnType("datetime");
            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateP).HasColumnType("smalldatetime");
            entity.Property(e => e.DateR).HasColumnType("smalldatetime");
            entity.Property(e => e.DateV).HasColumnType("smalldatetime");
            entity.Property(e => e.Des).HasMaxLength(250);
            entity.Property(e => e.DocCloture).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMntLettre).HasMaxLength(500);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Docref1).HasMaxLength(20);
            entity.Property(e => e.Ematricule)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("EMatricule");
            entity.Property(e => e.Etat).HasColumnType("smalldatetime");
            entity.Property(e => e.Imput1)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("imput1");
            entity.Property(e => e.Imputation)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MontantR).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.NumEncDec2).HasMaxLength(20);
            entity.Property(e => e.Pdecommentaire)
                .HasMaxLength(250)
                .HasColumnName("PDECommentaire");
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Rib)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("RIB");
            entity.Property(e => e.Rib1).HasMaxLength(100);
            entity.Property(e => e.Ribp)
                .HasMaxLength(100)
                .HasColumnName("RIBP");
            entity.Property(e => e.TypeEncDec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.VisibleEd).HasColumnName("VisibleED");
        });

        modelBuilder.Entity<Rqetarak>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("RQETARAK");

            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Breception)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Caisse)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Commentaire).HasMaxLength(250);
            entity.Property(e => e.DateAnnuler).HasColumnType("smalldatetime");
            entity.Property(e => e.DateCreation).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch2).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEven).HasColumnType("datetime");
            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateP).HasColumnType("smalldatetime");
            entity.Property(e => e.DateR).HasColumnType("smalldatetime");
            entity.Property(e => e.DateV).HasColumnType("smalldatetime");
            entity.Property(e => e.Des).HasMaxLength(250);
            entity.Property(e => e.DocCloture).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMntLettre).HasMaxLength(500);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Docref1).HasMaxLength(20);
            entity.Property(e => e.Ematricule)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("EMatricule");
            entity.Property(e => e.Etat).HasColumnType("smalldatetime");
            entity.Property(e => e.Imput1)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("imput1");
            entity.Property(e => e.Imputation)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MontantR).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.NumEncDec2).HasMaxLength(20);
            entity.Property(e => e.Pdecommentaire)
                .HasMaxLength(250)
                .HasColumnName("PDECommentaire");
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Rib)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("RIB");
            entity.Property(e => e.Rib1).HasMaxLength(100);
            entity.Property(e => e.Ribp)
                .HasMaxLength(100)
                .HasColumnName("RIBP");
            entity.Property(e => e.TypeEncDec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.VisibleEd).HasColumnName("VisibleED");
        });

        modelBuilder.Entity<Secteur>(entity =>
        {
            entity.ToTable("Secteur");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.NPays)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("N_Pays");
            entity.Property(e => e.NSecteur)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("N_Secteur");
            entity.Property(e => e.NVille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("N_Ville");
            entity.Property(e => e.Sref)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("SRef");
        });

        modelBuilder.Entity<ServicePanne>(entity =>
        {
            entity.HasKey(e => e.Panne);

            entity.ToTable("ServicePanne");

            entity.Property(e => e.Panne)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Idservice)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("IDService");
        });

        modelBuilder.Entity<ServiceReception>(entity =>
        {
            entity.HasKey(e => e.BonReception);

            entity.ToTable("ServiceReception");

            entity.Property(e => e.BonReception)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Date).HasColumnType("smalldatetime");
            entity.Property(e => e.Etat)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Marque)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Model)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NumSerie)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Reference)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Tiers)
                .HasMaxLength(10)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
        });

        modelBuilder.Entity<ServiceReceptionDetailPanne>(entity =>
        {
            entity.HasKey(e => new { e.BonReception, e.IdServicePanne });

            entity.ToTable("ServiceReceptionDetailPanne");

            entity.Property(e => e.BonReception)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Id).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<Sheet1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Sheet1");

            entity.Property(e => e.Categorie).HasMaxLength(255);
            entity.Property(e => e.Codetiers).HasMaxLength(255);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.EcartDelaiPaie).HasColumnName("Ecart delai paie");
            entity.Property(e => e.Echeance)
                .HasColumnType("datetime")
                .HasColumnName("echeance");
            entity.Property(e => e.F10).HasMaxLength(255);
            entity.Property(e => e.F11).HasMaxLength(255);
            entity.Property(e => e.F13).HasMaxLength(255);
            entity.Property(e => e.F19).HasMaxLength(255);
            entity.Property(e => e.F2).HasColumnType("datetime");
            entity.Property(e => e.F22).HasMaxLength(255);
            entity.Property(e => e.F23).HasMaxLength(255);
            entity.Property(e => e.F3).HasColumnType("datetime");
            entity.Property(e => e.F4).HasColumnType("datetime");
            entity.Property(e => e.F6).HasMaxLength(255);
            entity.Property(e => e.MtNominale).HasColumnName("Mt nominale");
            entity.Property(e => e.Nature).HasMaxLength(255);
            entity.Property(e => e.NbJours).HasColumnName("Nb#jours");
            entity.Property(e => e.Numint).HasMaxLength(255);
            entity.Property(e => e.RaisonSociale)
                .HasMaxLength(255)
                .HasColumnName("Raison sociale");
            entity.Property(e => e.Representant).HasMaxLength(255);
            entity.Property(e => e.Secteur).HasMaxLength(255);
        });

        modelBuilder.Entity<SoldeConge01012023>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SoldeConge01012023");

            entity.Property(e => e.F10).HasMaxLength(255);
            entity.Property(e => e.F11).HasMaxLength(255);
            entity.Property(e => e.F4).HasMaxLength(255);
            entity.Property(e => e.F5).HasMaxLength(255);
            entity.Property(e => e.F6).HasMaxLength(255);
            entity.Property(e => e.F7).HasMaxLength(255);
            entity.Property(e => e.F8).HasMaxLength(255);
            entity.Property(e => e.F9).HasMaxLength(255);
            entity.Property(e => e.NomEtPrenom)
                .HasMaxLength(255)
                .HasColumnName("NOM ET PRENOM");
            entity.Property(e => e.SoldeAnterieur).HasColumnName("SOLDE ANTERIEUR");
        });

        modelBuilder.Entity<SoldeInit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SoldeInit");

            entity.Property(e => e.F2).HasMaxLength(255);
            entity.Property(e => e.Tiers).HasMaxLength(255);
            entity.Property(e => e.Tiers1).HasMaxLength(255);
        });

        modelBuilder.Entity<SoldeInitialBrima>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SoldeInitialBrima");

            entity.Property(e => e.Code).HasColumnName("CODE");
            entity.Property(e => e.F4).HasMaxLength(255);
            entity.Property(e => e.F5).HasMaxLength(255);
            entity.Property(e => e.F6).HasMaxLength(255);
            entity.Property(e => e.Tiers).HasMaxLength(255);
        });

        modelBuilder.Entity<Somme1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("somme1");

            entity.Property(e => e.Aout).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Avril).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Client)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Décembre).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Février).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Janvier).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Juillet).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Juin).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Mai).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Mars).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Novembre).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Octobre).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Septembre).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Total).HasColumnType("decimal(38, 3)");
        });

        modelBuilder.Entity<SommeArticleBc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SommeArticleBC");

            entity.Property(e => e.Août).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Article)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Avril).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Décembre).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Février).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Janvier).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Juillet).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Juin).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Mai).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Mars).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Novembre).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Octobre).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Septembre).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Total).HasColumnType("decimal(38, 3)");
        });

        modelBuilder.Entity<SommeArticleBl>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SommeArticleBL");

            entity.Property(e => e.Août).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Article)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Avril).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Décembre).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Février).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Janvier).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Juillet).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Juin).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Mai).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Mars).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Novembre).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Octobre).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Septembre).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Total).HasColumnType("decimal(38, 3)");
        });

        modelBuilder.Entity<SousCategorie>(entity =>
        {
            entity.HasKey(e => new { e.NSousCat, e.NCat }).HasName("PK__SousCate__B86FDE39353C2D9A");

            entity.ToTable("SousCategorie");

            entity.Property(e => e.NSousCat)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("N_Sous_Cat");
            entity.Property(e => e.NCat)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("N_Cat");
            entity.Property(e => e.PrefixCat)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("Prefix_Cat");
        });

        modelBuilder.Entity<SousFamille>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SousFamille$");

            entity.Property(e => e.Categorie)
                .HasMaxLength(255)
                .HasColumnName("CATEGORIE");
            entity.Property(e => e.Designation)
                .HasMaxLength(255)
                .HasColumnName("DESIGNATION");
            entity.Property(e => e.Famille)
                .HasMaxLength(255)
                .HasColumnName("FAMILLE");
            entity.Property(e => e.Ref)
                .HasMaxLength(255)
                .HasColumnName("REF");
            entity.Property(e => e.SousCategorie).HasColumnName("SOUS CATEGORIE");
            entity.Property(e => e.SousFamille1)
                .HasMaxLength(255)
                .HasColumnName("SOUS FAMILLE ");
        });

        modelBuilder.Entity<SyntheseDesPrix>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SyntheseDesPrix");

            entity.Property(e => e.Amarge)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("AMarge");
            entity.Property(e => e.AprevientHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APRevientHT");
            entity.Property(e => e.Apvttc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APVTTC");
            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.Cref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CRef");
            entity.Property(e => e.DocArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocArtDesignation)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocPrevient)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DocPRevient");
            entity.Property(e => e.DocPunit).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTotalTtc)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("DocTotalTTC");
            entity.Property(e => e.Frais)
                .HasColumnType("decimal(38, 3)")
                .HasColumnName("frais");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<SyntheseDesPrix2222>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SyntheseDesPrix2222");

            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.Cref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CRef");
            entity.Property(e => e.DocArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocArtDesignation)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Frais)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("%Frais");
            entity.Property(e => e.FraisUnitaire)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Frais.Unitaire");
            entity.Property(e => e.Marque)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("%Marque");
            entity.Property(e => e.MontantNet).HasColumnName("Montant.net");
            entity.Property(e => e.PrixNet)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Net");
            entity.Property(e => e.PrixRevientArticle)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Revient.Article");
            entity.Property(e => e.PrixTotalRevient)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Total.Revient");
            entity.Property(e => e.PrixVteArticle)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Vte.Article");
            entity.Property(e => e.PrixVteCalculé)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Vte.Calculé");
            entity.Property(e => e.PrixVteDonné)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Vte.Donné");
            entity.Property(e => e.PrixVteTtc)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Vte.TTC");
            entity.Property(e => e.PuRevient)
                .HasColumnType("decimal(19, 3)")
                .HasColumnName("PU.Revient");
            entity.Property(e => e.TotalFrais)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Total.Frais");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.Uniqueid1).HasColumnName("uniqueid1");
        });

        modelBuilder.Entity<SynthéseDesPrixNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SynthéseDesPrixNEW");

            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.Cref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CRef");
            entity.Property(e => e.DocArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocArtDesignation)
                .HasMaxLength(250)
                .IsFixedLength();
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Frais)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("%Frais");
            entity.Property(e => e.FraisUnitaire)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Frais.Unitaire");
            entity.Property(e => e.Marque)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("%Marque");
            entity.Property(e => e.MontantNet).HasColumnName("Montant.net");
            entity.Property(e => e.PrixNet)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Net");
            entity.Property(e => e.PrixRevientArticle)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Revient.Article");
            entity.Property(e => e.PrixTotalRevient)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Total.Revient");
            entity.Property(e => e.PrixVteArticle)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Vte.Article");
            entity.Property(e => e.PrixVteCalculé)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Vte.Calculé");
            entity.Property(e => e.PrixVteDonné)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Vte.Donné");
            entity.Property(e => e.PrixVteTtc)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Vte.TTC");
            entity.Property(e => e.PuRevient)
                .HasColumnType("decimal(19, 3)")
                .HasColumnName("PU.Revient");
            entity.Property(e => e.TotalFrais)
                .HasColumnType("decimal(19, 3)")
                .HasColumnName("Total.Frais");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.Uniqueid1).HasColumnName("uniqueid1");
        });

        modelBuilder.Entity<SynthéseDesPrixNewOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SynthéseDesPrixNEW_OLD");

            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.Cref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CRef");
            entity.Property(e => e.DocArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocArtDesignation)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Frais)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("%Frais");
            entity.Property(e => e.FraisUnitaire)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Frais.Unitaire");
            entity.Property(e => e.Marque)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("%Marque");
            entity.Property(e => e.MontantNet).HasColumnName("Montant.net");
            entity.Property(e => e.PrixNet)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Net");
            entity.Property(e => e.PrixRevientArticle)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Revient.Article");
            entity.Property(e => e.PrixTotalRevient)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Total.Revient");
            entity.Property(e => e.PrixVteArticle)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Vte.Article");
            entity.Property(e => e.PrixVteCalculé)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Vte.Calculé");
            entity.Property(e => e.PrixVteDonné)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Vte.Donné");
            entity.Property(e => e.PrixVteTtc)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Vte.TTC");
            entity.Property(e => e.PuRevient)
                .HasColumnType("decimal(19, 3)")
                .HasColumnName("PU.Revient");
            entity.Property(e => e.TotalFrais)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Total.Frais");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.Uniqueid1).HasColumnName("uniqueid1");
        });

        modelBuilder.Entity<SynthéseDesPrixOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("SynthéseDesPrixOLD");

            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.Cref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CRef");
            entity.Property(e => e.DocArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocArtDesignation)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Frais)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("%Frais");
            entity.Property(e => e.FraisUnitaire)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Frais.Unitaire");
            entity.Property(e => e.Marque)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("%Marque");
            entity.Property(e => e.MontantNet).HasColumnName("Montant.net");
            entity.Property(e => e.PrixNet)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Net");
            entity.Property(e => e.PrixRevientArticle)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Revient.Article");
            entity.Property(e => e.PrixTotalRevient)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Total.Revient");
            entity.Property(e => e.PrixVteArticle)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Vte.Article");
            entity.Property(e => e.PrixVteCalculé)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Vte.Calculé");
            entity.Property(e => e.PrixVteDonné)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Vte.Donné");
            entity.Property(e => e.PrixVteTtc)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Prix.Vte.TTC");
            entity.Property(e => e.PuRevient)
                .HasColumnType("decimal(19, 3)")
                .HasColumnName("PU.Revient");
            entity.Property(e => e.TotalFrais)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Total.Frais");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.Uniqueid1).HasColumnName("uniqueid1");
        });

        modelBuilder.Entity<TVirementTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("T_Virement_Temp");

            entity.Property(e => e.Aa)
                .HasMaxLength(20)
                .HasColumnName("aa");
            entity.Property(e => e.Bb)
                .HasMaxLength(20)
                .UseCollation("French_CI_AS")
                .HasColumnName("bb");
            entity.Property(e => e.Cc)
                .HasMaxLength(50)
                .UseCollation("French_CI_AS")
                .HasColumnName("cc");
            entity.Property(e => e.Dd)
                .HasMaxLength(20)
                .HasColumnName("dd");
            entity.Property(e => e.Ee)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("ee");
            entity.Property(e => e.Ff).HasColumnName("ff");
        });

        modelBuilder.Entity<Table1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("'Table 1$'");

            entity.Property(e => e.F1).HasColumnType("datetime");
            entity.Property(e => e.F2).HasMaxLength(255);
            entity.Property(e => e.F4).HasColumnType("datetime");
            entity.Property(e => e.F6).HasMaxLength(255);
        });

        modelBuilder.Entity<TableTier>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Ccin)
                .HasMaxLength(255)
                .HasColumnName("CCIN");
            entity.Property(e => e.CcodeComptable)
                .HasMaxLength(255)
                .UseCollation("French_CI_AI")
                .HasColumnName("CCodeComptable");
            entity.Property(e => e.Cf)
                .HasMaxLength(255)
                .HasColumnName("CF");
            entity.Property(e => e.CmatFiscal)
                .HasMaxLength(255)
                .HasColumnName("CMatFiscal");
            entity.Property(e => e.Cnom).HasMaxLength(255);
            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(255)
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.Cref).HasMaxLength(255);
            entity.Property(e => e.Ctel)
                .HasMaxLength(255)
                .HasColumnName("CTel");
            entity.Property(e => e.Ctva)
                .HasMaxLength(255)
                .HasColumnName("CTVA");
            entity.Property(e => e.DocRepresentant)
                .HasMaxLength(255)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.F17).HasMaxLength(255);
            entity.Property(e => e.F18).HasMaxLength(255);
            entity.Property(e => e.F19).HasMaxLength(255);
            entity.Property(e => e.F20).HasMaxLength(255);
            entity.Property(e => e.F21).HasMaxLength(255);
            entity.Property(e => e.F22).HasMaxLength(255);
            entity.Property(e => e.F23).HasMaxLength(255);
            entity.Property(e => e.F24).HasMaxLength(255);
            entity.Property(e => e.F25).HasMaxLength(255);
            entity.Property(e => e.F26).HasMaxLength(255);
            entity.Property(e => e.F27).HasMaxLength(255);
            entity.Property(e => e.F28).HasMaxLength(255);
            entity.Property(e => e.F29).HasMaxLength(255);
            entity.Property(e => e.F30).HasMaxLength(255);
            entity.Property(e => e.F31).HasMaxLength(255);
            entity.Property(e => e.F32).HasMaxLength(255);
            entity.Property(e => e.F33).HasMaxLength(255);
            entity.Property(e => e.F34).HasMaxLength(255);
            entity.Property(e => e.F35).HasMaxLength(255);
            entity.Property(e => e.F36).HasMaxLength(255);
            entity.Property(e => e.F37).HasMaxLength(255);
            entity.Property(e => e.F38).HasMaxLength(255);
            entity.Property(e => e.F39).HasMaxLength(255);
            entity.Property(e => e.F40).HasMaxLength(255);
            entity.Property(e => e.F41).HasMaxLength(255);
            entity.Property(e => e.F42).HasMaxLength(255);
            entity.Property(e => e.F43).HasMaxLength(255);
            entity.Property(e => e.F44).HasMaxLength(255);
            entity.Property(e => e.F45).HasMaxLength(255);
            entity.Property(e => e.F46).HasMaxLength(255);
            entity.Property(e => e.F47).HasMaxLength(255);
            entity.Property(e => e.F48).HasMaxLength(255);
            entity.Property(e => e.F49).HasMaxLength(255);
            entity.Property(e => e.F9).HasMaxLength(255);
            entity.Property(e => e.Rc)
                .HasMaxLength(255)
                .HasColumnName("RC");
            entity.Property(e => e.Typec).HasMaxLength(255);
            entity.Property(e => e.UniqueIdt).HasColumnName("UniqueIDT");
        });

        modelBuilder.Entity<TableauCongeAnnee>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TableauCongeAnnee");

            entity.Property(e => e.AnnéeDEntréeEnService).HasColumnName("Année d'entrée en service");
            entity.Property(e => e.F2).HasMaxLength(255);
            entity.Property(e => e.F22).HasMaxLength(255);
            entity.Property(e => e.NomEtPrénom)
                .HasMaxLength(255)
                .HasColumnName("Nom et Prénom");
            entity.Property(e => e.Solde)
                .HasMaxLength(255)
                .HasColumnName("SOLDE");
            entity.Property(e => e.Total)
                .HasMaxLength(255)
                .HasColumnName("TOTAL");
            entity.Property(e => e._2009).HasColumnName("2009");
            entity.Property(e => e._2010).HasColumnName("2010");
            entity.Property(e => e._2011).HasColumnName("2011");
            entity.Property(e => e._2012).HasColumnName("2012");
            entity.Property(e => e._2013).HasColumnName("2013");
            entity.Property(e => e._2014).HasColumnName("2014");
            entity.Property(e => e._2015).HasColumnName("2015");
            entity.Property(e => e._2016).HasColumnName("2016");
            entity.Property(e => e._2017).HasColumnName("2017");
            entity.Property(e => e._2018).HasColumnName("2018");
            entity.Property(e => e._2019).HasColumnName("2019");
            entity.Property(e => e._20191)
                .HasMaxLength(255)
                .HasColumnName("20191");
            entity.Property(e => e._2020).HasColumnName("2020");
            entity.Property(e => e._2021).HasColumnName("2021");
            entity.Property(e => e._2022).HasColumnName("2022");
            entity.Property(e => e._2023).HasColumnName("2023");
            entity.Property(e => e._2024).HasColumnName("2024");
        });

        modelBuilder.Entity<TauxTva>(entity =>
        {
            entity.HasKey(e => e.NTva);

            entity.ToTable("TauxTVA");

            entity.Property(e => e.NTva)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("N_TVA");
            entity.Property(e => e.TauxTva1).HasColumnName("Taux_TVA");
        });

        modelBuilder.Entity<TbcalculMarge>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TBCalculMarge");

            entity.Property(e => e.Ca)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("CA");
            entity.Property(e => e.Canegoce)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("CANegoce");
            entity.Property(e => e.Casifcol)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("CASifcol");
            entity.Property(e => e.CoutMarVendu).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.CoutMarVenduNegoce).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.CoutMarVenduSifcol).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.CumulAch).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.CumulAchNegoce).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.CumulAchSifcol).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Marge).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.MargeNegoce).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.MargeSifcol).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ValDebStk).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ValDebStkNegoce).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ValDebStkSifcol).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ValFinStk).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ValFinStkNegoce).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.ValFinStkSifcol).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<Tcv>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TCV$");

            entity.Property(e => e.Active).HasColumnName("active");
            entity.Property(e => e.Color)
                .HasMaxLength(255)
                .HasColumnName("color");
            entity.Property(e => e.Dd)
                .HasMaxLength(255)
                .HasColumnName("dd");
            entity.Property(e => e.F14).HasMaxLength(255);
            entity.Property(e => e.Ff)
                .HasMaxLength(255)
                .HasColumnName("ff");
            entity.Property(e => e.Gg)
                .HasMaxLength(255)
                .HasColumnName("gg");
            entity.Property(e => e.Hh)
                .HasMaxLength(255)
                .HasColumnName("hh");
            entity.Property(e => e.Proc)
                .HasMaxLength(255)
                .HasColumnName("proc");
            entity.Property(e => e.Titre).HasMaxLength(255);
            entity.Property(e => e.UserInf).HasMaxLength(255);
            entity.Property(e => e.Xx).HasColumnName("xx");
            entity.Property(e => e.Yy)
                .HasMaxLength(255)
                .HasColumnName("yy");
            entity.Property(e => e.Zz)
                .HasMaxLength(255)
                .HasColumnName("zz");
        });

        modelBuilder.Entity<Tier>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable(tb =>
                {
                    tb.HasTrigger("AFTERDelUpdTiers");
                    tb.HasTrigger("AFTERDeleteC");
                    tb.HasTrigger("ForDeleteC");
                    tb.HasTrigger("ForINSERTTiers");
                });

            entity.HasIndex(e => e.DocRepresentant, "IX_Tiers");

            entity.HasIndex(e => new { e.Cref, e.Cf }, "NonClusteredIndex-20230529-091613");

            entity.Property(e => e.Cadresse)
                .HasMaxLength(500)
                .UseCollation("French_CI_AS")
                .HasColumnName("CAdresse");
            entity.Property(e => e.Cbanque)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CBanque");
            entity.Property(e => e.Cbloq).HasColumnName("CBloq");
            entity.Property(e => e.CbloqDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("CBloqDate");
            entity.Property(e => e.Cbloqer).HasColumnName("CBloqer");
            entity.Property(e => e.Ccin)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS")
                .HasColumnName("CCIN");
            entity.Property(e => e.CcodeComptable)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CCodeComptable");
            entity.Property(e => e.CcodePostal)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CCodePostal");
            entity.Property(e => e.CcompteCredi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CCompteCredi");
            entity.Property(e => e.CcreditMax).HasColumnName("CCreditMax");
            entity.Property(e => e.Cf)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS")
                .HasColumnName("CF");
            entity.Property(e => e.Cfidelite).HasColumnName("CFidelite");
            entity.Property(e => e.CmatFiscal)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CMatFiscal");
            entity.Property(e => e.Cnom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CNom");
            entity.Property(e => e.CodeDouane)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.CodeFidelite)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CodePd)
                .HasMaxLength(20)
                .HasColumnName("CodePD");
            entity.Property(e => e.Commentaire)
                .HasMaxLength(90)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CommentaireCf)
                .HasMaxLength(250)
                .HasColumnName("CommentaireCF");
            entity.Property(e => e.Cpays)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CPays");
            entity.Property(e => e.Cprenom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CPrenom");
            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.Cref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CRef");
            entity.Property(e => e.Cremise).HasColumnName("CRemise");
            entity.Property(e => e.Crib)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRIB");
            entity.Property(e => e.Crue)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRue");
            entity.Property(e => e.Csecteur)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CSecteur");
            entity.Property(e => e.Csolde)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("CSolde");
            entity.Property(e => e.Cterme).HasColumnName("CTerme");
            entity.Property(e => e.Ctva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CTVA");
            entity.Property(e => e.Cville)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CVille");
            entity.Property(e => e.DocRepresentant)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTypeP)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.EncBl).HasColumnName("EncBL");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Koniya)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ModeRegT)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NumDossier)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Rc)
                .HasMaxLength(50)
                .HasColumnName("RC");
            entity.Property(e => e.Score).HasColumnType("decimal(18, 1)");
            entity.Property(e => e.SecteurActiv)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Tel)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.TypeC)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.UniqueIdt)
                .ValueGeneratedOnAdd()
                .HasColumnName("UniqueIDT");
        });

        modelBuilder.Entity<Tiers30082018>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tiers30082018");

            entity.Property(e => e.Cadresse)
                .UseCollation("French_CI_AS")
                .HasColumnType("text")
                .HasColumnName("CAdresse");
            entity.Property(e => e.Cbanque)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CBanque");
            entity.Property(e => e.Cbloq).HasColumnName("CBloq");
            entity.Property(e => e.CbloqDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("CBloqDate");
            entity.Property(e => e.Cbloqer).HasColumnName("CBloqer");
            entity.Property(e => e.Ccin)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS")
                .HasColumnName("CCIN");
            entity.Property(e => e.CcodeComptable)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CCodeComptable");
            entity.Property(e => e.CcodePostal)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CCodePostal");
            entity.Property(e => e.CcompteCredi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CCompteCredi");
            entity.Property(e => e.CcreditMax).HasColumnName("CCreditMax");
            entity.Property(e => e.Cf)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS")
                .HasColumnName("CF");
            entity.Property(e => e.Cfidelite).HasColumnName("CFidelite");
            entity.Property(e => e.CmatFiscal)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CMatFiscal");
            entity.Property(e => e.Cnom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CNom");
            entity.Property(e => e.CodeDouane)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.CodeFidelite)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CodePd)
                .HasMaxLength(20)
                .HasColumnName("CodePD");
            entity.Property(e => e.Commentaire)
                .HasMaxLength(90)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CommentaireCf)
                .HasMaxLength(250)
                .HasColumnName("CommentaireCF");
            entity.Property(e => e.Cpays)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CPays");
            entity.Property(e => e.Cprenom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CPrenom");
            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.Cref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CRef");
            entity.Property(e => e.Cremise).HasColumnName("CRemise");
            entity.Property(e => e.Crib)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRIB");
            entity.Property(e => e.Crue)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRue");
            entity.Property(e => e.Csecteur)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CSecteur");
            entity.Property(e => e.Csolde)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("CSolde");
            entity.Property(e => e.Cterme).HasColumnName("CTerme");
            entity.Property(e => e.Ctva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CTVA");
            entity.Property(e => e.Cville)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CVille");
            entity.Property(e => e.DocRepresentant)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTypeP)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.EncBl).HasColumnName("EncBL");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Koniya)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ModeRegT)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NumDossier)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Rc)
                .HasMaxLength(50)
                .HasColumnName("RC");
            entity.Property(e => e.SecteurActiv)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Tel)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.TypeC)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.UniqueIdt)
                .ValueGeneratedOnAdd()
                .HasColumnName("UniqueIDT");
        });

        modelBuilder.Entity<TiersCarteVisite>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TiersCarteVisite");

            entity.Property(e => e.Color).HasMaxLength(50);
            entity.Property(e => e.DocumentBc).HasColumnName("DocumentBC");
            entity.Property(e => e.Ntype)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ParamCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ParamName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ProcSelect).HasMaxLength(255);
            entity.Property(e => e.Titre).HasMaxLength(50);
            entity.Property(e => e.TypeAff)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniqueId).ValueGeneratedOnAdd();
            entity.Property(e => e.UserInf)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TiersCarteVisite23102021Err>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TiersCarteVisite23102021ERR");

            entity.Property(e => e.Color).HasMaxLength(50);
            entity.Property(e => e.DocumentBc).HasColumnName("DocumentBC");
            entity.Property(e => e.Ntype)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ParamCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ParamName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ProcSelect).HasMaxLength(255);
            entity.Property(e => e.Titre).HasMaxLength(50);
            entity.Property(e => e.TypeAff)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniqueId).ValueGeneratedOnAdd();
            entity.Property(e => e.UserInf)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TiersCarteVisiteGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TiersCarteVisiteGroup");

            entity.Property(e => e.Colonne)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Fonction)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("2:Sum\r\n3:Min\r\n4:Max\r\n5:Last\r\n6:First\r\n7:Count\r\n8:Avg\r\n9:StDev\r\n10:Var");
            entity.Property(e => e.TopBottom)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasComment("Group Header Row\r\nTop Summary Rows\r\nBottom Summary Rows");
        });

        modelBuilder.Entity<TiersCarteVisiteNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TiersCarteVisite_NEW");

            entity.Property(e => e.Color).HasMaxLength(50);
            entity.Property(e => e.DocumentBc).HasColumnName("DocumentBC");
            entity.Property(e => e.Ntype)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ParamCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ParamName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ProcSelect).HasMaxLength(255);
            entity.Property(e => e.Titre).HasMaxLength(50);
            entity.Property(e => e.TypeAff)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniqueId).ValueGeneratedOnAdd();
            entity.Property(e => e.UserInf)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TiersCarteVisiteNiveau>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TiersCarteVisiteNiveau");

            entity.Property(e => e.ColonneRelation).HasMaxLength(250);
            entity.Property(e => e.ProcNiv1).HasMaxLength(250);
            entity.Property(e => e.ProcNiv2).HasMaxLength(250);
        });

        modelBuilder.Entity<TiersCarteVisiteRt2610>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TiersCarteVisiteRT2610");

            entity.Property(e => e.Color).HasMaxLength(50);
            entity.Property(e => e.DocumentBc).HasColumnName("DocumentBC");
            entity.Property(e => e.Ntype)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ParamCode)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ParamName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.ProcSelect).HasMaxLength(255);
            entity.Property(e => e.Titre).HasMaxLength(50);
            entity.Property(e => e.TypeAff)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniqueId).ValueGeneratedOnAdd();
            entity.Property(e => e.UserInf)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<TiersCritere>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TiersCritere");

            entity.Property(e => e.CritCl)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CritCL");
            entity.Property(e => e.Designation).HasMaxLength(250);
        });

        modelBuilder.Entity<TiersCritereDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TiersCritereDetail");

            entity.Property(e => e.Commentaire).HasMaxLength(255);
            entity.Property(e => e.CritCl)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CritCL");
            entity.Property(e => e.Designation).HasMaxLength(250);
            entity.Property(e => e.Score).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.UniqueId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("UniqueID");
        });

        modelBuilder.Entity<TiersDecision>(entity =>
        {
            entity.HasKey(e => new { e.TrRef, e.NumDecision });

            entity.ToTable("TiersDecision");

            entity.Property(e => e.TrRef)
                .HasMaxLength(10)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NumDecision)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Comm).HasMaxLength(250);
            entity.Property(e => e.DateDebut).HasColumnType("smalldatetime");
            entity.Property(e => e.DateFin).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<TiersHistorique>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TiersHistorique");

            entity.Property(e => e.Action).HasMaxLength(10);
            entity.Property(e => e.ActionDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Cadresse)
                .HasMaxLength(500)
                .HasColumnName("CAdresse");
            entity.Property(e => e.Cbanque)
                .HasMaxLength(50)
                .HasColumnName("CBanque");
            entity.Property(e => e.Cbloq).HasColumnName("CBloq");
            entity.Property(e => e.CbloqDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("CBloqDate");
            entity.Property(e => e.Cbloqer).HasColumnName("CBloqer");
            entity.Property(e => e.Ccin)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CCIN");
            entity.Property(e => e.CcodeComptable)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CCodeComptable");
            entity.Property(e => e.CcodePostal)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CCodePostal");
            entity.Property(e => e.CcompteCredi)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CCompteCredi");
            entity.Property(e => e.CcreditMax).HasColumnName("CCreditMax");
            entity.Property(e => e.Cf)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CF");
            entity.Property(e => e.Cfidelite).HasColumnName("CFidelite");
            entity.Property(e => e.CmatFiscal)
                .HasMaxLength(50)
                .HasColumnName("CMatFiscal");
            entity.Property(e => e.Cnom)
                .HasMaxLength(50)
                .HasColumnName("CNom");
            entity.Property(e => e.CodeDouane)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CodeFidelite)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.CodePd)
                .HasMaxLength(20)
                .HasColumnName("CodePD");
            entity.Property(e => e.Commentaire)
                .HasMaxLength(90)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.CommentaireCf)
                .HasMaxLength(250)
                .HasColumnName("CommentaireCF");
            entity.Property(e => e.Cpays)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CPays");
            entity.Property(e => e.Cprenom)
                .HasMaxLength(50)
                .HasColumnName("CPrenom");
            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.Cref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CRef");
            entity.Property(e => e.Cremise).HasColumnName("CRemise");
            entity.Property(e => e.Crib)
                .HasMaxLength(50)
                .HasColumnName("CRIB");
            entity.Property(e => e.Crue)
                .HasMaxLength(50)
                .HasColumnName("CRue");
            entity.Property(e => e.Csecteur)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CSecteur");
            entity.Property(e => e.Csolde)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("CSolde");
            entity.Property(e => e.Cterme).HasColumnName("CTerme");
            entity.Property(e => e.Ctva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CTVA");
            entity.Property(e => e.Cville)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CVille");
            entity.Property(e => e.DocRepresentant)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocTypeP)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.EncBl).HasColumnName("EncBL");
            entity.Property(e => e.Fax)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Koniya)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ModeRegT)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.NumDossier)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Rc)
                .HasMaxLength(50)
                .HasColumnName("RC");
            entity.Property(e => e.Reftiers)
                .HasMaxLength(20)
                .HasColumnName("reftiers");
            entity.Property(e => e.SecteurActiv).HasMaxLength(50);
            entity.Property(e => e.Tel)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.TypeC)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.UniqueIdt)
                .ValueGeneratedOnAdd()
                .HasColumnName("UniqueIDT");
        });

        modelBuilder.Entity<TiersPlusVente>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TiersPlusVente");

            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Expr1).HasColumnType("decimal(38, 4)");
        });

        modelBuilder.Entity<Tige>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TIGE$");

            entity.Property(e => e.Aref)
                .HasMaxLength(255)
                .HasColumnName("ARef");
            entity.Property(e => e.Categorie)
                .HasMaxLength(255)
                .HasColumnName("CATEGORIE");
            entity.Property(e => e.Désignation)
                .HasMaxLength(255)
                .HasColumnName("________Désignation_________");
            entity.Property(e => e.Famille)
                .HasMaxLength(255)
                .HasColumnName("FAMILLE");
            entity.Property(e => e.SousCat)
                .HasMaxLength(255)
                .HasColumnName("SOUS CAT");
            entity.Property(e => e.SousFamille)
                .HasMaxLength(255)
                .HasColumnName("SOUS FAMILLE ");
        });

        modelBuilder.Entity<Timber>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("timber");

            entity.Property(e => e.DocAnnee)
                .HasMaxLength(255)
                .UseCollation("French_CI_AI")
                .HasColumnName("(DocAnnee)");
            entity.Property(e => e.DocType)
                .HasMaxLength(255)
                .UseCollation("French_CI_AI")
                .HasColumnName("(DocType)");
            entity.Property(e => e.TimberFiscal).HasColumnName("(TimberFiscal)");
        });

        modelBuilder.Entity<TimeOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TimeOrder");
        });

        modelBuilder.Entity<TopRep>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("topRep");

            entity.Property(e => e.Cnom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CNom");
            entity.Property(e => e.Cprenom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CPrenom");
            entity.Property(e => e.DocRepresentant)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Expr1).HasColumnType("decimal(38, 4)");
        });

        modelBuilder.Entity<TotVenteMoi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TotVenteMois");

            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Expr1).HasColumnType("decimal(38, 4)");
        });

        modelBuilder.Entity<Tresorerieprevisionnelle>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("tresorerieprevisionnelle");

            entity.Property(e => e.Col1)
                .HasMaxLength(755)
                .HasColumnName("col1");
            entity.Property(e => e.Col10)
                .HasMaxLength(19)
                .IsUnicode(false)
                .HasColumnName("col10");
            entity.Property(e => e.Col2)
                .HasMaxLength(750)
                .HasColumnName("col2");
            entity.Property(e => e.Col3)
                .HasColumnType("decimal(38, 3)")
                .HasColumnName("col3");
            entity.Property(e => e.Col4)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("col4");
            entity.Property(e => e.Col5).HasColumnName("col5");
            entity.Property(e => e.Col6)
                .HasMaxLength(750)
                .HasColumnName("col6");
            entity.Property(e => e.Col7)
                .HasMaxLength(50)
                .HasColumnName("col7");
            entity.Property(e => e.Col8)
                .HasMaxLength(100)
                .HasColumnName("col8");
            entity.Property(e => e.Col9).HasColumnName("col9");
        });

        modelBuilder.Entity<TubeInox>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("'tube inox$'");

            entity.Property(e => e.Aref)
                .HasMaxLength(255)
                .HasColumnName("ARef");
            entity.Property(e => e.AuniteVnt)
                .HasMaxLength(255)
                .HasColumnName("AUniteVnt");
            entity.Property(e => e.AutreAction)
                .HasMaxLength(255)
                .HasColumnName("AUTRE ACTION ");
            entity.Property(e => e.Catégorie).HasMaxLength(255);
            entity.Property(e => e.Désignation)
                .HasMaxLength(255)
                .HasColumnName("________Désignation_________");
            entity.Property(e => e.Famille).HasMaxLength(255);
            entity.Property(e => e.SousCatégorie)
                .HasMaxLength(255)
                .HasColumnName("Sous catégorie");
            entity.Property(e => e.SousFamille)
                .HasMaxLength(255)
                .HasColumnName("SOUS FAMILLE");
        });

        modelBuilder.Entity<TypeContact>(entity =>
        {
            entity.HasKey(e => e.IdType);

            entity.ToTable("TypeContact");

            entity.Property(e => e.IdType).HasColumnName("ID_Type");
            entity.Property(e => e.Tcontact)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("TContact");
            entity.Property(e => e.Tdcontact)
                .HasMaxLength(15)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("TDContact");
        });

        modelBuilder.Entity<TypeTier>(entity =>
        {
            entity.HasKey(e => e.CodeType);

            entity.Property(e => e.CodeType)
                .HasMaxLength(3)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.LibType)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.Pcompte).HasColumnName("PCompte");
            entity.Property(e => e.Pcontact).HasColumnName("PContact");
            entity.Property(e => e.Pfidelite).HasColumnName("PFidelite");
            entity.Property(e => e.Plocal).HasColumnName("PLocal");
            entity.Property(e => e.ProcRecherche)
                .HasMaxLength(20)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.Psolde).HasColumnName("PSolde");
            entity.Property(e => e.Vbouton)
                .HasMaxLength(5)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS")
                .HasColumnName("VBouton");
        });

        modelBuilder.Entity<TypeUtilisateur>(entity =>
        {
            entity.HasKey(e => e.IdtypeU);

            entity.ToTable("TypeUtilisateur");

            entity.Property(e => e.IdtypeU).HasColumnName("IDTypeU");
            entity.Property(e => e.NTypeU)
                .HasMaxLength(200)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("N_TypeU");
        });

        modelBuilder.Entity<UtilisateurAlert>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UtilisateurAlert");

            entity.Property(e => e.Alert)
                .HasMaxLength(50)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.IdtypeUser).HasColumnName("IDTypeUser");
        });

        modelBuilder.Entity<UtilisateurApplication>(entity =>
        {
            entity.HasKey(e => e.Ematricule);

            entity.ToTable("UtilisateurApplication");

            entity.Property(e => e.Ematricule)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("EMatricule");
            entity.Property(e => e.ActiverColonneDgv).HasColumnName("ActiverColonneDGV");
            entity.Property(e => e.IdtypeUser).HasColumnName("IDTypeUser");
            entity.Property(e => e.Login)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Motdepasse)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Motdepasse2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();

            entity.HasOne(d => d.IdtypeUserNavigation).WithMany(p => p.UtilisateurApplications)
                .HasForeignKey(d => d.IdtypeUser)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_UtilisateurApplication_TypeUtilisateur");
        });

        modelBuilder.Entity<UtilisateurDepot>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UtilisateurDepot");

            entity.Property(e => e.Depot)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UtilisateurEdition>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UtilisateurEdition");

            entity.Property(e => e.Menu)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Parent)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<UtilisateurImg>(entity =>
        {
            entity.HasKey(e => e.Ematricule);

            entity.ToTable("UtilisateurIMG");

            entity.Property(e => e.Ematricule)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("EMatricule");
            entity.Property(e => e.Img)
                .HasColumnType("image")
                .HasColumnName("img");
        });

        modelBuilder.Entity<UtilisateurMenu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UtilisateurMenu");

            entity.Property(e => e.Menu)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Parent)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ValeurCriter>(entity =>
        {
            entity.HasKey(e => new { e.NCriters, e.ValCriters });

            entity.Property(e => e.NCriters)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("N_Criters");
            entity.Property(e => e.ValCriters)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("Val_Criters");
            entity.Property(e => e.TVal)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("T_Val");
        });

        modelBuilder.Entity<ValeurTaxe>(entity =>
        {
            entity.HasKey(e => new { e.NTaxe, e.ValTaxe });

            entity.ToTable("ValeurTaxe");

            entity.Property(e => e.NTaxe)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("N_Taxe");
            entity.Property(e => e.ValTaxe).HasColumnName("Val_Taxe");
        });

        modelBuilder.Entity<VencoursClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VEncoursClient");

            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DateCréation)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DateEcheance)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DateRecouvrement)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocRepresentant)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.ModeRegTier)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Montantreglé).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.RefDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Reste).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Tiers)
                .HasMaxLength(202)
                .UseCollation("French_CI_AI")
                .HasColumnName("________________Tiers___________________");
            entity.Property(e => e.Total).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<VencoursClientBl>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VEncoursClientBL");

            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateEch)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalTva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalTVA");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NetàPayer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RaisonSocial)
                .HasMaxLength(202)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefExt).HasMaxLength(250);
            entity.Property(e => e.RefTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Représentant).HasMaxLength(50);
            entity.Property(e => e.Reste).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<VencoursClientBr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VEncoursClientBR");

            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DateEch)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocTotalTva)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalTVA");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NetàPayer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.RaisonSocial)
                .HasMaxLength(202)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefExt).HasMaxLength(250);
            entity.Property(e => e.RefTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Représentant).HasMaxLength(50);
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<VencoursFr>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VEncoursFrs");

            entity.Property(e => e.DateCréation)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Devise).HasColumnName("devise");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Echeance).HasColumnType("smalldatetime");
            entity.Property(e => e.ReTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Reste).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Tiers)
                .HasMaxLength(202)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<VerifversementBanque>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("verifversementBanque");

            entity.Property(e => e.BordBanque)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Breception)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Numencdec).HasColumnName("numencdec");
        });

        modelBuilder.Entity<VersementEntet>(entity =>
        {
            entity.HasKey(e => e.BordRef);

            entity.ToTable("VersementEntet", tb => tb.HasTrigger("AfterDeleteTV"));

            entity.Property(e => e.BordRef).HasMaxLength(20);
            entity.Property(e => e.BordBanqExt)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("BordBanqEXT");
            entity.Property(e => e.BordBanque)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.BordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.BordDateVers).HasColumnType("smalldatetime");
            entity.Property(e => e.BordModePaie)
                .HasMaxLength(20)
                .IsFixedLength();
            entity.Property(e => e.BordMontant).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.BordNumCompte)
                .HasMaxLength(20)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.BordType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.BordTypeVers)
                .HasMaxLength(10)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Commentaire)
                .HasMaxLength(200)
                .IsFixedLength();
            entity.Property(e => e.IntegJourCa).HasColumnName("IntegJourCA");
            entity.Property(e => e.LabNumImp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.MntLettre)
                .HasMaxLength(200)
                .IsFixedLength();
            entity.Property(e => e.UniqueId)
                .ValueGeneratedOnAdd()
                .HasColumnName("UniqueID");
            entity.Property(e => e.ValidationSihem).HasColumnName("Validation_Sihem");
        });

        modelBuilder.Entity<VersementLigne>(entity =>
        {
            entity.HasKey(e => new { e.BordRef, e.BordRefDoc }).HasName("PK__Versemen__5271E44892770F0F");

            entity.ToTable("VersementLigne", tb =>
                {
                    tb.HasTrigger("AFTERDelUpdEncDecversement");
                    tb.HasTrigger("AfterDeleteLV");
                    tb.HasTrigger("AfterInsertLV");
                    tb.HasTrigger("insteadDeleteLV");
                });

            entity.Property(e => e.BordRef).HasMaxLength(20);
            entity.Property(e => e.BordDateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.BordMontDoc).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.BordTiers)
                .HasMaxLength(10)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Bordrefdoc1).HasMaxLength(20);
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<VersementLigneHistorique>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("VersementLigneHistorique");

            entity.Property(e => e.Action).HasMaxLength(10);
            entity.Property(e => e.ActionDate)
                .HasColumnType("datetime")
                .HasColumnName("actionDate");
            entity.Property(e => e.BordDateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.BordMontDoc).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.BordRef).HasMaxLength(20);
            entity.Property(e => e.BordTiers)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Bordrefdoc1).HasMaxLength(20);
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ViewAffectationFacture>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AffectationFacture");

            entity.Property(e => e.Action).HasMaxLength(250);
            entity.Property(e => e.Client).HasMaxLength(250);
            entity.Property(e => e.Cnom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CNom");
            entity.Property(e => e.Commentaire).HasMaxLength(250);
            entity.Property(e => e.Cprenom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CPrenom");
            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.Cref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CRef");
            entity.Property(e => e.Crmtype)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CRMType");
            entity.Property(e => e.DateCreation).HasColumnType("smalldatetime");
            entity.Property(e => e.DateFact).HasMaxLength(250);
            entity.Property(e => e.Etat).HasMaxLength(250);
            entity.Property(e => e.IdCampagne)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ref)
                .HasMaxLength(20)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Reference).HasMaxLength(250);
            entity.Property(e => e.Total).HasMaxLength(250);
            entity.Property(e => e.Type).HasMaxLength(250);
        });

        modelBuilder.Entity<ViewBordTest>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_BordTest");

            entity.Property(e => e.Acompte).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Banque)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Commentaire).HasMaxLength(250);
            entity.Property(e => e.Date)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DateEch)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DateI)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Date.I");
            entity.Property(e => e.DateP)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Date.P");
            entity.Property(e => e.DateVersement)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Date.Versement");
            entity.Property(e => e.Etat)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("ETAT");
            entity.Property(e => e.ModePay)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("French_CI_AI")
                .HasColumnName("Mode.Pay");
            entity.Property(e => e.Montant).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.NPiece)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI")
                .HasColumnName("N°Piece");
            entity.Property(e => e.RaisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("Raison.Social");
            entity.Property(e => e.RefTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RéférenceBordereau)
                .HasMaxLength(20)
                .HasColumnName("Référence Bordereau");
            entity.Property(e => e.Tel).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewCharesSociale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Chares_sociales");

            entity.Property(e => e.Annee).HasColumnName("annee");
            entity.Property(e => e.Col1)
                .HasMaxLength(250)
                .HasColumnName("col1");
            entity.Property(e => e.Mois).HasColumnName("mois");
            entity.Property(e => e.Value)
                .HasMaxLength(250)
                .HasColumnName("value");
        });

        modelBuilder.Entity<ViewCoutsFix>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Couts_fixes");

            entity.Property(e => e.Annee).HasColumnName("annee");
            entity.Property(e => e.Col1)
                .HasMaxLength(250)
                .HasColumnName("col1");
            entity.Property(e => e.Mois).HasColumnName("mois");
            entity.Property(e => e.Value)
                .HasMaxLength(250)
                .HasColumnName("value");
        });

        modelBuilder.Entity<ViewCra>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_CRA");

            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Client)
                .HasMaxLength(61)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DateC).HasColumnType("smalldatetime");
            entity.Property(e => e.DateCreation).HasColumnType("smalldatetime");
            entity.Property(e => e.Document)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Echeance).HasColumnType("smalldatetime");
            entity.Property(e => e.Montant).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.NPieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI")
                .HasColumnName("N° Pieces");
            entity.Property(e => e.Npieces1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI")
                .HasColumnName("Npieces");
            entity.Property(e => e.TypeDePièce)
                .HasMaxLength(4000)
                .UseCollation("French_CI_AI")
                .HasColumnName("type de pièce");
        });

        modelBuilder.Entity<ViewCri>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_cri");

            entity.Property(e => e.Bq)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("French_CI_AI")
                .HasColumnName("BQ");
            entity.Property(e => e.Client)
                .HasMaxLength(61)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Date).HasColumnType("smalldatetime");
            entity.Property(e => e.DateCreation).HasColumnType("smalldatetime");
            entity.Property(e => e.Des)
                .HasMaxLength(250)
                .HasColumnName("des");
            entity.Property(e => e.Document)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Echeance).HasColumnType("smalldatetime");
            entity.Property(e => e.Montant).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.NPieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI")
                .HasColumnName("N° Pieces");
            entity.Property(e => e.TypeDePièce)
                .HasMaxLength(4000)
                .UseCollation("French_CI_AI")
                .HasColumnName("type de pièce");
        });

        modelBuilder.Entity<ViewEncourStkBoumhal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EncourStkBoumhal");

            entity.Property(e => e.Adesignation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("ADesignation");
            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.AtauxTvav).HasColumnName("ATaux_TVAV");
            entity.Property(e => e.Pvht)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVht");
            entity.Property(e => e.Pvttc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVttc");
            entity.Property(e => e.QteDep).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.QteDisponible).HasColumnType("decimal(19, 3)");
            entity.Property(e => e.QteRes).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.QteTousDep).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<ViewEncourStkBoumhalOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EncourStkBoumhalOld");

            entity.Property(e => e.ApuventeHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APUVenteHT");
            entity.Property(e => e.Apvttc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APVTTC");
            entity.Property(e => e.AqteStock)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("AQteStock");
            entity.Property(e => e.Depot)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Designation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("designation");
            entity.Property(e => e.QteAs)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Qte_AS");
            entity.Property(e => e.Ref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI")
                .HasColumnName("ref");
        });

        modelBuilder.Entity<ViewEncourStkHbc>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EncourStkHBC");

            entity.Property(e => e.Adesignation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("ADesignation");
            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.AtauxTvav).HasColumnName("ATaux_TVAV");
            entity.Property(e => e.Pvht)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVht");
            entity.Property(e => e.Pvttc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVttc");
            entity.Property(e => e.QteDep).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.QteDisponible).HasColumnType("decimal(19, 3)");
            entity.Property(e => e.QteRes).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.QteTousDep).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<ViewEncourStkHbcold>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EncourStkHBCOld");

            entity.Property(e => e.ApuventeHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APUVenteHT");
            entity.Property(e => e.Apvttc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APVTTC");
            entity.Property(e => e.AqteStock)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("AQteStock");
            entity.Property(e => e.Depot)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Designation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("designation");
            entity.Property(e => e.QteAs)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Qte_AS");
            entity.Property(e => e.Ref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI")
                .HasColumnName("ref");
        });

        modelBuilder.Entity<ViewEncoursStkBca>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EncoursStkBCA");

            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Dateliv)
                .HasColumnType("smalldatetime")
                .HasColumnName("DATELiv");
            entity.Property(e => e.DocArtDesignation)
                .HasMaxLength(250)
                .IsFixedLength();
            entity.Property(e => e.DocDevise)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocEtatBp).HasColumnName("DocEtatBP");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Docart)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI")
                .HasColumnName("docart");
            entity.Property(e => e.Etape)
                .HasMaxLength(50)
                .HasColumnName("ETAPE");
            entity.Property(e => e.Idlg).HasColumnName("idlg");
            entity.Property(e => e.Maxech).HasColumnName("maxech");
            entity.Property(e => e.PxUnit).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.RaisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Type)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<ViewEncoursStkCentrale>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EncoursStkCentrale");

            entity.Property(e => e.Adesignation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("ADesignation");
            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.AtauxTvav).HasColumnName("ATaux_TVAV");
            entity.Property(e => e.Pvht)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVht");
            entity.Property(e => e.Pvttc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVttc");
            entity.Property(e => e.QteDep).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.QteDisponible).HasColumnType("decimal(19, 3)");
            entity.Property(e => e.QteRes).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.QteTousDep).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<ViewEncoursStkCentraleOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EncoursStkCentraleOld");

            entity.Property(e => e.ApuventeHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APUVenteHT");
            entity.Property(e => e.Apvttc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APVTTC");
            entity.Property(e => e.AqteStock)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("AQteStock");
            entity.Property(e => e.Depot)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Designation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("designation");
            entity.Property(e => e.QteAs)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Qte_AS");
            entity.Property(e => e.Ref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI")
                .HasColumnName("ref");
        });

        modelBuilder.Entity<ViewEncoursStkLca>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EncoursStkLCA");

            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DocArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocArtDesignation)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocDevise)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Echeance)
                .HasColumnType("smalldatetime")
                .HasColumnName("echeance");
            entity.Property(e => e.Idlg).HasColumnName("idlg");
            entity.Property(e => e.Maxech).HasColumnName("maxech");
            entity.Property(e => e.PxUnit).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Qte).HasColumnName("QTE");
            entity.Property(e => e.RaisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<ViewEncoursStkLca1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EncoursStkLCA1");

            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DocArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocArtDesignation)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocDevise)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Echeance)
                .HasColumnType("smalldatetime")
                .HasColumnName("echeance");
            entity.Property(e => e.Idlg).HasColumnName("idlg");
            entity.Property(e => e.Maxech).HasColumnName("maxech");
            entity.Property(e => e.PxUnit).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Qte).HasColumnName("QTE");
            entity.Property(e => e.RaisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<ViewEncoursStkSidiSalem>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EncoursStkSidiSalem");

            entity.Property(e => e.Adesignation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("ADesignation");
            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.AtauxTvav).HasColumnName("ATaux_TVAV");
            entity.Property(e => e.Pvht)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVht");
            entity.Property(e => e.Pvttc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("PVttc");
            entity.Property(e => e.QteDep).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.QteDisponible).HasColumnType("decimal(19, 3)");
            entity.Property(e => e.QteRes).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.QteTousDep).HasColumnType("decimal(18, 3)");
        });

        modelBuilder.Entity<ViewEncoursStkSidiSalemOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EncoursStkSidiSalemOld");

            entity.Property(e => e.ApuventeHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APUVenteHT");
            entity.Property(e => e.Apvttc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APVTTC");
            entity.Property(e => e.AqteStock)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("AQteStock");
            entity.Property(e => e.Depot)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Designation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("designation");
            entity.Property(e => e.QteAs)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("Qte_AS");
            entity.Property(e => e.Ref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI")
                .HasColumnName("ref");
        });

        modelBuilder.Entity<ViewEncoursTransfert>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EncoursTransfert");

            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DocArt)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocArtDesignation)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Idlg).HasColumnName("idlg");
            entity.Property(e => e.RaisonSocial)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<ViewEtatRecapAvoirComptum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EtatRecapAvoirCompta");

            entity.Property(e => e.Cnom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CNom");
            entity.Property(e => e.Cprenom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("cprenom");
            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocNetaPayer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocNptiers)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("DocNPTiers");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.TotalEntet).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalLigne).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TypeClient)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI");
        });

        modelBuilder.Entity<ViewEtatRecapVenteComptum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EtatRecapVenteCompta");

            entity.Property(e => e.Cnom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CNom");
            entity.Property(e => e.Cprenom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("cprenom");
            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocNetaPayer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocNptiers)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("DocNPTiers");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Exo)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("EXO");
            entity.Property(e => e.TotalEntet).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalLigne).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.TypeClient)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI");
        });

        modelBuilder.Entity<ViewFactureExo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_FactureExo");

            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.DateDebut).HasColumnType("smalldatetime");
            entity.Property(e => e.DateFin).HasColumnType("smalldatetime");
            entity.Property(e => e.DocDate).HasColumnType("smalldatetime");
            entity.Property(e => e.DocNetaPayer).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTotalHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("DocTotalHT");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Expr1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NumDecision)
                .HasMaxLength(20)
                .IsFixedLength();
        });

        modelBuilder.Entity<ViewFraisBancaire>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_FraisBancaire");

            entity.Property(e => e.BordBanque)
                .HasMaxLength(4000)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.BordDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Bordref)
                .HasMaxLength(20)
                .HasColumnName("bordref");
            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Breception)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateP).HasColumnType("smalldatetime");
            entity.Property(e => e.DateR).HasColumnType("smalldatetime");
            entity.Property(e => e.DateV).HasColumnType("smalldatetime");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Etat).HasColumnType("smalldatetime");
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MontantR).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Rib)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("RIB");
            entity.Property(e => e.TypeEncDec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<ViewImmobilisation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Immobilisation");

            entity.Property(e => e.Code).HasMaxLength(522);
            entity.Property(e => e.CodeArticle).HasMaxLength(250);
            entity.Property(e => e.CodeCatégorie).HasMaxLength(250);
            entity.Property(e => e.CodeDestination).HasMaxLength(250);
            entity.Property(e => e.CodeUser).HasMaxLength(250);
            entity.Property(e => e.DateCreation).HasColumnType("smalldatetime");
            entity.Property(e => e.DateOperation).HasColumnType("smalldatetime");
            entity.Property(e => e.DesCatégorie).HasMaxLength(250);
            entity.Property(e => e.Description).HasMaxLength(250);
            entity.Property(e => e.Description2).HasMaxLength(501);
            entity.Property(e => e.DescriptionImmo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("descriptionImmo");
            entity.Property(e => e.DesignationArt).HasMaxLength(250);
            entity.Property(e => e.Destination).HasMaxLength(250);
            entity.Property(e => e.Lcol3)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("LCol3");
            entity.Property(e => e.User).HasMaxLength(250);
            entity.Property(e => e.Utilisateur)
                .HasMaxLength(501)
                .HasColumnName("utilisateur");
        });

        modelBuilder.Entity<ViewInfoNivAe3detail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_InfoNivAE3Detail");

            entity.Property(e => e.Article)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Designation)
                .HasMaxLength(100)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Px).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Qte).HasColumnName("qte");
            entity.Property(e => e.Tht)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("THT");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<ViewInfoNivAe3liste>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_InfoNivAE3Liste");

            entity.Property(e => e.Date).HasColumnType("smalldatetime");
            entity.Property(e => e.Ref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.RefTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Tht)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("THT");
            entity.Property(e => e.Tiers)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<ViewListeEncaissement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("view_ListeEncaissement");

            entity.Property(e => e.Cf)
                .HasMaxLength(2)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS")
                .HasColumnName("CF");
            entity.Property(e => e.Cnom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CNom");
            entity.Property(e => e.Cprenom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CPrenom");
            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.Cref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CRef");
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.DateR).HasColumnType("smalldatetime");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MontantR).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.TypeC)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.TypeEncDec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
        });

        modelBuilder.Entity<ViewListeRecouvrementRegle>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_LIsteRecouvrementRegle");

            entity.Property(e => e.Action).HasMaxLength(250);
            entity.Property(e => e.Client).HasMaxLength(250);
            entity.Property(e => e.Cnom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CNom");
            entity.Property(e => e.Code).HasMaxLength(250);
            entity.Property(e => e.Commentaire).HasMaxLength(250);
            entity.Property(e => e.Cprenom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CPrenom");
            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.DateCreation).HasColumnType("smalldatetime");
            entity.Property(e => e.Etat).HasMaxLength(250);
            entity.Property(e => e.Expr1).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.IdCampagne)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ref)
                .HasMaxLength(20)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Reference).HasMaxLength(250);
            entity.Property(e => e.Total).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Type).HasMaxLength(250);
        });

        modelBuilder.Entity<ViewListing>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Listing");

            entity.Property(e => e.Action).HasMaxLength(250);
            entity.Property(e => e.Client).HasMaxLength(250);
            entity.Property(e => e.Cnom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CNom");
            entity.Property(e => e.Code).HasMaxLength(250);
            entity.Property(e => e.Commentaire).HasMaxLength(250);
            entity.Property(e => e.Cprenom)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("CPrenom");
            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.DateCreation).HasColumnType("smalldatetime");
            entity.Property(e => e.Etat).HasMaxLength(250);
            entity.Property(e => e.IdCampagne)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Ref)
                .HasMaxLength(20)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Reference).HasMaxLength(250);
            entity.Property(e => e.Reste).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Total).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Type).HasMaxLength(250);
        });

        modelBuilder.Entity<ViewOrganigramme>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Organigramme");

            entity.Property(e => e.Codetiers)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("codetiers");
            entity.Property(e => e.DateDeb)
                .HasColumnType("datetime")
                .HasColumnName("DateDEB");
            entity.Property(e => e.DateFin).HasColumnType("datetime");
            entity.Property(e => e.EmatSup)
                .HasMaxLength(250)
                .HasColumnName("Emat.Sup");
            entity.Property(e => e.EmatSup2)
                .HasMaxLength(250)
                .HasColumnName("Emat.Sup2");
            entity.Property(e => e.Ref)
                .HasMaxLength(250)
                .HasColumnName("ref");
            entity.Property(e => e.Sup2).HasMaxLength(250);
            entity.Property(e => e.Tiers)
                .HasMaxLength(250)
                .HasColumnName("tiers");
            entity.Property(e => e.Val2)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("val2");
            entity.Property(e => e.Valeur)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("valeur");
        });

        modelBuilder.Entity<ViewOrganigrammeDum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Organigramme_DA");

            entity.Property(e => e.Codetiers)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("codetiers");
            entity.Property(e => e.DateDeb)
                .HasColumnType("datetime")
                .HasColumnName("DateDEB");
            entity.Property(e => e.DateFin).HasColumnType("datetime");
            entity.Property(e => e.EmatSup)
                .HasMaxLength(250)
                .HasColumnName("Emat.Sup");
            entity.Property(e => e.EmatSup2)
                .HasMaxLength(250)
                .HasColumnName("Emat.Sup2");
            entity.Property(e => e.Sup2).HasMaxLength(250);
            entity.Property(e => e.Tiers)
                .HasMaxLength(250)
                .HasColumnName("tiers");
            entity.Property(e => e.Val2)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("val2");
            entity.Property(e => e.Valeur)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("valeur");
        });

        modelBuilder.Entity<ViewOrganigrammeOm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Organigramme_OM");

            entity.Property(e => e.Codetiers)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("codetiers");
            entity.Property(e => e.DateDeb)
                .HasColumnType("datetime")
                .HasColumnName("DateDEB");
            entity.Property(e => e.DateFin).HasColumnType("datetime");
            entity.Property(e => e.EmatSup)
                .HasMaxLength(250)
                .HasColumnName("Emat.Sup");
            entity.Property(e => e.EmatSup2)
                .HasMaxLength(250)
                .HasColumnName("Emat.Sup2");
            entity.Property(e => e.Obj)
                .HasMaxLength(250)
                .HasColumnName("OBJ");
            entity.Property(e => e.Sup2).HasMaxLength(250);
            entity.Property(e => e.Tiers)
                .HasMaxLength(250)
                .HasColumnName("tiers");
            entity.Property(e => e.Val2)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("val2");
            entity.Property(e => e.Valeur)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("valeur");
        });

        modelBuilder.Entity<ViewPeriodeFullyear>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_periode_fullyear");

            entity.Property(e => e.M).HasColumnName("m");
            entity.Property(e => e.Y).HasColumnName("y");
        });

        modelBuilder.Entity<ViewPositionBq>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Position_BQ");

            entity.Property(e => e.Annee).HasColumnName("annee");
            entity.Property(e => e.Col1)
                .HasMaxLength(250)
                .HasColumnName("col1");
            entity.Property(e => e.Mois).HasColumnName("mois");
            entity.Property(e => e.Value)
                .HasMaxLength(250)
                .HasColumnName("value");
        });

        modelBuilder.Entity<ViewQtcommander>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_QTCommander");

            entity.Property(e => e.Adesignation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("ADesignation");
            entity.Property(e => e.Afamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AFamille");
            entity.Property(e => e.AqteStock)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("AQteStock");
            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI")
                .HasColumnName("ARef");
            entity.Property(e => e.Asfamille)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("ASFamille");
            entity.Property(e => e.AstockMax).HasColumnName("AStockMax");
            entity.Property(e => e.AstockMin).HasColumnName("AStockMin");
            entity.Property(e => e.AuniteVnt)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("AUniteVnt");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.EncoursBca).HasColumnName("EncoursBCA");
            entity.Property(e => e.EncoursLca).HasColumnName("EncoursLCA");
            entity.Property(e => e.QtReserver)
                .HasColumnType("decimal(21, 3)")
                .HasColumnName("qt.Reserver");
            entity.Property(e => e.StockDisponible)
                .HasColumnType("decimal(22, 3)")
                .HasColumnName("Stock.Disponible");
        });

        modelBuilder.Entity<ViewRegImp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_RegImp");

            entity.Property(e => e.CraisonSocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("CRaisonSocial");
            entity.Property(e => e.DateR).HasColumnType("smalldatetime");
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MontantR).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Pdecommentaire)
                .HasMaxLength(250)
                .HasColumnName("PDECommentaire");
            entity.Property(e => e.TypeEncDec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
        });

        modelBuilder.Entity<ViewReleveGargouri>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ReleveGargouri");

            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Breception)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Caisse)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Commentaire).HasMaxLength(250);
            entity.Property(e => e.DateAnnuler).HasColumnType("smalldatetime");
            entity.Property(e => e.DateCreation).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch2).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEven).HasColumnType("datetime");
            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateP).HasColumnType("smalldatetime");
            entity.Property(e => e.DateR).HasColumnType("smalldatetime");
            entity.Property(e => e.DateV).HasColumnType("smalldatetime");
            entity.Property(e => e.Des).HasMaxLength(250);
            entity.Property(e => e.DocCloture).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMntLettre).HasMaxLength(500);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Docref1).HasMaxLength(20);
            entity.Property(e => e.Ematricule)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("EMatricule");
            entity.Property(e => e.Etat).HasColumnType("smalldatetime");
            entity.Property(e => e.Imput1)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("imput1");
            entity.Property(e => e.Imputation)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MontantR).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.NumEncDec2).HasMaxLength(20);
            entity.Property(e => e.Pdecommentaire)
                .HasMaxLength(250)
                .HasColumnName("PDECommentaire");
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Rib)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("RIB");
            entity.Property(e => e.Rib1).HasMaxLength(100);
            entity.Property(e => e.Ribp)
                .HasMaxLength(100)
                .HasColumnName("RIBP");
            entity.Property(e => e.TypeEncDec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.VisibleEd).HasColumnName("VisibleED");
        });

        modelBuilder.Entity<ViewReleveRahma>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ReleveRahma");

            entity.Property(e => e.Bpieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Breception)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Caisse)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Commentaire).HasMaxLength(250);
            entity.Property(e => e.DateAnnuler).HasColumnType("smalldatetime");
            entity.Property(e => e.DateCreation).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEch2).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEven).HasColumnType("datetime");
            entity.Property(e => e.DateI).HasColumnType("smalldatetime");
            entity.Property(e => e.DateP).HasColumnType("smalldatetime");
            entity.Property(e => e.DateR).HasColumnType("smalldatetime");
            entity.Property(e => e.DateV).HasColumnType("smalldatetime");
            entity.Property(e => e.Des).HasMaxLength(250);
            entity.Property(e => e.DocCloture).HasColumnType("smalldatetime");
            entity.Property(e => e.DocMntLettre).HasMaxLength(500);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Docref1).HasMaxLength(20);
            entity.Property(e => e.Ematricule)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("EMatricule");
            entity.Property(e => e.Etat).HasColumnType("smalldatetime");
            entity.Property(e => e.Imput1)
                .HasMaxLength(100)
                .IsFixedLength()
                .HasColumnName("imput1");
            entity.Property(e => e.Imputation)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.MontantR).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Npieces)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.NumDoc)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AS");
            entity.Property(e => e.NumEncDec2).HasMaxLength(20);
            entity.Property(e => e.Pdecommentaire)
                .HasMaxLength(250)
                .HasColumnName("PDECommentaire");
            entity.Property(e => e.Ppieces)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Rib)
                .HasMaxLength(100)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("RIB");
            entity.Property(e => e.Rib1).HasMaxLength(100);
            entity.Property(e => e.Ribp)
                .HasMaxLength(100)
                .HasColumnName("RIBP");
            entity.Property(e => e.TypeEncDec)
                .HasMaxLength(3)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.VisibleEd).HasColumnName("VisibleED");
        });

        modelBuilder.Entity<ViewRepartitionDesFrai>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_repartition des frais");

            entity.Property(e => e.Col1).HasMaxLength(250);
            entity.Property(e => e.Col2).HasMaxLength(250);
            entity.Property(e => e.Col3).HasMaxLength(250);
            entity.Property(e => e.Col4).HasMaxLength(250);
            entity.Property(e => e.Crmtype)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("CRMType");
            entity.Property(e => e.Des).HasMaxLength(255);
            entity.Property(e => e.IdCampagne)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<ViewStkSuivi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_stk_suivi");

            entity.Property(e => e.Adesignation)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.ApuventeHt)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APUVenteHT");
            entity.Property(e => e.Apvttc)
                .HasColumnType("decimal(18, 4)")
                .HasColumnName("APVTTC");
            entity.Property(e => e.AqteStock)
                .HasColumnType("decimal(18, 3)")
                .HasColumnName("AQteStock");
            entity.Property(e => e.Aref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Datedebutpromoa)
                .HasMaxLength(250)
                .HasColumnName("datedebutpromoa");
            entity.Property(e => e.Datedebutpromov)
                .HasMaxLength(250)
                .HasColumnName("datedebutpromov");
            entity.Property(e => e.Datefinpromoa)
                .HasMaxLength(250)
                .HasColumnName("datefinpromoa");
            entity.Property(e => e.Datefinpromov)
                .HasMaxLength(250)
                .HasColumnName("datefinpromov");
            entity.Property(e => e.PromoAchat)
                .HasMaxLength(250)
                .HasColumnName("promo_achat");
            entity.Property(e => e.PromoAchatGratuite)
                .HasMaxLength(250)
                .HasColumnName("promo_achat_gratuite");
            entity.Property(e => e.PromoVente)
                .HasMaxLength(250)
                .HasColumnName("promo_vente");
            entity.Property(e => e.PromoVenteGratuite)
                .HasMaxLength(250)
                .HasColumnName("promo_vente_gratuite");
            entity.Property(e => e.PromoWeb)
                .HasMaxLength(501)
                .HasColumnName("promo_web");
            entity.Property(e => e.QtePromoAchat).HasColumnName("qte_promo_achat");
            entity.Property(e => e.QtePromoAchatGratuite).HasColumnName("qte_promo_achat_gratuite");
            entity.Property(e => e.QtePromoVente).HasColumnName("qte_promo_vente");
            entity.Property(e => e.QtePromoVenteGratuite).HasColumnName("qte_promo_vente_gratuite");
            entity.Property(e => e.QteStkGratuite).HasColumnName("qte_stk_gratuite");
            entity.Property(e => e.Tva).HasColumnName("tva");
        });

        modelBuilder.Entity<ViewValidation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Validation");

            entity.Property(e => e.Codetiers)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("codetiers");
            entity.Property(e => e.DateDeb)
                .HasColumnType("datetime")
                .HasColumnName("DateDEB");
            entity.Property(e => e.DateFin).HasColumnType("datetime");
            entity.Property(e => e.EmatSup)
                .HasMaxLength(250)
                .HasColumnName("Emat.Sup");
            entity.Property(e => e.EmatSup2)
                .HasMaxLength(250)
                .HasColumnName("Emat.Sup2");
            entity.Property(e => e.Sup2).HasMaxLength(250);
            entity.Property(e => e.Tiers)
                .HasMaxLength(250)
                .HasColumnName("tiers");
            entity.Property(e => e.Val2)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("val2");
            entity.Property(e => e.Valeur)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("valeur");
        });

        modelBuilder.Entity<ViewValidationOrganigramme>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ValidationOrganigramme");

            entity.Property(e => e.Codetiers)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("codetiers");
            entity.Property(e => e.DateDeb).HasColumnName("DateDEB");
            entity.Property(e => e.EmatSup)
                .HasMaxLength(250)
                .HasColumnName("Emat.Sup");
            entity.Property(e => e.EmatSup2)
                .HasMaxLength(250)
                .HasColumnName("Emat.Sup2");
            entity.Property(e => e.Matricule).HasMaxLength(250);
            entity.Property(e => e.NbreJour).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Ref)
                .HasMaxLength(250)
                .HasColumnName("ref");
            entity.Property(e => e.Sup2).HasMaxLength(250);
            entity.Property(e => e.Tiers)
                .HasMaxLength(250)
                .HasColumnName("tiers");
            entity.Property(e => e.Valeur)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("valeur");
        });

        modelBuilder.Entity<ViewValidationOrganigrammeDum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ValidationOrganigramme_DA");

            entity.Property(e => e.Codetiers)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("codetiers");
            entity.Property(e => e.DateDeb)
                .HasColumnType("datetime")
                .HasColumnName("DateDEB");
            entity.Property(e => e.EmatSup)
                .HasMaxLength(250)
                .HasColumnName("Emat.Sup");
            entity.Property(e => e.EmatSup2)
                .HasMaxLength(250)
                .HasColumnName("Emat.Sup2");
            entity.Property(e => e.Matricule).HasMaxLength(250);
            entity.Property(e => e.NbreJour).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Ref)
                .HasMaxLength(250)
                .HasColumnName("ref");
            entity.Property(e => e.Sup2).HasMaxLength(250);
            entity.Property(e => e.Tiers)
                .HasMaxLength(250)
                .HasColumnName("tiers");
            entity.Property(e => e.Valeur)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("valeur");
        });

        modelBuilder.Entity<ViewValidationOrganigrammeOm>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ValidationOrganigramme_OM");

            entity.Property(e => e.Codetiers)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("codetiers");
            entity.Property(e => e.DateDeb)
                .HasColumnType("datetime")
                .HasColumnName("DateDEB");
            entity.Property(e => e.EmatSup)
                .HasMaxLength(250)
                .HasColumnName("Emat.Sup");
            entity.Property(e => e.EmatSup2)
                .HasMaxLength(250)
                .HasColumnName("Emat.Sup2");
            entity.Property(e => e.NbreJour).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Obj)
                .HasMaxLength(250)
                .HasColumnName("OBJ");
            entity.Property(e => e.Sup2).HasMaxLength(250);
            entity.Property(e => e.Tiers)
                .HasMaxLength(250)
                .HasColumnName("tiers");
            entity.Property(e => e.Valeur)
                .HasMaxLength(50)
                .UseCollation("French_CI_AI")
                .HasColumnName("valeur");
        });

        modelBuilder.Entity<VrelanceClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VRelanceClient");

            entity.Property(e => e.Client)
                .HasMaxLength(202)
                .UseCollation("French_CI_AI")
                .HasColumnName("client");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI")
                .HasColumnName("code");
            entity.Property(e => e.Date).HasColumnType("smalldatetime");
            entity.Property(e => e.DateCréation).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEcheance).HasColumnType("smalldatetime");
            entity.Property(e => e.DateRecouvrement).HasColumnType("smalldatetime");
            entity.Property(e => e.DocRepresentant)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.ModeRegTier)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Montantreglé).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Reference)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Reste).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Total).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.Type)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<VrelanceClient1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VRelanceClient1");

            entity.Property(e => e.Client)
                .HasMaxLength(202)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Commercial)
                .HasMaxLength(101)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Date).HasColumnType("smalldatetime");
            entity.Property(e => e.DateCréation).HasColumnType("smalldatetime");
            entity.Property(e => e.DateEcheance).HasColumnType("smalldatetime");
            entity.Property(e => e.DateRecouvrement).HasColumnType("smalldatetime");
            entity.Property(e => e.DocRepresentant)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.ModeRegTier)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Montantreglé).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Reference)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Reste).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Total).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.TotalAvance).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<VrelanceClientBft>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VRelanceClientBFT");

            entity.Property(e => e.Client)
                .HasMaxLength(202)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Code)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DateCréation)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DateRecouvrement)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.DocRepresentant)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.ModeRegTier)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Montantreglé).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Reference)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Reste).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Total).HasColumnType("decimal(19, 4)");
            entity.Property(e => e.Type)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
        });

        modelBuilder.Entity<VsoldeClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VSoldeClient");

            entity.Property(e => e.Crédit).HasMaxLength(4000);
            entity.Property(e => e.DateEch)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.DocRef)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocTiers)
                .HasMaxLength(20)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.DocType)
                .HasMaxLength(6)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Docdate)
                .HasColumnType("smalldatetime")
                .HasColumnName("docdate");
            entity.Property(e => e.Débit).HasMaxLength(4000);
            entity.Property(e => e.ModeReg)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.Npiece)
                .HasMaxLength(20)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
            entity.Property(e => e.ResteCheque).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.ResteDoc).HasColumnType("decimal(38, 3)");
            entity.Property(e => e.Ty)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VvisiteClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("VVisiteClient");

            entity.Property(e => e.Choix).HasColumnName("choix");
            entity.Property(e => e.Cref)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .UseCollation("French_CI_AI")
                .HasColumnName("CRef");
            entity.Property(e => e.DatePrevu).HasColumnType("smalldatetime");
            entity.Property(e => e.Des).HasMaxLength(255);
            entity.Property(e => e.DocLancement).HasColumnType("smalldatetime");
            entity.Property(e => e.Lcol2)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LCOL2");
            entity.Property(e => e.ListeId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("ListeID");
            entity.Property(e => e.ListeType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("ListeTYPE");
            entity.Property(e => e.Rsocial)
                .HasMaxLength(100)
                .UseCollation("French_CI_AI")
                .HasColumnName("RSocial");
            entity.Property(e => e.Secteur)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UniqueId).HasColumnName("UniqueID");
            entity.Property(e => e.Ville)
                .HasMaxLength(100)
                .IsUnicode(false)
                .UseCollation("French_CI_AI");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
