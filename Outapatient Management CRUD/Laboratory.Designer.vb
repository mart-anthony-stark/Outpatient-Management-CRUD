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
        Me.TestType = New System.Windows.Forms.ComboBox()
        Me.ClearAddBtn = New System.Windows.Forms.Button()
        Me.AddBtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Cost = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Description = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TestName = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DisDescription = New System.Windows.Forms.TextBox()
        Me.DisType = New System.Windows.Forms.ComboBox()
        Me.DisName = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SearchBox = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SearchDisBox = New System.Windows.Forms.TextBox()
        CType(Me.LabtestTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DiseaseTbl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.Cost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LabtestTbl
        '
        Me.LabtestTbl.AllowUserToAddRows = False
        Me.LabtestTbl.AllowUserToDeleteRows = False
        Me.LabtestTbl.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.LabtestTbl.BackgroundColor = System.Drawing.Color.White
        Me.LabtestTbl.BorderStyle = System.Windows.Forms.BorderStyle.None
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
        Me.LabtestLbl.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabtestLbl.Location = New System.Drawing.Point(10, 17)
        Me.LabtestLbl.Name = "LabtestLbl"
        Me.LabtestLbl.Size = New System.Drawing.Size(262, 24)
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
        Me.DiseaseTbl.BackgroundColor = System.Drawing.Color.White
        Me.DiseaseTbl.BorderStyle = System.Windows.Forms.BorderStyle.None
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
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.PictureBox2)
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Controls.Add(Me.Panel3)
        Me.TabPage1.Controls.Add(Me.TestType)
        Me.TabPage1.Controls.Add(Me.ClearAddBtn)
        Me.TabPage1.Controls.Add(Me.AddBtn)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Cost)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.Description)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.TestName)
        Me.TabPage1.Controls.Add(Me.LabtestTbl)
        Me.TabPage1.Controls.Add(Me.LabtestLbl)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1097, 651)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Laboratory Test Services"
        '
        'TestType
        '
        Me.TestType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestType.FormattingEnabled = True
        Me.TestType.Items.AddRange(New Object() {"Clinical Chemistry", "Clinical Microbiology", "Hematology", "Blood banking and Serology (aka Immunohematology, Transfusion Medicine)", "Clinical Microscopy", "Histopathology and Cytopathology", "Molecular Biology", "Public Health"})
        Me.TestType.Location = New System.Drawing.Point(206, 454)
        Me.TestType.Name = "TestType"
        Me.TestType.Size = New System.Drawing.Size(243, 32)
        Me.TestType.TabIndex = 45
        '
        'ClearAddBtn
        '
        Me.ClearAddBtn.BackColor = System.Drawing.Color.IndianRed
        Me.ClearAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ClearAddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearAddBtn.ForeColor = System.Drawing.Color.White
        Me.ClearAddBtn.Location = New System.Drawing.Point(718, 595)
        Me.ClearAddBtn.Name = "ClearAddBtn"
        Me.ClearAddBtn.Size = New System.Drawing.Size(162, 39)
        Me.ClearAddBtn.TabIndex = 30
        Me.ClearAddBtn.Text = "Clear"
        Me.ClearAddBtn.UseVisualStyleBackColor = False
        '
        'AddBtn
        '
        Me.AddBtn.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.AddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AddBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddBtn.ForeColor = System.Drawing.Color.White
        Me.AddBtn.Location = New System.Drawing.Point(529, 595)
        Me.AddBtn.Name = "AddBtn"
        Me.AddBtn.Size = New System.Drawing.Size(162, 39)
        Me.AddBtn.TabIndex = 29
        Me.AddBtn.Text = "Add"
        Me.AddBtn.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(201, 545)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 25)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "₱"
        '
        'Cost
        '
        Me.Cost.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cost.Location = New System.Drawing.Point(233, 544)
        Me.Cost.Maximum = New Decimal(New Integer() {999999, 0, 0, 0})
        Me.Cost.Name = "Cost"
        Me.Cost.Size = New System.Drawing.Size(216, 29)
        Me.Cost.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(201, 516)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 25)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Cost"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(524, 340)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 25)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "Description"
        '
        'Description
        '
        Me.Description.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Description.Location = New System.Drawing.Point(529, 368)
        Me.Description.Multiline = True
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(345, 205)
        Me.Description.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(201, 426)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 25)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Test type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(201, 340)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 25)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Test name"
        '
        'TestName
        '
        Me.TestName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TestName.Location = New System.Drawing.Point(206, 368)
        Me.TestName.Name = "TestName"
        Me.TestName.Size = New System.Drawing.Size(243, 29)
        Me.TestName.TabIndex = 12
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer), CType(CType(234, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.PictureBox3)
        Me.TabPage2.Controls.Add(Me.PictureBox4)
        Me.TabPage2.Controls.Add(Me.Panel1)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.DisDescription)
        Me.TabPage2.Controls.Add(Me.DisType)
        Me.TabPage2.Controls.Add(Me.DisName)
        Me.TabPage2.Controls.Add(Me.DiseaseTbl)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1097, 651)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Disease / Illness Records"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.IndianRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(652, 576)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(162, 39)
        Me.Button1.TabIndex = 53
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(471, 576)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(162, 39)
        Me.Button2.TabIndex = 52
        Me.Button2.Text = "Add"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(526, 358)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 25)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Description"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(224, 464)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 25)
        Me.Label8.TabIndex = 50
        Me.Label8.Text = "Disease Type"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(224, 358)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(152, 25)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Disease Name"
        '
        'DisDescription
        '
        Me.DisDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisDescription.Location = New System.Drawing.Point(531, 386)
        Me.DisDescription.Multiline = True
        Me.DisDescription.Name = "DisDescription"
        Me.DisDescription.Size = New System.Drawing.Size(283, 166)
        Me.DisDescription.TabIndex = 16
        '
        'DisType
        '
        Me.DisType.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisType.FormattingEnabled = True
        Me.DisType.Items.AddRange(New Object() {"Systematic Infection", "Infectious", "Deficiency", "Hereditary", "Physiological"})
        Me.DisType.Location = New System.Drawing.Point(229, 492)
        Me.DisType.Name = "DisType"
        Me.DisType.Size = New System.Drawing.Size(279, 32)
        Me.DisType.TabIndex = 15
        '
        'DisName
        '
        Me.DisName.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisName.Location = New System.Drawing.Point(225, 386)
        Me.DisName.Name = "DisName"
        Me.DisName.Size = New System.Drawing.Size(283, 29)
        Me.DisName.TabIndex = 14
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.refresh
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(1038, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox2.TabIndex = 49
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.search
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(993, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.SearchBox)
        Me.Panel3.Location = New System.Drawing.Point(715, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(272, 39)
        Me.Panel3.TabIndex = 47
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 13)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "ID or Name"
        '
        'SearchBox
        '
        Me.SearchBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchBox.Location = New System.Drawing.Point(83, 1)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(183, 35)
        Me.SearchBox.TabIndex = 5
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.refresh
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Location = New System.Drawing.Point(1035, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox3.TabIndex = 56
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.search
        Me.PictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox4.Location = New System.Drawing.Point(990, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(40, 40)
        Me.PictureBox4.TabIndex = 55
        Me.PictureBox4.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.SearchDisBox)
        Me.Panel1.Location = New System.Drawing.Point(712, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(272, 39)
        Me.Panel1.TabIndex = 54
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(10, 13)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(61, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "ID or Name"
        '
        'SearchDisBox
        '
        Me.SearchDisBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchDisBox.Location = New System.Drawing.Point(83, 1)
        Me.SearchDisBox.Name = "SearchDisBox"
        Me.SearchDisBox.Size = New System.Drawing.Size(183, 35)
        Me.SearchDisBox.TabIndex = 5
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
        CType(Me.Cost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LabtestTbl As System.Windows.Forms.DataGridView
    Friend WithEvents LabtestLbl As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DiseaseTbl As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TestName As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Cost As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Description As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ClearAddBtn As System.Windows.Forms.Button
    Friend WithEvents AddBtn As System.Windows.Forms.Button
    Friend WithEvents TestType As System.Windows.Forms.ComboBox
    Friend WithEvents DisDescription As System.Windows.Forms.TextBox
    Friend WithEvents DisType As System.Windows.Forms.ComboBox
    Friend WithEvents DisName As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents SearchBox As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents SearchDisBox As System.Windows.Forms.TextBox
End Class
