Public Class Form1
    '//Private t As Double//
    Private t As adapter
    Private f As Fahrenheit
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        f = New Fahrenheit
        t = New adapter(f)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        t.establecerTemperatura(TextBox2.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = t.temperatura
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox3.Text = f.temp
    End Sub
End Class
