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
        lblResult = New Label()
        dtpStart = New DateTimePicker()
        numCycle = New NumericUpDown()
        btnGo = New Button()
        Label1 = New Label()
        lblAnswer = New Label()
        CType(numCycle, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(259, -1)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(187, 15)
        lblResult.TabIndex = 0
        lblResult.Text = """When was your last period start?"""
        ' 
        ' dtpStart
        ' 
        dtpStart.Location = New Point(246, 32)
        dtpStart.Name = "dtpStart"
        dtpStart.Size = New Size(200, 23)
        dtpStart.TabIndex = 1
        ' 
        ' numCycle
        ' 
        numCycle.Location = New Point(281, 72)
        numCycle.Maximum = New Decimal(New Integer() {40, 0, 0, 0})
        numCycle.Minimum = New Decimal(New Integer() {21, 0, 0, 0})
        numCycle.Name = "numCycle"
        numCycle.Size = New Size(120, 23)
        numCycle.TabIndex = 2
        numCycle.Value = New Decimal(New Integer() {21, 0, 0, 0})
        ' 
        ' btnGo
        ' 
        btnGo.Location = New Point(280, 112)
        btnGo.Name = "btnGo"
        btnGo.Size = New Size(121, 21)
        btnGo.TabIndex = 3
        btnGo.Text = "Predict My Future!"
        btnGo.UseVisualStyleBackColor = True
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblAnswer)
        Controls.Add(Label1)
        Controls.Add(btnGo)
        Controls.Add(numCycle)
        Controls.Add(dtpStart)
        Controls.Add(lblResult)
        Name = "Form1"
        Text = "Form1"
        CType(numCycle, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblResult As Label
    Friend WithEvents dtpStart As DateTimePicker
    Friend WithEvents numCycle As NumericUpDown
    Friend WithEvents btnGo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblAnswer As Label

End Class
