<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubDepartments
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubDepartments))
        Me.Label7 = New System.Windows.Forms.Label
        Me.CmdClose = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.CmdCancel = New System.Windows.Forms.Button
        Me.CmdSave = New System.Windows.Forms.Button
        Me.CmdEdit = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.GridDTL1 = New AxFPSpreadADO.AxfpSpread
        Me.Label3 = New System.Windows.Forms.Label
        Me.CmbManufacturer = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.LBUserName = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.GridDTL1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(11, 397)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(218, 12)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "TO INSERT = CTRL+N , TO DELETE = CTRL+D"
        '
        'CmdClose
        '
        Me.CmdClose.BackColor = System.Drawing.Color.Blue
        Me.CmdClose.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CmdClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdClose.ForeColor = System.Drawing.Color.White
        Me.CmdClose.Location = New System.Drawing.Point(241, 14)
        Me.CmdClose.Name = "CmdClose"
        Me.CmdClose.Size = New System.Drawing.Size(76, 25)
        Me.CmdClose.TabIndex = 4
        Me.CmdClose.Text = "Cl&ose"
        Me.CmdClose.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmdClose)
        Me.GroupBox2.Controls.Add(Me.CmdCancel)
        Me.GroupBox2.Controls.Add(Me.CmdSave)
        Me.GroupBox2.Controls.Add(Me.CmdEdit)
        Me.GroupBox2.Location = New System.Drawing.Point(171, 506)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(327, 47)
        Me.GroupBox2.TabIndex = 31
        Me.GroupBox2.TabStop = False
        '
        'CmdCancel
        '
        Me.CmdCancel.BackColor = System.Drawing.Color.Blue
        Me.CmdCancel.Enabled = False
        Me.CmdCancel.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CmdCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancel.ForeColor = System.Drawing.Color.White
        Me.CmdCancel.Location = New System.Drawing.Point(162, 14)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(76, 25)
        Me.CmdCancel.TabIndex = 3
        Me.CmdCancel.Text = "&Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = False
        '
        'CmdSave
        '
        Me.CmdSave.BackColor = System.Drawing.Color.Blue
        Me.CmdSave.Enabled = False
        Me.CmdSave.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CmdSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdSave.ForeColor = System.Drawing.Color.White
        Me.CmdSave.Location = New System.Drawing.Point(84, 14)
        Me.CmdSave.Name = "CmdSave"
        Me.CmdSave.Size = New System.Drawing.Size(76, 25)
        Me.CmdSave.TabIndex = 2
        Me.CmdSave.Text = "&Save"
        Me.CmdSave.UseVisualStyleBackColor = False
        '
        'CmdEdit
        '
        Me.CmdEdit.BackColor = System.Drawing.Color.Blue
        Me.CmdEdit.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CmdEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdEdit.ForeColor = System.Drawing.Color.White
        Me.CmdEdit.Location = New System.Drawing.Point(6, 14)
        Me.CmdEdit.Name = "CmdEdit"
        Me.CmdEdit.Size = New System.Drawing.Size(76, 25)
        Me.CmdEdit.TabIndex = 1
        Me.CmdEdit.Text = "&Edit"
        Me.CmdEdit.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GridDTL1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.CmbManufacturer)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(665, 413)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'GridDTL1
        '
        Me.GridDTL1.DataSource = Nothing
        Me.GridDTL1.Location = New System.Drawing.Point(10, 59)
        Me.GridDTL1.Name = "GridDTL1"
        Me.GridDTL1.OcxState = CType(resources.GetObject("GridDTL1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.GridDTL1.Size = New System.Drawing.Size(652, 335)
        Me.GridDTL1.TabIndex = 31
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Department"
        '
        'CmbManufacturer
        '
        Me.CmbManufacturer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbManufacturer.FormattingEnabled = True
        Me.CmbManufacturer.Location = New System.Drawing.Point(101, 13)
        Me.CmbManufacturer.Name = "CmbManufacturer"
        Me.CmbManufacturer.Size = New System.Drawing.Size(564, 21)
        Me.CmbManufacturer.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Sub-Department(s)"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(2, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(665, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 33
        Me.PictureBox2.TabStop = False
        '
        'LBUserName
        '
        Me.LBUserName.BackColor = System.Drawing.Color.White
        Me.LBUserName.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBUserName.ForeColor = System.Drawing.Color.Green
        Me.LBUserName.Location = New System.Drawing.Point(439, 9)
        Me.LBUserName.Name = "LBUserName"
        Me.LBUserName.Size = New System.Drawing.Size(225, 25)
        Me.LBUserName.TabIndex = 34
        Me.LBUserName.Text = "SUB-DEPARTMENTS"
        Me.LBUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 6.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 494)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(383, 12)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "TO EDIT = ALT+ E, TO SAVE = ALT+S, TO CANCEL = ALT + C, TO CLOSE = ALT+O"
        '
        'SubDepartments
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(669, 558)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBUserName)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SubDepartments"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.GridDTL1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents CmdClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Friend WithEvents CmdSave As System.Windows.Forms.Button
    Friend WithEvents CmdEdit As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GridDTL1 As AxFPSpreadADO.AxfpSpread
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents CmbManufacturer As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LBUserName As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
