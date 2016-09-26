<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DateWisePatientReceipt
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DateWisePatientReceipt))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.CMDCANCEL = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.PgBar = New System.Windows.Forms.ProgressBar
        Me.txtPreview = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.TxtToDate = New System.Windows.Forms.DateTimePicker
        Me.TxtFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.LblTotCol = New System.Windows.Forms.Label
        Me.LBUserName = New System.Windows.Forms.Label
        Me.TmrPgBar = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmdPrint)
        Me.GroupBox1.Controls.Add(Me.CMDCANCEL)
        Me.GroupBox1.Location = New System.Drawing.Point(127, 553)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(274, 43)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.Blue
        Me.CmdPrint.Enabled = False
        Me.CmdPrint.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CmdPrint.Location = New System.Drawing.Point(6, 14)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(178, 23)
        Me.CmdPrint.TabIndex = 2
        Me.CmdPrint.Text = "&Print"
        Me.CmdPrint.UseVisualStyleBackColor = False
        '
        'CMDCANCEL
        '
        Me.CMDCANCEL.BackColor = System.Drawing.Color.Blue
        Me.CMDCANCEL.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CMDCANCEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDCANCEL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CMDCANCEL.Location = New System.Drawing.Point(190, 14)
        Me.CMDCANCEL.Name = "CMDCANCEL"
        Me.CMDCANCEL.Size = New System.Drawing.Size(76, 23)
        Me.CMDCANCEL.TabIndex = 1
        Me.CMDCANCEL.Text = "&Close"
        Me.CMDCANCEL.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PgBar)
        Me.GroupBox2.Controls.Add(Me.txtPreview)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.TxtToDate)
        Me.GroupBox2.Controls.Add(Me.TxtFromDate)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(525, 489)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'PgBar
        '
        Me.PgBar.Location = New System.Drawing.Point(6, 467)
        Me.PgBar.Name = "PgBar"
        Me.PgBar.Size = New System.Drawing.Size(513, 16)
        Me.PgBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PgBar.TabIndex = 40
        '
        'txtPreview
        '
        Me.txtPreview.BackColor = System.Drawing.Color.White
        Me.txtPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPreview.Font = New System.Drawing.Font("Lucida Console", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPreview.Location = New System.Drawing.Point(6, 35)
        Me.txtPreview.MaxLength = 0
        Me.txtPreview.Multiline = True
        Me.txtPreview.Name = "txtPreview"
        Me.txtPreview.ReadOnly = True
        Me.txtPreview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtPreview.Size = New System.Drawing.Size(515, 430)
        Me.txtPreview.TabIndex = 36
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(347, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 23)
        Me.Button1.TabIndex = 35
        Me.Button1.Text = "&Prepare Report"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'TxtToDate
        '
        Me.TxtToDate.CustomFormat = "dd/MMM/yyyy"
        Me.TxtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtToDate.Location = New System.Drawing.Point(245, 10)
        Me.TxtToDate.Name = "TxtToDate"
        Me.TxtToDate.Size = New System.Drawing.Size(96, 20)
        Me.TxtToDate.TabIndex = 29
        '
        'TxtFromDate
        '
        Me.TxtFromDate.CustomFormat = "dd/MMM/yyyy"
        Me.TxtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtFromDate.Location = New System.Drawing.Point(91, 9)
        Me.TxtFromDate.Name = "TxtFromDate"
        Me.TxtFromDate.Size = New System.Drawing.Size(92, 20)
        Me.TxtFromDate.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(188, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "To Date"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "From Date"
        '
        'LblTotCol
        '
        Me.LblTotCol.BackColor = System.Drawing.Color.Transparent
        Me.LblTotCol.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotCol.Location = New System.Drawing.Point(818, 576)
        Me.LblTotCol.Name = "LblTotCol"
        Me.LblTotCol.Size = New System.Drawing.Size(130, 13)
        Me.LblTotCol.TabIndex = 36
        Me.LblTotCol.Text = "Total Collection"
        Me.LblTotCol.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblTotCol.Visible = False
        '
        'LBUserName
        '
        Me.LBUserName.BackColor = System.Drawing.Color.White
        Me.LBUserName.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBUserName.ForeColor = System.Drawing.Color.Green
        Me.LBUserName.Location = New System.Drawing.Point(189, 2)
        Me.LBUserName.Name = "LBUserName"
        Me.LBUserName.Size = New System.Drawing.Size(333, 25)
        Me.LBUserName.TabIndex = 27
        Me.LBUserName.Text = "Patient Receipts Date Wise"
        Me.LBUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TmrPgBar
        '
        Me.TmrPgBar.Enabled = True
        Me.TmrPgBar.Interval = 50
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(525, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'DateWisePatientReceipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(528, 598)
        Me.Controls.Add(Me.LBUserName)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LblTotCol)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DateWisePatientReceipt"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CMDCANCEL As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LBUserName As System.Windows.Forms.Label
    Friend WithEvents TxtToDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtFromDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblTotCol As System.Windows.Forms.Label
    Friend WithEvents TmrPgBar As System.Windows.Forms.Timer
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtPreview As System.Windows.Forms.TextBox
    Friend WithEvents PgBar As System.Windows.Forms.ProgressBar
End Class
