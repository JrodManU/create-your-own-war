Option Strict On
Option Explicit On
' name: Create Your Own 2: War '
' purpose: A little vb game where two users compete to win a game of rock paper scissors '
' programmer: Jared Robbins '
' date: 2/6/2017 '
Public Class War
    ' declaring some global variables '
    Dim player1, player2 As Player
    Dim intSpeed As Integer = 50
    Dim intRows As Integer = 3
    Dim intLength As Integer = 100
    Dim intHealth As Integer = 3
    Dim intTicksToReload As Integer = 15
    Dim map(intRows, intLength) As Integer

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' close when exit is clicked '
        Me.Close()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ' checks all the inputs and takes appropriate actions '
        ' also initiates the game '
        If (rdoHuman.Checked) Then
            lblPlayer1Army.Text = "Humans"
            lblPlayer2Army.Text = "Orcs"
        End If
        If (chkChangeSpeed.Checked) Then
            intSpeed = getNumber("Please enter a number 10-1000 for the speed (lower=faster)", "Change Speed", 10, 1000, intSpeed)
        End If
        If (chkChangeRows.Checked) Then
            intRows = getNumber("Please enter a number 1-10 for the number of rows", "Change Rows", 1, 10, intRows)
        End If
        If (chkChangeTicksToReload.Checked) Then
            intSpeed = getNumber("Please enter a number 1-50 for the number of ticks to reload (lower=faster)", "Change Ticks to Reload", 1, 50, intTicksToReload)
        End If
        If (chkChangeHealth.Checked) Then
            intHealth = getNumber("Please enter a number 1-100 for the health of each player", "Change Health", 1, 100, intHealth)
        End If

        ' makes it so other controls don't interfere with the keypress events '
        gbxConfigure.Dispose()
        Me.KeyPreview = True

        ' creates new players '
        player1 = New Player(intHealth, 0, intTicksToReload, 1, 2, 3)
        player2 = New Player(intHealth, 0, intTicksToReload, 4, 5, 6)
        displayPlayer1Health()
        displayPlayer2Health()

        ' 2d array that stores all positions of rocks and stuff '
        ReDim map(intRows, intLength)

        ' starts game loop '
        tmrGameTick.Interval = intSpeed
        tmrGameTick.Start()
    End Sub

    Private Sub tmrGameTick_Tick(sender As Object, e As EventArgs) Handles tmrGameTick.Tick
        ' game loop '
        updatePositions()
        updateReloads()
        displayMap()
    End Sub

    Private Sub updatePositions()
        ' moves items left or right, makes players take damage if they reach the end '
        ' due to the different directions the two for loops go different directions for each player '
        ' so that the piece infront of it does not prevent it from moving '
        ' the ones infront will be moved first '
        For intY As Integer = 0 To intRows - 1
            ' move player1's pieces '
            For intX As Integer = intLength - 1 To 0 Step -1
                Dim intCell As Integer = map(intY, intX)
                If (intCell = player1.getRock() Or intCell = player1.getPaper() Or intCell = player1.getScissors()) Then
                    map(intY, intX) = 0
                    ' if it is not valid then that means it made it to the other side
                    If (Not isValid(intX + 1)) Then
                        If (player2.takeDamage()) Then
                            declareWinner("Player1")
                        End If
                        displayPlayer2Health()
                    Else
                        Select Case intCell
                            Case player1.getRock()
                                Select Case map(intY, intX + 1)
                                    Case player2.getRock()
                                        map(intY, intX + 1) = 0
                                    Case player2.getScissors(), 0
                                        map(intY, intX + 1) = player1.getRock()
                                End Select
                            Case player1.getPaper()
                                Select Case map(intY, intX + 1)
                                    Case player2.getPaper()
                                        map(intY, intX + 1) = 0
                                    Case player2.getRock(), 0
                                        map(intY, intX + 1) = player1.getPaper()
                                End Select
                            Case player1.getScissors()
                                Select Case map(intY, intX + 1)
                                    Case player2.getScissors()
                                        map(intY, intX + 1) = 0
                                    Case player2.getPaper(), 0
                                        map(intY, intX + 1) = player1.getScissors()
                                End Select
                        End Select
                    End If
                End If
            Next
            ' move player2's pieces '
            For intX As Integer = 0 To intLength - 1
                Dim intCell As Integer = map(intY, intX)
                If (intCell = player2.getRock() Or intCell = player2.getPaper() Or intCell = player2.getScissors()) Then
                    map(intY, intX) = 0
                    If (Not isValid(intX - 1)) Then
                        If (player1.takeDamage()) Then
                            declareWinner("Player2")
                        End If
                        displayPlayer1Health()
                    Else
                        Select Case intCell
                            Case player2.getRock()
                                Select Case map(intY, intX - 1)
                                    Case player1.getRock()
                                        map(intY, intX - 1) = 0
                                    Case player1.getScissors(), 0
                                        map(intY, intX - 1) = player2.getRock()
                                End Select
                            Case player2.getPaper()
                                Select Case map(intY, intX - 1)
                                    Case player1.getPaper()
                                        map(intY, intX - 1) = 0
                                    Case player1.getRock(), 0
                                        map(intY, intX - 1) = player2.getPaper()
                                End Select
                            Case player2.getScissors()
                                Select Case map(intY, intX - 1)
                                    Case player1.getScissors()
                                        map(intY, intX - 1) = 0
                                    Case player1.getPaper(), 0
                                        map(intY, intX - 1) = player2.getScissors()
                                End Select
                        End Select
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub updateReloads()
        ' displays the stars that shows reload time '
        player1.updateReload()
        player2.updateReload()

        fillWithStars(lblPlayer1Reload, player1.getTicksTillFire)
        fillWithStars(lblPlayer2Reload, player2.getTicksTillFire)
    End Sub

    Private Sub displayMap()
        ' displays all pieces and stuff '
        ' clear the display first '
        lblMap.Text = String.Empty
        For intY As Integer = -1 To intRows
            Dim strRow As String = String.Empty
            ' the players point, helps them know where they are placing pieces '
            If (player1.getPosition() = intY) Then
                strRow += ">>"
            Else
                strRow += "  "
            End If
            For intX As Integer = 0 To intLength - 1
                If (intY = -1 Or intY = intRows) Then
                    strRow += "-"
                    Continue For
                End If
                Select Case map(intY, intX)
                    Case player1.getRock(), player2.getRock()
                        strRow += "R"
                    Case player1.getPaper(), player2.getPaper()
                        strRow += "P"
                    Case player1.getScissors(), player2.getScissors()
                        strRow += "S"
                    Case Else
                        strRow += " "
                End Select
            Next
            If (player2.getPosition() = intY) Then
                strRow += "<<"
            Else
                strRow += "  "
            End If
            lblMap.Text += strRow + Environment.NewLine
        Next
    End Sub

    Private Sub fillWithStars(ByRef lblLabel As Label, ByVal intStars As Integer)
        ' makes a string of stars to display reload time '
        Dim intCounter As Integer = 1
        lblLabel.Text = String.Empty
        While intCounter <= intStars
            lblLabel.Text += "*"
            intCounter += 1
        End While
    End Sub

    Private Function isValid(ByVal intX As Integer) As Boolean
        ' checks if the position is inside the 2d array '
        Return intX >= 0 And intX < intLength
    End Function

    Private Function getNumber(ByVal strPrompt As String, ByVal strTitle As String, ByVal intLowerLimit As Integer, ByVal intUpperLimit As Integer, ByVal intDefault As Integer) As Integer
        ' prompts the user for data and returns the value, used by multiple things '
        Dim bolValid As Boolean = False
        Dim intNum As Integer = intDefault
        While Not bolValid
            Dim strRaw As String = InputBox(strPrompt, strTitle)
            Integer.TryParse(strRaw, intNum)
            If (intNum >= intLowerLimit And intNum <= intUpperLimit) Then
                bolValid = True
            ElseIf (intNum < intLowerLimit And intNum > intUpperLimit) Then
                MessageBox.Show("Please input valid data", "C'mon son")
            End If
        End While
        Return intNum
    End Function

    Private Sub displayPlayer1Health()
        ' displays player1 health '
        lblPlayer1Health.Text = player1.getHealth().ToString()
    End Sub

    Private Sub displayPlayer2Health()
        ' displays player 2 health '
        lblPlayer2Health.Text = player2.getHealth().ToString()
    End Sub

    Private Sub declareWinner(ByRef strWinner As String)
        tmrGameTick.Stop()
        MessageBox.Show("Congratulations " + strWinner + "! You are the rock paper scissors champion!", "WINNER")
    End Sub

    Private Sub txtWarName_TextChanged(sender As Object, e As EventArgs) Handles txtWarName.TextChanged
        lblWarName.Text = txtWarName.Text.Trim()
    End Sub

    Private Sub War_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        Select Case e.KeyChar.ToString().ToUpper()
            Case "W"
                player1.changePosition(-1, intRows)
            Case "S"
                player1.changePosition(1, intRows)
            Case "A"
                If (player1.fire()) Then
                    map(player1.getPosition(), 0) = player1.getRock()
                End If
            Case "D"
                If (player1.fire()) Then
                    map(player1.getPosition(), 0) = player1.getPaper()
                End If
            Case "Q", "E"
                If (player1.fire()) Then
                    map(player1.getPosition(), 0) = player1.getScissors()
                End If
            Case "I"
                player2.changePosition(-1, intRows)
            Case "K"
                player2.changePosition(1, intRows)
            Case "J"
                If (player2.fire()) Then
                    map(player2.getPosition(), intLength - 1) = player2.getRock()
                End If
            Case "L"
                If (player2.fire()) Then
                    map(player2.getPosition(), intLength - 1) = player2.getPaper()
                End If
            Case "U", "O"
                If (player2.fire()) Then
                    map(player2.getPosition(), intLength - 1) = player2.getScissors()
                End If
        End Select
    End Sub
End Class
