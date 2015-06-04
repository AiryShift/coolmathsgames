Public Class pracMaster
    Private Sub pracMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.practiceBackground
    End Sub

    Private Sub hide2()
        lblInput2.Hide()
        txtInput3.Hide()
    End Sub

    Private Sub hide3()
        lblInput3.Hide()
        txtInput3.Hide()
    End Sub

    Private Sub initialize(sender As Object, e As EventArgs) Handles MyBase.GotFocus
        lblInput1.Show()
        lblInput2.Show()
        lblInput3.Show()
        txtInput1.Show()
        txtInput1.Text = ""
        txtInput2.Show()
        txtInput2.Text = ""
        txtInput3.Show()
        txtInput3.Text = ""
        Select Case GlobalVariables.currentShape
            Case GlobalVariables.AREA_1
                hide2()
                hide3()
                lblInput1.Text = "Radius"
            Case GlobalVariables.AREA_2
                hide3()
                lblInput1.Text = "Height"
                lblInput2.Text = "Base"
            Case GlobalVariables.AREA_3
                hide3()
                lblInput1.Text = "Length"
                lblInput2.Text = "Width"
            Case GlobalVariables.AREA_4
                lblInput1.Text = "Height"
                lblInput2.Text = "a"
                lblInput2.Text = "b"
            Case GlobalVariables.AREA_5
                lblInput1.Text = "Base"
                lblInput2.Text = "Height"
            Case GlobalVariables.AREA_6
                lblInput1.Text = "p"
                lblInput2.Text = "q"
            Case GlobalVariables.VOLUME_1
            Case GlobalVariables.VOLUME_2
            Case GlobalVariables.VOLUME_3
            Case GlobalVariables.VOLUME_4
            Case GlobalVariables.VOLUME_5
            Case GlobalVariables.VOLUME_6
        End Select
    End Sub
End Class