﻿Public Class GlobalVariables
    Public Const AREA_1 As String = "Circle"
    Public Const AREA_2 As String = "Triangle"
    Public Const AREA_3 As String = "Rectangle"
    Public Const AREA_4 As String = "Trapezium"
    Public Const AREA_5 As String = "Parallelogram"
    Public Const AREA_6 As String = "Kite"

    Public Const VOLUME_1 As String = "Cylinder"
    Public Const VOLUME_2 As String = "Rectangular Pyramid"
    Public Const VOLUME_3 As String = "Rectangular Prism"
    Public Const VOLUME_4 As String = "Sphere"
    Public Const VOLUME_5 As String = "Trapezoidal Prism"
    Public Const VOLUME_6 As String = "Cone"

    Public Const PI As Double = 3.1415926535897931
    Public Shared currentShape As String = ""
    Public Shared soundIsMuted As Boolean = False

    Public Class MathFunctions

        Private Function formatAnswer(answer As Double) As Integer
            Return CInt(Math.Round(answer))
        End Function

        Public Function circleArea(radius As Integer) As Integer
            Dim answer As Double = PI * radius * radius
            Return formatAnswer(answer)
        End Function

        Public Function triangleArea(height As Integer, width As Integer) As Integer
            Dim answer As Double = height * width * 0.5
            Return formatAnswer(answer)
        End Function

        Public Function rectangleArea(length As Integer, width As Integer) As Integer
            Dim answer As Double = length * width
            Return formatAnswer(answer)
        End Function

        Public Function trapeziumArea(height As Integer, side1 As Integer, side2 As Integer) As Integer
            Dim answer As Double = 0.5 * height * (side1 + side2)
            Return formatAnswer(answer)
        End Function

        Public Function parallelogramArea(base As Integer, height As Integer) As Integer
            Dim answer As Double = base * height
            Return formatAnswer(answer)
        End Function

        Public Function kiteArea(diagonal1 As Integer, diagonal2 As Integer) As Integer
            Dim answer As Double = diagonal1 * diagonal2 * 0.5
            Return formatAnswer(answer)
        End Function

        Public Function cylinderVolume(radius As Integer, height As Integer) As Integer
            Dim answer As Double = PI * Math.Pow(radius, 2) * height
            Return formatAnswer(answer)
        End Function

        Public Function rectangularPyramidVolume(baseHeight As Integer, baseWidth As Integer, height As Integer) As Integer
            Dim answer As Double = baseHeight * baseWidth * height / 3
            Return formatAnswer(answer)
        End Function

        Public Function rectangularPrismVolume(length As Integer, width As Integer, height As Integer) As Integer
            Dim answer As Double = length * width * height
            Return formatAnswer(answer)
        End Function

        Public Function sphereVolume(radius As Integer) As Integer
            Dim answer As Double = 4 / 3 * PI * Math.Pow(radius, 3)
            Return formatAnswer(answer)
        End Function

        Public Function trapezoidalPrismVolume(length As Integer, height As Integer, a As Integer, b As Integer) As Integer
            Dim answer As Double = height * (a + b) * length / 2
            Return formatAnswer(answer)
        End Function

        Public Function coneVolume(radius As Integer, height As Integer) As Integer
            Dim answer As Double = PI * Math.Pow(radius, 2) * height / 3
            Return formatAnswer(answer)
        End Function
    End Class
End Class