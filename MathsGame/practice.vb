Public Class practice

    Const SELECTED_AREA As Integer = 0
    Const SELECTED_VOLUME As Integer = 1
    Dim currentMode As Integer = SELECTED_AREA

    Private Sub area_Open(sender As Object, e As EventArgs) Handles Me.GotFocus
        area.PerformClick()
        currentMode = SELECTED_AREA
    End Sub

    Private Sub area_Click(sender As Object, e As EventArgs) Handles area.Click
        shape1.Text = GlobalVariables.AREA_1
        shape2.Text = GlobalVariables.AREA_2
        shape3.Text = GlobalVariables.AREA_3
        shape4.Text = GlobalVariables.AREA_4
        shape5.Text = GlobalVariables.AREA_5
        shape6.Text = GlobalVariables.AREA_6
        currentMode = SELECTED_AREA
    End Sub

    Private Sub volume_Click(sender As Object, e As EventArgs) Handles volume.Click
        shape1.Text = GlobalVariables.VOLUME_1
        shape2.Text = GlobalVariables.VOLUME_2
        shape3.Text = GlobalVariables.VOLUME_3
        shape4.Text = GlobalVariables.VOLUME_4
        shape5.Text = GlobalVariables.VOLUME_5
        shape6.Text = GlobalVariables.VOLUME_6
        currentMode = SELECTED_VOLUME
    End Sub
End Class