Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Text
Imports System.Windows.Forms
Imports System.IO

Public Class DateWisePatientReceipt
    Dim strPrinterPortConfig As String = String.Empty
    Public strSelectedValue As String = String.Empty
    Dim Blncombofill As Boolean = False

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
        Me.TxtFromDate.Value = DateTime.Now
        Me.TxtToDate.Value = DateTime.Now
        PgBar.Minimum = 0
        PgBar.Maximum = 100
        GetConfig()
    End Sub
    Private Sub CMDOK_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)

    End Sub

    Private Sub TmrRefresh_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub TxtSearch_TextChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub CmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdPrint.Click

        Dim D As System.Diagnostics.Process
        Dim Prc As New System.Diagnostics.Process
        Try
            Prc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            Prc.StartInfo.FileName = Application.StartupPath + "\DayBill.bat"
            D = System.Diagnostics.Process.Start(Prc.StartInfo)
            Threading.Thread.Sleep(1000)
        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally
            Try
                If D.HasExited = False Then D.Kill()
            Catch ex As Exception
            End Try
            Prc.Dispose()
        End Try
    End Sub

    Private Sub BtnPrintDepartmentCollection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

    Private Sub PrintInDosMode()
        Dim MySqlCon As New Odbc.OdbcConnection
        Dim MySqlDataRd As Odbc.OdbcDataReader
        Dim MySqlCmd As New Odbc.OdbcCommand
        Dim HOSPNAME As String = String.Empty
        Dim HOSPADD As String = String.Empty
        Dim HOSPPHONE As String = String.Empty
        Dim strValue As String = String.Empty
        Dim strCharge As String = String.Empty
        Dim strType As String = String.Empty
        Dim strTotalNet As String = String.Empty
        Dim strDiscount As String = String.Empty
        Dim strTot As String = String.Empty
        Dim strChargeFormat As String = String.Empty
        Dim intX As Integer = 1
        Dim D As System.Diagnostics.Process
        Dim Dset As DataSet
        Dim DAdp As Odbc.OdbcDataAdapter
        Dim intMainLoop As Integer
        Dim strBillingID As String = String.Empty
        Dim strPrevBillingID As String = String.Empty
        Dim strBillCharge As String = String.Empty
        Dim strBillNetAmount As String = String.Empty
        Dim strBillDiscount As String = String.Empty
        Dim intHeader As Integer = 0


        If File.Exists(Application.StartupPath + "\DayBill.txt") = True Then File.Delete(Application.StartupPath + "\DayBill.txt")
        If File.Exists(Application.StartupPath + "\DayBill.bat") = True Then File.Delete(Application.StartupPath + "\DayBill.bat")
        Dim FsBat As StreamWriter = New StreamWriter(Application.StartupPath + "\DayBill.bat")
        Dim Fs As StreamWriter = New StreamWriter(Application.StartupPath + "\DayBill.txt")
        Dim Prc As New System.Diagnostics.Process
        Dim objTotalCharge As Object = Nothing

        Try
            MySqlCon = GetAccesscon()
            DAdp = New Odbc.OdbcDataAdapter("SELECT Distinct PatientBilling.BILLINGID FROM PatientBilling Where BILLINGDATE Between  cdate('" + TxtFromDate.Value.ToString("dd/MMM/yyyy") + "')  and Cdate( '" + TxtToDate.Value.ToString("dd/MMM/yyyy") + "')", MySqlCon)
            Dset = New DataSet
            DAdp.Fill(Dset, "TabReceipt")

            PgBar.Minimum = 0
            PgBar.Maximum = Dset.Tables(0).Rows.Count
            PgBar.Value = 0
            PgBar.Visible = True
            For intMainLoop = 0 To Dset.Tables(0).Rows.Count - 1
                PgBar.Value = PgBar.Value + 1
                intX = 1
                strBillCharge = String.Empty
                strBillNetAmount = String.Empty
                strBillDiscount = String.Empty

                MySqlCmd.Connection = MySqlCon
                strType = String.Empty
                strBillingID = Dset.Tables(0).Rows(intMainLoop)(0).ToString
                objTotalCharge = Nothing
                MySqlCmd.CommandText = "Select Sum(CHARGE) As TotCharge From PatientBilling Where BillingID='" + strBillingID + "'"
                objTotalCharge = MySqlCmd.ExecuteScalar()
                If IsNothing(objTotalCharge) Then objTotalCharge = "0"

                MySqlCmd.CommandText = ""
                MySqlCmd.CommandText = " SELECT  `PatientBilling`.`BILLINGID`, format(PatientBilling.BILLINGDATE,'dd/MMM/yyyy') As BILLINGDATE1, `PatientBilling`.`PATIENTID`, `Patient`.`Age`, `Patient`.`Sex`, `Patient`.`PatientName`, `SUBDEPARTMENT`.`SUBDEPDESC`, `SUBDEPARTMENT`.`SUBDEPCODE`, `SERVICES`.`SERVICEDESC`, `PatientBilling`.`CHARGE`, `PatientBilling`.`AMOUNTINWORD`, `PatientBilling`.`DISCOUNT`, `PatientBilling`.`NetAmount`, `PatientBilling`.`ISCANCELLED`  FROM   ((`PatientBilling` `PatientBilling` INNER JOIN `SUBDEPARTMENT` `SUBDEPARTMENT` ON (`PatientBilling`.`SUBDEPCODE`=`SUBDEPARTMENT`.`SUBDEPCODE`) AND (`PatientBilling`.`DEPCODE`=`SUBDEPARTMENT`.`DEPCODE`)) INNER JOIN `SERVICES` `SERVICES` ON `PatientBilling`.`SERVICECODE`=`SERVICES`.`SERVICECODE`) INNER JOIN `Patient` `Patient` ON `PatientBilling`.`PATIENTID`=`Patient`.`PatientID`   where `PatientBilling`.`BILLINGID`='" + strBillingID + "' ORDER BY `SUBDEPARTMENT`.`SUBDEPCODE` "
                MySqlDataRd = MySqlCmd.ExecuteReader()
                If (MySqlDataRd.HasRows = True) Then
                    While (MySqlDataRd.Read)
                        If intHeader = 0 Then
                            Fs.WriteLine("            G Mohan Nursing Home & Hospital H")
                            Fs.WriteLine("(Unit of: Mohan Lal Community Health & Charitable Society)")
                            Fs.WriteLine("         B-2/4,A, YAMUNA VIHAR, DELHI-110053")
                            Fs.WriteLine(" Phone : 22913708, 22916862")
                            Fs.WriteLine("")
                            Fs.WriteLine("           From Date " + TxtFromDate.Value.ToString("dd/MMM/yyyy") + " To " + TxtToDate.Value.ToString("dd/MMM/yyyy"))
                            Fs.WriteLine("")
                            intHeader = 1
                        End If
                        If intX = 1 Then
                            If MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("iscancelled")) = True Then
                                Fs.WriteLine("                PRINT SERIAL NO.(CANCELLED) " + (intMainLoop + 1).ToString)
                            Else
                                Fs.WriteLine("                  PRINT SERIAL NO. " + (intMainLoop + 1).ToString)
                            End If

                            Fs.WriteLine("________________________________________________________________")
                            Fs.WriteLine("Receipt No    :" + MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("BILLINGID")).ToString + "            Receipt Date " + MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("BILLINGDATE1")).ToString)
                            Fs.WriteLine("Patient Id    :" + MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("PATIENTID")).ToString + "    Age & Sex " + MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Age")).ToString + " " + MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Sex")).ToString)
                            Fs.WriteLine("Name          :" + MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("PatientName")).ToString)
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

                        strBillCharge = objTotalCharge.ToString
                        strBillNetAmount = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("NetAmount")).ToString
                        strBillDiscount = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("Discount")).ToString

                        intX = intX + 1
                    End While
                End If
                MySqlDataRd.Close()
                strTot = "Total" + Space(62 - ("Total".Length) - Val(strBillCharge).ToString("#######.00").Length) + Mid(Val(strBillCharge).ToString("#######.00"), 1, 10)
                strTotalNet = "Net Payable" + Space(62 - ("Net Payable".Length) - Val(strBillNetAmount).ToString("#######.00").Length) + Mid(Val(strBillNetAmount).ToString("#######.00"), 1, 10)
                strDiscount = "Discount" + Space(62 - ("Discount".Length) - Val(strBillDiscount).ToString("#######.00").Length) + Mid(Val(strBillDiscount).ToString("#######.00"), 1, 10)
                Fs.WriteLine("________________________________________________________________")
                Fs.WriteLine(strTot)
                If Val(strBillDiscount) > 0 Then Fs.WriteLine(strDiscount)
                Fs.WriteLine(strTotalNet)
                Fs.WriteLine("________________________________________________________________")

                'strTot = "Total" + Space(62 - ("Total".Length) - Val(Me.txtTotalAmount.Text).ToString("#######.00").Length) + Mid(Val(Me.txtTotalAmount.Text).ToString("#######.00"), 1, 10)
                'strTotalNet = "Net Payable" + Space(62 - ("Net Payable".Length) - Val(Me.txtNetAmount.Text).ToString("#######.00").Length) + Mid(Val(Me.txtNetAmount.Text).ToString("#######.00"), 1, 10)
                'strDiscount = "Discount" + Space(62 - ("Discount".Length) - Val(Me.txtDiscountAmount.Text).ToString("#######.00").Length) + Mid(Val(Me.txtDiscountAmount.Text).ToString("#######.00"), 1, 10)
                'Fs.WriteLine("________________________________________________________________")
                'Fs.WriteLine(strTot)
                'If Val(Me.txtDiscountAmount.Text) > 0 Then Fs.WriteLine(strDiscount)
                'Fs.WriteLine(strTotalNet)
                'Fs.WriteLine("________________________________________________________________")
                'Fs.WriteLine("Received With Thanks A Sum of : ")
                'Fs.WriteLine(Mid(lblAmountInWord.Text, 1, 60))
                'Fs.WriteLine(Mid(lblAmountInWord.Text, 61, Len(lblAmountInWord.Text)).Trim)
                'Fs.WriteLine("Print Date: " + DateTime.Now.ToString("dd/MMM/yyyy hh:mm:ss tt"))

                'Fs.WriteLine("                                                  ______________")
                'Fs.WriteLine("                                                    Auth. Sign  ")
                'Fs.WriteLine("*********************GET WELL SOON******************************")
                Fs.WriteLine(vbCrLf)
                Fs.WriteLine("++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++")
                Fs.WriteLine(vbCrLf)

                'Fs.WriteLine(vbCrLf)
                'Fs.WriteLine(vbCrLf)
                'Fs.WriteLine(vbCrLf)
                'Fs.WriteLine(vbCrLf)
                'Fs.WriteLine(vbCrLf)
                'Fs.WriteLine(vbCrLf)
                'Fs.WriteLine("")

            Next
            PgBar.Value = PgBar.Maximum
            PgBar.Visible = False
            Dim objTotalServiceCharge As Object = Nothing
            Dim objTotalDiscount As Object = Nothing
            Dim objTotalPayable As Object = Nothing

            MySqlCmd.Connection = MySqlCon
            strType = String.Empty
            MySqlCmd.CommandText = "SELECT Sum(PatientBilling.CHARGE) As TotalCharge FROM PatientBilling Where Iscancelled=0 and BILLINGDATE Between  cdate('" + TxtFromDate.Value.ToString("dd/MMM/yyyy") + "')  and Cdate( '" + TxtToDate.Value.ToString("dd/MMM/yyyy") + "')"
            objTotalServiceCharge = MySqlCmd.ExecuteScalar()
            If IsNothing(objTotalServiceCharge) = True Then objTotalServiceCharge = "0"

            MySqlCmd.CommandText = "SELECT sum( ViewBillWiseNetPayment.TotalDiscount) as  TotDisc, Sum(ViewBillWiseNetPayment.TotalPayable) as TotPay FROM ViewBillWiseNetPayment Where Iscancelled=0 and BILLINGDATE Between  cdate('" + TxtFromDate.Value.ToString("dd/MMM/yyyy") + "')  and Cdate( '" + TxtToDate.Value.ToString("dd/MMM/yyyy") + "') "
            MySqlDataRd = MySqlCmd.ExecuteReader()
            If (MySqlDataRd.HasRows = True) Then
                MySqlDataRd.Read()
                Fs.WriteLine("_________________________________________________________________")
                Fs.WriteLine("________________________GRAND TOTAL______________________________")
                strTot = "Total" + Space(62 - ("Total".Length) - Val(objTotalServiceCharge.ToString).ToString("#######.00").Length) + Mid(Val(objTotalServiceCharge.ToString).ToString("#######.00"), 1, 10)
                strTotalNet = "Net Payable" + Space(62 - ("Net Payable".Length) - Val(MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("TotPay")).ToString).ToString("#######.00").Length) + Mid(Val(MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("TotPay")).ToString).ToString("#######.00"), 1, 10)
                strDiscount = "Discount" + Space(62 - ("Discount".Length) - Val(MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("TotDisc")).ToString).ToString("#######.00").Length) + Mid(Val(MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("TotDisc")).ToString).ToString("#######.00"), 1, 10)
                Fs.WriteLine(strTot)
                Fs.WriteLine(strDiscount)
                Fs.WriteLine(strTotalNet)
                Fs.WriteLine("")
                Fs.WriteLine(BILLING.WORD_FIVE_DIGIT(MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("TotPay")).ToString))
                Fs.WriteLine("")
                Fs.WriteLine("Note : Cancelled Bill Amount Has Not Been Included In Grand Total.")
                Fs.WriteLine("________________________GRAND TOTAL______________________________")
                Fs.WriteLine("_________________________________________________________________")
                MySqlDataRd.Close()
            End If
            Fs.WriteLine("Print Date: " + DateTime.Now.ToString("dd/MMM/yyyy hh:mm:ss tt"))
            Fs.WriteLine("")
            Fs.Close()
            Dim Fr As StreamReader = New StreamReader(Application.StartupPath + "\DayBill.txt")
            Me.txtPreview.Text = Fr.ReadToEnd()
            Fr.Close()
            CmdPrint.Enabled = True
            FsBat.WriteLine("Echo off")
            FsBat.WriteLine("Type DayBill.txt " + strPrinterPortConfig)
            FsBat.WriteLine("Exit")
            FsBat.Close()

        Catch Ex As Exception
            MsgBox(Ex.Message, MsgBoxStyle.Critical)
        Finally
            Try
                If D.HasExited = False Then D.Kill()
            Catch ex As Exception
            End Try
            MySqlCon.Dispose()
            MySqlCmd.Dispose()
            Prc.Dispose()
            If IsNothing(FsBat) = False Then FsBat.Dispose()
            If IsNothing(Fs) = False Then Fs.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txtPreview.Text = String.Empty
        Me.CmdPrint.Enabled = False
        PrintInDosMode()
        Me.CmdPrint.Enabled = True
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
                    strPrinterPortConfig = MySqlDataRd.GetValue(MySqlDataRd.GetOrdinal("printerport"))
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
End Class