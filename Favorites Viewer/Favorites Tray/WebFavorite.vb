﻿Imports System.IO

Public Class WebFavorite
    Implements IDisposable

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region

    'Public Members
    Public Name As String
    Public Url As String

    Public Sub Load(fileName As String)
        'Declare variables
        Dim strData As String
        Dim strLines() As String
        Dim strLine As String
        Dim objFileInfo As New FileInfo(fileName)

        'Set the Name member to the file name minus the extension
        Name = objFileInfo.Name.Substring(0, objFileInfo.Name.Length - objFileInfo.Extension.Length)

        Try
            'Read the entire contents of the file
            strData = My.Computer.FileSystem.ReadAllText(fileName)
            'Split the lines of data in the file
            strLines = strData.Split(New String() {ControlChars.CrLf}, StringSplitOptions.RemoveEmptyEntries)

            'Process each line looking for the URL
            For Each strLine In strLines
                'Does the line of data start with URL=
                If strLine.StartsWith("URL=") Then
                    'Yes, set the Url member to the actual URL
                    Url = strLine.Substring(4)
                    'Exit the for...Next loop
                    Exit For
                End If
            Next
        Catch IOExceptionErr As IOException
            'Return the exception to the caller
            Throw New Exception(IOExceptionErr.Message)
        End Try
    End Sub
End Class
