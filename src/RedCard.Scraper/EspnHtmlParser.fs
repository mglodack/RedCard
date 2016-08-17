namespace RedCard

module EspnHtmlParser =
  open FSharp.Data
  open RedCard.Types
  open RedCard.EspnUrlHelper
  open System

  type EspnTeam =
    {
      Name : string
      TeamUrl : string
    }

  let private _matchesAttributeNameAndValue (name : string) (value : string) (node : HtmlNode) =
    node.HasAttribute(name, value)

  let private _findDescendantsOf (tags: seq<string>) (node : HtmlNode) =
    node.Descendants tags

  let private _createEspnTeam (name : string) (node : HtmlNode) =
    {
      Name = node.InnerText();
      TeamUrl = node.AttributeValue(name);
    }

  let private _createTeam (espnTeam : EspnTeam) (league : League) =
    {
      Name = espnTeam.Name;
      SquadUrl = (create2015SquadUrl espnTeam.TeamUrl);
      League = league;
    }

  let private _parseTableData (value : string) (tableDataList : HtmlNode seq) =
    tableDataList
    |> Seq.find (_matchesAttributeNameAndValue "class" value)
    |> (fun node -> node.InnerText())

  let private _tryConvertToInt (value : string) =
    let mutable result = 0
    Int32.TryParse(value, &result) |> ignore
    result

  let private _parsePlayerInfo (team : Team) (htmlNode : HtmlNode) =
    let tdList = htmlNode.Descendants [ "td" ]
    {
      Position =
        tdList
        |> _parseTableData "pos"
      Name =
        tdList
        |> _parseTableData "pla"
      YellowCards =
        tdList
        |> _parseTableData "yellowCards"
        |> _tryConvertToInt
      RedCards =
        tdList
        |> _parseTableData "redCards"
        |> _tryConvertToInt
      Team = team.Name
      League = leagueToString team.League.Name
      Country = countryToString team.League.Country
    }

  let parseTeams (league : League) =
    HtmlDocument.Load(league.LeagueTableUrl).Descendants [ "td" ]
    |> Seq.filter (_matchesAttributeNameAndValue "class" "team")
    |> Seq.map (_findDescendantsOf [ "a" ])
    |> Seq.concat
    |> Seq.map (_createEspnTeam "href")
    |> Seq.map (fun espnTeamUrl -> _createTeam espnTeamUrl league)

  let parsePlayers (team : Team) =
    HtmlDocument.Load(team.SquadUrl).Descendants [ "table" ]
    |> Seq.map (_findDescendantsOf [ "tr" ])
    |> Seq.concat
    |> Seq.filter (fun node ->
      node.Descendants ["td"]
      |> Seq.exists (_matchesAttributeNameAndValue "class" "redCards"))
    |> Seq.map (_parsePlayerInfo team)
