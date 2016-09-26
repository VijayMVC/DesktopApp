Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Printing
Public Class RadiologyReport
    Private m_nFirstCharOnPage As Integer
    Dim strFontName As String = "Verdana"
    Dim strFontsize As Integer = 10
    Dim strHeaderRtf As String = String.Empty
    Dim Fs As System.Drawing.FontStyle = FontStyle.Regular
    Public strReportFor As String = "SD0003" 'X-Ray ' SD0008 for Ultrasound
    Dim strNameAgeSexFormatRtf As String = String.Empty
    Dim blnFillReportedTests As Boolean = False
    Public strTableName As String = "RadiologyReportXRay"
    Private Sub BtnBold_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnBold.Click
        If IsNothing(TxtDefReport.SelectionFont) = False Then
            If TxtDefReport.SelectionFont.Underline = True And TxtDefReport.SelectionFont.Italic = True Then
                TxtDefReport.SelectionFont = New Font(strFontName, strFontsize, FontStyle.Underline Or FontStyle.Bold Or FontStyle.Italic)
                Fs = FontStyle.Underline Or FontStyle.Bold Or FontStyle.Italic
            ElseIf (TxtDefReport.SelectionFont.Underline = True) Then
                TxtDefReport.SelectionFont = New Font(strFontName, strFontsize, FontStyle.Underline Or FontStyle.Bold)
                Fs = FontStyle.Underline Or FontStyle.Bold
            ElseIf (TxtDefReport.SelectionFont.Italic = True) Then
                TxtDefReport.SelectionFont = New Font(strFontName, strFontsize, FontStyle.Bold Or FontStyle.Italic)
                Fs = FontStyle.Bold Or FontStyle.Italic
            Else
                TxtDefReport.SelectionFont = New Font(strFontName, strFontsize, FontStyle.Bold)
                Fs = FontStyle.Bold
            End If
        Else
            TxtDefReport.SelectionFont = New Font(strFontName, strFontsize, FontStyle.Bold)
            Fs = FontStyle.Bold
        End If
        TxtDefReport.Focus()
    End Sub

    Private Sub BtnUnderline_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUnderline.Click
        If IsNothing(TxtDefReport.SelectionFont) = False Then
            If TxtDefReport.SelectionFont.Bold = True And TxtDefReport.SelectionFont.Italic = True Then
                TxtDefReport.SelectionFont = New Font(strFontName, strFontsize, FontStyle.Underline Or FontStyle.Bold Or FontStyle.Italic)
                Fs = FontStyle.Underline Or FontStyle.Bold Or FontStyle.Italic
            ElseIf (TxtDefReport.SelectionFont.Bold = True) Then
                TxtDefReport.SelectionFont = New Font(strFontName, strFontsize, FontStyle.Underline Or FontStyle.Bold)
                Fs = FontStyle.Underline Or FontStyle.Bold
            ElseIf (TxtDefReport.SelectionFont.Italic = True) Then
                TxtDefReport.SelectionFont = New Font(strFontName, strFontsize, FontStyle.Underline Or FontStyle.Italic)
                Fs = FontStyle.Underline Or FontStyle.Italic
            Else
                TxtDefReport.SelectionFont = New Font(strFontName, strFontsize, FontStyle.Underline)
                Fs = FontStyle.Underline
            End If
        Else
            TxtDefReport.SelectionFont = New Font(strFontName, strFontsize, FontStyle.Underline)
            Fs = FontStyle.Underline
        End If
        TxtDefReport.Focus()
    End Sub

    Private Sub BtnItalic_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnItalic.Click
        If IsNothing(TxtDefReport.SelectionFont) = False Then
            If TxtDefReport.SelectionFont.Bold = True And TxtDefReport.SelectionFont.Underline = True Then
                TxtDefReport.SelectionFont = New Font(strFontName, strFontsize, FontStyle.Italic Or FontStyle.Bold Or FontStyle.Underline)
                Fs = FontStyle.Italic Or FontStyle.Bold Or FontStyle.Underline
            ElseIf (TxtDefReport.SelectionFont.Bold = True) Then
                TxtDefReport.SelectionFont = New Font(strFontName, strFontsize, FontStyle.Italic Or FontStyle.Bold)
                Fs = FontStyle.Italic Or FontStyle.Bold
            ElseIf (TxtDefReport.SelectionFont.Underline = True) Then
                TxtDefReport.SelectionFont = New Font(strFontName, strFontsize, FontStyle.Italic Or FontStyle.Underline)
                Fs = FontStyle.Italic Or FontStyle.Underline
            Else
                TxtDefReport.SelectionFont = New Font(strFontName, strFontsize, FontStyle.Italic)
                Fs = FontStyle.Italic
            End If
            Exit Sub
        Else
            TxtDefReport.SelectionFont = New Font(strFontName, strFontsize, FontStyle.Italic)
            Fs = FontStyle.Italic
        End If
        TxtDefReport.Focus()
    End Sub

    Private Sub txtRemoveFormat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRemoveFormat.Click
        TxtDefReport.SelectionFont = New Font(strFontName, strFontsize, FontStyle.Regular)
        Fs = FontStyle.Regular
        TxtDefReport.Focus()
    End Sub



    Private Sub CmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSave.Click
        Dim StrSql As String = String.Empty
        Dim Con As New Odbc.OdbcConnection
        Dim Cmd As New Odbc.OdbcCommand
        Dim VarTypeCode As Object = Nothing
        Dim VarMfgCode As Object = Nothing
        Dim VarModelCode As Object = Nothing
        Dim VarUDModelCode As Object = Nothing
        Dim VarCharges As Object = Nothing
        Dim Trans As System.Data.Odbc.OdbcTransaction
        Dim IsTrans As Boolean = False
        Dim VarSubDep As Object = Nothing
        Dim VarVal As Object = Nothing

        Dim Obj As Object = Nothing
        Dim StrId As String = String.Empty
        Dim strInsertedOrUpdated As String = String.Empty
        Dim IntRecordsAffected As Integer = 0



        If Me.txtpID.Text.Trim = String.Empty Then
            MsgBox("Please Select Patient Id.")
            CmdSearch.Focus()
            Exit Sub
        ElseIf Me.CmbReportedBy.Text.Trim = String.Empty Then
            MsgBox("Please Select/Enter Doctor Name.")
            CmbReportedBy.Focus()
            Exit Sub
        ElseIf Me.TxtDesignation.Text.Trim = String.Empty Then
            MsgBox("Please Select/Enter Doctor's Designation.")
            TxtDesignation.Focus()
            Exit Sub
        ElseIf Me.TxtDefReport.Text.Trim = String.Empty Then
            MsgBox("Please Enter Reporting Text.")
            TxtDefReport.Focus()
            Exit Sub
        End If
        Try
            Cmd.CommandType = CommandType.Text
            Con = GetAccesscon()
            Cmd.Connection = Con
            Trans = Con.BeginTransaction
            Cmd.Transaction = Trans
            IsTrans = True

            StrSql = "DELETE FROM " + strTableName + " WHERE PATIENTID='" + Me.txtpID.Text + "' AND BILLINGID='" + Me.TctReceiptNo.Text + "' AND SERVICECODE='" + Me.CmbTestName.SelectedValue.ToString + "'"
            Cmd.CommandText = StrSql
            Cmd.ExecuteNonQuery()

            StrSql = "INSERT INTO " + strTableName + " (PATIENTID,BILLINGID,SERVICECODE,REPORTINGDATE,REPORTTEXT,REPORTTEXTRTF,REPORTEDBY,REPORTEDBYDESIGNATION) "
            StrSql = StrSql + " Select '" + Me.txtpID.Text + "','" + Me.TctReceiptNo.Text + "','" + Me.CmbTestName.SelectedValue.ToString + "','" + Me.TxtReportingDateTime.Text + "','" + Me.TxtDefReport.Text + "','" + Me.TxtDefReport.Rtf.ToString + "','" + Me.CmbReportedBy.Text + "','" + Me.TxtDesignation.Text + "'"
            Cmd.CommandText = StrSql
            Cmd.ExecuteNonQuery()

            Trans.Commit()
            IsTrans = False
            MsgBox("Saved Successfully.", MsgBoxStyle.Information)
            Me.BtnEdit.Enabled = True
            Me.BtnEdit.Visible = True
            Me.CmdSave.Enabled = False
            Me.CmdSave.Visible = False
            Me.FrmTool.Enabled = False
            Button1.Enabled = True
            BtnPrint.Enabled = True
            Me.TxtDefReport.ReadOnly = True
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Critical)
        Finally
            Con.Dispose()
            Cmd.Dispose()
            Obj = Nothing
            If IsTrans = True Then
                Trans.Rollback()
                Trans.Dispose()
            End If

        End Try
    End Sub

    Public Sub GetHeader()
        Dim StrSql As String = String.Empty
        Dim Con As New Odbc.OdbcConnection
        Dim Cmd As New Odbc.OdbcCommand
        Dim Obj As Object = Nothing
        Try
            Cmd.CommandType = CommandType.Text
            Con = GetAccesscon()
            Cmd.Connection = Con

            StrSql = "Select HeaderOnReports from HospDetail"
            Cmd.CommandText = StrSql
            Obj = Cmd.ExecuteScalar()
            If IsNothing(Obj) = True Then Obj = String.Empty
            strHeaderRtf = Obj.ToString

            StrSql = "Select EndofReport from HospDetail"
            Cmd.CommandText = StrSql
            Obj = Cmd.ExecuteScalar()
            If IsNothing(Obj) = True Then Obj = String.Empty
            Me.txtEndOfReport.Rtf = Obj.ToString.Replace("ReplaceDoctorName", Me.CmbReportedBy.Text).Replace("ReplaceDesignation", Me.TxtDesignation.Text)
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Critical)
        Finally
            Con.Dispose()
            Cmd.Dispose()
            Obj = Nothing
        End Try
        CmbFontSize.Text = 10
        TxtDefReport.Focus()
    End Sub
    Private Sub BtnLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLeft.Click
        Me.TxtDefReport.SelectionAlignment = HorizontalAlignment.Left
    End Sub

    Private Sub Btncenter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btncenter.Click
        Me.TxtDefReport.SelectionAlignment = HorizontalAlignment.Center
        TxtDefReport.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.TxtDefReport.SelectionAlignment = HorizontalAlignment.Right
        TxtDefReport.Focus()
    End Sub

    Private Sub CmbFontSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbFontSize.SelectedIndexChanged
        strFontsize = CmbFontSize.Text
        TxtDefReport.SelectionFont = New Font(strFontName, strFontsize, Fs)
        TxtDefReport.Focus()
    End Sub

    Private Sub BtnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEdit.Click
        Me.BtnEdit.Enabled = False
        Me.BtnEdit.Visible = False
        Me.CmdSave.Enabled = True
        Me.CmdSave.Visible = True
        Me.FrmTool.Enabled = True
        Button1.Enabled = False
        BtnPrint.Enabled = False
        Me.TxtDefReport.ReadOnly = False
        TxtReportingDateTime.Value = Now
        TxtDefReport.Focus()
    End Sub

    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub


    'Private Sub PrintToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintToolStripMenuItem.Click
    '    Dim Print_Dialog As New PrintDialog
    '    Print_Dialog.Document = PreparePrintDocument()
    '    Print_Dialog.ShowDialog()
    '    If Print_Dialog.ShowDialog = Windows.Forms.DialogResult.OK Then
    '        Print_Dialog.Document.Print()
    '    End If
    'End Sub

    'Private Sub PrintPreviewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintPreviewToolStripMenuItem.Click
    '    Dim Print_Preview As New PrintPreviewDialog
    '    Print_Preview.Document = PreparePrintDocument()
    '    Print_Preview.WindowState = FormWindowState.Maximized
    '    Print_Preview.ShowDialog()
    'End Sub

    Private Function PreparePrintDocument() As PrintDocument
        Dim Print_Document As New PrintDocument
        AddHandler Print_Document.PrintPage, AddressOf Print_PrintPage
        Return Print_Document
    End Function

    Private Sub Print_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
        'Dim Page As String
        'Page = Me.TxtDefReport.Text
        'e.Graphics.DrawString(Page, TxtDefReport.Font, Brushes.Black, 50, 50)
        'e.HasMorePages = False
        'Dim MSWord As New Microsoft.Office.Interop.Word.Application
        'Dim WordDoc As New Microsoft.Office.Interop.Word.Document

        'Dim o As Microsoft.Office.Interop.Word.Application
        'WordDoc = MSWord.Documents.Open("C:\aa.rtf")

        'WordDoc.Visible = True
        'WordDoc.PrintOut(1, True, 1, False, True, True, False)
        'Uygulama.Workbooks.Add("c:\RaporTaslak\Temp.xls")
        'Uygulama.Visible = True
        'Uygulama.Sheets.PrintPreview(True)
        'Uygulama.Sheets._PrintOut(1, True, 1, False, True, True, _
        ' False)

    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' To print the boundaries of the current page margins
        ' uncomment the next line:
        e.Graphics.DrawRectangle(System.Drawing.Pens.White, e.MarginBounds)

        ' make the RichTextBoxEx calculate and render as much text as will
        ' fit on the page and remember the last character printed for the
        ' beginning of the next page

        m_nFirstCharOnPage = TxtDefReportForPrint.FormatRange(False, _
                                                 e, _
                                                m_nFirstCharOnPage, _
                                                TxtDefReportForPrint.TextLength)

        ' check if there are more pages to print
        If (m_nFirstCharOnPage < TxtDefReportForPrint.TextLength) Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub

    Private Sub PrintDocument1_BeginPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.BeginPrint
        ' Start at the beginning of the text
        m_nFirstCharOnPage = 0
    End Sub
    Private Sub PrintDocument1_EndPrint(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles PrintDocument1.EndPrint
        ' Clean up cached information
        TxtDefReportForPrint.FormatRangeDone()
    End Sub

    Private Sub BtnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrint.Click
        CreatePrintable()
        PrintDocument1.Print()
    End Sub

    Private Sub TxtDefReport_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDefReport.TextChanged
        'Me.TxtDefReportForPrint.Rtf = Me.TxtDefReportForPrint.Rtf + Me.TxtDefReport.Rtf
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintPreviewDialog1.SetBounds(Me.Left, Me.Top, 400, 400)
        CreatePrintable()
        If (PrintPreviewDialog1.ShowDialog = DialogResult.OK) Then
            PrintDocument1.Print()
        End If
    End Sub
    Private Sub CreatePrintable()
        Dim strType As String = String.Empty
        GetHeader()
        TxtDefReportForPrint.Text = String.Empty
        Me.TxtPatientNameAgeSex.Text = String.Empty
        TxtDefReportForPrint.Rtf = strHeaderRtf
        If strReportFor = "SD0003" Then
            strType = "(X-Ray) "
        Else
            strType = "(Ultrasound) "
        End If

        GetNameAgeSexFormat()

        strNameAgeSexFormatRtf = strNameAgeSexFormatRtf.Replace("ReplacePatientId", Me.txtpID.Text)
        strNameAgeSexFormatRtf = strNameAgeSexFormatRtf.Replace("ReplacePatientName", Me.txtName.Text)
        strNameAgeSexFormatRtf = strNameAgeSexFormatRtf.Replace("ReplaceAgeSex", txtAge.Text + " " + Me.txtSex.Text)
        strNameAgeSexFormatRtf = strNameAgeSexFormatRtf.Replace("ReplaceReportingDate", TxtReportingDateTime.Text)
        strNameAgeSexFormatRtf = strNameAgeSexFormatRtf.Replace("ReplaceInvestigation", strType + Me.CmbTestName.Text)
        Me.TxtPatientNameAgeSex.Rtf = strNameAgeSexFormatRtf

        TxtDefReportForPrint.SelectionStart = TxtDefReportForPrint.Text.Length
        TxtDefReportForPrint.SelectionLength = TxtDefReportForPrint.Text.Length

        Me.TxtPatientNameAgeSex.SelectAll()
        Me.TxtPatientNameAgeSex.Copy()
        Me.TxtDefReportForPrint.Paste()

        TxtDefReportForPrint.SelectionStart = TxtDefReportForPrint.Text.Length
        TxtDefReportForPrint.SelectionLength = TxtDefReportForPrint.Text.Length

        TxtDefReport.SelectAll()
        TxtDefReport.Copy()
        TxtDefReportForPrint.Paste()

        TxtDefReportForPrint.SelectionStart = TxtDefReportForPrint.Text.Length
        TxtDefReportForPrint.SelectionLength = TxtDefReportForPrint.Text.Length


        Me.txtEndOfReport.SelectAll()
        Me.txtEndOfReport.Copy()
        TxtDefReportForPrint.Paste()

        TxtDefReport.SelectionStart = TxtDefReport.Text.Length
        TxtDefReport.SelectionLength = TxtDefReport.Text.Length

    End Sub

    Private Sub RadiologyReport_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = "'" Then e.Handled = True
    End Sub

    Private Sub RadiologyReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If strReportFor = "SD0003" Then Me.LbFormHeader.Text = "Radiological Report (X-Ray)"
        If strReportFor = "SD0008" Then Me.LbFormHeader.Text = "Radiological Report (USG)"
        RdPending.Checked = True
        Me.CmbFontSize.Text = strFontsize
        PageSetupDialog1.PageSettings.Margins.Top = 50
        PageSetupDialog1.PageSettings.Margins.Left = 75
        PageSetupDialog1.PageSettings.Margins.Right = 40
        Me.KeyPreview = True
    End Sub

    Private Sub FrmTool_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrmTool.Enter

    End Sub

    Private Sub CmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSearch.Click

        Dim frm As New RadiologicalHelp
        frm.ModeHelp = 5
        frm.ServiceCodes = 5
        frm.strReportFor = strReportFor
        frm.strTableName = strTableName
        If Me.RdPending.Checked = True Then frm.IsPending = True Else frm.IsPending = False
        frm.ShowDialog()
        Clear()
        If frm.strSelectedValue.Trim <> String.Empty Then
            If Me.RdPending.Checked = True Then
                getdata(frm.ModeHelp, frm.strSelectedValue)
            Else
                getReporteddata(frm.ModeHelp, frm.strSelectedValue)
            End If
        End If
            frm.Dispose()

    End Sub
    Public Sub getdata(ByVal ModeHelp As Short, ByVal strPatientId As String)
        Dim MySqlCon As New Odbc.OdbcConnection
        Dim MySqlDataRd As Odbc.OdbcDataReader
        Dim MySqlCmd As New Odbc.OdbcCommand
        MySqlCon = GetAccesscon()
        MySqlCmd.Connection = MySqlCon
        Dim obj As Object = Nothing
        Dim STRTITLE As String = String.Empty
        Dim VarStr As Object = Nothing
        Dim VarStr1 As Object = Nothing
        Try
            Dim strSQL As String = String.Empty
            Me.TctReceiptNo.Text = strPatientId


            strSQL = "SELECT  PatientBilling.BILLINGDATE FROM PatientBilling, Services WHERE  PatientBilling.SERVICECODE = SERVICES.SERVICECODE AND PatientBilling.SUBDEPCODE = SERVICES.SUBDEPCODE AND  (PatientBilling.SUBDEPCODE = '" + strReportFor + "') AND (PatientBilling.BILLINGID = '" + strPatientId + "')"
            MySqlCmd.CommandText = strSQL
            obj = MySqlCmd.ExecuteScalar
            If IsNothing(obj) = True Then obj = Now.ToString("dd/MMM/yyyy")
            Me.TxtReceiptDate.Text = Convert.ToDateTime(obj).ToString("dd/MMM/yyyy")
            obj = Nothing

            strSQL = "SELECT PatientID,Name,Age,IIF(Sex='M','Male','Female') as Sex1 from Patient Where  PatientID in (SELECT DISTINCT PATIENTID FROM   PatientBilling WHERE  (BILLINGID = '" + strPatientId + "'))"
            MySqlCmd.CommandText = strSQL
            MySqlDataRd = MySqlCmd.ExecuteReader()
            If (MySqlDataRd.HasRows = True) Then
                txtpID.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("PatientID")).ToString()
                txtName.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Name")).ToString()
                txtAge.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Age")).ToString()
                txtSex.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Sex1")).ToString()
            End If
            FillTests(Me.TctReceiptNo.Text)
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally
            MySqlCon.Dispose()
            MySqlCmd.Dispose()
        End Try

    End Sub
    Public Sub getReporteddata(ByVal ModeHelp As Short, ByVal strPatientId As String)
        Dim MySqlCon As New Odbc.OdbcConnection
        Dim MySqlDataRd As Odbc.OdbcDataReader
        Dim MySqlCmd As New Odbc.OdbcCommand
        MySqlCon = GetAccesscon()
        MySqlCmd.Connection = MySqlCon
        Dim obj As Object = Nothing
        Dim STRTITLE As String = String.Empty
        Dim VarStr As Object = Nothing
        Dim VarStr1 As Object = Nothing
        Try
            Dim strSQL As String = String.Empty
            Me.TctReceiptNo.Text = strPatientId


            strSQL = "SELECT  PatientBilling.BILLINGDATE FROM PatientBilling, Services WHERE  PatientBilling.SERVICECODE = SERVICES.SERVICECODE AND PatientBilling.SUBDEPCODE = SERVICES.SUBDEPCODE AND  (PatientBilling.SUBDEPCODE = '" + strReportFor + "') AND (PatientBilling.BILLINGID = '" + strPatientId + "')"
            MySqlCmd.CommandText = strSQL
            obj = MySqlCmd.ExecuteScalar
            If IsNothing(obj) = True Then obj = Now.ToString("dd/MMM/yyyy")
            Me.TxtReceiptDate.Text = Convert.ToDateTime(obj).ToString("dd/MMM/yyyy")
            obj = Nothing

            strSQL = "SELECT PatientID,Name,Age,IIF(Sex='M','Male','Female') as Sex1 from Patient Where  PatientID in (SELECT DISTINCT PATIENTID FROM   PatientBilling WHERE  (BILLINGID = '" + strPatientId + "'))"
            MySqlCmd.CommandText = strSQL
            MySqlDataRd = MySqlCmd.ExecuteReader()
            If (MySqlDataRd.HasRows = True) Then
                txtpID.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("PatientID")).ToString()
                txtName.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Name")).ToString()
                txtAge.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Age")).ToString()
                txtSex.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Sex1")).ToString()
            End If
            FillReportedTests(Me.TctReceiptNo.Text)
            GetReportedTestDetails()
            Button1.Enabled = True
            BtnPrint.Enabled = True
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally
            MySqlCon.Dispose()
            MySqlCmd.Dispose()
        End Try

    End Sub
    Private Sub GetReportedTestDetails()
        Dim MySqlCon As New Odbc.OdbcConnection
        Dim MySqlDataRd As Odbc.OdbcDataReader
        Dim MySqlCmd As New Odbc.OdbcCommand
        MySqlCon = GetAccesscon()
        MySqlCmd.Connection = MySqlCon
        Dim obj As Object = Nothing
        Dim STRTITLE As String = String.Empty
        Dim VarStr As Object = Nothing
        Dim VarStr1 As Object = Nothing
        Try
            Dim strSQL As String = String.Empty
            Me.TxtDefReport.Text = String.Empty
            Me.CmbReportedBy.Text = String.Empty
            Me.TxtDesignation.Text = String.Empty
            strSQL = "SELECT " + strTableName + ".REPORTTEXTRTF, " + strTableName + ".REPORTEDBY, " + strTableName + ".REPORTEDBYDESIGNATION," + strTableName + ".REPORTINGDATE  FROM " + strTableName + "  WHERE PATIENTID='" + Me.txtpID.Text.Trim + "' AND BILLINGID='" + Me.TctReceiptNo.Text.Trim + "' AND SERVICECODE='" + Me.CmbTestName.SelectedValue.ToString + "'"
            MySqlCmd.CommandText = strSQL
            MySqlDataRd = MySqlCmd.ExecuteReader()
            If (MySqlDataRd.HasRows = True) Then
                Me.TxtDefReport.Rtf = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("REPORTTEXTRTF")).ToString()
                Me.CmbReportedBy.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("REPORTEDBY")).ToString()
                Me.TxtDesignation.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("REPORTEDBYDESIGNATION")).ToString()
                Me.TxtReportingDateTime.Value = Convert.ToDateTime(MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("REPORTINGDATE")).ToString()).ToString("dd/MMM/yyyy hh:mm tt")
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally
            MySqlCon.Dispose()
            MySqlCmd.Dispose()
        End Try
    End Sub
    Private Sub GetReportedDoctorList()
        Dim MySqlCon As New Odbc.OdbcConnection
        Dim MySqlDataRd As Odbc.OdbcDataReader
        Dim MySqlCmd As New Odbc.OdbcCommand
        MySqlCon = GetAccesscon()
        MySqlCmd.Connection = MySqlCon
        Dim obj As Object = Nothing
        Dim STRTITLE As String = String.Empty
        Dim VarStr As Object = Nothing
        Dim VarStr1 As Object = Nothing
        Try
            Me.CmbReportedBy.Items.Clear()
            Dim strSQL As String = String.Empty
            Me.TxtDefReport.Text = String.Empty
            Me.CmbReportedBy.Text = String.Empty
            Me.TxtDesignation.Text = String.Empty
            strSQL = "SELECT DISTINCT " + strTableName + ".REPORTEDBY FROM " + strTableName + " "
            MySqlCmd.CommandText = strSQL
            MySqlDataRd = MySqlCmd.ExecuteReader()
            If (MySqlDataRd.HasRows = True) Then
                While MySqlDataRd.Read
                    Me.CmbReportedBy.Items.Add(MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("REPORTEDBY")).ToString())
                End While
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally
            MySqlCon.Dispose()
            MySqlCmd.Dispose()
        End Try
    End Sub

    Private Sub GetReportedDoctorDesignation()
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
            Me.TxtDesignation.Text = String.Empty
            strSQL = "SELECT DISTINCT REPORTEDBYDESIGNATION  FROM " + strTableName + " where " + strTableName + ".REPORTEDBY='" + Me.CmbReportedBy.Text.ToString + "'"
            MySqlCmd.CommandText = strSQL
            obj = MySqlCmd.ExecuteScalar
            If IsNothing(obj) = True Then obj = String.Empty
            Me.TxtDesignation.Text = obj.ToString
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally
            MySqlCon.Dispose()
            MySqlCmd.Dispose()
        End Try
    End Sub

    Private Sub FillTests(ByVal strReceiptNo As String)
        Dim MySqlCon As New Odbc.OdbcConnection()
        Dim MysqlCmd As New Odbc.OdbcCommand
        MySqlCon = GetAccesscon()
        Dim DS As New DataSet
        Dim MySqlAdp As Odbc.OdbcDataAdapter
        Try
            Me.CmbTestName.DataSource = Nothing
            MySqlAdp = New Odbc.OdbcDataAdapter("SELECT SERVICES.SERVICECODE, SERVICES.SERVICEDESC  FROM PatientBilling, Services WHERE  PatientBilling.SERVICECODE = SERVICES.SERVICECODE AND PatientBilling.SUBDEPCODE = SERVICES.SUBDEPCODE AND  (PatientBilling.SUBDEPCODE = '" + strReportFor + "') AND (PatientBilling.BILLINGID = '" + strReceiptNo + "') And SERVICES.SERVICECODE NOT IN(SELECT SERVICECODE FROM " + strTableName + " WHERE PATIENTID='" + Me.txtpID.Text.Trim + "' AND BILLINGID='" + Me.TctReceiptNo.Text.Trim + "')", MySqlCon)
            MySqlAdp.Fill(DS, "TAB1")
            Me.CmbTestName.DataSource = DS.Tables("TAB1")
            Me.CmbTestName.ValueMember = "SERVICECODE"
            Me.CmbTestName.DisplayMember = "SERVICEDESC"
            MySqlAdp.Dispose()

        Catch Ex As Exception
            MsgBox(Ex.Message)
        Finally

            MySqlCon.Dispose()
        End Try

    End Sub
    Private Sub FillReportedTests(ByVal strReceiptNo As String)
        Dim MySqlCon As New Odbc.OdbcConnection()
        Dim MysqlCmd As New Odbc.OdbcCommand
        MySqlCon = GetAccesscon()
        Dim DS As New DataSet
        Dim MySqlAdp As Odbc.OdbcDataAdapter
        Try
            blnFillReportedTests = True
            Me.CmbTestName.DataSource = Nothing
            MySqlAdp = New Odbc.OdbcDataAdapter("SELECT SERVICES.SERVICECODE, SERVICES.SERVICEDESC FROM " + strTableName + " INNER JOIN SERVICES ON " + strTableName + ".SERVICECODE = SERVICES.SERVICECODE WHERE  (BILLINGID = '" + strReceiptNo + "')", MySqlCon)
            MySqlAdp.Fill(DS, "TAB1")
            Me.CmbTestName.DataSource = DS.Tables("TAB1")
            Me.CmbTestName.ValueMember = "SERVICECODE"
            Me.CmbTestName.DisplayMember = "SERVICEDESC"
            MySqlAdp.Dispose()

        Catch Ex As Exception
            MsgBox(Ex.Message)
        Finally
            blnFillReportedTests = False
            MySqlCon.Dispose()
        End Try

    End Sub
    Private Sub BtnDefaultReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDefaultReport.Click
        Dim MySqlCon As New Odbc.OdbcConnection
        Dim MySqlCmd As New Odbc.OdbcCommand
        MySqlCon = GetAccesscon()
        MySqlCmd.Connection = MySqlCon
        Dim obj As Object = Nothing
        Dim STRTITLE As String = String.Empty
        Dim VarStr As Object = Nothing
        Dim VarStr1 As Object = Nothing
        Try

            If Me.CmbTestName.Text = String.Empty Then
                MsgBox("Please Select Test To Call Default Report.")
                Exit Sub
            End If
            Dim strSQL As String = String.Empty
            strSQL = "SELECT   DefaultReportRtf  FROM      SERVICES WHERE     (SERVICECODE = '" + Me.CmbTestName.SelectedValue.ToString + "')"
            MySqlCmd.CommandText = strSQL
            obj = MySqlCmd.ExecuteScalar
            If IsNothing(obj) = True Then obj = String.Empty
            Me.TxtDefReport.Rtf = obj.ToString
            obj = Nothing

        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally
            MySqlCon.Dispose()
            MySqlCmd.Dispose()
        End Try
    End Sub

    Private Sub GetNameAgeSexFormat()
        Dim MySqlCon As New Odbc.OdbcConnection
        Dim MySqlCmd As New Odbc.OdbcCommand
        MySqlCon = GetAccesscon()
        MySqlCmd.Connection = MySqlCon
        Dim obj As Object = Nothing
        Try
            Dim strSQL As String = String.Empty
            strSQL = "SELECT   PatientNameAgeSexXRayUSG  FROM   HospDetail"
            MySqlCmd.CommandText = strSQL
            obj = MySqlCmd.ExecuteScalar
            If IsNothing(obj) = True Then obj = String.Empty
            strNameAgeSexFormatRtf = obj.ToString
            obj = Nothing
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally
            MySqlCon.Dispose()
            MySqlCmd.Dispose()
        End Try
    End Sub
    Private Sub Clear()
        Try
            txtpID.Text = String.Empty
            TctReceiptNo.Text = String.Empty
            TxtReceiptDate.Text = String.Empty
            txtName.Text = String.Empty
            txtAge.Text = String.Empty
            txtSex.Text = String.Empty
            TxtReportingDateTime.Value = Now
            CmbReportedBy.Text = String.Empty
            TxtDesignation.Text = String.Empty
            TxtDefReport.Text = String.Empty
            CmbTestName.DataSource = Nothing
        Catch Ex As Exception
        End Try
    End Sub

    Private Sub RdPending_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdPending.CheckedChanged
        Clear()
        If Me.RdPending.Checked = True Then

            GetReportedDoctorList()
            Button1.Enabled = False
            BtnPrint.Enabled = False
        End If
    End Sub

    Private Sub RdReported_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RdReported.CheckedChanged
        If Me.RdReported.Checked = True Then
            TxtReportingDateTime.Enabled = False
            BtnDefaultReport.Enabled = False
            CmbReportedBy.Enabled = False
            TxtDesignation.Enabled = False
        Else
            TxtReportingDateTime.Enabled = True
            BtnDefaultReport.Enabled = True
            CmbReportedBy.Enabled = True
            TxtDesignation.Enabled = True
        End If
    End Sub

    Private Sub CmbTestName_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbTestName.SelectedIndexChanged
        If Me.RdReported.Checked = True Then
            If IsNothing(CmbTestName.DataSource) = False Then
                If Me.CmbTestName.Items.Count > 0 And blnFillReportedTests = False Then
                    GetReportedTestDetails()
                End If
            End If
        End If
    End Sub

    Private Sub CmbReportedBy_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbReportedBy.SelectedIndexChanged
        If CmbReportedBy.Items.Count > 0 Then
            GetReportedDoctorDesignation()
        End If
    End Sub

  
End Class