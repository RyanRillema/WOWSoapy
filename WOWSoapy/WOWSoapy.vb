Public Class WOWSoapy
    Public SoapyData As SoapyData

    Private Sub WOWSoapy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SoapyData = New SoapyData(Me)
        SoapyData.TrdWowSoapy.StartThread()
        LblVersion.Text = SoapyData.SoapyConst.GetVersion
    End Sub

    Private Sub CmdGetData_Click(sender As Object, e As EventArgs) Handles cmdGetData.Click
        SoapyData.TrdWowSoapy.GetData()
        cmdGetData.Enabled = False
    End Sub

    Private Sub CmdOutputData_Click(sender As Object, e As EventArgs) Handles cmdOutputData.Click
        SoapyData.TrdWowSoapy.OutputData()
    End Sub

    Private Sub CmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        SoapyData.TrdWowSoapy.StopThread()
        Me.Close()
    End Sub

    Private Sub CmdRefresh_Click(sender As Object, e As EventArgs) Handles cmdRefresh.Click
        RefreshOutput()
        RefreshCharList()
    End Sub

    Private Sub RefreshOutput()
        lbOutput.Items.Clear()
        If SoapyData.TrdWowSoapy.bRunning Then
            lbOutput.Items.Add("Thread running")
        Else
            lbOutput.Items.Add("Thread NOT running")
        End If

        If SoapyData.TrdWowSoapy.bGetDataSuccess Then
            lbOutput.Items.Add("Data imported")
        ElseIf SoapyData.TrdWowSoapy.bGetData Then
            lbOutput.Items.Add("Data import pending")
        Else
            lbOutput.Items.Add("No active data import")
        End If

        If SoapyData.TrdWowSoapy.bOutputDataSuccess Then
            lbOutput.Items.Add("Data outputed")
        ElseIf SoapyData.TrdWowSoapy.bOutputData Then
            lbOutput.Items.Add("Data output pending")
        Else
            lbOutput.Items.Add("No active data output")
        End If
    End Sub

    Private Sub RefreshCharList()
        Dim iCharLoop As Integer

        lbChars.Items.Clear()

        For iCharLoop = 1 To SoapyData.AttemptedCharCount

            If Not IsNothing(SoapyData.Chars(iCharLoop)) Then

                lbChars.Items.Add(SoapyData.Chars(iCharLoop).Name)

            End If

        Next

    End Sub

    Private Sub cmdOverview_Click(sender As Object, e As EventArgs) Handles cmdOverview.Click
        SoapyData.FrmOverview.ShowForm()
    End Sub

    Private Sub cmdDetails_Click(sender As Object, e As EventArgs) Handles cmdDetails.Click
        SoapyData.FrmDetails.ShowForm(1)
    End Sub
End Class
