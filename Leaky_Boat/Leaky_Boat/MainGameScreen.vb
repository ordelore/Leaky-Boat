Public Class frmMain
    Private intPailEfficency As Integer
    Public intFillRate As Integer
    Public intFishDesirability As Integer
    Public intMoney As Integer
    Private intDay As Integer
    Public intFishCapacity As Integer
    Private intHunger As Integer
    Private intWater As Integer
    Private blnFish As Boolean
    Private intFish As Integer
    Private strWater As String = "Water Level: "
    Private strFish As String = "Fish: "
    Private rndRand As New Random

    Private Sub frmMain_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Left And picGuy.Left > picFishingRod.Left + picFishingRod.Width Then
            'move character left
            picGuy.Left -= 2
        ElseIf e.KeyCode = Keys.Right And picGuy.Left + picGuy.Width < picBucket.Left Then
            'right
            picGuy.Left += 2
        ElseIf e.KeyCode = Keys.Enter And picGuy.Left + picGuy.Width = picBucket.Left Then
            'empty water
            Bucket()
        ElseIf e.KeyCode = Keys.Enter And picGuy.Left = picFishingRod.Left + picFishingRod.Width Then
            fish()
        End If
    End Sub
    Private Sub Bucket()
        If intWater > 0 Then
            intWater -= intPailEfficency
            If intWater < 0 Then
                intWater = 0
            End If
            UpdateBar(lblWaterLevel, intWater, strWater)
        End If
    End Sub
    Private Sub fish()
        If blnFish = True And intFish < intFishCapacity Then
            blnFish = False
            intFish += 1
            UpdateBar(lblFish, intFish, strFish)
            picFishingRod.BackColor = Color.Transparent
        Else
            Dim intRandom As Integer = rndRand.Next(0, intFishDesirability + 1)
            If intRandom = 3 Then
                blnFish = True
                picFishingRod.BackColor = Color.LightYellow
            End If
        End If
    End Sub
    Private Sub MainGameScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        intDay = 0
        intMoney = 0
        intHunger = 1
        intFillRate = 5
        intPailEfficency = 3
        intFishDesirability = 3
        intFishCapacity = 3
        intWater = 2
        blnFish = False
        tmrEndDay.Stop()
        tmrFill.Stop()
        MsgBox("To move your character, press the arrow keys." & vbNewLine & "To empty your bucket, press Enter while standing next to it." & vbNewLine & "To cast your fishing rod, press Enter while standing next to it. If it catches a fish, it will change color. Press Enter again to get the fish." & vbNewLine & "If the boat's water level reaches 20, it's game over!" & vbNewLine & "Also, there is a limit to how much fish your boat can carry, so upgrade to have more fish capacity!" & vbNewLine & "The fishing pole is the one on the left and the bucket is on the right.")
        tmrFill.Start()
        tmrEndDay.Start()
    End Sub

    Private Sub tmrFill_Tick(sender As Object, e As EventArgs) Handles tmrFill.Tick
        intWater += intFillRate
        UpdateBar(lblWaterLevel, intWater, strWater)
        If intWater > 20 Then
            MsgBox("Game Over! You Let too much water fill up the boat!")
            Me.Close()
        End If
    End Sub
    Private Sub UpdateBar(lblBox As Label, intValue As Integer, strOpening As String)
        lblBox.Text = strOpening & intValue.ToString()
    End Sub

    Private Sub tmrEndDay_Tick(sender As Object, e As EventArgs) Handles tmrEndDay.Tick
        tmrEndDay.Stop()
        tmrFill.Stop()
        Me.Hide()
        intMoney = intMoney + intFish * 3
        lblFish.Text = strFish & "0"
        intWater = 0
        lblWaterLevel.Text = strWater & "0"
        intFish = 0
        MsgBox("Money: " & intMoney)
        frmUpgrade.Show()
    End Sub
End Class
