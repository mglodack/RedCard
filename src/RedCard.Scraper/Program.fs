open System
open RedCard.Leagues
open RedCard.EspnHtmlParser

[<EntryPoint>]
let main argv =

  espnLeagues2015
  |> Seq.map parseTeams
  |> Seq.concat
  |> Seq.iter (fun squadUrl -> printfn "%A" squadUrl)

  // TODO: Grab all player info from squad url

  printfn "%A" argv
  0 // return an integer exit code
