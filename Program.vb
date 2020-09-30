// cerner_2^5_2020
Public Class Form1
     Dim a As Integer
    Dim b As Integer
     Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Sum.Click
        a = TextBox1.Text
        b = TextBox2.Text
        Label2.Text = (a + b)
     End Sub
 
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        a = TextBox1.Text
        b = TextBox2.Text
        Label2.Text = (a - b)
    End Sub
 
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a = TextBox1.Text
        b = TextBox2.Text
        Label2.Text = (a * b)
    End Sub
 
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        a = TextBox1.Text
        b = TextBox2.Text
        Label2.Text = (a / b)
    End Sub
End Class