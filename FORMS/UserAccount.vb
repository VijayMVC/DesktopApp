Public Class UserAccount
    Inherits System.Windows.Forms.Form
    Dim InsertFlag As Integer
    Dim EditFlag As Integer
    Dim Cmd As New Odbc.OdbcCommand
    Dim x As String
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents LBUserName As System.Windows.Forms.Label
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
    Friend WithEvents ComDelete As System.Windows.Forms.Button
    Friend WithEvents ComSave As System.Windows.Forms.Button
    Friend WithEvents ComExit As System.Windows.Forms.Button
    Friend WithEvents ComEdit As System.Windows.Forms.Button
    Friend WithEvents ComNew As System.Windows.Forms.Button
    Friend WithEvents ComClear As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents TxtUserName As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserAccount))
        Me.GroupMain = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.TxtPassword = New System.Windows.Forms.TextBox
        Me.TxtUserName = New System.Windows.Forms.ComboBox
        Me.GrpDML = New System.Windows.Forms.GroupBox
        Me.ComDelete = New System.Windows.Forms.Button
        Me.ComExit = New System.Windows.Forms.Button
        Me.ComEdit = New System.Windows.Forms.Button
        Me.ComNew = New System.Windows.Forms.Button
        Me.ComClear = New System.Windows.Forms.Button
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
        Me.GroupMain.Controls.Add(Me.Label1)
        Me.GroupMain.Controls.Add(Me.TxtPassword)
        Me.GroupMain.Controls.Add(Me.TxtUserName)
        Me.GroupMain.Location = New System.Drawing.Point(4, 76)
        Me.GroupMain.Name = "GroupMain"
        Me.GroupMain.Size = New System.Drawing.Size(423, 104)
        Me.GroupMain.TabIndex = 0
        Me.GroupMain.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User Name"
        '
        'TxtPassword
        '
        Me.TxtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtPassword.Location = New System.Drawing.Point(112, 58)
        Me.TxtPassword.MaxLength = 10
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.ReadOnly = True
        Me.TxtPassword.Size = New System.Drawing.Size(120, 20)
        Me.TxtPassword.TabIndex = 2
        '
        'TxtUserName
        '
        Me.TxtUserName.Location = New System.Drawing.Point(112, 24)
        Me.TxtUserName.MaxLength = 20
        Me.TxtUserName.Name = "TxtUserName"
        Me.TxtUserName.Size = New System.Drawing.Size(248, 21)
        Me.TxtUserName.TabIndex = 1
        '
        'GrpDML
        '
        Me.GrpDML.Controls.Add(Me.ComDelete)
        Me.GrpDML.Controls.Add(Me.ComExit)
        Me.GrpDML.Controls.Add(Me.ComEdit)
        Me.GrpDML.Controls.Add(Me.ComNew)
        Me.GrpDML.Controls.Add(Me.ComClear)
        Me.GrpDML.Controls.Add(Me.ComSave)
        Me.GrpDML.Location = New System.Drawing.Point(25, 191)
        Me.GrpDML.Name = "GrpDML"
        Me.GrpDML.Size = New System.Drawing.Size(376, 48)
        Me.GrpDML.TabIndex = 3
        Me.GrpDML.TabStop = False
        '
        'ComDelete
        '
        Me.ComDelete.BackColor = System.Drawing.Color.Blue
        Me.ComDelete.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ComDelete.Location = New System.Drawing.Point(152, 16)
        Me.ComDelete.Name = "ComDelete"
        Me.ComDelete.Size = New System.Drawing.Size(72, 24)
        Me.ComDelete.TabIndex = 7
        Me.ComDelete.Text = "&Delete"
        Me.ComDelete.UseVisualStyleBackColor = False
        '
        'ComExit
        '
        Me.ComExit.BackColor = System.Drawing.Color.Blue
        Me.ComExit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComExit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ComExit.Location = New System.Drawing.Point(296, 16)
        Me.ComExit.Name = "ComExit"
        Me.ComExit.Size = New System.Drawing.Size(72, 24)
        Me.ComExit.TabIndex = 9
        Me.ComExit.Text = "&Close"
        Me.ComExit.UseVisualStyleBackColor = False
        '
        'ComEdit
        '
        Me.ComEdit.BackColor = System.Drawing.Color.Blue
        Me.ComEdit.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComEdit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ComEdit.Location = New System.Drawing.Point(80, 16)
        Me.ComEdit.Name = "ComEdit"
        Me.ComEdit.Size = New System.Drawing.Size(72, 24)
        Me.ComEdit.TabIndex = 6
        Me.ComEdit.Text = "&Edit"
        Me.ComEdit.UseVisualStyleBackColor = False
        '
        'ComNew
        '
        Me.ComNew.BackColor = System.Drawing.Color.Blue
        Me.ComNew.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComNew.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ComNew.Location = New System.Drawing.Point(6, 16)
        Me.ComNew.Name = "ComNew"
        Me.ComNew.Size = New System.Drawing.Size(72, 24)
        Me.ComNew.TabIndex = 4
        Me.ComNew.Text = "&New"
        Me.ComNew.UseVisualStyleBackColor = False
        '
        'ComClear
        '
        Me.ComClear.BackColor = System.Drawing.Color.Blue
        Me.ComClear.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComClear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ComClear.Location = New System.Drawing.Point(224, 16)
        Me.ComClear.Name = "ComClear"
        Me.ComClear.Size = New System.Drawing.Size(72, 24)
        Me.ComClear.TabIndex = 8
        Me.ComClear.Text = "&Cancel"
        Me.ComClear.UseVisualStyleBackColor = False
        '
        'ComSave
        '
        Me.ComSave.BackColor = System.Drawing.Color.Blue
        Me.ComSave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ComSave.Location = New System.Drawing.Point(8, 16)
        Me.ComSave.Name = "ComSave"
        Me.ComSave.Size = New System.Drawing.Size(72, 24)
        Me.ComSave.TabIndex = 5
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
        Me.LBUserName.Location = New System.Drawing.Point(233, 2)
        Me.LBUserName.Name = "LBUserName"
        Me.LBUserName.Size = New System.Drawing.Size(194, 25)
        Me.LBUserName.TabIndex = 8
        Me.LBUserName.Text = "USER ACCOUNT"
        Me.LBUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'UserAccount
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
        Me.Name = "UserAccount"
        Me.Text = "UserAccount"
        Me.GroupMain.ResumeLayout(False)
        Me.GroupMain.PerformLayout()
        Me.GrpDML.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub ComClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComClear.Click
        On Error Resume Next
        InsertFlag = 0
        EditFlag = 0
        Me.ComNew.Visible = True : Me.ComNew.Enabled = True
        Me.ComSave.Visible = False : Me.ComSave.Enabled = True
        Me.ComDelete.Enabled = False
        Me.ComEdit.Enabled = False
        Me.ComClear.Enabled = False
        ComDelete.Enabled = False
        Me.TxtPassword.ReadOnly = True
        Blank()
        GetUser()
        TxtUserName.Focus()
    End Sub
    Private Sub ComNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComNew.Click
        On Error GoTo rr
        Me.TxtUserName.DropDownStyle = ComboBoxStyle.Simple
        InsertFlag = 1
        EditFlag = 0
        Me.ComNew.Visible = False : Me.ComNew.Enabled = False
        Me.ComSave.Visible = True : Me.ComSave.Enabled = True
        Me.ComDelete.Enabled = False
        Me.ComEdit.Enabled = False
        Me.ComClear.Enabled = True
        Me.TxtPassword.ReadOnly = False
        Blank()
        GetCaller()
        TxtUserName.Focus()
        Exit Sub
