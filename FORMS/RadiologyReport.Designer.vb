<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RadiologyReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RadiologyReport))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.LbFormHeader = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.CmdClose = New System.Windows.Forms.Button
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.CmdSave = New System.Windows.Forms.Button
        Me.BtnBold = New System.Windows.Forms.Button
        Me.BtnItalic = New System.Windows.Forms.Button
        Me.BtnUnderline = New System.Windows.Forms.Button
        Me.FrmTool = New System.Windows.Forms.GroupBox
        Me.CmbFontSize = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Btncenter = New System.Windows.Forms.Button
        Me.BtnLeft = New System.Windows.Forms.Button
        Me.txtRemoveFormat = New System.Windows.Forms.Button
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.txtpID = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmdSearch = New System.Windows.Forms.Button
        Me.TctReceiptNo = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtSex = New System.Windows.Forms.TextBox
        Me.txtAge = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.RdPending = New System.Windows.Forms.RadioButton
        Me.RdReported = New System.Windows.Forms.RadioButton
        Me.CmbTestName = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.TxtReportingDateTime = New System.Windows.Forms.DateTimePicker
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.BtnDefaultReport = New System.Windows.Forms.Button
        Me.TxtReceiptDate = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.TxtDesignation = New System.Windows.Forms.TextBox
        Me.CmbReportedBy = New System.Windows.Forms.ComboBox
        Me.txtEndOfReport = New HBS.RichTextBoxEx
        Me.TxtPatientNameAgeSex = New HBS.RichTextBoxEx
        Me.TxtDefReport = New HBS.RichTextBoxEx
        Me.TxtDefReportForPrint = New HBS.RichTextBoxEx
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.FrmTool.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1, -2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(741, 61)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'LbFormHeader
        '
        Me.LbFormHeader.BackColor = System.Drawing.Color.White
        Me.LbFormHeader.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFormHeader.ForeColor = System.Drawing.Color.Green
        Me.LbFormHeader.Location = New System.Drawing.Point(367, -2)
        Me.LbFormHeader.Name = "LbFormHeader"
        Me.LbFormHeader.Size = New System.Drawing.Size(365, 25)
        Me.LbFormHeader.TabIndex = 28
        Me.LbFormHeader.Text = "Radiology Report Editor"
        Me.LbFormHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.BtnPrint)
        Me.GroupBox2.Controls.Add(Me.CmdClose)
        Me.GroupBox2.Controls.Add(Me.BtnEdit)
        Me.GroupBox2.Controls.Add(Me.CmdSave)
        Me.GroupBox2.Location = New System.Drawing.Point(183, 567)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(378, 47)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.Enabled = False
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(88, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 25)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "&Print Preview"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.Blue
        Me.BtnPrint.Enabled = False
        Me.BtnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnPrint.Location = New System.Drawing.Point(206, 16)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(76, 25)
        Me.BtnPrint.TabIndex = 27
        Me.BtnPrint.Text = "&Print"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'CmdClose
        '
        Me.CmdClose.BackColor = System.Drawing.Color.Blue
        Me.CmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CmdClose.Location = New System.Drawing.Point(288, 16)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(76, 25)
        Me.CmdClose.TabIndex = 28
        Me.CmdClose.Text = "Cl&ose"
        Me.CmdClose.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.Blue
        Me.BtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEdit.Location = New System.Drawing.Point(6, 14)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(76, 25)
        Me.BtnEdit.TabIndex = 25
        Me.BtnEdit.Text = "&Edit"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'CmdSave
        '
        Me.CmdSave.BackColor = System.Drawing.Color.Blue
        Me.CmdSave.Enabled = False
        Me.CmdSave.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CmdSave.Location = New System.Drawing.Point(6, 15)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.Size = New System.Drawing.Size(76, 25)
        Me.CmdSave.TabIndex = 6
        Me.CmdSave.Text = "&Save"
        Me.CmdSave.UseVisualStyleBackColor = False
        '
        'BtnBold
        '
        Me.BtnBold.BackColor = System.Drawing.Color.Blue
        Me.BtnBold.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.BtnBold.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBold.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnBold.Location = New System.Drawing.Point(7, 12)
        Me.BtnBold.Name = "BtnBold"
        Me.BtnBold.Size = New System.Drawing.Size(70, 22)
        Me.BtnBold.TabIndex = 15
        Me.BtnBold.Text = "&Bold"
        Me.BtnBold.UseVisualStyleBackColor = False
        '
        'BtnItalic
        '
        Me.BtnItalic.BackColor = System.Drawing.Color.Blue
        Me.BtnItalic.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.BtnItalic.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnItalic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnItalic.Location = New System.Drawing.Point(81, 12)
        Me.BtnItalic.Name = "BtnItalic"
        Me.BtnItalic.Size = New System.Drawing.Size(70, 22)
        Me.BtnItalic.TabIndex = 16
        Me.BtnItalic.Text = "Italic"
        Me.BtnItalic.UseVisualStyleBackColor = False
        '
        'BtnUnderline
        '
        Me.BtnUnderline.BackColor = System.Drawing.Color.Blue
        Me.BtnUnderline.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.BtnUnderline.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUnderline.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnUnderline.Location = New System.Drawing.Point(155, 12)
        Me.BtnUnderline.Name = "BtnUnderline"
        Me.BtnUnderline.Size = New System.Drawing.Size(71, 22)
        Me.BtnUnderline.TabIndex = 17
        Me.BtnUnderline.Text = "Underline"
        Me.BtnUnderline.UseVisualStyleBackColor = False
        '
        'FrmTool
        '
        Me.FrmTool.Controls.Add(Me.CmbFontSize)
        Me.FrmTool.Controls.Add(Me.Label1)
        Me.FrmTool.Controls.Add(Me.Button3)
        Me.FrmTool.Controls.Add(Me.Btncenter)
        Me.FrmTool.Controls.Add(Me.BtnLeft)
        Me.FrmTool.Controls.Add(Me.txtRemoveFormat)
        Me.FrmTool.Controls.Add(Me.BtnUnderline)
        Me.FrmTool.Controls.Add(Me.BtnItalic)
        Me.FrmTool.Controls.Add(Me.BtnBold)
        Me.FrmTool.Enabled = False
        Me.FrmTool.Location = New System.Drawing.Point(4, 178)
        Me.FrmTool.Name = "FrmTool"
        Me.FrmTool.Size = New System.Drawing.Size(738, 42)
        Me.FrmTool.TabIndex = 14
        Me.FrmTool.TabStop = False
        '
        'CmbFontSize
        '
        Me.CmbFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFontSize.FormattingEnabled = True
        Me.CmbFontSize.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50"})
        Me.CmbFontSize.Location = New System.Drawing.Point(658, 12)
        Me.CmbFontSize.Name = "CmbFontSize"
        Me.CmbFontSize.Size = New System.Drawing.Size(70, 21)
        Me.CmbFontSize.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(583, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Font Size"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Blue
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(492, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(70, 21)
        Me.Button3.TabIndex = 21
        Me.Button3.Text = "A. Right"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Btncenter
        '
        Me.Btncenter.BackColor = System.Drawing.Color.Blue
        Me.Btncenter.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.Btncenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncenter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btncenter.Location = New System.Drawing.Point(420, 12)
        Me.Btncenter.Name = "Btncenter"
        Me.Btncenter.Size = New System.Drawing.Size(70, 21)
        Me.Btncenter.TabIndex = 20
        Me.Btncenter.Text = "A. Center"
        Me.Btncenter.UseVisualStyleBackColor = False
        '
        'BtnLeft
        '
        Me.BtnLeft.BackColor = System.Drawing.Color.Blue
        Me.BtnLeft.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.BtnLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLeft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnLeft.Location = New System.Drawing.Point(349, 12)
        Me.BtnLeft.Name = "BtnLeft"
        Me.BtnLeft.Size = New System.Drawing.Size(68, 21)
        Me.BtnLeft.TabIndex = 19
        Me.BtnLeft.Text = "A. Left"
        Me.BtnLeft.UseVisualStyleBackColor = False
        '
        'txtRemoveFormat
        '
        Me.txtRemoveFormat.BackColor = System.Drawing.Color.Blue
        Me.txtRemoveFormat.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.txtRemoveFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRemoveFormat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtRemoveFormat.Location = New System.Drawing.Point(232, 12)
        Me.txtRemoveFormat.Name = "txtRemoveFormat"
        Me.txtRemoveFormat.Size = New System.Drawing.Size(74, 21)
        Me.txtRemoveFormat.TabIndex = 18
        Me.txtRemoveFormat.Text = "Normal"
        Me.txtRemoveFormat.UseVisualStyleBackColor = False
        '
        'PageSetupDialog1
        '
        Me.PageSetupDialog1.Document = Me.PrintDocument1
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Document = Me.PrintDocument1
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.ShowIcon = False
        Me.PrintPreviewDialog1.Visible = False
        '
        'PrintDialog1
        '
        Me.PrintDialog1.Document = Me.PrintDocument1
        '
        'txtpID
        '
        Me.txtpID.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpID.Location = New System.Drawing.Point(104, 82)
        Me.txtpID.Name = "txtpID"
        Me.txtpID.ReadOnly = True
        Me.txtpID.Size = New System.Drawing.Size(127, 20)
        Me.txtpID.TabIndex = 2
        Me.txtpID.TabStop = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(-2, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 49
        Me.Label3.Text = "Patient ID"
        '
        'CmdSearch
        '
        Me.CmdSearch.BackColor = System.Drawing.Color.SeaGreen
        Me.CmdSearch.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdSearch.Image = CType(resources.GetObject("CmdSearch.Image"), System.Drawing.Image)
        Me.CmdSearch.Location = New System.Drawing.Point(231, 81)
        Me.CmdSearch.Name = "CmdSearch"
        Me.CmdSearch.Size = New System.Drawing.Size(18, 22)
        Me.CmdSearch.TabIndex = 3
        Me.CmdSearch.UseVisualStyleBackColor = False
        '
        'TctReceiptNo
        '
        Me.TctReceiptNo.BackColor = System.Drawing.Color.White
        Me.TctReceiptNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TctReceiptNo.Location = New System.Drawing.Point(326, 82)
        Me.TctReceiptNo.Name = "TctReceiptNo"
        Me.TctReceiptNo.ReadOnly = True
        Me.TctReceiptNo.Size = New System.Drawing.Size(89, 20)
        Me.TctReceiptNo.TabIndex = 4
        Me.TctReceiptNo.TabStop = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(249, 86)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 61
        Me.Label10.Text = "Receipt No."
        '
        'txtSex
        '
        Me.txtSex.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSex.Location = New System.Drawing.Point(476, 104)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.ReadOnly = True
        Me.txtSex.Size = New System.Drawing.Size(53, 20)
        Me.txtSex.TabIndex = 8
        Me.txtSex.TabStop = False
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.Location = New System.Drawing.Point(417, 104)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(55, 20)
        Me.txtAge.TabIndex = 7
        Me.txtAge.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(339, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Age && Sex"
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(104, 105)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(229, 20)
        Me.txtName.TabIndex = 6
        Me.txtName.TabStop = False
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(-1, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 65
        Me.Label5.Text = "Patient Name"
        '
        'RdPending
        '
        Me.RdPending.AutoSize = True
        Me.RdPending.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdPending.Location = New System.Drawing.Point(100, 62)
        Me.RdPending.Name = "RdPending"
        Me.RdPending.Size = New System.Drawing.Size(71, 17)
        Me.RdPending.TabIndex = 0
        Me.RdPending.TabStop = True
        Me.RdPending.Text = "Pending"
        Me.RdPending.UseVisualStyleBackColor = True
        '
        'RdReported
        '
        Me.RdReported.AutoSize = True
        Me.RdReported.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdReported.Location = New System.Drawing.Point(172, 62)
        Me.RdReported.Name = "RdReported"
        Me.RdReported.Size = New System.Drawing.Size(77, 17)
        Me.RdReported.TabIndex = 1
        Me.RdReported.TabStop = True
        Me.RdReported.Text = "Reported"
        Me.RdReported.UseVisualStyleBackColor = True
        '
        'CmbTestName
        '
        Me.CmbTestName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTestName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbTestName.FormattingEnabled = True
        Me.CmbTestName.Items.AddRange(New Object() {"X-Ray", "Ultrasound"})
        Me.CmbTestName.Location = New System.Drawing.Point(104, 128)
        Me.CmbTestName.Name = "CmbTestName"
        Me.CmbTestName.Size = New System.Drawing.Size(425, 21)
        Me.CmbTestName.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-2, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Test Name"
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-3, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 13)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "Reporting Date"
        '
        'TxtReportingDateTime
        '
        Me.TxtReportingDateTime.CustomFormat = "dd/MMM/yyyy hh:mm tt"
        Me.TxtReportingDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtReportingDateTime.Location = New System.Drawing.Point(104, 152)
        Me.TxtReportingDateTime.Name = "TxtReportingDateTime"
        Me.TxtReportingDateTime.Size = New System.Drawing.Size(184, 20)
        Me.TxtReportingDateTime.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.RoyalBlue
        Me.GroupBox1.Location = New System.Drawing.Point(535, 62)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(5, 117)
        Me.GroupBox1.TabIndex = 74
        Me.GroupBox1.TabStop = False
        '
        'BtnDefaultReport
        '
        Me.BtnDefaultReport.BackColor = System.Drawing.Color.Teal
        Me.BtnDefaultReport.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.BtnDefaultReport.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDefaultReport.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnDefaultReport.Location = New System.Drawing.Point(294, 152)
        Me.BtnDefaultReport.Name = "BtnDefaultReport"
        Me.BtnDefaultReport.Size = New System.Drawing.Size(235, 22)
        Me.BtnDefaultReport.TabIndex = 11
        Me.BtnDefaultReport.Text = "&Call Default Report"
        Me.BtnDefaultReport.UseVisualStyleBackColor = False
        '
        'TxtReceiptDate
        '
        Me.TxtReceiptDate.BackColor = System.Drawing.Color.White
        Me.TxtReceiptDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtReceiptDate.Location = New System.Drawing.Point(417, 82)
        Me.TxtReceiptDate.Name = "TxtReceiptDate"
        Me.TxtReceiptDate.ReadOnly = True
        Me.TxtReceiptDate.Size = New System.Drawing.Size(112, 20)
        Me.TxtReceiptDate.TabIndex = 5
        Me.TxtReceiptDate.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(541, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 78
        Me.Label4.Text = "Reported By"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(541, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(117, 13)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "Designation"
        '
        'TxtDesignation
        '
        Me.TxtDesignation.BackColor = System.Drawing.Color.White
        Me.TxtDesignation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtDesignation.Location = New System.Drawing.Point(541, 150)
        Me.TxtDesignation.MaxLength = 100
        Me.TxtDesignation.Name = "TxtDesignation"
        Me.TxtDesignation.Size = New System.Drawing.Size(201, 20)
        Me.TxtDesignation.TabIndex = 13
        Me.TxtDesignation.TabStop = False
        '
        'CmbReportedBy
        '
        Me.CmbReportedBy.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmbReportedBy.FormattingEnabled = True
        Me.CmbReportedBy.Items.AddRange(New Object() {"X-Ray", "Ultrasound"})
        Me.CmbReportedBy.Location = New System.Drawing.Point(541, 103)
        Me.CmbReportedBy.MaxLength = 250
        Me.CmbReportedBy.Name = "CmbReportedBy"
        Me.CmbReportedBy.Size = New System.Drawing.Size(201, 21)
        Me.CmbReportedBy.TabIndex = 12
        '
        'txtEndOfReport
        '
        Me.txtEndOfReport.AcceptsTab = True
        Me.txtEndOfReport.BackColor = System.Drawing.Color.MintCream
        Me.txtEndOfReport.HideSelection = False
        Me.txtEndOfReport.Location = New System.Drawing.Point(11, 506)
        Me.txtEndOfReport.Name = "txtEndOfReport"
        Me.txtEndOfReport.ShowSelectionMargin = True
        Me.txtEndOfReport.Size = New System.Drawing.Size(738, 55)
        Me.txtEndOfReport.TabIndex = 77
        Me.txtEndOfReport.Text = ""
        Me.txtEndOfReport.Visible = False
        '
        'TxtPatientNameAgeSex
        '
        Me.TxtPatientNameAgeSex.AcceptsTab = True
        Me.TxtPatientNameAgeSex.BackColor = System.Drawing.Color.MintCream
        Me.TxtPatientNameAgeSex.HideSelection = False
        Me.TxtPatientNameAgeSex.Location = New System.Drawing.Point(4, 607)
        Me.TxtPatientNameAgeSex.Name = "TxtPatientNameAgeSex"
        Me.TxtPatientNameAgeSex.ReadOnly = True
        Me.TxtPatientNameAgeSex.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.TxtPatientNameAgeSex.ShowSelectionMargin = True
        Me.TxtPatientNameAgeSex.Size = New System.Drawing.Size(738, 45)
        Me.TxtPatientNameAgeSex.TabIndex = 76
        Me.TxtPatientNameAgeSex.Text = ""
        Me.TxtPatientNameAgeSex.Visible = False
        '
        'TxtDefReport
        '
        Me.TxtDefReport.AcceptsTab = True
        Me.TxtDefReport.BackColor = System.Drawing.Color.MintCream
        Me.TxtDefReport.HideSelection = False
        Me.TxtDefReport.Location = New System.Drawing.Point(4, 223)
        Me.TxtDefReport.MaxLength = 100000000
        Me.TxtDefReport.Name = "TxtDefReport"
        Me.TxtDefReport.ReadOnly = True
        Me.TxtDefReport.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.TxtDefReport.ShowSelectionMargin = True
        Me.TxtDefReport.Size = New System.Drawing.Size(738, 338)
        Me.TxtDefReport.TabIndex = 23
        Me.TxtDefReport.Text = ""
        '
        'TxtDefReportForPrint
        '
        Me.TxtDefReportForPrint.AcceptsTab = True
        Me.TxtDefReportForPrint.BackColor = System.Drawing.Color.MintCream
        Me.TxtDefReportForPrint.HideSelection = False
        Me.TxtDefReportForPrint.Location = New System.Drawing.Point(4, 658)
        Me.TxtDefReportForPrint.Name = "TxtDefReportForPrint"
        Me.TxtDefReportForPrint.ShowSelectionMargin = True
        Me.TxtDefReportForPrint.Size = New System.Drawing.Size(738, 55)
        Me.TxtDefReportForPrint.TabIndex = 46
        Me.TxtDefReportForPrint.Text = ""
        Me.TxtDefReportForPrint.Visible = False
        '
        'RadiologyReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(745, 617)
        Me.Controls.Add(Me.CmbReportedBy)
        Me.Controls.Add(Me.TxtDesignation)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEndOfReport)
        Me.Controls.Add(Me.TxtPatientNameAgeSex)
        Me.Controls.Add(Me.TxtReceiptDate)
        Me.Controls.Add(Me.txtpID)
        Me.Controls.Add(Me.BtnDefaultReport)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtReportingDateTime)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CmbTestName)
        Me.Controls.Add(Me.RdReported)
        Me.Controls.Add(Me.RdPending)
        Me.Controls.Add(Me.TctReceiptNo)
        Me.Controls.Add(Me.txtSex)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtDefReport)
        Me.Controls.Add(Me.CmdSearch)
        Me.Controls.Add(Me.FrmTool)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LbFormHeader)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TxtDefReportForPrint)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "RadiologyReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.FrmTool.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LbFormHeader As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdSave As System.Windows.Forms.Button
    Friend WithEvents CmdClose As System.Windows.Forms.Button
    Friend WithEvents BtnBold As System.Windows.Forms.Button
    Friend WithEvents BtnItalic As System.Windows.Forms.Button
    Friend WithEvents BtnUnderline As System.Windows.Forms.Button
    Friend WithEvents FrmTool As System.Windows.Forms.GroupBox
    Friend WithEvents txtRemoveFormat As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Btncenter As System.Windows.Forms.Button
    Friend WithEvents BtnLeft As System.Windows.Forms.Button
    Friend WithEvents CmbFontSize As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BtnEdit As System.Windows.Forms.Button
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents TxtDefReport As RichTextBoxEx
    Friend WithEvents BtnPrint As System.Windows.Forms.Button
    Friend WithEvents TxtDefReportForPrint As HBS.RichTextBoxEx
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtpID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmdSearch As System.Windows.Forms.Button
    Friend WithEvents TctReceiptNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSex As System.Windows.Forms.TextBox
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents RdPending As System.Windows.Forms.RadioButton
    Friend WithEvents RdReported As System.Windows.Forms.RadioButton
    Friend WithEvents CmbTestName As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtReportingDateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnDefaultReport As System.Windows.Forms.Button
    Friend WithEvents TxtReceiptDate As System.Windows.Forms.TextBox
    Friend WithEvents TxtPatientNameAgeSex As HBS.RichTextBoxEx
    Friend WithEvents txtEndOfReport As HBS.RichTextBoxEx
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TxtDesignation As System.Windows.Forms.TextBox
    Friend WithEvents CmbReportedBy As System.Windows.Forms.ComboBox
End Class
