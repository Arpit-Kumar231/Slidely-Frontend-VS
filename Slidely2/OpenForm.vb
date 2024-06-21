Imports System.Net.Http

Public Class OpenForm
    Private Sub OpenForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True



    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.N Then
            btnCreateNewSubmission.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.V Then
            btnViewSubmissions.PerformClick()
        End If
    End Sub
    Private Sub btnCreateNewSubmission_Click(sender As Object, e As EventArgs) Handles btnCreateNewSubmission.Click
        Dim submissionForm As New SubmissionForm()
        submissionForm.ShowDialog()
    End Sub

    Private Sub btnViewSubmissions_Click(sender As Object, e As EventArgs) Handles btnViewSubmissions.Click
        Dim viewSubmissionsForm As New ViewSubmissionsForm()
        viewSubmissionsForm.ShowDialog()
    End Sub
    Private Async Sub btnPing_Click(sender As Object, e As EventArgs)
        Await PingServerAsync()
    End Sub

    Private Async Function PingServerAsync() As Task
        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/ping")
            If response.IsSuccessStatusCode Then
                Dim result As String = Await response.Content.ReadAsStringAsync()
                MessageBox.Show("Success")
            Else
                MessageBox.Show("Failed to ping the server.")
            End If
        End Using
    End Function


End Class

