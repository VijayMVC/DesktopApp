Public Class Login
    Inherits System.Windows.Forms.Form
    Dim TMDI As HBSMAIN
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ButtOk As System.Windows.Forms.Button
    Friend WithEvents ButtCancel As System.Windows.Forms.Button
    Friend WithEvents Pic As System.Windows.Forms.PictureBox
    Friend WithEvents TxtUser As System.Windows.Forms.TextBox
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LBUserName As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.LBUserName = New System.Windows.Forms.Label
        Me.TxtUser = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtPassword = New System.Windows.Forms.TextBox
        Me.ButtOk = New System.Windows.Forms.Button
        Me.ButtCancel = New System.Windows.Forms.Button
        Me.Pic = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBUserName
        '
        Me.LBUserName.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBUserName.Location = New System.Drawing.Point(16, 26)
        Me.LBUserName.Name = "LBUserName"
        Me.LBUserName.Size = New System.Drawing.Size(80, 18)
        Me.LBUserName.TabIndex = 5
        Me.LBUserName.Text = "User Name"
        '
        'TxtUser
        '
        Me.TxtUser.BackColor = System.Drawing.SystemColors.Window
        Me.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtUser.Location = New System.Drawing.Point(104, 26)
        Me.TxtUser.MaxLength = 20
        Me.TxtUser.Name = "TxtUser"
        Me.TxtUser.Size = New System.Drawing.Size(170, 20)
        Me.TxtUser.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Password"
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPassword.Location = New System.Drawing.Point(104, 51)
        Me.TxtPassword.MaxLength = 10
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(36)
        Me.TxtPassword.Size = New System.Drawing.Size(170, 20)
        Me.TxtPassword.TabIndex = 7
        '
        'ButtOk
        '
        Me.ButtOk.BackColor = System.Drawing.Color.Blue
        Me.ButtOk.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtOk.ForeColor = System.Drawing.Color.White
        Me.ButtOk.Location = New System.Drawing.Point(114, 99)
        Me.ButtOk.Name = "ButtOk"
        Me.ButtOk.Size = New System.Drawing.Size(80, 24)
        Me.ButtOk.TabIndex = 9
        Me.ButtOk.Text = "&OK"
        Me.ButtOk.UseVisualStyleBackColor = False
        '
        'ButtCancel
        '
        Me.ButtCancel.BackColor = System.Drawing.Color.Blue
        Me.ButtCancel.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtCancel.ForeColor = System.Drawing.Color.White
        Me.ButtCancel.Location = New System.Drawing.Point(194, 99)
        Me.ButtCancel.Name = "ButtCancel"
        Me.ButtCancel.Size = New System.Drawing.Size(80, 24)
        Me.ButtCancel.TabIndex = 10
        Me.ButtCancel.Text = "&Cancel"
        Me.ButtCancel.UseVisualStyleBackColor = False
        '
        'Pic
        '
        Me.Pic.Image = CType(resources.GetObject("Pic.Image"), System.Drawing.Image)
        Me.Pic.Location = New System.Drawing.Point(19, 93)
        Me.Pic.Name = "Pic"
        Me.Pic.Size = New System.Drawing.Size(36, 30)
        Me.Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Pic.TabIndex = 11
        Me.Pic.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(104, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Released on : 18/Sep/2011"
        '
        'Login
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(278, 136)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Pic)
        Me.Controls.Add(Me.ButtCancel)
        Me.Controls.Add(Me.ButtOk)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LBUserName)
        Me.Controls.Add(Me.TxtUser)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HBS-Login "
        CType(Me.Pic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub TxtUser_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtUser.GotFocus
        TxtUser.BackColor = TextBoxGotFocusBackColor
    End Sub
    Private Sub TxtUser_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtUser.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        ElseIf e.KeyChar = Microsoft.VisualBasic.ControlChars.Cr Then
            ButtOk_Click(sender, e)
        End If
    End Sub

    Private Sub TxtPassword_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPassword.GotFocus
        TxtPassword.BackColor = TextBoxGotFocusBackColor
    End Sub
    Private Sub TxtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPassword.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        ElseIf e.KeyChar = Microsoft.VisualBasic.ControlChars.Cr Then
            ButtOk_Click(sender, e)
        End If
    End Sub
    Private Sub ButtOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtOk.Click
        Try
            Dim Cmd As New Odbc.OdbcCommand
            Dim Rd As Odbc.OdbcDataReader
            Dim obj As Object = Nothing
            Cmd.Connection = Con

            Cmd.CommandText = "select count(billingid) from DistinctBillNo"
            obj = Cmd.ExecuteScalar
            If Val(obj.ToString) >= 200000 Then
                MsgBox("Trial Period Is Now Over. Please Contact Your Software Vendor.", MsgBoxStyle.Critical)
                Exit Sub
            End If


            If Trim(Me.TxtUser.Text) = Nothing Then
                MsgBox("User Name Can't Be Blank.")
                Me.TxtUser.Focus()
                Exit Sub
            ElseIf Trim(Me.TxtPassword.Text) = Nothing Then
                MsgBox("Password Can't Be Blank.")
                Me.TxtPassword.Focus()
                Exit Sub
            End If

            Cmd.CommandText = "Select UserName From UserAccount Where Ucase(UserName)='" & UCase(Me.TxtUser.Text) & "'"
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            If Rd.HasRows = False Then
                Me.TxtPassword.Text = Nothing
                MsgBox("Invalid User Name.")
                Me.TxtUser.Focus()
                Rd.Close()
                Exit Sub
            ElseIf Rd.HasRows = True Then
                Rd.Close()
                Cmd.CommandText = "SELECT UserAccount.Pass, UserAccount.CallerId FROM UserAccount  Where Ucase(UserName)='" & UCase(Me.TxtUser.Text) & "' and ucase(Pass)='" & UCase(Trim(Me.TxtPassword.Text)) & "'"
                Rd = Cmd.ExecuteReader()
                Rd.Read()
                If Rd.HasRows = False Then
                    Rd.Close()
                    Me.TxtPassword.Text = Nothing
                    MsgBox("Invalid Password.")
                    Exit Sub
                Else
                    UserName = Trim(Me.TxtUser.Text)
                    CallerId = Rd.Item("CallerId") & ""
                    UserCode = Rd.Item("CallerId") & ""

                    If CallerId <> Nothing Then
                        HBSMAIN.ToolStripUserName.Text = UserCode
                        'HBSMAIN.StatusMdi.Text = "User Name: " & StrConv(UserName, VbStrConv.ProperCase)
                    Else
                        'HBSMAIN.StatusMdi.Text = "User Name : " & StrConv(UserName, VbStrConv.ProperCase)
                        HBSMAIN.ToolStripUserName.Text = String.Empty
                    End If
                End If
            End If

            If Rd.IsClosed = False Then Rd.Close()
            Me.Dispose()
        Catch
            MsgBox(Err.Description)
        End Try

    End Sub
    Private Sub Login_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Disposed
        Me.Dispose()
    End Sub

    Private Sub ButtCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtCancel.Click
        End
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
    Public Sub TMD(ByRef TM As HBSMAIN)
        TMDI = TM
    End Sub

    Private Sub TxtUser_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtUser.LostFocus
        TxtUser.BackColor = TextBoxLostFocusBackColor
    End Sub

    Private Sub TxtUser_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUser.TextChanged

    End Sub

    Private Sub TxtPassword_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtPassword.LostFocus
        TxtPassword.BackColor = TextBoxLostFocusBackColor
    End Sub

    Private Sub TxtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPassword.TextChanged

    End Sub
End Class
