<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LabtestResult
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DiseaseCmb = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ResultDate = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabtestResultTbl = New System.Windows.Forms.DataGridView()
        Me.LabtestCmb = New System.Windows.Forms.ComboBox()
        Me.AptID = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PatientName = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DoctorName = New System.Windows.Forms.Label()
        Me.AddBtn = New System.Windows.Forms.Button()
        CType(Me.LabtestResultTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label6.Location = New System.Drawing.Point(268, 540)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 25)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "Found"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(268, 515)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 25)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Disease/Illness"
        '
        'DiseaseCmb
        '
        Me.DiseaseCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DiseaseCmb.FormattingEnabled = True
        Me.DiseaseCmb.Location = New System.Drawing.Point(445, 527)
        Me.DiseaseCmb.Name = "DiseaseCmb"
        Me.DiseaseCmb.Size = New System.Drawing.Size(340, 32)
        Me.DiseaseCmb.TabIndex = 51
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(268, 449)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 25)
        Me.Label4.TabIndex = 50
        Me.Label4.Text = "Date"
        '
        'ResultDate
        '
        Me.ResultDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ResultDate.Location = New System.Drawing.Point(445, 449)
        Me.ResultDate.Name = "ResultDate"
        Me.ResultDate.Size = New System.Drawing.Size(340, 29)
        Me.ResultDate.TabIndex = 49
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(268, 378)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(162, 25)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "Lab Test Taken"
        '
        'LabtestResultTbl
        '
        Me.LabtestResultTbl.AllowUserToAddRows = False
        Me.LabtestResultTbl.AllowUserToDeleteRows = False
        Me.LabtestResultTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.LabtestResultTbl.BackgroundColor = System.Drawing.SystemColors.Control
        Me.LabtestResultTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LabtestResultTbl.Location = New System.Drawing.Point(12, 125)
        Me.LabtestResultTbl.Name = "LabtestResultTbl"
        Me.LabtestResultTbl.Size = New System.Drawing.Size(1061, 205)
        Me.LabtestResultTbl.TabIndex = 47
        '
        'LabtestCmb
        '
        Me.LabtestCmb.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabtestCmb.FormattingEnabled = True
        Me.LabtestCmb.Location = New System.Drawing.Point(445, 378)
        Me.LabtestCmb.Name = "LabtestCmb"
        Me.LabtestCmb.Size = New System.Drawing.Size(340, 32)
        Me.LabtestCmb.TabIndex = 46
        '
        'AptID
        '
        Me.AptID.AutoSize = True
        Me.AptID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AptID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AptID.Location = New System.Drawing.Point(179, 19)
        Me.AptID.Name = "AptID"
        Me.AptID.Size = New System.Drawing.Size(0, 25)
        Me.AptID.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(15, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 25)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Appointment ID"
        '
        'PatientName
        '
        Me.PatientName.AutoSize = True
        Me.PatientName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PatientName.Location = New System.Drawing.Point(179, 54)
        Me.PatientName.Name = "PatientName"
        Me.PatientName.Size = New System.Drawing.Size(0, 25)
        Me.PatientName.TabIndex = 57
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label8.Location = New System.Drawing.Point(15, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 25)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Patient"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label9.Location = New System.Drawing.Point(15, 87)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 25)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Doctor"
        '
        'DoctorName
        '
        Me.DoctorName.AutoSize = True
        Me.DoctorName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoctorName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DoctorName.Location = New System.Drawing.Point(179, 86)
        Me.DoctorName.Name = "DoctorName"
        Me.DoctorName.Size = New System.Drawing.Size(0, 25)
        Me.DoctorName.TabIndex = 59
        '
        'AddBtn
        '
        Me.AddBtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.ForeColor = System.Drawing.Color.White
        Me.AddBtn.Location = New System.Drawing.Point(623, 603)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(162, 39)
        Me.AddBtn.TabIndex = 60
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'LabtestResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1121, 715)
        Me.Controls.Add(Me.AddBtn)
        Me.Controls.Add(Me.DoctorName)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.PatientName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DiseaseCmb)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ResultDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabtestResultTbl)
        Me.Controls.Add(Me.LabtestCmb)
        Me.Controls.Add(Me.AptID)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "LabtestResult"
        Me.Text = "LabtestResult"
        CType(Me.LabtestResultTbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DiseaseCmb As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ResultDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LabtestResultTbl As System.Windows.Forms.DataGridView
    Friend WithEvents LabtestCmb As System.Windows.Forms.ComboBox
    Friend WithEvents AptID As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PatientName As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DoctorName As System.Windows.Forms.Label
    Friend WithEvents AddBtn As System.Windows.Forms.Button
End Class
