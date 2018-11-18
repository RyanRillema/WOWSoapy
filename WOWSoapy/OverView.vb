Public Class OverView
    Dim oSoapyData As SoapyData

    Public Sub New(oSetSoapyData As SoapyData)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        oSoapyData = oSetSoapyData

    End Sub

    Public Sub ShowForm()
        Me.Show()
    End Sub

    Public Sub HideForm()
        Me.Hide()
    End Sub

    Private Sub RefreshForm()

    End Sub

    Private Sub SetLabelColour(ByRef oLblLabel As Label)

        oLblLabel.ForeColor = Color.Blue

    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        HideForm()
    End Sub
End Class