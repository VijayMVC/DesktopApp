Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Windows.Forms

Public Class RadiologicalHelp
    Public strSelectedValue As String = String.Empty
    Public Mode As Boolean = False  ' True for new and False for Search
    Public ModeHelp As Short = 0 '1 FOR NEW, 2 for department, 3 for subdepartment , 4 for Services AND 5 for Search
    Public ServiceCodes As String = String.Empty
    Public strReportFor As String = String.Empty
    Public IsPending As Boolean = True
    Public strTableName As String = "RadiologyReportXRay"

    Private Sub SearchRecords()
        Dim strSQL As String = String.Empty
        Label6.Text = "Patient Code/ Name"
        If ModeHelp = 1 Then
            strSQL = "SELECT PatientID,Name from Patient Where  Name  LIKE '" + Me.TXTSEARCH.Text.Trim + "%' or PatientID LIKE '" + Me.TXTSEARCH.Text.Trim + "%'"
        ElseIf ModeHelp = 2 Then
            strSQL = "SELECT DepCode,DepDesc from Department Where  DepDesc  LIKE '" + Me.TXTSEARCH.Text.Trim + "%' or DepCode LIKE '" + Me.TXTSEARCH.Text.Trim + "%'"
        ElseIf ModeHelp = 3 Then
            strSQL = "SELECT SubDepCode,SubDepDesc from SubDepartment Where  SubDepDesc  LIKE '" + Me.TXTSEARCH.Text.Trim + "%' or SubDepCode LIKE '" + Me.TXTSEARCH.Text.Trim + "%'"
        ElseIf ModeHelp = 4 Then
            strSQL = "SELECT ServiceCode As SysServiceCode,UdServiceCode As ServiceCode ,ServiceDesc from Services Where  (ServiceDesc  LIKE '" + Me.TXTSEARCH.Text.Trim + "%' or ServiceCode LIKE '" + Me.TXTSEARCH.Text.Trim + "%' or UdServiceCode LIKE '" + Me.TXTSEARCH.Text.Trim + "%') AND ServiceCode NOT IN (" + IIf(ServiceCodes = "", "''", ServiceCodes) + ")"
            Label6.Text = "Service Code/ Name"
            LBUserName.Text = "Search Service"
            'strSQL = "SELECT SERVICES.SERVICECODE, SERVICES.SERVICEDESC, SUBDEPARTMENT.SUBDEPCODE, SUBDEPARTMENT.SUBDEPDESC, DEPARTMENT.DEPCODE, DEPARTMENT.DEPDESC FROM (SERVICES INNER JOIN SUBDEPARTMENT ON (SERVICES.SUBDEPCODE = SUBDEPARTMENT.SUBDEPCODE) AND (SERVICES.DEPCODE = SUBDEPARTMENT.DEPCODE)) INNER JOIN DEPARTMENT ON SUBDEPARTMENT.DEPCODE = DEPARTMENT.DEPCODE Where  ServiceDesc  LIKE '" + Me.TXTSEARCH.Text.Trim + "%' or ServiceCode LIKE '" + Me.TXTSEARCH.Text.Trim + "%' or  SUBDEPARTMENT.SUBDEPDESC  LIKE '" + Me.TXTSEARCH.Text.Trim + "%' or DEPARTMENT.DEPDESC LIKE '" + Me.TXTSEARCH.Text.Trim + "%'"
        Else 'If ModeHelp = 5 Then
            If IsPending = True Then
                strSQL = "SELECT Distinct Patient.PatientID,Name,BillingID As ReceiptNo,BillingDate as BillDate from Patient,PatientBilling Where PatientBilling.SUBDEPCODE IN('" + strReportFor.Trim + "') AND Patient.PatientID=PatientBilling.PatientID And PatientBilling.PATIENTID+PatientBilling.BILLINGID+PatientBilling.SERVICECODE Not In(Select Distinct " + strTableName + ".PATIENTID+" + strTableName + ".BILLINGID+" + strTableName + ".SERVICECODE From " + strTableName + ") AND (  Name  LIKE '" + Me.TXTSEARCH.Text.Trim + "%' or Patient.PatientID LIKE '" + Me.TXTSEARCH.Text.Trim + "%' or BillingID LIKE '" + Me.TXTSEARCH.Text.Trim + "%' or PatientBilling.UserCode LIKE '" + Me.TXTSEARCH.Text.Trim + "%')  ORDER BY BillingID DESC"
                Label6.Text = "Patient Code/ Name/ ReceiptNo/User"
            Else
                strSQL = "SELECT Distinct Patient.PatientID,Name,BillingID As ReceiptNo,BillingDate as BillDate from Patient,PatientBilling Where PatientBilling.SUBDEPCODE IN('" + strReportFor.Trim + "') AND Patient.PatientID=PatientBilling.PatientID And PatientBilling.PATIENTID+PatientBilling.BILLINGID+PatientBilling.SERVICECODE  In(Select Distinct " + strTableName + ".PATIENTID+" + strTableName + ".BILLINGID+" + strTableName + ".SERVICECODE From " + strTableName + ") AND (  Name  LIKE '" + Me.TXTSEARCH.Text.Trim + "%' or Patient.PatientID LIKE '" + Me.TXTSEARCH.Text.Trim + "%' or BillingID LIKE '" + Me.TXTSEARCH.Text.Trim + "%' or PatientBilling.UserCode LIKE '" + Me.TXTSEARCH.Text.Trim + "%')  ORDER BY BillingID DESC"
                Label6.Text = "Patient Code/ Name/ ReceiptNo/User"
            End If
        End If


        Dim MySqlAdp As New Odbc.OdbcDataAdapter
        Dim MySqlCon As New Odbc.OdbcConnection
        Dim DS As New DataSet
        Try
            MySqlCon = GetAccesscon()
            MySqlAdp = New Odbc.OdbcDataAdapter(strSQL, MySqlCon)
            MySqlAdp.Fill(DS, "SearchTable")
            GridSearch.DataSource = DS.Tables(0)

            GridSearch.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells)
            If ModeHelp = 4 Then
                GridSearch.Columns(0).Visible = False
                GridSearch.Columns(1).Width = 100
                GridSearch.Columns(2).Width = 250
                'If GridSearch.Columns.Count > 2 Then GridSearch.Columns(2).Width = 60
            Else
                GridSearch.Columns(1).Width = 230
                If GridSearch.Columns.Count > 2 Then GridSearch.Columns(2).Width = 60
            End If


        Catch Ex As Exception
            MsgBox(Ex.Message.ToString)
        Finally
            MySqlCon.Dispose()
            MySqlAdp.Dispose()
            DS.Dispose()
        End Try

    End Sub


    Private Sub TXTSEARCH_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTSEARCH.KeyPress
        If Asc(e.KeyChar) = 13 Then CMDOK_Click(sender, e)
    End Sub

    Private Sub TXTSEARCH_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXTSEARCH.TextChanged
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
        SearchRecords()
    End Sub

    Private Sub GridSearch_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles GridSearch.CellContentClick

    End Sub

    Private Sub GridSearch_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridSearch.DoubleClick
        CMDOK_Click(sender, e)
    End Sub

    Private Sub CMDOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CMDOK.Click
        If GridSearch.Rows.Count > 0 Then
            If ModeHelp = 1 Or ModeHelp = 2 Or ModeHelp = 3 Or ModeHelp = 4 Then
                strSelectedValue = GridSearch.CurrentRow.Cells(0).Value.ToString()
            ElseIf ModeHelp = 5 Then
                strSelectedValue = GridSearch.CurrentRow.Cells(2).Value.ToString()
            End If
            Me.Close()
            Me.Dispose()
        End If
    End Sub

    Private Sub CMDOK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMDOK.KeyPress
        If Asc(e.KeyChar) = 13 Then CMDOK_Click(sender, New System.EventArgs)
    End Sub

    Private Sub GridSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridSearch.KeyDown
        If GridSearch.Rows.Count > 0 And e.KeyCode = Keys.Enter Then
            If ModeHelp = 1 Or ModeHelp = 2 Or ModeHelp = 3 Or ModeHelp = 4 Then
                strSelectedValue = GridSearch.CurrentRow.Cells(0).Value.ToString()
            ElseIf ModeHelp = 5 Then
                strSelectedValue = GridSearch.CurrentRow.Cells(2).Value.ToString()
            End If
            Me.Close()
            Me.Dispose()
        End If
    End Sub

    Private Sub GridSearch_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles GridSearch.KeyPress

    End Sub
End Class