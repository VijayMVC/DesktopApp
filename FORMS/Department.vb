Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Windows.Forms
Public Class Departments
    Enum ENUMGRID
        DEPCODE = 1
        DEPDESC = 2
    End Enum
    Private Sub EquipmentTypeAndModel_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(Keys.Escape) Then
            Me.CmdClose_Click(sender, New System.EventArgs())
        End If
    End Sub
    Private Sub EquipmentTypeAndModel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        Me.GridDTL.MaxRows = 0
        Me.CmdEdit.Enabled = True
        Me.CmdSave.Enabled = False
        Me.CmdCancel.Enabled = False
        GetData()
    End Sub
    Private Sub AddBlankRecordInGrid()
        Me.GridDTL.MaxRows = Me.GridDTL.MaxRows + 1
        Me.GridDTL.Row = Me.GridDTL.MaxRows
        Me.GridDTL.Col = ENUMGRID.DEPCODE : Me.GridDTL.ColHidden = False
        Me.GridDTL.Col = ENUMGRID.DEPDESC : Me.GridDTL.ColHidden = False

        Me.GridDTL.Col = ENUMGRID.DEPCODE : Me.GridDTL.CellType = FPSpread.CellTypeConstants.CellTypeStaticText
        Me.GridDTL.Col = ENUMGRID.DEPDESC : Me.GridDTL.TypeEditLen = 100 : Me.GridDTL.ColHidden = False

        Me.GridDTL.BlockMode = True
        Me.GridDTL.Col = ENUMGRID.DEPCODE : Me.GridDTL.Col2 = ENUMGRID.DEPCODE
        Me.GridDTL.Row = 1 : Me.GridDTL.Row2 = Me.GridDTL.MaxRows
        Me.GridDTL.Lock = True
        Me.GridDTL.BlockMode = False

        Me.GridDTL.BlockMode = True
        Me.GridDTL.Col = ENUMGRID.DEPDESC : Me.GridDTL.Col2 = ENUMGRID.DEPDESC
        Me.GridDTL.Row = 1 : Me.GridDTL.Row2 = Me.GridDTL.MaxRows
        Me.GridDTL.Lock = False
        Me.GridDTL.BlockMode = False

        GridDTL.Row = Me.GridDTL.MaxRows
        GridDTL.Col = ENUMGRID.DEPDESC
        GridDTL.Action = FPSpread.ActionConstants.ActionActiveCell
        GridDTL.Focus()
    End Sub
    Private Sub DeleteRecordInGrid()
        Dim StrSql As String = String.Empty
        Dim Con As New Odbc.OdbcConnection
        Dim Cmd As New Odbc.OdbcCommand
        Dim obj As Object = Nothing
        Dim VarTypeCode As Object = Nothing
        Dim VarTypeDesc As Object = Nothing
        Try
            Cmd.CommandType = CommandType.Text
            Con = GetAccesscon()
            Cmd.Connection = Con
            Me.GridDTL.GetText(ENUMGRID.DEPCODE, Me.GridDTL.ActiveRow, VarTypeCode)
            Me.GridDTL.GetText(ENUMGRID.DEPDESC, Me.GridDTL.ActiveRow, VarTypeDesc)
            If VarTypeDesc.ToString.Trim <> String.Empty And MsgBox("Are You Sure To Delete The Department " + VarTypeDesc + "?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If

            StrSql = "SELECT count(*) As  cnt FROM SUBDEPARTMENT where DEPCODE='" + VarTypeCode.ToString.Trim + "';"
            Cmd.CommandText = StrSql
            obj = Cmd.ExecuteScalar()
            If obj.ToString <> "0" Then
                MsgBox("This Department Has Been Involved In Sub Department Specifications.", MsgBoxStyle.Information)
                Exit Sub
            End If
            Me.GridDTL.Row = Me.GridDTL.ActiveRow
            Me.GridDTL.Action = 5
            GridDTL.MaxRows = GridDTL.MaxRows - 1
        Catch EX As Exception
            MsgBox(EX.Message)
        Finally
            Cmd.Dispose()
            Con.Dispose()
            Cmd.Dispose()
        End Try


    End Sub


    Private Sub GridDTL_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles GridDTL.Advance

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub CmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEdit.Click
        Me.GridDTL.BlockMode = True
        Me.GridDTL.Col = ENUMGRID.DEPCODE : Me.GridDTL.Col2 = ENUMGRID.DEPCODE
        Me.GridDTL.Row = 1 : Me.GridDTL.Row2 = Me.GridDTL.MaxRows
        Me.GridDTL.Lock = True
        Me.GridDTL.BlockMode = False

        Me.GridDTL.BlockMode = True
        Me.GridDTL.Col = ENUMGRID.DEPDESC : Me.GridDTL.Col2 = ENUMGRID.DEPDESC
        Me.GridDTL.Row = 1 : Me.GridDTL.Row2 = Me.GridDTL.MaxRows
        Me.GridDTL.Lock = False
        Me.GridDTL.BlockMode = False

        Me.CmdEdit.Enabled = False
        Me.CmdSave.Enabled = True
        Me.CmdCancel.Enabled = True
        Me.GridDTL.Focus()
    End Sub

    Private Sub CmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSave.Click
        Dim StrSql As String = String.Empty
        Dim Con As New Odbc.OdbcConnection
        Dim Cmd As New Odbc.OdbcCommand
        Dim VARTYPECODE As Object
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
        Dim Trans As System.Data.Odbc.OdbcTransaction
        Dim IsTrans As Boolean = False
        Dim VarVal As Object = Nothing




        Dim Obj As Object = Nothing
        Dim StrId As String = String.Empty
        Dim strInsertedOrUpdated As String = String.Empty
        Dim IntRecordsAffected As Integer = 0

        Try
            Me.GridDTL.GetText(ENUMGRID.DEPDESC, GridDTL.MaxRows, VarVal)
            If IsNothing(VarVal) = True Or VarVal.ToString.Trim = String.Empty Then Me.GridDTL.MaxRows = Me.GridDTL.MaxRows - 1

            Cmd.CommandType = CommandType.Text
            Con = GetAccesscon()
            Cmd.Connection = Con
            Trans = Con.BeginTransaction
            Cmd.Transaction = Trans
            IsTrans = True

            If Me.GridDTL.MaxRows = 0 Then
                StrSql = "DELETE FROM DEPARTMENT"
                Cmd.CommandText = StrSql
                IntRecordsAffected = Cmd.ExecuteNonQuery()
                If IntRecordsAffected > 0 Then
                    Trans.Commit()
                    IsTrans = False
                    MsgBox(IntRecordsAffected.ToString() + " Records Deleted.To Enter New Please Fill Type Description By Adding New Rows.", MsgBoxStyle.Information)
                Else
                    Trans.Commit()
                    IsTrans = False
                    MsgBox("Please Enter Department Name.", MsgBoxStyle.Information)
                End If

                Exit Sub
            End If

            For IntCtr = 1 To Me.GridDTL.MaxRows
                VARTYPECODE = Nothing
                VARTYPEDESC = Nothing
                VARENMODELCODE = Nothing
                VAROUTPUTPOWER = Nothing
                VARRPM = Nothing
                VARSTROKE = Nothing
                VARASP = Nothing
                VARFUELCONS = Nothing
                VARMAXCONS = Nothing
                VARPEAKFUELCONS = Nothing
                VARPISTONDISPLACMENT = Nothing
                VARPISTONDISPLACMENTUNIT = Nothing

                GridDTL.GetText(ENUMGRID.DEPCODE, IntCtr, VARTYPECODE)

                GridDTL.GetText(ENUMGRID.DEPDESC, IntCtr, VARTYPEDESC)
                If VARTYPEDESC.ToString.Trim = String.Empty Then
                    Trans.Rollback()
                    IsTrans = False
                    MsgBox("Please Enter Department Name.", MsgBoxStyle.Information)
                    GridDTL.Row = IntCtr
                    GridDTL.Col = ENUMGRID.DEPDESC
                    GridDTL.Action = FPSpread.ActionConstants.ActionActiveCell
                    GridDTL.Focus()

                    Exit Sub
                End If


                If VARTYPECODE.ToString.Trim <> String.Empty Then
                    StrSql = "UPDATE DEPARTMENT SET DEPDESC='" + VARTYPEDESC.ToString.Trim + "',USERCODE='" + UserCode + "'"
                    StrSql = StrSql + " WHERE DEPCODE='" + VARTYPECODE.ToString.Trim + "'"
                    Cmd.CommandText = StrSql
                    Cmd.ExecuteNonQuery()

                    If strInsertedOrUpdated.Trim = String.Empty Then
                        strInsertedOrUpdated = "'" + VARTYPECODE.ToString.Trim + "'"
                    Else
                        strInsertedOrUpdated = strInsertedOrUpdated + ",'" + VARTYPECODE.ToString.Trim + "'"
                    End If


                Else

                    StrSql = "SELECT iif( isnull( max( val(Mid(DEPCODE,3,4))))=true,1,max( val(Mid(DEPCODE,3,4)))+1)  As Id From DEPARTMENT  where MID(DEPCODE,1,2)='D-'"
                    Cmd.CommandText = StrSql
                    Obj = Cmd.ExecuteScalar()
                    StrId = Convert.ToInt16(Obj.ToString()).ToString("0000")
                    StrId = "D-" + StrId

                    StrSql = "INSERT INTO DEPARTMENT(DEPCODE,DEPDESC,USERCODE) "
                    StrSql = StrSql + " VALUES('" + StrId.Trim + "','" + VARTYPEDESC.ToString.Trim + "','" + UserCode + "')"
                    Cmd.CommandText = StrSql
                    Cmd.ExecuteNonQuery()

                    If strInsertedOrUpdated.Trim = String.Empty Then
                        strInsertedOrUpdated = "'" + StrId + "'"
                    Else
                        strInsertedOrUpdated = strInsertedOrUpdated + ",'" + StrId.ToString.Trim + "'"
                    End If
                End If
            Next

            StrSql = "DELETE FROM DEPARTMENT WHERE DEPCODE NOT IN(" + strInsertedOrUpdated.ToString + ")"
            Cmd.CommandText = StrSql
            Cmd.ExecuteNonQuery()
            Trans.Commit()
            IsTrans = False
            GetData()
            MsgBox("Saved Successfully.", MsgBoxStyle.Information)
            Me.CmdEdit.Enabled = True
            Me.CmdSave.Enabled = False
            Me.CmdCancel.Enabled = False
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Critical)
        Finally
            Con.Dispose()
            Cmd.Dispose()
            Obj = Nothing
            If IsTrans = True Then Trans.Rollback()
            Trans.Dispose()
        End Try
    End Sub

    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        Me.CmdEdit.Enabled = True
        Me.CmdSave.Enabled = False
        Me.CmdCancel.Enabled = False
        GetData()
    End Sub

    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub GridDTL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDTL.Enter
        GridDTL.Refresh()
        Me.Refresh()
        GridDTL.ShadowText = Color.Blue
        GridDTL.Refresh()
        Me.Refresh()
    End Sub

    Private Sub GridDTL_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDTL.GotFocus
      
    End Sub

    Private Sub GridDTL_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles GridDTL.KeyDownEvent
        If e.keyCode = Keys.Tab Then
            If Me.CmdEdit.Enabled = True Then Me.CmdEdit.Focus() Else CmdSave.Focus()
        End If
    End Sub

    Private Sub GridDTL_KeyPressEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyPressEvent) Handles GridDTL.KeyPressEvent
        If e.keyAscii = 39 Then
            e.keyAscii = 0
        End If
        Try
            Dim VarDesc As Object
            If Me.CmdSave.Enabled = True Then
                If e.keyAscii = 14 Or (e.keyAscii = 13 And GridDTL.ActiveCol = 2) Then
                    For IntCtr = 1 To Me.GridDTL.MaxRows
                        VarDesc = Nothing
                        GridDTL.GetText(2, IntCtr, VarDesc)
                        If VarDesc.ToString.Trim = String.Empty Then
                            MsgBox("Please Enter Department.", MsgBoxStyle.Information)
                            GridDTL.Row = IntCtr
                            GridDTL.Col = 2
                            GridDTL.Action = FPSpread.ActionConstants.ActionActiveCell
                            GridDTL.Focus()
                            Exit Sub
                        End If
                    Next
                    AddBlankRecordInGrid()
                End If
                If e.keyAscii = 4 Then
                    If GridDTL.MaxRows > 0 Then
                        DeleteRecordInGrid()
                    End If
                End If
            End If
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub GetData()
        Dim MySqlCon As New Odbc.OdbcConnection
        Dim MySqlDataRd As Odbc.OdbcDataReader
        Dim MySqlCmd As New Odbc.OdbcCommand
        MySqlCon = GetAccesscon()
        MySqlCmd.Connection = MySqlCon

        Try
            Me.GridDTL.MaxRows = 0
            MySqlCmd.CommandText = ""

            MySqlCmd.CommandText = "SELECT DEPCODE,DEPDESC FROM DEPARTMENT ORDER BY DEPCODE"


            MySqlDataRd = MySqlCmd.ExecuteReader()
            If (MySqlDataRd.HasRows = True) Then
                While (MySqlDataRd.Read)
                    AddBlankRecordInGrid()
                    Me.GridDTL.SetText(ENUMGRID.DEPCODE, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("DEPCODE")).ToString())
                    Me.GridDTL.SetText(ENUMGRID.DEPDESC, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("DEPDESC")).ToString())


                End While
            End If

            Me.GridDTL.BlockMode = True
            Me.GridDTL.Col = 1 : Me.GridDTL.Col2 = Me.GridDTL.MaxCols
            Me.GridDTL.Row = 1 : Me.GridDTL.Row2 = Me.GridDTL.MaxRows
            Me.GridDTL.Lock = True
            Me.GridDTL.BlockMode = False
            MySqlDataRd.Close()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally
            MySqlCon.Dispose()
            MySqlCmd.Dispose()
        End Try


    End Sub

    Private Sub GridDTL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDTL.Leave
        GridDTL.Refresh()
        Me.Refresh()
        GridDTL.ShadowText = Color.Black
        GridDTL.Refresh()
        Me.Refresh()
    End Sub

    Private Sub GridDTL_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDTL.LostFocus
      
    End Sub
End Class