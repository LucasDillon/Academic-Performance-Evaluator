<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_menu
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
        Me.btn_createClass = New System.Windows.Forms.Button()
        Me.lbl_classListLabel = New System.Windows.Forms.Label()
        Me.btn_viewClass = New System.Windows.Forms.Button()
        Me.lbx_classList = New System.Windows.Forms.ListBox()
        Me.btn_exit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_createClass
        '
        Me.btn_createClass.Location = New System.Drawing.Point(334, 93)
        Me.btn_createClass.Name = "btn_createClass"
        Me.btn_createClass.Size = New System.Drawing.Size(163, 64)
        Me.btn_createClass.TabIndex = 8
        Me.btn_createClass.Text = "Create New Class"
        Me.btn_createClass.UseVisualStyleBackColor = True
        '
        'lbl_classListLabel
        '
        Me.lbl_classListLabel.AutoSize = True
        Me.lbl_classListLabel.Location = New System.Drawing.Point(9, 7)
        Me.lbl_classListLabel.Name = "lbl_classListLabel"
        Me.lbl_classListLabel.Size = New System.Drawing.Size(68, 13)
        Me.lbl_classListLabel.TabIndex = 7
        Me.lbl_classListLabel.Text = "Your Classes"
        '
        'btn_viewClass
        '
        Me.btn_viewClass.Location = New System.Drawing.Point(333, 23)
        Me.btn_viewClass.Name = "btn_viewClass"
        Me.btn_viewClass.Size = New System.Drawing.Size(164, 64)
        Me.btn_viewClass.TabIndex = 6
        Me.btn_viewClass.Text = "View Class"
        Me.btn_viewClass.UseVisualStyleBackColor = True
        '
        'lbx_classList
        '
        Me.lbx_classList.FormattingEnabled = True
        Me.lbx_classList.Location = New System.Drawing.Point(12, 23)
        Me.lbx_classList.Name = "lbx_classList"
        Me.lbx_classList.Size = New System.Drawing.Size(315, 407)
        Me.lbx_classList.TabIndex = 5
        '
        'btn_exit
        '
        Me.btn_exit.Location = New System.Drawing.Point(407, 394)
        Me.btn_exit.Name = "btn_exit"
        Me.btn_exit.Size = New System.Drawing.Size(90, 36)
        Me.btn_exit.TabIndex = 9
        Me.btn_exit.Text = "Exit"
        Me.btn_exit.UseVisualStyleBackColor = True
        '
        'frm_menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 440)
        Me.Controls.Add(Me.btn_exit)
        Me.Controls.Add(Me.btn_createClass)
        Me.Controls.Add(Me.lbl_classListLabel)
        Me.Controls.Add(Me.btn_viewClass)
        Me.Controls.Add(Me.lbx_classList)
        Me.Name = "frm_menu"
        Me.Text = "Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_createClass As Button
    Friend WithEvents lbl_classListLabel As Label
    Friend WithEvents btn_viewClass As Button
    Friend WithEvents lbx_classList As ListBox
    Friend WithEvents btn_exit As Button
End Class
