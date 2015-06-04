Public Class practiceMain

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

    Private Sub shape1_Click(sender As Object, e As EventArgs) Handles shape1.Click
        If currentMode = SELECTED_AREA Then
            GlobalVariables.currentShape = GlobalVariables.AREA_1
            pracCircle.Show()
        Else
            GlobalVariables.currentShape = GlobalVariables.VOLUME_1
            pracCylinder.Show()
        End If
        Me.Hide()
    End Sub

    Private Sub shape2_Click(sender As Object, e As EventArgs) Handles shape2.Click
        If currentMode = SELECTED_AREA Then
            GlobalVariables.currentShape = GlobalVariables.AREA_2
            pracTriangle.Show()
        Else
            GlobalVariables.currentShape = GlobalVariables.VOLUME_2
            pracTrapezoidalPrism.Show()
        End If
        Me.Hide()
    End Sub

    Private Sub shape3_Click(sender As Object, e As EventArgs) Handles shape3.Click
        If currentMode = SELECTED_AREA Then
            GlobalVariables.currentShape = GlobalVariables.AREA_3
            pracRectangle.Show()
        Else
            GlobalVariables.currentShape = GlobalVariables.VOLUME_3
            pracRectangularPrism.Show()
        End If
        Me.Hide()
    End Sub

    Private Sub shape4_Click(sender As Object, e As EventArgs) Handles shape4.Click
        If currentMode = SELECTED_AREA Then
            GlobalVariables.currentShape = GlobalVariables.AREA_4
            pracTrapezium.Show()
        Else
            GlobalVariables.currentShape = GlobalVariables.VOLUME_4
            pracSphere.Show()
        End If
        Me.Hide()
    End Sub

    Private Sub shape5_Click(sender As Object, e As EventArgs) Handles shape5.Click
        If currentMode = SELECTED_AREA Then
            GlobalVariables.currentShape = GlobalVariables.AREA_5
            pracParallelogram.Show()
        Else
            GlobalVariables.currentShape = GlobalVariables.VOLUME_5
            pracTrapezoidalPrism.Show()
        End If
        Me.Hide()
    End Sub

    Private Sub shape6_Click(sender As Object, e As EventArgs) Handles shape6.Click
        If currentMode = SELECTED_AREA Then
            GlobalVariables.currentShape = GlobalVariables.AREA_6
            pracKite.Show()
        Else
            GlobalVariables.currentShape = GlobalVariables.VOLUME_6
            pracCone.Show()
        End If
        Me.Hide()
    End Sub
End Class