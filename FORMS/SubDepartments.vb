Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Windows.Forms
Public Class SubDepartments
    Enum ENUMGRIDDTL
        DEPCODE = 1
        TYPEDESC = 2
    End Enum
    Enum ENUMGRIDDTL1
        SUBDEPCODE = 1
        DESCRIPTION = 2
    End Enum
    Dim Blncombofill As Boolean = False
    Private Sub AddBlankRecordInGrid1(ByVal blnSetFocus As Boolean)
        Me.GridDTL1.MaxRows = Me.GridDTL1.MaxRows + 1
        Me.GridDTL1.Row = Me.GridDTL1.MaxRows
        Me.GridDTL1.Col = ENUMGRIDDTL1.SUBDEPCODE : Me.GridDTL1.ColHidden = False
        Me.GridDTL1.Col = ENUMGRIDDTL1.DESCRIPTION : Me.GridDTL1.ColHidden = False

        Me.GridDTL1.Col = ENUMGRIDDTL1.SUBDEPCODE : Me.GridDTL1.CellType = FPSpread.CellTypeConstants.CellTypeStaticText
        Me.GridDTL1.Col = ENUMGRIDDTL1.DESCRIPTION : Me.GridDTL1.TypeEditLen = 100 : Me.GridDTL1.ColHidden = False

        Me.GridDTL1.BlockMode = True
        Me.GridDTL1.Col = ENUMGRIDDTL1.SUBDEPCODE : Me.GridDTL1.Col2 = ENUMGRIDDTL1.SUBDEPCODE
        Me.GridDTL1.Row = 1 : Me.GridDTL1.Row2 = Me.GridDTL1.MaxRows
        Me.GridDTL1.Lock = True
        Me.GridDTL1.BlockMode = False

        If blnSetFocus = True Then
            GridDTL1.Row = Me.GridDTL1.MaxRows
            GridDTL1.Col = ENUMGRIDDTL1.DESCRIPTION
            GridDTL1.Action = FPSpread.ActionConstants.ActionActiveCell
            GridDTL1.Focus()
        End If
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
            Me.GridDTL1.GetText(ENUMGRIDDTL1.SUBDEPCODE, Me.GridDTL1.ActiveRow, VarTypeCode)
            Me.GridDTL1.GetText(ENUMGRIDDTL1.DESCRIPTION, Me.GridDTL1.ActiveRow, VarTypeDesc)
            If VarTypeDesc.ToString.Trim <> String.Empty And MsgBox("Are You Sure To Delete The Sub-Department " + VarTypeDesc + "?", MsgBoxStyle.YesNo) = MsgBoxResult.No Then
                Exit Sub
            End If
            StrSql = "SELECT count(*) as cnt FROM services e where SUBDEPCODE='" + VarTypeCode.ToString.Trim + "';"
            Cmd.CommandText = StrSql
            obj = Cmd.ExecuteScalar()
            If obj.ToString <> "0" Then
                MsgBox("This Sub-Department Has Been Involved In Services.", MsgBoxStyle.Information)
                Exit Sub
            End If
            Me.GridDTL1.Row = Me.GridDTL1.ActiveRow
            Me.GridDTL1.Action = 5
            GridDTL1.MaxRows = GridDTL1.MaxRows - 1
        Catch EX As Exception
            MsgBox(EX.Message)
        Finally
            Cmd.Dispose()
            Con.Dispose()
            Cmd.Dispose()
        End Try

    End Sub

    Private Sub GridDTL1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDTL1.Enter
        GridDTL1.Refresh()
        Me.Refresh()
        GridDTL1.ShadowText = Color.Blue
        GridDTL1.Refresh()
        Me.Refresh()
    End Sub

    Private Sub GridDTL1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDTL1.GotFocus
       
    End Sub
    Private Sub GridDTL11_KeyPressEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyPressEvent) Handles GridDTL1.KeyPressEvent
        If e.keyAscii = 39 Then
            e.keyAscii = 0
        End If
        Try
            Dim VarDesc As Object
            If Me.CmdSave.Enabled = True Then
                If e.keyAscii = 14 Or (e.keyAscii = 13 And GridDTL1.ActiveCol = 2) Then
                    For IntCtr = 1 To Me.GridDTL1.MaxRows
                        VarDesc = Nothing
                        GridDTL1.GetText(2, IntCtr, VarDesc)
                        If VarDesc.ToString.Trim = String.Empty Then
                            MsgBox("Please Enter Sub-Department.", MsgBoxStyle.Information)
                            GridDTL1.Row = IntCtr
                            GridDTL1.Col = 2
                            GridDTL1.Action = FPSpread.ActionConstants.ActionActiveCell
                            GridDTL1.Focus()
                            Exit Sub
                        End If
                    Next
                    AddBlankRecordInGrid1(True)
                End If
                If e.keyAscii = 4 Then
                    If GridDTL1.MaxRows > 0 Then
                        DeleteRecordInGrid()
                    End If
                End If
            End If
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub FillCombo()
        Dim MySqlCon As New Odbc.OdbcConnection()
        Dim MysqlCmd As New Odbc.OdbcCommand
        MySqlCon = GetAccesscon()
        Dim DS As New DataSet
        Dim MySqlAdp As Odbc.OdbcDataAdapter
        Blncombofill = True
        Try
            MySqlAdp = New Odbc.OdbcDataAdapter("SELECT DEPCODE,DEPDESC FROM DEPARTMENT ORDER BY DEPDESC", MySqlCon)
            MySqlAdp.Fill(DS, "TAB1")
            Me.CmbManufacturer.DataSource = DS.Tables("TAB1")
            Me.CmbManufacturer.ValueMember = "DEPCODE"
            Me.CmbManufacturer.DisplayMember = "DEPDESC"
            MySqlAdp.Dispose()
            If CmbManufacturer.Items.Count > 0 Then
                CmbManufacturer.SelectedItem = 0
                GetData(CmbManufacturer.SelectedValue)
            End If

        Catch Ex As Exception
            MsgBox(Ex.Message)
        Finally
            Blncombofill = False
            MySqlCon.Dispose()
        End Try

    End Sub

    Private Sub SubDepartments_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
        If e.KeyChar = Chr(Keys.Escape) Then
            Me.CmdClose_Click(sender, New System.EventArgs())
        End If
    End Sub




    Private Sub EquipmentModel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridDTL1.MaxRows = 0
        FillCombo()
        Me.KeyPreview = True
    End Sub

    Private Sub CmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEdit.Click
        Me.GridDTL1.BlockMode = True
        Me.GridDTL1.Col = ENUMGRIDDTL1.SUBDEPCODE : Me.GridDTL1.Col2 = ENUMGRIDDTL1.SUBDEPCODE
        Me.GridDTL1.Row = 1 : Me.GridDTL1.Row2 = Me.GridDTL1.MaxRows
        Me.GridDTL1.Lock = True
        Me.GridDTL1.BlockMode = False

        Me.GridDTL1.BlockMode = True
        Me.GridDTL1.Col = ENUMGRIDDTL1.DESCRIPTION : Me.GridDTL1.Col2 = ENUMGRIDDTL1.DESCRIPTION
        Me.GridDTL1.Row = 1 : Me.GridDTL1.Row2 = Me.GridDTL1.MaxRows
        Me.GridDTL1.Lock = False
        Me.GridDTL1.BlockMode = False

        Me.CmdEdit.Enabled = False
        Me.CmdSave.Enabled = True
        Me.CmdCancel.Enabled = True
        CmbManufacturer.Enabled = False
        Me.GridDTL1.Focus()
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
        Dim Trans As System.Data.Odbc.OdbcTransaction
        Dim IsTrans As Boolean = False
        Dim VarVal As Object = Nothing

        Dim Obj As Object = Nothing
        Dim StrId As String = String.Empty
        Dim strInsertedOrUpdated As String = String.Empty
        Dim IntRecordsAffected As Integer = 0

        Try


            If Me.CmbManufacturer.Items.Count = 0 Then
                MsgBox("Please Select Sub Department.")
                Me.CmbManufacturer.Focus()
                Exit Sub
            End If

            Me.GridDTL1.GetText(ENUMGRIDDTL1.DESCRIPTION, GridDTL1.MaxRows, VarVal)
            If IsNothing(VarVal) = True Or VarVal.ToString.Trim = String.Empty Then Me.GridDTL1.MaxRows = Me.GridDTL1.MaxRows - 1


            VarMfgCode = Me.CmbManufacturer.SelectedValue
            Cmd.CommandType = CommandType.Text
            Con = GetAccesscon()
            Cmd.Connection = Con
            Trans = Con.BeginTransaction
            Cmd.Transaction = Trans
            IsTrans = True

            If Me.GridDTL1.MaxRows = 0 Then
                StrSql = "DELETE FROM SUBDEPARTMENT Where DepCode='" + VarMfgCode.ToString.Trim + "'"
                Cmd.CommandText = StrSql
                IntRecordsAffected = Cmd.ExecuteNonQuery()
                If IntRecordsAffected > 0 Then
                    Trans.Commit()
                    IsTrans = False
                    MsgBox(IntRecordsAffected.ToString() + " Records Deleted.To Enter New Please Fill Type Sub Department By Adding New Rows.", MsgBoxStyle.Information)
                Else
                    Trans.Commit()
                    IsTrans = False
                    MsgBox("Please Enter Sub Department.", MsgBoxStyle.Information)
                End If
                
                Exit Sub
            End If

            For IntCtr = 1 To Me.GridDTL1.MaxRows

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
                VarModelCode = Nothing

                GridDTL1.GetText(ENUMGRIDDTL1.SUBDEPCODE, IntCtr, VarModelCode)

                GridDTL1.GetText(ENUMGRIDDTL1.DESCRIPTION, IntCtr, VARTYPEDESC)
                If VARTYPEDESC.ToString.Trim = String.Empty Then
                    Trans.Rollback()
                    IsTrans = False
                    MsgBox("Please Enter Sub Department.", MsgBoxStyle.Information)
                    GridDTL1.Row = IntCtr
                    GridDTL1.Col = ENUMGRIDDTL1.DESCRIPTION
                    GridDTL1.Action = FPSpread.ActionConstants.ActionActiveCell
                    GridDTL1.Focus()

                    Exit Sub
                End If


                If VarModelCode.ToString.Trim <> String.Empty Then
                    StrSql = "UPDATE SUBDEPARTMENT SET SUBDEPCODE='" + VarModelCode.ToString.Trim + "',SUBDEPDESC='" + VARTYPEDESC.ToString.Trim + "',DEPCODE='" + Me.CmbManufacturer.SelectedValue + "',USERCODE='" + UserCode + "'"
                    StrSql = StrSql + " WHERE SUBDEPCODE='" + VarModelCode.ToString.Trim + "'"
                    Cmd.CommandText = StrSql
                    Cmd.ExecuteNonQuery()

                    If strInsertedOrUpdated.Trim = String.Empty Then
                        strInsertedOrUpdated = "'" + VarModelCode.ToString.Trim + "'"
                    Else
                        strInsertedOrUpdated = strInsertedOrUpdated + ",'" + VarModelCode.ToString.Trim + "'"
                    End If


                Else

                    StrSql = "SELECT iif(  isnull(max( val( mid(SUBDEPCODE,3,4)) ) )=true,1,max( val( mid(SUBDEPCODE,3,4)) )+1) as id  From SUBDEPARTMENT  where mid(SUBDEPCODE,1,2)='SD'"
                    Cmd.CommandText = StrSql
                    Obj = Cmd.ExecuteScalar()
                    StrId = Convert.ToInt16(Obj.ToString()).ToString("0000")
                    StrId = "SD" + StrId

                    StrSql = "INSERT INTO SUBDEPARTMENT(SUBDEPCODE,SUBDEPDESC,DEPCODE,USERCODE) "
                    StrSql = StrSql + " VALUES('" + StrId.Trim + "','" + VARTYPEDESC.ToString.Trim + "','" + Me.CmbManufacturer.SelectedValue + "','" + UserCode + "')"
                    Cmd.CommandText = StrSql
                    Cmd.ExecuteNonQuery()

                    If strInsertedOrUpdated.Trim = String.Empty Then
                        strInsertedOrUpdated = "'" + StrId + "'"
                    Else
                        strInsertedOrUpdated = strInsertedOrUpdated + ",'" + StrId.ToString.Trim + "'"
                    End If
                End If
            Next

            StrSql = "DELETE FROM SUBDEPARTMENT WHERE SUBDEPCODE NOT IN(" + strInsertedOrUpdated.ToString + ") And DEPCODE='" + Me.CmbManufacturer.SelectedValue + "'"
            Cmd.CommandText = StrSql
            Cmd.ExecuteNonQuery()
            Trans.Commit()
            IsTrans = False
            Me.GridDTL1.MaxRows = 0
            GetData(Me.CmbManufacturer.SelectedValue)

            MsgBox("Saved Successfully.", MsgBoxStyle.Information)
            Me.CmdEdit.Enabled = True
            Me.CmdSave.Enabled = False
            Me.CmdCancel.Enabled = False
            CmbManufacturer.Enabled = True
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
        CmbManufacturer.Enabled = True
        GetData(Me.CmbManufacturer.SelectedValue)
    End Sub

    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub GetData(ByVal strManufacturer As String)
        Dim MySqlCon As New Odbc.OdbcConnection()
        Dim MySqlDataRd As Odbc.OdbcDataReader
        Dim MySqlCmd As New Odbc.OdbcCommand
        MySqlCon = GetAccesscon()
        MySqlCmd.Connection = MySqlCon

        Try
            Me.GridDTL1.MaxRows = 0
            MySqlCmd.CommandText = ""

            MySqlCmd.CommandText = "SELECT SUBDEPCODE,SUBDEPDESC FROM SUBDEPARTMENT Where DEPCODE='" + strManufacturer.Trim + "'"
            MySqlDataRd = MySqlCmd.ExecuteReader()

            If (MySqlDataRd.HasRows = True) Then
                While (MySqlDataRd.Read)
                    AddBlankRecordInGrid1(False)
                    Me.GridDTL1.SetText(ENUMGRIDDTL1.SUBDEPCODE, Me.GridDTL1.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("SUBDEPCODE")).ToString())
                    Me.GridDTL1.SetText(ENUMGRIDDTL1.DESCRIPTION, Me.GridDTL1.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("SUBDEPDESC")).ToString())
                End While
            End If

            Me.GridDTL1.BlockMode = True
            Me.GridDTL1.Col = 1 : Me.GridDTL1.Col2 = Me.GridDTL1.MaxCols
            Me.GridDTL1.Row = 1 : Me.GridDTL1.Row2 = Me.GridDTL1.MaxRows
            Me.GridDTL1.Lock = True
            Me.GridDTL1.BlockMode = False
            MySqlDataRd.Close()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally
            MySqlCon.Dispose()
            MySqlCmd.Dispose()
        End Try
    End Sub
   
    Private Sub CmbManufacturer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbManufacturer.SelectedIndexChanged
        If IsNothing(Me.CmbManufacturer) = False And Blncombofill = False Then
            If Me.CmbManufacturer.Items.Count > 0 Then
                Dim VarMfgCode As Object = Nothing
                Dim VarTypeCode As Object = Nothing
                Me.GridDTL1.MaxRows = 0
                VarMfgCode = Me.CmbManufacturer.SelectedValue
                GetData(CmbManufacturer.SelectedValue)
            End If
        End If
    End Sub

    Private Sub GridDTL1_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles GridDTL1.Advance

    End Sub

    Private Sub GridDTL1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDTL1.LostFocus
        
    End Sub

    Private Sub GridDTL1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDTL1.Leave
        GridDTL1.Refresh()
        Me.Refresh()
        GridDTL1.ShadowText = Color.Black
        GridDTL1.Refresh()
        Me.Refresh()
    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub
End Class