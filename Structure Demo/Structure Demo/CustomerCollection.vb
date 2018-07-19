Public Class CustomerCollection
    Inherits CollectionBase

    'Private member
    Private objEmailHashtable As New Hashtable

    'EmailHashtable property to return the Email Hashtable
    Public ReadOnly Property EmailHashtable() As Hashtable
        Get
            Return objEmailHashtable
        End Get
    End Property

    'Add a customer to the collection
    Public Sub add(newCustomer As Customer)
        Me.List.Add(newCustomer)
        'Add the email address to the Hashtable
        EmailHashtable.Add(newCustomer.Email.ToLower, newCustomer)

    End Sub

    'Remove a customer from the collection
    Public Sub remove(oldCustomer As Customer)
        Me.List.Remove(oldCustomer)

        'Remove customer from the Hashtable
        EmailHashtable.Remove(oldCustomer.Email.ToLower)
    End Sub

    'Item property to read or update a customer at a given position in the list
    Default Public Property Item(index As Integer) As Customer
        Get
            Return CType(Me.List.Item(index), Customer)
        End Get
        Set(value As Customer)
            Me.List.Item(index) = value
        End Set
    End Property

    'Overload item property to find a customer by email address
    Default Public ReadOnly Property Item(email As String) As Customer
        Get
            Return CType(EmailHashtable.Item(email.ToLower), Customer)
        End Get
    End Property

    'Provide a new implementation of the Clear method
    Public Shadows Sub Clear()
        'Clear the CollectionBase
        MyBase.Clear()
        'Clear your hashtable
        EmailHashtable.Clear()
    End Sub

    'Provide a new implementation of the RemoveAtMethod
    Public Shadows Sub RemoveAt(index As Integer)
        remove(Item(index))
    End Sub

End Class
