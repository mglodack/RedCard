open System
open RedCard.Leagues
open RedCard.EspnHtmlParser

[<EntryPoint>]
let main argv =

  let teams =
    espnLeagues2015
    |> Seq.map parseTeams
    |> Seq.concat

  teams
  |> Seq.iter parsePlayers
  // TODO: Grab all player info from squad url

  printfn "%A" argv
  0 // return an integer exit code
