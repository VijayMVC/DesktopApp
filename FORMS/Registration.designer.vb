<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registration))
        Me.CmdSave = New System.Windows.Forms.Button
        Me.CmdClose = New System.Windows.Forms.Button
        Me.CmdCancel = New System.Windows.Forms.Button
        Me.CmdEdit = New System.Windows.Forms.Button
        Me.CmdNew = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CmdDelete = New System.Windows.Forms.Button
        Me.GroupMain = New System.Windows.Forms.GroupBox
        Me.txtregDate = New System.Windows.Forms.DateTimePicker
        Me.txtpID = New System.Windows.Forms.TextBox
        Me.txtRef = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtPaddress = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtFname = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.OptSexM = New System.Windows.Forms.RadioButton
        Me.OptSexF = New System.Windows.Forms.RadioButton
        Me.Label7 = New System.Windows.Forms.Label
        Me.MDYValue = New System.Windows.Forms.ComboBox
        Me.TxtYears = New System.Windows.Forms.TextBox
        Me.txtPname = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.optTitleMr = New System.Windows.Forms.RadioButton
        Me.optTitleBeby = New System.Windows.Forms.RadioButton
        Me.optTitleMrs = New System.Windows.Forms.RadioButton
        Me.optTitleMaster = New System.Windows.Forms.RadioButton
        Me.optTitleMiss = New System.Windows.Forms.RadioButton
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.AxfpSpread1 = New AxFPSpreadADO.AxfpSpread
        Me.LBUserName = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.CmdSearch = New System.Windows.Forms.Button
        Me.CmdMakeBill = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupMain.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.AxfpSpread1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CmdSave
        '
        Me.CmdSave.BackColor = System.Drawing.Color.Blue
        Me.CmdSave.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSave.ForeColor = System.Drawing.Color.White
        Me.CmdSave.Location = New System.Drawing.Point(6, 13)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.Size = New System.Drawing.Size(76, 25)
        Me.CmdSave.TabIndex = 20
        Me.CmdSave.Text = "&Save"
        Me.CmdSave.UseVisualStyleBackColor = False
        '
        'CmdClose
        '
        Me.CmdClose.BackColor = System.Drawing.Color.Blue
        Me.CmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClose.ForeColor = System.Drawing.Color.White
        Me.CmdClose.Location = New System.Drawing.Point(323, 14)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(76, 25)
        Me.CmdClose.TabIndex = 24
        Me.CmdClose.Text = "Cl&ose"
        Me.CmdClose.UseVisualStyleBackColor = False
        '
        'CmdCancel
        '
        Me.CmdCancel.BackColor = System.Drawing.Color.Blue
        Me.CmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancel.ForeColor = System.Drawing.Color.White
        Me.CmdCancel.Location = New System.Drawing.Point(244, 14)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(76, 25)
        Me.CmdCancel.TabIndex = 23
        Me.CmdCancel.Text = "&Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = False
        '
        'CmdEdit
        '
        Me.CmdEdit.BackColor = System.Drawing.Color.Blue
        Me.CmdEdit.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CmdEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdEdit.ForeColor = System.Drawing.Color.White
        Me.CmdEdit.Location = New System.Drawing.Point(84, 14)
        Me.CmdEdit.Name = "CmdEdit"
        Me.CmdEdit.Size = New System.Drawing.Size(76, 25)
        Me.CmdEdit.TabIndex = 21
        Me.CmdEdit.Text = "&Edit"
        Me.CmdEdit.UseVisualStyleBackColor = False
        '
        'CmdNew
        '
        Me.CmdNew.BackColor = System.Drawing.Color.Blue
        Me.CmdNew.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CmdNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNew.ForeColor = System.Drawing.Color.White
        Me.CmdNew.Location = New System.Drawing.Point(6, 14)
        Me.CmdNew.Name = "CmdNew"
        Me.CmdNew.Size = New System.Drawing.Size(76, 25)
        Me.CmdNew.TabIndex = 19
        Me.CmdNew.Text = "&New"
        Me.CmdNew.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(191, -109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Manufacturer Master"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmdDelete)
        Me.GroupBox1.Controls.Add(Me.CmdCancel)
        Me.GroupBox1.Controls.Add(Me.CmdEdit)
        Me.GroupBox1.Controls.Add(Me.CmdClose)
        Me.GroupBox1.Controls.Add(Me.CmdSave)
        Me.GroupBox1.Controls.Add(Me.CmdNew)
        Me.GroupBox1.Location = New System.Drawing.Point(87, 302)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(413, 47)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        '
        'CmdDelete
        '
        Me.CmdDelete.BackColor = System.Drawing.Color.Blue
        Me.CmdDelete.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CmdDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdDelete.ForeColor = System.Drawing.Color.White
        Me.CmdDelete.Location = New System.Drawing.Point(164, 14)
        Me.CmdDelete.Name = "CmdDelete"
        Me.CmdDelete.Size = New System.Drawing.Size(76, 25)
        Me.CmdDelete.TabIndex = 22
        Me.CmdDelete.Text = "&Delete"
        Me.CmdDelete.UseVisualStyleBackColor = False
        '
        'GroupMain
        '
        Me.GroupMain.Controls.Add(Me.txtregDate)
        Me.GroupMain.Controls.Add(Me.txtpID)
        Me.GroupMain.Controls.Add(Me.txtRef)
        Me.GroupMain.Controls.Add(Me.Label10)
        Me.GroupMain.Controls.Add(Me.txtPaddress)
        Me.GroupMain.Controls.Add(Me.Label9)
        Me.GroupMain.Controls.Add(Me.txtFname)
        Me.GroupMain.Controls.Add(Me.Label8)
        Me.GroupMain.Controls.Add(Me.GroupBox4)
        Me.GroupMain.Controls.Add(Me.Label7)
        Me.GroupMain.Controls.Add(Me.MDYValue)
        Me.GroupMain.Controls.Add(Me.TxtYears)
        Me.GroupMain.Controls.Add(Me.txtPname)
        Me.GroupMain.Controls.Add(Me.Label6)
        Me.GroupMain.Controls.Add(Me.Label5)
        Me.GroupMain.Controls.Add(Me.GroupBox3)
        Me.GroupMain.Controls.Add(Me.Label4)
        Me.GroupMain.Controls.Add(Me.Label2)
        Me.GroupMain.Controls.Add(Me.Label3)
        Me.GroupMain.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupMain.Location = New System.Drawing.Point(2, 70)
        Me.GroupMain.Name = "GroupMain"
        Me.GroupMain.Size = New System.Drawing.Size(581, 211)
        Me.GroupMain.TabIndex = 0
        Me.GroupMain.TabStop = False
        '
        'txtregDate
        '
        Me.txtregDate.CustomFormat = "dd/MMM/yyyy"
        Me.txtregDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtregDate.Location = New System.Drawing.Point(399, 22)
        Me.txtregDate.Name = "txtregDate"
        Me.txtregDate.Size = New System.Drawing.Size(106, 21)
        Me.txtregDate.TabIndex = 3
        '
        'txtpID
        '
        Me.txtpID.BackColor = System.Drawing.Color.White
        Me.txtpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpID.Location = New System.Drawing.Point(128, 24)
        Me.txtpID.Name = "txtpID"
        Me.txtpID.ReadOnly = True
        Me.txtpID.Size = New System.Drawing.Size(132, 21)
        Me.txtpID.TabIndex = 1
        Me.txtpID.TabStop = False
        '
        'txtRef
        '
        Me.txtRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRef.Location = New System.Drawing.Point(128, 181)
        Me.txtRef.Name = "txtRef"
        Me.txtRef.Size = New System.Drawing.Size(378, 21)
        Me.txtRef.TabIndex = 18
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 13)
        Me.Label10.TabIndex = 51
        Me.Label10.Text = "Referred By"
        '
        'txtPaddress
        '
        Me.txtPaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPaddress.Location = New System.Drawing.Point(127, 154)
        Me.txtPaddress.Name = "txtPaddress"
        Me.txtPaddress.Size = New System.Drawing.Size(378, 21)
        Me.txtPaddress.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(10, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 13)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Address"
        '
        'txtFname
        '
        Me.txtFname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFname.Location = New System.Drawing.Point(127, 128)
        Me.txtFname.Name = "txtFname"
        Me.txtFname.Size = New System.Drawing.Size(378, 21)
        Me.txtFname.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(10, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(120, 13)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Father's/Spouse"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.OptSexM)
        Me.GroupBox4.Controls.Add(Me.OptSexF)
        Me.GroupBox4.Location = New System.Drawing.Point(355, 97)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(150, 27)
        Me.GroupBox4.TabIndex = 13
        Me.GroupBox4.TabStop = False
        '
        'OptSexM
        '
        Me.OptSexM.AutoSize = True
        Me.OptSexM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptSexM.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptSexM.Location = New System.Drawing.Point(8, 8)
        Me.OptSexM.Name = "OptSexM"
        Me.OptSexM.Size = New System.Drawing.Size(50, 17)
        Me.OptSexM.TabIndex = 14
        Me.OptSexM.Text = "Male"
        Me.OptSexM.UseVisualStyleBackColor = True
        '
        'OptSexF
        '
        Me.OptSexF.AutoSize = True
        Me.OptSexF.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.OptSexF.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptSexF.Location = New System.Drawing.Point(68, 8)
        Me.OptSexF.Name = "OptSexF"
        Me.OptSexF.Size = New System.Drawing.Size(65, 17)
        Me.OptSexF.TabIndex = 15
        Me.OptSexF.Text = "Female"
        Me.OptSexF.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(311, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "Sex"
        '
        'MDYValue
        '
        Me.MDYValue.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MDYValue.FormattingEnabled = True
        Me.MDYValue.Items.AddRange(New Object() {"Years", "Months", "Days"})
        Me.MDYValue.Location = New System.Drawing.Point(201, 101)
        Me.MDYValue.Name = "MDYValue"
        Me.MDYValue.Size = New System.Drawing.Size(93, 21)
        Me.MDYValue.TabIndex = 12
        '
        'TxtYears
        '
        Me.TxtYears.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtYears.Location = New System.Drawing.Point(128, 100)
        Me.TxtYears.MaxLength = 2
        Me.TxtYears.Name = "TxtYears"
        Me.TxtYears.Size = New System.Drawing.Size(67, 21)
        Me.TxtYears.TabIndex = 11
        Me.TxtYears.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPname
        '
        Me.txtPname.BackColor = System.Drawing.Color.Honeydew
        Me.txtPname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPname.Location = New System.Drawing.Point(128, 76)
        Me.txtPname.Name = "txtPname"
        Me.txtPname.Size = New System.Drawing.Size(377, 21)
        Me.txtPname.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(10, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Age"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Patient Name"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.optTitleMr)
        Me.GroupBox3.Controls.Add(Me.optTitleBeby)
        Me.GroupBox3.Controls.Add(Me.optTitleMrs)
        Me.GroupBox3.Controls.Add(Me.optTitleMaster)
        Me.GroupBox3.Controls.Add(Me.optTitleMiss)
        Me.GroupBox3.Location = New System.Drawing.Point(128, 43)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(377, 30)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        '
        'optTitleMr
        '
        Me.optTitleMr.AutoSize = True
        Me.optTitleMr.BackColor = System.Drawing.Color.Lavender
        Me.optTitleMr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optTitleMr.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTitleMr.Location = New System.Drawing.Point(10, 8)
        Me.optTitleMr.Name = "optTitleMr"
        Me.optTitleMr.Size = New System.Drawing.Size(42, 17)
        Me.optTitleMr.TabIndex = 5
        Me.optTitleMr.Text = "Mr."
        Me.optTitleMr.UseVisualStyleBackColor = False
        '
        'optTitleBeby
        '
        Me.optTitleBeby.AutoSize = True
        Me.optTitleBeby.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optTitleBeby.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTitleBeby.Location = New System.Drawing.Point(246, 8)
        Me.optTitleBeby.Name = "optTitleBeby"
        Me.optTitleBeby.Size = New System.Drawing.Size(53, 17)
        Me.optTitleBeby.TabIndex = 9
        Me.optTitleBeby.Text = "Baby"
        Me.optTitleBeby.UseVisualStyleBackColor = True
        '
        'optTitleMrs
        '
        Me.optTitleMrs.AutoSize = True
        Me.optTitleMrs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optTitleMrs.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTitleMrs.Location = New System.Drawing.Point(59, 8)
        Me.optTitleMrs.Name = "optTitleMrs"
        Me.optTitleMrs.Size = New System.Drawing.Size(48, 17)
        Me.optTitleMrs.TabIndex = 6
        Me.optTitleMrs.Text = "Mrs."
        Me.optTitleMrs.UseVisualStyleBackColor = True
        '
        'optTitleMaster
        '
        Me.optTitleMaster.AutoSize = True
        Me.optTitleMaster.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optTitleMaster.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTitleMaster.Location = New System.Drawing.Point(173, 8)
        Me.optTitleMaster.Name = "optTitleMaster"
        Me.optTitleMaster.Size = New System.Drawing.Size(62, 17)
        Me.optTitleMaster.TabIndex = 8
        Me.optTitleMaster.Text = "Master"
        Me.optTitleMaster.UseVisualStyleBackColor = True
        '
        'optTitleMiss
        '
        Me.optTitleMiss.AutoSize = True
        Me.optTitleMiss.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.optTitleMiss.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.optTitleMiss.Location = New System.Drawing.Point(116, 8)
        Me.optTitleMiss.Name = "optTitleMiss"
        Me.optTitleMiss.Size = New System.Drawing.Size(48, 17)
        Me.optTitleMiss.TabIndex = 7
        Me.optTitleMiss.Text = "Miss"
        Me.optTitleMiss.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(10, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Prefix"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(279, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Registration Date"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Patient ID"
        '
        'AxfpSpread1
        '
        Me.AxfpSpread1.DataSource = Nothing
        Me.AxfpSpread1.Location = New System.Drawing.Point(6, 87)
        Me.AxfpSpread1.Name = "AxfpSpread1"
        Me.AxfpSpread1.OcxState = CType(resources.GetObject("AxfpSpread1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxfpSpread1.Size = New System.Drawing.Size(497, 160)
        Me.AxfpSpread1.TabIndex = 25
        '
        'LBUserName
        '
        Me.LBUserName.BackColor = System.Drawing.Color.White
        Me.LBUserName.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBUserName.ForeColor = System.Drawing.Color.Green
        Me.LBUserName.Location = New System.Drawing.Point(306, 3)
        Me.LBUserName.Name = "LBUserName"
        Me.LBUserName.Size = New System.Drawing.Size(276, 25)
        Me.LBUserName.TabIndex = 6
        Me.LBUserName.Text = "PATIENT REGISTRATION"
        Me.LBUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(2, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(581, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(-54, -129)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(634, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'CmdSearch
        '
        Me.CmdSearch.BackColor = System.Drawing.Color.SeaGreen
        Me.CmdSearch.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdSearch.Image = CType(resources.GetObject("CmdSearch.Image"), System.Drawing.Image)
        Me.CmdSearch.Location = New System.Drawing.Point(264, 93)
        Me.CmdSearch.Name = "CmdSearch"
        Me.CmdSearch.Size = New System.Drawing.Size(18, 22)
        Me.CmdSearch.TabIndex = 2
        Me.CmdSearch.UseVisualStyleBackColor = False
        '
        'CmdMakeBill
        '
        Me.CmdMakeBill.BackColor = System.Drawing.Color.Blue
        Me.CmdMakeBill.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CmdMakeBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdMakeBill.ForeColor = System.Drawing.Color.White
        Me.CmdMakeBill.Location = New System.Drawing.Point(506, 312)
        Me.CmdMakeBill.Name = "CmdMakeBill"
        Me.CmdMakeBill.Size = New System.Drawing.Size(76, 34)
        Me.CmdMakeBill.TabIndex = 25
        Me.CmdMakeBill.Text = "Generate &Bill..."
        Me.CmdMakeBill.UseVisualStyleBackColor = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(0, 287)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(583, 12)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "TO ADD NEW = ALT+N, TO EDIT = ALT+ E, TO SAVE = ALT+S, TO CANCEL = ALT + C, TO CL" & _
            "OSE = ALT+O, BILLING = ALT+B"
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(586, 356)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CmdMakeBill)
        Me.Controls.Add(Me.CmdSearch)
        Me.Controls.Add(Me.LBUserName)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Registration"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupMain.ResumeLayout(False)
        Me.GroupMain.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.AxfpSpread1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CmdSave As System.Windows.Forms.Button
    Friend WithEvents CmdClose As System.Windows.Forms.Button
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Friend WithEvents CmdEdit As System.Windows.Forms.Button
    Friend WithEvents CmdNew As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupMain As System.Windows.Forms.GroupBox
    Friend WithEvents AxfpSpread1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LBUserName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents optTitleMr As System.Windows.Forms.RadioButton
    Friend WithEvents optTitleBeby As System.Windows.Forms.RadioButton
    Friend WithEvents optTitleMrs As System.Windows.Forms.RadioButton
    Friend WithEvents optTitleMaster As System.Windows.Forms.RadioButton
    Friend WithEvents optTitleMiss As System.Windows.Forms.RadioButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFname As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents OptSexM As System.Windows.Forms.RadioButton
    Friend WithEvents OptSexF As System.Windows.Forms.RadioButton
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents MDYValue As System.Windows.Forms.ComboBox
    Friend WithEvents TxtYears As System.Windows.Forms.TextBox
    Friend WithEvents txtPname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtpID As System.Windows.Forms.TextBox
    Friend WithEvents txtRef As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtPaddress As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CmdDelete As System.Windows.Forms.Button
    Friend WithEvents txtregDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents CmdSearch As System.Windows.Forms.Button
    Friend WithEvents CmdMakeBill As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
