Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Windows.Forms

Public Class Help
    Public strSelectedValue As String = String.Empty
    Private Sub SearchRecords()
        Dim strSQL As String = "SELECT PatientID,Name from Patient Where  Name  LIKE '" + Me.TXTSEARCH.Text.Trim + "%' or PatientID LIKE '" + Me.TXTSEARCH.Text.Trim + "%'"
        Dim MySqlAdp As New Odbc.OdbcDataAdapter
        Dim MySqlCon As New Odbc.OdbcConnection
        Dim DS As New DataSet
        Try
            MySqlCon = GetAccesscon()
            MySqlAdp = New Odbc.OdbcDataAdapter(strSQL, MySqlCon)
            MySqlAdp.Fill(DS, "SearchTable")
            GridSearch.DataSource = DS.Tables(0)
            GridSearch.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells)
            GridSearch.Columns(1).Width = 300
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
            strSelectedValue = GridSearch.CurrentRow.Cells(0).Value.ToString()
            Me.Close()
            Me.Dispose()
        End If
    End Sub

    Private Sub CMDOK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CMDOK.KeyPress
        If Asc(e.KeyChar) = 13 Then CMDOK_Click(sender, New System.EventArgs)
    End Sub

    Private Sub GridSearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles GridSearch.KeyDown
        If e.KeyCode = Keys.Enter Then CMDOK_Click(sender, New System.EventArgs())
    End Sub
End Class