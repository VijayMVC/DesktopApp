<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CurrentUserCollections
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CurrentUserCollections))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CmdPrint = New System.Windows.Forms.Button
        Me.CMDCANCEL = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.DGUserWise = New System.Windows.Forms.DataGridView
        Me.TxtToDate = New System.Windows.Forms.DateTimePicker
        Me.TxtFromDate = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.PgBar = New System.Windows.Forms.ProgressBar
        Me.LblTotCol = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.LBUserName = New System.Windows.Forms.Label
        Me.TmrPgBar = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGUserWise, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CmdPrint)
        Me.GroupBox1.Controls.Add(Me.CMDCANCEL)
        Me.GroupBox1.Location = New System.Drawing.Point(339, 367)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(276, 43)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        '
        'CmdPrint
        '
        Me.CmdPrint.BackColor = System.Drawing.Color.Blue
        Me.CmdPrint.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CmdPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdPrint.ForeColor = System.Drawing.Color.White
        Me.CmdPrint.Location = New System.Drawing.Point(6, 14)
        Me.CmdPrint.Name = "CmdPrint"
        Me.CmdPrint.Size = New System.Drawing.Size(178, 23)
        Me.CmdPrint.TabIndex = 3
        Me.CmdPrint.Text = "&Print User Collection"
        Me.CmdPrint.UseVisualStyleBackColor = False
        '
        'CMDCANCEL
        '
        Me.CMDCANCEL.BackColor = System.Drawing.Color.Blue
        Me.CMDCANCEL.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CMDCANCEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDCANCEL.ForeColor = System.Drawing.Color.White
        Me.CMDCANCEL.Location = New System.Drawing.Point(190, 14)
        Me.CMDCANCEL.Name = "CMDCANCEL"
        Me.CMDCANCEL.Size = New System.Drawing.Size(76, 23)
        Me.CMDCANCEL.TabIndex = 1
        Me.CMDCANCEL.Text = "&Close"
        Me.CMDCANCEL.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.TxtToDate)
        Me.GroupBox2.Controls.Add(Me.TxtFromDate)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(952, 299)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.DGUserWise)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 36)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(940, 257)
        Me.GroupBox3.TabIndex = 40
        Me.GroupBox3.TabStop = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(194, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "User Wise Cash Collection"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'DGUserWise
        '
        Me.DGUserWise.AllowUserToAddRows = False
        Me.DGUserWise.AllowUserToDeleteRows = False
        Me.DGUserWise.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGUserWise.Location = New System.Drawing.Point(6, 27)
        Me.DGUserWise.Name = "DGUserWise"
        Me.DGUserWise.ReadOnly = True
        Me.DGUserWise.Size = New System.Drawing.Size(928, 224)
        Me.DGUserWise.TabIndex = 27
        '
        'TxtToDate
        '
        Me.TxtToDate.CustomFormat = "dd/MMM/yyyy"
        Me.TxtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtToDate.Location = New System.Drawing.Point(256, 10)
        Me.TxtToDate.Name = "TxtToDate"
        Me.TxtToDate.Size = New System.Drawing.Size(118, 20)
        Me.TxtToDate.TabIndex = 29
        '
        'TxtFromDate
        '
        Me.TxtFromDate.CustomFormat = "dd/MMM/yyyy"
        Me.TxtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.TxtFromDate.Location = New System.Drawing.Point(79, 9)
        Me.TxtFromDate.Name = "TxtFromDate"
        Me.TxtFromDate.Size = New System.Drawing.Size(118, 20)
        Me.TxtFromDate.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(200, 13)
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
        'PgBar
        '
        Me.PgBar.Location = New System.Drawing.Point(2, 394)
        Me.PgBar.Name = "PgBar"
        Me.PgBar.Size = New System.Drawing.Size(254, 16)
        Me.PgBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.PgBar.TabIndex = 39
        '
        'LblTotCol
        '
        Me.LblTotCol.BackColor = System.Drawing.Color.Transparent
        Me.LblTotCol.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotCol.Location = New System.Drawing.Point(824, 391)
        Me.LblTotCol.Name = "LblTotCol"
        Me.LblTotCol.Size = New System.Drawing.Size(130, 13)
        Me.LblTotCol.TabIndex = 36
        Me.LblTotCol.Text = "Total Collection"
        Me.LblTotCol.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LblTotCol.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(952, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'LBUserName
        '
        Me.LBUserName.BackColor = System.Drawing.Color.White
        Me.LBUserName.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBUserName.ForeColor = System.Drawing.Color.Green
        Me.LBUserName.Location = New System.Drawing.Point(562, 2)
        Me.LBUserName.Name = "LBUserName"
        Me.LBUserName.Size = New System.Drawing.Size(388, 25)
        Me.LBUserName.TabIndex = 27
        Me.LBUserName.Text = "Cash Status By Current User"
        Me.LBUserName.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TmrPgBar
        '
        Me.TmrPgBar.Enabled = True
        Me.TmrPgBar.Interval = 50
        '
        'CurrentUserCollections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(954, 422)
        Me.Controls.Add(Me.LBUserName)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PgBar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.LblTotCol)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CurrentUserCollections"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Current User Cash Collection"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.DGUserWise, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PgBar As System.Windows.Forms.ProgressBar
    Friend WithEvents TmrPgBar As System.Windows.Forms.Timer
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DGUserWise As System.Windows.Forms.DataGridView
    Friend WithEvents CmdPrint As System.Windows.Forms.Button
End Class
