Imports System.IO

Public Class Form1
    Private Const LOG_FILE As String = "cycle_data.txt"

    ' --- 1. FORM LOAD ---
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This ensures the slider label has a value when the app starts
        If lblCycleValue IsNot Nothing Then
            lblCycleValue.Text = tbCycle.Value & " Days"
        End If
    End Sub

    ' --- 2. SLIDER SCROLL ---
    Private Sub tbCycle_Scroll(sender As Object, e As EventArgs) Handles tbCycle.Scroll
        ' Updates the number as you drag
        If lblCycleValue IsNot Nothing Then
            lblCycleValue.Text = tbCycle.Value & " Days"
        End If
    End Sub

    ' --- 3. THE MAIN PREDICTION BUTTON ---
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Try
            Dim lastDate As Date = dtpStart.Value
            Dim cycleDays As Integer = tbCycle.Value

            ' --- A. CALCULATE PHASES ---
            Dim nextPeriod As Date = lastDate.AddDays(cycleDays)
            Dim ovulationDay As Date = nextPeriod.AddDays(-14)
            Dim fertileStart As Date = ovulationDay.AddDays(-5)
            Dim fertileEnd As Date = ovulationDay.AddDays(1)
            Dim lutealStart As Date = ovulationDay.AddDays(1)
            Dim lutealEnd As Date = nextPeriod.AddDays(-1)
            Dim daysUntil As Integer = (nextPeriod.Date - DateTime.Now.Date).Days

            ' --- B. BUILD FORECAST TEXT ---
            Dim result As String = ""

            ' Check Irregular Button (Safety check in case it was deleted)
            Dim isIrregular As Boolean = False
            If chkIrregular IsNot Nothing Then isIrregular = chkIrregular.Checked

            If isIrregular Then
                result = "⚠️ IRREGULAR CYCLE MODE" & vbCrLf &
                         "Dates may vary by +/- 3 days." & vbCrLf & vbCrLf &
                         "🩸 Period Window: " & nextPeriod.AddDays(-3).ToString("MMM dd") & " - " & nextPeriod.AddDays(3).ToString("MMM dd")
            Else
                result = "📊 CYCLE FORECAST" & vbCrLf &
                         "-----------------------" & vbCrLf &
                         "🩸 Next Period:    " & nextPeriod.ToString("ddd, MMM dd") & vbCrLf &
                         "💕 Fertile Window: " & fertileStart.ToString("MMM dd") & " - " & fertileEnd.ToString("MMM dd") & vbCrLf &
                         "🥚 Ovulation Day:  " & ovulationDay.ToString("MMM dd") & vbCrLf &
                         "🌙 Luteal Phase:   " & lutealStart.ToString("MMM dd") & " - " & lutealEnd.ToString("MMM dd")
            End If

            ' --- C. DETERMINE CURRENT STATUS ---
            Dim status As String = ""
            Dim today As Date = DateTime.Now.Date

            If today >= lastDate And today < lastDate.AddDays(5) Then
                status = "✨ TODAY: Menstrual Phase 🩸 (Rest & recharge!)"
            ElseIf today >= fertileStart And today <= fertileEnd Then
                status = "✨ TODAY: Fertile Phase 🥚 (High energy/Libido!)"
            ElseIf today > fertileEnd And today < nextPeriod Then
                status = "✨ TODAY: Luteal Phase 🌙 (PMS Zone - Be kind to yourself)"
            Else
                status = "✨ TODAY: Follicular Phase 🌱 (Rising energy)"
            End If

            ' --- D. RANDOM JOKE GENERATOR ---
            Dim jokes() As String = {
                "💭 Mood: I want to speak to the manager of hormones.",
                "🤰 Not pregnant! Just a food baby. 🍔",
                "🤧 Period Rule #1: Do not sneeze.",
                "🏗️ Uterus remodeling in progress... please wait.",
                "📉 Congratulations! You are NOT the mother!",
                "🌊 Shark week, but make it fashion. 💅",
                "🍫 Chocolate is technically a salad. It comes from a bean."
            }
            Dim rnd As New Random()
            Dim selectedJoke As String = jokes(rnd.Next(jokes.Length))

            ' --- E. DISPLAY EVERYTHING ---
            If lblResult IsNot Nothing Then
                lblResult.Text = result & vbCrLf & vbCrLf &
                                 status & vbCrLf & vbCrLf &
                                 "-----------------------" & vbCrLf &
                                 selectedJoke
            End If

            ' --- F. MEME LOGIC (Fixing the ElseIf Error) ---
            Dim memeFile As String = "chill.jpg"

            If daysUntil < 0 Then
                memeFile = "panic.jpg"
            ElseIf daysUntil <= 3 Then
                memeFile = "panic.jpg"
            ElseIf today >= fertileStart And today <= fertileEnd Then
                memeFile = "happy.jpg"
            End If

            If pbMeme IsNot Nothing AndAlso File.Exists(memeFile) Then
                pbMeme.Image = Image.FromFile(memeFile)
            End If

            ' --- G. SAVE DATA ---
            SaveToFile(lastDate, cycleDays, nextPeriod, "Logged")

        Catch ex As Exception
            If lblResult IsNot Nothing Then lblResult.Text = "Error: " & ex.Message
        End Try
    End Sub

    ' --- 4. HELPERS AND LINKS ---
    Private Sub SaveToFile(lastDate As Date, cycleDays As Integer, nextP As Date, symps As String)
        Try
            Dim line As String = lastDate.ToString("yyyy-MM-dd") & "," & cycleDays & "," & nextP.ToString("yyyy-MM-dd")
            File.AppendAllText(LOG_FILE, line & vbCrLf)
        Catch
        End Try
    End Sub

    Private Sub lnkHistory_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkHistory.LinkClicked
        If File.Exists(LOG_FILE) Then
            lblResult.Text = "📚 History Log:" & vbCrLf & File.ReadAllText(LOG_FILE)
        Else
            lblResult.Text = "📭 No history found."
        End If
    End Sub

    Private Sub lnkClear_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkClear.LinkClicked
        If MessageBox.Show("Delete all history?", "Confirm", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If File.Exists(LOG_FILE) Then File.Delete(LOG_FILE)
            lblResult.Text = "🗑️ History deleted."
        End If
    End Sub

End Class