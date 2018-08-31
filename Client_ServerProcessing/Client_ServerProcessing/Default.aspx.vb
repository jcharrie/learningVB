
Partial Class _Default
    Inherits Page

    Protected Sub btnServer_Click(sender As Object, e As EventArgs) Handles btnServer.Click
        lblServer.Text = "Changed"
    End Sub
    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub
End Class