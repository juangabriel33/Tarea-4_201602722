Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim numero, i, factorial As Integer
        factorial = 1
        numero = Val(TextBox1.Text)

        For i = 1 To numero Step 1
            factorial = i * factorial
        Next

        MsgBox("El factorial del numero " & numero & " es: " & factorial, MsgBoxStyle.Information, "RESULTADO")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
