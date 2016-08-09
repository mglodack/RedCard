open FSharp.Data
open System

type Team = { Name : string; Id : int; }

let ArsenalStats = new HtmlProvider<"http://www.espnfc.us/club/arsenal/359/squad?season=2015">()

let premierLeague = new HtmlProvider<"http://www.espnfc.us/english-premier-league/23/table?season=2015">()

let private _2015SquadPath = "squad?season=2015"

let private _trimTeamIndexUrl (indexUrl : string) =
  indexUrl.Remove(indexUrl.LastIndexOf('/'))

let createSquadUrl indexUrl =
  sprintf "%s/%s" (_trimTeamIndexUrl indexUrl) _2015SquadPath

[<EntryPoint>]
let main argv =
  premierLeague.Tables.Html.Descendants ["td"]
  |> Seq.filter (fun node -> node.HasAttribute("class", "team"))
  |> Seq.map (fun node -> node.Descendants [ "a" ])
  |> Seq.concat
  |> Seq.map (fun anchorNode -> anchorNode.AttributeValue("href"))
  |> Seq.iter (fun link -> printfn "%s" (createSquadUrl link))

  printfn "%A" argv
  0 // return an integer exit code
