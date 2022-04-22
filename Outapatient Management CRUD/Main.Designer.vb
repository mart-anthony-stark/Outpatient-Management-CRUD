<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MinimizeBtn = New System.Windows.Forms.Button()
        Me.ExitBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AppointmentsBtn = New System.Windows.Forms.Button()
        Me.DoctorsBtn = New System.Windows.Forms.Button()
        Me.PatientsBtn = New System.Windows.Forms.Button()
        Me.DashboardBtn = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelContainer
        '
        Me.PanelContainer.Location = New System.Drawing.Point(238, 57)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1121, 715)
        Me.PanelContainer.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(180, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.MinimizeBtn)
        Me.Panel1.Controls.Add(Me.ExitBtn)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1359, 51)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(181, Byte), Integer))
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(232, 51)
        Me.Panel3.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(94, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 32)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "OMS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(569, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Outpatient Management System"
        '
        'MinimizeBtn
        '
        Me.MinimizeBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.MinimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MinimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MinimizeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinimizeBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.MinimizeBtn.Location = New System.Drawing.Point(1238, 8)
        Me.MinimizeBtn.Name = "MinimizeBtn"
        Me.MinimizeBtn.Size = New System.Drawing.Size(43, 30)
        Me.MinimizeBtn.TabIndex = 1
        Me.MinimizeBtn.Text = "--"
        Me.MinimizeBtn.UseVisualStyleBackColor = False
        '
        'ExitBtn
        '
        Me.ExitBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ExitBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(69, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(190, Byte), Integer))
        Me.ExitBtn.Location = New System.Drawing.Point(1304, 8)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(43, 30)
        Me.ExitBtn.TabIndex = 0
        Me.ExitBtn.Text = "X"
        Me.ExitBtn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.AppointmentsBtn)
        Me.Panel2.Controls.Add(Me.DoctorsBtn)
        Me.Panel2.Controls.Add(Me.PatientsBtn)
        Me.Panel2.Controls.Add(Me.DashboardBtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(232, 733)
        Me.Panel2.TabIndex = 2
        '
        'AppointmentsBtn
        '
        Me.AppointmentsBtn.BackColor = System.Drawing.Color.White
        Me.AppointmentsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AppointmentsBtn.FlatAppearance.BorderSize = 0
        Me.AppointmentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AppointmentsBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AppointmentsBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.AppointmentsBtn.Location = New System.Drawing.Point(3, 262)
        Me.AppointmentsBtn.Name = "AppointmentsBtn"
        Me.AppointmentsBtn.Size = New System.Drawing.Size(227, 50)
        Me.AppointmentsBtn.TabIndex = 3
        Me.AppointmentsBtn.Text = "Appointments"
        Me.AppointmentsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AppointmentsBtn.UseVisualStyleBackColor = False
        '
        'DoctorsBtn
        '
        Me.DoctorsBtn.BackColor = System.Drawing.Color.White
        Me.DoctorsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoctorsBtn.FlatAppearance.BorderSize = 0
        Me.DoctorsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DoctorsBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DoctorsBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.DoctorsBtn.Location = New System.Drawing.Point(3, 211)
        Me.DoctorsBtn.Name = "DoctorsBtn"
        Me.DoctorsBtn.Size = New System.Drawing.Size(227, 50)
        Me.DoctorsBtn.TabIndex = 2
        Me.DoctorsBtn.Text = "Doctors"
        Me.DoctorsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DoctorsBtn.UseVisualStyleBackColor = False
        '
        'PatientsBtn
        '
        Me.PatientsBtn.BackColor = System.Drawing.Color.White
        Me.PatientsBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PatientsBtn.FlatAppearance.BorderSize = 0
        Me.PatientsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PatientsBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatientsBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.PatientsBtn.Location = New System.Drawing.Point(3, 159)
        Me.PatientsBtn.Name = "PatientsBtn"
        Me.PatientsBtn.Size = New System.Drawing.Size(227, 50)
        Me.PatientsBtn.TabIndex = 1
        Me.PatientsBtn.Text = "Patients"
        Me.PatientsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PatientsBtn.UseVisualStyleBackColor = False
        '
        'DashboardBtn
        '
        Me.DashboardBtn.BackColor = System.Drawing.Color.White
        Me.DashboardBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.DashboardBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DashboardBtn.FlatAppearance.BorderSize = 0
        Me.DashboardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.DashboardBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DashboardBtn.ForeColor = System.Drawing.Color.FromArgb(CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer), CType(CType(112, Byte), Integer))
        Me.DashboardBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardBtn.Location = New System.Drawing.Point(2, 107)
        Me.DashboardBtn.Name = "DashboardBtn"
        Me.DashboardBtn.Size = New System.Drawing.Size(227, 50)
        Me.DashboardBtn.TabIndex = 0
        Me.DashboardBtn.Text = "Dashboard"
        Me.DashboardBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DashboardBtn.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources._196123
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(50, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1359, 784)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PanelContainer)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Main"
        Me.Text = "Outpatient Management System"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PanelContainer As System.Windows.Forms.Panel
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents MinimizeBtn As System.Windows.Forms.Button
    Friend WithEvents ExitBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents AppointmentsBtn As System.Windows.Forms.Button
    Friend WithEvents DoctorsBtn As System.Windows.Forms.Button
    Friend WithEvents PatientsBtn As System.Windows.Forms.Button
    Friend WithEvents DashboardBtn As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
