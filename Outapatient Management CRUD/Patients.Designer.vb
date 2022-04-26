<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Patients
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
        Me.PatientDataGrid = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.SearchBtn = New System.Windows.Forms.Button()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FirstnameBox = New System.Windows.Forms.TextBox()
        Me.LastnameBox = New System.Windows.Forms.TextBox()
        Me.DOBPicker = New System.Windows.Forms.DateTimePicker()
        Me.MaleRadio = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.FemaleRadio = New System.Windows.Forms.RadioButton()
        Me.ContactBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CancelAddBtn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.EditContact = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.EditFemaleRadio = New System.Windows.Forms.RadioButton()
        Me.EditMaleRadio = New System.Windows.Forms.RadioButton()
        Me.EditDOB = New System.Windows.Forms.DateTimePicker()
        Me.EditLname = New System.Windows.Forms.TextBox()
        Me.EditFname = New System.Windows.Forms.TextBox()
        Me.EditSaveBtn = New System.Windows.Forms.Button()
        Me.EditCancelBtn = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.PatientDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PatientDataGrid
        '
        Me.PatientDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.PatientDataGrid.BackgroundColor = System.Drawing.SystemColors.ControlLight
        Me.PatientDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PatientDataGrid.Location = New System.Drawing.Point(19, 53)
        Me.PatientDataGrid.Name = "PatientDataGrid"
        Me.PatientDataGrid.Size = New System.Drawing.Size(1053, 237)
        Me.PatientDataGrid.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.PatientDataGrid)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1109, 308)
        Me.Panel2.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Patients"
        '
        'AddBtn
        '
        Me.AddBtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.ForeColor = System.Drawing.Color.White
        Me.AddBtn.Location = New System.Drawing.Point(171, 608)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(84, 39)
        Me.AddBtn.TabIndex = 3
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'SearchBtn
        '
        Me.SearchBtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBtn.ForeColor = System.Drawing.Color.White
        Me.SearchBtn.Location = New System.Drawing.Point(881, 307)
        Me.SearchBtn.Name = "SearchBtn"
        Me.SearchBtn.Size = New System.Drawing.Size(76, 39)
        Me.SearchBtn.TabIndex = 4
        Me.SearchBtn.Text = "Search"
        Me.SearchBtn.UseVisualStyleBackColor = False
        '
        'SearchBox
        '
        Me.SearchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox.Location = New System.Drawing.Point(34, 1)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(131, 35)
        Me.SearchBox.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.SearchBox)
        Me.Panel3.Location = New System.Drawing.Point(707, 308)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(168, 39)
        Me.Panel3.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "ID"
        '
        'FirstnameBox
        '
        Me.FirstnameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstnameBox.Location = New System.Drawing.Point(171, 360)
        Me.FirstnameBox.Name = "FirstnameBox"
        Me.FirstnameBox.Size = New System.Drawing.Size(217, 31)
        Me.FirstnameBox.TabIndex = 7
        '
        'LastnameBox
        '
        Me.LastnameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LastnameBox.Location = New System.Drawing.Point(171, 409)
        Me.LastnameBox.Name = "LastnameBox"
        Me.LastnameBox.Size = New System.Drawing.Size(217, 31)
        Me.LastnameBox.TabIndex = 8
        '
        'DOBPicker
        '
        Me.DOBPicker.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DOBPicker.Location = New System.Drawing.Point(171, 460)
        Me.DOBPicker.Name = "DOBPicker"
        Me.DOBPicker.Size = New System.Drawing.Size(217, 20)
        Me.DOBPicker.TabIndex = 9
        '
        'MaleRadio
        '
        Me.MaleRadio.AutoSize = True
        Me.MaleRadio.Location = New System.Drawing.Point(16, 18)
        Me.MaleRadio.Name = "MaleRadio"
        Me.MaleRadio.Size = New System.Drawing.Size(48, 17)
        Me.MaleRadio.TabIndex = 10
        Me.MaleRadio.TabStop = True
        Me.MaleRadio.Text = "Male"
        Me.MaleRadio.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.FemaleRadio)
        Me.GroupBox1.Controls.Add(Me.MaleRadio)
        Me.GroupBox1.Location = New System.Drawing.Point(171, 495)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(188, 46)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sex"
        '
        'FemaleRadio
        '
        Me.FemaleRadio.AutoSize = True
        Me.FemaleRadio.Location = New System.Drawing.Point(103, 18)
        Me.FemaleRadio.Name = "FemaleRadio"
        Me.FemaleRadio.Size = New System.Drawing.Size(59, 17)
        Me.FemaleRadio.TabIndex = 11
        Me.FemaleRadio.TabStop = True
        Me.FemaleRadio.Text = "Female"
        Me.FemaleRadio.UseVisualStyleBackColor = True
        '
        'ContactBox
        '
        Me.ContactBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContactBox.Location = New System.Drawing.Point(171, 557)
        Me.ContactBox.Name = "ContactBox"
        Me.ContactBox.Size = New System.Drawing.Size(217, 31)
        Me.ContactBox.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(62, 360)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(107, 25)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Firstname"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(62, 412)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 25)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Lastname"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(63, 455)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 25)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Birthdate"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.Location = New System.Drawing.Point(62, 506)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 25)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Sex"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label8.Location = New System.Drawing.Point(62, 557)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 25)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Contact"
        '
        'CancelAddBtn
        '
        Me.CancelAddBtn.BackColor = System.Drawing.Color.IndianRed
        Me.CancelAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CancelAddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CancelAddBtn.ForeColor = System.Drawing.Color.White
        Me.CancelAddBtn.Location = New System.Drawing.Point(304, 608)
        Me.CancelAddBtn.Name = "CancelAddBtn"
        Me.CancelAddBtn.Size = New System.Drawing.Size(84, 39)
        Me.CancelAddBtn.TabIndex = 18
        Me.CancelAddBtn.Text = "Cancel"
        Me.CancelAddBtn.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label9.Location = New System.Drawing.Point(549, 563)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(86, 25)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Contact"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label10.Location = New System.Drawing.Point(549, 512)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 25)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Sex"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label11.Location = New System.Drawing.Point(550, 461)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(98, 25)
        Me.Label11.TabIndex = 26
        Me.Label11.Text = "Birthdate"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label12.Location = New System.Drawing.Point(549, 418)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(106, 25)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Lastname"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label13.Location = New System.Drawing.Point(549, 366)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(107, 25)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Firstname"
        '
        'EditContact
        '
        Me.EditContact.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditContact.Location = New System.Drawing.Point(658, 563)
        Me.EditContact.Name = "EditContact"
        Me.EditContact.Size = New System.Drawing.Size(217, 31)
        Me.EditContact.TabIndex = 23
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.EditFemaleRadio)
        Me.GroupBox2.Controls.Add(Me.EditMaleRadio)
        Me.GroupBox2.Location = New System.Drawing.Point(658, 501)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(188, 46)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sex"
        '
        'EditFemaleRadio
        '
        Me.EditFemaleRadio.AutoSize = True
        Me.EditFemaleRadio.Location = New System.Drawing.Point(103, 17)
        Me.EditFemaleRadio.Name = "EditFemaleRadio"
        Me.EditFemaleRadio.Size = New System.Drawing.Size(59, 17)
        Me.EditFemaleRadio.TabIndex = 11
        Me.EditFemaleRadio.TabStop = True
        Me.EditFemaleRadio.Text = "Female"
        Me.EditFemaleRadio.UseVisualStyleBackColor = True
        '
        'EditMaleRadio
        '
        Me.EditMaleRadio.AutoSize = True
        Me.EditMaleRadio.Location = New System.Drawing.Point(16, 17)
        Me.EditMaleRadio.Name = "EditMaleRadio"
        Me.EditMaleRadio.Size = New System.Drawing.Size(48, 17)
        Me.EditMaleRadio.TabIndex = 10
        Me.EditMaleRadio.TabStop = True
        Me.EditMaleRadio.Text = "Male"
        Me.EditMaleRadio.UseVisualStyleBackColor = True
        '
        'EditDOB
        '
        Me.EditDOB.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EditDOB.Location = New System.Drawing.Point(658, 466)
        Me.EditDOB.Name = "EditDOB"
        Me.EditDOB.Size = New System.Drawing.Size(217, 20)
        Me.EditDOB.TabIndex = 21
        '
        'EditLname
        '
        Me.EditLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditLname.Location = New System.Drawing.Point(658, 415)
        Me.EditLname.Name = "EditLname"
        Me.EditLname.Size = New System.Drawing.Size(217, 31)
        Me.EditLname.TabIndex = 20
        '
        'EditFname
        '
        Me.EditFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditFname.Location = New System.Drawing.Point(658, 366)
        Me.EditFname.Name = "EditFname"
        Me.EditFname.Size = New System.Drawing.Size(217, 31)
        Me.EditFname.TabIndex = 19
        '
        'EditSaveBtn
        '
        Me.EditSaveBtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.EditSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditSaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditSaveBtn.ForeColor = System.Drawing.Color.White
        Me.EditSaveBtn.Location = New System.Drawing.Point(658, 614)
        Me.EditSaveBtn.Name = "EditSaveBtn"
        Me.EditSaveBtn.Size = New System.Drawing.Size(77, 39)
        Me.EditSaveBtn.TabIndex = 29
        Me.EditSaveBtn.Text = "Save"
        Me.EditSaveBtn.UseVisualStyleBackColor = False
        Me.EditSaveBtn.Visible = False
        '
        'EditCancelBtn
        '
        Me.EditCancelBtn.BackColor = System.Drawing.Color.Gray
        Me.EditCancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditCancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditCancelBtn.ForeColor = System.Drawing.Color.White
        Me.EditCancelBtn.Location = New System.Drawing.Point(863, 614)
        Me.EditCancelBtn.Name = "EditCancelBtn"
        Me.EditCancelBtn.Size = New System.Drawing.Size(80, 39)
        Me.EditCancelBtn.TabIndex = 30
        Me.EditCancelBtn.Text = "Cancel"
        Me.EditCancelBtn.UseVisualStyleBackColor = False
        Me.EditCancelBtn.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label14.Location = New System.Drawing.Point(550, 314)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 25)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "EDIT"
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.IndianRed
        Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.Location = New System.Drawing.Point(761, 614)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(80, 39)
        Me.DeleteBtn.TabIndex = 32
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        Me.DeleteBtn.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1109, 715)
        Me.Panel1.TabIndex = 33
        '
        'Patients
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1109, 715)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.EditCancelBtn)
        Me.Controls.Add(Me.EditSaveBtn)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.EditContact)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.EditDOB)
        Me.Controls.Add(Me.EditLname)
        Me.Controls.Add(Me.EditFname)
        Me.Controls.Add(Me.CancelAddBtn)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ContactBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DOBPicker)
        Me.Controls.Add(Me.LastnameBox)
        Me.Controls.Add(Me.FirstnameBox)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.SearchBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Patients"
        CType(Me.PatientDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PatientDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AddBtn As System.Windows.Forms.Button
    Friend WithEvents SearchBtn As System.Windows.Forms.Button
    Friend WithEvents SearchBox As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents FirstnameBox As System.Windows.Forms.TextBox
    Friend WithEvents LastnameBox As System.Windows.Forms.TextBox
    Friend WithEvents DOBPicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents MaleRadio As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents FemaleRadio As System.Windows.Forms.RadioButton
    Friend WithEvents ContactBox As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CancelAddBtn As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents EditContact As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents EditFemaleRadio As System.Windows.Forms.RadioButton
    Friend WithEvents EditMaleRadio As System.Windows.Forms.RadioButton
    Friend WithEvents EditDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents EditLname As System.Windows.Forms.TextBox
    Friend WithEvents EditFname As System.Windows.Forms.TextBox
    Friend WithEvents EditSaveBtn As System.Windows.Forms.Button
    Friend WithEvents EditCancelBtn As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
