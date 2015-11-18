Public Class frmMain
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        ViewWindow.Navigate(txtLocation.Text)
    End Sub
End Class
