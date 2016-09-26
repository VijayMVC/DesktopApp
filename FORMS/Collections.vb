Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Windows.Forms
Imports System.IO

Public Class Collections
    Public strSelectedValue As String = String.Empty
    Dim Blncombofill As Boolean = False
    Private Sub SearchRecords()
        Dim strSQL As String
        If RDService.Checked = True Then
            If CmbManufacturer.SelectedValue.ToString().Trim.ToUpper = "ALL" Then
                BtnPrintDepartmentCollection.Text = "&Print All Departments Wise Collection"
                strSQL = "SELECT '' as BILLINGID,SERVICES.SERVICECODE, SERVICES.SERVICEDESC,format( BillingDate,'dd/MMM/yyyy') as BILLDATE,sum(PatientBilling.CHARGE) As TotAmount,Sum(Discount) As TotalDiscount,sum( PatientBilling.CHARGE)-Sum(Discount) As NetAmount FROM PatientBilling INNER JOIN SERVICES ON PatientBilling.SERVICECODE = SERVICES.SERVICECODE Where  ISCANCELLED=0 and BILLINGDATE >=cdate('" + Me.TxtFromDate.Value.ToString("dd/MMM/yyyy") + "') and BILLINGDATE<=cdate( '" + Me.TxtToDate.Value.ToString("dd/MMM/yyyy") + "') and ServiceDesc Like '%" + TxtSearch.Text.Trim + "%' Group By SERVICES.SERVICECODE, SERVICES.SERVICEDESC,BILLINGDATE Order By BILLINGDATE,SERVICES.SERVICEDESC"
            Else
                strSQL = "SELECT '' as BILLINGID,SERVICES.SERVICECODE, SERVICES.SERVICEDESC,format( BillingDate,'dd/MMM/yyyy') as BILLDATE,sum(PatientBilling.CHARGE) As TotAmount,Sum(Discount) As TotalDiscount,sum( PatientBilling.CHARGE)-Sum(Discount) As NetAmount FROM PatientBilling INNER JOIN SERVICES ON PatientBilling.SERVICECODE = SERVICES.SERVICECODE Where SERVICES.SUBDEPCODE='" + CmbManufacturer.SelectedValue.ToString().Trim + "' and ISCANCELLED=0 and BILLINGDATE >=cdate('" + Me.TxtFromDate.Value.ToString("dd/MMM/yyyy") + "') and BILLINGDATE<=cdate( '" + Me.TxtToDate.Value.ToString("dd/MMM/yyyy") + "') and ServiceDesc Like '%" + TxtSearch.Text.Trim + "%' Group By SERVICES.SERVICECODE, SERVICES.SERVICEDESC,BILLINGDATE Order By BILLINGDATE,SERVICES.SERVICEDESC"
                BtnPrintDepartmentCollection.Text = "&Print " + CmbManufacturer.Text.ToString().Trim + " Wise Collection"
            End If
        Else
            If CmbManufacturer.SelectedValue.ToString().Trim.ToUpper = "ALL" Then
                BtnPrintDepartmentCollection.Text = "&Print All Departments Wise Collection"
                strSQL = "SELECT BILLINGID ,SERVICES.SERVICECODE, SERVICES.SERVICEDESC,format( BillingDate,'dd/MMM/yyyy') as BILLDATE,sum(PatientBilling.CHARGE) As TotAmount,Sum(Discount) As TotalDiscount,sum( PatientBilling.CHARGE)-Sum(Discount) As NetAmount FROM PatientBilling INNER JOIN SERVICES ON PatientBilling.SERVICECODE = SERVICES.SERVICECODE Where  ISCANCELLED=0 and BILLINGDATE >=cdate('" + Me.TxtFromDate.Value.ToString("dd/MMM/yyyy") + "') and BILLINGDATE<=cdate( '" + Me.TxtToDate.Value.ToString("dd/MMM/yyyy") + "') and ServiceDesc Like '%" + TxtSearch.Text.Trim + "%' Group By SERVICES.SERVICECODE, SERVICES.SERVICEDESC,BILLINGDATE,BILLINGID Order By BILLINGID,BILLINGDATE,SERVICES.SERVICEDESC"
            Else
                strSQL = "SELECT BILLINGID,SERVICES.SERVICECODE, SERVICES.SERVICEDESC,format( BillingDate,'dd/MMM/yyyy') as BILLDATE,sum(PatientBilling.CHARGE) As TotAmount,Sum(Discount) As TotalDiscount,sum( PatientBilling.CHARGE)-Sum(Discount) As NetAmount FROM PatientBilling INNER JOIN SERVICES ON PatientBilling.SERVICECODE = SERVICES.SERVICECODE Where SERVICES.SUBDEPCODE='" + CmbManufacturer.SelectedValue.ToString().Trim + "' and ISCANCELLED=0 and BILLINGDATE >=cdate('" + Me.TxtFromDate.Value.ToString("dd/MMM/yyyy") + "') and BILLINGDATE<=cdate( '" + Me.TxtToDate.Value.ToString("dd/MMM/yyyy") + "') and ServiceDesc Like '%" + TxtSearch.Text.Trim + "%' Group By SERVICES.SERVICECODE, SERVICES.SERVICEDESC,BILLINGDATE,BILLINGID Order By BILLINGID,BILLINGDATE,SERVICES.SERVICEDESC"
                BtnPrintDepartmentCollection.Text = "&Print " + CmbManufacturer.Text.ToString().Trim + " Wise Collection"
            End If

        End If


        Dim MySqlAdp As New Odbc.OdbcDataAdapter
        Dim MySqlCon As New Odbc.OdbcConnection
        Dim Cmd As New Odbc.OdbcCommand
        Dim obj As Object = Nothing
        Dim DS As New DataSet
        Try
            MySqlCon = GetAccesscon()
            MySqlAdp = New Odbc.OdbcDataAdapter(strSQL, MySqlCon)
            MySqlAdp.Fill(DS, "SearchTable")
            GridSearch.DataSource = DS.Tables(0)
            GridSearch.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells)

            If RDService.Checked = True Then
                GridSearch.Columns(0).Visible = False
                GridSearch.Columns(1).Visible = False
                GridSearch.Columns(2).Width = 400
                GridSearch.Columns(3).Width = 100
                GridSearch.Columns(4).Width = 100
                GridSearch.Columns(5).Width = 100
                GridSearch.Columns(6).Width = 100

                GridSearch.Columns(2).HeaderText = "Service_Name"
                GridSearch.Columns(4).HeaderText = "Service_Amount"
                GridSearch.Columns(5).HeaderText = "Discount"
                GridSearch.Columns(6).HeaderText = "Total_Amount"
            Else
                GridSearch.Columns(0).Visible = True
                GridSearch.Columns(1).Visible = False
                GridSearch.Columns(2).Width = 400
                GridSearch.Columns(3).Width = 100
                GridSearch.Columns(4).Width = 100
                GridSearch.Columns(5).Width = 100
                GridSearch.Columns(6).Width = 100

                GridSearch.Columns(0).HeaderText = "Receipt No"
                GridSearch.Columns(2).HeaderText = "Service_Name"
                GridSearch.Columns(4).HeaderText = "Service_Amount"
                GridSearch.Columns(5).HeaderText = "Discount"
                GridSearch.Columns(6).HeaderText = "Total_Amount"

            End If


            Dim d As New System.Windows.Forms.DataGridViewTextBoxEditingControl
            d.TextAlign = HorizontalAlignment.Right
            Cmd.Connection = MySqlCon
            Cmd.CommandType = CommandType.Text
            Cmd.CommandText = "SELECT sum(PatientBilling.CHARGE)-Sum(Discount) As NetAmount FROM PatientBilling INNER JOIN SERVICES ON PatientBilling.SERVICECODE = SERVICES.SERVICECODE Where  ServiceDesc Like '%" + TxtSearch.Text.Trim + "%' and ISCANCELLED=0 and BILLINGDATE >=cdate('" + Me.TxtFromDate.Value.ToString("dd/MMM/yyyy") + "') and BILLINGDATE<=cdate( '" + Me.TxtToDate.Value.ToString("dd/MMM/yyyy") + "') "
            obj = Cmd.ExecuteScalar()
            If IsDBNull(obj) = False Then
                Me.LblTotCol.Text = Val(obj.ToString()).ToString("#############.00")
                LblTot.Text = "Total Collection From " + Me.TxtFromDate.Value.ToString("dd/MMM/yyyy") + " To " + Me.TxtToDate.Value.ToString("dd/MMM/yyyy") + " Is " + Me.LblTotCol.Text
            Else
                Me.LblTotCol.Text = 0
                LblTot.Text = "Total Collection From " + Me.TxtFromDate.Value.ToString("dd/MMM/yyyy") + " To " + Me.TxtToDate.Value.ToString("dd/MMM/yyyy") + " Is " + Me.LblTotCol.Text
            End If


            SearchRecordsUserWise()

        Catch Ex As Exception
            MsgBox(Ex.Message.ToString)
        Finally
            MySqlCon.Dispose()
            MySqlAdp.Dispose()
            DS.Dispose()
            obj = Nothing
        End Try
    End Sub
    Private Sub SearchRecordsUserWise()
        Dim strSQL As String = "SELECT PatientBilling.USERCODE,format( PatientBilling.BillingDate,'dd/MMM/yyyy') AS BillingDate1,  Sum(PatientBilling.CHARGE) AS TotAmount, Sum(PatientBilling.DISCOUNT) AS TotalDiscount, Sum(PatientBilling.CHARGE)-Sum(Discount) AS NetAmount FROM PatientBilling INNER JOIN SERVICES ON PatientBilling.SERVICECODE = SERVICES.SERVICECODE WHERE (((PatientBilling.ISCANCELLED)=0) AND ((PatientBilling.BILLINGDATE)>=CDate('" + Me.TxtFromDate.Value.ToString("dd/MMM/yyyy") + "') And (PatientBilling.BILLINGDATE)<=CDate('" + Me.TxtToDate.Value.ToString("dd/MMM/yyyy") + "'))) GROUP BY  PatientBilling.USERCODE,PatientBilling.BillingDate "
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
    Private Sub TXTSEARCH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SearchRecords()
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
        FillCombo()
        SearchRecords()
        PgBar.Minimum = 0
        PgBar.Maximum = 100
    End Sub
    Private Sub CMDOK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        SearchRecords()
    End Sub

    Private Sub TmrRefresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SearchRecords()
    End Sub

  
    Private Sub TxtSearch_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSearch.TextChanged
        SearchRecords()
    End Sub

    Private Sub TmrPgBar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrPgBar.Tick
        If PgBar.Value >= PgBar.Maximum Then
            PgBar.Minimum = 0
            PgBar.Maximum = 100
            PgBar.Value = 0
            SearchRecords()
        End If
        PgBar.Value = PgBar.Value + 1
    End Sub
    Private Sub FillCombo()
        Dim MySqlCon As New Odbc.OdbcConnection()
        Dim MysqlCmd As New Odbc.OdbcCommand
        MySqlCon = GetAccesscon()
        Dim DS As New DataSet
        Dim MySqlAdp As Odbc.OdbcDataAdapter
        Blncombofill = True
        Try
            MySqlAdp = New Odbc.OdbcDataAdapter("SELECT Distinct  'ALL' As DEPCODE,'ALL' As DEPDESC  FROM SUBDEPARTMENT Union  SELECT SUBDEPCODE as DEPCODE,SUBDEPDESC as DEPDESC FROM SUBDEPARTMENT ", MySqlCon)
            MySqlAdp.Fill(DS, "TAB1")
            Me.CmbManufacturer.DataSource = DS.Tables("TAB1")
            Me.CmbManufacturer.ValueMember = "DEPCODE"
            Me.CmbManufacturer.DisplayMember = "DEPDESC"
            MySqlAdp.Dispose()

        Catch Ex As Exception
            MsgBox(Ex.Message)
        Finally
            Blncombofill = False
            MySqlCon.Dispose()
        End Try

    End Sub
    Private Sub CmbManufacturer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbManufacturer.SelectedIndexChanged
        If Blncombofill = False Then SearchRecords()
    End Sub

    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click
        PrintUserCollection(Me.DGUserWise, Me.TxtFromDate.Value, Me.TxtToDate.Value, "ALL")
    End Sub

    Private Sub BtnPrintDepartmentCollection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintDepartmentCollection.Click
        If Me.RDService.Checked = True Then
            PrintDepartmentCollection(Me.GridSearch, Me.TxtFromDate.Value, Me.TxtToDate.Value, Me.CmbManufacturer.Text.ToUpper)
        Else
            PrintDepartmentCollectionReceiptWise(Me.GridSearch, Me.TxtFromDate.Value, Me.TxtToDate.Value, Me.CmbManufacturer.Text.ToUpper)
        End If
    End Sub

    Private Sub RDReceipt_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles RDReceipt.CheckedChanged
        SearchRecords()
    End Sub
End Class