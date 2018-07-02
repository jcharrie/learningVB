Public Class Form1
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'Define a variable for intNumber
        Dim intNumber As Integer
        'Set the initial value
        intNumber = 27
        'Add 1 to the value of intNumber
        intNumber = intNumber + 1
        'Display the new value of intNumber
        MessageBox.Show("Value of intNumber + 1 = " & intNumber.ToString, "Variables")
    End Sub
End Class
