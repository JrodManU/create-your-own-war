Option Strict On
Option Explicit On

Public Class Player
    Private intHealth, intPosition, intTicksToReload, intTicksTillFire, intRock, intPaper, intScissors As Integer
    Public Sub New(ByVal intHealth As Integer, ByVal intPosition As Integer, ByVal intTicksToReload As Integer, ByVal intRock As Integer, ByVal intPaper As Integer, ByVal intScissors As Integer)
        Me.intHealth = intHealth
        Me.intPosition = intPosition
        Me.intTicksToReload = intTicksToReload
        Me.intRock = intRock
        Me.intPaper = intPaper
        Me.intScissors = intScissors

        intTicksTillFire = 0
    End Sub

    Public Function takeDamage() As Boolean
        intHealth -= 1
        Return intHealth = 0
    End Function

    ' limit is exclusive '
    Public Sub changePosition(ByVal intChange As Integer, ByVal intLimit As Integer)
        intPosition += intChange
        If (intPosition = intLimit) Then
            intPosition = 0
        ElseIf (intPosition = -1) Then
            intPosition = intLimit - 1
        End If
    End Sub
    Public Sub updateReload()
        If (intTicksTillFire > 0) Then
            intTicksTillFire -= 1
        End If
    End Sub
    Public Function getTicksTillFire() As Integer
        Return intTicksTillFire
    End Function
    Public Function fire() As Boolean
        If (intTicksTillFire = 0) Then
            intTicksTillFire = intTicksToReload
            Return True
        End If
        Return False
    End Function
    Public Function getHealth() As Integer
        Return intHealth
    End Function
    Public Function getPosition() As Integer
        Return intPosition
    End Function
    Public Function getRock() As Integer
        Return intRock
    End Function
    Public Function getPaper() As Integer
        Return intPaper
    End Function
    Public Function getScissors() As Integer
        Return intScissors
    End Function
End Class
