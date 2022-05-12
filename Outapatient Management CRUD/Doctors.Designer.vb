<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Doctors
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
        Me.DoctorDataGridView = New System.Windows.Forms.DataGridView()
        Me.AddFname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddLname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AddSpec = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AddContact = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.EditDeleteBtn = New System.Windows.Forms.Button()
        Me.EditSaveBtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.EditContact = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.EditSpecialization = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.EditLname = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.EditFname = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.EditCancelBtn = New System.Windows.Forms.Button()
        CType(Me.DoctorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DoctorDataGridView
        '
        Me.DoctorDataGridView.AllowUserToAddRows = False
        Me.DoctorDataGridView.AllowUserToDeleteRows = False
        Me.DoctorDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DoctorDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DoctorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DoctorDataGridView.Location = New System.Drawing.Point(13, 56)
        Me.DoctorDataGridView.Name = "DoctorDataGridView"
        Me.DoctorDataGridView.ReadOnly = True
        Me.DoctorDataGridView.Size = New System.Drawing.Size(1049, 282)
        Me.DoctorDataGridView.TabIndex = 0
        '
        'AddFname
        '
        Me.AddFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddFname.Location = New System.Drawing.Point(167, 395)
        Me.AddFname.Name = "AddFname"
        Me.AddFname.Size = New System.Drawing.Size(212, 31)
        Me.AddFname.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(56, 398)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Firstname"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(54, 445)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 25)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Lastname"
        '
        'AddLname
        '
        Me.AddLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddLname.Location = New System.Drawing.Point(167, 442)
        Me.AddLname.Name = "AddLname"
        Me.AddLname.Size = New System.Drawing.Size(212, 31)
        Me.AddLname.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(15, 493)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Specialization"
        '
        'AddSpec
        '
        Me.AddSpec.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddSpec.Location = New System.Drawing.Point(167, 493)
        Me.AddSpec.Name = "AddSpec"
        Me.AddSpec.Size = New System.Drawing.Size(212, 31)
        Me.AddSpec.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(74, 551)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 25)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Contact"
        '
        'AddContact
        '
        Me.AddContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddContact.Location = New System.Drawing.Point(167, 548)
        Me.AddContact.Name = "AddContact"
        Me.AddContact.Size = New System.Drawing.Size(212, 31)
        Me.AddContact.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(167, 610)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 25)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Doctors"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.IndianRed
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(284, 610)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 35)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'EditDeleteBtn
        '
        Me.EditDeleteBtn.BackColor = System.Drawing.Color.IndianRed
        Me.EditDeleteBtn.FlatAppearance.BorderSize = 0
        Me.EditDeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditDeleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditDeleteBtn.ForeColor = System.Drawing.Color.White
        Me.EditDeleteBtn.Location = New System.Drawing.Point(904, 604)
        Me.EditDeleteBtn.Name = "EditDeleteBtn"
        Me.EditDeleteBtn.Size = New System.Drawing.Size(95, 35)
        Me.EditDeleteBtn.TabIndex = 41
        Me.EditDeleteBtn.Text = "Delete"
        Me.EditDeleteBtn.UseVisualStyleBackColor = False
        '
        'EditSaveBtn
        '
        Me.EditSaveBtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.EditSaveBtn.FlatAppearance.BorderSize = 0
        Me.EditSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditSaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditSaveBtn.ForeColor = System.Drawing.Color.White
        Me.EditSaveBtn.Location = New System.Drawing.Point(787, 604)
        Me.EditSaveBtn.Name = "EditSaveBtn"
        Me.EditSaveBtn.Size = New System.Drawing.Size(95, 35)
        Me.EditSaveBtn.TabIndex = 40
        Me.EditSaveBtn.Text = "Save"
        Me.EditSaveBtn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(694, 545)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 25)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Contact"
        '
        'EditContact
        '
        Me.EditContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditContact.Location = New System.Drawing.Point(787, 542)
        Me.EditContact.Name = "EditContact"
        Me.EditContact.Size = New System.Drawing.Size(212, 31)
        Me.EditContact.TabIndex = 38
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.Location = New System.Drawing.Point(635, 487)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(146, 25)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Specialization"
        '
        'EditSpecialization
        '
        Me.EditSpecialization.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditSpecialization.Location = New System.Drawing.Point(787, 487)
        Me.EditSpecialization.Name = "EditSpecialization"
        Me.EditSpecialization.Size = New System.Drawing.Size(212, 31)
        Me.EditSpecialization.TabIndex = 36
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label8.Location = New System.Drawing.Point(674, 439)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(106, 25)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "Lastname"
        '
        'EditLname
        '
        Me.EditLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditLname.Location = New System.Drawing.Point(787, 436)
        Me.EditLname.Name = "EditLname"
        Me.EditLname.Size = New System.Drawing.Size(212, 31)
        Me.EditLname.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label9.Location = New System.Drawing.Point(676, 392)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(107, 25)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "Firstname"
        '
        'EditFname
        '
        Me.EditFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditFname.Location = New System.Drawing.Point(787, 389)
        Me.EditFname.Name = "EditFname"
        Me.EditFname.Size = New System.Drawing.Size(212, 31)
        Me.EditFname.TabIndex = 32
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label14.Location = New System.Drawing.Point(853, 341)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 25)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "EDIT"
        '
        'EditCancelBtn
        '
        Me.EditCancelBtn.BackColor = System.Drawing.Color.Gray
        Me.EditCancelBtn.FlatAppearance.BorderSize = 0
        Me.EditCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditCancelBtn.ForeColor = System.Drawing.Color.White
        Me.EditCancelBtn.Location = New System.Drawing.Point(1018, 604)
        Me.EditCancelBtn.Name = "EditCancelBtn"
        Me.EditCancelBtn.Size = New System.Drawing.Size(95, 35)
        Me.EditCancelBtn.TabIndex = 43
        Me.EditCancelBtn.Text = "Cancel"
        Me.EditCancelBtn.UseVisualStyleBackColor = False
        '
        'Doctors
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1121, 696)
        Me.Controls.Add(Me.EditCancelBtn)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.EditDeleteBtn)
        Me.Controls.Add(Me.EditSaveBtn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.EditContact)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.EditSpecialization)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.EditLname)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.EditFname)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.AddContact)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.AddSpec)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.AddLname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddFname)
        Me.Controls.Add(Me.DoctorDataGridView)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Doctors"
        Me.Text = "Doctors"
        CType(Me.DoctorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DoctorDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents AddFname As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AddLname As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AddSpec As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AddContact As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents EditDeleteBtn As System.Windows.Forms.Button
    Friend WithEvents EditSaveBtn As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents EditContact As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents EditSpecialization As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents EditLname As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents EditFname As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents EditCancelBtn As System.Windows.Forms.Button
End Class
