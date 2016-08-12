namespace RedCard

module EspnHtmlParser =
  open FSharp.Data
  open RedCard.Types
  open RedCard.EspnUrlHelper

  type EspnTeam =
    {
      Name : string
      TeamUrl : string
    }

  let private _byAttribute (name : string) (value : string) (node : HtmlNode) =
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

  let parseTeams (league : League) =
    HtmlDocument.Load(league.LeagueTableUrl).Descendants [ "td" ]
    |> Seq.filter (_byAttribute "class" "team")
    |> Seq.map (_findDescendantsOf [ "a" ])
    |> Seq.concat
    |> Seq.map (_createEspnTeam "href")
    |> Seq.map (fun espnTeamUrl -> _createTeam espnTeamUrl league)

