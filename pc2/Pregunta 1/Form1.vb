Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim f = New MacroNombre
        TextBox2.Text = f.filtrar(TextBox1.Text)
    End Sub
End Class