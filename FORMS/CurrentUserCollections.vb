Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Windows.Forms
Public Class CurrentUserCollections
    Public strSelectedValue As String = String.Empty
    
    Private Sub SearchRecordsUserWise()
        Dim strSQL As String = "SELECT PatientBilling.USERCODE,format( PatientBilling.BillingDate,'dd/MMM/yyyy') AS BillingDate1,  Sum(PatientBilling.CHARGE) AS TotAmount, Sum(PatientBilling.DISCOUNT) AS TotalDiscount, Sum(PatientBilling.CHARGE)-Sum(Discount) AS NetAmount FROM PatientBilling INNER JOIN SERVICES ON PatientBilling.SERVICECODE = SERVICES.SERVICECODE WHERE (((PatientBilling.ISCANCELLED)=0) AND ((PatientBilling.BILLINGDATE)>=CDate('" + Me.TxtFromDate.Value.ToString("dd/MMM/yyyy") + "') And (PatientBilling.BILLINGDATE)<=CDate('" + Me.TxtToDate.Value.ToString("dd/MMM/yyyy") + "'))) GROUP BY  PatientBilling.USERCODE,PatientBilling.BillingDate Having PatientBilling.USERCODE ='" & UserName & "'"
        Dim MySqlAdp As New Odbc.OdbcDataAdapter
        Dim MySqlCon As New Odbc.OdbcConnection
        Dim Cmd As New Odbc.OdbcCommand
        Dim obj As Object = Nothing
        Dim DS As New DataSet
        Try
            MySqlCon = GetAccesscon()
            MySqlAdp = New Odbc.OdbcDataAdapter(strSQL, MySqlCon)
            MySqlAdp.Fill(DS, "SearchTable")
            DGUserWise.DataSource = DS.Tables(0)
            DGUserWise.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells)
            DGUserWise.Columns(0).Width = 350
            DGUserWise.Columns(1).Width = 150
            DGUserWise.Columns(2).Width = 100

            DGUserWise.Columns(3).Width = 100
            DGUserWise.Columns(4).Width = 150



            DGUserWise.Columns(0).HeaderText = "User ID"
            DGUserWise.Columns(1).HeaderText = "Date"
            DGUserWise.Columns(2).HeaderText = "Collected_Amount"
            DGUserWise.Columns(3).HeaderText = "Discount"
            DGUserWise.Columns(4).HeaderText = "Total_Collected_Amount"




        Catch Ex As Exception
            MsgBox(Ex.Message.ToString)
        Finally
            MySqlCon.Dispose()
            MySqlAdp.Dispose()
            DS.Dispose()
            obj = Nothing
        End Try
    End Sub
    Private Sub TXTSEARCH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    

    Private Sub CMDCANCEL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDCANCEL.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub Help_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
    End Sub

    Private Sub Help_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.KeyPreview = True
        Me.TxtFromDate.Value = DateTime.Now
        Me.TxtToDate.Value = DateTime.Now
        LBUserName.Text = "Cash Collection By " + UserName.ToUpper
        SearchRecordsUserWise()
        PgBar.Minimum = 0
        PgBar.Maximum = 100
    End Sub




    Private Sub TmrPgBar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrPgBar.Tick
        If PgBar.Value >= PgBar.Maximum Then
            PgBar.Minimum = 0
            PgBar.Maximum = 100
            PgBar.Value = 0
            SearchRecordsUserWise()
        End If
        PgBar.Value = PgBar.Value + 1
    End Sub

    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        PrintUserCollection(Me.DGUserWise, Me.TxtFromDate.Value, Me.TxtToDate.Value, "Individual")
    End Sub
End Class