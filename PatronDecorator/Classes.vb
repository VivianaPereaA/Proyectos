Public MustInherit Class Museo
    Public MustOverride Function play() As String

End Class

Public Class cuadros
    Inherits Museo

    Public Overrides Function play() As String
        Return "Esto es una presentacion de los cuadros del museo"
    End Function
End Class

Public Class esculturas
    Inherits Museo

    Public Overrides Function play() As String

        Return "Esto es una presentacion de las esculturas del museo".ToString

    End Function
End Class

Public Class testimonios
    Inherits Museo

    Public Overrides Function play() As String

        Return "Esto es una presentacion de los testimonios del museo".ToString

    End Function
End Class
Public MustInherit Class abstractDecorator
    Inherits Museo

    Protected midecorado As Museo

End Class
Public Class leyenda
    Inherits abstractDecorator
    Public Sub New(d As Museo)
        midecorado = d
    End Sub
    Public Overrides Function play() As String

        Return midecorado.play + "Esto fue creado en 1987 por Leonard"
    End Function
End Class

Public Class sonido
    Inherits abstractDecorator
    Public Sub New(d As Museo)
        midecorado = d
    End Sub
    Public Overrides Function play() As String

        Return midecorado.play + "[se reproduce una cancion]"
    End Function
End Class

Public Class video
    Inherits abstractDecorator
    Public Sub New(d As Museo)
        midecorado = d
    End Sub
    Public Overrides Function play() As String

        Return midecorado.play + "[se reproduce un video]"
    End Function
End Class

Public Class consulta
    Inherits abstractDecorator
    Public Sub New(d As Museo)
        midecorado = d
    End Sub
    Public Overrides Function play() As String

        Return midecorado.play + "¿Cual es su duda?"
    End Function
End Class

