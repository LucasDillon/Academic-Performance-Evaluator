<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_logIn
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbx_teacherIdEntry = New System.Windows.Forms.TextBox()
        Me.tbx_passwordEntry = New System.Windows.Forms.TextBox()
        Me.lbl_teacherIdEntryLabel = New System.Windows.Forms.Label()
        Me.lbl_passwordEntryLabel = New System.Windows.Forms.Label()
        Me.btn_logIn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbx_teacherIdEntry
        '
        Me.tbx_teacherIdEntry.Location = New System.Drawing.Point(112, 39)
        Me.tbx_teacherIdEntry.Name = "tbx_teacherIdEntry"
        Me.tbx_teacherIdEntry.Size = New System.Drawing.Size(200, 20)
        Me.tbx_teacherIdEntry.TabIndex = 1
        '
        'tbx_passwordEntry
        '
        Me.tbx_passwordEntry.Location = New System.Drawing.Point(112, 70)
        Me.tbx_passwordEntry.Name = "tbx_passwordEntry"
        Me.tbx_passwordEntry.Size = New System.Drawing.Size(199, 20)
        Me.tbx_passwordEntry.TabIndex = 2
        Me.tbx_passwordEntry.UseSystemPasswordChar = True
        '
        'lbl_teacherIdEntryLabel
        '
        Me.lbl_teacherIdEntryLabel.AutoSize = True
        Me.lbl_teacherIdEntryLabel.Location = New System.Drawing.Point(45, 42)
        Me.lbl_teacherIdEntryLabel.Name = "lbl_teacherIdEntryLabel"
        Me.lbl_teacherIdEntryLabel.Size = New System.Drawing.Size(61, 13)
        Me.lbl_teacherIdEntryLabel.TabIndex = 4
        Me.lbl_teacherIdEntryLabel.Text = "Teacher ID"
        '
        'lbl_passwordEntryLabel
        '
        Me.lbl_passwordEntryLabel.AutoSize = True
        Me.lbl_passwordEntryLabel.Location = New System.Drawing.Point(53, 73)
        Me.lbl_passwordEntryLabel.Name = "lbl_passwordEntryLabel"
        Me.lbl_passwordEntryLabel.Size = New System.Drawing.Size(53, 13)
        Me.lbl_passwordEntryLabel.TabIndex = 5
        Me.lbl_passwordEntryLabel.Text = "Password"
        '
        'btn_logIn
        '
        Me.btn_logIn.Location = New System.Drawing.Point(112, 106)
        Me.btn_logIn.Name = "btn_logIn"
        Me.btn_logIn.Size = New System.Drawing.Size(198, 33)
        Me.btn_logIn.TabIndex = 6
        Me.btn_logIn.Text = "Log In"
        Me.btn_logIn.UseVisualStyleBackColor = True
        '
        'frm_logIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(417, 160)
        Me.Controls.Add(Me.btn_logIn)
        Me.Controls.Add(Me.lbl_passwordEntryLabel)
        Me.Controls.Add(Me.lbl_teacherIdEntryLabel)
        Me.Controls.Add(Me.tbx_passwordEntry)
        Me.Controls.Add(Me.tbx_teacherIdEntry)
        Me.Name = "frm_logIn"
        Me.Text = "Log In"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbx_teacherIdEntry As TextBox
    Friend WithEvents tbx_passwordEntry As TextBox
    Friend WithEvents lbl_teacherIdEntryLabel As Label
    Friend WithEvents lbl_passwordEntryLabel As Label
    Friend WithEvents btn_logIn As Button
End Class
