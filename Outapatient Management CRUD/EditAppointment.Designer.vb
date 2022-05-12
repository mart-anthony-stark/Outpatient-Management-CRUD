<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditAppointment
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.AptType = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AMPM = New System.Windows.Forms.ComboBox()
        Me.Minutes = New System.Windows.Forms.NumericUpDown()
        Me.Hours = New System.Windows.Forms.NumericUpDown()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DoctorName = New System.Windows.Forms.Label()
        Me.PatientName = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AptId = New System.Windows.Forms.Label()
        Me.DeleteBtn = New System.Windows.Forms.Button()
        Me.EditSaveBtn = New System.Windows.Forms.Button()
        CType(Me.Minutes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label11.Location = New System.Drawing.Point(145, 295)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(186, 25)
        Me.Label11.TabIndex = 50
        Me.Label11.Text = "Appointment Type"
        '
        'AptType
        '
        Me.AptType.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AptType.Location = New System.Drawing.Point(150, 323)
        Me.AptType.Name = "AptType"
        Me.AptType.Size = New System.Drawing.Size(329, 31)
        Me.AptType.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label9.Location = New System.Drawing.Point(145, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 25)
        Me.Label9.TabIndex = 48
        Me.Label9.Text = "Time"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.CadetBlue
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(387, 227)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 30)
        Me.Button1.TabIndex = 47
        Me.Button1.Text = "Current Time"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AMPM
        '
        Me.AMPM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AMPM.FormattingEnabled = True
        Me.AMPM.Items.AddRange(New Object() {"AM", "PM"})
        Me.AMPM.Location = New System.Drawing.Point(322, 227)
        Me.AMPM.Name = "AMPM"
        Me.AMPM.Size = New System.Drawing.Size(59, 32)
        Me.AMPM.TabIndex = 46
        '
        'Minutes
        '
        Me.Minutes.AutoSize = True
        Me.Minutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minutes.Location = New System.Drawing.Point(275, 228)
        Me.Minutes.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.Minutes.Name = "Minutes"
        Me.Minutes.Size = New System.Drawing.Size(46, 29)
        Me.Minutes.TabIndex = 45
        Me.Minutes.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Hours
        '
        Me.Hours.AutoSize = True
        Me.Hours.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hours.Location = New System.Drawing.Point(228, 228)
        Me.Hours.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.Hours.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Hours.Name = "Hours"
        Me.Hours.Size = New System.Drawing.Size(46, 29)
        Me.Hours.TabIndex = 44
        Me.Hours.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label10.Location = New System.Drawing.Point(145, 174)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 25)
        Me.Label10.TabIndex = 43
        Me.Label10.Text = "Date"
        '
        'DateTimePicker
        '
        Me.DateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker.Location = New System.Drawing.Point(225, 174)
        Me.DateTimePicker.Name = "DateTimePicker"
        Me.DateTimePicker.Size = New System.Drawing.Size(260, 24)
        Me.DateTimePicker.TabIndex = 42
        Me.DateTimePicker.Value = New Date(2022, 5, 11, 20, 8, 44, 0)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label8.Location = New System.Drawing.Point(145, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 25)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Patient"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label7.Location = New System.Drawing.Point(145, 64)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 25)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Doctor"
        '
        'DoctorName
        '
        Me.DoctorName.AutoSize = True
        Me.DoctorName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoctorName.ForeColor = System.Drawing.Color.SteelBlue
        Me.DoctorName.Location = New System.Drawing.Point(246, 64)
        Me.DoctorName.Name = "DoctorName"
        Me.DoctorName.Size = New System.Drawing.Size(0, 25)
        Me.DoctorName.TabIndex = 51
        '
        'PatientName
        '
        Me.PatientName.AutoSize = True
        Me.PatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientName.ForeColor = System.Drawing.Color.SteelBlue
        Me.PatientName.Location = New System.Drawing.Point(247, 113)
        Me.PatientName.Name = "PatientName"
        Me.PatientName.Size = New System.Drawing.Size(0, 25)
        Me.PatientName.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(567, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 25)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "ID"
        '
        'AptId
        '
        Me.AptId.AutoSize = True
        Me.AptId.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AptId.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AptId.Location = New System.Drawing.Point(600, 9)
        Me.AptId.Name = "AptId"
        Me.AptId.Size = New System.Drawing.Size(0, 25)
        Me.AptId.TabIndex = 54
        '
        'DeleteBtn
        '
        Me.DeleteBtn.BackColor = System.Drawing.Color.IndianRed
        Me.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DeleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DeleteBtn.ForeColor = System.Drawing.Color.White
        Me.DeleteBtn.Location = New System.Drawing.Point(399, 385)
        Me.DeleteBtn.Name = "DeleteBtn"
        Me.DeleteBtn.Size = New System.Drawing.Size(80, 39)
        Me.DeleteBtn.TabIndex = 56
        Me.DeleteBtn.Text = "Delete"
        Me.DeleteBtn.UseVisualStyleBackColor = False
        '
        'EditSaveBtn
        '
        Me.EditSaveBtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.EditSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditSaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditSaveBtn.ForeColor = System.Drawing.Color.White
        Me.EditSaveBtn.Location = New System.Drawing.Point(296, 385)
        Me.EditSaveBtn.Name = "EditSaveBtn"
        Me.EditSaveBtn.Size = New System.Drawing.Size(77, 39)
        Me.EditSaveBtn.TabIndex = 55
        Me.EditSaveBtn.Text = "Save"
        Me.EditSaveBtn.UseVisualStyleBackColor = False
        '
        'EditAppointment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 492)
        Me.Controls.Add(Me.DeleteBtn)
        Me.Controls.Add(Me.EditSaveBtn)
        Me.Controls.Add(Me.AptId)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PatientName)
        Me.Controls.Add(Me.DoctorName)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.AptType)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AMPM)
        Me.Controls.Add(Me.Minutes)
        Me.Controls.Add(Me.Hours)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DateTimePicker)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Name = "EditAppointment"
        Me.Text = "Edit Appointment Record"
        CType(Me.Minutes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents AptType As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AMPM As System.Windows.Forms.ComboBox
    Friend WithEvents Minutes As System.Windows.Forms.NumericUpDown
    Friend WithEvents Hours As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DoctorName As System.Windows.Forms.Label
    Friend WithEvents PatientName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents AptId As System.Windows.Forms.Label
    Friend WithEvents DeleteBtn As System.Windows.Forms.Button
    Friend WithEvents EditSaveBtn As System.Windows.Forms.Button
End Class
