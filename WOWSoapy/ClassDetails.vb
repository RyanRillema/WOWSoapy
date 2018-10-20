Imports Newtonsoft.Json

Public Class IClass

    <JsonProperty("id")>
    Public Property Id As Integer

    <JsonProperty("mask")>
    Public Property Mask As Integer

    <JsonProperty("powerType")>
    Public Property PowerType As String

    <JsonProperty("name")>
    Public Property Name As String
End Class

Public Class Classes

    <JsonProperty("classes")>
    Public Property Classes As IClass()
End Class


