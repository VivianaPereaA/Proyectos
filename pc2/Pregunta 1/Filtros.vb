Imports System.Text.RegularExpressions

Public MustInherit Class AbstractPipe
    Protected filtros As List(Of AbstractFilter)

    Public Sub New()
        filtros = New List(Of AbstractFilter)
    End Sub

    Public MustOverride Function filtrar(input As String) As String

    Public Sub add(f As AbstractFilter)
        filtros.Add(f)
    End Sub

    Public Sub clear()
        filtros.Clear()
    End Sub
End Class

Public Class Tuberia
    Inherits AbstractPipe

    Public Overrides Function filtrar(input As String) As String
        Dim filtrado As String = input
        For Each f As AbstractFilter In filtros
            filtrado = f.filtrar(filtrado)
        Next
        Return filtrado
    End Function
End Class

Public MustInherit Class AbstractFilter
    Public MustOverride Function filtrar(input As String) As String
End Class

Public Class ReducirEspacios
    Inherits AbstractFilter
    Public Overrides Function filtrar(input As String) As String
        Return Regex.Replace(input, "\s+", " ")
    End Function
End Class

Public Class MacroNombre
    Inherits AbstractFilter
    Public Overrides Function filtrar(input As String) As String
        Return Regex.Replace(input, "\s*@vcpacode", "Viviana Cristina Perea Apaza con codigo: 201712613")
    End Function
End Class


Public Class Mayusculas
    Inherits AbstractFilter
    Public Overrides Function filtrar(input As String) As String
        Return input.ToUpper
    End Function
End Class

Public Class Minusculas
    Inherits AbstractFilter
    Public Overrides Function filtrar(input As String) As String
        Return input.ToLower
    End Function
End Class



