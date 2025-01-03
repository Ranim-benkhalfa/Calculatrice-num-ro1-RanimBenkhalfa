Public Class Form1
    Dim op As Char


    Private Sub Button1_Click(sender As Object, a As EventArgs) Handles Button1.Click
        op = "+"
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        op = "-"
    End Sub


    Private Sub Buttom3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        op = "*"
    End Sub

    Private Sub Buttom4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        op = "/"
    End Sub


    Private Sub Buttom5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim A = Integer.Parse(TextBox1.Text)
        Dim B = Integer.Parse(TextBox2.Text)
        Dim reset = 0
        Dim test = True
        If op = "+" Then
            reset = A + B
        ElseIf op = "-" Then
            reset = A - B
        ElseIf op = "*" Then
            reset = A * B
        ElseIf op = "/" Then
            reset = A / B
        Else
            MessageBox.Show("Veuiller choisir un opérateur")
            test = False
        End If
        If test Then
            Label1.Text = A.ToString + " " + op + " " + B.ToString + " = " + reset.ToString

        End If
    End Sub


End Class
