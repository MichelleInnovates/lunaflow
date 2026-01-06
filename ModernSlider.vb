Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Windows.Forms

Public Class ModernSlider
    Inherits Control

    ' Properties for the user to change
    Public Property Minimum As Integer = 21
    Public Property Maximum As Integer = 45
    Private _Value As Integer = 28

    Public Property Value As Integer
        Get
            Return _Value
        End Get
        Set(val As Integer)
            If val < Minimum Then val = Minimum
            If val > Maximum Then val = Maximum
            _Value = val
            Me.Invalidate() ' Redraws the control
            RaiseEvent Scroll(Me, EventArgs.Empty) ' Tells Form1 we moved
        End Set
    End Property

    ' Event to let Form1 know when it moves
    Public Event Scroll As EventHandler

    Public Sub New()
        Me.DoubleBuffered = True
        Me.Height = 30 ' Default height
        Me.Cursor = Cursors.Hand
        Me.BackColor = Color.Transparent
    End Sub

    ' --- 1. DRAWING THE SLIDER (The "Paint" Logic) ---
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim g As Graphics = e.Graphics
        g.SmoothingMode = SmoothingMode.AntiAlias

        ' A. Draw the Track (The gray line)
        Dim trackY As Integer = Me.Height \ 2
        Dim trackPen As New Pen(Color.FromArgb(80, 80, 80), 4) ' Dark Gray Line
        trackPen.StartCap = LineCap.Round
        trackPen.EndCap = LineCap.Round
        g.DrawLine(trackPen, 10, trackY, Me.Width - 10, trackY)

        ' B. Calculate Thumb Position
        Dim range As Integer = Maximum - Minimum
        Dim percent As Single = CSng(_Value - Minimum) / CSng(range)
        Dim usableWidth As Integer = Me.Width - 20
        Dim thumbX As Integer = 10 + CInt(usableWidth * percent)

        ' C. Draw the "Fill" (The colored line behind the thumb)
        Dim fillPen As New Pen(Color.MediumPurple, 4) ' Accent Color
        fillPen.StartCap = LineCap.Round
        g.DrawLine(fillPen, 10, trackY, thumbX, trackY)

        ' D. Draw the Thumb (The Circle)
        Dim circleSize As Integer = 16
        Dim thumbRect As New Rectangle(thumbX - (circleSize \ 2), trackY - (circleSize \ 2), circleSize, circleSize)

        g.FillEllipse(Brushes.White, thumbRect) ' White Circle
        g.DrawEllipse(New Pen(Color.MediumPurple, 2), thumbRect) ' Purple Border
    End Sub

    ' --- 2. MOUSE MOVEMENT LOGIC ---
    Dim isDragging As Boolean = False

    Protected Overrides Sub OnMouseDown(e As MouseEventArgs)
        isDragging = True
        MoveSlider(e.X)
    End Sub

    Protected Overrides Sub OnMouseMove(e As MouseEventArgs)
        If isDragging Then MoveSlider(e.X)
    End Sub

    Protected Overrides Sub OnMouseUp(e As MouseEventArgs)
        isDragging = False
    End Sub

    Private Sub MoveSlider(mouseX As Integer)
        ' Math to convert Mouse Position -> Value (21 to 45)
        Dim usableWidth As Integer = Me.Width - 20
        Dim relativeX As Integer = mouseX - 10
        Dim percent As Single = CSng(relativeX) / CSng(usableWidth)

        If percent < 0 Then percent = 0
        If percent > 1 Then percent = 1

        Dim newValue As Integer = Minimum + CInt(percent * (Maximum - Minimum))
        Me.Value = newValue
    End Sub
End Class