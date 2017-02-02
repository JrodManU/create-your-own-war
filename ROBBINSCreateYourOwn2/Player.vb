Option Strict On
Option Explicit On

Public Class Player
    Private health As Integer
    Private position As Integer
    Public Sub New(ByVal health As Integer, ByVal position As Integer)
        Me.health = health
        Me.position = position
    End Sub

    Public Function takeDamage() As Boolean
        health -= 1
        Return health = 0
    End Function

    ' limit is exclusive '
    Public Sub changePosition(ByVal change As Integer, ByVal limit As Integer)
        position += change
        If (position = limit) Then
            position = 0
        ElseIf (position = -1) Then
            position = limit - 1
        End If
    End Sub

    Public Function getPosition() As Integer
        Return position
    End Function
End Class
