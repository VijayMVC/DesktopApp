<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Password
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Password))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.lblPassword = New System.Windows.Forms.Label
        Me.TxtPassword = New System.Windows.Forms.TextBox
        Me.ComOk = New System.Windows.Forms.Button
        Me.ComCancel = New System.Windows.Forms.Button
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(301, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'lblPassword
        '
        Me.lblPassword.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(7, 87)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(132, 16)
        Me.lblPassword.TabIndex = 10
        Me.lblPassword.Text = "Discount Password"
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPassword.Location = New System.Drawing.Point(145, 85)
        Me.TxtPassword.MaxLength = 8
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(156, 20)
        Me.TxtPassword.TabIndex = 0
        '
        'ComOk
        '
        Me.ComOk.BackColor = System.Drawing.Color.Blue
        Me.ComOk.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComOk.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ComOk.Location = New System.Drawing.Point(67, 128)
        Me.ComOk.Name = "ComOk"
        Me.ComOk.Size = New System.Drawing.Size(72, 24)
        Me.ComOk.TabIndex = 1
        Me.ComOk.Text = "&Ok"
        Me.ComOk.UseVisualStyleBackColor = False
        '
        'ComCancel
        '
        Me.ComCancel.BackColor = System.Drawing.Color.Blue
        Me.ComCancel.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComCancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ComCancel.Location = New System.Drawing.Point(145, 128)
        Me.ComCancel.Name = "ComCancel"
        Me.ComCancel.Size = New System.Drawing.Size(72, 24)
        Me.ComCancel.TabIndex = 2
        Me.ComCancel.Text = "&Cancel"
        Me.ComCancel.UseVisualStyleBackColor = False
        '
        'Password
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(303, 167)
        Me.Controls.Add(Me.ComCancel)
        Me.Controls.Add(Me.ComOk)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.PictureBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Password"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents ComOk As System.Windows.Forms.Button
    Friend WithEvents ComCancel As System.Windows.Forms.Button
End Class
