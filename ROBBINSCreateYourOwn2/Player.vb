Option Strict On
Option Explicit On

Public Class Player
    Private health, position, rock, paper, scissors As Integer
    Public Sub New(ByVal health As Integer, ByVal position As Integer, ByVal rock As Integer, ByVal paper As Integer, ByVal scissors As Integer)
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
    Public Function getRock() As Integer
        Return rock
    End Function
    Public Function getPaper() As Integer
        Return paper
    End Function
    Public Function getScissors() As Integer
        Return scissors
    End Function
End Class
