Public Class HBSMAIN
    Private Declare Function SQLConfigDataSource Lib "odbccp32.dll" _
 (ByVal hwndParent As Long, _
ByVal fRequest As Integer, _
ByVal lpszDriver As String, _
ByVal lpszAttributes As String) As Long

    Private Sub HBS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Try
        'CreateDSN()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        Try
            GetPrinterPort()
            'ToolStripMenuItem1.Visible = False 'cash status
            ReportsToolStripMenuItem.Visible = False
            CashCollectionSummaryToolStripMenuItem.Visible = False
            ToolStripMenuItem2.Visible = False
            ChangeDiscountPasswordToolStripMenuItem.Visible = False
            AboutUsToolStripMenuItem.Visible = True

            SecurityToolStripMenuItem.Visible = False
            Dim L As New Login
            Con = New Odbc.OdbcConnection("DSN=BILLING;FIL=MS Access;MaxBufferSize=2048;PageTimeout=5;PWD=management;UID=admin;")
            Con.Open()
            L.TMD(Me)
            L.ShowDialog()
            If UserCode.ToUpper.Trim = "ADMIN" Then
                ToolStripMenuItem1.Visible = True
                ReportsToolStripMenuItem.Visible = False
                CashCollectionSummaryToolStripMenuItem.Visible = False
                ToolStripMenuItem2.Visible = True
                ChangeDiscountPasswordToolStripMenuItem.Visible = True
                SecurityToolStripMenuItem.Visible = True
                AboutUsToolStripMenuItem.Visible = True
            End If

        Catch
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub DepartmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DepartmentToolStripMenuItem.Click
        Dim Frm As New Departments
        Frm.Owner = Me
        Frm.MdiParent = Me
        Frm.BringToFront()
        My.Forms.Departments.MdiParent = Me
        Frm.Show()
        Frm.Top = 0
        Frm.Left = 0
        Frm.Icon = Me.Icon
    End Sub

    Private Sub SubDepartmentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubDepartmentToolStripMenuItem.Click
        Dim Frm As New SubDepartments
        Frm.Owner = Me
        Frm.MdiParent = Me
        Frm.BringToFront()
        My.Forms.Departments.MdiParent = Me
        Frm.Show()
        Frm.Top = 0
        Frm.Left = 0
        Frm.Icon = Me.Icon
    End Sub

    Private Sub ServicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ServicesToolStripMenuItem.Click
        Dim Frm As New Services
        Frm.Owner = Me
        Frm.MdiParent = Me
        Frm.BringToFront()
        My.Forms.Departments.MdiParent = Me
        Frm.Show()
        Frm.Top = 0
        Frm.Left = 0
        Frm.Icon = Me.Icon
    End Sub

    Private Sub PatientRegistrationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PatientRegistrationToolStripMenuItem.Click
        Dim Frm As New Registration
        Frm.Owner = Me
        Frm.MdiParent = Me
        Frm.BringToFront()
        My.Forms.Departments.MdiParent = Me
        Frm.Show()
        Frm.Top = 0
        Frm.Left = 0
        Frm.Icon = Me.Icon
    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        Dim Frm As New UserAccount
        Frm.Owner = Me
        Frm.MdiParent = Me
        Frm.BringToFront()
        My.Forms.Departments.MdiParent = Me
        Frm.Show()
        Frm.Top = 0
        Frm.Left = 0
        Frm.Icon = Me.Icon
    End Sub

    Private Sub ChangeDiscountPasswordToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChangeDiscountPasswordToolStripMenuItem.Click
        Dim Frm As New OtherPasswords
        Frm.Owner = Me
        Frm.MdiParent = Me
        Frm.BringToFront()
        Frm.Show()
        Frm.Top = 0
        Frm.Left = 0
        Frm.Icon = Me.Icon
    End Sub

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        Application.Exit()
       
    End Sub


    Private Sub AboutUsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutUsToolStripMenuItem.Click
        Dim Frm As New AboutUs
        Frm.Owner = Me
        'Frm.MdiParent = Me
        Frm.BringToFront()
        ' My.Forms.Departments.MdiParent = Me
        Frm.Top = 0
        Frm.Left = 0
        Frm.Icon = Me.Icon
        Frm.ShowDialog()
        
    End Sub





    Private Sub BillingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillingToolStripMenuItem.Click
        Dim Frm As New PatinetBilling
        Frm.Owner = Me
        Frm.MdiParent = Me
        Frm.BringToFront()
        Frm.Show()
        Frm.Top = 0
        Frm.Left = 0
        Frm.Icon = Me.Icon

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        If UserCode.ToUpper.Trim = "ADMIN" Then
            Dim Frm As New Collections
            Frm.Owner = Me
            Frm.MdiParent = Me
            Frm.BringToFront()
            Frm.Show()
            Frm.Top = 0
            Frm.Left = 0
            Frm.Icon = Me.Icon
        Else
            Dim Frm As New CurrentUserCollections
            Frm.Owner = Me
            Frm.MdiParent = Me
            Frm.BringToFront()
            Frm.Show()
            Frm.Top = 0
            Frm.Left = 0
            Frm.Icon = Me.Icon
        End If
    End Sub

    Private Sub ToolStripLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel1.Click
        DepartmentToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click
        SubDepartmentToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ToolStripLabel3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel3.Click
        ServicesToolStripMenuItem_Click(sender, e)
    End Sub

    Private Sub ToolStripLabel4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel4.Click
        PatientRegistrationToolStripMenuItem_Click(sender, e)
    End Sub
    Private Sub BackupDatabseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupDatabseToolStripMenuItem.Click
        Try
            If System.IO.Directory.Exists("Billing_DBBackup") = False Then
                System.IO.Directory.CreateDirectory("Billing_DBBackup")
            End If
            System.IO.File.Copy("Billing.mdb", "Billing_DBBackup\Billing" + DateTime.Now.ToString("ddMMMyyyyHHmmtt") + ".mdb")
            MsgBox("Backup Done Successfully With File Name " + DateTime.Now.ToString("ddMMMyyyyHHmmtt") + ".mdb", MsgBoxStyle.Information)
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Information)
        End Try

    End Sub

    Public Sub CreateDSN()
        Dim AdSystemDsn As Integer
        On Error Resume Next
        '============Creating DSN============================
        MsgBox(Application.StartupPath + "\BILLING.mdb")
        'AdSystemDsn = SQLConfigDataSource(0, 1, "Microsoft Access Driver (*.mdb)", "DSN=Inven" & Chr(0) & "DBQ=E:\Company\HBS\HBS\bin\Debug\BILLING.mdb" & Chr(0) & "UID=Admin" & Chr(0))
        AdSystemDsn = SQLConfigDataSource(0, 1, "Microsoft Access Driver (*.mdb)", "DSN=Inventory" & Chr(0) & "DBQ=" & "E:\Company\HBS\HBS\bin\Debug\BILLING.mdb" & Chr(0) & "UID=Admin" & Chr(0) & "Password=management")
        '& "Password=management")
        If Val(AdSystemDsn) = 0 Then
            MsgBox("DSN Not Found")
            Exit Sub
        End If
        '============Creating DSN============================
    End Sub

   
    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Dim Frm As New DateWisePatientReceipt
        Frm.Owner = Me
        Frm.MdiParent = Me
        Frm.BringToFront()
        Frm.Show()
        Frm.Top = 0
        Frm.Left = 0
        Frm.Icon = Me.Icon
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Frm As New RadiologyReport
        Frm.strReportFor = "SD0003" ' X-ray
        Frm.strTableName = "RadiologyReportXRay"
        Frm.Owner = Me
        Frm.MdiParent = Me
        Frm.BringToFront()
        Frm.Show()
        Frm.Top = 0
        Frm.Left = 0
        Frm.Icon = Me.Icon
    End Sub

    Private Sub ToolStripLabel5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ToolStripMenuItem4_Click(sender, e)
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Frm As New RadiologyReport
        Frm.strReportFor = "SD0008" ' USG
        Frm.strTableName = "RadiologyReportUltrasound"
        Frm.Owner = Me
        Frm.MdiParent = Me
        Frm.BringToFront()
        Frm.Show()
        Frm.Top = 0
        Frm.Left = 0
        Frm.Icon = Me.Icon
    End Sub

    Private Sub ToolStripLabel6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ToolStripMenuItem5_Click(sender, e)
    End Sub

    Private Sub ToolStripLabel7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Frm As New AdminView
        Frm.Owner = Me
        Frm.MdiParent = Me
        Frm.BringToFront()
        Frm.Show()
        Frm.Top = 0
        Frm.Left = 0
        Frm.Icon = Me.Icon
    End Sub
End Class
