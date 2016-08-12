namespace RedCard

module Models =

  type Country =
  | England
  | Germany

  type League =
  | EnglishPremierLeague

  type LeagueLink =
    {
      League : League;
      TableUrl : string;
      Country : Country
    }

  type SquadLink = { SquadUrl : string; Country : Country }