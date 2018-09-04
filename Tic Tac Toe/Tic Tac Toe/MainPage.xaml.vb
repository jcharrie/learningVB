' The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' An empty page that can be used on its own or navigated to within a Frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page
    Private _CurrentPlayer As String
    Public Property CurrentPlayer() As String
        Get
            Return _CurrentPlayer
        End Get
        Set(ByVal value As String)
            _CurrentPlayer = value
        End Set
    End Property
    Private _isWinnerFound As Boolean
    Public Property isWinnerFound() As Boolean
        Get
            Return _isWinnerFound
        End Get
        Set(ByVal value As Boolean)
            _isWinnerFound = value
        End Set
    End Property
    Public Sub ChangePlayer()
        If CurrentPlayer.ToUpper = "X" Then
            CurrentPlayer = "O"
        Else
            CurrentPlayer = "X"
        End If
    End Sub
    Private Sub GameBoard_Click(sender As Object, e As RoutedEventArgs) Handles TopLeft.Click, TopMiddle.Click, TopRight.Click, CenterLeft.Click, CenterMiddle.Click, CenterRight.Click, BottomLeft.Click, BottomMiddle.Click, BottomRight.Click

        MakePlay(sender)
    End Sub
    Sub MakePlay(ByRef ButtonToPlay As Button)
        ButtonToPlay.Content = CurrentPlayer
        CheckForWinner(TopLeft.Content, TopMiddle.Content, TopRight.Content, CenterLeft.Content, CenterMiddle.Content, CenterRight.Content, BottomLeft.Content, BottomMiddle.Content, BottomRight.Content)
        ButtonToPlay.IsEnabled = False
        If isWinnerFound Then Exit Sub
        If GameIsTie() Then Exit Sub
        ChangePlayer()
        Status.Text = "Play " + CurrentPlayer.ToString

    End Sub
    Sub Winner(strPlayer)
        Status.Text = CurrentPlayer.ToString + " is the winner."
    End Sub
    Sub CheckForWinner(strTopLeft As String, strTopMid As String, strTopRight As String, strCenterLeft As String, strCenterMid As String, strCenterRight As String, strBottomLeft As String, strBottomMid As String, strBottomRight As String)
        If isRowWinner(strTopLeft, strTopMid, strTopRight) Then Exit Sub
        If isRowWinner(strCenterLeft, strCenterMid, strCenterRight) Then Exit Sub
        If isRowWinner(strBottomLeft, strBottomMid, strBottomRight) Then Exit Sub
        If isRowWinner(strTopLeft, strCenterLeft, strBottomLeft) Then Exit Sub
        If isRowWinner(strTopMid, strCenterMid, strBottomMid) Then Exit Sub
        If isRowWinner(strTopRight, strCenterRight, strBottomRight) Then Exit Sub
        If isRowWinner(strTopLeft, strCenterMid, strBottomRight) Then Exit Sub
        If isRowWinner(strTopRight, strCenterMid, strBottomLeft) Then Exit Sub

    End Sub
    Function isRowWinner(Square1 As String, Square2 As String, Square3 As String) As Boolean
        If Square1 <> " " And Square1 = Square2 And Square2 = Square3 Then
            Winner(CurrentPlayer)
            _isWinnerFound = True
            Return True
        End If
        Return False
    End Function
    Sub RandomPlay()
        If isWinnerFound Then Exit Sub
        If GameIsTie() Then Exit Sub

        Dim RandomGenerator As New Random()
        Dim blnIsComputersTurn As Boolean = True
        While blnIsComputersTurn
            Select Case RandomGenerator.Next(1, 10)
                Case 1
                    If TopLeft.IsEnabled Then
                        MakePlay(TopLeft)
                        blnIsComputersTurn = False
                    End If
                Case 2
                    If TopMiddle.IsEnabled Then
                        MakePlay(TopMiddle)
                        blnIsComputersTurn = False
                    End If
                Case 3
                    If TopRight.IsEnabled Then
                        MakePlay(TopRight)
                        blnIsComputersTurn = False
                    End If
                Case 4
                    If CenterLeft.IsEnabled Then
                        MakePlay(CenterLeft)
                        blnIsComputersTurn = False
                    End If
                Case 5
                    If CenterMiddle.IsEnabled Then
                        MakePlay(CenterMiddle)
                        blnIsComputersTurn = False
                    End If
                Case 6
                    If CenterRight.IsEnabled Then
                        MakePlay(CenterRight)
                        blnIsComputersTurn = False
                    End If
                Case 7
                    If BottomLeft.IsEnabled Then
                        MakePlay(BottomLeft)
                        blnIsComputersTurn = False
                    End If
                Case 8
                    If BottomMiddle.IsEnabled Then
                        MakePlay(BottomMiddle)
                        blnIsComputersTurn = False
                    End If
                Case 9
                    If BottomRight.IsEnabled Then
                        MakePlay(BottomRight)
                        blnIsComputersTurn = False
                    End If
            End Select
        End While
    End Sub
    Function GameIsTie() As Boolean
        'if any game board buttons are enabled
        'the games is a tie if no winner was found
        Dim GameButton As Button
        For Each ctrl In MainGrid.Children
            If TypeOf (ctrl) Is Button Then
                GameButton = ctrl
                If GameButton.Name <> "NewGame" And
                        GameButton.Name <> "Random" Then
                    If GameButton.IsEnabled Then
                        Return False
                    End If
                End If
            End If
        Next
        Status.Text = "The game is a tie."
        Return True
    End Function
    Sub Reset()
        Dim GameButton As Button
        For Each ctrl In MainGrid.Children
            If TypeOf (ctrl) Is Button Then
                GameButton = ctrl
                With GameButton
                    If .Name <> "NewGame" And
                            .Name <> "Random" Then .Content = " "
                    .IsEnabled = True
                End With
            End If
        Next
        Status.Text = "Start the game by selecting" & " a square to play."
        CurrentPlayer = "X"
        isWinnerFound = False
    End Sub
    Private Sub MainPage_Loaded(sender As Object, e As RoutedEventArgs) Handles Me.Loaded
        Reset()
    End Sub
    Private Sub NewGame_Click(sender As Object, e As RoutedEventArgs) Handles NewGame.Click
        Reset()
    End Sub
    Private Sub Random_Click(sender As Object, e As RoutedEventArgs) Handles Random.Click
        RandomPlay()
    End Sub

    Private Sub MainPage_SizeChanged(sender As Object, e As SizeChangedEventArgs) Handles Me.SizeChanged

        If Window.Current.Bounds.Width <= 1000 Then
            Grid.SetColumn(TextSP, 0)
            Grid.SetColumn(ButtonSP, 0)
            Grid.SetColumnSpan(TextSP, 3)
            Grid.SetColumnSpan(ButtonSP, 3)
            Grid.SetRow(TextSP, 3)
            Grid.SetRow(ButtonSP, 4)
        Else
            Grid.SetColumn(TextSP, 3)
            Grid.SetColumn(ButtonSP, 3)
            Grid.SetRow(TextSP, 0)
            Grid.SetRow(ButtonSP, 1)
            Grid.SetColumnSpan(TextSP, 1)
            Grid.SetColumnSpan(ButtonSP, 1)
        End If
    End Sub
End Class
