Imports System.Text.RegularExpressions
Public Class pracMaster
    Dim myMath As Object = New GlobalVariables.MathFunctions()
    Private Sub pracMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Wiki_background
    End Sub

    Private Sub hide2()
        lblInput2.Hide()
        txtInput2.Hide()
    End Sub

    Private Sub hide3()
        lblInput3.Hide()
        txtInput3.Hide()
    End Sub

    Private Sub initialize(sender As Object, e As EventArgs) Handles Me.VisibleChanged
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
                shapeFormula.Image = My.Resources.rectangleForm
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
                lblInput1.Text = "Width (here we assume height = 2)"
                lblInput2.Text = "a"
                lblInput3.Text = "b"
                shapeDesc.Image = My.Resources.trapezoidalPrism
                shapeFormula.Image = My.Resources.trapezoidalPrismForm
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

    Private Function checkInput(strIn As String) As String
        Dim rgx As Regex = New Regex("^[0-9]{1,2}")
        Dim match As Match = rgx.Match(strIn)
        If match.Success Then
            Return match.Value
        End If
        Return "0"
    End Function

    Private Sub txtInput1_TextChanged(sender As Object, e As EventArgs) Handles txtInput1.TextChanged, txtInput2.TextChanged, txtInput3.TextChanged
        txtInput1.Text = checkInput(txtInput1.Text)
        txtInput2.Text = checkInput(txtInput2.Text)
        txtInput3.Text = checkInput(txtInput3.Text)
        Dim a As Integer = CInt(txtInput1.Text)
        Dim b As Integer = CInt(txtInput2.Text)
        Dim c As Integer = CInt(txtInput3.Text)
        Select Case GlobalVariables.currentShape
            Case GlobalVariables.AREA_1 'Circle
                answer.Text = myMath.circleArea(a)
            Case GlobalVariables.AREA_2 'Triangle
                answer.Text = myMath.triangleArea(a, b)
            Case GlobalVariables.AREA_3 'Rectangle
                answer.Text = myMath.rectangleArea(a, b)
            Case GlobalVariables.AREA_4 'Trapezium
                answer.Text = myMath.trapeziumArea(a, b, c)
            Case GlobalVariables.AREA_5 'Parallelogram
                answer.Text = myMath.parallelogramArea(a, b)
            Case GlobalVariables.AREA_6 'Kite
                answer.Text = myMath.kiteArea(a, b)

            Case GlobalVariables.VOLUME_1 'Cylinder
                answer.Text = myMath.cylinderVolume(a, b)
            Case GlobalVariables.VOLUME_2 'RectangularPyramid"
                answer.Text = myMath.rectangularPyramidVolume(a, b, c)
            Case GlobalVariables.VOLUME_3 'RectangularPrism"
                answer.Text = myMath.rectangularPrismVolume(a, b, c)
            Case GlobalVariables.VOLUME_4 'Sphere
                answer.Text = myMath.sphereVolume(a)
            Case GlobalVariables.VOLUME_5 'TrapezoidalPrism
                answer.Text = myMath.trapezoidalPrismVolume(a, 2, b, c)
            Case GlobalVariables.VOLUME_6 'Cone
                answer.Text = myMath.coneVolume(a, b)
        End Select
    End Sub

    Private Sub info_Click(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        Select Case GlobalVariables.currentShape
            Case GlobalVariables.AREA_1 'Circle
                info.Image = My.Resources.circleAbout
            Case GlobalVariables.AREA_2 'Triangle
                info.Image = My.Resources.triangleAbout
            Case GlobalVariables.AREA_3 'Rectangle
                info.Image = My.Resources.rectangleAbout
            Case GlobalVariables.AREA_4 'Trapezium
                info.Image = My.Resources.trapeziumAbout
            Case GlobalVariables.AREA_5 'Parallelogram
                info.Image = My.Resources.parallelogramAbout
            Case GlobalVariables.AREA_6 'Kite
                info.Image = My.Resources.kiteAbout

            Case GlobalVariables.VOLUME_1 'Cylinder
                info.Image = My.Resources.cylinderAbout
            Case GlobalVariables.VOLUME_2 'RectangularPyramid
                info.Image = My.Resources.rectangularPyramidAbout
            Case GlobalVariables.VOLUME_3 'RectangularPrism
                info.Image = My.Resources.rectangularPrismAbout
            Case GlobalVariables.VOLUME_4 'Sphere
                info.Image = My.Resources.sphereAbout
            Case GlobalVariables.VOLUME_5 'TrapezoidalPrism
                info.Image = My.Resources.trapezoidalPrismAbout
            Case GlobalVariables.VOLUME_6 'Cone
                info.Image = My.Resources.coneAbout
        End Select
    End Sub
End Class