rr:
        MsgBox(Err.Description)
    End Sub
    Private Sub ComEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComEdit.Click
        On Error GoTo rr
        InsertFlag = 0
        EditFlag = 1
        Me.ComNew.Visible = False : Me.ComNew.Enabled = False
        Me.ComSave.Visible = True : Me.ComSave.Enabled = True
        Me.ComDelete.Enabled = False
        Me.ComEdit.Enabled = False
        Me.ComClear.Enabled = True
        Me.TxtPassword.ReadOnly = False
        Exit Sub
rr:
        MsgBox(Err.Description)
    End Sub
    Private Sub Blank()
        Me.TxtUserName.Items.Clear()
        Me.TxtUserName.Text = Nothing
        Me.TxtPassword.Text = Nothing
        CallerId = Nothing
    End Sub
    Private Sub ComSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComSave.Click
        If Trim(Me.TxtUserName.Text) = Nothing Then
            MsgBox("User Name Can't Be Blank.")
            Me.TxtUserName.Focus()
            Exit Sub
        ElseIf Trim(Me.TxtPassword.Text) = Nothing Then
            MsgBox("Password Can't Be Blank.")
            Me.TxtPassword.Focus()
            Exit Sub
        End If

        Try
            If InsertFlag = 1 Then
                Cmd.CommandText = "Insert Into UserAccount(UserName,CallerId,Pass) values('" & Trim(Me.TxtUserName.Text) & "','" & Trim(Me.TxtUserName.Text) & "','" & Trim(Me.TxtPassword.Text) & "')"
                Cmd.ExecuteNonQuery()
            ElseIf EditFlag = 1 Then
                Cmd.CommandText = "Update UserAccount Set Pass='" & Trim(Me.TxtPassword.Text) & "' Where ucase(UserName)='" & UCase(Trim(Mid(Me.TxtUserName.SelectedItem, 1, InStr(Me.TxtUserName.SelectedItem, "^") - 1))) & "'"
                Cmd.ExecuteNonQuery()
            End If

            InsertFlag = 0
            EditFlag = 0
            Me.TxtUserName.Text = ""
            Me.TxtPassword.Text = Nothing
            Me.ComNew.Visible = True : Me.ComNew.Enabled = True
            Me.ComSave.Visible = False : Me.ComSave.Enabled = False
            Me.ComDelete.Enabled = False
            Me.TxtPassword.ReadOnly = True
            ComClear.Enabled = False
            GetUser()
            MsgBox("Saved Successfully.")
            TxtUserName.Focus()
        Catch
            If Err.Number = 5 Then
                MsgBox("User Name Already Exists.")
                Exit Sub
            Else
                MsgBox(Err.Description)
            End If
        End Try
    End Sub
    Private Sub GetUser()
        Dim Dreader As Odbc.OdbcDataReader
        TxtUserName.Text = ""
        TxtUserName.Items.Clear()
        Me.TxtUserName.DropDownStyle = ComboBoxStyle.DropDownList
        Cmd.CommandText = "Select UserName,Pass From UserAccount Order By UserName"
        Dreader = Cmd.ExecuteReader
        While Dreader.Read()
            Me.TxtUserName.Items.Add(Trim(Dreader.Item("UserName") & "") & Space(100) & "^" & Trim(Dreader.Item("Pass") & ""))
        End While
        Dreader.Close()
    End Sub

    Private Sub UserAccount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = "'" Then e.Handled = True
        If e.KeyChar = Chr(Keys.Escape) Then
            Me.ComClear_Click(sender, New System.EventArgs())
        End If
    End Sub
    Private Sub UserAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        On Error GoTo rr
        Cmd = New Odbc.OdbcCommand
        Cmd.Connection = Con
        ComClear_Click(sender, e)
        GetUser()
        UserName = "Admin"
        Me.KeyPreview = True
        Exit Sub
