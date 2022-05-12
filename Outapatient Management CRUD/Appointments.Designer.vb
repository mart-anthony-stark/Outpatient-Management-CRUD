<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Appointments
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.AppointmentTbl = New System.Windows.Forms.DataGridView()
        Me.DoctorsCmbBox = New System.Windows.Forms.ComboBox()
        Me.DatePicker = New System.Windows.Forms.DateTimePicker()
        Me.PatientCmbBox = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Hours = New System.Windows.Forms.NumericUpDown()
        Me.Minutes = New System.Windows.Forms.NumericUpDown()
        Me.ampm = New System.Windows.Forms.ComboBox()
        Me.CurrentTimeBtn = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.AddAptTypeInput = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ClearAddBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        CType(Me.AppointmentTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hours, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Minutes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 25)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Appointments"
        '
        'AppointmentTbl
        '
        Me.AppointmentTbl.AllowUserToAddRows = False
        Me.AppointmentTbl.AllowUserToDeleteRows = False
        Me.AppointmentTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.AppointmentTbl.BackgroundColor = System.Drawing.SystemColors.Control
        Me.AppointmentTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AppointmentTbl.Location = New System.Drawing.Point(12, 56)
        Me.AppointmentTbl.Name = "AppointmentTbl"
        Me.AppointmentTbl.ReadOnly = True
        Me.AppointmentTbl.Size = New System.Drawing.Size(1049, 264)
        Me.AppointmentTbl.TabIndex = 11
        '
        'DoctorsCmbBox
        '
        Me.DoctorsCmbBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoctorsCmbBox.FormattingEnabled = True
        Me.DoctorsCmbBox.Location = New System.Drawing.Point(224, 406)
        Me.DoctorsCmbBox.Name = "DoctorsCmbBox"
        Me.DoctorsCmbBox.Size = New System.Drawing.Size(345, 33)
        Me.DoctorsCmbBox.TabIndex = 13
        '
        'DatePicker
        '
        Me.DatePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatePicker.Location = New System.Drawing.Point(224, 494)
        Me.DatePicker.Name = "DatePicker"
        Me.DatePicker.Size = New System.Drawing.Size(345, 24)
        Me.DatePicker.TabIndex = 15
        Me.DatePicker.Value = New Date(2022, 5, 11, 20, 8, 44, 0)
        '
        'PatientCmbBox
        '
        Me.PatientCmbBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientCmbBox.FormattingEnabled = True
        Me.PatientCmbBox.Location = New System.Drawing.Point(598, 406)
        Me.PatientCmbBox.Name = "PatientCmbBox"
        Me.PatientCmbBox.Size = New System.Drawing.Size(345, 33)
        Me.PatientCmbBox.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(219, 378)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 25)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Doctor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(593, 378)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Patient"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(219, 463)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 25)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Date"
        '
        'Hours
        '
        Me.Hours.AutoSize = True
        Me.Hours.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hours.Location = New System.Drawing.Point(600, 490)
        Me.Hours.Maximum = New Decimal(New Integer() {12, 0, 0, 0})
        Me.Hours.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Hours.Name = "Hours"
        Me.Hours.Size = New System.Drawing.Size(46, 29)
        Me.Hours.TabIndex = 20
        Me.Hours.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Minutes
        '
        Me.Minutes.AutoSize = True
        Me.Minutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minutes.Location = New System.Drawing.Point(647, 490)
        Me.Minutes.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.Minutes.Name = "Minutes"
        Me.Minutes.Size = New System.Drawing.Size(46, 29)
        Me.Minutes.TabIndex = 21
        Me.Minutes.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ampm
        '
        Me.ampm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ampm.FormattingEnabled = True
        Me.ampm.Items.AddRange(New Object() {"AM", "PM"})
        Me.ampm.Location = New System.Drawing.Point(694, 489)
        Me.ampm.Name = "ampm"
        Me.ampm.Size = New System.Drawing.Size(59, 32)
        Me.ampm.TabIndex = 22
        '
        'CurrentTimeBtn
        '
        Me.CurrentTimeBtn.BackColor = System.Drawing.Color.CadetBlue
        Me.CurrentTimeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CurrentTimeBtn.ForeColor = System.Drawing.Color.White
        Me.CurrentTimeBtn.Location = New System.Drawing.Point(759, 489)
        Me.CurrentTimeBtn.Name = "CurrentTimeBtn"
        Me.CurrentTimeBtn.Size = New System.Drawing.Size(92, 30)
        Me.CurrentTimeBtn.TabIndex = 23
        Me.CurrentTimeBtn.Text = "Current Time"
        Me.CurrentTimeBtn.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(595, 462)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 25)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Time"
        '
        'AddAptTypeInput
        '
        Me.AddAptTypeInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddAptTypeInput.Location = New System.Drawing.Point(224, 567)
        Me.AddAptTypeInput.Name = "AddAptTypeInput"
        Me.AddAptTypeInput.Size = New System.Drawing.Size(345, 31)
        Me.AddAptTypeInput.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(219, 539)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(186, 25)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Appointment Type"
        '
        'ClearAddBtn
        '
        Me.ClearAddBtn.BackColor = System.Drawing.Color.IndianRed
        Me.ClearAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearAddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearAddBtn.ForeColor = System.Drawing.Color.White
        Me.ClearAddBtn.Location = New System.Drawing.Point(781, 620)
        Me.ClearAddBtn.Name = "ClearAddBtn"
        Me.ClearAddBtn.Size = New System.Drawing.Size(162, 39)
        Me.ClearAddBtn.TabIndex = 28
        Me.ClearAddBtn.Text = "Clear"
        Me.ClearAddBtn.UseVisualStyleBackColor = False
        '
        'AddBtn
        '
        Me.AddBtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.ForeColor = System.Drawing.Color.White
        Me.AddBtn.Location = New System.Drawing.Point(600, 620)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(162, 39)
        Me.AddBtn.TabIndex = 27
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'Appointments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1121, 715)
        Me.Controls.Add(Me.ClearAddBtn)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.AddAptTypeInput)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.CurrentTimeBtn)
        Me.Controls.Add(Me.ampm)
        Me.Controls.Add(Me.Minutes)
        Me.Controls.Add(Me.Hours)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PatientCmbBox)
        Me.Controls.Add(Me.DatePicker)
        Me.Controls.Add(Me.DoctorsCmbBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.AppointmentTbl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Appointments"
        Me.Text = "Appointments"
        CType(Me.AppointmentTbl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hours, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Minutes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents AppointmentTbl As System.Windows.Forms.DataGridView
    Friend WithEvents DoctorsCmbBox As System.Windows.Forms.ComboBox
    Friend WithEvents DatePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents PatientCmbBox As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Hours As System.Windows.Forms.NumericUpDown
    Friend WithEvents Minutes As System.Windows.Forms.NumericUpDown
    Friend WithEvents ampm As System.Windows.Forms.ComboBox
    Friend WithEvents CurrentTimeBtn As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents AddAptTypeInput As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ClearAddBtn As System.Windows.Forms.Button
    Friend WithEvents AddBtn As System.Windows.Forms.Button
End Class
