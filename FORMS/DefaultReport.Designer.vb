<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DefaultReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DefaultReport))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.LBUserName = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.LblDefaultReportFor = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.BtnPrint = New System.Windows.Forms.Button
        Me.BtnEdit = New System.Windows.Forms.Button
        Me.CmdClose = New System.Windows.Forms.Button
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
        Me.LblServiceCode = New System.Windows.Forms.Label
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog
        Me.TxtDefReportForPrint = New HBS.RichTextBoxEx
        Me.TxtDefReport = New HBS.RichTextBoxEx
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
        Me.PictureBox2.Size = New System.Drawing.Size(741, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'LBUserName
        '
        Me.LBUserName.BackColor = System.Drawing.Color.White
        Me.LBUserName.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBUserName.ForeColor = System.Drawing.Color.Green
        Me.LBUserName.Location = New System.Drawing.Point(473, -2)
        Me.LBUserName.Name = "LBUserName"
        Me.LBUserName.Size = New System.Drawing.Size(269, 25)
        Me.LBUserName.TabIndex = 28
        Me.LBUserName.Text = "Default Report Editor"
        Me.LBUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(0, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Default Report For"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblDefaultReportFor
        '
        Me.LblDefaultReportFor.BackColor = System.Drawing.Color.Transparent
        Me.LblDefaultReportFor.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDefaultReportFor.ForeColor = System.Drawing.Color.Blue
        Me.LblDefaultReportFor.Location = New System.Drawing.Point(223, 67)
        Me.LblDefaultReportFor.Name = "LblDefaultReportFor"
        Me.LblDefaultReportFor.Size = New System.Drawing.Size(420, 13)
        Me.LblDefaultReportFor.TabIndex = 40
        Me.LblDefaultReportFor.Text = "User Wise Cash Collection"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.BtnPrint)
        Me.GroupBox2.Controls.Add(Me.BtnEdit)
        Me.GroupBox2.Controls.Add(Me.CmdClose)
        Me.GroupBox2.Controls.Add(Me.CmdSave)
        Me.GroupBox2.Location = New System.Drawing.Point(183, 559)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(374, 47)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(88, 15)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 25)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "&Print Preview"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.Blue
        Me.BtnPrint.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.BtnPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnPrint.Location = New System.Drawing.Point(206, 15)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(76, 25)
        Me.BtnPrint.TabIndex = 11
        Me.BtnPrint.Text = "&Print"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.Blue
        Me.BtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnEdit.Location = New System.Drawing.Point(6, 15)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(76, 25)
        Me.BtnEdit.TabIndex = 10
        Me.BtnEdit.Text = "&Edit"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'CmdClose
        '
        Me.CmdClose.BackColor = System.Drawing.Color.Blue
        Me.CmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CmdClose.Location = New System.Drawing.Point(288, 15)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(76, 25)
        Me.CmdClose.TabIndex = 9
        Me.CmdClose.Text = "Cl&ose"
        Me.CmdClose.UseVisualStyleBackColor = False
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
        Me.BtnBold.Size = New System.Drawing.Size(70, 25)
        Me.BtnBold.TabIndex = 6
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
        Me.BtnItalic.Size = New System.Drawing.Size(70, 25)
        Me.BtnItalic.TabIndex = 9
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
        Me.BtnUnderline.Size = New System.Drawing.Size(71, 25)
        Me.BtnUnderline.TabIndex = 10
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
        Me.FrmTool.Location = New System.Drawing.Point(4, 80)
        Me.FrmTool.Name = "FrmTool"
        Me.FrmTool.Size = New System.Drawing.Size(738, 43)
        Me.FrmTool.TabIndex = 43
        Me.FrmTool.TabStop = False
        '
        'CmbFontSize
        '
        Me.CmbFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbFontSize.FormattingEnabled = True
        Me.CmbFontSize.Items.AddRange(New Object() {"8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50"})
        Me.CmbFontSize.Location = New System.Drawing.Point(662, 12)
        Me.CmbFontSize.Name = "CmbFontSize"
        Me.CmbFontSize.Size = New System.Drawing.Size(70, 21)
        Me.CmbFontSize.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(587, 15)
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
        Me.Button3.Location = New System.Drawing.Point(498, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(68, 25)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "A. Right"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Btncenter
        '
        Me.Btncenter.BackColor = System.Drawing.Color.Blue
        Me.Btncenter.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.Btncenter.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btncenter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Btncenter.Location = New System.Drawing.Point(427, 12)
        Me.Btncenter.Name = "Btncenter"
        Me.Btncenter.Size = New System.Drawing.Size(68, 25)
        Me.Btncenter.TabIndex = 13
        Me.Btncenter.Text = "A. Center"
        Me.Btncenter.UseVisualStyleBackColor = False
        '
        'BtnLeft
        '
        Me.BtnLeft.BackColor = System.Drawing.Color.Blue
        Me.BtnLeft.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.BtnLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLeft.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnLeft.Location = New System.Drawing.Point(356, 12)
        Me.BtnLeft.Name = "BtnLeft"
        Me.BtnLeft.Size = New System.Drawing.Size(68, 25)
        Me.BtnLeft.TabIndex = 12
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
        Me.txtRemoveFormat.Size = New System.Drawing.Size(74, 25)
        Me.txtRemoveFormat.TabIndex = 11
        Me.txtRemoveFormat.Text = "Normal"
        Me.txtRemoveFormat.UseVisualStyleBackColor = False
        '
        'LblServiceCode
        '
        Me.LblServiceCode.BackColor = System.Drawing.Color.Transparent
        Me.LblServiceCode.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblServiceCode.ForeColor = System.Drawing.Color.Blue
        Me.LblServiceCode.Location = New System.Drawing.Point(131, 67)
        Me.LblServiceCode.Name = "LblServiceCode"
        Me.LblServiceCode.Size = New System.Drawing.Size(86, 13)
        Me.LblServiceCode.TabIndex = 44
        Me.LblServiceCode.Text = "User Wise Cash Collection"
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
        'TxtDefReportForPrint
        '
        Me.TxtDefReportForPrint.AcceptsTab = True
        Me.TxtDefReportForPrint.BackColor = System.Drawing.Color.MintCream
        Me.TxtDefReportForPrint.Enabled = False
        Me.TxtDefReportForPrint.HideSelection = False
        Me.TxtDefReportForPrint.Location = New System.Drawing.Point(5, 520)
        Me.TxtDefReportForPrint.Name = "TxtDefReportForPrint"
        Me.TxtDefReportForPrint.ShowSelectionMargin = True
        Me.TxtDefReportForPrint.Size = New System.Drawing.Size(737, 48)
        Me.TxtDefReportForPrint.TabIndex = 46
        Me.TxtDefReportForPrint.Text = ""
        Me.TxtDefReportForPrint.Visible = False
        '
        'TxtDefReport
        '
        Me.TxtDefReport.AcceptsTab = True
        Me.TxtDefReport.BackColor = System.Drawing.Color.MintCream
        Me.TxtDefReport.HideSelection = False
        Me.TxtDefReport.Location = New System.Drawing.Point(4, 129)
        Me.TxtDefReport.Name = "TxtDefReport"
        Me.TxtDefReport.ReadOnly = True
        Me.TxtDefReport.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me.TxtDefReport.ShowSelectionMargin = True
        Me.TxtDefReport.Size = New System.Drawing.Size(738, 424)
        Me.TxtDefReport.TabIndex = 45
        Me.TxtDefReport.Text = ""
        '
        'DefaultReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(741, 607)
        Me.Controls.Add(Me.TxtDefReportForPrint)
        Me.Controls.Add(Me.TxtDefReport)
        Me.Controls.Add(Me.LblServiceCode)
        Me.Controls.Add(Me.FrmTool)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LblDefaultReportFor)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LBUserName)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DefaultReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DefaultReport"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.FrmTool.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LBUserName As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents LblDefaultReportFor As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdSave As System.Windows.Forms.Button
    Friend WithEvents CmdClose As System.Windows.Forms.Button
    Friend WithEvents BtnBold As System.Windows.Forms.Button
    Friend WithEvents BtnItalic As System.Windows.Forms.Button
    Friend WithEvents BtnUnderline As System.Windows.Forms.Button
    Friend WithEvents FrmTool As System.Windows.Forms.GroupBox
    Friend WithEvents txtRemoveFormat As System.Windows.Forms.Button
    Friend WithEvents LblServiceCode As System.Windows.Forms.Label
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
End Class
