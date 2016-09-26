Imports System.IO
Module BILLING


    Private Const REG_DWORD = 4&
    Private Const REG_SZ = 1    'Constant for a string variable type.
    Private Const HKEY_CURRENT_USER = &H80000001

    Private Declare Function RegCreateKey Lib "advapi32.dll" Alias _
       "RegCreateKeyA" (ByVal hKey As Long, ByVal lpSubKey As String, _
       ByVal phkResult As Long) As Long

    Private Declare Function RegSetValueEx Lib "advapi32.dll" Alias _
       "RegSetValueExA" (ByVal hKey As Long, ByVal lpValueName As String, _
       ByVal Reserved As Long, ByVal dwType As Long, ByVal lpData As Object, ByVal _
       cbData As Long) As Long

    Private Declare Function RegCloseKey Lib "advapi32.dll" _
       (ByVal hKey As Long) As Long


    Public Con As Odbc.OdbcConnection
    Public UserName As String
    Public UserCode As String
    Public CallerId As String = "Ria001"
    Public TextBoxGotFocusBackColor = Color.Honeydew
    Public TextBoxLostFocusBackColor = Color.White
    Public strPrinterPortConfig As String = String.Empty

    Public Function ExecuteSingleRowQuery(ByRef ActiveConnection As Odbc.OdbcConnection, ByVal QueryString As String, ByRef Transaction As Odbc.OdbcTransaction) As Odbc.OdbcDataReader
        Try
            Dim IdCmd As Odbc.OdbcCommand
            If Not IdCmd Is Nothing Then IdCmd.Dispose()
            IdCmd = New Odbc.OdbcCommand(QueryString, ActiveConnection)
            IdCmd.Transaction = Transaction
            ExecuteSingleRowQuery = IdCmd.ExecuteReader

        Catch Exc As Exception
            MsgBox("Error Occured While Execution." & ControlChars.CrLf & Err.Description)
        End Try
    End Function
    Public Function GetAccesscon() As Odbc.OdbcConnection
        Dim con As New Odbc.OdbcConnection
        Dim obj As Object
        Dim CnStr As String
        Static intTry As Integer = 0
        Try
            intTry = intTry + 1
            'CnStr = "DSN=BILLING;PWD=management;UID=admin;"
            CnStr = "DSN=BILLING;FIL=MS Access;MaxBufferSize=2048;PageTimeout=5;PWD=management;UID=admin;"
            con.ConnectionString = CnStr
            con.Open()
            GetAccesscon = con
        Catch ex As Exception
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
            If intTry < 5 Then
                obj = GetAccesscon()
            End If
            MsgBox(ex.Message)
            GetAccesscon = Nothing
        End Try
    End Function
    Public Function WORD_FIVE_DIGIT(ByVal Digits As Object) As String
        Dim WordPaise = String.Empty, Rupee, WordRupee As String
        Dim Paise As String = String.Empty
        Dim result As String = String.Empty

        If InStr(Trim(Digits), ".") <> 0 Then Rupee = Mid(Trim(Digits), 1, InStr(Trim(Digits), ".") - 1) Else Rupee = Digits
        WordRupee = Conver(Val(Rupee))
        If InStr(Trim(Digits), ".") <> 0 Then
            Paise = Mid(Trim(Digits), InStr(Trim(Digits), ".") + 1, Len(Trim(Digits)))
            WordPaise = Conver(Val(Mid(Paise, 1, 1)))
            WordPaise = WordPaise & "" & Conver(Val(Mid(Paise, 2, 1)))
        End If
        If Trim(WordPaise) <> String.Empty Then
            result = StrConv("Rupees " & WordRupee & "And Paise " & WordPaise & "Only.", vbProperCase)
        ElseIf Trim(WordPaise) = String.Empty Then
            result = StrConv("Rupees " & WordRupee & "Only.", vbProperCase)
        ElseIf Trim(WordPaise) = String.Empty And WordRupee = String.Empty Then
            result = String.Empty
        End If
        Return result
    End Function
    Function Conver(ByVal yournum As Double) As String
        Dim www(0 To 19) As String
        Dim mdd(0 To 9) As String
        Dim big(0 To 4) As String
        Dim number As String
        Dim numb As Double
        number = yournum
        www(0) = " "
        www(1) = "ONE "
        www(2) = "TWO "
        www(3) = "THREE "
        www(4) = "FOUR "
        www(5) = "FIVE "
        www(6) = "SIX "
        www(7) = "SEVEN "
        www(8) = "EIGHT "
        www(9) = "NINE "
        www(10) = "TEN "
        www(11) = "ELEVEN "
        www(12) = "TWELVE "
        www(13) = "THIRTEEN "
        www(14) = "FOURTEEN "
        www(15) = "FIFTEEN "
        www(16) = "SIXTEEN "
        www(17) = "SEVENTEEN "
        www(18) = "EIGHTEEN "
        www(19) = "NINTEEN "
        mdd(0) = ""
        mdd(1) = "TEN "
        mdd(2) = "TWENTY "
        mdd(3) = "THIRTY "
        mdd(4) = "FORTY "
        mdd(5) = "FIFTY "
        mdd(6) = "SIXTY "
        mdd(7) = "SEVENTY "
        mdd(8) = "EIGHTY "
        mdd(9) = "NINTY "
        big(0) = ""
        big(1) = "HUNDRED "
        big(2) = "THOUSAND "
        big(3) = "LAKH "
        big(4) = "CRORE "
        numb = CType(String.Format(number, "#########.00"), Double)
        Dim st_rtn As String
        Dim w_cc As String
        Dim w_c As Double
        Dim wws As String
        Dim ccc As String
        Dim mmm As String
        Dim w_nn As Decimal
        Dim w_nns As String


        st_rtn = ""
        w_cc = 4
        w_c = 10000000
        Do While numb > 0
            w_nn = (numb / w_c)
            w_nn = Int(w_nn)
            If w_nn > 0 Then
                If w_c < 1 Then
                    st_rtn = st_rtn + "POINT "
                End If
                ccc = big(String.Format(w_cc, "0"))

                If w_nn < 20 Then
                    wws = www(LTrim(String.Format(w_nn, "##")))
                    st_rtn = st_rtn & wws & ccc
                Else
                    w_nns = String.Format(w_nn, "##")
                    mmm = mdd(Mid(w_nns, 1, 1))
                    wws = www(Mid(w_nns, 2, 1))
                    st_rtn = st_rtn & mmm & wws & ccc
                End If
            End If
            'Text2 = st_rtn
            numb = String.Format(numb - w_nn * w_c, "########.00")
            If numb <> 0 Then
                w_c = String.Format(IIf(w_c <> 1000, w_c / 100, w_c / 10), "#########.00")
                w_cc = IIf(w_cc > 0, w_cc - 1, w_cc)
                If Len(st_rtn) > 0 And numb / w_c = Int(numb / w_c) Then
                    st_rtn = st_rtn '+ "AND "
                End If
            End If
            'MsgBox w_c & "< w_c -numb>" & numb
        Loop
        st_rtn = st_rtn '+ "ONLY"
        If Trim(st_rtn) = String.Empty Then
            st_rtn = "ZERO "
        End If
        Conver = st_rtn
    End Function

    Public Sub DSN()
        Dim DataSourceName As String
        Dim DBQ As String
        Dim Description As String
        Dim DriverPath As String
        Dim DriverId As Long
        Dim DriverName As String
        Dim User As String
        Dim PWD As String

        Dim lResult As Long
        Dim hKeyHandle As Long
        Dim hKeyHandSub As Long

        'Specify the DSN parameters.

        DataSourceName = "Amit"
        DBQ = "E:\Company\HBS\HBS\bin\Debug\billing.mdb"
        Description = "BILLING"
        DriverPath = "C:\windows\System\odbcjt32.dll"
        PWD = ""
        DriverId = 19
        User = "admin"
        DriverName = "MIcrosoft Access Driver (*.mdb)"

        'Create the new DSN key.

        lResult = RegCreateKey(HKEY_CURRENT_USER, "SOFTWARE\ODBC\ODBC.INI\" & _
             DataSourceName, hKeyHandle)

        'Set the values of the new DSN key.

        lResult = RegSetValueEx(hKeyHandle, "DBQ", 0&, REG_SZ, DBQ, Len(DBQ))
        lResult = RegSetValueEx(hKeyHandle, "Description", 0&, REG_SZ, Description, Len(Description))
        lResult = RegSetValueEx(hKeyHandle, "Driver", 0&, REG_SZ, DriverPath, Len(DriverPath))
        lResult = RegSetValueEx(hKeyHandle, "DriverID", 0&, REG_DWORD, 25, 4)
        lResult = RegSetValueEx(hKeyHandle, "FIL", 0&, REG_SZ, "MS Access", 9)
        lResult = RegSetValueEx(hKeyHandle, "PWD", 0&, REG_SZ, PWD, Len(PWD))
        lResult = RegSetValueEx(hKeyHandle, "SafeTransactions", 0&, REG_DWORD, 0, 4)
        lResult = RegSetValueEx(hKeyHandle, "UID", 0&, REG_SZ, User, Len(User))
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Open a new key as follows
        lResult = RegCreateKey(HKEY_CURRENT_USER, "SOFTWARE\ODBC\ODBC.INI\" & _
             DataSourceName & "\Engines\Jet", hKeyHandSub)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        lResult = RegSetValueEx(hKeyHandSub, "ImplicitCommitSync", 0&, REG_SZ, _
            "", 0)
        lResult = RegSetValueEx(hKeyHandSub, "MaxBufferSize", 0&, REG_DWORD, _
           2048, 4)
        lResult = RegSetValueEx(hKeyHandSub, "PageTimeout", 0&, REG_DWORD, _
           5, 4)
        lResult = RegSetValueEx(hKeyHandSub, "Threads", 0&, REG_DWORD, _
           3, 4)
        lResult = RegSetValueEx(hKeyHandSub, "UserCommitSync", 0&, REG_SZ, _
            "Yes", 3)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Close the new Sub key.
        lResult = RegCloseKey(hKeyHandSub)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'Close the new DSN key.

        lResult = RegCloseKey(hKeyHandle)

        'Open ODBC Data Sources key to list the new DSN in the ODBC Manager.
        'Specify the new value.
        'Close the key.

        lResult = RegCreateKey(HKEY_CURRENT_USER, _
           "SOFTWARE\ODBC\ODBC.INI\ODBC Data Sources", hKeyHandle)
        lResult = RegSetValueEx(hKeyHandle, DataSourceName, 0&, REG_SZ, _
            DriverName, Len(DriverName))
        lResult = RegCloseKey(hKeyHandle)
    End Sub
    Public Sub PrintUserCollection(ByVal DGUserWise As System.Windows.Forms.DataGridView, ByVal TxtFromDate As Date, ByVal TxttoDate As Date, ByVal strHeader As String)
        If DGUserWise.RowCount = 0 Then
            MsgBox("Nothing To Print", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim fPath As String
        Dim intRow As Integer

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
        Dim StrUserNm As String = String.Empty
        Dim StrColDate As String = String.Empty
        Dim StrAmount As String = String.Empty
        Dim StrDisc As String = String.Empty
        Dim StrNetAmount As String = String.Empty
        Dim strFinal As String = String.Empty
        Dim strTotalCollection As String = String.Empty
        Dim D As System.Diagnostics.Process

        If File.Exists(Application.StartupPath + "\UserCol.txt") = True Then File.Delete(Application.StartupPath + "\UserCol.txt")
        If File.Exists(Application.StartupPath + "\UserCol.bat") = True Then File.Delete(Application.StartupPath + "\UserCol.bat")
        Dim FsBat As StreamWriter = New StreamWriter(Application.StartupPath + "\UserCol.bat")
        Dim Fs As StreamWriter = New StreamWriter(Application.StartupPath + "\UserCol.txt")
        Dim Prc As New System.Diagnostics.Process
        Try


            For intRow = 0 To DGUserWise.RowCount - 1
                StrUserNm = DGUserWise.Rows(intRow).Cells(0).Value.ToString.Trim
                StrColDate = DGUserWise.Rows(intRow).Cells(1).Value.ToString.Trim
                StrAmount = DGUserWise.Rows(intRow).Cells(2).Value.ToString.Trim
                StrDisc = DGUserWise.Rows(intRow).Cells(3).Value.ToString.Trim
                StrNetAmount = DGUserWise.Rows(intRow).Cells(4).Value.ToString.Trim
                strTotalCollection = (Val(strTotalCollection) + StrNetAmount).ToString

                If intX = 1 Then
                    Fs.WriteLine("            G Mohan Nursing Home & Hospital H")
                    Fs.WriteLine("(Unit of: Mohan Lal Community Health & Charitable Society)")
                    Fs.WriteLine("         B-2/4,A, YAMUNA VIHAR, DELHI-110053")
                    Fs.WriteLine(" Phone : 22913708, 22916862")
                    Fs.WriteLine("")
                    Fs.WriteLine("                 User Collection (" + strHeader + ") ")
                    Fs.WriteLine("")
                    Fs.WriteLine("From Date " + TxtFromDate.ToString("dd/MMM/yyyy") + " To Date " + TxttoDate.ToString("dd/MMM/yyyy"))
                    Fs.WriteLine("================================================================")
                    Fs.WriteLine("User Name |   Date    |   TotAmount | Discount | Net Amount    |")
                    Fs.WriteLine("================================================================")
                End If
                Fs.WriteLine((intRow + 1).ToString + ". " + StrUserNm)
                strFinal = Space(Len("User Name  ")) + StrColDate
                StrAmount = Val(StrAmount).ToString("##########.00")
                StrAmount = Space(14 - Len(StrAmount)) + StrAmount
                strFinal = strFinal + StrAmount

                StrDisc = Val(StrDisc).ToString("#########0.00")
                StrDisc = Space(10 - Len(StrDisc)) + StrDisc
                strFinal = strFinal + StrDisc

                StrNetAmount = Val(StrNetAmount).ToString("#########0.00")
                StrNetAmount = Space(16 - Len(StrNetAmount)) + StrNetAmount
                strFinal = strFinal + StrNetAmount
                Fs.WriteLine(strFinal)
                Fs.WriteLine("________________________________________________________________")
                If intRow = DGUserWise.RowCount - 1 Then
                    strTotalCollection = "Total Collection     " + Val(strTotalCollection).ToString("###########0.00")
                    strTotalCollection = Space(62 - Len(strTotalCollection)) + strTotalCollection
                    Fs.WriteLine("")
                    Fs.WriteLine(strTotalCollection)
                    Fs.WriteLine("________________________________________________________________")
                End If


                intX = intX + 1
            Next
            Fs.WriteLine("Print Date & Time " + DateTime.Now.ToString("dd/MMM/yyyy hh:mm tt"))
            Fs.WriteLine("")
            Fs.WriteLine("********************* END of REPORT*****************************")
            Fs.WriteLine(vbCrLf)
            Fs.WriteLine(vbCrLf)
            Fs.WriteLine(vbCrLf)
            Fs.WriteLine(vbCrLf)
            Fs.WriteLine(vbCrLf)
            Fs.WriteLine(vbCrLf)
            Fs.WriteLine("")
            Fs.Close()
            FsBat.WriteLine("Echo off")
            FsBat.WriteLine("Type UserCol.txt " + strPrinterPortConfig)
            FsBat.WriteLine("Exit")
            FsBat.Close()
            Prc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            Prc.StartInfo.FileName = Application.StartupPath + "\UserCol.bat"
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
            Prc.Dispose()
            If IsNothing(FsBat) = False Then FsBat.Dispose()
            If IsNothing(Fs) = False Then Fs.Dispose()
        End Try
    End Sub

    Public Sub PrintDepartmentCollection(ByVal DGUserWise As System.Windows.Forms.DataGridView, ByVal TxtFromDate As Date, ByVal TxttoDate As Date, ByVal strHeader As String)
        If DGUserWise.RowCount = 0 Then
            MsgBox("Nothing To Print", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim fPath As String
        Dim intRow As Integer

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
        Dim StrUserNm As String = String.Empty
        Dim StrColDate As String = String.Empty
        Dim StrAmount As String = String.Empty
        Dim StrDisc As String = String.Empty
        Dim StrNetAmount As String = String.Empty
        Dim strFinal As String = String.Empty
        Dim strTotalCollection As String = String.Empty
        Dim D As System.Diagnostics.Process

        If File.Exists(Application.StartupPath + "\DepCol.txt") = True Then File.Delete(Application.StartupPath + "\DepCol.txt")
        If File.Exists(Application.StartupPath + "\DepCol.bat") = True Then File.Delete(Application.StartupPath + "\DepCol.bat")
        Dim FsBat As StreamWriter = New StreamWriter(Application.StartupPath + "\DepCol.bat")
        Dim Fs As StreamWriter = New StreamWriter(Application.StartupPath + "\DepCol.txt")
        Dim Prc As New System.Diagnostics.Process
        Try


            For intRow = 0 To DGUserWise.RowCount - 1
                StrUserNm = DGUserWise.Rows(intRow).Cells(2).Value.ToString.Trim
                StrColDate = DGUserWise.Rows(intRow).Cells(3).Value.ToString.Trim
                StrAmount = DGUserWise.Rows(intRow).Cells(4).Value.ToString.Trim
                StrDisc = DGUserWise.Rows(intRow).Cells(5).Value.ToString.Trim
                StrNetAmount = DGUserWise.Rows(intRow).Cells(6).Value.ToString.Trim
                strTotalCollection = (Val(strTotalCollection) + StrNetAmount).ToString

                If intX = 1 Then
                    Fs.WriteLine("            G Mohan Nursing Home & Hospital H")
                    Fs.WriteLine("(Unit of: Mohan Lal Community Health & Charitable Society)")
                    Fs.WriteLine("         B-2/4,A, YAMUNA VIHAR, DELHI-110053")
                    Fs.WriteLine(" Phone : 22913708, 22916862")
                    Fs.WriteLine("")
                    Fs.WriteLine("           Department Wise Collection (" + strHeader + ") ")
                    Fs.WriteLine("")
                    Fs.WriteLine("From Date " + TxtFromDate.ToString("dd/MMM/yyyy") + " To Date " + TxttoDate.ToString("dd/MMM/yyyy"))
                    Fs.WriteLine("================================================================")
                    Fs.WriteLine("Srv. Name |   Date    |   TotAmount | Discount | Net Amount    |")
                    Fs.WriteLine("================================================================")
                End If
                Fs.WriteLine((intRow + 1).ToString + ". " + StrUserNm)
                strFinal = Space(Len("User Name  ")) + StrColDate
                StrAmount = Val(StrAmount).ToString("##########.00")
                StrAmount = Space(14 - Len(StrAmount)) + StrAmount
                strFinal = strFinal + StrAmount

                StrDisc = Val(StrDisc).ToString("#########0.00")
                StrDisc = Space(10 - Len(StrDisc)) + StrDisc
                strFinal = strFinal + StrDisc

                StrNetAmount = Val(StrNetAmount).ToString("#########0.00")
                StrNetAmount = Space(16 - Len(StrNetAmount)) + StrNetAmount
                strFinal = strFinal + StrNetAmount
                Fs.WriteLine(strFinal)
                Fs.WriteLine("________________________________________________________________")
                If intRow = DGUserWise.RowCount - 1 Then
                    strTotalCollection = "Total Collection     " + Val(strTotalCollection).ToString("###########0.00")
                    strTotalCollection = Space(62 - Len(strTotalCollection)) + strTotalCollection
                    Fs.WriteLine("")
                    Fs.WriteLine(strTotalCollection)
                    Fs.WriteLine("________________________________________________________________")
                End If


                intX = intX + 1
            Next
            Fs.WriteLine("Print Date & Time " + DateTime.Now.ToString("dd/MMM/yyyy hh:mm tt"))
            Fs.WriteLine("")
            Fs.WriteLine("********************* END of REPORT*****************************")
            Fs.WriteLine(vbCrLf)
            Fs.WriteLine(vbCrLf)
            Fs.WriteLine(vbCrLf)
            Fs.WriteLine(vbCrLf)
            Fs.WriteLine(vbCrLf)
            Fs.WriteLine(vbCrLf)
            Fs.WriteLine("")
            Fs.Close()
            FsBat.WriteLine("Echo off")
            FsBat.WriteLine("Type DepCol.txt " + strPrinterPortConfig)
            FsBat.WriteLine("Exit")
            FsBat.Close()
            Prc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            Prc.StartInfo.FileName = Application.StartupPath + "\DepCol.bat"
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
            Prc.Dispose()
            If IsNothing(FsBat) = False Then FsBat.Dispose()
            If IsNothing(Fs) = False Then Fs.Dispose()
        End Try
    End Sub
    Public Sub PrintDepartmentCollectionReceiptWise(ByVal DGUserWise As System.Windows.Forms.DataGridView, ByVal TxtFromDate As Date, ByVal TxttoDate As Date, ByVal strHeader As String)
        If DGUserWise.RowCount = 0 Then
            MsgBox("Nothing To Print", MsgBoxStyle.Information)
            Exit Sub
        End If

        Dim fPath As String
        Dim intRow As Integer

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
        Dim StrUserNm As String = String.Empty
        Dim StrColDate As String = String.Empty
        Dim StrAmount As String = String.Empty
        Dim StrDisc As String = String.Empty
        Dim StrNetAmount As String = String.Empty
        Dim strFinal As String = String.Empty
        Dim strTotalCollection As String = String.Empty
        Dim strReceiptNo As String = String.Empty
        Dim D As System.Diagnostics.Process

        If File.Exists(Application.StartupPath + "\DepCol.txt") = True Then File.Delete(Application.StartupPath + "\DepCol.txt")
        If File.Exists(Application.StartupPath + "\DepCol.bat") = True Then File.Delete(Application.StartupPath + "\DepCol.bat")
        Dim FsBat As StreamWriter = New StreamWriter(Application.StartupPath + "\DepCol.bat")
        Dim Fs As StreamWriter = New StreamWriter(Application.StartupPath + "\DepCol.txt")
        Dim Prc As New System.Diagnostics.Process
        Try


            For intRow = 0 To DGUserWise.RowCount - 1
                strReceiptNo = DGUserWise.Rows(intRow).Cells(0).Value.ToString.Trim
                StrUserNm = DGUserWise.Rows(intRow).Cells(2).Value.ToString.Trim
                StrColDate = DGUserWise.Rows(intRow).Cells(3).Value.ToString.Trim
                StrAmount = DGUserWise.Rows(intRow).Cells(4).Value.ToString.Trim
                StrDisc = DGUserWise.Rows(intRow).Cells(5).Value.ToString.Trim
                StrNetAmount = DGUserWise.Rows(intRow).Cells(6).Value.ToString.Trim
                strTotalCollection = (Val(strTotalCollection) + StrNetAmount).ToString

                If intX = 1 Then
                    Fs.WriteLine("            G Mohan Nursing Home & Hospital H")
                    Fs.WriteLine("(Unit of: Mohan Lal Community Health & Charitable Society)")
                    Fs.WriteLine("         B-2/4,A, YAMUNA VIHAR, DELHI-110053")
                    Fs.WriteLine(" Phone : 22913708, 22916862")
                    Fs.WriteLine("")
                    Fs.WriteLine("           Department Wise Collection (" + strHeader + ") ")
                    Fs.WriteLine("")
                    Fs.WriteLine("From Date " + TxtFromDate.ToString("dd/MMM/yyyy") + " To Date " + TxttoDate.ToString("dd/MMM/yyyy"))
                    Fs.WriteLine("================================================================")
                    Fs.WriteLine("Srv. Name |   Date    |   TotAmount | Discount | Net Amount    |")
                    Fs.WriteLine("================================================================")
                End If
                Fs.WriteLine(strReceiptNo + " " + StrUserNm)
                strFinal = Space(Len("User Name  ")) + StrColDate
                StrAmount = Val(StrAmount).ToString("##########.00")
                StrAmount = Space(14 - Len(StrAmount)) + StrAmount
                strFinal = strFinal + StrAmount

                StrDisc = Val(StrDisc).ToString("#########0.00")
                StrDisc = Space(10 - Len(StrDisc)) + StrDisc
                strFinal = strFinal + StrDisc

                StrNetAmount = Val(StrNetAmount).ToString("#########0.00")
                StrNetAmount = Space(16 - Len(StrNetAmount)) + StrNetAmount
                strFinal = strFinal + StrNetAmount
                Fs.WriteLine(strFinal)
                Fs.WriteLine("________________________________________________________________")
                If intRow = DGUserWise.RowCount - 1 Then
                    strTotalCollection = "Total Collection     " + Val(strTotalCollection).ToString("###########0.00")
                    strTotalCollection = Space(62 - Len(strTotalCollection)) + strTotalCollection
                    Fs.WriteLine("")
                    Fs.WriteLine(strTotalCollection)
                    Fs.WriteLine("________________________________________________________________")
                End If


                intX = intX + 1
            Next
            Fs.WriteLine("Print Date & Time " + DateTime.Now.ToString("dd/MMM/yyyy hh:mm tt"))
            Fs.WriteLine("")
            Fs.WriteLine("********************* END of REPORT*****************************")
            Fs.WriteLine(vbCrLf)
            Fs.WriteLine(vbCrLf)
            Fs.WriteLine(vbCrLf)
            Fs.WriteLine(vbCrLf)
            Fs.WriteLine(vbCrLf)
            Fs.WriteLine(vbCrLf)
            Fs.WriteLine("")
            Fs.Close()
            FsBat.WriteLine("Echo off")
            FsBat.WriteLine("Type DepCol.txt " + strPrinterPortConfig)
            FsBat.WriteLine("Exit")
            FsBat.Close()
            Prc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            Prc.StartInfo.FileName = Application.StartupPath + "\DepCol.bat"
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
            Prc.Dispose()
            If IsNothing(FsBat) = False Then FsBat.Dispose()
            If IsNothing(Fs) = False Then Fs.Dispose()
        End Try
    End Sub

    Public Sub GetPrinterPort()
        Dim MySqlCon As New Odbc.OdbcConnection
        Dim MySqlDataRd As Odbc.OdbcDataReader
        Dim MySqlCmd As New Odbc.OdbcCommand

        Try
            MySqlCon = GetAccesscon()
            MySqlCmd.Connection = MySqlCon
            MySqlCmd.CommandText = ""
            MySqlCmd.CommandText = " SELECT printerport From HBSCONFIG"
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
End Module
