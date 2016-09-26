Public Class Password
    Public isDiscountPassword As Boolean = False
    Public isCancelPassword As Boolean = False
    Public isDiscountCalled As Boolean = True

    Private Sub ComOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComOk.Click
        If (isDiscountCalled = True) Then
            If (TxtPassword.Text.Trim() = GetOthersPassword(True)) Then
                isDiscountPassword = True
            End If
        Else
            If (TxtPassword.Text.Trim() = GetOthersPassword(False)) Then
                isCancelPassword = True
            End If
        End If
        Me.Close()
    End Sub

    Private Sub ComCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComCancel.Click       
        Me.Close()
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

    Private Sub TxtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPassword.KeyPress
        If e.KeyChar = "'" Then
            e.Handled = True
        End If
        If Asc(e.KeyChar) = Keys.Enter Then ComOk_Click(e, New System.EventArgs())
    End Sub

    Private Sub TxtPassword_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtPassword.TextChanged

    End Sub
End Class