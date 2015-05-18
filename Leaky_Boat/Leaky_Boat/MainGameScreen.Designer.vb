<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmrFill = New System.Windows.Forms.Timer(Me.components)
        Me.tmrEndDay = New System.Windows.Forms.Timer(Me.components)
        Me.lblWaterLevel = New System.Windows.Forms.Label()
        Me.lblFish = New System.Windows.Forms.Label()
        Me.picBucket = New System.Windows.Forms.PictureBox()
        Me.picFishingRod = New System.Windows.Forms.PictureBox()
        Me.picGuy = New System.Windows.Forms.PictureBox()
        Me.picBoat = New System.Windows.Forms.PictureBox()
        CType(Me.picBucket, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFishingRod, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGuy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBoat, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrFill
        '
        Me.tmrFill.Enabled = True
        Me.tmrFill.Interval = 3000
        '
        'tmrEndDay
        '
        Me.tmrEndDay.Enabled = True
        Me.tmrEndDay.Interval = 15000
        '
        'lblWaterLevel
        '
        Me.lblWaterLevel.AutoSize = True
        Me.lblWaterLevel.Location = New System.Drawing.Point(13, 13)
        Me.lblWaterLevel.Name = "lblWaterLevel"
        Me.lblWaterLevel.Size = New System.Drawing.Size(100, 17)
        Me.lblWaterLevel.TabIndex = 4
        Me.lblWaterLevel.Text = "Water Level: 0"
        '
        'lblFish
        '
        Me.lblFish.AutoSize = True
        Me.lblFish.Location = New System.Drawing.Point(157, 13)
        Me.lblFish.Name = "lblFish"
        Me.lblFish.Size = New System.Drawing.Size(50, 17)
        Me.lblFish.TabIndex = 5
        Me.lblFish.Text = "Fish: 0"
        '
        'picBucket
        '
        Me.picBucket.BackColor = System.Drawing.Color.Transparent
        Me.picBucket.Image = Global.Leaky_Boat.My.Resources.Resources.bucket
        Me.picBucket.Location = New System.Drawing.Point(204, 87)
        Me.picBucket.Name = "picBucket"
        Me.picBucket.Size = New System.Drawing.Size(44, 50)
        Me.picBucket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBucket.TabIndex = 3
        Me.picBucket.TabStop = False
        '
        'picFishingRod
        '
        Me.picFishingRod.BackColor = System.Drawing.Color.Transparent
        Me.picFishingRod.Image = Global.Leaky_Boat.My.Resources.Resources.oie_transparent
        Me.picFishingRod.Location = New System.Drawing.Point(0, 56)
        Me.picFishingRod.Name = "picFishingRod"
        Me.picFishingRod.Size = New System.Drawing.Size(88, 82)
        Me.picFishingRod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picFishingRod.TabIndex = 2
        Me.picFishingRod.TabStop = False
        '
        'picGuy
        '
        Me.picGuy.BackColor = System.Drawing.Color.Transparent
        Me.picGuy.Image = Global.Leaky_Boat.My.Resources.Resources.PIXILART_LOCAL__3_
        Me.picGuy.Location = New System.Drawing.Point(80, 56)
        Me.picGuy.Name = "picGuy"
        Me.picGuy.Size = New System.Drawing.Size(86, 81)
        Me.picGuy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGuy.TabIndex = 1
        Me.picGuy.TabStop = False
        '
        'picBoat
        '
        Me.picBoat.BackColor = System.Drawing.Color.Transparent
        Me.picBoat.Image = Global.Leaky_Boat.My.Resources.Resources.PIXILART_LOCAL
        Me.picBoat.Location = New System.Drawing.Point(12, 87)
        Me.picBoat.Name = "picBoat"
        Me.picBoat.Size = New System.Drawing.Size(258, 106)
        Me.picBoat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picBoat.TabIndex = 0
        Me.picBoat.TabStop = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(282, 255)
        Me.Controls.Add(Me.lblFish)
        Me.Controls.Add(Me.lblWaterLevel)
        Me.Controls.Add(Me.picBucket)
        Me.Controls.Add(Me.picFishingRod)
        Me.Controls.Add(Me.picGuy)
        Me.Controls.Add(Me.picBoat)
        Me.Name = "frmMain"
        Me.Text = "Leaky Boat"
        CType(Me.picBucket, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFishingRod, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGuy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBoat, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents picBoat As System.Windows.Forms.PictureBox
    Friend WithEvents picGuy As System.Windows.Forms.PictureBox
    Friend WithEvents picFishingRod As System.Windows.Forms.PictureBox
    Friend WithEvents picBucket As System.Windows.Forms.PictureBox
    Friend WithEvents tmrFill As System.Windows.Forms.Timer
    Friend WithEvents tmrEndDay As System.Windows.Forms.Timer
    Friend WithEvents lblWaterLevel As System.Windows.Forms.Label
    Friend WithEvents lblFish As System.Windows.Forms.Label

End Class
