<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class War
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoHuman = New System.Windows.Forms.RadioButton()
        Me.rdoOrc = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWarName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkRandomMeteors = New System.Windows.Forms.CheckBox()
        Me.chkDoubleDamage = New System.Windows.Forms.CheckBox()
        Me.chkDoubleMoney = New System.Windows.Forms.CheckBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblWarName = New System.Windows.Forms.Label()
        Me.lblPlayer1Army = New System.Windows.Forms.Label()
        Me.lblPlayer2Army = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoHuman)
        Me.GroupBox1.Controls.Add(Me.rdoOrc)
        Me.GroupBox1.Location = New System.Drawing.Point(136, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(118, 84)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Player 1 Army Type"
        '
        'rdoHuman
        '
        Me.rdoHuman.AutoSize = True
        Me.rdoHuman.Location = New System.Drawing.Point(6, 42)
        Me.rdoHuman.Name = "rdoHuman"
        Me.rdoHuman.Size = New System.Drawing.Size(59, 17)
        Me.rdoHuman.TabIndex = 1
        Me.rdoHuman.TabStop = True
        Me.rdoHuman.Text = "&Human"
        Me.rdoHuman.UseVisualStyleBackColor = True
        '
        'rdoOrc
        '
        Me.rdoOrc.AutoSize = True
        Me.rdoOrc.Checked = True
        Me.rdoOrc.Location = New System.Drawing.Point(6, 19)
        Me.rdoOrc.Name = "rdoOrc"
        Me.rdoOrc.Size = New System.Drawing.Size(42, 17)
        Me.rdoOrc.TabIndex = 0
        Me.rdoOrc.TabStop = True
        Me.rdoOrc.Text = "&Orc"
        Me.rdoOrc.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ROBBINSCreateYourOwn2.My.Resources.Resources._192180_Simon_Stålenhag_artwork_night_car_science_fiction
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(118, 84)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(260, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "War Name:"
        '
        'txtWarName
        '
        Me.txtWarName.Location = New System.Drawing.Point(263, 28)
        Me.txtWarName.Name = "txtWarName"
        Me.txtWarName.Size = New System.Drawing.Size(100, 20)
        Me.txtWarName.TabIndex = 3
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkRandomMeteors)
        Me.GroupBox2.Controls.Add(Me.chkDoubleDamage)
        Me.GroupBox2.Controls.Add(Me.chkDoubleMoney)
        Me.GroupBox2.Location = New System.Drawing.Point(369, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(118, 84)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options"
        '
        'chkRandomMeteors
        '
        Me.chkRandomMeteors.AutoSize = True
        Me.chkRandomMeteors.Location = New System.Drawing.Point(3, 62)
        Me.chkRandomMeteors.Name = "chkRandomMeteors"
        Me.chkRandomMeteors.Size = New System.Drawing.Size(101, 17)
        Me.chkRandomMeteors.TabIndex = 2
        Me.chkRandomMeteors.Text = "Random &deaths"
        Me.chkRandomMeteors.UseVisualStyleBackColor = True
        '
        'chkDoubleDamage
        '
        Me.chkDoubleDamage.AutoSize = True
        Me.chkDoubleDamage.Location = New System.Drawing.Point(3, 39)
        Me.chkDoubleDamage.Name = "chkDoubleDamage"
        Me.chkDoubleDamage.Size = New System.Drawing.Size(88, 17)
        Me.chkDoubleDamage.TabIndex = 1
        Me.chkDoubleDamage.Text = "Change &rows"
        Me.chkDoubleDamage.UseVisualStyleBackColor = True
        '
        'chkDoubleMoney
        '
        Me.chkDoubleMoney.AutoSize = True
        Me.chkDoubleMoney.Location = New System.Drawing.Point(3, 16)
        Me.chkDoubleMoney.Name = "chkDoubleMoney"
        Me.chkDoubleMoney.Size = New System.Drawing.Size(95, 17)
        Me.chkDoubleMoney.TabIndex = 0
        Me.chkDoubleMoney.Text = "Change &speed"
        Me.chkDoubleMoney.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(493, 12)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "&Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(493, 41)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(9, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(848, 313)
        Me.Label2.TabIndex = 7
        '
        'lblWarName
        '
        Me.lblWarName.AutoSize = True
        Me.lblWarName.Location = New System.Drawing.Point(369, 116)
        Me.lblWarName.Name = "lblWarName"
        Me.lblWarName.Size = New System.Drawing.Size(0, 13)
        Me.lblWarName.TabIndex = 8
        '
        'lblPlayer1Army
        '
        Me.lblPlayer1Army.AutoSize = True
        Me.lblPlayer1Army.Location = New System.Drawing.Point(9, 116)
        Me.lblPlayer1Army.Name = "lblPlayer1Army"
        Me.lblPlayer1Army.Size = New System.Drawing.Size(29, 13)
        Me.lblPlayer1Army.TabIndex = 9
        Me.lblPlayer1Army.Text = "Orcs"
        '
        'lblPlayer2Army
        '
        Me.lblPlayer2Army.AutoSize = True
        Me.lblPlayer2Army.Location = New System.Drawing.Point(811, 116)
        Me.lblPlayer2Army.Name = "lblPlayer2Army"
        Me.lblPlayer2Army.Size = New System.Drawing.Size(46, 13)
        Me.lblPlayer2Army.TabIndex = 11
        Me.lblPlayer2Army.Text = "Humans"
        '
        'War
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(869, 462)
        Me.Controls.Add(Me.lblPlayer2Army)
        Me.Controls.Add(Me.lblPlayer1Army)
        Me.Controls.Add(Me.lblWarName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtWarName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "War"
        Me.Text = "War"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdoHuman As RadioButton
    Friend WithEvents rdoOrc As RadioButton
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtWarName As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chkRandomMeteors As CheckBox
    Friend WithEvents chkDoubleDamage As CheckBox
    Friend WithEvents chkDoubleMoney As CheckBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblWarName As Label
    Friend WithEvents lblPlayer1Army As Label
    Friend WithEvents lblPlayer2Army As Label
End Class
