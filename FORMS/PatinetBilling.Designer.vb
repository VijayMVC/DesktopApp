<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PatinetBilling
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PatinetBilling))
        Me.LBUserName = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GridDTL = New AxFPSpread.AxvaSpread
        Me.txtBillingDate = New System.Windows.Forms.DateTimePicker
        Me.txtpID = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmdSearch = New System.Windows.Forms.Button
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtAge = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtSex = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCancelBill = New System.Windows.Forms.Button
        Me.btnPrint = New System.Windows.Forms.Button
        Me.btnPreview = New System.Windows.Forms.Button
        Me.CmdCancel = New System.Windows.Forms.Button
        Me.CmdClose = New System.Windows.Forms.Button
        Me.CmdSave = New System.Windows.Forms.Button
        Me.CmdNew = New System.Windows.Forms.Button
        Me.lblAmountInWord = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtTotalAmount = New System.Windows.Forms.TextBox
        Me.txtDiscountAmount = New System.Windows.Forms.TextBox
        Me.txtNetAmount = New System.Windows.Forms.TextBox
        Me.TctReceiptNo = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GRPPOPUPHELP = New System.Windows.Forms.GroupBox
        Me.GridPopUpService = New AxFPSpreadADO.AxfpSpread
        Me.ChPrintReceipt = New System.Windows.Forms.CheckBox
        Me.LbLBillCancelled = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.ChPrintInDosMode = New System.Windows.Forms.CheckBox
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridDTL, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GRPPOPUPHELP.SuspendLayout()
        CType(Me.GridPopUpService, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBUserName
        '
        Me.LBUserName.BackColor = System.Drawing.Color.White
        Me.LBUserName.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBUserName.ForeColor = System.Drawing.Color.Green
        Me.LBUserName.Location = New System.Drawing.Point(716, 9)
        Me.LBUserName.Name = "LBUserName"
        Me.LBUserName.Size = New System.Drawing.Size(257, 25)
        Me.LBUserName.TabIndex = 36
        Me.LBUserName.Text = "PATIENT BILLING"
        Me.LBUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(991, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 35
        Me.PictureBox2.TabStop = False
        '
        'GridDTL
        '
        Me.GridDTL.Location = New System.Drawing.Point(4, 107)
        Me.GridDTL.Name = "GridDTL"
        Me.GridDTL.OcxState = CType(resources.GetObject("GridDTL.OcxState"), System.Windows.Forms.AxHost.State)
        Me.GridDTL.Size = New System.Drawing.Size(987, 305)
        Me.GridDTL.TabIndex = 7
        '
        'txtBillingDate
        '
        Me.txtBillingDate.CustomFormat = "dd/MMM/yyyy"
        Me.txtBillingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtBillingDate.Location = New System.Drawing.Point(458, 82)
        Me.txtBillingDate.Name = "txtBillingDate"
        Me.txtBillingDate.Size = New System.Drawing.Size(93, 20)
        Me.txtBillingDate.TabIndex = 3
        '
        'txtpID
        '
        Me.txtpID.BackColor = System.Drawing.Color.White
        Me.txtpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpID.Location = New System.Drawing.Point(77, 79)
        Me.txtpID.Name = "txtpID"
        Me.txtpID.ReadOnly = True
        Me.txtpID.Size = New System.Drawing.Size(117, 20)
        Me.txtpID.TabIndex = 0
        Me.txtpID.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(366, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Receipt Date"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(4, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Patient ID"
        '
        'CmdSearch
        '
        Me.CmdSearch.BackColor = System.Drawing.Color.SeaGreen
        Me.CmdSearch.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CmdSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CmdSearch.Image = CType(resources.GetObject("CmdSearch.Image"), System.Drawing.Image)
        Me.CmdSearch.Location = New System.Drawing.Point(196, 78)
        Me.CmdSearch.Name = "CmdSearch"
        Me.CmdSearch.Size = New System.Drawing.Size(18, 22)
        Me.CmdSearch.TabIndex = 1
        Me.CmdSearch.UseVisualStyleBackColor = False
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.White
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(599, 83)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(198, 20)
        Me.txtName.TabIndex = 4
        Me.txtName.TabStop = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(551, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Name"
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.White
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAge.Location = New System.Drawing.Point(872, 83)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.ReadOnly = True
        Me.txtAge.Size = New System.Drawing.Size(61, 20)
        Me.txtAge.TabIndex = 5
        Me.txtAge.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(798, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Age && Sex"
        '
        'txtSex
        '
        Me.txtSex.BackColor = System.Drawing.Color.White
        Me.txtSex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSex.Location = New System.Drawing.Point(936, 83)
        Me.txtSex.Name = "txtSex"
        Me.txtSex.ReadOnly = True
        Me.txtSex.Size = New System.Drawing.Size(53, 20)
        Me.txtSex.TabIndex = 6
        Me.txtSex.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCancelBill)
        Me.GroupBox1.Controls.Add(Me.btnPrint)
        Me.GroupBox1.Controls.Add(Me.btnPreview)
        Me.GroupBox1.Controls.Add(Me.CmdCancel)
        Me.GroupBox1.Controls.Add(Me.CmdClose)
        Me.GroupBox1.Controls.Add(Me.CmdSave)
        Me.GroupBox1.Controls.Add(Me.CmdNew)
        Me.GroupBox1.Location = New System.Drawing.Point(252, 454)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 47)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        '
        'btnCancelBill
        '
        Me.btnCancelBill.BackColor = System.Drawing.Color.Blue
        Me.btnCancelBill.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.btnCancelBill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelBill.ForeColor = System.Drawing.Color.White
        Me.btnCancelBill.Location = New System.Drawing.Point(326, 14)
        Me.btnCancelBill.Name = "btnCancelBill"
        Me.btnCancelBill.Size = New System.Drawing.Size(76, 25)
        Me.btnCancelBill.TabIndex = 16
        Me.btnCancelBill.Text = "Cancel &Bill"
        Me.btnCancelBill.UseVisualStyleBackColor = False
        '
        'btnPrint
        '
        Me.btnPrint.BackColor = System.Drawing.Color.Blue
        Me.btnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.btnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.ForeColor = System.Drawing.Color.White
        Me.btnPrint.Location = New System.Drawing.Point(245, 14)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(76, 25)
        Me.btnPrint.TabIndex = 15
        Me.btnPrint.Text = "&Print"
        Me.btnPrint.UseVisualStyleBackColor = False
        '
        'btnPreview
        '
        Me.btnPreview.BackColor = System.Drawing.Color.Blue
        Me.btnPreview.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.btnPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPreview.ForeColor = System.Drawing.Color.White
        Me.btnPreview.Location = New System.Drawing.Point(165, 14)
        Me.btnPreview.Name = "btnPreview"
        Me.btnPreview.Size = New System.Drawing.Size(76, 25)
        Me.btnPreview.TabIndex = 14
        Me.btnPreview.Text = "P&review"
        Me.btnPreview.UseVisualStyleBackColor = False
        '
        'CmdCancel
        '
        Me.CmdCancel.BackColor = System.Drawing.Color.Blue
        Me.CmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancel.ForeColor = System.Drawing.Color.White
        Me.CmdCancel.Location = New System.Drawing.Point(85, 14)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(76, 25)
        Me.CmdCancel.TabIndex = 13
        Me.CmdCancel.Text = "&Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = False
        '
        'CmdClose
        '
        Me.CmdClose.BackColor = System.Drawing.Color.Blue
        Me.CmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClose.ForeColor = System.Drawing.Color.White
        Me.CmdClose.Location = New System.Drawing.Point(407, 14)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(76, 25)
        Me.CmdClose.TabIndex = 17
        Me.CmdClose.Text = "Cl&ose"
        Me.CmdClose.UseVisualStyleBackColor = False
        '
        'CmdSave
        '
        Me.CmdSave.BackColor = System.Drawing.Color.Blue
        Me.CmdSave.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSave.ForeColor = System.Drawing.Color.White
        Me.CmdSave.Location = New System.Drawing.Point(6, 14)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.Size = New System.Drawing.Size(76, 25)
        Me.CmdSave.TabIndex = 12
        Me.CmdSave.Text = "&Save"
        Me.CmdSave.UseVisualStyleBackColor = False
        '
        'CmdNew
        '
        Me.CmdNew.BackColor = System.Drawing.Color.Blue
        Me.CmdNew.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CmdNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CmdNew.Location = New System.Drawing.Point(6, 14)
        Me.CmdNew.Name = "CmdNew"
        Me.CmdNew.Size = New System.Drawing.Size(76, 25)
        Me.CmdNew.TabIndex = 11
        Me.CmdNew.Text = "&New"
        Me.CmdNew.UseVisualStyleBackColor = False
        '
        'lblAmountInWord
        '
        Me.lblAmountInWord.BackColor = System.Drawing.Color.Transparent
        Me.lblAmountInWord.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountInWord.Location = New System.Drawing.Point(7, 518)
        Me.lblAmountInWord.Name = "lblAmountInWord"
        Me.lblAmountInWord.Size = New System.Drawing.Size(984, 22)
        Me.lblAmountInWord.TabIndex = 50
        Me.lblAmountInWord.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(748, 454)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(128, 13)
        Me.Label6.TabIndex = 51
        Me.Label6.Text = "Total Amount :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(748, 476)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(128, 13)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Discount Amount :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(748, 496)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 13)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Net Amount :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtTotalAmount
        '
        Me.txtTotalAmount.BackColor = System.Drawing.Color.White
        Me.txtTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalAmount.Enabled = False
        Me.txtTotalAmount.Location = New System.Drawing.Point(882, 452)
        Me.txtTotalAmount.Name = "txtTotalAmount"
        Me.txtTotalAmount.ReadOnly = True
        Me.txtTotalAmount.Size = New System.Drawing.Size(107, 20)
        Me.txtTotalAmount.TabIndex = 18
        Me.txtTotalAmount.TabStop = False
        Me.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDiscountAmount
        '
        Me.txtDiscountAmount.BackColor = System.Drawing.Color.White
        Me.txtDiscountAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiscountAmount.Location = New System.Drawing.Point(882, 473)
        Me.txtDiscountAmount.Name = "txtDiscountAmount"
        Me.txtDiscountAmount.Size = New System.Drawing.Size(107, 20)
        Me.txtDiscountAmount.TabIndex = 19
        Me.txtDiscountAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtNetAmount
        '
        Me.txtNetAmount.BackColor = System.Drawing.Color.White
        Me.txtNetAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNetAmount.Enabled = False
        Me.txtNetAmount.Location = New System.Drawing.Point(882, 495)
        Me.txtNetAmount.Name = "txtNetAmount"
        Me.txtNetAmount.ReadOnly = True
        Me.txtNetAmount.Size = New System.Drawing.Size(107, 20)
        Me.txtNetAmount.TabIndex = 20
        Me.txtNetAmount.TabStop = False
        Me.txtNetAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'TctReceiptNo
        '
        Me.TctReceiptNo.BackColor = System.Drawing.Color.White
        Me.TctReceiptNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TctReceiptNo.Location = New System.Drawing.Point(294, 81)
        Me.TctReceiptNo.Name = "TctReceiptNo"
        Me.TctReceiptNo.ReadOnly = True
        Me.TctReceiptNo.Size = New System.Drawing.Size(71, 20)
        Me.TctReceiptNo.TabIndex = 2
        Me.TctReceiptNo.TabStop = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(215, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(84, 13)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "Receipt No."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 415)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(218, 12)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "TO INSERT = CTRL+N , TO DELETE = CTRL+D"
        '
        'GRPPOPUPHELP
        '
        Me.GRPPOPUPHELP.Controls.Add(Me.GridPopUpService)
        Me.GRPPOPUPHELP.Location = New System.Drawing.Point(428, 133)
        Me.GRPPOPUPHELP.Name = "GRPPOPUPHELP"
        Me.GRPPOPUPHELP.Size = New System.Drawing.Size(385, 279)
        Me.GRPPOPUPHELP.TabIndex = 8
        Me.GRPPOPUPHELP.TabStop = False
        Me.GRPPOPUPHELP.Visible = False
        '
        'GridPopUpService
        '
        Me.GridPopUpService.DataSource = Nothing
        Me.GridPopUpService.Location = New System.Drawing.Point(0, 2)
        Me.GridPopUpService.Name = "GridPopUpService"
        Me.GridPopUpService.OcxState = CType(resources.GetObject("GridPopUpService.OcxState"), System.Windows.Forms.AxHost.State)
        Me.GridPopUpService.Size = New System.Drawing.Size(382, 276)
        Me.GridPopUpService.TabIndex = 9
        '
        'ChPrintReceipt
        '
        Me.ChPrintReceipt.AutoSize = True
        Me.ChPrintReceipt.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChPrintReceipt.Location = New System.Drawing.Point(4, 454)
        Me.ChPrintReceipt.Name = "ChPrintReceipt"
        Me.ChPrintReceipt.Size = New System.Drawing.Size(165, 17)
        Me.ChPrintReceipt.TabIndex = 9
        Me.ChPrintReceipt.Text = "Print Receipt on Save"
        Me.ChPrintReceipt.UseVisualStyleBackColor = True
        '
        'LbLBillCancelled
        '
        Me.LbLBillCancelled.BackColor = System.Drawing.Color.Transparent
        Me.LbLBillCancelled.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbLBillCancelled.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.LbLBillCancelled.Location = New System.Drawing.Point(4, 495)
        Me.LbLBillCancelled.Name = "LbLBillCancelled"
        Me.LbLBillCancelled.Size = New System.Drawing.Size(99, 13)
        Me.LbLBillCancelled.TabIndex = 61
        Me.LbLBillCancelled.Text = "Bill Cancelled"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(5, 439)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(728, 12)
        Me.Label11.TabIndex = 62
        Me.Label11.Text = "TO ADD NEW = ALT+N,  TO SAVE = ALT+S, TO CANCEL = ALT + C,  PREVIEW BILL = ALT+R," & _
            " CANCEL BILL= ALT+B  PRINT BILL= ALT+P, TO CLOSE = ALT+O"
        '
        'ChPrintInDosMode
        '
        Me.ChPrintInDosMode.AutoSize = True
        Me.ChPrintInDosMode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChPrintInDosMode.Location = New System.Drawing.Point(4, 472)
        Me.ChPrintInDosMode.Name = "ChPrintInDosMode"
        Me.ChPrintInDosMode.Size = New System.Drawing.Size(143, 17)
        Me.ChPrintInDosMode.TabIndex = 10
        Me.ChPrintInDosMode.Text = "Print In DOS Mode"
        Me.ChPrintInDosMode.UseVisualStyleBackColor = True
        '
        'PatinetBilling
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(1003, 542)
        Me.Controls.Add(Me.TctReceiptNo)
        Me.Controls.Add(Me.ChPrintInDosMode)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.LbLBillCancelled)
        Me.Controls.Add(Me.ChPrintReceipt)
        Me.Controls.Add(Me.GRPPOPUPHELP)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtNetAmount)
        Me.Controls.Add(Me.txtDiscountAmount)
        Me.Controls.Add(Me.txtTotalAmount)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblAmountInWord)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtSex)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBillingDate)
        Me.Controls.Add(Me.txtpID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CmdSearch)
        Me.Controls.Add(Me.GridDTL)
        Me.Controls.Add(Me.LBUserName)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PatinetBilling"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridDTL, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GRPPOPUPHELP.ResumeLayout(False)
        CType(Me.GridPopUpService, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBUserName As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GridDTL As AxFPSpread.AxvaSpread
    Friend WithEvents txtBillingDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtpID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmdSearch As System.Windows.Forms.Button
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAge As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtSex As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Friend WithEvents CmdClose As System.Windows.Forms.Button
    Friend WithEvents CmdSave As System.Windows.Forms.Button
    Friend WithEvents CmdNew As System.Windows.Forms.Button
    Friend WithEvents lblAmountInWord As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtTotalAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtDiscountAmount As System.Windows.Forms.TextBox
    Friend WithEvents txtNetAmount As System.Windows.Forms.TextBox
    Friend WithEvents btnPreview As System.Windows.Forms.Button
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnCancelBill As System.Windows.Forms.Button
    Friend WithEvents TctReceiptNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GRPPOPUPHELP As System.Windows.Forms.GroupBox
    Friend WithEvents GridPopUpService As AxFPSpreadADO.AxfpSpread
    Friend WithEvents ChPrintReceipt As System.Windows.Forms.CheckBox
    Friend WithEvents LbLBillCancelled As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents ChPrintInDosMode As System.Windows.Forms.CheckBox
End Class
