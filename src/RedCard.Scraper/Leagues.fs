namespace RedCard

module Leagues =
  open RedCard.Models

  let englishPremierLeague tableUrl =
    {
      League = League.EnglishPremierLeague;
      TableUrl = tableUrl;
      Country = Country.England
    }

  let leagues =
    [
      englishPremierLeague "http://www.espnfc.us/english-premier-league/23/table?season=2015";
    ]

