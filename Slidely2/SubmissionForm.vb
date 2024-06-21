Imports System.Net.Http
Imports System.Text
Imports Newtonsoft.Json

Public Class SubmissionForm
    Private stopwatchRunning As Boolean = False
    Private stopwatchStartTime As DateTime
    Private stopwatchElapsed As TimeSpan = TimeSpan.Zero
    Private Sub SubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Me.BackColor = ColorTranslator.FromHtml("#121212")
        Me.ForeColor = ColorTranslator.FromHtml("#E0E0E0")



        txtName.BackColor = ColorTranslator.FromHtml("#2C2C2C")
        txtName.ForeColor = ColorTranslator.FromHtml("#E0E0E0")
        txtEmail.BackColor = ColorTranslator.FromHtml("#2C2C2C")
        txtEmail.ForeColor = ColorTranslator.FromHtml("#E0E0E0")
        txtPhoneNumber.BackColor = ColorTranslator.FromHtml("#2C2C2C")
        txtPhoneNumber.ForeColor = ColorTranslator.FromHtml("#E0E0E0")
        txtGitHubLink.BackColor = ColorTranslator.FromHtml("#2C2C2C")
        txtGitHubLink.ForeColor = ColorTranslator.FromHtml("#E0E0E0")

        ' Label properties
        lblName.ForeColor = ColorTranslator.FromHtml("#E0E0E0")
        lblEmail.ForeColor = ColorTranslator.FromHtml("#E0E0E0")
        lblPhoneNumber.ForeColor = ColorTranslator.FromHtml("#E0E0E0")
        lblGitHubLink.ForeColor = ColorTranslator.FromHtml("#E0E0E0")
        lblStopwatch.ForeColor = ColorTranslator.FromHtml("#E0E0E0")

        ' Button properties
        btnSubmit.BackColor = ColorTranslator.FromHtml("#3D3C42")
        btnSubmit.ForeColor = ColorTranslator.FromHtml("#FFFFFF")
        btnToggleStopwatch.BackColor = ColorTranslator.FromHtml("#3D3C42")
        btnToggleStopwatch.ForeColor = ColorTranslator.FromHtml("#FFFFFF")


    End Sub
    Private Sub SubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnToggleStopwatch.PerformClick()
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick()
        End If
    End Sub


    Public Sub New()

        InitializeComponent()


        stopwatchTimer.Interval = 1000 ' 1 second
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Submission With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .PhoneNumber = txtPhoneNumber.Text,
            .GitHubLink = txtGitHubLink.Text,
            .StopwatchTime = lblStopwatch.Text
        }

        Dim json As String = JsonConvert.SerializeObject(submission)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Using client As New HttpClient()
            Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission successful!")
            Else
                MessageBox.Show("Submission failed.")
            End If
        End Using

        Me.Close()
    End Sub

    Private Sub btnToggleStopwatch_Click(sender As Object, e As EventArgs) Handles btnToggleStopwatch.Click
        If stopwatchRunning Then
            stopwatchTimer.Stop()
            stopwatchElapsed += DateTime.Now - stopwatchStartTime
            btnToggleStopwatch.Text = "TOGGLE STOPWATCH (CTRL + T)"
        Else
            stopwatchStartTime = DateTime.Now
            stopwatchTimer.Start()
            btnToggleStopwatch.Text = "STOP STOPWATCH (CTRL + T)"
        End If
        stopwatchRunning = Not stopwatchRunning
    End Sub

    Private Sub stopwatchTimer_Tick(sender As Object, e As EventArgs) Handles stopwatchTimer.Tick
        UpdateStopwatchDisplay()
    End Sub

    Private Sub UpdateStopwatchDisplay()
        Dim elapsed As TimeSpan
        If stopwatchRunning Then
            elapsed = stopwatchElapsed + (DateTime.Now - stopwatchStartTime)
        Else
            elapsed = stopwatchElapsed
        End If
        lblStopwatch.Text = elapsed.ToString("hh\:mm\:ss")
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneNumber.TextChanged

    End Sub
End Class

Public Class Submission
    Public Property Name As String
    Public Property Email As String
    Public Property PhoneNumber As String
    Public Property GitHubLink As String
    Public Property StopwatchTime As String
End Class