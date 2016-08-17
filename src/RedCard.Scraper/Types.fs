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

  let countryToString country =
    match country with
    | England       -> "England"
    | Germany       -> "Germany"
    | Spain         -> "Spain"
    | Italy         -> "Italy"
    | France        -> "France"
    | UnitedStates  -> "United States"
    | Mexico        -> "Mexico"
    | Australia     -> "Australia"
    | Brazil        -> "Brazil"
    | Argentina     -> "Argentina"
    | Scotland      -> "Scotland"
    | Portugal      -> "Portugal"
    | Russia        -> "Russia"
    | Turkey        -> "Turkey"

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
  | PortugueseLiga
  | RussianPremierLeague
  | TurkishSuperLig

  let leagueToString league =
    match league with
    | EnglishPremierLeague      -> "English Premier League"
    | GermanBundesliga          -> "German Bundesliga"
    | SpanishPrimeraDivision    -> "Spanish Primera Division"
    | ItalianSerieA             -> "Italian Serie A"
    | FrenchLigue1              -> "French Ligue 1"
    | MLS                       -> "Major League Soccer"
    | MexicanLigaMX             -> "Mexican Liga MX"
    | AustralianALeague         -> "A-League"
    | BrazilSerieA              -> "Brazil Serie A"
    | ArgentinePrimeraDivision  -> "Argentine Primera Division"
    | ScottishPremiership       -> "Scottish Premiership"
    | PortugueseLiga            -> "Portuguese Liga"
    | RussianPremierLeague      -> "Russian Premier League"
    | TurkishSuperLig           -> "Turkish Super Lig"

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
      Team : string;
      League : string;
      Country : string;
    }
