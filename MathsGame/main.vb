Public Class mainScreen

    Dim isExiting As Boolean = False

    Private Sub friendlyExit_Click(sender As Object, e As EventArgs) Handles friendlyExit.Click

    End Sub

    Private Sub practice_Click(sender As Object, e As EventArgs) Handles practice.Click
        Me.Hide()
        practice.Show()
    End Sub

    Private Sub help_Click(sender As Object, e As EventArgs) Handles help.Click
        about.ShowDialog()
    End Sub
End Class
