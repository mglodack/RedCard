namespace RedCard

module Leagues =
  open RedCard.Types

  let private _createLeagueLink league tableUrl country =
    {
      League = league;
      TableUrl = tableUrl;
      Country = country;
    }

  let englishPremierLeague tableUrl =
     _createLeagueLink League.EnglishPremierLeague tableUrl Country.England

  let germanBundesliga tableUrl =
    _createLeagueLink League.GermanBundesliga tableUrl Country.Germany

  let spanishPrimeraDivision tableUrl =
    _createLeagueLink League.SpanishPrimeraDivision tableUrl Country.Spain

  let italianSeriaA tableUrl =
    _createLeagueLink League.ItalianSerieA tableUrl Country.Italy

  let frenchLigue1 tableUrl =
    _createLeagueLink League.FrenchLigue1 tableUrl Country.France

  let mls tableUrl =
    _createLeagueLink League.MLS tableUrl Country.UnitedStates

  let mexicanLigaMX tableUrl =
    _createLeagueLink League.MexicanLigaMX tableUrl Country.Mexico

  let australianALeauge tableUrl =
    _createLeagueLink League.AustralianALeague tableUrl Country.Australia

  let brazilianSerieA tableUrl =
    _createLeagueLink League.BrazilSerieA tableUrl Country.Brazil

  let argentinePrimeraDivision tableUrl =
    _createLeagueLink League.ArgentinePrimeraDivision tableUrl Country.Argentina

  let scottishPremiership tableUrl =
    _createLeagueLink League.ScottishPremiership tableUrl Country.Scotland

  let portuguesLiga tableUrl =
    _createLeagueLink League.PortuguesLiga tableUrl Country.Portugal

  let russianPremierLeague tableUrl =
    _createLeagueLink League.RussianPremierLeague tableUrl Country.Russia

  let turkishSuperLig tableUrl =
    _createLeagueLink League.RussianPremierLeague tableUrl Country.Turkey

  let espnLeagues2015 =
    [
      englishPremierLeague "http://www.espnfc.us/english-premier-league/23/table?season=2015";
      germanBundesliga "http://www.espnfc.us/german-bundesliga/10/table?season=2015"
      spanishPrimeraDivision "http://www.espnfc.us/spanish-primera-division/15/table?season=2015"
      italianSeriaA "http://www.espnfc.us/italian-serie-a/12/table?season=2015"
      frenchLigue1 "http://www.espnfc.us/french-ligue-1/9/table?season=2015"
      mls "http://www.espnfc.us/major-league-soccer/19/table?season=2015"
      mexicanLigaMX "http://www.espnfc.us/mexican-liga-mx/22/table?season=2015"
      australianALeauge "http://www.espnfc.us/australian-a-league/1308/table?season=2015"
      brazilianSerieA "http://www.espnfc.us/futebol-brasileiro/85/table?season=2015"
      argentinePrimeraDivision "http://www.espnfc.us/primera-division-de-argentina/1/table?season=2015"
      scottishPremiership "http://www.espnfc.us/scottish-premiership/45/table?season=2015"
      portuguesLiga "http://www.espnfc.us/portuguese-liga/14/table?season=2015"
      russianPremierLeague "http://www.espnfc.us/russian-premier-league/106/table?season=2015"
      turkishSuperLig "http://www.espnfc.us/turkish-super-lig/18/table?season=2015"
    ]

