Public Class practiceMain

    Const SELECTED_AREA As Integer = 0
    Const SELECTED_VOLUME As Integer = 1
    Dim currentMode As Integer = SELECTED_AREA

    Private Sub area_Open(sender As Object, e As EventArgs) Handles Me.Load
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

    Private Sub openPracticeSheet()
        Me.Hide()
        pracMaster.Show()
    End Sub

    Private Sub shape1_Click(sender As Object, e As EventArgs) Handles shape1.Click
        If currentMode = SELECTED_AREA Then
            GlobalVariables.currentShape = GlobalVariables.AREA_1
        Else
            GlobalVariables.currentShape = GlobalVariables.VOLUME_1
        End If
        openPracticeSheet()
    End Sub

    Private Sub shape2_Click(sender As Object, e As EventArgs) Handles shape2.Click
        If currentMode = SELECTED_AREA Then
            GlobalVariables.currentShape = GlobalVariables.AREA_2
        Else
            GlobalVariables.currentShape = GlobalVariables.VOLUME_2
        End If
        openPracticeSheet()
    End Sub

    Private Sub shape3_Click(sender As Object, e As EventArgs) Handles shape3.Click
        If currentMode = SELECTED_AREA Then
            GlobalVariables.currentShape = GlobalVariables.AREA_3
        Else
            GlobalVariables.currentShape = GlobalVariables.VOLUME_3
        End If
        openPracticeSheet()
    End Sub

    Private Sub shape4_Click(sender As Object, e As EventArgs) Handles shape4.Click
        If currentMode = SELECTED_AREA Then
            GlobalVariables.currentShape = GlobalVariables.AREA_4
        Else
            GlobalVariables.currentShape = GlobalVariables.VOLUME_4
        End If
        openPracticeSheet()
    End Sub

    Private Sub shape5_Click(sender As Object, e As EventArgs) Handles shape5.Click
        If currentMode = SELECTED_AREA Then
            GlobalVariables.currentShape = GlobalVariables.AREA_5
        Else
            GlobalVariables.currentShape = GlobalVariables.VOLUME_5
        End If
        openPracticeSheet()
    End Sub

    Private Sub shape6_Click(sender As Object, e As EventArgs) Handles shape6.Click
        If currentMode = SELECTED_AREA Then
            GlobalVariables.currentShape = GlobalVariables.AREA_6
        Else
            GlobalVariables.currentShape = GlobalVariables.VOLUME_6
        End If
        openPracticeSheet()
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        mainScreen.Show()
    End Sub
End Class