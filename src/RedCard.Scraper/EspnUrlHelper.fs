namespace RedCard

module EspnUrlHelper =
  let private _squadPath = "squad?season=2015"

  let private _trimTeamIndexUrl (indexUrl : string) =
    indexUrl.Remove(indexUrl.LastIndexOf('/'))

  let create2015SquadUrl teamIndexUrl =
    sprintf "%s/%s" (_trimTeamIndexUrl teamIndexUrl) _squadPath

