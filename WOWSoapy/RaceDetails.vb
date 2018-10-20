Imports Newtonsoft.Json

Public Class Race

    <JsonProperty("id")>
    Public Property Id As Integer

    <JsonProperty("mask")>
    Public Property Mask As Integer

    <JsonProperty("side")>
    Public Property Side As String

    <JsonProperty("name")>
    Public Property Name As String
End Class

Public Class Races

    <JsonProperty("races")>
    Public Property Races As Race()
End Class
