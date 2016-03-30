<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnLoadSpin = New System.Windows.Forms.Button()
        Me.btnFire = New System.Windows.Forms.Button()
        Me.btnAway = New System.Windows.Forms.Button()
        Me.gpbCtrl = New System.Windows.Forms.GroupBox()
        Me.lblReminder1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.lblReminder3 = New System.Windows.Forms.Label()
        Me.btnAgain = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblChances = New System.Windows.Forms.Label()
        Me.lblReminder2 = New System.Windows.Forms.Label()
        Me.pbYou = New System.Windows.Forms.PictureBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblReminder4 = New System.Windows.Forms.Label()
        Me.lblHighScore = New System.Windows.Forms.Label()
        Me.gpbCtrl.SuspendLayout()
        CType(Me.pbYou, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLoadSpin
        '
        Me.btnLoadSpin.Enabled = False
        Me.btnLoadSpin.Location = New System.Drawing.Point(7, 56)
        Me.btnLoadSpin.Name = "btnLoadSpin"
        Me.btnLoadSpin.Size = New System.Drawing.Size(98, 54)
        Me.btnLoadSpin.TabIndex = 1
        Me.btnLoadSpin.Text = "Load the bullet" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and spin the chamber"
        Me.btnLoadSpin.UseVisualStyleBackColor = True
        '
        'btnFire
        '
        Me.btnFire.Enabled = False
        Me.btnFire.Location = New System.Drawing.Point(7, 117)
        Me.btnFire.Name = "btnFire"
        Me.btnFire.Size = New System.Drawing.Size(98, 23)
        Me.btnFire.TabIndex = 2
        Me.btnFire.Text = "Fire!"
        Me.btnFire.UseVisualStyleBackColor = True
        '
        'btnAway
        '
        Me.btnAway.Enabled = False
        Me.btnAway.Location = New System.Drawing.Point(7, 147)
        Me.btnAway.Name = "btnAway"
        Me.btnAway.Size = New System.Drawing.Size(98, 23)
        Me.btnAway.TabIndex = 3
        Me.btnAway.Text = "Shoot away!"
        Me.btnAway.UseVisualStyleBackColor = True
        '
        'gpbCtrl
        '
        Me.gpbCtrl.Controls.Add(Me.lblHighScore)
        Me.gpbCtrl.Controls.Add(Me.lblReminder4)
        Me.gpbCtrl.Controls.Add(Me.btnSave)
        Me.gpbCtrl.Controls.Add(Me.lblReminder1)
        Me.gpbCtrl.Controls.Add(Me.txtName)
        Me.gpbCtrl.Controls.Add(Me.btnNext)
        Me.gpbCtrl.Controls.Add(Me.lblScore)
        Me.gpbCtrl.Controls.Add(Me.lblReminder3)
        Me.gpbCtrl.Controls.Add(Me.btnAgain)
        Me.gpbCtrl.Controls.Add(Me.btnExit)
        Me.gpbCtrl.Controls.Add(Me.lblChances)
        Me.gpbCtrl.Controls.Add(Me.lblReminder2)
        Me.gpbCtrl.Controls.Add(Me.btnAway)
        Me.gpbCtrl.Controls.Add(Me.btnFire)
        Me.gpbCtrl.Controls.Add(Me.btnLoadSpin)
        Me.gpbCtrl.Location = New System.Drawing.Point(478, 0)
        Me.gpbCtrl.Name = "gpbCtrl"
        Me.gpbCtrl.Size = New System.Drawing.Size(114, 402)
        Me.gpbCtrl.TabIndex = 4
        Me.gpbCtrl.TabStop = False
        Me.gpbCtrl.Text = "Controls"
        '
        'lblReminder1
        '
        Me.lblReminder1.AutoSize = True
        Me.lblReminder1.Location = New System.Drawing.Point(4, 15)
        Me.lblReminder1.Name = "lblReminder1"
        Me.lblReminder1.Size = New System.Drawing.Size(108, 13)
        Me.lblReminder1.TabIndex = 12
        Me.lblReminder1.Text = "Enter a 3 letter name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(6, 31)
        Me.txtName.MaxLength = 3
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 11
        Me.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(7, 319)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(96, 23)
        Me.btnNext.TabIndex = 10
        Me.btnNext.Text = "Next Round"
        Me.btnNext.UseVisualStyleBackColor = True
        Me.btnNext.Visible = False
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(15, 223)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(19, 20)
        Me.lblScore.TabIndex = 9
        Me.lblScore.Text = "0"
        '
        'lblReminder3
        '
        Me.lblReminder3.AutoSize = True
        Me.lblReminder3.Location = New System.Drawing.Point(7, 208)
        Me.lblReminder3.Name = "lblReminder3"
        Me.lblReminder3.Size = New System.Drawing.Size(38, 13)
        Me.lblReminder3.TabIndex = 8
        Me.lblReminder3.Text = "Score:"
        '
        'btnAgain
        '
        Me.btnAgain.Location = New System.Drawing.Point(7, 348)
        Me.btnAgain.Name = "btnAgain"
        Me.btnAgain.Size = New System.Drawing.Size(96, 23)
        Me.btnAgain.TabIndex = 7
        Me.btnAgain.Text = "Play Again"
        Me.btnAgain.UseVisualStyleBackColor = True
        Me.btnAgain.Visible = False
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(7, 376)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(96, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Quit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblChances
        '
        Me.lblChances.AutoSize = True
        Me.lblChances.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChances.Location = New System.Drawing.Point(77, 179)
        Me.lblChances.Name = "lblChances"
        Me.lblChances.Size = New System.Drawing.Size(19, 20)
        Me.lblChances.TabIndex = 5
        Me.lblChances.Text = "2"
        Me.lblChances.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblReminder2
        '
        Me.lblReminder2.AutoSize = True
        Me.lblReminder2.Location = New System.Drawing.Point(7, 173)
        Me.lblReminder2.Name = "lblReminder2"
        Me.lblReminder2.Size = New System.Drawing.Size(64, 26)
        Me.lblReminder2.TabIndex = 4
        Me.lblReminder2.Text = "Chances to " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "shoot away:"
        '
        'pbYou
        '
        Me.pbYou.Location = New System.Drawing.Point(1, 0)
        Me.pbYou.Name = "pbYou"
        Me.pbYou.Size = New System.Drawing.Size(475, 402)
        Me.pbYou.TabIndex = 5
        Me.pbYou.TabStop = False
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(7, 291)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(96, 23)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save Score"
        Me.btnSave.UseVisualStyleBackColor = True
        Me.btnSave.Visible = False
        '
        'lblReminder4
        '
        Me.lblReminder4.AutoSize = True
        Me.lblReminder4.Location = New System.Drawing.Point(5, 244)
        Me.lblReminder4.Name = "lblReminder4"
        Me.lblReminder4.Size = New System.Drawing.Size(63, 13)
        Me.lblReminder4.TabIndex = 14
        Me.lblReminder4.Text = "High Score:"
        '
        'lblHighScore
        '
        Me.lblHighScore.AutoSize = True
        Me.lblHighScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHighScore.Location = New System.Drawing.Point(15, 261)
        Me.lblHighScore.Name = "lblHighScore"
        Me.lblHighScore.Size = New System.Drawing.Size(19, 20)
        Me.lblHighScore.TabIndex = 15
        Me.lblHighScore.Text = "0"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 402)
        Me.Controls.Add(Me.pbYou)
        Me.Controls.Add(Me.gpbCtrl)
        Me.Name = "Form1"
        Me.Text = "Russian Roulette"
        Me.gpbCtrl.ResumeLayout(False)
        Me.gpbCtrl.PerformLayout()
        CType(Me.pbYou, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLoadSpin As Button
    Friend WithEvents btnFire As Button
    Friend WithEvents btnAway As Button
    Friend WithEvents gpbCtrl As GroupBox
    Friend WithEvents lblChances As Label
    Friend WithEvents lblReminder2 As Label
    Friend WithEvents pbYou As PictureBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnAgain As Button
    Friend WithEvents lblScore As Label
    Friend WithEvents lblReminder3 As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents lblReminder1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblHighScore As Label
    Friend WithEvents lblReminder4 As Label
    Friend WithEvents btnSave As Button
End Class
