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
                shapeDesc.Image = My.Resources.circle
                shapeFormula.Image = My.Resources.circleForm
            Case GlobalVariables.AREA_2
                hide3()
                lblInput1.Text = "Height"
                lblInput2.Text = "Base"
                shapeDesc.Image = My.Resources.triangle
                shapeFormula.Image = My.Resources.triangleForm
            Case GlobalVariables.AREA_3
                hide3()
                lblInput1.Text = "Length"
                lblInput2.Text = "Width"
                shapeDesc.Image = My.Resources.rectangle
                shapeFormula.Image = My.Resources.rectangle
            Case GlobalVariables.AREA_4
                lblInput1.Text = "Height"
                lblInput2.Text = "a"
                lblInput2.Text = "b"
                shapeDesc.Image = My.Resources.trapezium
                shapeFormula.Image = My.Resources.trapeziumForm
            Case GlobalVariables.AREA_5
                hide3()
                lblInput1.Text = "Base"
                lblInput2.Text = "Height"
                shapeDesc.Image = My.Resources.parallelogram
                shapeFormula.Image = My.Resources.parallelogramForm
            Case GlobalVariables.AREA_6
                hide3()
                lblInput1.Text = "p"
                lblInput2.Text = "q"
                shapeDesc.Image = My.Resources.kite
                shapeFormula.Image = My.Resources.kiteForm
            Case GlobalVariables.VOLUME_1
                hide3()
                lblInput1.Text = "Radius"
                lblInput2.Text = "Height"
                shapeDesc.Image = My.Resources.cylinder
                shapeFormula.Image = My.Resources.circleForm
            Case GlobalVariables.VOLUME_2
                lblInput1.Text = "Length"
                lblInput2.Text = "Width"
                lblInput3.Text = "Height"
                shapeDesc.Image = My.Resources.rectangularPyramid
                shapeFormula.Image = My.Resources.rectangularPyramidForm
            Case GlobalVariables.VOLUME_3
                lblInput1.Text = "Length"
                lblInput2.Text = "Width"
                lblInput3.Text = "Height"
                shapeDesc.Image = My.Resources.rectangularPrism
                shapeFormula.Image = My.Resources.rectangularPrismForm
            Case GlobalVariables.VOLUME_4
                hide2()
                hide3()
                lblInput1.Text = "Radius"
                shapeDesc.Image = My.Resources.sphere
                shapeFormula.Image = My.Resources.sphereForm
            Case GlobalVariables.VOLUME_5
            Case GlobalVariables.VOLUME_6
                hide3()
                lblInput1.Text = "Radius"
                lblInput2.Text = "Cone"
                shapeDesc.Image = My.Resources.cone
                shapeFormula.Image = My.Resources.coneForm
        End Select
    End Sub

    Private Sub back_Click(sender As Object, e As EventArgs) Handles back.Click
        Me.Hide()
        practiceMain.Show()
    End Sub
End Class