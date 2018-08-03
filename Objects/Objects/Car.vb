Namespace CarPerformance

    Public Class Car
        Implements IDisposable
        Public Color As String
        Public HorsePower As Integer
        Private intSpeed As Integer
        Private intNumberOfDoors As Integer


        'Speed-read-only property to return the speed
        Public ReadOnly Property Speed() As Integer
            Get
                Return intSpeed
            End Get
        End Property

        'Accelerate-add mph to the speed
        Public Sub Accelerate(accelerateBy As Integer)
            'Adjust the speed
            intSpeed += accelerateBy
        End Sub

        'NumberOfDoors-get/set the number of doors
        Public Property NumberOfDoors() As Integer
            'Called when the property is read
            Get
                Return intNumberOfDoors
            End Get
            'Called when the property is set
            Set(value As Integer)
                'Is the new value between two and five
                If value >= 2 And value <= 5 Then
                    intNumberOfDoors = value
                End If
            End Set
        End Property

        'IsMoving-is the car moving?
        Public Function IsMoving() As Boolean
            'Is the car's speed zero?
            If Speed = 0 Then
                Return False
            Else
                Return True
            End If
        End Function

        'Constructor
        Public Sub New()
            'Set the default values
            Color = "White"
            intSpeed = 0
            intNumberOfDoors = 5
        End Sub

        'CalculateAccelerationRate-assume a constant for a normal car
        Public Overridable Function CalculateAccelerationRate() As Double
            'If we assume a normal car goes from 0-60 in 14 seconds, that's an average rate of 4.2 mph/s
            Return 4.2
        End Function

        Private disposedValue As Boolean = False 'To detect redundant calls

        'IDisposable
        Protected Overridable Sub Dispose(disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    'TODO: free other state(managed objects)
                End If
                'TODO: free your own state(unmanaged objects)
                'TODO: set large fields to null
            End If
            Me.disposedValue = True
        End Sub

#Region " IDisposable Support"
        'This code added by Visual Basic to correctly implement disposable pattern
        Public Sub Dispose() Implements IDisposable.Dispose
            'Do not change this code. Put cleanup code in Dispose(ByVal disposaing As Boolean above.
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub
#End Region

    End Class

End Namespace
