<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SubmissionForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        components = New ComponentModel.Container()
        lblName = New Label()
        txtName = New TextBox()
        lblEmail = New Label()
        txtEmail = New TextBox()
        lblPhoneNumber = New Label()
        txtPhoneNumber = New TextBox()
        lblGitHubLink = New Label()
        txtGitHubLink = New TextBox()
        btnToggleStopwatch = New Button()
        lblStopwatch = New Label()
        stopwatchTimer = New Timer(components)
        btnSubmit = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblName.Location = New Point(57, 108)
        lblName.Name = "lblName"
        lblName.Size = New Size(57, 21)
        lblName.TabIndex = 1
        lblName.Text = "Name:"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(150, 106)
        txtName.Name = "txtName"
        txtName.Size = New Size(277, 25)
        txtName.TabIndex = 2
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblEmail.Location = New Point(57, 163)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(52, 21)
        lblEmail.TabIndex = 3
        lblEmail.Text = "Email:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI Semibold", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(150, 161)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(277, 23)
        txtEmail.TabIndex = 4
        ' 
        ' lblPhoneNumber
        ' 
        lblPhoneNumber.AutoSize = True
        lblPhoneNumber.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblPhoneNumber.Location = New Point(36, 220)
        lblPhoneNumber.Name = "lblPhoneNumber"
        lblPhoneNumber.Size = New Size(99, 21)
        lblPhoneNumber.TabIndex = 5
        lblPhoneNumber.Text = "Phone Num:"
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPhoneNumber.Location = New Point(150, 218)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(277, 25)
        txtPhoneNumber.TabIndex = 6
        ' 
        ' lblGitHubLink
        ' 
        lblGitHubLink.AutoSize = True
        lblGitHubLink.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGitHubLink.Location = New Point(36, 283)
        lblGitHubLink.Name = "lblGitHubLink"
        lblGitHubLink.Size = New Size(97, 21)
        lblGitHubLink.TabIndex = 7
        lblGitHubLink.Text = "Github Link:"
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtGitHubLink.Location = New Point(150, 281)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.Size = New Size(277, 25)
        txtGitHubLink.TabIndex = 8
        ' 
        ' btnToggleStopwatch
        ' 
        btnToggleStopwatch.Location = New Point(36, 374)
        btnToggleStopwatch.Name = "btnToggleStopwatch"
        btnToggleStopwatch.Size = New Size(314, 23)
        btnToggleStopwatch.TabIndex = 9
        btnToggleStopwatch.Text = "Toggle Stopwatch(CTRL +T or Left Mouse/Double Click" & vbCrLf & ") " & vbCrLf
        btnToggleStopwatch.UseVisualStyleBackColor = True
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStopwatch.Location = New Point(420, 374)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(72, 21)
        lblStopwatch.TabIndex = 10
        lblStopwatch.Text = "00:00:00"
        ' 
        ' stopwatchTimer
        ' 
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(36, 468)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(519, 33)
        btnSubmit.TabIndex = 11
        btnSubmit.Text = "Submit(CTRL +S)"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Emoji", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(94, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(398, 21)
        Label1.TabIndex = 12
        Label1.Text = "Arpit Kumar,Slidely 2nd Assignment Slidely Form"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 522)
        Label2.Name = "Label2"
        Label2.Size = New Size(575, 15)
        Label2.TabIndex = 13
        Label2.Text = "Note: This is added to last of an array in db.json so the latest submission shows up at last in view submission"
        ' 
        ' SubmissionForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(592, 546)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnSubmit)
        Controls.Add(lblStopwatch)
        Controls.Add(btnToggleStopwatch)
        Controls.Add(txtGitHubLink)
        Controls.Add(lblGitHubLink)
        Controls.Add(txtPhoneNumber)
        Controls.Add(lblPhoneNumber)
        Controls.Add(txtEmail)
        Controls.Add(lblEmail)
        Controls.Add(txtName)
        Controls.Add(lblName)
        Name = "SubmissionForm"
        Text = "SubmissionForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents lblGitHubLink As Label
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents btnToggleStopwatch As Button
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents stopwatchTimer As Timer
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
