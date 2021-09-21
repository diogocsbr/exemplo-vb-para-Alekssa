Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim v1 = TextBox1.Text
        Dim v2 = TextBox2.Text

        TextBox1.Text = v2
        TextBox2.Text = v1

    End Sub
End Class