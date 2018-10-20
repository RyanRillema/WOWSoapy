Public Class OverView

    Public Sub ShowForm()
        Me.Show()
    End Sub

    Public Sub HideForm()
        Me.Hide()
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        HideForm()
    End Sub
End Class