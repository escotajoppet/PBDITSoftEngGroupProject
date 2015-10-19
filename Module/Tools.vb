Imports System.Security.Cryptography
Imports System.Text

Module Tools
    Public Function rIndex(ByVal _dgv As DataGridView, ByVal _i As Integer) As Integer
        If _dgv.Rows.Count > 1 Then
            If _i = 0 Then
                rIndex = 0
            Else
                rIndex -= 1
            End If
        Else
            rIndex = -1
        End If
    End Function

    Public Function generateHash(ByVal _str As String) As String
        Dim md5Obj As MD5 = MD5.Create()
        Dim byteObj As Byte() = md5Obj.ComputeHash(Encoding.Default.GetBytes(_str))
        Dim builder As New StringBuilder()

        For i As Integer = 0 To byteObj.Length - 1
            builder.Append(byteObj(i).ToString("x2"))
        Next

        generateHash = builder.ToString
    End Function

    Public Function SimplePINEncryption(ByVal PIN As String) As String
        ' Encrypts/decrypts the PIN string using
        ' a simple ASCII value-swapping algorithm
        Dim strTempChar As String, idx As Integer

        'initialize variable
        strTempChar = ""

        'loop
        For idx = 1 To Len(PIN)
            If Asc(Mid$(PIN, idx, 1)) < 128 Then
                strTempChar = CType(Asc(Mid$(PIN, idx, 1)) + 128, String)
            ElseIf Asc(Mid$(PIN, idx, 1)) > 128 Then
                strTempChar = CType(Asc(Mid$(PIN, idx, 1)) - 128, String)
            End If

            Mid$(PIN, idx, 1) = Chr(CType(strTempChar, Integer))
        Next idx

        SimplePINEncryption = PIN
    End Function

    Public Sub populateCustomersDataGridView(ByVal _dgv As DataGridView, ByVal _records As Customer())
        Dim columns As String() = {"customersIDCol", "customersAccountNumberCol", "customersPinCol", "customersLastNameCol", "customersFirstNameCol", "customersMiddleNameCol", "customersAddressCol", "customersContactNumberCol", "customersBalanceCol"}
        Dim items As String() = {"id", "an", "pin", "ln", "fn", "mn", "ad", "cn", "bal"}
        Dim record As Hashtable
        Dim records As List(Of Hashtable) = New List(Of Hashtable)

        For Each rec In _records
            record = New Hashtable

            record.Add("id", rec.id)
            record.Add("an", rec.accountNumber)
            record.Add("pin", rec.pin)
            record.Add("ln", rec.lastName)
            record.Add("fn", rec.firstName)
            record.Add("mn", rec.middleName)
            record.Add("ad", rec.address)
            record.Add("cn", rec.contactNumber)
            record.Add("bal", rec.balance)

            records.Add(record)
        Next

        populateDGV(_dgv, columns, items, records.ToArray)
    End Sub

    Public Sub populateDGV(ByVal _dgv As DataGridView, ByVal _columns As String(), ByVal _items As String(), ByVal _records As Hashtable())
        Dim index As Integer = 0

        _dgv.Rows.Clear()
        _dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect

        For Each record In _records
            index = _dgv.Rows.Add

            For i As Integer = 0 To _columns.Length - 1
                _dgv.Item(_columns(i), index).Value = record.Item(_items(i))
            Next
        Next

        If _dgv.Rows.Count > 0 Then
            _dgv.CurrentCell.Selected = False
        End If
    End Sub
End Module
