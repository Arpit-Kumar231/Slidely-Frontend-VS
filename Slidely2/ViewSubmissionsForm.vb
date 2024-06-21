Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm
    Private submissions As New List(Of Submission)()
    Private currentIndex As Integer = 0

    ' Loads submissions when the form is first opened
    Private Async Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorTranslator.FromHtml("#121212") ' Black background color
        Me.ForeColor = ColorTranslator.FromHtml("#E0E0E0") ' Light gray text color
        Me.KeyPreview = True

        ' TextBox properties
        txtName.BackColor = ColorTranslator.FromHtml("#2C2C2C")
        txtName.ForeColor = ColorTranslator.FromHtml("#E0E0E0")
        txtEmail.BackColor = ColorTranslator.FromHtml("#2C2C2C")
        txtEmail.ForeColor = ColorTranslator.FromHtml("#E0E0E0")
        txtPhoneNumber.BackColor = ColorTranslator.FromHtml("#2C2C2C")
        txtPhoneNumber.ForeColor = ColorTranslator.FromHtml("#E0E0E0")
        txtGithubLink.BackColor = ColorTranslator.FromHtml("#2C2C2C")
        txtGithubLink.ForeColor = ColorTranslator.FromHtml("#E0E0E0")

        ' Label properties
        lblName.ForeColor = ColorTranslator.FromHtml("#E0E0E0")

        lblGithubLink.ForeColor = ColorTranslator.FromHtml("#E0E0E0")
        lblStopwatch.ForeColor = ColorTranslator.FromHtml("#E0E0E0")

        ' Button properties

        btnPrevious.BackColor = ColorTranslator.FromHtml("#3D3C42") ' Dark purple background color
        btnPrevious.ForeColor = ColorTranslator.FromHtml("#FFFFFF") ' White text color
        btnNext.BackColor = ColorTranslator.FromHtml("#3D3C42") ' Dark purple background color
        btnNext.ForeColor = ColorTranslator.FromHtml("#FFFFFF") ' White text color
        btnDelete.BackColor = ColorTranslator.FromHtml("#3D3C42") ' Dark purple background color
        btnDelete.ForeColor = ColorTranslator.FromHtml("#FFFFFF")
        btnUpdate.BackColor = ColorTranslator.FromHtml("#3D3C42") ' Dark purple background color
        btnUpdate.ForeColor = ColorTranslator.FromHtml("#FFFFFF")
        Me.KeyPreview = True
        Await LoadSubmissions()
        If submissions.Count > 0 Then
            DisplaySubmission(submissions(currentIndex))
        End If
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.D Then
            btnDelete.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.U Then
            btnUpdate.PerformClick()
        End If
    End Sub


    Private Async Function LoadSubmissions() As Task
        Using client As New HttpClient()
            Dim index As Integer = 0
            Dim response As HttpResponseMessage

            Do
                response = Await client.GetAsync($"http://localhost:3000/read?index={index}")
                If response.IsSuccessStatusCode Then
                    Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                    Dim submission As Submission = JsonConvert.DeserializeObject(Of Submission)(jsonResponse)
                    submissions.Add(submission)
                    index += 1
                Else
                    Exit Do
                End If
            Loop
        End Using
    End Function

    ' Handles the click event for the Previous button
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        If currentIndex > 0 Then
            currentIndex -= 1
            DisplaySubmission(submissions(currentIndex))
        End If
    End Sub

    ' Handles the click event for the Next button
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If currentIndex < submissions.Count - 1 Then
            currentIndex += 1
            DisplaySubmission(submissions(currentIndex))
        End If
    End Sub

    ' Updates the form fields to display the current submission
    Private Sub DisplaySubmission(submission As Submission)
        txtName.Text = submission.Name
        txtEmail.Text = submission.Email
        txtPhoneNumber.Text = submission.PhoneNumber
        txtGithubLink.Text = submission.GitHubLink
        lblStopwatch.Text = submission.StopwatchTime
    End Sub
    Private Async Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If submissions.Count = 0 Then
            MessageBox.Show("No submissions to delete.")
            Return
        End If

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this submission?", "Confirm Delete", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.DeleteAsync($"http://localhost:3000/delete?index={currentIndex}")
                If response.IsSuccessStatusCode Then
                    submissions.RemoveAt(currentIndex)
                    If currentIndex >= submissions.Count Then
                        currentIndex = submissions.Count - 1
                    End If

                    If submissions.Count > 0 Then
                        DisplaySubmission(submissions(currentIndex))
                    Else

                        txtName.Clear()
                        txtEmail.Clear()
                        txtPhoneNumber.Clear()
                        txtGithubLink.Clear()
                        lblStopwatch.Text = ""
                    End If

                    MessageBox.Show("Submission deleted successfully.")
                Else
                    MessageBox.Show("Failed to delete the submission.")
                End If
            End Using
        End If
    End Sub
    Private Async Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim updatedSubmission As New Submission With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .PhoneNumber = txtPhoneNumber.Text,
            .GitHubLink = txtGithubLink.Text,
            .StopwatchTime = lblStopwatch.Text
        }

        Dim json As String = JsonConvert.SerializeObject(updatedSubmission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.PutAsync($"http://localhost:3000/update?index={currentIndex}", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Update successful!")
                submissions(currentIndex) = updatedSubmission
            Else
                MessageBox.Show("Update failed.")
            End If
        End Using
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class

