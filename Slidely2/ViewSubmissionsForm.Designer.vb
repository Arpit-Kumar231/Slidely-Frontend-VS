<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
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
        lblName = New Label()
        txtName = New TextBox()
        Label1 = New Label()
        txtEmail = New TextBox()
        Label2 = New Label()
        txtPhoneNumber = New TextBox()
        lblGithubLink = New Label()
        txtGithubLink = New TextBox()
        Label3 = New Label()
        lblStopwatch = New Label()
        btnPrevious = New Button()
        btnNext = New Button()
        btnDelete = New Button()
        Label4 = New Label()
        btnUpdate = New Button()
        Label5 = New Label()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Font = New Font("Segoe UI Semibold", 12.0F)
        lblName.Location = New Point(58, 74)
        lblName.Name = "lblName"
        lblName.Size = New Size(57, 21)
        lblName.TabIndex = 0
        lblName.Text = "Name:"
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.Info
        txtName.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtName.Location = New Point(150, 76)
        txtName.Name = "txtName"
        txtName.Size = New Size(299, 25)
        txtName.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(58, 118)
        Label1.Name = "Label1"
        Label1.Size = New Size(52, 21)
        Label1.TabIndex = 2
        Label1.Text = "Email:"
        ' 
        ' txtEmail
        ' 
        txtEmail.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtEmail.Location = New Point(150, 116)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(299, 25)
        txtEmail.TabIndex = 3
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(41, 168)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 21)
        Label2.TabIndex = 4
        Label2.Text = "Phone No:"
        ' 
        ' txtPhoneNumber
        ' 
        txtPhoneNumber.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtPhoneNumber.Location = New Point(150, 166)
        txtPhoneNumber.Name = "txtPhoneNumber"
        txtPhoneNumber.Size = New Size(299, 25)
        txtPhoneNumber.TabIndex = 5
        ' 
        ' lblGithubLink
        ' 
        lblGithubLink.AutoSize = True
        lblGithubLink.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblGithubLink.Location = New Point(41, 215)
        lblGithubLink.Name = "lblGithubLink"
        lblGithubLink.Size = New Size(97, 21)
        lblGithubLink.TabIndex = 6
        lblGithubLink.Text = "Github Link:"
        ' 
        ' txtGithubLink
        ' 
        txtGithubLink.Font = New Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        txtGithubLink.Location = New Point(150, 213)
        txtGithubLink.Name = "txtGithubLink"
        txtGithubLink.Size = New Size(299, 25)
        txtGithubLink.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(58, 270)
        Label3.Name = "Label3"
        Label3.Size = New Size(50, 21)
        Label3.TabIndex = 8
        Label3.Text = "Time:"
        ' 
        ' lblStopwatch
        ' 
        lblStopwatch.AutoSize = True
        lblStopwatch.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblStopwatch.Location = New Point(150, 270)
        lblStopwatch.Name = "lblStopwatch"
        lblStopwatch.Size = New Size(72, 21)
        lblStopwatch.TabIndex = 9
        lblStopwatch.Text = "00:00:00"
        ' 
        ' btnPrevious
        ' 
        btnPrevious.Location = New Point(30, 392)
        btnPrevious.Name = "btnPrevious"
        btnPrevious.Size = New Size(192, 29)
        btnPrevious.TabIndex = 10
        btnPrevious.Text = "Previous(CTRL+P)"
        btnPrevious.UseVisualStyleBackColor = True
        ' 
        ' btnNext
        ' 
        btnNext.Location = New Point(337, 392)
        btnNext.Name = "btnNext"
        btnNext.Size = New Size(190, 29)
        btnNext.TabIndex = 11
        btnNext.Text = "Next(CTRL+ N)"
        btnNext.UseVisualStyleBackColor = True
        ' 
        ' btnDelete
        ' 
        btnDelete.Location = New Point(150, 466)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(260, 23)
        btnDelete.TabIndex = 12
        btnDelete.Text = "Delete Submission(CTRL +D)"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(30, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(488, 25)
        Label4.TabIndex = 13
        Label4.Text = "Arpit Kumar ,Slidely 2nd Assignment - View Submission"
        ' 
        ' btnUpdate
        ' 
        btnUpdate.Location = New Point(150, 427)
        btnUpdate.Name = "btnUpdate"
        btnUpdate.Size = New Size(260, 23)
        btnUpdate.TabIndex = 14
        btnUpdate.Text = "Update Submission(CTRL + U)"
        btnUpdate.UseVisualStyleBackColor = True
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(12, 492)
        Label5.Name = "Label5"
        Label5.Size = New Size(483, 15)
        Label5.TabIndex = 15
        Label5.Text = "Note: These fields have been changed from Read-Only to Writable as well to allow updates"
        ' 
        ' ViewSubmissionsForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.White
        ClientSize = New Size(562, 516)
        Controls.Add(Label5)
        Controls.Add(btnUpdate)
        Controls.Add(Label4)
        Controls.Add(btnDelete)
        Controls.Add(btnNext)
        Controls.Add(btnPrevious)
        Controls.Add(lblStopwatch)
        Controls.Add(Label3)
        Controls.Add(txtGithubLink)
        Controls.Add(lblGithubLink)
        Controls.Add(txtPhoneNumber)
        Controls.Add(Label2)
        Controls.Add(txtEmail)
        Controls.Add(Label1)
        Controls.Add(txtName)
        Controls.Add(lblName)
        ForeColor = SystemColors.ActiveCaptionText
        Name = "ViewSubmissionsForm"
        Text = "ViewSubmissionsForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPhoneNumber As TextBox
    Friend WithEvents lblGithubLink As Label
    Friend WithEvents txtGithubLink As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblStopwatch As Label
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents Label5 As Label
End Class
