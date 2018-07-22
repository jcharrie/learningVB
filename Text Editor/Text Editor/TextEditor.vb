﻿Public Class TextEditor

    'Get or set the text on the status bar
    Public Property StatusText() As String
        Get
            Return sslStatus.text
        End Get
        Set(value As String)
            sslStatus.Text = value
        End Set
    End Property

    'Gets or sets the text that you're editing
    Public Property EditText() As String
        Get
            Return txtEdit.Text
        End Get
        Set(value As String)
            txtEdit.Text = value
        End Set
    End Property

    Private Sub txtEdit_TextChanged(sender As Object, e As EventArgs) Handles txtEdit.TextChanged
        'Reset the status bar text
        StatusText = "Ready"
    End Sub

    'Clears the txtEdit control
    Public Sub ClearEditBox()
        'Set the EditText property
        EditText = String.Empty

        'Reset the font color
        txtEdit.ForeColor = Color.Black
        'Set the status bar text
        StatusText = "Text box cleared"
    End Sub

    Private Sub tbrClear_Click(sender As Object, e As EventArgs) Handles tbrClear.Click
        'Clear the edit box
        ClearEditBox()

    End Sub

    Public Sub RedText()
        'Make the text red
        txtEdit.ForeColor = Color.Red

        'Update the status bar text
        StatusText = "The text is red"
    End Sub

    Private Sub tbrRed_Click(sender As Object, e As EventArgs) Handles tbrRed.Click
        'Make the text red
        RedText()

    End Sub

    Public Sub BlueText()
        'Make the text blue
        txtEdit.ForeColor = Color.Blue

        'Update the status bar text
        StatusText = "The text is blue"
    End Sub

    Private Sub tbrBlue_Click(sender As Object, e As EventArgs) Handles tbrBlue.Click

        'Make the text blue
        BlueText()

    End Sub

    Public Sub UpperCaseText()
        'Make the text uppercase
        EditText = EditText.ToUpper

        'Update the status bar text
        StatusText = "The text is all uppercase"
    End Sub

    Private Sub tbrUpperCase_Click(sender As Object, e As EventArgs) Handles tbrUpperCase.Click
        'Make the text uppercase
        UpperCaseText()
    End Sub

    Public Sub LowerCaseText()
        'Make the text lowercase
        EditText = EditText.ToLower

        'Update the status bar text
        StatusText = "The text is all lowercase"
    End Sub

    Private Sub tbrLowerCase_Click(sender As Object, e As EventArgs) Handles tbrLowerCase.Click
        'Make the text lowercase
        LowerCaseText()
    End Sub

    Public Sub ShowAboutBox()
        'Display the About dialog box
        Using objAbout As New About
            objAbout.ShowDialog(Me)
        End Using
    End Sub

    Private Sub tbrHelpAbout_Click(sender As Object, e As EventArgs) Handles tbrHelpAbout.Click
        'Display the About dialog box
        ShowAboutBox()
    End Sub
End Class
