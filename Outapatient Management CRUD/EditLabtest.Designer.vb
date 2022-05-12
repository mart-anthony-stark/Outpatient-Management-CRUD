<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditLabtest
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
        Me.Cost = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Description = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TestName = New System.Windows.Forms.TextBox()
        Me.EditSaveBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idText = New System.Windows.Forms.Label()
        Me.TestType = New System.Windows.Forms.ComboBox()
        CType(Me.Cost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(145, 346)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 25)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "₱"
        '
        'Cost
        '
        Me.Cost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cost.Location = New System.Drawing.Point(177, 345)
        Me.Cost.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.Cost.Name = "Cost"
        Me.Cost.Size = New System.Drawing.Size(221, 29)
        Me.Cost.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label5.Location = New System.Drawing.Point(145, 317)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 25)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Cost"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label4.Location = New System.Drawing.Point(439, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 25)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Description"
        '
        'Description
        '
        Me.Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Description.Location = New System.Drawing.Point(444, 169)
        Me.Description.Multiline = True
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(262, 205)
        Me.Description.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label3.Location = New System.Drawing.Point(145, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 25)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Test type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label2.Location = New System.Drawing.Point(145, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 25)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Test name"
        '
        'TestName
        '
        Me.TestName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestName.Location = New System.Drawing.Point(150, 169)
        Me.TestName.Name = "TestName"
        Me.TestName.Size = New System.Drawing.Size(248, 29)
        Me.TestName.TabIndex = 27
        '
        'EditSaveBtn
        '
        Me.EditSaveBtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.EditSaveBtn.FlatAppearance.BorderSize = 0
        Me.EditSaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.EditSaveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EditSaveBtn.ForeColor = System.Drawing.Color.White
        Me.EditSaveBtn.Location = New System.Drawing.Point(611, 411)
        Me.EditSaveBtn.Name = "EditSaveBtn"
        Me.EditSaveBtn.Size = New System.Drawing.Size(95, 35)
        Me.EditSaveBtn.TabIndex = 41
        Me.EditSaveBtn.Text = "Save"
        Me.EditSaveBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.SteelBlue
        Me.Label1.Location = New System.Drawing.Point(674, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 25)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "ID"
        '
        'idText
        '
        Me.idText.AutoSize = True
        Me.idText.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.idText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.idText.Location = New System.Drawing.Point(712, 22)
        Me.idText.Name = "idText"
        Me.idText.Size = New System.Drawing.Size(0, 25)
        Me.idText.TabIndex = 43
        '
        'TestType
        '
        Me.TestType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestType.FormattingEnabled = True
        Me.TestType.Items.AddRange(New Object() {"Clinical Chemistry", "Clinical Microbiology", "Hematology", "Blood banking and Serology (aka Immunohematology, Transfusion Medicine)", "Clinical Microscopy", "Histopathology and Cytopathology", "Molecular Biology", "Public Health"})
        Me.TestType.Location = New System.Drawing.Point(150, 255)
        Me.TestType.Name = "TestType"
        Me.TestType.Size = New System.Drawing.Size(248, 32)
        Me.TestType.TabIndex = 44
        '
        'EditLabtest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(863, 528)
        Me.Controls.Add(Me.TestType)
        Me.Controls.Add(Me.idText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.EditSaveBtn)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Cost)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Description)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TestName)
        Me.Name = "EditLabtest"
        Me.Text = "Edit Labtest"
        CType(Me.Cost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cost As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Description As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TestName As System.Windows.Forms.TextBox
    Friend WithEvents EditSaveBtn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents idText As System.Windows.Forms.Label
    Friend WithEvents TestType As System.Windows.Forms.ComboBox
End Class
