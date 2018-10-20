Imports Newtonsoft.Json

Public Class CharDetails

    <JsonProperty("lastModified")>
    Public Property LastModified As Long

    <JsonProperty("name")>
    Public Property Name As String

    <JsonProperty("realm")>
    Public Property Realm As String

    <JsonProperty("battlegroup")>
    Public Property Battlegroup As String

    <JsonProperty("class")>
    Public Property CharClass As Integer

    <JsonProperty("race")>
    Public Property Race As Integer

    <JsonProperty("gender")>
    Public Property Gender As Integer

    <JsonProperty("level")>
    Public Property Level As Integer

    <JsonProperty("achievementPoints")>
    Public Property AchievementPoints As Integer

    <JsonProperty("thumbnail")>
    Public Property Thumbnail As String

    <JsonProperty("calcClass")>
    Public Property CalcClass As String

    <JsonProperty("faction")>
    Public Property Faction As Integer

    <JsonProperty("professions")>
    Public Property Professions As Professions

    <JsonProperty("totalHonorableKills")>
    Public Property TotalHonorableKills As Integer
    Public Function getPrimaryProfession(CharDetail As CharDetails, Level As String, Prof As String) As Primary
        Dim ReturnProfession As Primary = New Primary
        Dim bLoop As Boolean = True
        Dim iLoop As Integer

        ReturnProfession.Rank = 0

        While bLoop

            If CharDetail.Professions.Primary(iLoop).Name = LTrim(Level & " " & Prof) Then
                ReturnProfession = CharDetail.Professions.Primary(iLoop)
                bLoop = False
            End If

            iLoop = iLoop + 1

            If iLoop >= CharDetail.Professions.Primary.Count Then
                bLoop = False
            End If

        End While

        Return ReturnProfession

    End Function

    Public Function getSecondaryProfession(CharDetail As CharDetails, Level As String, Prof As String) As Secondary
        Dim ReturnProfession As Secondary = New Secondary
        Dim bLoop As Boolean = True
        Dim iLoop As Integer

        ReturnProfession.Rank = 0

        While bLoop

            If CharDetail.Professions.Secondary(iLoop).Name = LTrim(Level & " " & Prof) Then
                ReturnProfession = CharDetail.Professions.Secondary(iLoop)
                bLoop = False
            End If

            iLoop = iLoop + 1

            If iLoop >= CharDetail.Professions.Secondary.Count Then
                bLoop = False
            End If

        End While

        Return ReturnProfession

    End Function

End Class

Public Class Primary

    <JsonProperty("id")>
    Public Property Id As Integer

    <JsonProperty("name")>
    Public Property Name As String

    <JsonProperty("icon")>
    Public Property Icon As String

    <JsonProperty("rank")>
    Public Property Rank As Integer

    <JsonProperty("max")>
    Public Property Max As Integer

    <JsonProperty("recipes")>
    Public Property Recipes As Integer()
End Class

Public Class Secondary

    <JsonProperty("id")>
    Public Property Id As Integer

    <JsonProperty("name")>
    Public Property Name As String

    <JsonProperty("icon")>
    Public Property Icon As String

    <JsonProperty("rank")>
    Public Property Rank As Integer

    <JsonProperty("max")>
    Public Property Max As Integer

    <JsonProperty("recipes")>
    Public Property Recipes As Integer()
End Class

Public Class Professions

    <JsonProperty("primary")>
    Public Property Primary As Primary()

    <JsonProperty("secondary")>
    Public Property Secondary As Secondary()
End Class
