Public Class Puntos
    Private x As Double = 4
    Private y As Double = 3
    Public Function puntos() As Double
        Return x And y
    End Function

    Public Sub obtenerPunto(nuevoP As Double)
        x = nuevoP
        y = nuevoP
    End Sub

End Class


Public Class Points
    Private x1 As Double = 0
    Private x2 As Double = 0
    Public Function getPoint() As Double
        Return x1 And x2
    End Function

    Public Sub setPoint(newP As Double)
        x1 = newP
        x2 = newP
    End Sub

End Class

Public MustInherit Class abstractadapter
    Public MustOverride Function puntos() As Double
    Public MustOverride Sub obtenerPunto(nuevoP As Double)
End Class

Public Class adapter
    Inherits abstractadapter
    Private adaptado As Points

    Public Sub New(f As Points)
        Me.adaptado = f
    End Sub

    Public Overrides Sub obtenerPunto(nuevoP As Double)
        adaptado.setPoint(nuevoP * Math.Cos(nuevoP))
    End Sub

    Public Overrides Function puntos() As Double
        Return Math.Sin(f)
    End Function
End Class