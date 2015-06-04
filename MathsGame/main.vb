Public Class mainScreen

    Dim isExiting As Boolean = False

    Private Sub friendlyExit_Click(sender As Object, e As EventArgs) Handles friendlyExit.Click
        exitForm.ShowDialog()
    End Sub

    Private Sub practice_Click(sender As Object, e As EventArgs) Handles practice.Click
        Me.Hide()
        practiceMain.Show()
    End Sub

    Private Sub help_Click(sender As Object, e As EventArgs) Handles help.Click
        about.ShowDialog()
    End Sub

    Private Sub mainScreen_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.BackgroundImage = My.Resources.maxresdefault
        PictureBox1.Image = My.Resources.mathstory_transparent
    End Sub
End Class
