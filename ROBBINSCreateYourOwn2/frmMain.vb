Option Strict On
Option Explicit On
' name: Create Your Own 2: War '
' purpose: A little vb game where two users compete to win '
Public Class War
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

    End Sub

    Private Sub txtWarName_TextChanged(sender As Object, e As EventArgs) Handles txtWarName.TextChanged
        lblWarName.Text = txtWarName.Text
    End Sub
End Class
