namespace RedCard

module Types =

  type Country =
  | England
  | Germany
  | Spain
  | Italy
  | France
  | UnitedStates
  | Mexico
  | Australia
  | Brazil
  | Argentina
  | Scotland
  | Portugal
  | Russia
  | Turkey

  type League =
  | EnglishPremierLeague
  | GermanBundesliga
  | SpanishPrimeraDivision
  | ItalianSerieA
  | FrenchLigue1
  | MLS
  | MexicanLigaMX
  | AustralianALeague
  | BrazilSerieA
  | ArgentinePrimeraDivision
  | ScottishPremiership
  | PortuguesLiga
  | RussianPremierLeague
  | TurkishSuperLig

  type LeagueLink =
    {
      League : League;
      TableUrl : string;
      Country : Country
    }

  type SquadLink = { SquadUrl : string; Country : Country }