rr:
        MsgBox(Err.Description)
    End Sub
    Private Sub TxtUserName_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub
    Private Sub TxtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPassword.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub
    Private Sub TxtUserName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtUserName.SelectedIndexChanged
        Dim Rd As Odbc.OdbcDataReader
        Try
            If InsertFlag <> 1 Then
                Me.TxtPassword.Text = Mid(TxtUserName.SelectedItem, InStr(TxtUserName.SelectedItem, "^") + 1, Len(TxtUserName.SelectedItem))
                Me.ComEdit.Enabled = True
                If UCase(UserName) = "ADMIN" Then
                    Me.ComDelete.Enabled = True
                Else
                    Me.ComDelete.Enabled = False
                End If

                'If UCase(Trim(Mid(Me.TxtUserName.SelectedItem, 1, InStr(Me.TxtUserName.SelectedItem, "^") - 1))) <> "ADMIN" Then

                'Else
                CallerId = Nothing
                'End If

            End If
        Catch
            MsgBox(Err.Description)
            If Rd.IsClosed = False Then Rd.Close()
        End Try

    End Sub
    Private Sub ComDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComDelete.Click
        Try
            If MsgBox("Are You Sure To Delete This Record?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                If UCase(Trim(Mid(Me.TxtUserName.SelectedItem, 1, InStr(Me.TxtUserName.SelectedItem, "^") - 1))) = "ADMIN" Then
                    MsgBox("This User Can't Be Deleted.")
                    Exit Sub
                End If
                Cmd.CommandText = "Delete From UserAccount Where ucase(UserName)='" & UCase(Trim(Mid(Me.TxtUserName.SelectedItem, 1, InStr(Me.TxtUserName.SelectedItem, "^") - 1))) & "'"
                Cmd.ExecuteNonQuery()
                ComClear_Click(sender, e)
                MsgBox("Deleted Successfully.")
            End If
        Catch
            MsgBox(Err.Description)
        End Try

    End Sub

    Private Sub GetCaller()
        'Dim Dreader As Odbc.OdbcDataReader
        'Me.ComCaller.Text = ""
        'ComCaller.Items.Clear()
        'Me.ComCaller.DropDownStyle = ComboBoxStyle.DropDownList
        'Cmd.CommandText = "Select CallerName,CallerId From CallerMst Order By CallerName"
        'Dreader = Cmd.ExecuteReader
        'Me.ComCaller.Items.Add("")
        'While Dreader.Read()
        '    Me.ComCaller.Items.Add(Trim(Dreader.Item("CallerName") & "") & Space(100) & "^" & Trim(Dreader.Item("CallerId") & ""))
        'End While
        'Dreader.Close()
    End Sub
    Private Sub ComExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComExit.Click
        Me.Dispose()
    End Sub
    Private Sub ComCaller_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.Handled = True
    End Sub

    Private Sub ComCaller_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComCaller_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            e.Handled = True
        End If
    End Sub
End Class
