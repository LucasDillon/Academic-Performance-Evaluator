<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_createClass
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
        Me.tbx_classNameEntryBox = New System.Windows.Forms.TextBox()
        Me.tbx_classSubjectEntryBox = New System.Windows.Forms.TextBox()
        Me.lbl_classNameEntryBoxLabel = New System.Windows.Forms.Label()
        Me.lbl_classSubjectEntryBoxLabel = New System.Windows.Forms.Label()
        Me.btn_createClass = New System.Windows.Forms.Button()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbx_classNameEntryBox
        '
        Me.tbx_classNameEntryBox.Location = New System.Drawing.Point(88, 30)
        Me.tbx_classNameEntryBox.Name = "tbx_classNameEntryBox"
        Me.tbx_classNameEntryBox.Size = New System.Drawing.Size(161, 20)
        Me.tbx_classNameEntryBox.TabIndex = 1
        '
        'tbx_classSubjectEntryBox
        '
        Me.tbx_classSubjectEntryBox.Location = New System.Drawing.Point(89, 56)
        Me.tbx_classSubjectEntryBox.Name = "tbx_classSubjectEntryBox"
        Me.tbx_classSubjectEntryBox.Size = New System.Drawing.Size(161, 20)
        Me.tbx_classSubjectEntryBox.TabIndex = 2
        '
        'lbl_classNameEntryBoxLabel
        '
        Me.lbl_classNameEntryBoxLabel.AutoSize = True
        Me.lbl_classNameEntryBoxLabel.Location = New System.Drawing.Point(19, 33)
        Me.lbl_classNameEntryBoxLabel.Name = "lbl_classNameEntryBoxLabel"
        Me.lbl_classNameEntryBoxLabel.Size = New System.Drawing.Size(63, 13)
        Me.lbl_classNameEntryBoxLabel.TabIndex = 5
        Me.lbl_classNameEntryBoxLabel.Text = "Class Name"
        '
        'lbl_classSubjectEntryBoxLabel
        '
        Me.lbl_classSubjectEntryBoxLabel.AutoSize = True
        Me.lbl_classSubjectEntryBoxLabel.Location = New System.Drawing.Point(40, 59)
        Me.lbl_classSubjectEntryBoxLabel.Name = "lbl_classSubjectEntryBoxLabel"
        Me.lbl_classSubjectEntryBoxLabel.Size = New System.Drawing.Size(43, 13)
        Me.lbl_classSubjectEntryBoxLabel.TabIndex = 4
        Me.lbl_classSubjectEntryBoxLabel.Text = "Subject"
        '
        'btn_createClass
        '
        Me.btn_createClass.Location = New System.Drawing.Point(89, 82)
        Me.btn_createClass.Name = "btn_createClass"
        Me.btn_createClass.Size = New System.Drawing.Size(160, 36)
        Me.btn_createClass.TabIndex = 6
        Me.btn_createClass.Text = "Create"
        Me.btn_createClass.UseVisualStyleBackColor = True
        '
        'btn_cancel
        '
        Me.btn_cancel.Location = New System.Drawing.Point(242, 124)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(88, 33)
        Me.btn_cancel.TabIndex = 7
        Me.btn_cancel.Text = "Cancel"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'frm_createClass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(334, 167)
        Me.Controls.Add(Me.btn_cancel)
        Me.Controls.Add(Me.btn_createClass)
        Me.Controls.Add(Me.lbl_classNameEntryBoxLabel)
        Me.Controls.Add(Me.lbl_classSubjectEntryBoxLabel)
        Me.Controls.Add(Me.tbx_classSubjectEntryBox)
        Me.Controls.Add(Me.tbx_classNameEntryBox)
        Me.Name = "frm_createClass"
        Me.Text = "New Class"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbx_classNameEntryBox As TextBox
    Friend WithEvents tbx_classSubjectEntryBox As TextBox
    Friend WithEvents lbl_classNameEntryBoxLabel As Label
    Friend WithEvents lbl_classSubjectEntryBoxLabel As Label
    Friend WithEvents btn_createClass As Button
    Friend WithEvents btn_cancel As Button
End Class
