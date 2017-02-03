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
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdoHuman = New System.Windows.Forms.RadioButton()
        Me.rdoOrc = New System.Windows.Forms.RadioButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtWarName = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkRandomDeaths = New System.Windows.Forms.CheckBox()
        Me.chkChangeRows = New System.Windows.Forms.CheckBox()
        Me.chkChangeSpeed = New System.Windows.Forms.CheckBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblMap = New System.Windows.Forms.Label()
        Me.lblWarName = New System.Windows.Forms.Label()
        Me.lblPlayer1Army = New System.Windows.Forms.Label()
        Me.lblPlayer2Army = New System.Windows.Forms.Label()
        Me.tmrGameTick = New System.Windows.Forms.Timer(Me.components)
        Me.lblPlayer2Health = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPlayer1Health = New System.Windows.Forms.Label()
        Me.labelwhatever = New System.Windows.Forms.Label()
        Me.gbxConfigure = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPlayer2Reload = New System.Windows.Forms.Label()
        Me.lblPlayer1Reload = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.gbxConfigure.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdoHuman)
        Me.GroupBox1.Controls.Add(Me.rdoOrc)
        Me.GroupBox1.Location = New System.Drawing.Point(172, 22)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(157, 103)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Player 1 Army Type"
        '
        'rdoHuman
        '
        Me.rdoHuman.AutoSize = True
        Me.rdoHuman.Location = New System.Drawing.Point(8, 52)
        Me.rdoHuman.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoHuman.Name = "rdoHuman"
        Me.rdoHuman.Size = New System.Drawing.Size(74, 21)
        Me.rdoHuman.TabIndex = 1
        Me.rdoHuman.TabStop = True
        Me.rdoHuman.Text = "&Human"
        Me.rdoHuman.UseVisualStyleBackColor = True
        '
        'rdoOrc
        '
        Me.rdoOrc.AutoSize = True
        Me.rdoOrc.Checked = True
        Me.rdoOrc.Location = New System.Drawing.Point(8, 23)
        Me.rdoOrc.Margin = New System.Windows.Forms.Padding(4)
        Me.rdoOrc.Name = "rdoOrc"
        Me.rdoOrc.Size = New System.Drawing.Size(52, 21)
        Me.rdoOrc.TabIndex = 0
        Me.rdoOrc.TabStop = True
        Me.rdoOrc.Text = "&Orc"
        Me.rdoOrc.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ROBBINSCreateYourOwn2.My.Resources.Resources._192180_Simon_Stålenhag_artwork_night_car_science_fiction
        Me.PictureBox1.Location = New System.Drawing.Point(7, 22)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(157, 103)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(338, 22)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "War Name:"
        '
        'txtWarName
        '
        Me.txtWarName.Location = New System.Drawing.Point(342, 41)
        Me.txtWarName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtWarName.Name = "txtWarName"
        Me.txtWarName.Size = New System.Drawing.Size(132, 22)
        Me.txtWarName.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkRandomDeaths)
        Me.GroupBox2.Controls.Add(Me.chkChangeRows)
        Me.GroupBox2.Controls.Add(Me.chkChangeSpeed)
        Me.GroupBox2.Location = New System.Drawing.Point(483, 22)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(157, 103)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Options"
        '
        'chkRandomDeaths
        '
        Me.chkRandomDeaths.AutoSize = True
        Me.chkRandomDeaths.Location = New System.Drawing.Point(4, 76)
        Me.chkRandomDeaths.Margin = New System.Windows.Forms.Padding(4)
        Me.chkRandomDeaths.Name = "chkRandomDeaths"
        Me.chkRandomDeaths.Size = New System.Drawing.Size(130, 21)
        Me.chkRandomDeaths.TabIndex = 2
        Me.chkRandomDeaths.Text = "Random &deaths"
        Me.chkRandomDeaths.UseVisualStyleBackColor = True
        '
        'chkChangeRows
        '
        Me.chkChangeRows.AutoSize = True
        Me.chkChangeRows.Location = New System.Drawing.Point(4, 48)
        Me.chkChangeRows.Margin = New System.Windows.Forms.Padding(4)
        Me.chkChangeRows.Name = "chkChangeRows"
        Me.chkChangeRows.Size = New System.Drawing.Size(112, 21)
        Me.chkChangeRows.TabIndex = 1
        Me.chkChangeRows.Text = "Change &rows"
        Me.chkChangeRows.UseVisualStyleBackColor = True
        '
        'chkChangeSpeed
        '
        Me.chkChangeSpeed.AutoSize = True
        Me.chkChangeSpeed.Location = New System.Drawing.Point(4, 20)
        Me.chkChangeSpeed.Margin = New System.Windows.Forms.Padding(4)
        Me.chkChangeSpeed.Name = "chkChangeSpeed"
        Me.chkChangeSpeed.Size = New System.Drawing.Size(122, 21)
        Me.chkChangeSpeed.TabIndex = 0
        Me.chkChangeSpeed.Text = "Change s&peed"
        Me.chkChangeSpeed.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(657, 15)
        Me.btnStart.Margin = New System.Windows.Forms.Padding(4)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(100, 28)
        Me.btnStart.TabIndex = 4
        Me.btnStart.Text = "S&tart"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(657, 50)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(100, 28)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblMap
        '
        Me.lblMap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMap.Font = New System.Drawing.Font("Consolas", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMap.Location = New System.Drawing.Point(12, 177)
        Me.lblMap.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMap.Name = "lblMap"
        Me.lblMap.Size = New System.Drawing.Size(1130, 385)
        Me.lblMap.TabIndex = 12
        '
        'lblWarName
        '
        Me.lblWarName.AutoSize = True
        Me.lblWarName.Location = New System.Drawing.Point(476, 161)
        Me.lblWarName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblWarName.Name = "lblWarName"
        Me.lblWarName.Size = New System.Drawing.Size(0, 17)
        Me.lblWarName.TabIndex = 5
        '
        'lblPlayer1Army
        '
        Me.lblPlayer1Army.AutoSize = True
        Me.lblPlayer1Army.Location = New System.Drawing.Point(12, 144)
        Me.lblPlayer1Army.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlayer1Army.Name = "lblPlayer1Army"
        Me.lblPlayer1Army.Size = New System.Drawing.Size(38, 17)
        Me.lblPlayer1Army.TabIndex = 6
        Me.lblPlayer1Army.Text = "Orcs"
        '
        'lblPlayer2Army
        '
        Me.lblPlayer2Army.AutoSize = True
        Me.lblPlayer2Army.Location = New System.Drawing.Point(766, 144)
        Me.lblPlayer2Army.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlayer2Army.Name = "lblPlayer2Army"
        Me.lblPlayer2Army.Size = New System.Drawing.Size(60, 17)
        Me.lblPlayer2Army.TabIndex = 9
        Me.lblPlayer2Army.Text = "Humans"
        '
        'tmrGameTick
        '
        '
        'lblPlayer2Health
        '
        Me.lblPlayer2Health.AutoSize = True
        Me.lblPlayer2Health.Location = New System.Drawing.Point(1071, 161)
        Me.lblPlayer2Health.Name = "lblPlayer2Health"
        Me.lblPlayer2Health.Size = New System.Drawing.Size(0, 17)
        Me.lblPlayer2Health.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(766, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Health:"
        '
        'lblPlayer1Health
        '
        Me.lblPlayer1Health.AutoSize = True
        Me.lblPlayer1Health.Location = New System.Drawing.Point(71, 161)
        Me.lblPlayer1Health.Name = "lblPlayer1Health"
        Me.lblPlayer1Health.Size = New System.Drawing.Size(0, 17)
        Me.lblPlayer1Health.TabIndex = 8
        '
        'labelwhatever
        '
        Me.labelwhatever.AutoSize = True
        Me.labelwhatever.Location = New System.Drawing.Point(12, 161)
        Me.labelwhatever.Name = "labelwhatever"
        Me.labelwhatever.Size = New System.Drawing.Size(53, 17)
        Me.labelwhatever.TabIndex = 7
        Me.labelwhatever.Text = "Health:"
        '
        'gbxConfigure
        '
        Me.gbxConfigure.Controls.Add(Me.PictureBox1)
        Me.gbxConfigure.Controls.Add(Me.GroupBox1)
        Me.gbxConfigure.Controls.Add(Me.Label1)
        Me.gbxConfigure.Controls.Add(Me.txtWarName)
        Me.gbxConfigure.Controls.Add(Me.GroupBox2)
        Me.gbxConfigure.Location = New System.Drawing.Point(12, 12)
        Me.gbxConfigure.Name = "gbxConfigure"
        Me.gbxConfigure.Size = New System.Drawing.Size(638, 129)
        Me.gbxConfigure.TabIndex = 13
        Me.gbxConfigure.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(874, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Reload:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(110, 161)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 17)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Reload:"
        '
        'lblPlayer2Reload
        '
        Me.lblPlayer2Reload.AutoSize = True
        Me.lblPlayer2Reload.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer2Reload.Location = New System.Drawing.Point(937, 146)
        Me.lblPlayer2Reload.Name = "lblPlayer2Reload"
        Me.lblPlayer2Reload.Size = New System.Drawing.Size(0, 29)
        Me.lblPlayer2Reload.TabIndex = 16
        '
        'lblPlayer1Reload
        '
        Me.lblPlayer1Reload.AutoSize = True
        Me.lblPlayer1Reload.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlayer1Reload.Location = New System.Drawing.Point(173, 146)
        Me.lblPlayer1Reload.Name = "lblPlayer1Reload"
        Me.lblPlayer1Reload.Size = New System.Drawing.Size(0, 29)
        Me.lblPlayer1Reload.TabIndex = 17
        '
        'War
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1159, 569)
        Me.Controls.Add(Me.lblPlayer1Reload)
        Me.Controls.Add(Me.lblPlayer2Reload)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.gbxConfigure)
        Me.Controls.Add(Me.labelwhatever)
        Me.Controls.Add(Me.lblPlayer1Health)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblPlayer2Health)
        Me.Controls.Add(Me.lblPlayer2Army)
        Me.Controls.Add(Me.lblPlayer1Army)
        Me.Controls.Add(Me.lblWarName)
        Me.Controls.Add(Me.lblMap)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStart)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "War"
        Me.Text = "War"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbxConfigure.ResumeLayout(False)
        Me.gbxConfigure.PerformLayout()
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
    Friend WithEvents chkRandomDeaths As CheckBox
    Friend WithEvents chkChangeRows As CheckBox
    Friend WithEvents chkChangeSpeed As CheckBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblMap As Label
    Friend WithEvents lblWarName As Label
    Friend WithEvents lblPlayer1Army As Label
    Friend WithEvents lblPlayer2Army As Label
    Friend WithEvents tmrGameTick As Timer
    Friend WithEvents lblPlayer2Health As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblPlayer1Health As Label
    Friend WithEvents labelwhatever As Label
    Friend WithEvents gbxConfigure As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblPlayer2Reload As Label
    Friend WithEvents lblPlayer1Reload As Label
End Class
