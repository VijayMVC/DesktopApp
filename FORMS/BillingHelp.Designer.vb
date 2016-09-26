<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BillingHelp
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BillingHelp))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.CMDCANCEL = New System.Windows.Forms.Button
        Me.CMDOK = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GridSearch = New System.Windows.Forms.DataGridView
        Me.TXTSEARCH = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.LBUserName = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.GridSearch, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CMDCANCEL)
        Me.GroupBox1.Controls.Add(Me.CMDOK)
        Me.GroupBox1.Location = New System.Drawing.Point(182, 378)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(167, 43)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'CMDCANCEL
        '
        Me.CMDCANCEL.BackColor = System.Drawing.Color.Blue
        Me.CMDCANCEL.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CMDCANCEL.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDCANCEL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CMDCANCEL.Location = New System.Drawing.Point(84, 12)
        Me.CMDCANCEL.Name = "CMDCANCEL"
        Me.CMDCANCEL.Size = New System.Drawing.Size(76, 23)
        Me.CMDCANCEL.TabIndex = 5
        Me.CMDCANCEL.Text = "Cancel"
        Me.CMDCANCEL.UseVisualStyleBackColor = False
        '
        'CMDOK
        '
        Me.CMDOK.BackColor = System.Drawing.Color.Blue
        Me.CMDOK.FlatAppearance.BorderColor = System.Drawing.Color.Coral
        Me.CMDOK.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CMDOK.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.CMDOK.Location = New System.Drawing.Point(6, 12)
        Me.CMDOK.Name = "CMDOK"
        Me.CMDOK.Size = New System.Drawing.Size(76, 23)
        Me.CMDOK.TabIndex = 4
        Me.CMDOK.Text = "OK"
        Me.CMDOK.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GridSearch)
        Me.GroupBox2.Controls.Add(Me.TXTSEARCH)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 62)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(567, 310)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'GridSearch
        '
        Me.GridSearch.AllowUserToAddRows = False
        Me.GridSearch.AllowUserToDeleteRows = False
        Me.GridSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridSearch.Location = New System.Drawing.Point(6, 40)
        Me.GridSearch.Name = "GridSearch"
        Me.GridSearch.ReadOnly = True
        Me.GridSearch.Size = New System.Drawing.Size(553, 264)
        Me.GridSearch.TabIndex = 2
        '
        'TXTSEARCH
        '
        Me.TXTSEARCH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXTSEARCH.Location = New System.Drawing.Point(277, 14)
        Me.TXTSEARCH.Name = "TXTSEARCH"
        Me.TXTSEARCH.Size = New System.Drawing.Size(282, 20)
        Me.TXTSEARCH.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Patient Code/ Name"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(2, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(567, 65)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 26
        Me.PictureBox2.TabStop = False
        '
        'LBUserName
        '
        Me.LBUserName.BackColor = System.Drawing.Color.White
        Me.LBUserName.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBUserName.ForeColor = System.Drawing.Color.Green
        Me.LBUserName.Location = New System.Drawing.Point(351, 3)
        Me.LBUserName.Name = "LBUserName"
        Me.LBUserName.Size = New System.Drawing.Size(214, 25)
        Me.LBUserName.TabIndex = 27
        Me.LBUserName.Text = "SEARCH PATIENTS"
        Me.LBUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BillingHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lavender
        Me.ClientSize = New System.Drawing.Size(573, 426)
        Me.Controls.Add(Me.LBUserName)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BillingHelp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Search"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.GridSearch, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CMDCANCEL As System.Windows.Forms.Button
    Friend WithEvents CMDOK As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TXTSEARCH As System.Windows.Forms.TextBox
    Friend WithEvents GridSearch As System.Windows.Forms.DataGridView
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LBUserName As System.Windows.Forms.Label
End Class
