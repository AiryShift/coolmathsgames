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
        Me.BackgroundImage = My.Resources.mainBackground
        PictureBox1.Image = My.Resources.mathstory_transparent
        playMusic()
    End Sub

    Private Function rand(lowerbound As Integer, upperbound As Integer) As Integer
        Dim randomValue As Integer = CInt(Math.Floor((upperbound - lowerbound + 1) * Rnd())) + lowerbound
        Return randomValue
    End Function

    Private Sub playMusic()
        If rand(0, 2) = 0 Then
            My.Computer.Audio.Play(My.Resources.henesy, AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Play(My.Resources.introMusic, AudioPlayMode.BackgroundLoop)
        End If
    End Sub

    Private Sub mute_Click(sender As Object, e As EventArgs) Handles mute.Click
        If Not GlobalVariables.soundIsMuted Then
            GlobalVariables.soundIsMuted = True
            My.Computer.Audio.Stop()
        Else
            playMusic()
        End If
    End Sub
End Class
