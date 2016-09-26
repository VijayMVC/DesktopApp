<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminView))
        Me.LbFormHeader = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.LblXRayTotal = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.LblXRayReported = New System.Windows.Forms.Label
        Me.LblXRayPending = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDateToXray = New System.Windows.Forms.DateTimePicker
        Me.txtDateFromXray = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.LblUSGTotal = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.LblUSGReported = New System.Windows.Forms.Label
        Me.LblUSGPending = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Label26 = New System.Windows.Forms.Label
        Me.CmdClose = New System.Windows.Forms.Button
        Me.TmrPgBar = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'LbFormHeader
        '
        Me.LbFormHeader.BackColor = System.Drawing.Color.White
        Me.LbFormHeader.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbFormHeader.ForeColor = System.Drawing.Color.Green
        Me.LbFormHeader.Location = New System.Drawing.Point(490, 9)
        Me.LbFormHeader.Name = "LbFormHeader"
        Me.LbFormHeader.Size = New System.Drawing.Size(265, 25)
        Me.LbFormHeader.TabIndex = 30
        Me.LbFormHeader.Text = "Administrator's View"
        Me.LbFormHeader.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(762, 61)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 29
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.LblXRayTotal)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.LblXRayReported)
        Me.GroupBox1.Controls.Add(Me.LblXRayPending)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtDateToXray)
        Me.GroupBox1.Controls.Add(Me.txtDateFromXray)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Location = New System.Drawing.Point(4, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 234)
        Me.GroupBox1.TabIndex = 63
        Me.GroupBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Blue
        Me.Label13.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(-34, 205)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(446, 2)
        Me.Label13.TabIndex = 76
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblXRayTotal
        '
        Me.LblXRayTotal.BackColor = System.Drawing.Color.Transparent
        Me.LblXRayTotal.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblXRayTotal.ForeColor = System.Drawing.Color.Blue
        Me.LblXRayTotal.Location = New System.Drawing.Point(123, 180)
        Me.LblXRayTotal.Name = "LblXRayTotal"
        Me.LblXRayTotal.Size = New System.Drawing.Size(206, 17)
        Me.LblXRayTotal.TabIndex = 75
        Me.LblXRayTotal.Text = "0"
        Me.LblXRayTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(3, 182)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 17)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "Total"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Blue
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(-34, 169)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(446, 2)
        Me.Label9.TabIndex = 73
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Blue
        Me.Label8.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(-3, 86)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(446, 2)
        Me.Label8.TabIndex = 72
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Blue
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(3, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(446, 2)
        Me.Label7.TabIndex = 71
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblXRayReported
        '
        Me.LblXRayReported.BackColor = System.Drawing.Color.Transparent
        Me.LblXRayReported.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblXRayReported.ForeColor = System.Drawing.Color.Green
        Me.LblXRayReported.Location = New System.Drawing.Point(124, 144)
        Me.LblXRayReported.Name = "LblXRayReported"
        Me.LblXRayReported.Size = New System.Drawing.Size(206, 17)
        Me.LblXRayReported.TabIndex = 70
        Me.LblXRayReported.Tag = "0"
        Me.LblXRayReported.Text = "0"
        Me.LblXRayReported.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblXRayPending
        '
        Me.LblXRayPending.BackColor = System.Drawing.Color.Transparent
        Me.LblXRayPending.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblXRayPending.ForeColor = System.Drawing.Color.Red
        Me.LblXRayPending.Location = New System.Drawing.Point(125, 111)
        Me.LblXRayPending.Name = "LblXRayPending"
        Me.LblXRayPending.Size = New System.Drawing.Size(206, 17)
        Me.LblXRayPending.TabIndex = 69
        Me.LblXRayPending.Text = "0"
        Me.LblXRayPending.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 17)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Reported"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Pending"
        '
        'txtDateToXray
        '
        Me.txtDateToXray.CustomFormat = "dd/MMM/yyyy"
        Me.txtDateToXray.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateToXray.Location = New System.Drawing.Point(238, 59)
        Me.txtDateToXray.Name = "txtDateToXray"
        Me.txtDateToXray.Size = New System.Drawing.Size(93, 20)
        Me.txtDateToXray.TabIndex = 66
        '
        'txtDateFromXray
        '
        Me.txtDateFromXray.CustomFormat = "dd/MMM/yyyy"
        Me.txtDateFromXray.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.txtDateFromXray.Location = New System.Drawing.Point(82, 59)
        Me.txtDateFromXray.Name = "txtDateFromXray"
        Me.txtDateFromXray.Size = New System.Drawing.Size(93, 20)
        Me.txtDateFromXray.TabIndex = 65
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(181, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Date To"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Date From"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(152, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 30)
        Me.Label10.TabIndex = 62
        Me.Label10.Text = "X-Ray"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.LblUSGTotal)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.LblUSGReported)
        Me.GroupBox2.Controls.Add(Me.LblUSGPending)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker3)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Location = New System.Drawing.Point(385, 95)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(378, 234)
        Me.GroupBox2.TabIndex = 77
        Me.GroupBox2.TabStop = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Blue
        Me.Label14.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(-34, 205)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(446, 2)
        Me.Label14.TabIndex = 76
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblUSGTotal
        '
        Me.LblUSGTotal.BackColor = System.Drawing.Color.Transparent
        Me.LblUSGTotal.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUSGTotal.ForeColor = System.Drawing.Color.Blue
        Me.LblUSGTotal.Location = New System.Drawing.Point(123, 180)
        Me.LblUSGTotal.Name = "LblUSGTotal"
        Me.LblUSGTotal.Size = New System.Drawing.Size(206, 17)
        Me.LblUSGTotal.TabIndex = 75
        Me.LblUSGTotal.Text = "Reported"
        Me.LblUSGTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label16
        '
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(3, 182)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 17)
        Me.Label16.TabIndex = 74
        Me.Label16.Text = "Total"
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Blue
        Me.Label17.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(-34, 169)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(446, 2)
        Me.Label17.TabIndex = 73
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.Color.Blue
        Me.Label18.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(-3, 86)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(446, 2)
        Me.Label18.TabIndex = 72
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label19
        '
        Me.Label19.BackColor = System.Drawing.Color.Blue
        Me.Label19.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(3, 46)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(446, 2)
        Me.Label19.TabIndex = 71
        Me.Label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblUSGReported
        '
        Me.LblUSGReported.BackColor = System.Drawing.Color.Transparent
        Me.LblUSGReported.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUSGReported.ForeColor = System.Drawing.Color.Green
        Me.LblUSGReported.Location = New System.Drawing.Point(124, 144)
        Me.LblUSGReported.Name = "LblUSGReported"
        Me.LblUSGReported.Size = New System.Drawing.Size(206, 17)
        Me.LblUSGReported.TabIndex = 70
        Me.LblUSGReported.Text = "Reported"
        Me.LblUSGReported.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LblUSGPending
        '
        Me.LblUSGPending.BackColor = System.Drawing.Color.Transparent
        Me.LblUSGPending.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblUSGPending.ForeColor = System.Drawing.Color.Red
        Me.LblUSGPending.Location = New System.Drawing.Point(125, 111)
        Me.LblUSGPending.Name = "LblUSGPending"
        Me.LblUSGPending.Size = New System.Drawing.Size(206, 17)
        Me.LblUSGPending.TabIndex = 69
        Me.LblUSGPending.Text = "Reported"
        Me.LblUSGPending.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label22
        '
        Me.Label22.BackColor = System.Drawing.Color.Transparent
        Me.Label22.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(6, 145)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(84, 17)
        Me.Label22.TabIndex = 68
        Me.Label22.Text = "Reported"
        '
        'Label23
        '
        Me.Label23.BackColor = System.Drawing.Color.Transparent
        Me.Label23.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(6, 115)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(84, 13)
        Me.Label23.TabIndex = 67
        Me.Label23.Text = "Pending"
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CustomFormat = "dd/MMM/yyyy"
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker2.Location = New System.Drawing.Point(238, 59)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(93, 20)
        Me.DateTimePicker2.TabIndex = 66
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.CustomFormat = "dd/MMM/yyyy"
        Me.DateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker3.Location = New System.Drawing.Point(82, 59)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(93, 20)
        Me.DateTimePicker3.TabIndex = 65
        '
        'Label24
        '
        Me.Label24.BackColor = System.Drawing.Color.Transparent
        Me.Label24.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(181, 59)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(84, 13)
        Me.Label24.TabIndex = 64
        Me.Label24.Text = "Date To"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.Transparent
        Me.Label25.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(6, 61)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(84, 13)
        Me.Label25.TabIndex = 63
        Me.Label25.Text = "Date From"
        '
        'Label26
        '
        Me.Label26.BackColor = System.Drawing.Color.Transparent
        Me.Label26.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(132, 16)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(143, 30)
        Me.Label26.TabIndex = 62
        Me.Label26.Text = "Ultrasound"
        '
        'CmdClose
        '
        Me.CmdClose.BackColor = System.Drawing.Color.Blue
        Me.CmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClose.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CmdClose.Location = New System.Drawing.Point(328, 335)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(119, 25)
        Me.CmdClose.TabIndex = 78
        Me.CmdClose.Text = "Cl&ose"
        Me.CmdClose.UseVisualStyleBackColor = False
        '
        'TmrPgBar
        '
        Me.TmrPgBar.Enabled = True
        Me.TmrPgBar.Interval = 1000
        '
        'AdminView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(767, 367)
        Me.Controls.Add(Me.CmdClose)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LbFormHeader)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdminView"
        Me.Text = "AdmilistratorView"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LbFormHeader As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents LblXRayReported As System.Windows.Forms.Label
    Friend WithEvents LblXRayPending As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDateToXray As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDateFromXray As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents LblXRayTotal As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents LblUSGTotal As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents LblUSGReported As System.Windows.Forms.Label
    Friend WithEvents LblUSGPending As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents CmdClose As System.Windows.Forms.Button
    Friend WithEvents TmrPgBar As System.Windows.Forms.Timer
End Class
