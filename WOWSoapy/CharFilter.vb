Public Class CharFilter
    Public sName As String
    Public iMinLevel As Integer
    Public iMaxLevel As Integer

    Public Sub New()
        InitValues()
    End Sub

    Public Function MatchesFilter(oChar As CharDetails) As Boolean
        Dim bReturn As Boolean = True

        If sName <> "" And sName <> oChar.Name Then
            bReturn = False
        End If

        If iMinLevel <> 0 And iMinLevel > oChar.Level Then
            bReturn = False
        End If

        If iMaxLevel <> 0 And iMaxLevel < oChar.Level Then
            bReturn = False
        End If

        Return bReturn
    End Function

    'initialise
    Private Sub InitValues()
        sName = ""
        iMinLevel = 0
        iMaxLevel = 0
    End Sub

End Class
