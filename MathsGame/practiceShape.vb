Imports System.Text.RegularExpressions ' Regular Expressions Namespace
Public Class practiceShape

    Private Sub practiceShape_Load(sender As Object, e As EventArgs) Handles MyBase.GotFocus
        Me.Text = "Practice with " + GlobalVariables.currentShape + "s!"
        Select Case GlobalVariables.currentShape
            Case GlobalVariables.AREA_1 ' circle
                field_1.Text = "Radius"
            Case GlobalVariables.AREA_2 ' triangle
                field_1.Text = "Width"
                field_2.Text = "Height"
            Case GlobalVariables.AREA_3 ' rectangle
                field_1.Text = "Width"
                field_2.Text = "Height"
            Case GlobalVariables.AREA_4 ' trap
                field_1.Text = "Height"
                field_2.Text = "Top length"
                ' TODO: field_3
            Case GlobalVariables.AREA_5 ' parallel
                field_1.Text = "Base"
                field_2.Text = "Height"
            Case GlobalVariables.AREA_6 ' kite
                field_1.Text = "Width diagonal"
                field_2.Text = "Height diagonal"
            Case GlobalVariables.VOLUME_1 ' cylinder
            Case GlobalVariables.VOLUME_2 ' tri pyramid
            Case GlobalVariables.VOLUME_3 ' rekt prism
            Case GlobalVariables.VOLUME_4 ' sphere
            Case GlobalVariables.VOLUME_5 ' tri prism
            Case GlobalVariables.VOLUME_6 ' TODO
        End Select
    End Sub
End Class