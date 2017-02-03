Option Strict On
Option Explicit On
' name: Create Your Own 2: War '
' purpose: A little vb game where two users compete to win '
Public Class War
    Dim player1, player2 As Player
    Dim intSpeed As Integer = 150
    Dim intRows As Integer = 3
    Dim intLength As Integer = 100
    Dim bolRandomDeaths As Boolean = False
    Dim map(intRows, intLength) As Integer

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If (rdoHuman.Checked) Then
            lblPlayer1Army.Text = "Humans"
            lblPlayer2Army.Text = "Orcs"
        End If

        gbxConfigure.Dispose()
        Me.KeyPreview = True

        player1 = New Player(10, 0, 5, 1, 2, 3)
        player2 = New Player(10, 0, 5, 4, 5, 6)
        displayPlayer1Health()
        displayPlayer2Health()

        If (chkChangeSpeed.Checked) Then
            intSpeed = getNewSpeed()
        End If
        If (chkChangeRows.Checked) Then
            intRows = getNewRows()
        End If
        bolRandomDeaths = chkRandomDeaths.Checked

        tmrGameTick.Interval = intSpeed
        tmrGameTick.Start()
    End Sub

    Private Sub tmrGameTick_Tick(sender As Object, e As EventArgs) Handles tmrGameTick.Tick
        updatePositions()
        updateReloads()
        displayMap()
    End Sub

    Private Sub updatePositions()
        For y As Integer = 0 To intRows - 1
            For x As Integer = intLength - 1 To 0 Step -1
                Dim intCell As Integer = map(y, x)
                If (intCell = player1.getRock() Or intCell = player1.getPaper() Or intCell = player1.getScissors()) Then
                    map(y, x) = 0
                    If (Not isValid(x + 1)) Then
                        If (player2.takeDamage()) Then
                            declareWinner("Player1")
                        End If
                        displayPlayer2Health()
                    Else
                        Select Case intCell
                            Case player1.getRock()
                                Select Case map(y, x + 1)
                                    Case player2.getRock()
                                        map(y, x + 1) = 0
                                    Case player2.getScissors(), 0
                                        map(y, x + 1) = player1.getRock()
                                End Select
                            Case player1.getPaper()
                                Select Case map(y, x + 1)
                                    Case player2.getPaper()
                                        map(y, x + 1) = 0
                                    Case player2.getRock(), 0
                                        map(y, x + 1) = player1.getPaper()
                                End Select
                            Case player1.getScissors()
                                Select Case map(y, x + 1)
                                    Case player2.getScissors()
                                        map(y, x + 1) = 0
                                    Case player2.getPaper(), 0
                                        map(y, x + 1) = player1.getScissors()
                                End Select
                        End Select
                    End If
                End If
            Next
            For x As Integer = 0 To intLength - 1
                Dim intCell As Integer = map(y, x)
                If (intCell = player2.getRock() Or intCell = player2.getPaper() Or intCell = player2.getScissors()) Then
                    map(y, x) = 0
                    If (Not isValid(x - 1)) Then
                        If (player1.takeDamage()) Then
                            declareWinner("Player2")
                        End If
                        displayPlayer1Health()
                    Else
                        Select Case intCell
                            Case player2.getRock()
                                Select Case map(y, x - 1)
                                    Case player1.getRock()
                                        map(y, x - 1) = 0
                                    Case player1.getScissors(), 0
                                        map(y, x - 1) = player2.getRock()
                                End Select
                            Case player2.getPaper()
                                Select Case map(y, x - 1)
                                    Case player1.getPaper()
                                        map(y, x - 1) = 0
                                    Case player1.getRock(), 0
                                        map(y, x - 1) = player2.getPaper()
                                End Select
                            Case player2.getScissors()
                                Select Case map(y, x - 1)
                                    Case player1.getScissors()
                                        map(y, x - 1) = 0
                                    Case player1.getPaper(), 0
                                        map(y, x - 1) = player2.getScissors()
                                End Select
                        End Select
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub updateReloads()
        player1.updateReload()
        player2.updateReload()

        fillWithStars(lblPlayer1Reload, player1.getTicksTillFire)
        fillWithStars(lblPlayer2Reload, player2.getTicksTillFire)
    End Sub

    Private Sub displayMap()
        lblMap.Text = String.Empty
        For y As Integer = -1 To intRows
            Dim strRow As String = String.Empty
            If (player1.getPosition() = y) Then
                strRow += ">>"
            Else
                strRow += "  "
            End If
            For x As Integer = 0 To intLength - 1
                If (y = -1 Or y = intRows) Then
                    strRow += "-"
                    Continue For
                End If
                Select Case map(y, x)
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
            If (player2.getPosition() = y) Then
                strRow += "<<"
            Else
                strRow += "  "
            End If
            lblMap.Text += strRow + Environment.NewLine
        Next
    End Sub

    Private Sub fillWithStars(ByRef lblLabel As Label, ByVal intStars As Integer)
        lblLabel.Text = String.Empty
        For intCount As Integer = 1 To intStars
            lblLabel.Text += "*"
        Next
    End Sub

    Private Function isValid(ByVal x As Integer) As Boolean
        Return x >= 0 And x < intLength
    End Function

    Private Function getNewSpeed() As Integer
        Dim bolValid As Boolean = False
        Dim intNewSpeed As Integer = intSpeed
        While Not bolValid
            Dim strRaw As String = InputBox("Please enter a new speed (lower = faster) between 50 and 2000", "Change Speed")
            Integer.TryParse(strRaw, intNewSpeed)
            If (intNewSpeed >= 50 And intNewSpeed <= 2000) Then
                bolValid = True
            Else
                MessageBox.Show("Please input valid data", "C'mon son")
            End If
        End While
        Return intNewSpeed
    End Function

    Private Function getNewRows() As Integer
        Dim bolValid As Boolean = False
        Dim intNewRows As Integer = intRows
        While Not bolValid
            Dim strRaw As String = InputBox("Please enter a new amount of rows (1-10)", "Change Rows")
            Integer.TryParse(strRaw, intNewRows)
            If (intNewRows >= 1 And intNewRows <= 10) Then
                bolValid = True
            Else
                MessageBox.Show("Please input valid data", "C'mon son")
            End If
        End While
        Return intNewRows
    End Function

    Private Sub displayPlayer1Health()
        lblPlayer1Health.Text = player1.getHealth().ToString()
    End Sub

    Private Sub displayPlayer2Health()
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
            Case "Q", "E"
                player1.changePosition(1, intRows)
            Case "A"
                If (player1.fire()) Then
                    map(player1.getPosition(), 0) = player1.getRock()
                End If
            Case "S"
                If (player1.fire()) Then
                    map(player1.getPosition(), 0) = player1.getPaper()
                End If
            Case "D"
                If (player1.fire()) Then
                    map(player1.getPosition(), 0) = player1.getScissors()
                End If
            Case "I"
                player2.changePosition(-1, intRows)
            Case "U", "O"
                player2.changePosition(1, intRows)
            Case "J"
                If (player2.fire()) Then
                    map(player2.getPosition(), intLength - 1) = player2.getRock()
                End If
            Case "K"
                If (player2.fire()) Then
                    map(player2.getPosition(), intLength - 1) = player2.getPaper()
                End If
            Case "L"
                If (player2.fire()) Then
                    map(player2.getPosition(), intLength - 1) = player2.getScissors()
                End If
        End Select
    End Sub
End Class
