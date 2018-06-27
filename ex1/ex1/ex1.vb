Public Class ex1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        MessageBox.Show(
            txtBox.Text & "!"
        )
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
