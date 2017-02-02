Option Strict On
Option Explicit On
' name: Create Your Own 2: War '
' purpose: A little vb game where two users compete to win '
Public Class War
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        If (rdoHuman.Checked) Then
            lblPlayer1Army.Text = "Humans"
            lblPlayer2Army.Text = "Orcs"
        End If
        Dim player1 As Player = New Player(10, 0)
        Dim player2 As Player = New Player(10, 0)
    End Sub

    Private Sub txtWarName_TextChanged(sender As Object, e As EventArgs) Handles txtWarName.TextChanged
        lblWarName.Text = txtWarName.Text.Trim()
    End Sub
End Class
