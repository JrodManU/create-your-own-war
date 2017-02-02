Option Strict On
Option Explicit On
' name: Create Your Own 2: War '
' purpose: A little vb game where two users compete to win '
Public Class War
    Dim player1, player2 As Player
    Dim intSpeed As Integer = 300
    Dim intRows As Integer = 3
    Dim intLength As Integer = 20
    Dim bolRandomDeaths As Boolean = False

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If (rdoHuman.Checked) Then
            lblPlayer1Army.Text = "Humans"
            lblPlayer2Army.Text = "Orcs"
        End If
        player1 = New Player(10, 0, 1, 2, 3)
        player2 = New Player(10, 0, 4, 5, 6)

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
        Dim map(intRows, intLength) As Integer

        For y As Integer = 0 To intRows - 1
            For x As Integer = intLength - 1 To 0
                Select Case map(y, x)
                    Case player1.getRock()
                        If (isValid(x - 1)) Then
                            Select Case map(y, x - 1)
                                Case player2.getRock()
                                    map(y, x - 1) = 0
                                    map(y, x) = 0
                                Case player2.getScissors()
                                    map(y, x - 1) = player1.getRock()
                                    map(y, x) = 0
                                Case 0
                            End Select
                        End If
                    Case player1.getPaper()
                    Case player1.getScissors()
                End Select
            Next
            For x As Integer = 0 To intLength - 1
                Select Case map(y, x)
                    Case player2.getRock()
                    Case player2.getPaper()
                    Case player2.getScissors()
                End Select
            Next
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

    Private Sub txtWarName_TextChanged(sender As Object, e As EventArgs) Handles txtWarName.TextChanged
        lblWarName.Text = txtWarName.Text.Trim()
    End Sub
End Class
