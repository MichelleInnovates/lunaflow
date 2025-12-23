Imports System.IO

Public Class Form1

    Private Const LOG_FILE As String = "cycle_data.txt"

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Dim lastDate As Date = dtpStart.Value
        Dim cycleDays As Integer = CInt(numCycle.Value)

        If Not ValidateInput(lastDate, cycleDays) Then
            Exit Sub
        End If

        Try
            CalculateAndDisplay(lastDate, cycleDays)
            SaveToFile(lastDate, cycleDays)
        Catch ex As Exception
            lblResult.Text = "Error: Unable to process your request. Please try again."
        End Try
    End Sub

    Private Function ValidateInput(lastDate As Date, cycleDays As Integer) As Boolean
        If lastDate.Date > DateTime.Now.Date Then
            lblResult.Text = "Error:Start date cannot be in the future."
            Return False
        End If

        If cycleDays < 21 Or cycleDays > 40 Then
            lblResult.Text = "Error:Cycle length must be between 21 and 40 days."
            Return False
        End If

        If lastDate.Date < DateTime.Now.Date.AddYears(-1) Then
            lblResult.Text = "Warning: This date is over a year ago. Results may be less accurate."
        End If
        Return True
    End Function

    Private Sub CalculateAndDisplay(lastDate As Date, cycleDays As Integer)
        Dim nextPeriod As Date = lastDate.AddDays(cycleDays)
        Dim ovulationDay As Date = nextPeriod.AddDays(-14)
        Dim fertileStart As Date = ovulationDay.AddDays(-5)
        Dim fertileEnd As Date = ovulationDay.AddDays(1)

        Dim resultText As String = "Next Period: " & nextPeriod.ToString("MMMM dd, yyyy") & vbCrLf &
                                   "Ovulation Day: " & ovulationDay.ToString("MMMM dd, yyyy") & vbCrLf &
                                   "Fertile Window: " & fertileStart.ToString("MMM dd") & " - " & fertileEnd.ToString("MMM dd") & vbCrLf

        Dim daysUntilPeriod As Integer = (nextPeriod.Date - DateTime.Now.Date).Days

        If daysUntilPeriod < 0 Then
            resultText &= vbCrLf & "Note: Your next period date has passed. Consider entering a new cycle."
        ElseIf daysUntilPeriod <= 3 Then
            resultText &= vbCrLf & "Alert: Your period is expected within " & daysUntilPeriod & " days."
        ElseIf DateTime.Now.Date >= fertileStart.Date And DateTime.Now.Date <= fertileEnd.Date Then
            resultText &= vbCrLf & "Status: You are currently in your fertile window."
        Else
            resultText &= vbCrLf & "Days until next period: " & daysUntilPeriod
        End If

        lblResult.Text = resultText
    End Sub

    Private Sub SaveToFile(lastDate As Date, cycleDays As Integer)
        Try
            Dim nextPeriod As Date = lastDate.AddDays(cycleDays)
            Dim ovulationDay As Date = nextPeriod.AddDays(-14)
            Dim timestamp As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

            Dim logEntry As String = lastDate.ToString("yyyy-MM-dd") & "," &
                                    cycleDays.ToString() & "," &
                                    nextPeriod.ToString("yyyy-MM-dd") & "," &
                                    ovulationDay.ToString("yyyy-MM-dd") & "," &
                                    timestamp

            If Not File.Exists(LOG_FILE) Then
                File.WriteAllText(LOG_FILE, "LastPeriod,CycleLength,NextPeriod,Ovulation,Timestamp" & Environment.NewLine)
            End If

            File.AppendAllText(LOG_FILE, logEntry & Environment.NewLine)
        Catch ex As IOException
            MessageBox.Show("Unable to save data. Check file permissions.")
        End Try
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles BtnHistory.Click
        If Not File.Exists(LOG_FILE) Then
            lblResult.Text = "No history found. Start tracking to build your history."
            Exit Sub
        End If

        Try
            Dim lines As String() = File.ReadAllLines(LOG_FILE)
            Dim historyText As String = "Your Cycle History:" & vbCrLf & vbCrLf

            If lines.Length <= 1 Then
                lblResult.Text = "No entries yet. Make your first prediction."
                Exit Sub
            End If

            Dim count As Integer = 0
            For i As Integer = lines.Length - 1 To 1 Step -1
                If count >= 5 Then Exit For

                Dim parts As String() = lines(i).Split(","c)
                If parts.Length >= 4 Then
                    historyText &= "Last Period: " & parts(0) & " | Cycle: " & parts(1) & " days" & vbCrLf
                    count += 1
                End If
            Next

            lblResult.Text = historyText
        Catch ex As Exception
            lblResult.Text = "Error reading history file."
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete all saved data?",
                                                     "Confirm Clear",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Warning)

        If result = DialogResult.Yes Then
            Try
                If File.Exists(LOG_FILE) Then
                    File.Delete(LOG_FILE)
                    lblResult.Text = "All data cleared successfully."
                Else
                    lblResult.Text = "No data to clear."
                End If
            Catch ex As Exception
                lblResult.Text = "Error: Could not delete data file."
            End Try
        End If
    End Sub

End Class

