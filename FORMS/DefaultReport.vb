Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Windows.Forms
Imports System.Drawing.Printing

Public Class DefaultReport
    Private m_nFirstCharOnPage As Integer
    Dim strFontName As String = "Verdana"
    Dim strFontsize As Integer = strFontsize
    Dim strHeaderRtf As String = String.Empty
    Dim Fs As System.Drawing.FontStyle = FontStyle.Regular

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

    Private Sub DefaultReport_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = "'" Then e.Handled = True
    End Sub

    Private Sub DefaultReport_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        PageSetupDialog1.PageSettings.Margins.Top = 50
        PageSetupDialog1.PageSettings.Margins.Left = 75
        PageSetupDialog1.PageSettings.Margins.Right = 40
        Me.KeyPreview = True
    End Sub

    Private Sub CmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSave.Click
        Dim StrSql As String = String.Empty
        Dim Con As New Odbc.OdbcConnection
        Dim Cmd As New Odbc.OdbcCommand
        Dim VARTYPEDESC As Object
        Dim VARENMODELCODE As Object
        Dim VAROUTPUTPOWER As Object
        Dim VARRPM As Object
        Dim VARSTROKE As Object
        Dim VARASP As Object
        Dim VARPISTONDISPLACMENT As Object
        Dim VARFUELCONS As Object
        Dim VARMAXCONS As Object
        Dim VARPEAKFUELCONS As Object
        Dim VARPISTONDISPLACMENTUNIT As Object
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

        Try

            If Me.TxtDefReport.Text.Trim = String.Empty Then
                MsgBox("Please Enter Default Report.")
                Exit Sub
            End If

            Cmd.CommandType = CommandType.Text
            Con = GetAccesscon()
            Cmd.Connection = Con
            Trans = Con.BeginTransaction
            Cmd.Transaction = Trans
            IsTrans = True


            StrSql = "Update Services Set DefaultReportRtf='" + Me.TxtDefReport.Rtf.Trim + "',DefaultReport='" + Me.TxtDefReport.Text.Trim + "' where servicecode='" + Me.LblServiceCode.Text.Trim + "'"
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

    Public Sub GetSavedDefaultReport()
        Dim StrSql As String = String.Empty
        Dim Con As New Odbc.OdbcConnection
        Dim Cmd As New Odbc.OdbcCommand
        Dim Obj As Object = Nothing
        Try
            Cmd.CommandType = CommandType.Text
            Con = GetAccesscon()
            Cmd.Connection = Con
            StrSql = "Select DefaultReportRtf from Services where servicecode='" + Me.LblServiceCode.Text.Trim + "'"
            Cmd.CommandText = StrSql
            Obj = Cmd.ExecuteScalar()
            If IsNothing(Obj) = True Then Obj = String.Empty
            Me.TxtDefReport.Rtf = Obj.ToString


            StrSql = "Select HeaderOnReports from HospDetail"
            Cmd.CommandText = StrSql
            Obj = Cmd.ExecuteScalar()
            If IsNothing(Obj) = True Then Obj = String.Empty
            strHeaderRtf = Obj.ToString

        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Critical)
        Finally
            Con.Dispose()
            Cmd.Dispose()
            Obj = Nothing
        End Try
        CmbFontSize.Text = 10
    End Sub



    Private Sub BtnLeft_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnLeft.Click
        Me.TxtDefReport.SelectionAlignment = HorizontalAlignment.Left
        TxtDefReport.Focus()
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

        If (PrintPreviewDialog1.ShowDialog = DialogResult.OK) Then
            PrintDocument1.Print()

        End If
    End Sub

    Private Sub TxtDefReport_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtDefReport.TextChanged
        ' Me.TxtDefReportForPrint.Rtf = Me.TxtDefReportForPrint.Rtf + Me.TxtDefReport.Rtf
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        PrintPreviewDialog1.SetBounds(Me.Left, Me.Top, 400, 400)
        CreatePrintable()
       
        If (PrintPreviewDialog1.ShowDialog = DialogResult.OK) Then
            PrintDocument1.Print()
        End If
    End Sub
    Private Sub CreatePrintable()
        TxtDefReportForPrint.Text = String.Empty
        TxtDefReportForPrint.Rtf = strHeaderRtf
        TxtDefReportForPrint.SelectionStart = TxtDefReportForPrint.Text.Length
        TxtDefReportForPrint.SelectionLength = TxtDefReportForPrint.Text.Length
        TxtDefReport.SelectAll()
        TxtDefReport.Copy()
        TxtDefReportForPrint.Paste()

    End Sub
End Class