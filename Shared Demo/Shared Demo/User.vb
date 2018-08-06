﻿Public Class User
    'Public members
    Public Username As String
    Public Shared MinPasswordLength As Integer = 6
    'Private members
    Private strPassword As String

    'Password property
    Public Property Password() As String
        Get
            Return strPassword
        End Get
        Set(value As String)
            If value.Length >= MinPasswordLength Then
                strPassword = value
            End If
        End Set
    End Property

    Public Shared Function CreateUser(userName As String, password As String) As User
        'Declare a new User object
        Dim objUser As New User()

        'Set the User properties
        objUser.Username = userName
        objUser.Password = password

        'Return the new user
        Return objUser
    End Function

End Class
