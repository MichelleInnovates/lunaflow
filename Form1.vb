Imports System.IO

Public Class Form1

    ' This is like a Procedure: It runs when you click the button
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        ' 1. Data Types and Variables: Storing information
        Dim lastDate As Date = dtpStart.Value
        Dim cycleDays As Integer = CInt(numCycle.Value)

        ' 2. Error Handling: Checking for mistakes before they happen
        Try
            ' 3. The Algorithm: The "Math" part

            Dim nextPeriod As Date = lastDate.AddDays(cycleDays)

            ' Ovulation is usually 14 days BEFORE the next period
            Dim ovulationDay As Date = nextPeriod.AddDays(-14)

            ' 4. Decision Structure: If/Then logic

            If lastDate > DateTime.Now Then
                lblResult.Text = "Error: You can't pick a future date!"
                Exit Sub
            End If

            ' 5. Displaying the Result
            lblResult.Text = "Your next period is: " & nextPeriod.ToShortDateString() &
                           vbCrLf & "Ovulation Day: " & ovulationDay.ToShortDateString()

            ' 6. Data Storage: Saving it to a text file so it's not lost

            Dim logMessage As String = "Log: " & lastDate.ToShortDateString() & " | Cycle: " & cycleDays
            File.AppendAllText("my_logs.txt", logMessage & Environment.NewLine)

        Catch ex As Exception

            MessageBox.Show("Something went wrong: " & ex.Message)
        End Try

    End Sub

End Class