Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a = TextBox1.Text
        Dim b = TextBox2.Text
        If a = "prizm" And b = "rudra" Then
            MsgBox("Login Successful!")
        Else
            MsgBox("Retry")
        End If
    End Sub
End Class
