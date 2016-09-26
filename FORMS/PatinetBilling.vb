Imports System.Data
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.IO

Public Class PatinetBilling


    Enum ENUMGRIDDTL
        DEPTCODE = 1
        DEPTNAME = 2
        DEPHELP = 3
        SUBDEPTCODE = 4
        SUBDEPTNAME = 5
        SUBDEPHELP = 6
        SERVICECODE = 7
        UserDefinedServiceCode = 8
        SERVICENAME = 9
        SERVICEHELP = 10
        REMARKS = 11
        CHARGES = 12
    End Enum
    Dim BlnFlg As Boolean = False
    Public InsertFlag As Integer
    Public CancelFlag As Integer
    Public amount As Decimal = 0
    Public AmountInWord As String = String.Empty
    Public isDiscountAllowed As Boolean = False, isCancelAllowed As Boolean = False
    Public isCalledFromPatient As Boolean = False
    Dim ServiceCodes As String = String.Empty
    Public Sub Clear()
        txtpID.Text = String.Empty
        txtBillingDate.Text = String.Empty
        txtName.Text = String.Empty
        txtSex.Text = String.Empty
        txtAge.Text = String.Empty
        txtTotalAmount.Text = 0
        txtNetAmount.Text = 0
        txtDiscountAmount.Text = 0
        Me.TctReceiptNo.Text = String.Empty
        LbLBillCancelled.Visible = False

    End Sub
    Public Sub ReadOnlyTrueFalse(ByVal bval As Boolean)
        txtpID.BackColor = Color.White
        txtBillingDate.BackColor = Color.White
        txtName.BackColor = Color.White
        txtAge.BackColor = Color.White
        txtSex.BackColor = Color.White

        txtpID.ReadOnly = bval
        txtName.ReadOnly = bval
        txtAge.ReadOnly = bval
        txtSex.ReadOnly = bval



    End Sub


    Private Sub AddBlankRecordInGrid()
        GridDTL.EditModePermanent = False
        Me.GridDTL.MaxRows = Me.GridDTL.MaxRows + 1
        Me.GridDTL.Row = Me.GridDTL.MaxRows
        Me.GridDTL.Col = ENUMGRIDDTL.DEPTCODE : Me.GridDTL.ColHidden = True
        Me.GridDTL.Col = ENUMGRIDDTL.DEPTNAME : Me.GridDTL.ColHidden = False : Me.GridDTL.TypeEditLen = 150 : Me.GridDTL.Lock = True
        Me.GridDTL.Col = ENUMGRIDDTL.DEPHELP : Me.GridDTL.ColHidden = False : Me.GridDTL.CellType = FPSpread.CellTypeConstants.CellTypeButton

        Me.GridDTL.Col = ENUMGRIDDTL.SUBDEPTCODE : Me.GridDTL.ColHidden = True
        Me.GridDTL.Col = ENUMGRIDDTL.SUBDEPTNAME : Me.GridDTL.ColHidden = False : Me.GridDTL.TypeEditLen = 150 : Me.GridDTL.Lock = True
        Me.GridDTL.Col = ENUMGRIDDTL.SUBDEPHELP : Me.GridDTL.ColHidden = False : Me.GridDTL.CellType = FPSpread.CellTypeConstants.CellTypeButton

        Me.GridDTL.Col = ENUMGRIDDTL.SERVICECODE : Me.GridDTL.ColHidden = True
        Me.GridDTL.Col = ENUMGRIDDTL.UserDefinedServiceCode : Me.GridDTL.ColHidden = False : Me.GridDTL.TypeEditLen = 6 : Me.GridDTL.Lock = False

        Me.GridDTL.Col = ENUMGRIDDTL.SERVICENAME : Me.GridDTL.ColHidden = False : Me.GridDTL.TypeEditLen = 150 : Me.GridDTL.Lock = True
        Me.GridDTL.Col = ENUMGRIDDTL.SERVICEHELP : Me.GridDTL.ColHidden = True : Me.GridDTL.CellType = FPSpread.CellTypeConstants.CellTypeButton

        Me.GridDTL.Col = ENUMGRIDDTL.REMARKS : Me.GridDTL.ColHidden = False : Me.GridDTL.TypeEditLen = 150 : Me.GridDTL.Lock = False

        Me.GridDTL.Col = ENUMGRIDDTL.CHARGES : Me.GridDTL.ColHidden = False : Me.GridDTL.CellType = FPSpread.CellTypeConstants.CellTypeFloat : Me.GridDTL.Lock = False

        Me.GridDTL.Col = ENUMGRIDDTL.DEPHELP : Me.GridDTL.ColHidden = True
        Me.GridDTL.Col = ENUMGRIDDTL.SUBDEPHELP : Me.GridDTL.ColHidden = True



        GridDTL.Row = GridDTL.MaxRows
        GridDTL.Col = 7 ' ENUMGRIDDTL.UserDefinedServiceCode
        GridDTL.Action = FPSpread.ActionConstants.ActionActiveCell
        GridDTL.Focus()
    End Sub

    Private Sub DeleteRecordInGrid()

        Dim StrSql As String = String.Empty
        Dim Con As New Odbc.OdbcConnection
        Dim Cmd As New Odbc.OdbcCommand
        Dim obj As Object = Nothing
        Dim VarTypeCode As Object = Nothing

        Try
            If GridDTL.MaxRows > 0 Then
                Cmd.CommandType = CommandType.Text
                Con = GetAccesscon()
                Cmd.Connection = Con
                ' Me.GridDTL.GetText(ENUMGRIDDTL.MODELCODE, Me.GridDTL.ActiveRow, VarTypeCode)

                'StrSql = "SELECT count(*) cnt FROM equipmentvsengine_dtl e where Enginecode='" + VarTypeCode.ToString.Trim + "';"
                'Cmd.CommandText = StrSql
                'obj = Cmd.ExecuteScalar()
                'If obj.ToString <> "0" Then
                '    MsgBox("This Engine Model Has Been Involved In Engine/Equipment Relationship.", MsgBoxStyle.Information)
                '    Exit Sub
                'End If
                Me.GridDTL.Row = Me.GridDTL.ActiveRow
                Me.GridDTL.Action = 5
                GridDTL.MaxRows = GridDTL.MaxRows - 1
                If GridDTL.MaxRows = 0 Then
                    AddBlankRecordInGrid()
                    'GridDTL.Row = GridDTL.MaxRows
                    'GridDTL.Col = 7 ' ENUMGRIDDTL.UserDefinedServiceCode
                    'GridDTL.Action = FPSpread.ActionConstants.ActionActiveCell
                    'GridDTL.Focus()
                End If

                CalculateAmount()
            Else
                AddBlankRecordInGrid()
            End If
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Information)
        Finally
            Cmd.Dispose()
            Con.Dispose()
            Cmd.Dispose()
        End Try

    End Sub

    Private Sub PatinetBilling_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If isCalledFromPatient = True Then GridDTL.Focus()
    End Sub

    Private Sub PatinetBilling_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        If Me.GRPPOPUPHELP.Visible = True Then Me.GRPPOPUPHELP.Visible = False
    End Sub

    Private Sub PatinetBilling_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = "'" Then e.Handled = True
        If e.KeyChar = Chr(Keys.Escape) Then
            If Me.GRPPOPUPHELP.Visible = True Then
                Me.GRPPOPUPHELP.Visible = False
            Else
                Me.CmdClose_Click(sender, New System.EventArgs())
            End If

        End If
    End Sub



    Private Sub Billing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If isCalledFromPatient = False Then
            Me.KeyPreview = True
            CmdNew.Enabled = True
            CmdNew.Visible = True
            CmdSave.Enabled = False
            CmdSave.Visible = False

            CmdCancel.Enabled = False
            btnPreview.Enabled = False
            btnPrint.Enabled = False
            btnCancelBill.Enabled = False
            GridDTL.MaxRows = 0
            AddBlankRecordInGrid()
            ReadOnlyTrueFalse(True)
            txtDiscountAmount.ReadOnly = True
            EnableDisable(False)

        End If
        Me.KeyPreview = True
        GridPopUpService.BackColor = Color.Lavender
        GRPPOPUPHELP.Left = 400
        GRPPOPUPHELP.Top = 135
        ChPrintReceipt.Checked = True
        LbLBillCancelled.Visible = False
        GetConfig()


    End Sub

    Private Sub GridDTL_ButtonClicked(ByVal sender As Object, ByVal e As AxFPSpread._DSpreadEvents_ButtonClickedEvent) Handles GridDTL.ButtonClicked
        If GridDTL.ActiveCol = ENUMGRIDDTL.DEPHELP Then
            Search(2)
        End If
        If GridDTL.ActiveCol = ENUMGRIDDTL.SUBDEPHELP Then
            Search(3)
        End If
        If GridDTL.ActiveCol = ENUMGRIDDTL.SERVICEHELP Then
            Search(4)
        End If
    End Sub

    Private Sub GridDTL_KeyPressEvent(ByVal sender As System.Object, ByVal e As AxFPSpread._DSpreadEvents_KeyPressEvent) Handles GridDTL.KeyPressEvent

        If e.keyAscii = 39 Then
            e.keyAscii = 0
            Exit Sub
        End If
        Try
            Dim VarDesc As Object
            Dim VarAmount As Object
            If Me.CmdSave.Enabled = True Then
                If e.keyAscii = 13 And GridDTL.ActiveRow = GridDTL.MaxRows And GridDTL.ActiveCol = ENUMGRIDDTL.CHARGES Then
                    VarDesc = Nothing
                    VarAmount = Nothing
                    GridDTL.GetText(ENUMGRIDDTL.SERVICECODE, GridDTL.ActiveRow, VarDesc)
                    GridDTL.GetText(ENUMGRIDDTL.CHARGES, GridDTL.ActiveRow, VarAmount)
                    If IsNothing(VarAmount) = True Then VarAmount = "0"

                    If VarDesc.ToString.Trim = String.Empty Then
                        MsgBox("Please Select A Service.", MsgBoxStyle.Information)
                        GridDTL.Row = GridDTL.ActiveRow
                        GridDTL.Col = ENUMGRIDDTL.SERVICECODE
                        GridDTL.Action = FPSpread.ActionConstants.ActionActiveCell
                        GridDTL.Focus()
                        Exit Sub
                    End If
                    If Val(VarAmount.ToString.Trim) = 0 Then
                        MsgBox("Please Enter Service Charge.", MsgBoxStyle.Information)
                        GridDTL.Row = GridDTL.ActiveRow
                        GridDTL.Col = ENUMGRIDDTL.CHARGES
                        GridDTL.Action = FPSpread.ActionConstants.ActionActiveCell
                        GridDTL.Focus()
                        Exit Sub
                    End If
                    AddBlankRecordInGrid()
                    'ElseIf e.keyAscii = 13 Then
                    '    GridDTL.Row = GridDTL.ActiveRow
                    '    GridDTL.Col = GridDTL.Col + 1
                    '    GridDTL.Action = FPSpread.ActionConstants.ActionActiveCell
                    '    GridDTL.Focus()
                End If

                If e.keyAscii = 14 Then
                    For IntCtr = 1 To Me.GridDTL.MaxRows
                        VarDesc = Nothing
                        VarAmount = Nothing
                        GridDTL.GetText(2, IntCtr, VarDesc)
                        GridDTL.GetText(ENUMGRIDDTL.CHARGES, GridDTL.ActiveRow, VarAmount)
                        If IsNothing(VarAmount) = True Then VarAmount = "0"

                        If VarDesc.ToString.Trim = String.Empty Then
                            MsgBox("Please Enter Service(s).", MsgBoxStyle.Information)
                            GridDTL.Row = IntCtr
                            GridDTL.Col = 1
                            GridDTL.Action = FPSpread.ActionConstants.ActionActiveCell
                            GridDTL.Focus()
                            Exit Sub
                        End If

                        If Val(VarAmount.ToString.Trim) = 0 Then
                            MsgBox("Please Enter Service Charge.", MsgBoxStyle.Information)
                            GridDTL.Row = GridDTL.ActiveRow
                            GridDTL.Col = ENUMGRIDDTL.CHARGES
                            GridDTL.Action = FPSpread.ActionConstants.ActionActiveCell
                            GridDTL.Focus()
                            Exit Sub
                        End If
                    Next
                    AddBlankRecordInGrid()
                End If

                If e.keyAscii = 4 Then
                    DeleteRecordInGrid()
                End If

            End If
        Catch EX As Exception
            MsgBox(EX.Message, MsgBoxStyle.Critical)
        End Try
    End Sub



    Public Sub getdata(ByVal ModeHelp As Short, ByVal strPatientId As String)
        Dim MySqlCon As New Odbc.OdbcConnection
        Dim MySqlDataRd As Odbc.OdbcDataReader
        Dim MySqlCmd As New Odbc.OdbcCommand
        MySqlCon = GetAccesscon()
        MySqlCmd.Connection = MySqlCon
        Dim STRTITLE As String = String.Empty
        Dim VarStr As Object = Nothing
        Dim VarStr1 As Object = Nothing
        Try

            Dim strSQL As String = String.Empty
            If ModeHelp = 1 Then
                strSQL = "SELECT PatientID,Name,Age,IIF(Sex='M','Male','Female') as Sex1 from Patient Where  PatientID = '" + strPatientId + "'"
                MySqlCmd.CommandText = strSQL
                MySqlDataRd = MySqlCmd.ExecuteReader()
                If (MySqlDataRd.HasRows = True) Then
                    txtpID.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("PatientID")).ToString()
                    txtName.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Name")).ToString()
                    txtAge.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Age")).ToString()
                    txtSex.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Sex1")).ToString()
                End If

            ElseIf ModeHelp = 2 Then
                strSQL = "SELECT DepCode,DepDesc from Department Where DepCode = '" + strPatientId + "'"
                MySqlCmd.CommandText = strSQL
                MySqlDataRd = MySqlCmd.ExecuteReader()
                If (MySqlDataRd.HasRows = True) Then
                    While (MySqlDataRd.Read)
                        'AddBlankRecordInGrid()
                        Me.GridDTL.SetText(ENUMGRIDDTL.DEPTCODE, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("DEPCODE")).ToString())
                        Me.GridDTL.SetText(ENUMGRIDDTL.DEPTNAME, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("DEPDESC")).ToString())


                        Me.GridDTL.SetText(ENUMGRIDDTL.SUBDEPTCODE, Me.GridDTL.MaxRows, String.Empty)
                        Me.GridDTL.SetText(ENUMGRIDDTL.SUBDEPTNAME, Me.GridDTL.MaxRows, String.Empty)
                        Me.GridDTL.SetText(ENUMGRIDDTL.SERVICECODE, Me.GridDTL.MaxRows, String.Empty)
                        Me.GridDTL.SetText(ENUMGRIDDTL.SERVICENAME, Me.GridDTL.MaxRows, String.Empty)
                        Me.GridDTL.SetText(ENUMGRIDDTL.CHARGES, Me.GridDTL.MaxRows, "0")

                    End While
                End If

            ElseIf ModeHelp = 3 Then
                VarStr = Nothing
                Me.GridDTL.GetText(ENUMGRIDDTL.DEPTCODE, Me.GridDTL.MaxRows, VarStr)
                If IsNothing(VarStr) = True Then VarStr = String.Empty
                If VarStr.ToString.Trim <> String.Empty Then
                    strSQL = "SELECT SubDepartment.SUBDEPCODE, SubDepartment.SUBDEPDESC, DEPARTMENT.DEPCODE, DEPARTMENT.DEPDESC FROM SubDepartment INNER JOIN DEPARTMENT ON SubDepartment.DEPCODE = DEPARTMENT.DEPCODE Where  SubDepCode = '" + strPatientId + "' and SubDepartment.DEPCODE='" + VarStr.ToString + "'"
                Else
                    strSQL = "SELECT SubDepartment.SUBDEPCODE, SubDepartment.SUBDEPDESC, DEPARTMENT.DEPCODE, DEPARTMENT.DEPDESC FROM SubDepartment INNER JOIN DEPARTMENT ON SubDepartment.DEPCODE = DEPARTMENT.DEPCODE Where  SubDepCode = '" + strPatientId + "'"
                End If
                MySqlCmd.CommandText = strSQL
                MySqlDataRd = MySqlCmd.ExecuteReader()
                If (MySqlDataRd.HasRows = True) Then

                    While (MySqlDataRd.Read)
                        Me.GridDTL.SetText(ENUMGRIDDTL.SUBDEPTCODE, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("SUBDEPCODE")).ToString())
                        Me.GridDTL.SetText(ENUMGRIDDTL.SUBDEPTNAME, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("SUBDEPDESC")).ToString())
                        Me.GridDTL.SetText(ENUMGRIDDTL.DEPTCODE, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("DEPCODE")).ToString())
                        Me.GridDTL.SetText(ENUMGRIDDTL.DEPTNAME, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("DEPDESC")).ToString())
                        Me.GridDTL.SetText(ENUMGRIDDTL.SERVICECODE, Me.GridDTL.MaxRows, String.Empty)
                        Me.GridDTL.SetText(ENUMGRIDDTL.SERVICENAME, Me.GridDTL.MaxRows, String.Empty)
                        Me.GridDTL.SetText(ENUMGRIDDTL.CHARGES, Me.GridDTL.MaxRows, "0")
                    End While
                End If
            ElseIf ModeHelp = 4 Then
                'VarStr = Nothing
                'Me.GridDTL.GetText(ENUMGRIDDTL.SUBDEPTCODE, Me.GridDTL.MaxRows, VarStr)
                'If IsNothing(VarStr) = True Then VarStr = String.Empty
                'If VarStr.ToString.Trim <> String.Empty Then
                '    strSQL = "SELECT SERVICES.SERVICECODE, SERVICES.SERVICEDESC, SUBDEPARTMENT.SUBDEPCODE, SUBDEPARTMENT.SUBDEPDESC, DEPARTMENT.DEPCODE, DEPARTMENT.DEPDESC,CHARGE FROM (SERVICES INNER JOIN SUBDEPARTMENT ON (SERVICES.SUBDEPCODE = SUBDEPARTMENT.SUBDEPCODE) AND (SERVICES.DEPCODE = SUBDEPARTMENT.DEPCODE)) INNER JOIN DEPARTMENT ON SUBDEPARTMENT.DEPCODE = DEPARTMENT.DEPCODE Where ServiceCode = '" + strPatientId + "' And SUBDEPARTMENT.SUBDEPCODE='" + VarStr.ToString.Trim + "'"
                'Else
                strSQL = "SELECT SERVICES.SERVICECODE,SERVICES.UDSERVICECODE, SERVICES.SERVICEDESC, SUBDEPARTMENT.SUBDEPCODE, SUBDEPARTMENT.SUBDEPDESC, DEPARTMENT.DEPCODE, DEPARTMENT.DEPDESC,CHARGE FROM (SERVICES INNER JOIN SUBDEPARTMENT ON (SERVICES.SUBDEPCODE = SUBDEPARTMENT.SUBDEPCODE) AND (SERVICES.DEPCODE = SUBDEPARTMENT.DEPCODE)) INNER JOIN DEPARTMENT ON SUBDEPARTMENT.DEPCODE = DEPARTMENT.DEPCODE Where ServiceCode = '" + strPatientId + "'"
                'End If

                MySqlCmd.CommandText = strSQL
                MySqlDataRd = MySqlCmd.ExecuteReader()
                If (MySqlDataRd.HasRows = True) Then

                    While (MySqlDataRd.Read)
                        'AddBlankRecordInGrid()
                        Me.GridDTL.SetText(ENUMGRIDDTL.DEPTCODE, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("DEPCODE")).ToString())
                        Me.GridDTL.SetText(ENUMGRIDDTL.DEPTNAME, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("DEPDESC")).ToString())
                        Me.GridDTL.SetText(ENUMGRIDDTL.SUBDEPTCODE, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("SUBDEPCODE")).ToString())
                        Me.GridDTL.SetText(ENUMGRIDDTL.SUBDEPTNAME, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("SUBDEPDESC")).ToString())

                        Me.GridDTL.SetText(ENUMGRIDDTL.UserDefinedServiceCode, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("UDSERVICECODE")).ToString())
                        Me.GridDTL.SetText(ENUMGRIDDTL.SERVICECODE, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("SERVICECODE")).ToString())
                        Me.GridDTL.SetText(ENUMGRIDDTL.SERVICENAME, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("SERVICEDESC")).ToString())
                        Me.GridDTL.SetText(ENUMGRIDDTL.CHARGES, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Charge")).ToString())
                        If Val(MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Charge")).ToString()) = 0 Then
                            Me.GridDTL.Col = ENUMGRIDDTL.CHARGES
                            Me.GridDTL.Row = Me.GridDTL.MaxRows
                            Me.GridDTL.Lock = False
                        Else
                            Me.GridDTL.Col = ENUMGRIDDTL.CHARGES
                            Me.GridDTL.Row = Me.GridDTL.MaxRows
                            Me.GridDTL.Lock = True
                        End If

                        'amount += MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("CHARGE"))

                    End While
                    'txtTotalAmount.Text = amount.ToString()
                    'amount = amount - Int(IIf(txtDiscountAmount.Text.Trim() = "", 0, txtDiscountAmount.Text))
                    'txtNetAmount.Text = amount.ToString()
                    'lblAmountInWord.Text = BILLING.WORD_FIVE_DIGIT(amount)
                    CalculateAmount()
                    GridDTL.Row = GridDTL.ActiveRow
                    GridDTL.Col = ENUMGRIDDTL.CHARGES
                    GridDTL.Action = FPSpread.ActionConstants.ActionActiveCell
                    GridDTL.Focus()
                End If

            Else 'If ModeHelp = 5 Then
                'strSQL = "SELECT PatientID,Name,BillingID from Patient,PatientBilling Where Patient.PatientID=PatientBilling.PatientID AND (  Name  LIKE '" + Me.TXTSEARCH.Text.Trim + "%' or PatientID LIKE '" + Me.TXTSEARCH.Text.Trim + "%' or BillingID LIKE '" + Me.TXTSEARCH.Text.Trim + "%')"
                amount = 0
                Me.GridDTL.MaxRows = 0
                txtDiscountAmount.ReadOnly = True
                strSQL = "SELECT SERVICES.UDSERVICECODE,PatientBilling.BILLINGID,PatientBilling.BILLINGDate,PatientBilling.PatientID,DEPARTMENT.DEPCODE, DEPARTMENT.DEPDESC, " & _
                         " SUBDEPARTMENT.SUBDEPCODE, " & _
                         " SUBDEPARTMENT.SUBDEPDESC, " & _
                         " SERVICES.SERVICECODE, " & _
                         " SERVICES.SERVICEDESC,  " & _
                         " PatientBilling.CHARGE,IIF(ISNULL(Remarks)=TRUE,'',Remarks) AS Comments,AmountInWord,DISCOUNT,ISCANCELLED " & _
                         " FROM PatientBilling, " & _
                         " DEPARTMENT, " & _
                         " SERVICES, SUBDEPARTMENT " & _
                         " WHERE(PatientBilling.DEPCODE = DEPARTMENT.DEPCODE) AND PATIENTBILLING.SUBDEPCODE=SUBDEPARTMENT.SUBDEPCODE" & _
                         " AND PATIENTBILLING.SERVICECODE=SERVICES.SERVICECODE" & _
                         " AND PATIENTBILLING.BILLINGID='" & strPatientId & "';"
                MySqlCmd.CommandText = strSQL
                MySqlDataRd = MySqlCmd.ExecuteReader()
                If (MySqlDataRd.HasRows = True) Then
                    strPatientId = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("PatientID")).ToString()
                    txtBillingDate.Value = Convert.ToDateTime(MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("BILLINGDate")).ToString()).ToString("dd/MMM/yyyy")
                    Dim discount As Double
                    discount = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("discount"))
                    txtDiscountAmount.Text = discount
                    Me.TctReceiptNo.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("BILLINGID"))
                    While (MySqlDataRd.Read)
                        AddBlankRecordInGrid()
                        Me.GridDTL.SetText(ENUMGRIDDTL.DEPTCODE, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("DEPCODE")).ToString())
                        Me.GridDTL.SetText(ENUMGRIDDTL.DEPTNAME, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("DEPDESC")).ToString())

                        Me.GridDTL.SetText(ENUMGRIDDTL.SUBDEPTCODE, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("SUBDEPCODE")).ToString())
                        Me.GridDTL.SetText(ENUMGRIDDTL.SUBDEPTNAME, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("SUBDEPDESC")).ToString())

                        Me.GridDTL.SetText(ENUMGRIDDTL.UserDefinedServiceCode, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("UDSERVICECODE")).ToString())

                        Me.GridDTL.SetText(ENUMGRIDDTL.SERVICECODE, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("SERVICECODE")).ToString())
                        Me.GridDTL.SetText(ENUMGRIDDTL.SERVICENAME, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("SERVICEDESC")).ToString())

                        Me.GridDTL.SetText(ENUMGRIDDTL.REMARKS, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Comments")).ToString())

                        Me.GridDTL.SetText(ENUMGRIDDTL.CHARGES, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("CHARGE")).ToString())
                        amount += MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("CHARGE"))

                        btnPreview.Enabled = True
                        btnPrint.Enabled = True
                        If MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("ISCANCELLED")).ToString() = True Then
                            btnCancelBill.Enabled = False
                            LbLBillCancelled.Visible = True
                        Else
                            btnCancelBill.Enabled = True
                            LbLBillCancelled.Visible = False
                        End If
                    End While




                    txtTotalAmount.Text = amount.ToString()
                    amount = amount - discount
                    txtNetAmount.Text = amount.ToString()
                    lblAmountInWord.Text = BILLING.WORD_FIVE_DIGIT(amount)
                    MySqlDataRd.Close()
                    strSQL = "SELECT PatientID,Name,Age,IIF(Sex='M','Male','Female') as Sex1 from Patient Where  PatientID = '" + strPatientId + "'"
                    MySqlCmd.CommandText = strSQL
                    MySqlDataRd = MySqlCmd.ExecuteReader()
                    If (MySqlDataRd.HasRows = True) Then
                        txtpID.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("PatientID")).ToString()
                        txtName.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Name")).ToString()
                        txtAge.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Age")).ToString()
                        txtSex.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Sex1")).ToString()
                    End If

                End If

            End If

            'MySqlCmd.CommandText = strSQL  '"Select PatientID,PatientName,Title,Name,AgeYears,AgeValue,Age,Sex,Fname,Address,RDoc,RegisterDate From Patient Where PatientID='" + strPatientId.Trim + "'"
            'MySqlDataRd = MySqlCmd.ExecuteReader()
            'If (MySqlDataRd.HasRows = True) Then

            '    While (MySqlDataRd.Read)
            '        AddBlankRecordInGrid()
            '        Me.GridDTL.SetText(ENUMGRID.DEPCODE, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("DEPCODE")).ToString())
            '        Me.GridDTL.SetText(ENUMGRID.DEPDESC, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("DEPDESC")).ToString())

            '    End While

            '    While (MySqlDataRd.Read)
            '        Me.txtpID.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("PatientID")).ToString()
            '        STRTITLE = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Title")).ToString()
            '        If STRTITLE = "Mr." Then
            '            Me.optTitleMr.Checked = True
            '        ElseIf STRTITLE = "Mrs." Then
            '            Me.optTitleMrs.Checked = True
            '        ElseIf STRTITLE = "Miss" Then
            '            Me.optTitleMiss.Checked = True
            '        ElseIf STRTITLE = "Master." Then
            '            Me.optTitleMaster.Checked = True
            '        ElseIf STRTITLE = "Beby" Then
            '            Me.optTitleBeby.Checked = True
            '        End If
            '        If MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Sex")).ToString() = "M" Then
            '            Me.OptSexM.Checked = True
            '        Else
            '            Me.OptSexF.Checked = True
            '        End If
            '        Me.txtregDate.Value = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("RegisterDate")).ToString()
            '        Me.txtPname.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Name")).ToString()
            '        TxtYears.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("AgeYears")).ToString()
            '        MDYValue.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("AgeValue")).ToString()
            '        txtFname.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Fname")).ToString()
            '        txtPaddress.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Address")).ToString()
            '        Me.txtRef.Text = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("RDoc")).ToString()
            '        CmdEdit.Enabled = True
            '        CmdDelete.Enabled = True
            '        CmdMakeBill.Enabled = True
            '    End While
            'End If


        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally
            MySqlCon.Dispose()
            MySqlCmd.Dispose()
        End Try

    End Sub

    Private Sub CmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdSearch.Click
        Try
            If InsertFlag = 1 Then
                Search(1)
                Me.GridDTL.Focus()
            Else
                Search(5)
            End If
        Catch EX As Exception
            MsgBox(EX.Message)
        End Try
    End Sub

    Public Sub Search(ByVal ClickedValue As Integer)
        Dim frm As New BillingHelp
        frm.ModeHelp = ClickedValue
        frm.ServiceCodes = ServiceCodes
        frm.ShowDialog()
        If frm.strSelectedValue.Trim <> String.Empty Then
            getdata(frm.ModeHelp, frm.strSelectedValue)
        End If
        frm.Dispose()

    End Sub

    Public Sub CmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNew.Click
        ServiceCodes = String.Empty
        InsertFlag = 1

        CancelFlag = 0
        txtpID.Enabled = True
        Clear()
        'GroupMain.Enabled = True
        'OptSexM.Checked = True
        'optTitleMr.Focus()
        CmdNew.Enabled = False
        CmdNew.Visible = False
        CmdSave.Enabled = True
        CmdSave.Visible = True

        CmdCancel.Enabled = True
        ReadOnlyTrueFalse(True)
        'CmdSearch.Enabled = False
        Me.GridDTL.MaxRows = 0
        isDiscountAllowed = False
        txtDiscountAmount.ReadOnly = False
        AddBlankRecordInGrid()
        EnableDisable(True)
        btnPreview.Enabled = False
        btnPrint.Enabled = False
        btnCancelBill.Enabled = False
        amount = 0
    End Sub

    Private Sub CmdSave_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles CmdSave.Click
        Dim StrSql As String = String.Empty
        Dim Con As New Odbc.OdbcConnection
        Dim Cmd As New Odbc.OdbcCommand
        Dim Obj As Object = Nothing
        Dim StrId As String = String.Empty
        Dim STRTITLE As String = String.Empty
        Dim STRSEX As String = String.Empty
        Dim Trans As System.Data.Odbc.OdbcTransaction
        Dim IsTrans As Boolean = False
        Dim VarVal As Object = Nothing


        ServiceCodes = String.Empty
        If Me.txtpID.Text.Trim = String.Empty Then
            MsgBox("Please Select Patient.", MsgBoxStyle.Information)
            CmdSearch.Focus()
            Exit Sub
        End If

        If Int(txtNetAmount.Text) < 1 Then
            MsgBox("Zero Bill Amount is not allowed to save Billing Details.", MsgBoxStyle.Information)
            Exit Sub
        End If

        If GridDTL.MaxRows < 1 Then
            MsgBox("Please Select Services.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim ServiceCode As String = Nothing
        GridDTL.GetText(ENUMGRIDDTL.SERVICECODE, GridDTL.MaxRows, ServiceCode)
        If IsNothing(ServiceCode) = True Then ServiceCode = String.Empty
        If ServiceCode.Trim = String.Empty Then GridDTL.MaxRows = GridDTL.MaxRows - 1




        For IntCtr = 1 To Me.GridDTL.MaxRows
            ServiceCode = Nothing
            GridDTL.GetText(ENUMGRIDDTL.SERVICECODE, IntCtr, ServiceCode)
            If (ServiceCode = "") Then
                MsgBox("Please Select Service Name.", MsgBoxStyle.Information)
                GridDTL.Row = Me.GridDTL.MaxRows
                GridDTL.Col = ENUMGRIDDTL.SERVICENAME
                GridDTL.Action = FPSpread.ActionConstants.ActionActiveCell
                GridDTL.Focus()
                Exit Sub
            End If

            VarVal = Nothing
            GridDTL.GetText(ENUMGRIDDTL.SUBDEPTCODE, GridDTL.MaxRows, VarVal)
            If IsNothing(VarVal) = True Then VarVal = String.Empty

            If VarVal.ToString.Trim = String.Empty Then
                MsgBox("Please Enter Valid Service Name.", MsgBoxStyle.Information)
                GridDTL.Row = Me.GridDTL.MaxRows
                GridDTL.Col = ENUMGRIDDTL.UserDefinedServiceCode
                GridDTL.Action = FPSpread.ActionConstants.ActionActiveCell
                GridDTL.Focus()
                Exit Sub
            End If

            VarVal = Nothing
            GridDTL.GetText(ENUMGRIDDTL.CHARGES, GridDTL.MaxRows, VarVal)
            If IsNothing(VarVal) = True Then VarVal = "0"

            If Val(VarVal.ToString.Trim) = 0 Then
                MsgBox("Please Enter Charge For Selected Service.", MsgBoxStyle.Information)
                GridDTL.Row = Me.GridDTL.MaxRows
                GridDTL.Col = ENUMGRIDDTL.CHARGES
                GridDTL.Action = FPSpread.ActionConstants.ActionActiveCell
                GridDTL.Focus()
                Exit Sub
            End If
        Next

        Try
            Con = GetAccesscon()
            Cmd.CommandType = CommandType.Text
            Cmd.Connection = Con
            Obj = Nothing
            Cmd.CommandText = "SELECT IIF( ISNULL( MAX(BILLINGDATE))=TRUE,'" + Date.Today.ToString("dd/MMM/yyyy") + "',  MAX(BILLINGDATE))       FROM PATIENTBILLING"
            Obj = Cmd.ExecuteScalar()
            If Me.txtBillingDate.Value < Convert.ToDateTime(Obj) Then
                MsgBox("Billing Data Can't Be Less Than " + Convert.ToDateTime(Obj).ToString("dd/MMM/yyyy"))
                Exit Sub
            End If


            Trans = Con.BeginTransaction
            Cmd.Transaction = Trans
            IsTrans = True

            If InsertFlag = 1 Then
                amount = 0
                For intctr = 1 To Me.GridDTL.MaxRows
                    Dim Charge As Object
                    Charge = Nothing
                    GridDTL.GetText(ENUMGRIDDTL.CHARGES, intctr, Charge)

                    amount += Charge

                Next
                txtTotalAmount.Text = amount.ToString()
                amount = amount - Int(IIf(txtDiscountAmount.Text.Trim() = "", 0, txtDiscountAmount.Text))
                txtNetAmount.Text = amount.ToString()
                lblAmountInWord.Text = BILLING.WORD_FIVE_DIGIT(amount)

                StrSql = "Select IIF(ISNULL(MAX(VAL(MID(billingid,2,6))))=TRUE,1, MAX(VAL( MID(billingid,2,6)) )+1) as Mxid from patientbilling "
                Cmd.CommandText = StrSql
                Obj = Cmd.ExecuteScalar()
                StrId = Val(Obj.ToString()).ToString("000000")
                StrId = "R" + StrId

                For IntCtr = 1 To Me.GridDTL.MaxRows
                    Dim DepCode As String
                    Dim SubDepCode As String
                    Dim Remarks As String
                    Dim Charge As Object

                    DepCode = Nothing
                    SubDepCode = Nothing
                    ServiceCode = Nothing
                    Remarks = Nothing
                    Charge = Nothing

                    GridDTL.GetText(ENUMGRIDDTL.DEPTCODE, IntCtr, DepCode)

                    GridDTL.GetText(ENUMGRIDDTL.SUBDEPTCODE, IntCtr, SubDepCode)

                    GridDTL.GetText(ENUMGRIDDTL.SERVICECODE, IntCtr, ServiceCode)
                    GridDTL.GetText(ENUMGRIDDTL.REMARKS, IntCtr, Remarks)
                    GridDTL.GetText(ENUMGRIDDTL.CHARGES, IntCtr, Charge)

                    'StrSql = "INSERT INTO PATIENTBILLING ( PatientBilling.BILLINGID, PatientBilling.BILLINGDATE, PatientBilling.DEPCODE, PatientBilling.SUBDEPCODE, PatientBilling.SERVICECODE, PatientBilling.REMARKS, PatientBilling.CHARGE, PatientBilling.USERCODE, PatientBilling.PATIENTID )"
                    StrSql = "INSERT INTO PATIENTBILLING ( BILLINGID, BILLINGDATE, DEPCODE, SUBDEPCODE, SERVICECODE, REMARKS, CHARGE, USERCODE, PATIENTID,AMOUNTINWORD,DISCOUNT,NetAmount )"
                    StrSql = StrSql + " SELECT '" + StrId + "','" + txtBillingDate.Value.Date + "','" + DepCode.ToString() + "','" + SubDepCode.ToString() + "','" + ServiceCode.ToString() + "','" + Remarks.ToString() + "'," + Charge.ToString() + ",'" + UserCode.ToString() + "','" + txtpID.Text + "','" + lblAmountInWord.Text + "'," + Val(txtDiscountAmount.Text).ToString + "," + Val(txtNetAmount.Text).ToString
                    ' StrSql = "INSERT INTO PATIENTBILLING(  PatientID,PatientName,Title,Name,AgeYears,AgeValue,Age,Sex,Fname,Address,RDoc,RegisterDate,USERCODE)"
                    'StrSql = StrSql + "SELECT '" + StrId + "','" + STRTITLE + " " + Me.txtPname.Text.Trim + "','" + STRTITLE + "','" + Me.txtPname.Text.Trim + "'," + Me.TxtYears.Text.Trim + ",'" + Me.MDYValue.Text + "','" + Me.TxtYears.Text.Trim + " " + Me.MDYValue.Text + "','" + STRSEX + "','" + txtFname.Text.Trim + "','" + Me.txtPaddress.Text.Trim + "','" + Me.txtRef.Text.Trim + "','" + txtregDate.Value + "','" + UserCode + "'"
                    Cmd.CommandText = StrSql
                    Cmd.ExecuteNonQuery()
                    Me.TctReceiptNo.Text = StrId
                    'GetData(StrId)

                Next





                'ElseIf EditFlag = 1 Then
                '    StrSql = "Update  Patient Set PatientName='" + STRTITLE + " " + Me.txtPname.Text.Trim + "',"
                '    StrSql = StrSql + "Title='" + STRTITLE + "',"
                '    StrSql = StrSql + "Name='" + Me.txtPname.Text.Trim + "',"
                '    StrSql = StrSql + "AgeYears=" + Me.TxtYears.Text.Trim + ","
                '    StrSql = StrSql + "AgeValue='" + Me.MDYValue.Text + "',"
                '    StrSql = StrSql + "Age=" + Me.TxtYears.Text.Trim + ","
                '    StrSql = StrSql + "Sex='" + STRSEX + "',"
                '    StrSql = StrSql + "Fname='" + txtFname.Text.Trim + "',"
                '    StrSql = StrSql + "Address='" + Me.txtPaddress.Text.Trim + "',"
                '    StrSql = StrSql + "RDoc='" + Me.txtRef.Text.Trim + "',"
                '    StrSql = StrSql + "RegisterDate='" + txtregDate.Value + "',USERCODE='" + UserCode + "'"
                '    StrSql = StrSql + "Where PatientID='" + Me.txtpID.Text.Trim + "'"
                '    Cmd.CommandText = StrSql
                '    Cmd.ExecuteNonQuery()
                '    GetData(Me.txtpID.Text.Trim, 5)
            End If
            Trans.Commit()
            IsTrans = False
            MsgBox("Saved Successfully.", MsgBoxStyle.Information)
            If Me.ChPrintReceipt.Checked = True Then
                btnPrint_Click(sender, e)
            End If
            InsertFlag = 0
            CancelFlag = 0
            'GroupMain.Enabled = False
            CmdNew.Enabled = True
            CmdNew.Visible = True
            CmdSave.Enabled = False
            CmdSave.Visible = False
            CmdCancel.Enabled = False
            ReadOnlyTrueFalse(True)
            CmdSearch.Enabled = True
            EnableDisable(False)
            btnPreview.Enabled = True
            btnPrint.Enabled = True
            btnCancelBill.Enabled = True
        Catch EX As Exception
            If IsTrans = True Then Trans.Rollback()
            MsgBox(EX.Message, MsgBoxStyle.Critical)
        Finally
            Con.Dispose()
            Cmd.Dispose()
            Obj = Nothing
            If IsNothing(Trans) = False Then Trans.Dispose()
        End Try
    End Sub

    Private Sub txtDiscountAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDiscountAmount.KeyPress
        If (isDiscountAllowed = False) Then
            Dim frm As New Password
            frm.ShowDialog()
            ' Dim result As String = InputBox("Enter Discount Password", "HBS")
            If (frm.isDiscountPassword = False) Then
                e.KeyChar = "0"
                MsgBox("Invalid Password.")
            End If
            If (frm.isDiscountPassword = True) Then
                isDiscountAllowed = True
            Else
                txtDiscountAmount.Text = 0
            End If
            frm.Close()



        End If
    End Sub


    Private Function GetOthersPassword(ByVal isDiscount As Boolean, Optional ByVal both As Boolean = False) As String
        Dim MySqlCon As New Odbc.OdbcConnection
        Dim MySqlDataRd As Odbc.OdbcDataReader
        Dim MySqlCmd As New Odbc.OdbcCommand
        MySqlCon = GetAccesscon()
        MySqlCmd.Connection = MySqlCon
        Dim result As String = String.Empty
        Dim resultboth As String = String.Empty
        Try
            MySqlCmd.CommandText = "SELECT DeletePassword,DiscountPassword FROM OtherPasswords"
            MySqlDataRd = MySqlCmd.ExecuteReader()

            If (MySqlDataRd.HasRows = True) Then
                While (MySqlDataRd.Read)
                    If (isDiscount = True) Then ' returns discount password only
                        result = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("DiscountPassword")).ToString()
                    Else
                        result = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("DeletePassword")).ToString()
                    End If

                    If (both = True) Then
                        resultboth = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("DiscountPassword")).ToString() + ";" + MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("DeletePassword")).ToString()
                    End If

                End While
            End If

            MySqlDataRd.Close()
            If both = True Then
                Return resultboth
            Else
                Return result
            End If
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
            Return String.Empty
        Finally
            MySqlCon.Dispose()
            MySqlCmd.Dispose()
        End Try
    End Function

    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        ServiceCodes = String.Empty
        InsertFlag = 0

        Clear()

        CmdNew.Enabled = True
        CmdNew.Visible = True
        CmdSave.Enabled = False
        CmdSave.Visible = False

        CmdCancel.Enabled = False
        btnPreview.Enabled = False
        btnPrint.Enabled = False
        btnCancelBill.Enabled = False
        ReadOnlyTrueFalse(True)
        GridDTL.MaxRows = 0
        AddBlankRecordInGrid()
        amount = 0
        EnableDisable(False)
    End Sub

    Private Sub EnableDisable(ByVal blnTrueFalse As Boolean)
        txtpID.Enabled = blnTrueFalse
        TctReceiptNo.Enabled = blnTrueFalse
        txtBillingDate.Enabled = blnTrueFalse
        GridDTL.Enabled = blnTrueFalse
        txtName.Enabled = blnTrueFalse
        txtAge.Enabled = blnTrueFalse
        txtSex.Enabled = blnTrueFalse
        txtDiscountAmount.Enabled = blnTrueFalse
    End Sub
    Private Sub CalculateAmount()
        Dim IntX As Integer
        Dim varCharge As Object
        Dim Tot As Decimal
        ServiceCodes = String.Empty
        Dim serviceCode As Object


        txtTotalAmount.Text = 0
        txtNetAmount.Text = 0
        lblAmountInWord.Text = "Rupees Zero Only."
        If Me.GridDTL.MaxRows > 0 Then
            For IntX = 1 To Me.GridDTL.MaxRows
                varCharge = Nothing
                serviceCode = Nothing
                Me.GridDTL.GetText(ENUMGRIDDTL.CHARGES, IntX, varCharge)
                If IsNothing(varCharge) = True Then varCharge = "0"
                Me.GridDTL.GetText(ENUMGRIDDTL.SERVICECODE, IntX, serviceCode)
                Tot = Tot + Val(varCharge.ToString)

                ServiceCodes += "'" + serviceCode + "',"


            Next

            ServiceCodes = ServiceCodes.Substring(0, ServiceCodes.LastIndexOf(","))
            txtTotalAmount.Text = Tot
            txtNetAmount.Text = Tot - Val(Me.txtDiscountAmount.Text)
            lblAmountInWord.Text = BILLING.WORD_FIVE_DIGIT(txtNetAmount.Text)
        Else
            txtDiscountAmount.Text = 0
        End If

    End Sub

    Private Sub btnPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreview.Click
        If TctReceiptNo.Text.Trim = String.Empty Then
            MsgBox("Receipt Number Can Not Be Blank.", MsgBoxStyle.Information)
            Exit Sub
        End If
        Dim cr As New ReportViewer
        cr.strReceiptNo = Me.TctReceiptNo.Text
        cr.ShowDialog()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        If TctReceiptNo.Text.Trim = String.Empty Then
            MsgBox("Receipt Number Can Not Be Blank.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim RdAddSold As New ReportDocument
        Dim fPath As String

        Dim MySqlCon As New Odbc.OdbcConnection
        Dim MySqlDataRd As Odbc.OdbcDataReader
        Dim MySqlCmd As New Odbc.OdbcCommand
        Dim HOSPNAME As String = String.Empty
        Dim HOSPADD As String = String.Empty
        Dim HOSPPHONE As String = String.Empty

        Dim crtableLogoninfos As New TableLogOnInfos

        Dim crConnectionInfo As New ConnectionInfo
        Dim CrTables As Tables
        Dim CrTable As Table



        Try
            If Me.ChPrintInDosMode.Checked = True Then
                PrintInDosMode()
            Else
                Dim crtableLogoninfo As New TableLogOnInfo
                MySqlCmd.CommandText = ""
                MySqlCmd.CommandText = "SELECT HOSPNAME,HOSPADD,HOSPPHONE FROM HOSPDETAIL "
                MySqlDataRd = MySqlCmd.ExecuteReader()
                If (MySqlDataRd.HasRows = True) Then
                    While (MySqlDataRd.Read)
                        HOSPNAME = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("HOSPNAME")).ToString()
                        HOSPADD = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("HOSPADD")).ToString()
                        HOSPPHONE = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("HOSPPHONE")).ToString()
                    End While
                End If
                MySqlDataRd.Close()

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
                RdAddSold.DataDefinition.FormulaFields("HOSPADD").Text = "'" + HOSPADD + "'"
                RdAddSold.DataDefinition.FormulaFields("HOSPPHONE").Text = "'" + HOSPPHONE + "'"
                RdAddSold.RecordSelectionFormula = "{PatientBilling.BillingID}='" + Me.TctReceiptNo.Text.Trim + "'"
                RdAddSold.Refresh()
                RdAddSold.PrintToPrinter(1, False, 1, 1)

            End If
        Catch Ex As Exception
            If Err.Number = 57 Then
                MsgBox("Printer Is Busy.")
            Else
                MsgBox(Ex.Message, MsgBoxStyle.Critical)
            End If

        Finally
            MySqlCon.Dispose()
            MySqlCmd.Dispose()
            RdAddSold.Dispose()
        End Try

    End Sub

    Private Sub CmdClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdClose.Click
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub txtDiscountAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscountAmount.TextChanged
        If InsertFlag = 1 Then
            txtNetAmount.Text = Val(Me.txtTotalAmount.Text) - Val(Me.txtDiscountAmount.Text)
            lblAmountInWord.Text = BILLING.WORD_FIVE_DIGIT(txtNetAmount.Text)
        End If
    End Sub

    Private Sub btnCancelBill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelBill.Click
        If MsgBox("Are You Sure To Cancel This Bill?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            Dim StrSql As String = String.Empty
            Dim Con As New Odbc.OdbcConnection
            Dim Cmd As New Odbc.OdbcCommand
            Dim obj As Object = Nothing
            Dim VarTypeCode As Object = Nothing
            Dim VarTypeDesc As Object = Nothing
            Dim Trans As System.Data.Odbc.OdbcTransaction
            Dim IsTrans As Boolean = False
            Try

                Dim frm As New Password
                frm.lblPassword.Text = "Cancel Password"
                frm.isDiscountCalled = False
                frm.ShowDialog()
                '                Dim result As String = InputBox("Enter Bill Cancelation Password.", "HBS")
                If (frm.isCancelPassword = False) Then
                    MsgBox("Invalid Password.")
                    Exit Sub
                End If
                If (frm.isCancelPassword = True) Then


                    Cmd.CommandType = CommandType.Text
                    Con = GetAccesscon()
                    Cmd.Connection = Con
                    Trans = Con.BeginTransaction
                    Cmd.Transaction = Trans
                    IsTrans = True


                    StrSql = "Update PatientBilling Set ISCANCELLED=1 where BILLINGID='" + TctReceiptNo.Text.Trim + "'"
                    Cmd.CommandText = StrSql
                    Cmd.ExecuteScalar()
                    Trans.Commit()
                    IsTrans = False
                    btnCancelBill.Enabled = False
                    Me.LbLBillCancelled.Visible = True
                    MsgBox("This Bill Has Been Cancelled.", MsgBoxStyle.Information)
                    frm.Close()
                Else
                    MsgBox("Invalid Password.")
                    Exit Sub
                End If
            Catch EX As Exception
                MsgBox(EX.Message)
            Finally
                Cmd.Dispose()
                Con.Dispose()
                Cmd.Dispose()
                If IsTrans = True Then Trans.Rollback()
                If IsNothing(Trans) = False Then Trans.Dispose()
            End Try
        End If
    End Sub



    Private Sub GridDTL_EditChange(ByVal sender As Object, ByVal e As AxFPSpread._DSpreadEvents_EditChangeEvent) Handles GridDTL.EditChange
        If e.col = ENUMGRIDDTL.UserDefinedServiceCode Then
            Dim Var As Object = Nothing
            Me.GridDTL.GetText(ENUMGRIDDTL.UserDefinedServiceCode, Me.GridDTL.ActiveRow, Var)

            GetServiceCodeInfo()
        End If
        If e.col = ENUMGRIDDTL.CHARGES Then
            CalculateAmount()
        End If

    End Sub


    Private Sub FillCombo(ByVal strSearch As String)
        Dim MySqlCon As New Odbc.OdbcConnection()
        Dim MysqlCmd As New Odbc.OdbcCommand
        MySqlCon = GetAccesscon()
        Dim DS As New DataSet
        Dim MySqlAdp As Odbc.OdbcDataAdapter
        Dim intX As Integer
        ' Blncombofill = True
        If strSearch.Trim = String.Empty Then Me.GRPPOPUPHELP.Visible = False
        Try
            MySqlAdp = New Odbc.OdbcDataAdapter("SELECT SERVICES.SERVICECODE, SERVICES.UDSERVICECODE as UDFSERVICE,SERVICES.SERVICEDESC FROM SERVICES Where (SERVICES.SERVICECODE Like '" + strSearch.Trim + "%' or SERVICES.SERVICEDESC Like '" + strSearch.Trim + "%') AND ServiceCode NOT IN (" + IIf(ServiceCodes = "", "''", ServiceCodes) + ")", MySqlCon)
            MySqlAdp.Fill(DS, "TAB1")
            GridPopUpService.MaxRows = 0
            For intX = 0 To DS.Tables(0).Rows.Count - 1
                GridPopUpService.MaxRows = GridPopUpService.MaxRows + 1
                Me.GridPopUpService.SetText(1, intX + 1, DS.Tables(0).Rows(intX)(0).ToString)
                Me.GridPopUpService.SetText(2, intX + 1, DS.Tables(0).Rows(intX)(1).ToString)
                Me.GridPopUpService.SetText(3, intX + 1, DS.Tables(0).Rows(intX)(2).ToString)
            Next

            Me.GridPopUpService.Col = 1 : GridPopUpService.ColHidden = True
            GridPopUpService.BlockMode = True
            GridPopUpService.Col = 1
            GridPopUpService.Col2 = GridPopUpService.MaxCols
            GridPopUpService.Row = 1
            GridPopUpService.Row2 = GridPopUpService.MaxRows
            GridPopUpService.Lock = True
            GridPopUpService.BlockMode = False

            If DS.Tables(0).Rows.Count > 0 Then
                GRPPOPUPHELP.Visible = True

                Me.GridPopUpService.Col = 1
                Me.GridPopUpService.Row = 1
                GridPopUpService.Action = FPSpread.ActionConstants.ActionActiveCell
                Me.GridPopUpService.Focus()

            Else
                GRPPOPUPHELP.Visible = False
            End If

        Catch Ex As Exception
            MsgBox(Ex.Message)
        Finally
            'Blncombofill = False
            MySqlCon.Dispose()
        End Try
    End Sub

    Private Sub GetServiceCodeInfo()
        Dim MySqlCon As New Odbc.OdbcConnection()
        Dim MysqlCmd As New Odbc.OdbcCommand
        MySqlCon = GetAccesscon()
        Dim DS As New DataSet
        Dim MySqlDataRd As Odbc.OdbcDataReader
        Dim VarStr As Object = Nothing
        Dim strSQL As String = String.Empty
        Me.GridDTL.GetText(ENUMGRIDDTL.UserDefinedServiceCode, Me.GridDTL.ActiveRow, VarStr)

        Try

            Me.GridDTL.SetText(ENUMGRIDDTL.DEPTCODE, Me.GridDTL.MaxRows, String.Empty)
            Me.GridDTL.SetText(ENUMGRIDDTL.DEPTNAME, Me.GridDTL.MaxRows, String.Empty)
            Me.GridDTL.SetText(ENUMGRIDDTL.SUBDEPTCODE, Me.GridDTL.MaxRows, String.Empty)
            Me.GridDTL.SetText(ENUMGRIDDTL.SUBDEPTNAME, Me.GridDTL.MaxRows, String.Empty)
            Me.GridDTL.SetText(ENUMGRIDDTL.SERVICECODE, Me.GridDTL.MaxRows, String.Empty)
            Me.GridDTL.SetText(ENUMGRIDDTL.SERVICENAME, Me.GridDTL.MaxRows, String.Empty)
            Me.GridDTL.SetText(ENUMGRIDDTL.CHARGES, Me.GridDTL.MaxRows, "0.00")


            MysqlCmd.Connection = MySqlCon
            strSQL = "SELECT SERVICES.SERVICECODE,SERVICES.UDSERVICECODE, SERVICES.SERVICEDESC, SUBDEPARTMENT.SUBDEPCODE, SUBDEPARTMENT.SUBDEPDESC, DEPARTMENT.DEPCODE, DEPARTMENT.DEPDESC,CHARGE FROM (SERVICES INNER JOIN SUBDEPARTMENT ON (SERVICES.SUBDEPCODE = SUBDEPARTMENT.SUBDEPCODE) AND (SERVICES.DEPCODE = SUBDEPARTMENT.DEPCODE)) INNER JOIN DEPARTMENT ON SUBDEPARTMENT.DEPCODE = DEPARTMENT.DEPCODE Where UDSERVICECODE = '" + VarStr.ToString.Trim + "'  AND ServiceCode NOT IN (" + IIf(ServiceCodes = "", "''", ServiceCodes) + ")"
            MysqlCmd.CommandText = strSQL
            MySqlDataRd = MysqlCmd.ExecuteReader()
            If (MySqlDataRd.HasRows = True) Then
                Me.GRPPOPUPHELP.Visible = False
                While (MySqlDataRd.Read)

                    Me.GridDTL.SetText(ENUMGRIDDTL.DEPTCODE, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("DEPCODE")).ToString())
                    Me.GridDTL.SetText(ENUMGRIDDTL.DEPTNAME, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("DEPDESC")).ToString())
                    Me.GridDTL.SetText(ENUMGRIDDTL.SUBDEPTCODE, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("SUBDEPCODE")).ToString())
                    Me.GridDTL.SetText(ENUMGRIDDTL.SUBDEPTNAME, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("SUBDEPDESC")).ToString())
                    Me.GridDTL.SetText(ENUMGRIDDTL.SERVICECODE, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("SERVICECODE")).ToString())
                    Me.GridDTL.SetText(ENUMGRIDDTL.SERVICENAME, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("SERVICEDESC")).ToString())
                    Me.GridDTL.SetText(ENUMGRIDDTL.CHARGES, Me.GridDTL.MaxRows, MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Charge")).ToString())
                    If Val(MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Charge")).ToString()) = 0 Then
                        Me.GridDTL.Col = ENUMGRIDDTL.CHARGES
                        Me.GridDTL.Row = Me.GridDTL.MaxRows
                        Me.GridDTL.Lock = False
                    Else
                        Me.GridDTL.Col = ENUMGRIDDTL.CHARGES
                        Me.GridDTL.Row = Me.GridDTL.MaxRows
                        Me.GridDTL.Lock = True
                    End If


                End While
            Else
                FillCombo(VarStr.ToString)
            End If
            CalculateAmount()

        Catch Ex As Exception
            MsgBox(Ex.Message)
        Finally

            MySqlCon.Dispose()
        End Try
    End Sub

    Private Sub GridDTL_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpread._DSpreadEvents_KeyDownEvent) Handles GridDTL.KeyDownEvent
        If e.keyCode = Keys.Down And Me.GRPPOPUPHELP.Visible = True Then
            Me.GridPopUpService.Col = 1
            Me.GridPopUpService.Row = 1
            GridPopUpService.Action = FPSpread.ActionConstants.ActionActiveCell
            Me.GridPopUpService.Focus()
            Me.GridPopUpService.Focus()
        ElseIf e.keyCode = 9 Then
            If Me.CmdNew.Enabled = True And Me.CmdNew.Visible = True Then Me.CmdNew.Focus()
            If Me.CmdSave.Enabled = True And Me.CmdSave.Visible = True Then Me.CmdSave.Focus()

        End If
    End Sub

    Private Sub GridPopUpService_DblClick(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_DblClickEvent) Handles GridPopUpService.DblClick
        GridPopUpService_KeyDownEvent(sender, New AxFPSpreadADO._DSpreadEvents_KeyDownEvent(13, 0))
    End Sub

    Private Sub GridPopUpService_KeyDownEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyDownEvent) Handles GridPopUpService.KeyDownEvent
        Dim Var As Object = Nothing
        If e.keyCode = 190 Then e.keyCode = 46
        If e.keyCode <> Keys.Down And e.keyCode <> 13 Then
            GridDTL.GetText(ENUMGRIDDTL.UserDefinedServiceCode, GridDTL.ActiveRow, Var)
            If IsNothing(Var) = True Then Var = String.Empty
            'GridDTL.EditModePermanent = True
            Me.GRPPOPUPHELP.Visible = False
            GridDTL.Row = GridDTL.ActiveRow
            GridDTL.Col = ENUMGRIDDTL.UserDefinedServiceCode
            GridDTL.Action = FPSpread.ActionConstants.ActionActiveCell
            If e.keyCode = Keys.Back Then
                GridDTL.SetText(ENUMGRIDDTL.UserDefinedServiceCode, GridDTL.ActiveRow, Mid(Var.ToString, 1, Len(Var.ToString) - 1))
            Else
                If InStr(".ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890_-()", Chr(e.keyCode).ToString.ToUpper) <> 0 Then
                    GridDTL.SetText(ENUMGRIDDTL.UserDefinedServiceCode, GridDTL.ActiveRow, Var.ToString + Chr(e.keyCode))
                End If
            End If
            GridDTL.Focus()
            GridDTL_EditChange(sender, New AxFPSpread._DSpreadEvents_EditChangeEvent(ENUMGRIDDTL.UserDefinedServiceCode, GridDTL.ActiveRow))
        ElseIf e.keyCode = 13 Then
            Me.GridPopUpService.GetText(2, GridPopUpService.ActiveRow, Var)
            GridDTL.SetText(ENUMGRIDDTL.UserDefinedServiceCode, GridDTL.ActiveRow, Var)
            Me.GRPPOPUPHELP.Visible = False
            GetServiceCodeInfo()
            GridDTL.EditEnterAction = FPSpread.EditEnterActionConstants.EditEnterActionNext
            GridDTL.Focus()
        End If

    End Sub

    Private Sub GridPopUpService_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridPopUpService.Leave

    End Sub
    Private Sub GridPopUpService_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridPopUpService.LostFocus
        'If BlnFlg = False Then
        On Error Resume Next
        If Me.ActiveControl.Name <> Me.GridPopUpService.Name Then
            Me.GRPPOPUPHELP.Visible = False
        End If

        'End If
        'BlnFlg = False
    End Sub

    Private Sub GridPopUpService_Advance(ByVal sender As System.Object, ByVal e As AxFPSpreadADO._DSpreadEvents_AdvanceEvent) Handles GridPopUpService.Advance

    End Sub

    Private Sub GRPPOPUPHELP_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GRPPOPUPHELP.Enter

    End Sub

    Private Sub GRPPOPUPHELP_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GRPPOPUPHELP.GotFocus

    End Sub

    Private Sub GridPopUpService_KeyPressEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyPressEvent) Handles GridPopUpService.KeyPressEvent
        'If e.keyAscii = 13 Then
        '    Dim Var As Object = Nothing
        '    Me.GridPopUpService.GetText(2, GridPopUpService.ActiveRow, Var)
        '    GridDTL.SetText(ENUMGRIDDTL.UserDefinedServiceCode, GridDTL.ActiveRow, Var)
        '    Me.GRPPOPUPHELP.Visible = False
        '    GetServiceCodeInfo()
        'End If
    End Sub

    Private Sub GridDTL_ClickEvent(ByVal sender As Object, ByVal e As AxFPSpread._DSpreadEvents_ClickEvent) Handles GridDTL.ClickEvent
        If Me.GRPPOPUPHELP.Visible = True Then Me.GRPPOPUPHELP.Visible = False
    End Sub

    Private Sub GridDTL_DataFill(ByVal sender As Object, ByVal e As AxFPSpread._DSpreadEvents_DataFillEvent) Handles GridDTL.DataFill

    End Sub

    Private Sub GridDTL_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDTL.GotFocus

    End Sub

    Private Sub GridDTL_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDTL.LostFocus

    End Sub

    Private Sub GridPopUpService_KeyUpEvent(ByVal sender As Object, ByVal e As AxFPSpreadADO._DSpreadEvents_KeyUpEvent) Handles GridPopUpService.KeyUpEvent
        'Dim VarText As Object = Nothing
        'GridPopUpService.GetText(GridPopUpService.ActiveCol, GridPopUpService.ActiveRow, VarText)
        'GridPopUpService.SetText(2, 0, VarText)
    End Sub

    Private Sub GridDTL_Advance(ByVal sender As System.Object, ByVal e As AxFPSpread._DSpreadEvents_AdvanceEvent) Handles GridDTL.Advance

    End Sub

    Private Sub lblAmountInWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblAmountInWord.Click

    End Sub

    Private Sub GridDTL_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDTL.Enter
        GridDTL.Refresh()
        Me.Refresh()
        GridDTL.ShadowText = Color.Blue
        GridDTL.Refresh()
        Me.Refresh()
    End Sub

    Private Sub GridDTL_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridDTL.Leave
        GridDTL.Refresh()
        Me.Refresh()
        GridDTL.ShadowText = Color.Black
        GridDTL.Refresh()
        Me.Refresh()
    End Sub

    Private Sub PrintInDosMode()
        If TctReceiptNo.Text.Trim = String.Empty Then
            MsgBox("Receipt Number Can Not Be Blank.", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim RdAddSold As New ReportDocument
        Dim fPath As String

        Dim MySqlCon As New Odbc.OdbcConnection
        Dim MySqlDataRd As Odbc.OdbcDataReader
        Dim MySqlCmd As New Odbc.OdbcCommand
        Dim HOSPNAME As String = String.Empty
        Dim HOSPADD As String = String.Empty
        Dim HOSPPHONE As String = String.Empty

        Dim crtableLogoninfos As New TableLogOnInfos
        Dim crtableLogoninfo As New TableLogOnInfo
        Dim crConnectionInfo As New ConnectionInfo
        Dim CrTables As Tables
        Dim CrTable As Table
        Dim strValue As String = String.Empty
        Dim strCharge As String = String.Empty
        Dim strType As String = String.Empty
        Dim strTotalNet As String = String.Empty
        Dim strDiscount As String = String.Empty
        Dim strTot As String = String.Empty
        Dim strChargeFormat As String = String.Empty
        Dim intX As Integer = 1
        Dim D As System.Diagnostics.Process

        If File.Exists(Application.StartupPath + "\Print.txt") = True Then File.Delete(Application.StartupPath + "\Print.txt")
        If File.Exists(Application.StartupPath + "\Print.bat") = True Then File.Delete(Application.StartupPath + "\Print.bat")
        Dim FsBat As StreamWriter = New StreamWriter(Application.StartupPath + "\Print.bat")
        Dim Fs As StreamWriter = New StreamWriter(Application.StartupPath + "\Print.txt")
        Dim Prc As New System.Diagnostics.Process
        Try
            MySqlCon = GetAccesscon()
            MySqlCmd.Connection = MySqlCon
            strType = String.Empty
            MySqlCmd.CommandText = ""
            MySqlCmd.CommandText = " SELECT  `PatientBilling`.`BILLINGID`, `PatientBilling`.`BILLINGDATE`, `PatientBilling`.`PATIENTID`, `Patient`.`Age`, `Patient`.`Sex`, `Patient`.`PatientName`, `SUBDEPARTMENT`.`SUBDEPDESC`, `SUBDEPARTMENT`.`SUBDEPCODE`, `SERVICES`.`SERVICEDESC`, `PatientBilling`.`CHARGE`, `PatientBilling`.`AMOUNTINWORD`, `PatientBilling`.`DISCOUNT`, `PatientBilling`.`NetAmount`, `PatientBilling`.`ISCANCELLED`  FROM   ((`PatientBilling` `PatientBilling` INNER JOIN `SUBDEPARTMENT` `SUBDEPARTMENT` ON (`PatientBilling`.`SUBDEPCODE`=`SUBDEPARTMENT`.`SUBDEPCODE`) AND (`PatientBilling`.`DEPCODE`=`SUBDEPARTMENT`.`DEPCODE`)) INNER JOIN `SERVICES` `SERVICES` ON `PatientBilling`.`SERVICECODE`=`SERVICES`.`SERVICECODE`) INNER JOIN `Patient` `Patient` ON `PatientBilling`.`PATIENTID`=`Patient`.`PatientID`   where `PatientBilling`.`BILLINGID`='" + Me.TctReceiptNo.Text.Trim + "' ORDER BY `SUBDEPARTMENT`.`SUBDEPCODE` "
            MySqlDataRd = MySqlCmd.ExecuteReader()
            If (MySqlDataRd.HasRows = True) Then
                While (MySqlDataRd.Read)
                    If intX = 1 Then
                        Fs.WriteLine("            G Mohan Nursing Home & Hospital H")
                        Fs.WriteLine("(Unit of: Mohan Lal Community Health & Charitable Society)")
                        Fs.WriteLine("         B-2/4,A, YAMUNA VIHAR, DELHI-110053")
                        Fs.WriteLine(" Phone : 22913708, 22916862")
                        Fs.WriteLine("")
                        If MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("iscancelled")) = True Then
                            Fs.WriteLine("                Patient Bill(CANCELLED)")
                        Else
                            Fs.WriteLine("                    Patient Bill")
                        End If

                        Fs.WriteLine("________________________________________________________________")
                        Fs.WriteLine("Receipt No    :" + Me.TctReceiptNo.Text + "            Receipt Date " + Me.txtBillingDate.Text)
                        Fs.WriteLine("Patient Id    :" + Me.txtpID.Text + "    Age & Sex " + Me.txtAge.Text + " " + Me.txtSex.Text)
                        Fs.WriteLine("Name          :" + Me.txtName.Text)
                        Fs.WriteLine("________________________________________________________________")
                        Fs.WriteLine("Services                                      Charges In (Rs.)")
                        Fs.WriteLine("________________________________________________________________")

                    End If
                    If strType.ToUpper <> MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("SUBDEPDESC")).ToString().ToUpper Then
                        Fs.WriteLine(MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("SUBDEPDESC")).ToString().ToUpper)
                    End If
                    strChargeFormat = Val(Mid(MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("CHARGE")).ToString(), 1, 10)).ToString("#######.00")
                    strCharge = Space(10 - strChargeFormat.Length) + strChargeFormat
                    strValue = Mid(MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("SERVICEDESC")).ToString(), 1, 50) + Space(50 - Mid(MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("SERVICEDESC")).ToString(), 1, 50).Length)
                    Fs.WriteLine(Space(2) + strValue + strCharge)
                    strType = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("SUBDEPDESC")).ToString()
                    intX = intX + 1
                End While
            End If
            MySqlDataRd.Close()
            strTot = "Total" + Space(62 - ("Total".Length) - Val(Me.txtTotalAmount.Text).ToString("#######.00").Length) + Mid(Val(Me.txtTotalAmount.Text).ToString("#######.00"), 1, 10)
            strTotalNet = "Net Payable" + Space(62 - ("Net Payable".Length) - Val(Me.txtNetAmount.Text).ToString("#######.00").Length) + Mid(Val(Me.txtNetAmount.Text).ToString("#######.00"), 1, 10)
            strDiscount = "Discount" + Space(62 - ("Discount".Length) - Val(Me.txtDiscountAmount.Text).ToString("#######.00").Length) + Mid(Val(Me.txtDiscountAmount.Text).ToString("#######.00"), 1, 10)
            Fs.WriteLine("________________________________________________________________")
            Fs.WriteLine(strTot)
            If Val(Me.txtDiscountAmount.Text) > 0 Then Fs.WriteLine(strDiscount)
            Fs.WriteLine(strTotalNet)
            Fs.WriteLine("________________________________________________________________")
            Fs.WriteLine("Received With Thanks A Sum of : ")
            Fs.WriteLine(Mid(lblAmountInWord.Text, 1, 60))
            Fs.WriteLine(Mid(lblAmountInWord.Text, 61, Len(lblAmountInWord.Text)).Trim)
            Fs.WriteLine("Print Date: " + DateTime.Now.ToString("dd/MMM/yyyy hh:mm:ss tt"))

            Fs.WriteLine("                                                  ______________")
            Fs.WriteLine("                                                    Auth. Sign  ")
            Fs.WriteLine("*********************GET WELL SOON******************************")
            Fs.WriteLine(vbCrLf)
            Fs.WriteLine(vbCrLf)
            Fs.WriteLine(vbCrLf)
            Fs.WriteLine(vbCrLf)
            Fs.WriteLine(vbCrLf)
            Fs.WriteLine(vbCrLf)
            Fs.WriteLine("")
            Fs.Close()
            FsBat.WriteLine("Echo off")
            'FsBat.WriteLine("cd\")
            'FsBat.WriteLine("CD C:")
            FsBat.WriteLine("Type Print.txt " + strPrinterPortConfig)
            FsBat.WriteLine("Exit")
            FsBat.Close()
            Prc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            Prc.StartInfo.FileName = Application.StartupPath + "\Print.bat"
            D = System.Diagnostics.Process.Start(Prc.StartInfo)

            Threading.Thread.Sleep(1000)
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally
            Try
                If D.HasExited = False Then D.Kill()
            Catch ex As Exception
            End Try
            MySqlCon.Dispose()
            MySqlCmd.Dispose()
            RdAddSold.Dispose()
            Prc.Dispose()
            If IsNothing(FsBat) = False Then FsBat.Dispose()
            If IsNothing(Fs) = False Then Fs.Dispose()
        End Try
    End Sub
    Private Sub SaveConfig()
        Dim MySqlCon As New Odbc.OdbcConnection
        Dim MySqlCmd As New Odbc.OdbcCommand
        Try
            MySqlCon = GetAccesscon()
            MySqlCmd.Connection = MySqlCon

            If Me.ChPrintInDosMode.Checked = True Then
                MySqlCmd.CommandText = "Update HBSCONFIG SET PrintInDosMode=1 "
                MySqlCmd.ExecuteNonQuery()
            Else
                MySqlCmd.CommandText = "Update HBSCONFIG SET PrintInDosMode=0"
                MySqlCmd.ExecuteNonQuery()
            End If
            If Me.ChPrintReceipt.Checked = True Then
                MySqlCmd.CommandText = "Update HBSCONFIG SET PrintOnSave=1 "
                MySqlCmd.ExecuteNonQuery()
            Else
                MySqlCmd.CommandText = "Update HBSCONFIG SET PrintOnSave=0 "
                MySqlCmd.ExecuteNonQuery()
            End If

        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally
            MySqlCon.Dispose()
            MySqlCmd.Dispose()
        End Try
    End Sub
    Private Sub GetConfig()
        Dim MySqlCon As New Odbc.OdbcConnection
        Dim MySqlDataRd As Odbc.OdbcDataReader
        Dim MySqlCmd As New Odbc.OdbcCommand

        Try
            MySqlCon = GetAccesscon()
            MySqlCmd.Connection = MySqlCon
            MySqlCmd.CommandText = ""
            MySqlCmd.CommandText = " SELECT PrintInDosMode,PrintOnSave,printerport From HBSCONFIG"
            MySqlDataRd = MySqlCmd.ExecuteReader()
            If (MySqlDataRd.HasRows = True) Then
                While (MySqlDataRd.Read)
                    Me.ChPrintInDosMode.Checked = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("PrintInDosMode"))
                    Me.ChPrintReceipt.Checked = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("PrintOnSave"))
                End While
            End If
            MySqlDataRd.Close()

        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally
            MySqlCon.Dispose()
            MySqlCmd.Dispose()

        End Try
    End Sub

    Private Sub ChPrintReceipt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChPrintReceipt.CheckedChanged

    End Sub

    Private Sub ChPrintInDosMode_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChPrintInDosMode.CheckedChanged

    End Sub

    Private Sub ChPrintReceipt_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChPrintReceipt.Click
        SaveConfig()
    End Sub

    Private Sub ChPrintInDosMode_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ChPrintInDosMode.Click
        SaveConfig()
    End Sub
End Class