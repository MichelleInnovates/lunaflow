Imports System.IO

Public Class Form1
    ' --- CONFIGURATION ---
    Private Const LOG_FILE As String = "cycle_data.txt"

    ' --- 1. FORM LOAD ---
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If lblCycleValue IsNot Nothing Then
            lblCycleValue.Text = tbCycle.Value & " Days"
        End If
    End Sub

    ' --- 2. SLIDER SCROLL ---
    Private Sub tbCycle_Scroll(sender As Object, e As EventArgs) Handles tbCycle.Scroll
        If lblCycleValue IsNot Nothing Then
            lblCycleValue.Text = tbCycle.Value & " Days"
        End If
    End Sub

    ' --- 3. THE MAIN PREDICTION BUTTON ---
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Try
            ' A. GATHER BASIC INPUTS
            Dim lastDate As Date = dtpStart.Value
            Dim cycleDays As Integer = tbCycle.Value

            ' B. CALCULATE FUTURE DATES
            Dim nextPeriod As Date = lastDate.AddDays(cycleDays)
            Dim ovulationDay As Date = nextPeriod.AddDays(-14)
            Dim fertileStart As Date = ovulationDay.AddDays(-5)
            Dim fertileEnd As Date = ovulationDay.AddDays(1)
            Dim lutealStart As Date = ovulationDay.AddDays(1)
            Dim lutealEnd As Date = nextPeriod.AddDays(-1)

            Dim today As Date = DateTime.Now.Date
            Dim daysLate As Integer = (today - nextPeriod).Days
            Dim daysSinceLastPeriod As Integer = (today - lastDate).Days

            ' C. BUILD FORECAST TEXT
            Dim result As String = ""
            If daysSinceLastPeriod > 35 Then
                result = "⚠️ UNCERTAIN CYCLE (Est. Dates)" & vbCrLf
            Else
                result = "📊 CYCLE FORECAST" & vbCrLf
            End If

            result &= "-----------------------" & vbCrLf &
                      "🩸 Next Period:    " & nextPeriod.ToString("ddd, MMM dd") & vbCrLf &
                      "💕 Fertile Window: " & fertileStart.ToString("MMM dd") & " - " & fertileEnd.ToString("MMM dd") & vbCrLf &
                      "🥚 Ovulation Day:  " & ovulationDay.ToString("MMM dd") & vbCrLf &
                      "🌙 Luteal Phase:   " & lutealStart.ToString("MMM dd") & " - " & lutealEnd.ToString("MMM dd")

            ' D. DETERMINE CURRENT STATUS
            Dim status As String = ""
            If daysLate > 10 Then
                status = "⚠️ STATUS: Missed Period (> 10 Days Late)" & vbCrLf & "Recommendation: Consider taking a test."
            ElseIf daysLate > 0 Then
                status = "⏳ STATUS: Late by " & daysLate & " Day(s)."
            ElseIf today >= lastDate And today < lastDate.AddDays(5) Then
                status = "✨ TODAY: Menstrual Phase 🩸"
            ElseIf today >= fertileStart And today <= fertileEnd Then
                status = "✨ TODAY: Fertile Phase 🥚"
            ElseIf today > fertileEnd And today < nextPeriod Then
                status = "✨ TODAY: Luteal Phase 🌙"
            Else
                status = "✨ TODAY: Follicular Phase 🌱"
            End If

            ' E. RANDOM JOKE
            Dim jokes() As String = {
                "Mood: I want to speak to the manager of hormones.",
                "Not pregnant! Just a food baby. 🍔",
                "Rule #1: Do not sneeze right now.",
                "Uterus remodeling in progress... 🏗️",
                "Shark week, but make it fashion. 💅"
            }
            Dim rnd As New Random()
            Dim selectedJoke As String = jokes(rnd.Next(jokes.Length))

            ' F. DISPLAY RESULTS
            If lblResult IsNot Nothing Then
                lblResult.Text = result & vbCrLf & vbCrLf & status & vbCrLf & vbCrLf & "-----------------------" & vbCrLf & selectedJoke
            End If

            ' --- G. MEME LOGIC (Fixed) ---
            Dim daysUntil As Integer = (nextPeriod.Date - today).Days
            Dim memeFile As String = "chill.jpg"

            ' NOTICE: I pressed Enter after every "Then". This fixes the error.
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
            ' --- H. GATHER SYMPTOMS & FLOW (NEW!) ---
            Dim symptoms As String = ""

            ' Check checkboxes safely
            If chkCramps IsNot Nothing AndAlso chkCramps.Checked Then symptoms &= "Cramps "
            If chkMood IsNot Nothing AndAlso chkMood.Checked Then symptoms &= "Mood "
            If chkAcne IsNot Nothing AndAlso chkAcne.Checked Then symptoms &= "Acne "

            ' Check Flow Buttons safely
            Dim flow As String = "None"
            'If rbLight IsNot Nothing AndAlso rbLight.Checked Then flow = "Light"
            'If rbMedium IsNot Nothing AndAlso rbMedium.Checked Then flow = "Medium"
            'If rbHeavy IsNot Nothing AndAlso rbHeavy.Checked Then flow = "Heavy"

            ' Combine them
            Dim logEntry As String = "Symp: " & symptoms & "| Flow: " & flow

            ' I. SAVE TO FILE
            SaveToFile(lastDate, cycleDays, nextPeriod, logEntry)

        Catch ex As Exception
            If lblResult IsNot Nothing Then lblResult.Text = "Error: " & ex.Message
        End Try
    End Sub

    ' --- 4. SAVE HELPER ---
    Private Sub SaveToFile(lastDate As Date, cycleDays As Integer, nextP As Date, details As String)
        Try
            ' Format: Date, Cycle, NextPeriod, Details
            Dim line As String = lastDate.ToString("yyyy-MM-dd") & " | Cycle: " & cycleDays & " | Next: " & nextP.ToString("MMM-dd") & " | " & details
            File.AppendAllText(LOG_FILE, line & vbCrLf)
        Catch
        End Try
    End Sub

    ' --- 5. HISTORY LINK (Now with a LOOP!) ---
    Private Sub lnkHistory_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkHistory.LinkClicked
        If File.Exists(LOG_FILE) Then
            Dim allHistory As String = "📚 HISTORY LOG:" & vbCrLf & "------------------" & vbCrLf

            ' READ FILE INTO AN ARRAY
            Dim lines() As String = File.ReadAllLines(LOG_FILE)

            ' *** THE LOOPING STRUCTURE ***
            ' We loop through every single line one by one
            For Each singleLine As String In lines
                allHistory &= singleLine & vbCrLf
            Next
            ' *****************************

            lblResult.Text = allHistory
        Else
            lblResult.Text = "📭 No history found."
        End If
    End Sub

    ' --- 6. CLEAR DATA LINK ---
    Private Sub lnkClear_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkClear.LinkClicked
        Dim answer As DialogResult = MessageBox.Show("Delete all history?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
        If answer = DialogResult.Yes Then
            If File.Exists(LOG_FILE) Then File.Delete(LOG_FILE)
            lblResult.Text = "🗑️ History deleted."
        End If
    End Sub

End Class