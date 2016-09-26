Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class ReportViewer
    Public strReceiptNo As String = String.Empty
    Private Sub CRVIEW_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CRVIEW.Load

    End Sub

    Private Sub ReportViewer_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim RdAddSold As New ReportDocument
        Dim fPath As String

        Dim MySqlCon As New Odbc.OdbcConnection
        Dim MySqlDataRd As Odbc.OdbcDataReader
        Dim MySqlCmd As New Odbc.OdbcCommand
        Dim HOSPNAME As String = String.Empty
        Dim HOSPADD As String = String.Empty
        Dim HOSPPHONE As String = String.Empty
        Dim HOSPNAME1 As String = String.Empty

        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo
        Dim CrTables As Tables
        Dim CrTable As Table

        MySqlCon = GetAccesscon()
        MySqlCmd.Connection = MySqlCon

        Try
            MySqlCmd.CommandText = ""
            MySqlCmd.CommandText = "SELECT HOSPNAME,HOSPADD,HOSPPHONE,HOSPNAME1 FROM HOSPDETAIL "
            MySqlDataRd = MySqlCmd.ExecuteReader()
            If (MySqlDataRd.HasRows = True) Then
                While (MySqlDataRd.Read)
                    HOSPNAME = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("HOSPNAME")).ToString()
                    HOSPNAME1 = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("HOSPNAME1")).ToString()
                    HOSPADD = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("HOSPADD")).ToString()
                    HOSPPHONE = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("HOSPPHONE")).ToString()
                End While
            End If
            MySqlDataRd.Close()
            Me.CRVIEW.DisplayGroupTree = False
            fPath = Application.StartupPath + "\Bill.rpt"

            RdAddSold.Load(fPath)
            
            With crConnectionInfo
                .ServerName = "BILLING"
                .DatabaseName = "BILLING.mdb"
                .UserID = "admin"
                .Password = "management"
            End With

            CrTables = RdAddSold.Database.Tables
            For Each CrTable In CrTables
                crtableLogoninfo = CrTable.LogOnInfo
                crtableLogoninfo.ConnectionInfo = crConnectionInfo
                CrTable.ApplyLogOnInfo(crtableLogoninfo)
            Next


            RdAddSold.DataDefinition.FormulaFields("HOSPNAME").Text = "'" + HOSPNAME + "'"
            RdAddSold.DataDefinition.FormulaFields("HOSPNAME1").Text = "'" + HOSPNAME1 + "'"
            RdAddSold.DataDefinition.FormulaFields("HOSPADD").Text = "'" + HOSPADD + "'"
            RdAddSold.DataDefinition.FormulaFields("HOSPPHONE").Text = "'" + HOSPPHONE + "'"
            Me.CRVIEW.SelectionFormula = "{PatientBilling.BillingID}='" + strReceiptNo.Trim + "'"
            Me.CRVIEW.ReportSource = RdAddSold

            Me.CRVIEW.RefreshReport()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally
            MySqlCon.Dispose()
            MySqlCmd.Dispose()
        End Try


        Try
           
            'Next

            'RdAddSold.DataDefinition.FormulaFields("AsonDate").Text = "'" + Me.DtpPurDate.Value.ToString("dd/MMM/yyyy") + "'"
            'RdAddSold.DataDefinition.FormulaFields("GrandTotal").Text = Val(Me.TxtTotalValue.Text)
            'If Me.CmbIngradiants.Text <> "A-Z" Then
            '    RdAddSold.RecordSelectionFormula = "{tmppurchasestockvaluation.Item_code}='" + Me.CmbIngradiants.SelectedValue + "'"
            'End If

            'RdAddSold.Refresh()
            'RdAddSold.PrintToPrinter(1, False, 1, 1)

        Catch Ex As Exception
            MsgBox(Ex.Message)
        End Try
    End Sub
End Class