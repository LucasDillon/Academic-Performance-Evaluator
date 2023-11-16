<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_classView
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
        Me.btn_removeClass = New System.Windows.Forms.Button()
        Me.btn_toMenu = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btn_removeClass
        '
        Me.btn_removeClass.Location = New System.Drawing.Point(644, 12)
        Me.btn_removeClass.Name = "btn_removeClass"
        Me.btn_removeClass.Size = New System.Drawing.Size(144, 58)
        Me.btn_removeClass.TabIndex = 2
        Me.btn_removeClass.Text = "Remove Class"
        Me.btn_removeClass.UseVisualStyleBackColor = True
        '
        'btn_toMenu
        '
        Me.btn_toMenu.Location = New System.Drawing.Point(698, 402)
        Me.btn_toMenu.Name = "btn_toMenu"
        Me.btn_toMenu.Size = New System.Drawing.Size(90, 36)
        Me.btn_toMenu.TabIndex = 3
        Me.btn_toMenu.Text = "Return to Menu"
        Me.btn_toMenu.UseVisualStyleBackColor = True
        '
        'frm_classView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btn_toMenu)
        Me.Controls.Add(Me.btn_removeClass)
        Me.Name = "frm_classView"
        Me.Text = "Class View"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_removeClass As Button
    Friend WithEvents btn_toMenu As Button
End Class
