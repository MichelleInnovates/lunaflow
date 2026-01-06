<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        dtpStart = New DateTimePicker()
        btnGo = New Button()
        Label1 = New Label()
        lblAnswer = New Label()
        Label2 = New Label()
        Label3 = New Label()
        grpCycle = New GroupBox()
        Label8 = New Label()
        Label7 = New Label()
        rbMedium = New RadioButton()
        rbHeavy = New RadioButton()
        rbLight = New RadioButton()
        lblCycleValue = New Label()
        tbCycle = New TrackBar()
        Label4 = New Label()
        Label5 = New Label()
        chkAcne = New CheckBox()
        chkCramps = New CheckBox()
        chkMood = New CheckBox()
        lblResult = New Label()
        pbMeme = New PictureBox()
        Label6 = New Label()
        lnkHistory = New LinkLabel()
        lnkClear = New LinkLabel()
        grpCycle.SuspendLayout()
        CType(tbCycle, ComponentModel.ISupportInitialize).BeginInit()
        CType(pbMeme, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtpStart
        ' 
        dtpStart.Font = New Font("Segoe UI Symbol", 9.25F)
        dtpStart.Location = New Point(6, 46)
        dtpStart.Name = "dtpStart"
        dtpStart.Size = New Size(200, 24)
        dtpStart.TabIndex = 1
        ' 
        ' btnGo
        ' 
        btnGo.BackColor = Color.FromArgb(CByte(156), CByte(89), CByte(182))
        btnGo.FlatAppearance.BorderSize = 0
        btnGo.FlatStyle = FlatStyle.Flat
        btnGo.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        btnGo.ForeColor = SystemColors.Control
        btnGo.Location = New Point(27, 378)
        btnGo.Name = "btnGo"
        btnGo.Size = New Size(255, 35)
        btnGo.TabIndex = 3
        btnGo.Text = "Predict My Future!"
        btnGo.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(310, 183)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 15)
        Label1.TabIndex = 4
        ' 
        ' lblAnswer
        ' 
        lblAnswer.AutoSize = True
        lblAnswer.Location = New Point(316, 170)
        lblAnswer.Name = "lblAnswer"
        lblAnswer.Size = New Size(0, 15)
        lblAnswer.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Microsoft Sans Serif", 14.0F, FontStyle.Bold)
        Label2.ForeColor = Color.FromArgb(CByte(156), CByte(89), CByte(182))
        Label2.ImageAlign = ContentAlignment.TopLeft
        Label2.Location = New Point(28, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(101, 24)
        Label2.TabIndex = 9
        Label2.Text = "LunaFlow"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 11.0F, FontStyle.Italic)
        Label3.Location = New Point(28, 45)
        Label3.Name = "Label3"
        Label3.Size = New Size(226, 17)
        Label3.TabIndex = 10
        Label3.Text = "Track your cycle, plan your future"
        ' 
        ' grpCycle
        ' 
        grpCycle.Controls.Add(Label8)
        grpCycle.Controls.Add(Label7)
        grpCycle.Controls.Add(rbMedium)
        grpCycle.Controls.Add(rbHeavy)
        grpCycle.Controls.Add(rbLight)
        grpCycle.Controls.Add(lblCycleValue)
        grpCycle.Controls.Add(tbCycle)
        grpCycle.Controls.Add(Label4)
        grpCycle.Controls.Add(Label5)
        grpCycle.Controls.Add(dtpStart)
        grpCycle.Controls.Add(chkAcne)
        grpCycle.Controls.Add(chkCramps)
        grpCycle.Controls.Add(chkMood)
        grpCycle.Font = New Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpCycle.ForeColor = SystemColors.Control
        grpCycle.Location = New Point(27, 76)
        grpCycle.Name = "grpCycle"
        grpCycle.Size = New Size(255, 280)
        grpCycle.TabIndex = 13
        grpCycle.TabStop = False
        grpCycle.Text = "1. CYCLE DATA"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(14, 151)
        Label8.Name = "Label8"
        Label8.Size = New Size(77, 17)
        Label8.TabIndex = 20
        Label8.Text = "Daily Log:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Cambria", 9.25F, FontStyle.Bold)
        Label7.ForeColor = Color.Silver
        Label7.Location = New Point(25, 107)
        Label7.Name = "Label7"
        Label7.Size = New Size(93, 15)
        Label7.TabIndex = 20
        Label7.Text = "(Cycle Length)"
        ' 
        ' rbMedium
        ' 
        rbMedium.Appearance = Appearance.Button
        rbMedium.BackColor = Color.Salmon
        rbMedium.FlatStyle = FlatStyle.Flat
        rbMedium.Location = New Point(140, 210)
        rbMedium.Name = "rbMedium"
        rbMedium.Size = New Size(102, 24)
        rbMedium.TabIndex = 22
        rbMedium.TabStop = True
        rbMedium.Text = "Medium"
        rbMedium.TextAlign = ContentAlignment.TopCenter
        rbMedium.UseVisualStyleBackColor = False
        ' 
        ' rbHeavy
        ' 
        rbHeavy.Appearance = Appearance.Button
        rbHeavy.BackColor = Color.Crimson
        rbHeavy.FlatStyle = FlatStyle.Flat
        rbHeavy.Font = New Font("Cambria", 9.25F, FontStyle.Bold)
        rbHeavy.Location = New Point(140, 240)
        rbHeavy.Name = "rbHeavy"
        rbHeavy.Size = New Size(102, 28)
        rbHeavy.TabIndex = 20
        rbHeavy.TabStop = True
        rbHeavy.Text = "Heavy"
        rbHeavy.TextAlign = ContentAlignment.MiddleCenter
        rbHeavy.UseVisualStyleBackColor = False
        ' 
        ' rbLight
        ' 
        rbLight.Appearance = Appearance.Button
        rbLight.BackColor = Color.LightPink
        rbLight.FlatStyle = FlatStyle.Flat
        rbLight.Font = New Font("Cambria", 9.25F, FontStyle.Bold)
        rbLight.Location = New Point(140, 180)
        rbLight.Name = "rbLight"
        rbLight.Size = New Size(102, 24)
        rbLight.TabIndex = 20
        rbLight.TabStop = True
        rbLight.Text = "Light"
        rbLight.TextAlign = ContentAlignment.MiddleCenter
        rbLight.UseVisualStyleBackColor = False
        ' 
        ' lblCycleValue
        ' 
        lblCycleValue.AutoSize = True
        lblCycleValue.Location = New Point(166, 83)
        lblCycleValue.Name = "lblCycleValue"
        lblCycleValue.Size = New Size(61, 17)
        lblCycleValue.TabIndex = 19
        lblCycleValue.Text = "28 days"
        ' 
        ' tbCycle
        ' 
        tbCycle.AutoSize = False
        tbCycle.Location = New Point(14, 83)
        tbCycle.Maximum = 45
        tbCycle.Minimum = 21
        tbCycle.Name = "tbCycle"
        tbCycle.Size = New Size(129, 26)
        tbCycle.TabIndex = 15
        tbCycle.TickStyle = TickStyle.None
        tbCycle.Value = 28
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 11.0F)
        Label4.Location = New Point(14, 21)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 20)
        Label4.TabIndex = 14
        Label4.Text = "Date picker:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(156, 151)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 17)
        Label5.TabIndex = 3
        Label5.Text = "Flow Level:"
        ' 
        ' chkAcne
        ' 
        chkAcne.AutoSize = True
        chkAcne.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkAcne.Location = New Point(14, 245)
        chkAcne.Name = "chkAcne"
        chkAcne.Size = New Size(53, 19)
        chkAcne.TabIndex = 2
        chkAcne.Text = "Acne"
        chkAcne.UseVisualStyleBackColor = True
        ' 
        ' chkCramps
        ' 
        chkCramps.AutoSize = True
        chkCramps.Font = New Font("Segoe UI", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkCramps.Location = New Point(14, 185)
        chkCramps.Name = "chkCramps"
        chkCramps.Size = New Size(67, 19)
        chkCramps.TabIndex = 0
        chkCramps.Text = "Cramps"
        chkCramps.UseVisualStyleBackColor = True
        ' 
        ' chkMood
        ' 
        chkMood.AutoSize = True
        chkMood.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkMood.Location = New Point(14, 213)
        chkMood.Name = "chkMood"
        chkMood.Size = New Size(107, 21)
        chkMood.TabIndex = 1
        chkMood.Text = "Mood Swings"
        chkMood.UseVisualStyleBackColor = True
        ' 
        ' lblResult
        ' 
        lblResult.Font = New Font("Segoe UI", 11.25F)
        lblResult.ForeColor = SystemColors.Control
        lblResult.Location = New Point(336, 85)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(232, 294)
        lblResult.TabIndex = 18
        lblResult.Text = "Press 'Predict' to see your cycle forecast..."
        lblResult.TextAlign = ContentAlignment.TopCenter
        ' 
        ' pbMeme
        ' 
        pbMeme.BackColor = Color.Transparent
        pbMeme.Location = New Point(619, 85)
        pbMeme.Name = "pbMeme"
        pbMeme.Size = New Size(253, 271)
        pbMeme.SizeMode = PictureBoxSizeMode.Zoom
        pbMeme.TabIndex = 15
        pbMeme.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(629, 76)
        Label6.Name = "Label6"
        Label6.Size = New Size(113, 17)
        Label6.TabIndex = 16
        Label6.Text = "CURRENT VIBE"
        ' 
        ' lnkHistory
        ' 
        lnkHistory.AutoSize = True
        lnkHistory.LinkBehavior = LinkBehavior.HoverUnderline
        lnkHistory.LinkColor = Color.FromArgb(CByte(100), CByte(100), CByte(255))
        lnkHistory.Location = New Point(21, 442)
        lnkHistory.Name = "lnkHistory"
        lnkHistory.Size = New Size(73, 15)
        lnkHistory.TabIndex = 18
        lnkHistory.TabStop = True
        lnkHistory.Text = "View History"
        ' 
        ' lnkClear
        ' 
        lnkClear.AutoSize = True
        lnkClear.LinkBehavior = LinkBehavior.HoverUnderline
        lnkClear.LinkColor = Color.Salmon
        lnkClear.Location = New Point(811, 442)
        lnkClear.Name = "lnkClear"
        lnkClear.Size = New Size(61, 15)
        lnkClear.TabIndex = 19
        lnkClear.TabStop = True
        lnkClear.Text = "Clear Data"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        ClientSize = New Size(884, 481)
        Controls.Add(lnkClear)
        Controls.Add(lblResult)
        Controls.Add(lnkHistory)
        Controls.Add(Label6)
        Controls.Add(pbMeme)
        Controls.Add(grpCycle)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblAnswer)
        Controls.Add(Label1)
        Controls.Add(btnGo)
        ForeColor = SystemColors.Control
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        grpCycle.ResumeLayout(False)
        grpCycle.PerformLayout()
        CType(tbCycle, ComponentModel.ISupportInitialize).EndInit()
        CType(pbMeme, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents btnGo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblResponse As Label
    Friend WithEvents grpCycle As GroupBox
    Friend WithEvents chkMood As CheckBox
    Friend WithEvents chkCramps As CheckBox
    Friend WithEvents chkAcne As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents pbMeme As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbCycle As TrackBar
    Friend WithEvents lblResult As Label
    Friend WithEvents lnkHistory As LinkLabel
    Friend WithEvents lnkClear As LinkLabel
    Friend WithEvents lblCycleValue As Label
    Friend WithEvents rbHeavy As System.Windows.Forms.RadioButton
    Friend WithEvents rbLight As System.Windows.Forms.RadioButton
    Friend WithEvents rbMedium As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label

End Class
