<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EditNameBtn = New System.Windows.Forms.Button()
        Me.NewPassword = New System.Windows.Forms.TextBox()
        Me.NewPasswordTxt = New System.Windows.Forms.Label()
        Me.CurrentPassword = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ConfirmPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(689, 48)
        Me.Panel1.TabIndex = 67
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(202, 25)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Change Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(632, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 25)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "x"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(606, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(20, 25)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "-"
        '
        'EditNameBtn
        '
        Me.EditNameBtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.EditNameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditNameBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditNameBtn.ForeColor = System.Drawing.Color.White
        Me.EditNameBtn.Location = New System.Drawing.Point(300, 326)
        Me.EditNameBtn.Name = "EditNameBtn"
        Me.EditNameBtn.Size = New System.Drawing.Size(143, 39)
        Me.EditNameBtn.TabIndex = 72
        Me.EditNameBtn.Text = "Change Password"
        Me.EditNameBtn.UseVisualStyleBackColor = False
        '
        'NewPassword
        '
        Me.NewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPassword.Location = New System.Drawing.Point(207, 190)
        Me.NewPassword.Name = "NewPassword"
        Me.NewPassword.Size = New System.Drawing.Size(236, 29)
        Me.NewPassword.TabIndex = 71
        '
        'NewPasswordTxt
        '
        Me.NewPasswordTxt.AutoSize = True
        Me.NewPasswordTxt.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewPasswordTxt.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.NewPasswordTxt.Location = New System.Drawing.Point(202, 157)
        Me.NewPasswordTxt.Name = "NewPasswordTxt"
        Me.NewPasswordTxt.Size = New System.Drawing.Size(153, 30)
        Me.NewPasswordTxt.TabIndex = 70
        Me.NewPasswordTxt.Text = "New Password"
        '
        'CurrentPassword
        '
        Me.CurrentPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CurrentPassword.Location = New System.Drawing.Point(207, 117)
        Me.CurrentPassword.Name = "CurrentPassword"
        Me.CurrentPassword.Size = New System.Drawing.Size(236, 29)
        Me.CurrentPassword.TabIndex = 69
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(202, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 30)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Current Password"
        '
        'ConfirmPassword
        '
        Me.ConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConfirmPassword.Location = New System.Drawing.Point(207, 260)
        Me.ConfirmPassword.Name = "ConfirmPassword"
        Me.ConfirmPassword.Size = New System.Drawing.Size(236, 29)
        Me.ConfirmPassword.TabIndex = 74
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(202, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(181, 30)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "ConfirmPassword"
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(689, 427)
        Me.Controls.Add(Me.ConfirmPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.EditNameBtn)
        Me.Controls.Add(Me.NewPassword)
        Me.Controls.Add(Me.NewPasswordTxt)
        Me.Controls.Add(Me.CurrentPassword)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ChangePassword"
        Me.Text = "ChangePassword"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents EditNameBtn As System.Windows.Forms.Button
    Friend WithEvents NewPassword As System.Windows.Forms.TextBox
    Friend WithEvents NewPasswordTxt As System.Windows.Forms.Label
    Friend WithEvents CurrentPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ConfirmPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
