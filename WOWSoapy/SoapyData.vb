Public Class SoapyData

    Public FrmWowSoapy As WOWSoapy
    Public FrmOverview As OverView
    Public FrmDetails As Details
    Public SoapyIO As SoapyIO
    Public SoapyConst As SoapyConst
    Public TrdWowSoapy As TrdWowSoapy

    Public CharCount As Integer
    Public Chars(50) As CharDetails
    Public Races As Races
    Public Classes As Classes

    Public Sub New(SetFrmWowSoapy As WOWSoapy)
        FrmWowSoapy = SetFrmWowSoapy
        FrmOverview = New OverView
        FrmDetails = New Details(Me)
        FrmOverview.HideForm()
        SoapyIO = New SoapyIO(Me)
        SoapyConst = New SoapyConst
        TrdWowSoapy = New TrdWowSoapy(Me)
    End Sub

    Public Sub SortCharArrayByLevel()
        Dim TempChar As CharDetails
        Dim CharLoop As Integer

        For CharLoop = 1 To 49

            If Not IsNothing(Chars(CharLoop + 1)) Then

                If CharLoop < 50 And Chars(CharLoop).Level < Chars(CharLoop + 1).Level Then

                    TempChar = Chars(CharLoop)
                    Chars(CharLoop) = Chars(CharLoop + 1)
                    Chars(CharLoop + 1) = TempChar

                End If

            End If

        Next


    End Sub

    Public Function getSecondaryProfession(CharDetail As CharDetails, Name As String)
        Dim ReturnProfession As Secondary
        Dim bLoop As Boolean = True
        Dim iLoop As Integer

        While bLoop

            If CharDetail.Professions.Secondary(iLoop).Name = Name Then
                ReturnProfession = CharDetail.Professions.Secondary(iLoop)
                bLoop = False
            End If

            If iLoop = 20 Then
                bLoop = False
            End If

        End While

        Return ReturnProfession

    End Function

End Class
