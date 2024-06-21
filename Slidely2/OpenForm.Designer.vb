<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class OpenForm
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
        btnViewSubmissions = New Button()
        btnCreateNewSubmission = New Button()
        TextBox1 = New TextBox()
        SuspendLayout()
        ' 
        ' btnViewSubmissions
        ' 
        btnViewSubmissions.BackColor = Color.Black
        btnViewSubmissions.Font = New Font("Book Antiqua", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnViewSubmissions.ForeColor = SystemColors.ButtonHighlight
        btnViewSubmissions.Location = New Point(181, 153)
        btnViewSubmissions.Name = "btnViewSubmissions"
        btnViewSubmissions.Size = New Size(509, 43)
        btnViewSubmissions.TabIndex = 0
        btnViewSubmissions.Text = "VIEW SUBMISSIONS (CTRL + V)" & vbCrLf
        btnViewSubmissions.UseVisualStyleBackColor = False
        ' 
        ' btnCreateNewSubmission
        ' 
        btnCreateNewSubmission.BackColor = SystemColors.Desktop
        btnCreateNewSubmission.Font = New Font("STZhongsong", 11.9999981F, FontStyle.Bold, GraphicsUnit.Point, CByte(134))
        btnCreateNewSubmission.ForeColor = SystemColors.ButtonHighlight
        btnCreateNewSubmission.Location = New Point(181, 275)
        btnCreateNewSubmission.Name = "btnCreateNewSubmission"
        btnCreateNewSubmission.Size = New Size(509, 42)
        btnCreateNewSubmission.TabIndex = 1
        btnCreateNewSubmission.Text = "CREATE NEW SUBMISSION (CTRL + N)"
        btnCreateNewSubmission.UseVisualStyleBackColor = False
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.Info
        TextBox1.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        TextBox1.Location = New Point(181, 58)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(509, 29)
        TextBox1.TabIndex = 2
        TextBox1.Text = "Arpit Kumar,Slidely Task 2 - Slidely Form App"
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' OpenForm
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaptionText
        ClientSize = New Size(835, 450)
        Controls.Add(TextBox1)
        Controls.Add(btnCreateNewSubmission)
        Controls.Add(btnViewSubmissions)
        ForeColor = SystemColors.ActiveCaption
        Name = "OpenForm"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnViewSubmissions As Button
    Friend WithEvents btnCreateNewSubmission As Button
    Friend WithEvents TextBox1 As TextBox

End Class
