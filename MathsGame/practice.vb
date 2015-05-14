﻿Public Class practice
    Const AREA_1 As String = "Circle"
    Const AREA_2 As String = "Triangle"
    Const AREA_3 As String = "Rectangle"
    Const AREA_4 As String = "Trapezium"
    Const AREA_5 As String = "Parallelogram"
    Const AREA_6 As String = "Kite"

    Const VOLUME_1 As String = "Cylinder"
    Const VOLUME_2 As String = "Triangular Pyramid"
    Const VOLUME_3 As String = "Rectangular Prism"
    Const VOLUME_4 As String = "Sphere"
    Const VOLUME_5 As String = "Triangular Prism"
    Const VOLUME_6 As String = "Icosahedron"

    Private Sub area_Click(sender As Object, e As EventArgs) Handles area.Click
        shape1.Text = AREA_1
        shape2.Text = AREA_2
        shape3.Text = AREA_3
        shape4.Text = AREA_4
        shape5.Text = AREA_5
        shape6.Text = AREA_6
    End Sub

    Private Sub volume_Click(sender As Object, e As EventArgs) Handles volume.Click
        shape1.Text = VOLUME_1
        shape2.Text = VOLUME_2
        shape3.Text = VOLUME_3
        shape4.Text = VOLUME_4
        shape5.Text = VOLUME_5
        shape6.Text = VOLUME_6
    End Sub
End Class