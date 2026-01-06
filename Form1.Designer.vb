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
        lblCycleValue = New Label()
        lblResult = New Label()
        tbCycle = New TrackBar()
        Label4 = New Label()
        chkIrregular = New CheckBox()
        grpSymptoms = New GroupBox()
        rdoHeavy = New RadioButton()
        rdoMedium = New RadioButton()
        rdoLight = New RadioButton()
        Label5 = New Label()
        chkAcne = New CheckBox()
        chkMood = New CheckBox()
        chkCramps = New CheckBox()
        pbMeme = New PictureBox()
        Label6 = New Label()
        lnkHistory = New LinkLabel()
        lnkClear = New LinkLabel()
        grpCycle.SuspendLayout()
        CType(tbCycle, ComponentModel.ISupportInitialize).BeginInit()
        grpSymptoms.SuspendLayout()
        CType(pbMeme, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dtpStart
        ' 
        dtpStart.Font = New Font("Segoe UI Symbol", 9.25F)
        dtpStart.Location = New Point(15, 49)
        dtpStart.Name = "dtpStart"
        dtpStart.Size = New Size(200, 24)
        dtpStart.TabIndex = 1
        ' 
        ' btnGo
        ' 
        btnGo.BackColor = Color.FromArgb(CByte(156), CByte(89), CByte(182))
        btnGo.FlatAppearance.BorderSize = 0
        btnGo.FlatStyle = FlatStyle.Flat
        btnGo.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        btnGo.ForeColor = SystemColors.Control
        btnGo.Location = New Point(294, 353)
        btnGo.Name = "btnGo"
        btnGo.Size = New Size(228, 35)
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
        Label2.Font = New Font("Microsoft Sans Serif", 14F, FontStyle.Bold)
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
        Label3.Font = New Font("Arial", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(28, 45)
        Label3.Name = "Label3"
        Label3.Size = New Size(186, 15)
        Label3.TabIndex = 10
        Label3.Text = "Track your cycle, plan your future"
        ' 
        ' grpCycle
        ' 
        grpCycle.Controls.Add(lblCycleValue)
        grpCycle.Controls.Add(lblResult)
        grpCycle.Controls.Add(tbCycle)
        grpCycle.Controls.Add(Label4)
        grpCycle.Controls.Add(chkIrregular)
        grpCycle.Controls.Add(dtpStart)
        grpCycle.Font = New Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpCycle.ForeColor = SystemColors.Control
        grpCycle.Location = New Point(27, 76)
        grpCycle.Name = "grpCycle"
        grpCycle.Size = New Size(248, 229)
        grpCycle.TabIndex = 13
        grpCycle.TabStop = False
        grpCycle.Text = "1. CYCLE DATA"
        ' 
        ' lblCycleValue
        ' 
        lblCycleValue.AutoSize = True
        lblCycleValue.Location = New Point(160, 83)
        lblCycleValue.Name = "lblCycleValue"
        lblCycleValue.Size = New Size(61, 17)
        lblCycleValue.TabIndex = 19
        lblCycleValue.Text = "28 days"
        ' 
        ' lblResult
        ' 
        lblResult.Font = New Font("Segoe UI", 11.25F)
        lblResult.ForeColor = SystemColors.Control
        lblResult.Location = New Point(15, 112)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(200, 57)
        lblResult.TabIndex = 18
        lblResult.Text = "Press 'Predict' to see your cycle forecast..."
        lblResult.TextAlign = ContentAlignment.TopCenter
        ' 
        ' tbCycle
        ' 
        tbCycle.AutoSize = False
        tbCycle.Location = New Point(15, 83)
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
        Label4.Font = New Font("Segoe UI", 11F)
        Label4.Location = New Point(15, 24)
        Label4.Name = "Label4"
        Label4.Size = New Size(88, 20)
        Label4.TabIndex = 14
        Label4.Text = "Date picker:"
        ' 
        ' chkIrregular
        ' 
        chkIrregular.Appearance = Appearance.Button
        chkIrregular.AutoSize = True
        chkIrregular.BackColor = Color.Transparent
        chkIrregular.FlatAppearance.CheckedBackColor = Color.FromArgb(CByte(192), CByte(64), CByte(0))
        chkIrregular.FlatStyle = FlatStyle.Flat
        chkIrregular.Font = New Font("Segoe UI Emoji", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkIrregular.ForeColor = SystemColors.Control
        chkIrregular.Location = New Point(15, 192)
        chkIrregular.Name = "chkIrregular"
        chkIrregular.Size = New Size(108, 26)
        chkIrregular.TabIndex = 13
        chkIrregular.Text = "My cycle is varies"
        chkIrregular.TextAlign = ContentAlignment.MiddleCenter
        chkIrregular.UseVisualStyleBackColor = False
        ' 
        ' grpSymptoms
        ' 
        grpSymptoms.Controls.Add(rdoHeavy)
        grpSymptoms.Controls.Add(rdoMedium)
        grpSymptoms.Controls.Add(rdoLight)
        grpSymptoms.Controls.Add(Label5)
        grpSymptoms.Controls.Add(chkAcne)
        grpSymptoms.Controls.Add(chkMood)
        grpSymptoms.Controls.Add(chkCramps)
        grpSymptoms.Font = New Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        grpSymptoms.ForeColor = SystemColors.Control
        grpSymptoms.Location = New Point(545, 76)
        grpSymptoms.Name = "grpSymptoms"
        grpSymptoms.Size = New Size(243, 229)
        grpSymptoms.TabIndex = 14
        grpSymptoms.TabStop = False
        grpSymptoms.Text = "2. SYMPTOMS TRACKING"
        ' 
        ' rdoHeavy
        ' 
        rdoHeavy.Appearance = Appearance.Button
        rdoHeavy.AutoSize = True
        rdoHeavy.BackColor = Color.FromArgb(CByte(255), CByte(127), CByte(127))
        rdoHeavy.FlatStyle = FlatStyle.Flat
        rdoHeavy.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rdoHeavy.Location = New Point(22, 192)
        rdoHeavy.Name = "rdoHeavy"
        rdoHeavy.Size = New Size(145, 27)
        rdoHeavy.TabIndex = 6
        rdoHeavy.TabStop = True
        rdoHeavy.Text = "Heavy / Niagara Falls " & ChrW(55358) & ChrW(56952)
        rdoHeavy.TextAlign = ContentAlignment.MiddleCenter
        rdoHeavy.UseVisualStyleBackColor = False
        ' 
        ' rdoMedium
        ' 
        rdoMedium.Appearance = Appearance.Button
        rdoMedium.BackColor = Color.LightPink
        rdoMedium.FlatStyle = FlatStyle.Flat
        rdoMedium.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rdoMedium.Location = New Point(23, 159)
        rdoMedium.Name = "rdoMedium"
        rdoMedium.Size = New Size(144, 27)
        rdoMedium.TabIndex = 5
        rdoMedium.TabStop = True
        rdoMedium.Text = "Medium 🌊"
        rdoMedium.TextAlign = ContentAlignment.MiddleCenter
        rdoMedium.UseVisualStyleBackColor = False
        ' 
        ' rdoLight
        ' 
        rdoLight.Appearance = Appearance.Button
        rdoLight.BackColor = Color.FromArgb(CByte(255), CByte(235), CByte(238))
        rdoLight.FlatStyle = FlatStyle.Flat
        rdoLight.Font = New Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        rdoLight.ForeColor = SystemColors.ActiveCaptionText
        rdoLight.Location = New Point(23, 127)
        rdoLight.Name = "rdoLight"
        rdoLight.Size = New Size(144, 26)
        rdoLight.TabIndex = 4
        rdoLight.TabStop = True
        rdoLight.Text = "Light / Spotting 💧"
        rdoLight.TextAlign = ContentAlignment.MiddleCenter
        rdoLight.UseVisualStyleBackColor = False
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(22, 107)
        Label5.Name = "Label5"
        Label5.Size = New Size(86, 17)
        Label5.TabIndex = 3
        Label5.Text = "Flow Level:"
        ' 
        ' chkAcne
        ' 
        chkAcne.AutoSize = True
        chkAcne.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkAcne.Location = New Point(22, 75)
        chkAcne.Name = "chkAcne"
        chkAcne.Size = New Size(53, 19)
        chkAcne.TabIndex = 2
        chkAcne.Text = "Acne"
        chkAcne.UseVisualStyleBackColor = True
        ' 
        ' chkMood
        ' 
        chkMood.AutoSize = True
        chkMood.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkMood.Location = New Point(22, 49)
        chkMood.Name = "chkMood"
        chkMood.Size = New Size(107, 21)
        chkMood.TabIndex = 1
        chkMood.Text = "Mood Swings"
        chkMood.UseVisualStyleBackColor = True
        ' 
        ' chkCramps
        ' 
        chkCramps.AutoSize = True
        chkCramps.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        chkCramps.Location = New Point(22, 24)
        chkCramps.Name = "chkCramps"
        chkCramps.Size = New Size(67, 19)
        chkCramps.TabIndex = 0
        chkCramps.Text = "Cramps"
        chkCramps.UseVisualStyleBackColor = True
        ' 
        ' pbMeme
        ' 
        pbMeme.BackColor = Color.Transparent
        pbMeme.Location = New Point(294, 87)
        pbMeme.Name = "pbMeme"
        pbMeme.Size = New Size(228, 218)
        pbMeme.SizeMode = PictureBoxSizeMode.Zoom
        pbMeme.TabIndex = 15
        pbMeme.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Cambria", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.Control
        Label6.Location = New Point(310, 76)
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
        lnkHistory.Location = New Point(12, 426)
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
        lnkClear.Location = New Point(725, 426)
        lnkClear.Name = "lnkClear"
        lnkClear.Size = New Size(61, 15)
        lnkClear.TabIndex = 19
        lnkClear.TabStop = True
        lnkClear.Text = "Clear Data"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(30), CByte(30), CByte(40))
        ClientSize = New Size(800, 450)
        Controls.Add(lnkClear)
        Controls.Add(lnkHistory)
        Controls.Add(Label6)
        Controls.Add(pbMeme)
        Controls.Add(grpSymptoms)
        Controls.Add(grpCycle)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lblAnswer)
        Controls.Add(Label1)
        Controls.Add(btnGo)
        ForeColor = SystemColors.Control
        Name = "Form1"
        Text = "Form1"
        grpCycle.ResumeLayout(False)
        grpCycle.PerformLayout()
        CType(tbCycle, ComponentModel.ISupportInitialize).EndInit()
        grpSymptoms.ResumeLayout(False)
        grpSymptoms.PerformLayout()
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
    Friend WithEvents chkIrregular As CheckBox
    Friend WithEvents grpSymptoms As GroupBox
    Friend WithEvents chkMood As CheckBox
    Friend WithEvents chkCramps As CheckBox
    Friend WithEvents chkAcne As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents rdoMedium As RadioButton
    Friend WithEvents rdoLight As RadioButton
    Friend WithEvents rdoHeavy As RadioButton
    Friend WithEvents pbMeme As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbCycle As TrackBar
    Friend WithEvents lblResult As Label
    Friend WithEvents lnkHistory As LinkLabel
    Friend WithEvents lnkClear As LinkLabel
    Friend WithEvents lblCycleValue As Label

End Class
