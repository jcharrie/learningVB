Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim words As String
        words = TextBox1.Text.ToString()

        Dim wordHalf As Integer
        wordHalf = words.Length / 2

        MessageBox.Show(words.Length, "Length")
        MessageBox.Show(words.Substring(0, wordHalf), "First half")
        MessageBox.Show(words.Substring(wordHalf), "Last half")
    End Sub
End Class
