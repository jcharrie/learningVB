Public Class ExitMenuItem
    Inherits MenuItem

    'Constructor
    Public Sub New()
        Text = "Exit"
    End Sub

    Private Sub ExitMenuItem_Click(sender As Object, e As EventArgs) Handles Me.Click
        Application.Exit()
    End Sub
End Class
