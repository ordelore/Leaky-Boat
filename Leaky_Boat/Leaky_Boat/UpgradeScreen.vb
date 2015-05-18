Public Class frmUpgrade

    Private Sub btnBoat1_Click(sender As Object, e As EventArgs) Handles btnBoat1.Click
        If frmMain.intMoney >= 15 And frmMain.intFillRate = 8 Then
            frmMain.intMoney -= 15
            frmMain.intFillRate -= 2
            frmMain.intFishCapacity += 5
            frmMain.picBoat.Image = My.Resources.PIXILART_LOCAL__1_
        ElseIf frmMain.intMoney < 15 Then
            NoCash()
        Else
            Already()
        End If
    End Sub
    Private Sub Already()
        MsgBox("You already have this! You only have one set of hands!")
    End Sub
    Private Sub NoCash()
        MsgBox("Not Enough Money!")
    End Sub

    Private Sub btnBoat2_Click(sender As Object, e As EventArgs) Handles btnBoat2.Click
        If frmMain.intMoney >= 35 And frmMain.intFillRate = 6 Then
            frmMain.intMoney -= 35
            frmMain.intFillRate -= 2
            frmMain.intFishCapacity += 5
            frmMain.picBoat.Image = My.Resources.PIXILART_LOCAL__2_
        ElseIf frmMain.intMoney < 35 Then
            NoCash()
        Else
            Already()
        End If
    End Sub

    Private Sub btnRod1_Click(sender As Object, e As EventArgs) Handles btnRod1.Click
        If frmMain.intMoney >= 6 And frmMain.intFishDesirability = 15 Then
            frmMain.intMoney -= 6
            frmMain.intFishDesirability -= 5
        ElseIf frmMain.intMoney < 6 Then
            NoCash()
        Else
            Already()
        End If
    End Sub

    Private Sub btnRod2_Click(sender As Object, e As EventArgs) Handles btnRod2.Click
        If frmMain.intMoney >= 40 And frmMain.intFishDesirability = 10 Then
            frmMain.intMoney -= 40
            frmMain.intFishDesirability -= 5
        ElseIf frmMain.intMoney < 40 Then
            NoCash()
        Else
            Already()
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        frmMain.Show()
        frmMain.tmrEndDay.Start()
        frmMain.tmrFill.Start()
        Me.Hide()
    End Sub
End Class