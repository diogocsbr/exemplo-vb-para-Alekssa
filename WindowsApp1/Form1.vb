Public Class Form1
    Private Sub btnDouble_Click(sender As Object, e As EventArgs) Handles btnDouble.Click

        'criando uma variavel na memória
        Dim a As Double
        Dim mult As Double = 2
        Dim result As Double

        Try
            a = Convert.ToDouble(txtData.Text)
        Catch ex As Exception
            MessageBox.Show("error")
            Return
        End Try

        result = a * mult

        txtResult.Text = result

    End Sub

    Private Sub btnHalf_Click(sender As Object, e As EventArgs) Handles btnHalf.Click
        Dim a As Double
        Dim mult As Double = 2
        Dim result As Double

        Try
            a = Convert.ToDouble(txtData.Text)
        Catch ex As Exception
            MessageBox.Show("error")
            Return
        End Try

        result = a / mult

        txtResult.Text = result
    End Sub


End Class
