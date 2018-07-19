Public Structure Customer
    'Public members
    Public FirstName As String
    Public LastName As String
    Public Email As String

    'Name Property
    Public ReadOnly Property Name() As String
        Get
            Return FirstName & " " & LastName
        End Get
    End Property

    '''<summary>
    '''Overrides the default ToString method
    '''</summary>
    Public Overrides Function ToString() As String
        Return Name & " (" & Email & ")"
    End Function

End Structure
