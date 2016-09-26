Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Windows.Forms
Public Class Services
    Dim BLNFILLCOMBO As Boolean = True
    Enum ENUMGRIDDTL
        SUBDEPCODE = 1
        SUBDEPDESC = 2
    End Enum
    Enum ENUMGRIDDTL1
        SERVICECODE = 1
        UDSERVICECODE = 2
        DESCRIPTION = 3
        CHARGE = 4

    End Enum
    Private Sub AddBlankRecordInGrid()
        Me.GridDTL.MaxRows = Me.GridDTL.MaxRows + 1
        Me.GridDTL.Row = Me.GridDTL.MaxRows
        Me.GridDTL.Col = ENUMGRIDDTL.SUBDEPCODE : Me.GridDTL.ColHidden = False
        Me.GridDTL.Col = ENUMGRIDDTL.SUBDEPDESC : Me.GridDTL.ColHidden = False

        Me.GridDTL.Col = ENUMGRIDDTL.SUBDEPCODE : Me.GridDTL.CellType = FPSpread.CellTypeConstants.CellTypeStaticText
        Me.GridDTL.Col = ENUMGRIDDTL.SUBDEPDESC : Me.GridDTL.TypeEditLen = 100 : Me.GridDTL.ColHidden = False


        Me.GridDTL.BlockMode = True
        Me.GridDTL.Col = ENUMGRIDDTL.SUBDEPCODE : Me.GridDTL.Col2 = ENUMGRIDDTL.SUBDEPDESC
        Me.GridDTL.Row = 1 : Me.GridDTL.Row2 = Me.GridDTL.MaxRows
        Me.GridDTL.Lock = True
        Me.GridDTL.BlockMode = False

    End Sub
    Private Sub AddBlankRecordInGrid1(ByVal blnSetFocus As Boolean)
        Me.GridDTL1.MaxRows = Me.GridDTL1.MaxRows + 1
        Me.GridDTL1.Row = Me.GridDTL1.MaxRows
        Me.GridDTL1.Col = ENUMGRIDDTL1.SERVICECODE : Me.GridDTL1.ColHidden = True : Me.GridDTL1.Lock = True
        Me.GridDTL1.Col = ENUMGRIDDTL1.DESCRIPTION : Me.GridDTL1.ColHidden = False

        Me.GridDTL1.Col = ENUMGRIDDTL1.UDSERVICECODE : Me.GridDTL1.TypeEditLen = 6 : Me.GridDTL1.ColHidden = False : Me.GridDTL1.Lock = False
        Me.GridDTL1.Col = ENUMGRIDDTL1.DESCRIPTION : Me.GridDTL1.TypeEditLen = 100 : Me.GridDTL1.ColHidden = False
        Me.GridDTL1.Col = ENUMGRIDDTL1.CHARGE : Me.GridDTL1.CellType = FPSpreadADO.CellTypeConstants.CellTypeNumber : Me.GridDTL1.Lock = False : Me.GridDTL1.TypeIntegerMax = 99999.99

        Me.GridDTL1.BlockMode = True
        Me.GridDTL1.Col = ENUMGRIDDTL1.SERVICECODE : Me.GridDTL1.Col2 = ENUMGRIDDTL1.UDSERVICECODE
        Me.GridDTL1.Row = 1 : Me.GridDTL1.Row2 = Me.GridDTL1.MaxRows
        Me.GridDTL1.Lock = False
        Me.GridDTL1.BlockMode = False

        If blnSetFocus = True Then
            GridDTL1.Row = Me.GridDTL1.MaxRows
            GridDTL1.Col = ENUMGRIDDTL1.UDSERVICECODE
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

        Try
            Cmd.CommandType = CommandType.Text
            Con = GetAccesscon()
            Cmd.Connection = Con
            Me.GridDTL1.GetText(ENUMGRIDDTL1.SERVICECODE, Me.GridDTL1.ActiveRow, VarTypeCode)

            StrSql = "SELECT count(*) as cnt FROM patientbilling e where SERVICECODE='" + VarTypeCode.ToString.Trim + "';"
            Cmd.CommandText = StrSql
            obj = Cmd.ExecuteScalar()
            If obj.ToString <> "0" Then
                MsgBox("This Service Has Been Involved Patient Billing.", MsgBoxStyle.Information)
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

    Private Sub GridDTL1_DblClick(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_DblClickEvent) Handles GridDTL1.DblClick
        'Dim Frm As New DefaultReport
        'GridDTL1.Col = ENUMGRIDDTL1.DESCRIPTION
        'GridDTL1.Row = GridDTL1.ActiveRow
        'Frm.LblDefaultReportFor.Text = GridDTL1.Text
        'GridDTL1.Col = ENUMGRIDDTL1.SERVICECODE
        'Frm.LblServiceCode.Text = GridDTL1.Text
        'Frm.GetSavedDefaultReport()
        'Frm.ShowDialog()
    End Sub

    Private Sub GridDTL1_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDTL1.Enter
        Try
            GridDTL1.Refresh()
            Me.Refresh()
            GridDTL1.ShadowText = Color.Blue
            GridDTL1.Refresh()
            Me.Refresh()
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Critical)
        Finally

        End Try
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
                If e.keyAscii = 14 Or (e.keyAscii = 13 And GridDTL1.ActiveCol = ENUMGRIDDTL1.CHARGE) Then
                    For IntCtr = 1 To Me.GridDTL1.MaxRows
                        VarDesc = Nothing
                        GridDTL1.GetText(ENUMGRIDDTL1.DESCRIPTION, IntCtr, VarDesc)
                        If VarDesc.ToString.Trim = String.Empty Then
                            MsgBox("Please Enter Service Name.", MsgBoxStyle.Information)
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
        Dim MySqlCon As New Odbc.OdbcConnection
        Dim MysqlCmd As New Odbc.OdbcCommand
        MySqlCon = GetAccesscon()
        Dim DS As New DataSet
        Dim MySqlAdp As Odbc.OdbcDataAdapter
        BLNFILLCOMBO = True
        Try
            MySqlAdp = New Odbc.OdbcDataAdapter("SELECT DEPCODE,DEPDESC FROM DEPARTMENT  ORDER BY DEPDESC", MySqlCon)
            MySqlAdp.Fill(DS, "TAB1")
            Me.CmbManufacturer.DataSource = DS.Tables("TAB1")
            Me.CmbManufacturer.ValueMember = "DEPCODE"
            Me.CmbManufacturer.DisplayMember = "DEPDESC"
            MySqlAdp.Dispose()
            GETCOMBODATA()
        Catch Ex As Exception
            MsgBox(Ex.Message)
        Finally
            BLNFILLCOMBO = False
            MySqlCon.Dispose()
        End Try

    End Sub


    Private Sub GETCOMBODATA()
        Dim MySqlCon As New Odbc.OdbcConnection
        Dim MysqlCmd As New Odbc.OdbcCommand
        MySqlCon = GetAccesscon()
        Dim MysqlDr As Odbc.OdbcDataReader

        Try

            MysqlCmd.Connection = MySqlCon
            MysqlCmd.CommandText = "SELECT SUBDEPCODE AS SUBDEPCODE1,SUBDEPDESC AS SUBDEPDESC1 FROM SUBDEPARTMENT where Depcode='" + Me.CmbManufacturer.SelectedValue + "' ORDER BY SUBDEPDESC"
            MysqlDr = MysqlCmd.ExecuteReader()

            If (MysqlDr.HasRows = True) Then
                While (MysqlDr.Read)
                    AddBlankRecordInGrid()
                    Me.GridDTL.SetText(ENUMGRIDDTL.SUBDEPCODE, Me.GridDTL.MaxRows, MysqlDr.GetValue(MysqlDr.GetOrdinal("SUBDEPCODE1")).ToString())
                    Me.GridDTL.SetText(ENUMGRIDDTL.SUBDEPDESC, Me.GridDTL.MaxRows, MysqlDr.GetValue(MysqlDr.GetOrdinal("SUBDEPDESC1")).ToString())
                End While
            End If
            If MysqlDr.IsClosed = False Then MysqlDr.Close()
        Catch Ex As Exception
            MsgBox(Ex.Message)
        Finally
            MySqlCon.Dispose()
        End Try

    End Sub

   

    Private Sub CmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEdit.Click
        Try
            Dim varValue As Object = Nothing
            Me.GridDTL1.BlockMode = True
            Me.GridDTL1.Col = ENUMGRIDDTL1.SERVICECODE : Me.GridDTL1.Col2 = ENUMGRIDDTL1.SERVICECODE
            Me.GridDTL1.Row = 1 : Me.GridDTL1.Row2 = Me.GridDTL1.MaxRows
            Me.GridDTL1.Lock = True
            Me.GridDTL1.BlockMode = False

            Me.GridDTL1.BlockMode = True
            Me.GridDTL1.Col = ENUMGRIDDTL1.UDSERVICECODE : Me.GridDTL1.Col2 = ENUMGRIDDTL1.UDSERVICECODE
            Me.GridDTL1.Row = 1 : Me.GridDTL1.Row2 = Me.GridDTL1.MaxRows
            Me.GridDTL1.Lock = False
            Me.GridDTL1.BlockMode = False


            Me.GridDTL1.BlockMode = True
            Me.GridDTL1.Col = ENUMGRIDDTL1.DESCRIPTION : Me.GridDTL1.Col2 = ENUMGRIDDTL1.CHARGE
            Me.GridDTL1.Row = 1 : Me.GridDTL1.Row2 = Me.GridDTL1.MaxRows
            Me.GridDTL1.Lock = False
            Me.GridDTL1.BlockMode = False

            Me.CmdEdit.Enabled = False
            Me.CmdSave.Enabled = True
            Me.CmdCancel.Enabled = True
            GridDTL.Enabled = False
            CmbManufacturer.Enabled = False
            GridDTL.GetText(ENUMGRIDDTL.SUBDEPDESC, GridDTL.ActiveRow, varValue)
            LblServicesInDept.Text = "Services In Sub-Department [ " + varValue + " ]"
            Me.GridDTL1.Focus()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally

        End Try
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
            Me.GridDTL.GetText(ENUMGRIDDTL.SUBDEPCODE, Me.GridDTL.ActiveRow, VarTypeCode)

            If Me.CmbManufacturer.Items.Count = 0 Then
                MsgBox("Please Select SubDepartment.")
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
                StrSql = "DELETE FROM SERVICES Where SUBDEPCODE='" + VarTypeCode.ToString.Trim + "' And DEPCODE='" + VarMfgCode.ToString.Trim + "'"
                Cmd.CommandText = StrSql
                IntRecordsAffected = Cmd.ExecuteNonQuery()
                If IntRecordsAffected > 0 Then
                    Trans.Commit()
                    IsTrans = False
                    MsgBox(IntRecordsAffected.ToString() + " Records Deleted.To Enter New Please Fill Type Description By Adding New Rows.", MsgBoxStyle.Information)
                Else
                    Trans.Commit()
                    IsTrans = False
                    MsgBox("Please Enter Services.", MsgBoxStyle.Information)
                End If
                
                Exit Sub
            End If
            If VarTypeCode.ToString.Trim = String.Empty Or Me.GridDTL.MaxRows = 0 Then
                Trans.Commit()
                IsTrans = False
                MsgBox("Please Enter Sub Department.", MsgBoxStyle.Information)
                Exit Sub
            End If

            Dim CheckCounter As Integer = 0

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
                VarUDModelCode = Nothing
                VarCharges = Nothing

                GridDTL1.GetText(ENUMGRIDDTL1.SERVICECODE, IntCtr, VarModelCode)
                

                GridDTL1.GetText(ENUMGRIDDTL1.UDSERVICECODE, IntCtr, VarUDModelCode)
                If VarUDModelCode.ToString.Trim = String.Empty Then
                    Trans.Rollback()
                    IsTrans = False
                    MsgBox("Please Enter Service Code.", MsgBoxStyle.Information)
                    GridDTL1.Row = IntCtr
                    GridDTL1.Col = ENUMGRIDDTL1.UDSERVICECODE
                    GridDTL1.Action = FPSpread.ActionConstants.ActionActiveCell
                    GridDTL1.Focus()

                    Exit Sub
                End If


                GridDTL1.GetText(ENUMGRIDDTL1.DESCRIPTION, IntCtr, VARTYPEDESC)
                If VARTYPEDESC.ToString.Trim = String.Empty Then
                    Trans.Rollback()
                    IsTrans = False
                    MsgBox("Please Enter Service Name.", MsgBoxStyle.Information)
                    GridDTL1.Row = IntCtr
                    GridDTL1.Col = ENUMGRIDDTL1.DESCRIPTION
                    GridDTL1.Action = FPSpread.ActionConstants.ActionActiveCell
                    GridDTL1.Focus()

                    Exit Sub
                End If


                GridDTL1.GetText(ENUMGRIDDTL1.CHARGE, IntCtr, VarCharges)
                If IsNothing(VarCharges) = True Then VarCharges = "0"
                'If Val(VarCharges) = 0 Then
                '    MsgBox("Please Enter Service Charge.", MsgBoxStyle.Information)
                '    GridDTL1.Row = IntCtr
                '    GridDTL1.Col = ENUMGRIDDTL1.CHARGE
                '    GridDTL1.Action = FPSpread.ActionConstants.ActionActiveCell
                '    GridDTL1.Focus()
                '    Trans.Rollback()
                '    IsTrans = False
                '    Exit Sub
                'End If



                '   For CheckCounter = 1 To GridDTL1.MaxRows


                Dim SQLREADER As Odbc.OdbcDataReader

                If (VarModelCode.ToString() = "") Then
                    StrSql = "SELECT UDSERVICECODE,SERVICECODE FROM SERVICES WHERE  LCASE(UDSERVICECODE)='" + VarUDModelCode.ToString().ToLower() + "'"
                Else
                    StrSql = "SELECT UDSERVICECODE,SERVICECODE FROM SERVICESCHECKVIEW WHERE ALREADYEXISTS=1 AND SERVICECODE='" + VarModelCode + "'"
                End If


                Cmd.CommandText = StrSql

                SQLREADER = Cmd.ExecuteReader
                Dim varudsvcd As Object = Nothing
                If (SQLREADER.HasRows()) Then
                    If (SQLREADER.GetValue(0) <> VarUDModelCode) And (VarModelCode.ToString() <> "") Then
                        varudsvcd = SQLREADER.GetValue(0)
                        MsgBox("Service Code used in PatientBilling.")
                        GridDTL1.Row = IntCtr
                        GridDTL1.SetText(ENUMGRIDDTL1.UDSERVICECODE, IntCtr, varudsvcd)
                        GridDTL1.Col = ENUMGRIDDTL1.UDSERVICECODE
                        GridDTL1.Action = FPSpread.ActionConstants.ActionActiveCell
                        GridDTL1.Focus()
                        Trans.Rollback()
                        IsTrans = False
                        SQLREADER.Close()
                        Exit Sub
                    End If
                    If (VarModelCode.ToString() = "") Then
                        MsgBox("Service Code already exists.")
                        GridDTL1.Row = IntCtr
                        GridDTL1.Col = ENUMGRIDDTL1.UDSERVICECODE
                        GridDTL1.Action = FPSpread.ActionConstants.ActionActiveCell
                        GridDTL1.Focus()
                        Trans.Rollback()
                        IsTrans = False
                        SQLREADER.Close()
                        Exit Sub
                    End If
                End If
                SQLREADER.Close()

                StrSql = "SELECT UDSERVICECODE,SERVICECODE FROM SERVICES WHERE SERVICECODE='" + VarModelCode + "'"
                Cmd.CommandText = StrSql
                SQLREADER = Cmd.ExecuteReader

                If (SQLREADER.HasRows()) Then
                    If (SQLREADER.GetValue(0) <> VarUDModelCode) Then

                        SQLREADER.Close()

                        StrSql = "SELECT UDSERVICECODE,SERVICECODE FROM SERVICES WHERE UDSERVICECODE='" + VarUDModelCode + "'"
                        Cmd.CommandText = StrSql
                        SQLREADER = Cmd.ExecuteReader
                        If (SQLREADER.HasRows()) Then
                            MsgBox("Service Code already exists.")
                            GridDTL1.Row = IntCtr
                            ' GridDTL1.SetText(ENUMGRIDDTL1.UDSERVICECODE, IntCtr, varudsvcd)
                            GridDTL1.Col = ENUMGRIDDTL1.UDSERVICECODE
                            GridDTL1.Action = FPSpread.ActionConstants.ActionActiveCell
                            GridDTL1.Focus()
                            Trans.Rollback()
                            IsTrans = False
                            SQLREADER.Close()
                            Exit Sub
                        End If

                        

                    End If
                  
                End If
                SQLREADER.Close()

                'Next


                If VarModelCode.ToString.Trim <> String.Empty Then
                    StrSql = "UPDATE SERVICES SET UDSERVICECODE='" + VarUDModelCode.ToString.Trim + "',SERVICEDESC='" + VARTYPEDESC.ToString.Trim + "',DEPCODE='" + VarMfgCode.ToString.Trim + "',SUBDEPCODE='" + VarTypeCode.ToString.Trim + "',Charge=" + VarCharges.ToString.Trim + ",USERCODE='" + UserCode + "'"
                    StrSql = StrSql + " WHERE SERVICECODE='" + VarModelCode.ToString.Trim + "'"
                    Cmd.CommandText = StrSql
                    Cmd.ExecuteNonQuery()

                    If strInsertedOrUpdated.Trim = String.Empty Then
                        strInsertedOrUpdated = "'" + VarModelCode.ToString.Trim + "'"
                    Else
                        strInsertedOrUpdated = strInsertedOrUpdated + ",'" + VarModelCode.ToString.Trim + "'"
                    End If


                Else

                    StrSql = "SELECT  iif( isnull( max( val( mid(SERVICECODE,3,4))) )=true,1, max( val( mid(SERVICECODE,3,4)))+1)    As Id From SERVICES where mid(SERVICECODE,1,2)='SE'"
                    Cmd.CommandText = StrSql
                    Obj = Cmd.ExecuteScalar()
                    StrId = Convert.ToInt16(Obj.ToString()).ToString("0000")
                    StrId = "SE" + StrId

                    StrSql = "INSERT INTO SERVICES(SERVICECODE,UDSERVICECODE,SERVICEDESC,DEPCODE,SUBDEPCODE,CHARGE,USERCODE) "
                    StrSql = StrSql + " VALUES('" + StrId.Trim + "','" + VarUDModelCode + "','" + VARTYPEDESC.ToString.Trim + "','" + VarMfgCode.ToString.Trim + "','" + VarTypeCode.ToString.Trim + "'," + VarCharges.ToString.Trim + ",'" + UserCode + "')"
                    Cmd.CommandText = StrSql
                    Cmd.ExecuteNonQuery()

                    If strInsertedOrUpdated.Trim = String.Empty Then
                        strInsertedOrUpdated = "'" + StrId + "'"
                    Else
                        strInsertedOrUpdated = strInsertedOrUpdated + ",'" + StrId.ToString.Trim + "'"
                    End If
                End If
            Next

            StrSql = "DELETE FROM SERVICES WHERE SERVICECODE NOT IN(" + strInsertedOrUpdated.ToString + ") And SUBDEPCODE='" + VarTypeCode.ToString.Trim + "' And DEPCODE='" + VarMfgCode.ToString.Trim + "'"
            Cmd.CommandText = StrSql
            Cmd.ExecuteNonQuery()
            Trans.Commit()
            IsTrans = False
            Me.GridDTL1.MaxRows = 0
            GetData(VarMfgCode.ToString.Trim, VarTypeCode.ToString.Trim)

            MsgBox("Saved Successfully.", MsgBoxStyle.Information)
            Me.CmdEdit.Enabled = True
            Me.CmdSave.Enabled = False
            Me.CmdCancel.Enabled = False
            GridDTL.Enabled = True
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
        Try
            Dim VarTypeCode As Object = Nothing
            Me.CmdEdit.Enabled = True
            Me.CmdSave.Enabled = False
            Me.CmdCancel.Enabled = False
            GridDTL.Enabled = True
            CmbManufacturer.Enabled = True
            Me.GridDTL.GetText(ENUMGRIDDTL.SUBDEPCODE, GridDTL.ActiveRow, VarTypeCode)
            GetData(Me.CmbManufacturer.SelectedValue, VarTypeCode.ToString)
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally

        End Try
    End Sub

    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        Try
            Me.Close()
            Me.Dispose()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally

        End Try
    End Sub

    Private Sub GetData(ByVal strManufacturer As String, ByVal strTypeCode As String)
        Dim MySqlCon As New Odbc.OdbcConnection
        Dim MySqlDataRd As Odbc.OdbcDataReader
        Dim MySqlCmd As New Odbc.OdbcCommand
        MySqlCon = GetAccesscon()
        MySqlCmd.Connection = MySqlCon

        Try
            Me.GridDTL1.MaxRows = 0
            MySqlCmd.CommandText = ""

            MySqlCmd.CommandText = "SELECT UDSERVICECODE as UDMODELCODE, SERVICECODE as MODELCODE,SERVICEDESC as MODELDESC,CHARGE FROM SERVICES Where DEPCODE='" + strManufacturer.Trim + "' and SUBDEPCODE='" + strTypeCode.Trim + "'"
            MySqlDataRd = MySqlCmd.ExecuteReader()

            If (MySqlDataRd.HasRows = True) Then
                While (MySqlDataRd.Read)
                    AddBlankRecordInGrid1(False)

                    Me.GridDTL1.SetText(ENUMGRIDDTL1.SERVICECODE, Me.GridDTL1.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("MODELCODE")).ToString())
                    Me.GridDTL1.SetText(ENUMGRIDDTL1.UDSERVICECODE, Me.GridDTL1.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("UDMODELCODE")).ToString())
                    Me.GridDTL1.SetText(ENUMGRIDDTL1.DESCRIPTION, Me.GridDTL1.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("MODELDESC")).ToString())
                    Me.GridDTL1.SetText(ENUMGRIDDTL1.CHARGE, Me.GridDTL1.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("CHARGE")).ToString())
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

    Private Sub GridDTL_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDTL.GotFocus
        GridDTL.Refresh()
        Me.Refresh()
        GridDTL.ShadowText = Color.Blue
        GridDTL.Refresh()
        Me.Refresh()
    End Sub

    Private Sub GridDTL_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles GridDTL.KeyDownEvent
        Try
            Dim VarMfgCode As Object = Nothing
            Dim VarTypeCode As Object = Nothing
            Dim intRowNo As Integer
            Dim varValue As Object = Nothing
            If Me.CmdEdit.Enabled = True Then
                Me.CmdEdit.Enabled = False
                If e.keyCode = 38 Then
                    Me.GridDTL1.MaxRows = 0
                    Me.GridDTL.GetText(ENUMGRIDDTL.SUBDEPDESC, Me.GridDTL.ActiveRow, varValue)
                    LblServicesInDept.Text = "Services In Sub-Department [ " + varValue + " ]"
                    VarMfgCode = Me.CmbManufacturer.SelectedValue
                    intRowNo = IIf(GridDTL.ActiveRow = 1, 1, GridDTL.ActiveRow - 1)
                    Me.GridDTL.GetText(ENUMGRIDDTL.SUBDEPCODE, intRowNo, VarTypeCode)
                    GetData(VarMfgCode.ToString, VarTypeCode.ToString)
                ElseIf e.keyCode = 40 Then
                    Me.GridDTL1.MaxRows = 0
                    Me.GridDTL.GetText(ENUMGRIDDTL.SUBDEPDESC, Me.GridDTL.ActiveRow, varValue)
                    LblServicesInDept.Text = "Services In Sub-Department [ " + varValue + " ]"
                    VarMfgCode = Me.CmbManufacturer.SelectedValue
                    intRowNo = IIf(GridDTL.ActiveRow = GridDTL.MaxRows, GridDTL.MaxRows, GridDTL.ActiveRow + 1)
                    Me.GridDTL.GetText(ENUMGRIDDTL.SUBDEPCODE, intRowNo, VarTypeCode)
                    GetData(VarMfgCode.ToString, VarTypeCode.ToString)
                End If
                Me.CmdEdit.Enabled = True
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally

        End Try
    End Sub

    Private Sub GridDTL_KeyUpEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyUpEvent) Handles GridDTL.KeyUpEvent
        Try
            If Me.CmdEdit.Enabled = True Then
                Dim VarMfgCode As Object = Nothing
                Dim VarTypeCode As Object = Nothing
                Dim varValue As Object = Nothing
                Me.CmdEdit.Enabled = False
                Me.GridDTL1.MaxRows = 0
                Me.GridDTL.GetText(ENUMGRIDDTL.SUBDEPDESC, Me.GridDTL.ActiveRow, varValue)
                LblServicesInDept.Text = "Services In Sub-Department [ " + varValue + " ]"
                VarMfgCode = Me.CmbManufacturer.SelectedValue
                Me.GridDTL.GetText(ENUMGRIDDTL.SUBDEPCODE, Me.GridDTL.ActiveRow, VarTypeCode)
                GetData(VarMfgCode.ToString, VarTypeCode.ToString)
                Me.CmdEdit.Enabled = True
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally

        End Try
    End Sub

    Private Sub GridDTL_MouseUpEvent(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_MouseUpEvent) Handles GridDTL.MouseUpEvent
        Try
            If Me.CmdEdit.Enabled = True Then
                Dim VarMfgCode As Object = Nothing
                Dim VarTypeCode As Object = Nothing
                Dim varValue As Object = Nothing
                Me.CmdEdit.Enabled = False
                Me.GridDTL1.MaxRows = 0
                Me.GridDTL.GetText(ENUMGRIDDTL.SUBDEPDESC, Me.GridDTL.ActiveRow, varValue)
                LblServicesInDept.Text = "Services In Sub-Department [ " + varValue + " ]"
                VarMfgCode = Me.CmbManufacturer.SelectedValue
                Me.GridDTL.GetText(ENUMGRIDDTL.SUBDEPCODE, Me.GridDTL.ActiveRow, VarTypeCode)
                GetData(VarMfgCode.ToString, VarTypeCode.ToString)
                Me.CmdEdit.Enabled = True
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally

        End Try
    End Sub
    Private Sub CmbManufacturer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbManufacturer.SelectedIndexChanged
        If IsNothing(Me.CmbManufacturer) = False And BLNFILLCOMBO = False Then
            If Me.CmbManufacturer.Items.Count > 0 Then
                Me.GridDTL.MaxRows = 0
                GETCOMBODATA()
                Dim VarMfgCode As Object = Nothing
                Dim VarTypeCode As Object = Nothing
                Me.GridDTL1.MaxRows = 0
                VarMfgCode = Me.CmbManufacturer.SelectedValue
                Me.GridDTL.GetText(ENUMGRIDDTL.SUBDEPCODE, Me.GridDTL.ActiveRow, VarTypeCode)
                GetData(VarMfgCode.ToString, VarTypeCode.ToString)
            End If
        End If
    End Sub
    Private Sub Services_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        Try
            If e.KeyChar = "'" Then e.Handled = True
            If e.KeyChar = Chr(Keys.Escape) Then
                Me.CmdClose_Click(sender, New System.EventArgs())
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally

        End Try
    End Sub

    Private Sub Services_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try
            GridDTL.MaxRows = 0
            GridDTL1.MaxRows = 0
            FillCombo()
            Me.KeyPreview = True
            CmdCancel_Click(sender, e)
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally

        End Try
    End Sub

    Private Sub GridDTL_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDTL.LostFocus
        Try
            GridDTL.Refresh()
            Me.Refresh()
            GridDTL.ShadowText = Color.Black
            GridDTL.Refresh()
            Me.Refresh()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally

        End Try
    End Sub

    Private Sub GridDTL1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDTL1.LostFocus
        
    End Sub

    Private Sub GridDTL1_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles GridDTL1.Advance

    End Sub

    Private Sub GridDTL1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDTL1.Leave
        Try
            GridDTL1.Refresh()
            Me.Refresh()
            GridDTL1.ShadowText = Color.Black
            GridDTL1.Refresh()
            Me.Refresh()
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally

        End Try
    End Sub

    Private Sub GridDTL1_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles GridDTL1.KeyDownEvent
        Try
            If e.keyCode = Keys.Tab Then
                If Me.CmdEdit.Enabled = True Then Me.CmdEdit.Focus() Else CmdSave.Focus()
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally

        End Try
    End Sub
End Class