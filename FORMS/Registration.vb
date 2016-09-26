Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Windows.Forms
Public Class Registration
    Dim InsertFlag As Integer
    Dim EditFlag As Integer
    Public Sub Clear()
        txtpID.Text = String.Empty
        txtregDate.Text = String.Empty
        optTitleMr.Checked = True
        txtPname.Text = String.Empty
        TxtYears.Text = String.Empty
        OptSexM.Checked = True
        txtFname.Text = String.Empty
        txtRef.Text = String.Empty
        Me.txtPaddress.Text = String.Empty
        MDYValue.Text = "Years"
        CmdMakeBill.Enabled = False
    End Sub
    Public Sub ReadOnlyTrueFalse(ByVal bval As Boolean)
        txtpID.BackColor = Color.White
        txtregDate.BackColor = Color.White
        txtPname.BackColor = Color.White
        TxtYears.BackColor = Color.White
        txtFname.BackColor = Color.White
        txtRef.BackColor = Color.White
        txtPaddress.BackColor = Color.White

        txtpID.ReadOnly = True
        txtPname.ReadOnly = bval
        TxtYears.ReadOnly = bval
        txtFname.ReadOnly = bval
        txtRef.ReadOnly = bval
        txtPaddress.ReadOnly = bval

    End Sub

    Private Sub Registration_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Comadd_Click(sender, e)
        optTitleMr.Focus()
    End Sub

    Private Sub Registration_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = "'" Then e.Handled = True
        If e.KeyChar = Chr(Keys.Escape) Then
            Me.CmdClose_Click(sender, New System.EventArgs())
        End If

        
        If Asc(e.KeyChar) = Keys.Enter Then
            SendKeys.Send(Chr(Keys.Tab))
        End If
    End Sub

    Private Sub Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        GroupMain.Enabled = False
        CmdNew.Enabled = True
        CmdNew.Visible = True
        CmdSave.Enabled = False
        CmdSave.Visible = False
        CmdEdit.Enabled = False
        CmdDelete.Enabled = False
        CmdCancel.Enabled = False
        ReadOnlyTrueFalse(True)
       
    End Sub

    Private Sub Comadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNew.Click
        InsertFlag = 1
        EditFlag = 0
        txtpID.Enabled = True
        Clear()
        GroupMain.Enabled = True
        OptSexM.Checked = True
        optTitleMr.Focus()
        CmdNew.Enabled = False
        CmdNew.Visible = False
        CmdSave.Enabled = True
        CmdSave.Visible = True
        CmdEdit.Enabled = False
        CmdDelete.Enabled = False
        CmdCancel.Enabled = True
        ReadOnlyTrueFalse(False)
        CmdSearch.Enabled = False
        CmdMakeBill.Enabled = False
        optTitleMr.Focus()
    End Sub
    Private Sub CmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSave.Click
        Dim StrSql As String = String.Empty
        Dim Con As New Odbc.OdbcConnection
        Dim Cmd As New Odbc.OdbcCommand
        Dim Obj As Object = Nothing
        Dim StrId As String = String.Empty
        Dim STRTITLE As String = String.Empty
        Dim STRSEX As String = String.Empty
        Dim Trans As System.Data.Odbc.OdbcTransaction
        Dim IsTrans As Boolean = False


        If txtPname.Text.Trim = String.Empty Then
            MsgBox("Please Enter Patient Name.", MsgBoxStyle.Information)
            Me.txtPname.Focus()
            Exit Sub
        ElseIf Val(TxtYears.Text) = 0 Or IsNumeric(TxtYears.Text) = False Then
            MsgBox("Please Enter Patient Age.", MsgBoxStyle.Information)
            Me.TxtYears.Focus()
            Exit Sub
        End If

        If optTitleMr.Checked = True Then
            STRTITLE = "Mr."
        ElseIf optTitleMrs.Checked = True Then
            STRTITLE = "Mrs."
        ElseIf optTitleMiss.Checked = True Then
            STRTITLE = "Miss"
        ElseIf optTitleMaster.Checked = True Then
            STRTITLE = "Master."
        ElseIf optTitleBeby.Checked = True Then
            STRTITLE = "Beby"
        End If

        If Me.OptSexF.Checked = True Then
            STRSEX = "F"
        Else
            STRSEX = "M"
        End If

        Try
            Con = GetAccesscon()
            
            Cmd.CommandType = CommandType.Text

            Cmd.Connection = Con
            Trans = Con.BeginTransaction
            Cmd.Transaction = Trans
            IsTrans = True

            If InsertFlag = 1 Then
                StrSql = "Select IIF(ISNULL(MAX(VAL(MID(patientid,9,7))))=TRUE,1, MAX(VAL( MID(patientid,9,7)) )+1) as Mxid from patient WHERE MID(patientid,3,2)='" + txtregDate.Value.ToString("yy") + "'"
                Cmd.CommandText = StrSql
                Obj = Cmd.ExecuteScalar()
                StrId = Val(Obj.ToString()).ToString("0000000")
                StrId = "P-" + txtregDate.Value.ToString("yy") + txtregDate.Value.ToString("MM") + txtregDate.Value.ToString("dd") + StrId

                StrSql = "INSERT INTO PATIENT(PatientID,PatientName,Title,Name,AgeYears,AgeValue,Age,Sex,Fname,Address,RDoc,RegisterDate,USERCODE)"
                StrSql = StrSql + "SELECT '" + StrId + "','" + STRTITLE + " " + Me.txtPname.Text.Trim + "','" + STRTITLE + "','" + Me.txtPname.Text.Trim + "'," + Me.TxtYears.Text.Trim + ",'" + Me.MDYValue.Text + "','" + Me.TxtYears.Text.Trim + " " + Me.MDYValue.Text + "','" + STRSEX + "','" + txtFname.Text.Trim + "','" + Me.txtPaddress.Text.Trim + "','" + Me.txtRef.Text.Trim + "','" + txtregDate.Value + "','" + UserCode + "'"
                Cmd.CommandText = StrSql
                Cmd.ExecuteNonQuery()
                Trans.Commit()
                IsTrans = False
                getdata(StrId)
            ElseIf EditFlag = 1 Then
                StrSql = "Update  Patient Set PatientName='" + STRTITLE + " " + Me.txtPname.Text.Trim + "',"
                StrSql = StrSql + "Title='" + STRTITLE + "',"
                StrSql = StrSql + "Name='" + Me.txtPname.Text.Trim + "',"
                StrSql = StrSql + "AgeYears=" + Me.TxtYears.Text.Trim + ","
                StrSql = StrSql + "AgeValue='" + Me.MDYValue.Text + "',"
                StrSql = StrSql + "Age=" + Me.TxtYears.Text.Trim + ","
                StrSql = StrSql + "Sex='" + STRSEX + "',"
                StrSql = StrSql + "Fname='" + txtFname.Text.Trim + "',"
                StrSql = StrSql + "Address='" + Me.txtPaddress.Text.Trim + "',"
                StrSql = StrSql + "RDoc='" + Me.txtRef.Text.Trim + "',"
                StrSql = StrSql + "RegisterDate='" + txtregDate.Value + "',USERCODE='" + UserCode + "'"
                StrSql = StrSql + "Where PatientID='" + Me.txtpID.Text.Trim + "'"
                Cmd.CommandText = StrSql
                Cmd.ExecuteNonQuery()
                Trans.Commit()
                IsTrans = False
                getdata(Me.txtpID.Text.Trim)
            End If
          
            'MsgBox("Saved Successfully.", MsgBoxStyle.Information)
            CmdMakeBill_Click(sender, e)
            InsertFlag = 0
            EditFlag = 0
            GroupMain.Enabled = False
            CmdNew.Enabled = True
            CmdNew.Visible = True
            CmdSave.Enabled = False
            CmdSave.Visible = False
            CmdCancel.Enabled = False
            ReadOnlyTrueFalse(True)
            CmdSearch.Enabled = True
            Comadd_Click(sender, e)
        Catch EX As Exception
            If IsTrans = True Then Trans.Rollback()
            MsgBox(EX.Message, MsgBoxStyle.Critical)
        Finally
            Con.Dispose()
            Cmd.Dispose()
            Obj = Nothing
            Trans.Dispose()
        End Try

     
    End Sub

    Private Sub CmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdEdit.Click
        InsertFlag = 0
        EditFlag = 1
        GroupMain.Enabled = True
        CmdNew.Enabled = False
        CmdNew.Visible = False
        CmdSave.Enabled = True
        CmdSave.Visible = True
        CmdEdit.Enabled = False
        CmdDelete.Enabled = False
        CmdCancel.Enabled = True
        ReadOnlyTrueFalse(False)
        CmdSearch.Enabled = False
        CmdMakeBill.Enabled = False
        optTitleMr.Focus()
    End Sub
    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        InsertFlag = 0
        EditFlag = 1
        Clear()
        GroupMain.Enabled = False
        CmdNew.Enabled = True
        CmdNew.Visible = True
        CmdSave.Enabled = False
        CmdSave.Visible = False
        CmdEdit.Enabled = False
        CmdDelete.Enabled = False
        CmdCancel.Enabled = False
        ReadOnlyTrueFalse(True)
        CmdSearch.Enabled = True
        CmdMakeBill.Enabled = False
        CmdSearch.Focus()
    End Sub
    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub TxtYears_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtYears.GotFocus
        Me.TxtYears.BackColor = TextBoxGotFocusBackColor
    End Sub

    Private Sub TxtYears_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtYears.KeyPress
        If InStr("0123456789" + vbBack, e.KeyChar) = 0 Then e.Handled = True
    End Sub

    Private Sub getdata(ByVal strPatientId As String)
        Dim MySqlCon As New Odbc.OdbcConnection
        Dim MySqlDataRd As Odbc.OdbcDataReader
        Dim MySqlCmd As New Odbc.OdbcCommand
        MySqlCon = GetAccesscon()
        MySqlCmd.Connection = MySqlCon
        Dim STRTITLE As String = String.Empty
        Try

            MySqlCmd.CommandText = "Select PatientID,PatientName,Title,Name,AgeYears,AgeValue,Age,Sex,Fname,Address,RDoc,RegisterDate From Patient Where PatientID='" + strPatientId.Trim + "'"
            MySqlDataRd = MySqlCmd.ExecuteReader()
            If (MySqlDataRd.HasRows = True) Then
                While (MySqlDataRd.Read)
                    Me.txtpID.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("PatientID")).ToString()
                    STRTITLE = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Title")).ToString()
                    If STRTITLE = "Mr." Then
                        Me.optTitleMr.Checked = True
                    ElseIf STRTITLE = "Mrs." Then
                        Me.optTitleMrs.Checked = True
                    ElseIf STRTITLE = "Miss" Then
                        Me.optTitleMiss.Checked = True
                    ElseIf STRTITLE = "Master." Then
                        Me.optTitleMaster.Checked = True
                    ElseIf STRTITLE = "Beby" Then
                        Me.optTitleBeby.Checked = True
                    End If
                    If MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Sex")).ToString() = "M" Then
                        Me.OptSexM.Checked = True
                    Else
                        Me.OptSexF.Checked = True
                    End If
                    Me.txtregDate.Value = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("RegisterDate")).ToString()
                    Me.txtPname.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Name")).ToString()
                    TxtYears.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("AgeYears")).ToString()
                    MDYValue.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("AgeValue")).ToString()
                    txtFname.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Fname")).ToString()
                    txtPaddress.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Address")).ToString()
                    Me.txtRef.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("RDoc")).ToString()
                    CmdEdit.Enabled = True
                    CmdDelete.Enabled = True
                    CmdMakeBill.Enabled = True
                    CmdNew.Focus()
                End While
            End If


        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally
            MySqlCon.Dispose()
            MySqlCmd.Dispose()
        End Try

    End Sub

    Private Sub CmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSearch.Click
        Try
            Dim frm As New Help
            frm.ShowDialog()
            If frm.strSelectedValue.Trim <> String.Empty Then
                getdata(frm.strSelectedValue)
            End If
            frm.Dispose()
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try
    End Sub

    Private Sub CmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdDelete.Click
        If MsgBox("Are You Sure To Delete?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim StrSql As String = String.Empty
            Dim Con As New Odbc.OdbcConnection
            Dim Cmd As New Odbc.OdbcCommand
            Dim obj As Object = Nothing
            Dim Trans As System.Data.Odbc.OdbcTransaction
            Dim IsTrans As Boolean = False

            Try
                Cmd.CommandType = CommandType.Text
                Con = GetAccesscon()
                Cmd.Connection = Con
                Trans = Con.BeginTransaction
                Cmd.Transaction = Trans
                IsTrans = True

                StrSql = "SELECT count(*) As  cnt FROM  patientbilling where PatientID='" + Me.txtpID.Text.ToString.Trim + "';"
                Cmd.CommandText = StrSql
                obj = Cmd.ExecuteScalar()
                If obj.ToString <> "0" Then
                    Trans.Rollback()
                    IsTrans = False
                    MsgBox("This Patient Has Been Involved In Billing.", MsgBoxStyle.Information)
                    Exit Sub
                End If

                StrSql = "DELETE FROM Patient WHERE PatientID='" + Me.txtpID.Text.Trim + "'"
                Cmd.CommandText = StrSql
                Cmd.ExecuteNonQuery()
                Me.CmdCancel_Click(sender, e)
                Trans.Commit()
                IsTrans = False
                MsgBox("Deleted Successully.", MsgBoxStyle.Information)
            Catch EX As Exception
                
                MsgBox(EX.Message)
            Finally
                Cmd.Dispose()
                Con.Dispose()
                Cmd.Dispose()
                If IsTrans = True Then Trans.Rollback()
                Trans.Dispose()
            End Try

        End If
    End Sub

    Private Sub CmdMakeBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdMakeBill.Click

        If txtpID.Text.Trim() = String.Empty Then
            MsgBox("PatientID could not be blank.")
            Exit Sub
        End If

        Dim frm As New PatinetBilling
        frm.CmdNew_Click(sender, New System.EventArgs)
        frm.getdata(1, txtpID.Text)
        frm.isCalledFromPatient = True
        frm.GridDTL.Row = frm.GridDTL.MaxRows
        frm.GridDTL.Col = 8 ' ENUMGRIDDTL.UserDefinedServiceCode
        frm.GridDTL.Action = FPSpread.ActionConstants.ActionActiveCell
        frm.GridDTL.Focus()
        frm.ShowDialog()
        frm.isCalledFromPatient = False
    End Sub

    Private Sub txtregDate_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtregDate.GotFocus

    End Sub

    Private Sub txtregDate_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtregDate.ValueChanged

    End Sub

    Private Sub txtPname_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPname.GotFocus
        Me.txtPname.BackColor = TextBoxGotFocusBackColor
    End Sub

    Private Sub txtPname_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPname.LostFocus
        Me.txtPname.BackColor = TextBoxLostFocusBackColor
    End Sub

    Private Sub txtPname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPname.TextChanged

    End Sub

    Private Sub TxtYears_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TxtYears.LostFocus
        Me.TxtYears.BackColor = TextBoxLostFocusBackColor
    End Sub

    Private Sub TxtYears_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtYears.TextChanged

    End Sub

    Private Sub MDYValue_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MDYValue.SelectedIndexChanged

    End Sub

    Private Sub txtFname_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFname.GotFocus
        Me.txtFname.BackColor = TextBoxGotFocusBackColor
    End Sub

    Private Sub txtFname_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtFname.LostFocus
        Me.txtFname.BackColor = TextBoxLostFocusBackColor
    End Sub

    Private Sub txtFname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFname.TextChanged

    End Sub

    Private Sub txtPaddress_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPaddress.GotFocus
        Me.txtPaddress.BackColor = TextBoxGotFocusBackColor
    End Sub

    Private Sub txtPaddress_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPaddress.LostFocus
        Me.txtPaddress.BackColor = TextBoxLostFocusBackColor
    End Sub

    Private Sub txtPaddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPaddress.TextChanged

    End Sub

    Private Sub txtRef_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRef.GotFocus
        Me.txtRef.BackColor = TextBoxGotFocusBackColor
    End Sub

    Private Sub txtRef_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRef.LostFocus
        Me.txtRef.BackColor = TextBoxLostFocusBackColor
    End Sub

    Private Sub txtRef_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtRef.TextChanged

    End Sub
End Class