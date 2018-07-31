﻿Public Class Generics(Of elementType)
    'This class provides a demonstration of Generics

    'Declare Private variables
    Private strKey() As String
    Private elmValue() As elementType

    Public Sub add(key As String, value As elementType)
        'Check to see if the objects have been initialized
        If strKey IsNot Nothing Then
            'Objects have been initialized
            ReDim Preserve strKey(strKey.GetUpperBound(0) + 1)
            ReDim Preserve elmValue(elmValue.GetUpperBound(0) + 1)
        Else
            'Initialize the objects
            ReDim strKey(0)
            ReDim elmValue(0)
        End If

        'Set the values
        strKey(strKey.GetUpperBound(0)) = key
        elmValue(elmValue.GetUpperBound(0)) = value

    End Sub

    Public ReadOnly Property Key(Index As Integer) As String
        Get
            Return strKey(Index)
        End Get
    End Property

    Public ReadOnly Property Value(Index As Integer) As elementType
        Get
            Return elmValue(Index)
        End Get
    End Property

End Class
