Public Class CharFilter
    Public oSoapyData As SoapyData
    Public sName As String
    Public sClass As String
    Public sRealmA, sRealmB, sRealmC As String
    Public iMinLevel As Integer
    Public iMaxLevel As Integer

    Public Sub New(oSetSoapyData As SoapyData)
        InitValues()
        oSoapyData = oSetSoapyData
    End Sub

    Public Function MatchesFilter(oChar As CharDetails) As Boolean
        Dim bReturn As Boolean = True

        If sName <> "" And sName <> oChar.Name Then
            bReturn = False
        End If

        If sClass <> "" And sClass <> oSoapyData.SoapyIO.GetClassName(oChar.CharClass) Then
            bReturn = False
        End If

        If sRealmA <> "" And sRealmA <> oChar.Realm Then
            bReturn = False
        End If
        If sRealmB <> "" And sRealmB <> oChar.Realm Then
            bReturn = False
        End If
        If sRealmC <> "" And sRealmC <> oChar.Realm Then
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
