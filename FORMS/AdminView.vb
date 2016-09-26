Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Windows.Forms

Public Class AdminView
    Public Sub getdata()
        Dim MySqlCon As New Odbc.OdbcConnection
        Dim MySqlCmd As New Odbc.OdbcCommand
        MySqlCon = GetAccesscon()
        MySqlCmd.Connection = MySqlCon
        Dim obj As Object = Nothing
        Dim STRTITLE As String = String.Empty
        Dim VarStr As Object = Nothing
        Dim VarStr1 As Object = Nothing
        Try
            Dim strSQL As String = String.Empty

            Application.DoEvents()
            strSQL = "SELECT  Count(PatientBilling.SERVICECODE) AS Expr1 FROM PatientBilling WHERE (((PatientBilling.[subdepcode])='SD0003')) and   patientBilling.ISCANCELLED=false and billingdate between cdate('" + txtDateFromXray.Value.ToString("dd/MMM/yyyy") + "') and cdate('" + txtDateToXray.Value.ToString("dd/MMM/yyyy") + "') and PatientBilling.SERVICECODE+ PatientBilling.patientid+billingid not in(select radiologyReportXRay.servicecode+RadiologyReportXRay.patientid+RadiologyReportXRay.billingid  from RadiologyReportXRay where  cdate( format(reportingdate,'dd/MMM/yyyy') ) between  cdate('" + txtDateFromXray.Value.ToString("dd/MMM/yyyy") + "') and cdate('" + txtDateToXray.Value.ToString("dd/MMM/yyyy") + "') )"
            MySqlCmd.CommandText = strSQL
            obj = MySqlCmd.ExecuteScalar
            If IsNothing(obj) = True Then obj = "0"
            LblXRayPending.Text = obj.ToString


            strSQL = "select count(RadiologyReportXRay.servicecode+RadiologyReportXRay.patientid+RadiologyReportXRay.billingid ) from RadiologyReportXRay where  cdate( format(reportingdate,'dd/MMM/yyyy') ) between  cdate('" + txtDateFromXray.Value.ToString("dd/MMM/yyyy") + "') and cdate('" + txtDateToXray.Value.ToString("dd/MMM/yyyy") + "')"
            MySqlCmd.CommandText = strSQL
            obj = MySqlCmd.ExecuteScalar
            If IsNothing(obj) = True Then obj = "0"
            LblXRayReported.Text = obj.ToString
            LblXRayTotal.Text = Val(LblXRayPending.Text) + Val(LblXRayReported.Text)


            strSQL = "SELECT  Count(PatientBilling.SERVICECODE) AS Expr1 FROM PatientBilling WHERE (((PatientBilling.[subdepcode])='SD0003')) and   patientBilling.ISCANCELLED=false and billingdate between cdate('" + txtDateFromXray.Value.ToString("dd/MMM/yyyy") + "') and cdate('" + txtDateToXray.Value.ToString("dd/MMM/yyyy") + "') and PatientBilling.SERVICECODE+ PatientBilling.patientid+billingid not in(select RadiologyReportUltrasound.servicecode+RadiologyReportUltrasound.patientid+RadiologyReportUltrasound.billingid  from RadiologyReportUltrasound where  cdate( format(reportingdate,'dd/MMM/yyyy') ) between  cdate('" + txtDateFromXray.Value.ToString("dd/MMM/yyyy") + "') and cdate('" + txtDateToXray.Value.ToString("dd/MMM/yyyy") + "') )"
            MySqlCmd.CommandText = strSQL
            obj = MySqlCmd.ExecuteScalar
            If IsNothing(obj) = True Then obj = "0"
            LblUSGPending.Text = obj.ToString


            strSQL = "select count(RadiologyReportUltrasound.servicecode+RadiologyReportUltrasound.patientid+RadiologyReportUltrasound.billingid ) from RadiologyReportUltrasound where  cdate( format(reportingdate,'dd/MMM/yyyy') ) between  cdate('" + txtDateFromXray.Value.ToString("dd/MMM/yyyy") + "') and cdate('" + txtDateToXray.Value.ToString("dd/MMM/yyyy") + "')"
            MySqlCmd.CommandText = strSQL
            obj = MySqlCmd.ExecuteScalar
            If IsNothing(obj) = True Then obj = "0"
            LblUSGReported.Text = obj.ToString
            LblUSGTotal.Text = Val(LblUSGPending.Text) + Val(LblUSGReported.Text)


            obj = Nothing
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally
            MySqlCon.Dispose()
            MySqlCmd.Dispose()
        End Try

    End Sub
    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub TmrPgBar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TmrPgBar.Tick
        getdata()
    End Sub

    Private Sub LblXRayPending_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblXRayPending.Click

    End Sub
End Class