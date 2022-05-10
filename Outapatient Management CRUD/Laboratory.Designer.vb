<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laboratory
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
        Me.LabtestTbl = New System.Windows.Forms.DataGridView()
        Me.LabtestLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DiseaseTbl = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        CType(Me.LabtestTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiseaseTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabtestTbl
        '
        Me.LabtestTbl.AllowUserToAddRows = False
        Me.LabtestTbl.AllowUserToDeleteRows = False
        Me.LabtestTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.LabtestTbl.BackgroundColor = System.Drawing.SystemColors.Control
        Me.LabtestTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LabtestTbl.Location = New System.Drawing.Point(15, 45)
        Me.LabtestTbl.Name = "LabtestTbl"
        Me.LabtestTbl.ReadOnly = True
        Me.LabtestTbl.Size = New System.Drawing.Size(1062, 279)
        Me.LabtestTbl.TabIndex = 0
        '
        'LabtestLbl
        '
        Me.LabtestLbl.AutoSize = True
        Me.LabtestLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabtestLbl.Location = New System.Drawing.Point(10, 17)
        Me.LabtestLbl.Name = "LabtestLbl"
        Me.LabtestLbl.Size = New System.Drawing.Size(252, 25)
        Me.LabtestLbl.TabIndex = 11
        Me.LabtestLbl.Text = "Laboratory Test Services"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Disease / Illness Records"
        '
        'DiseaseTbl
        '
        Me.DiseaseTbl.AllowUserToAddRows = False
        Me.DiseaseTbl.AllowUserToDeleteRows = False
        Me.DiseaseTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DiseaseTbl.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DiseaseTbl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DiseaseTbl.Location = New System.Drawing.Point(15, 45)
        Me.DiseaseTbl.Name = "DiseaseTbl"
        Me.DiseaseTbl.ReadOnly = True
        Me.DiseaseTbl.Size = New System.Drawing.Size(1062, 279)
        Me.DiseaseTbl.TabIndex = 12
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1105, 677)
        Me.TabControl1.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.LabtestTbl)
        Me.TabPage1.Controls.Add(Me.LabtestLbl)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1097, 651)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Laboratory Test Services"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DiseaseTbl)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1097, 651)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Disease / Illness Records"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Laboratory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1105, 677)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Laboratory"
        Me.Text = "Laboratory"
        CType(Me.LabtestTbl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DiseaseTbl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabtestTbl As System.Windows.Forms.DataGridView
    Friend WithEvents LabtestLbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DiseaseTbl As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
End Class
