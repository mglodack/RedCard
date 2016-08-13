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

  type LeagueName =
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

  type League =
    {
      Name : LeagueName;
      LeagueTableUrl : string;
      Country : Country
    }

  type Team =
    {
      Name : string;
      SquadUrl : string;
      League : League;
    }

  type Player =
    {
      Position : string;
      Name : string;
      YellowCards : int
      RedCards : int
      Team : Team;
    }
