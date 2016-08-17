open System
open RedCard.Leagues
open RedCard.EspnHtmlParser
open Newtonsoft.Json
open System.IO

[<EntryPoint>]
let main argv =

  let teams =
    espnLeagues2015
    |> Seq.map parseTeams
    |> Seq.concat

  let players =
    teams
    |> Seq.map parsePlayers
    |> Seq.concat

  let serializedPlayers = JsonConvert.SerializeObject(players)

  printfn "%s" serializedPlayers

  File.WriteAllText("players.json", serializedPlayers)

  printfn "%A" argv
  0 // return an integer exit code
