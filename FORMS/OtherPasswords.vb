Public Class OtherPasswords
    Inherits System.Windows.Forms.Form
    Dim InsertFlag As Integer
    Dim EditFlag As Integer
    Dim Cmd As New Odbc.OdbcCommand
    Dim x As String
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LBUserName As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtBillDelPwd As System.Windows.Forms.TextBox
    Dim CallerId As String
#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents GroupMain As System.Windows.Forms.GroupBox
    Friend WithEvents GrpDML As System.Windows.Forms.GroupBox
    Friend WithEvents ComSave As System.Windows.Forms.Button
    Friend WithEvents ComExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtBillDiscountPwd As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OtherPasswords))
        Me.GroupMain = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtBillDelPwd = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtBillDiscountPwd = New System.Windows.Forms.TextBox
        Me.GrpDML = New System.Windows.Forms.GroupBox
        Me.ComExit = New System.Windows.Forms.Button
        Me.ComSave = New System.Windows.Forms.Button
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.LBUserName = New System.Windows.Forms.Label
        Me.GroupMain.SuspendLayout()
        Me.GrpDML.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupMain
        '
        Me.GroupMain.Controls.Add(Me.Label2)
        Me.GroupMain.Controls.Add(Me.TxtBillDelPwd)
        Me.GroupMain.Controls.Add(Me.Label1)
        Me.GroupMain.Controls.Add(Me.TxtBillDiscountPwd)
        Me.GroupMain.Location = New System.Drawing.Point(4, 76)
        Me.GroupMain.Name = "GroupMain"
        Me.GroupMain.Size = New System.Drawing.Size(423, 104)
        Me.GroupMain.TabIndex = 0
        Me.GroupMain.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password For Bill Deletion"
        '
        'TxtBillDelPwd
        '
        Me.TxtBillDelPwd.BackColor = System.Drawing.SystemColors.Window
        Me.TxtBillDelPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBillDelPwd.Location = New System.Drawing.Point(193, 51)
        Me.TxtBillDelPwd.MaxLength = 8
        Me.TxtBillDelPwd.Name = "TxtBillDelPwd"
        Me.TxtBillDelPwd.Size = New System.Drawing.Size(187, 20)
        Me.TxtBillDelPwd.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Password For Discount On Bill"
        '
        'TxtBillDiscountPwd
        '
        Me.TxtBillDiscountPwd.BackColor = System.Drawing.SystemColors.Window
        Me.TxtBillDiscountPwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBillDiscountPwd.Location = New System.Drawing.Point(193, 25)
        Me.TxtBillDiscountPwd.MaxLength = 8
        Me.TxtBillDiscountPwd.Name = "TxtBillDiscountPwd"
        Me.TxtBillDiscountPwd.Size = New System.Drawing.Size(187, 20)
        Me.TxtBillDiscountPwd.TabIndex = 1
        '
        'GrpDML
        '
        Me.GrpDML.Controls.Add(Me.ComExit)
        Me.GrpDML.Controls.Add(Me.ComSave)
        Me.GrpDML.Location = New System.Drawing.Point(130, 191)
        Me.GrpDML.Name = "GrpDML"
        Me.GrpDML.Size = New System.Drawing.Size(166, 48)
        Me.GrpDML.TabIndex = 6
        Me.GrpDML.TabStop = False
        '
        'ComExit
        '
        Me.ComExit.BackColor = System.Drawing.Color.Blue
        Me.ComExit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ComExit.Location = New System.Drawing.Point(84, 16)
        Me.ComExit.Name = "ComExit"
        Me.ComExit.Size = New System.Drawing.Size(72, 24)
        Me.ComExit.TabIndex = 4
        Me.ComExit.Text = "&Close"
        Me.ComExit.UseVisualStyleBackColor = False
        '
        'ComSave
        '
        Me.ComSave.BackColor = System.Drawing.Color.Blue
        Me.ComSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ComSave.Location = New System.Drawing.Point(6, 16)
        Me.ComSave.Name = "ComSave"
        Me.ComSave.Size = New System.Drawing.Size(72, 24)
        Me.ComSave.TabIndex = 3
        Me.ComSave.Text = "&Save"
        Me.ComSave.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(4, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(423, 70)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        '
        'LBUserName
        '
        Me.LBUserName.BackColor = System.Drawing.Color.White
        Me.LBUserName.Font = New System.Drawing.Font("Verdana", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBUserName.ForeColor = System.Drawing.Color.Green
        Me.LBUserName.Location = New System.Drawing.Point(277, 2)
        Me.LBUserName.Name = "LBUserName"
        Me.LBUserName.Size = New System.Drawing.Size(150, 25)
        Me.LBUserName.TabIndex = 8
        Me.LBUserName.Text = "Passwords"
        Me.LBUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OtherPasswords
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(426, 245)
        Me.Controls.Add(Me.LBUserName)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.GrpDML)
        Me.Controls.Add(Me.GroupMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OtherPasswords"
        Me.Text = "Passwords"
        Me.GroupMain.ResumeLayout(False)
        Me.GroupMain.PerformLayout()
        Me.GrpDML.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub ComClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        InsertFlag = 0
        EditFlag = 0
        Me.TxtBillDiscountPwd.ReadOnly = True
       

    End Sub
    Private Sub ComEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error GoTo rr

        Exit Sub
rr:
        MsgBox(Err.Description)
    End Sub
    
    Private Sub ComSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComSave.Click
        Try
            Cmd.CommandType = CommandType.Text
            Con = GetAccesscon()
            Cmd.Connection = Con

            Cmd.CommandText = "Update OtherPasswords Set DeletePassword='" & Trim(Me.TxtBillDelPwd.Text) & "',DiscountPassword='" + Trim(Me.TxtBillDiscountPwd.Text) + "'"
            Cmd.ExecuteNonQuery()
            MsgBox("Saved Successfully.")
        Catch
            
            MsgBox(Err.Description)

        End Try
    End Sub

    Private Sub OtherPasswords_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = "'" Then e.Handled = True
    End Sub
 
    Private Sub UserAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo rr
        Me.KeyPreview = True
        GetData()
        Exit Sub
rr:
        MsgBox(Err.Description)
    End Sub
    Private Sub TxtUserName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub
    Private Sub TxtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBillDiscountPwd.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub ComExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComExit.Click
        Me.Close()
        Me.Dispose()
    End Sub
    Private Sub GetData()
        Dim MySqlCon As New Odbc.OdbcConnection
        Dim MySqlDataRd As Odbc.OdbcDataReader
        Dim MySqlCmd As New Odbc.OdbcCommand
        MySqlCon = GetAccesscon()
        MySqlCmd.Connection = MySqlCon

        Try
            MySqlCmd.CommandText = "SELECT DeletePassword,DiscountPassword FROM OtherPasswords"
            MySqlDataRd = MySqlCmd.ExecuteReader()

            If (MySqlDataRd.HasRows = True) Then
                While (MySqlDataRd.Read)
                    Me.TxtBillDiscountPwd.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("DiscountPassword")).ToString()
                    Me.TxtBillDelPwd.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("DeletePassword")).ToString()
                End While
            End If

            MySqlDataRd.Close()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally
            MySqlCon.Dispose()
            MySqlCmd.Dispose()
        End Try
    End Sub
End Class
