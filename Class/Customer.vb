Imports System.Data.OleDb

Public Class Customer
    Public Property id As Integer
    Public Property accountNumber As Integer
    Public Property lastName As String
    Public Property firstName As String
    Public Property middleName As String
    Public Property pin As String
    Public Property address As String
    Public Property contactNumber As String
    Public Property balance As Decimal

    Public Sub New(ByVal _id As Integer)
        Dim table As String = "customers"
        Dim fields As String = "[account_number], [pin], [last_name], [first_name], [middle_name], [address], [contact_number], [balance]"
        Dim condition As String = "[id]=" & _id

        Dim recordReader As OleDbDataReader = selectQuery(table, fields, condition)

        While recordReader.Read() = True
            Me.id = _id
            Me.accountNumber = Integer.Parse(recordReader.Item("account_number"))
            Me.pin = recordReader.Item("pin")
            Me.lastName = recordReader.Item("last_name")
            Me.firstName = recordReader.Item("first_name")
            Me.middleName = recordReader.Item("middle_name")
            Me.address = recordReader.Item("address")
            Me.contactNumber = recordReader.Item("contact_number")
            Me.balance = Decimal.Parse(recordReader.Item("balance").ToString)
        End While

        recordReader.Close()
    End Sub

    ' shared methods
    Public Shared Function findByAccountNumber(ByVal _accountNumber As Integer) As Customer
        findByAccountNumber = getCustomer("[account_number]=" & _accountNumber)
    End Function

    Public Shared Function all() As Customer()
        all = getCustomers("1")
    End Function

    Public Shared Function search(ByVal _condition As String) As Customer()
        search = getCustomers(_condition)
    End Function

    Public Shared Function addCustomer(ByVal _accountNumber As Integer, ByVal _pin As String, ByVal _lastName As String, ByVal _firstName As String, ByVal _middleName As String, ByVal _address As String, ByVal _contactNumber As String, ByVal _balance As Decimal) As String
        Dim table As String = "customers"
        Dim fields As String = "[account_number], [pin], [last_name], [first_name], [middle_name], [address], [contact_number], [balance]"
        Dim values As String = _accountNumber & ", '" & _pin & "', '" & _lastName & "', '" & _firstName & "', '" & _middleName & "', '" & _address & "', '" & _contactNumber & "', " & _balance

        If addQuery(table, fields, values) Then
            addCustomer = "Customer ADDED: " & _accountNumber
        Else
            addCustomer = "Error Adding Customer"
        End If
    End Function

    Public Shared Function generateAccountNumber() As Integer
        Dim table As String = "customers"
        Dim fields As String = "account_number"
        Dim accNumbers As List(Of Integer) = New List(Of Integer)

        Dim recordReader As OleDbDataReader = selectQuery(table, fields, "1")

        If recordReader.Read() = True Then
            accNumbers.Add(Integer.Parse(recordReader.Item("account_number").ToString))
        End If

        Dim an As Integer() = accNumbers.ToArray()

        If an.Length < 1 Then
            generateAccountNumber = 100000
        Else
            generateAccountNumber = an(an.Length - 1) + 1
        End If
    End Function

    Public Shared Function authenticated(ByVal _accountNumber As Integer, ByVal _pin As String) As String
        Dim recordReader As OleDbDataReader

        Dim table As String = "customers"
        Dim fields As String = "[id]"
        Dim condition As String = "[account_number]=" & _accountNumber.ToString & " AND [pin]='" & _pin & "'"

        recordReader = selectQuery(table, fields, condition)

        If recordReader.HasRows Then
            authenticated = ""
        Else
            authenticated = "Error Authentication: Invalid Account Number/Wrong PIN"
        End If

        recordReader.Close()
    End Function

    ' instance methods
    Public Function updateCustomer(ByVal _accountNumber As Integer, ByVal _lastName As String, ByVal _firstName As String, ByVal _middleName As String, ByVal _address As String, ByVal _contactNumber As String) As String
        Dim table As String = "customers"
        Dim fields As List(Of String) = {"account_number", "last_name", "first_name", "middle_name", "address", "contact_number"}.ToList()
        Dim values As List(Of String) = {_accountNumber.ToString, "'" & _lastName & "'", "'" & _firstName & "'", "'" & _middleName & "'", "'" & _address & "'", "'" & _contactNumber & "'"}.ToList()
        Dim condition As String = "[account_number]=" & Me.accountNumber

        If updateQuery(table, fields.ToArray, values.ToArray, condition) Then
            updateCustomer = "Customer UPDATED: " & Me.accountNumber
        Else
            updateCustomer = "Error Updating Customer"
        End If
    End Function

    Public Function deleteCustomer() As String
        Dim table As String = "customers"
        Dim condition As String = "[account_number]=" & Me.accountNumber

        If deleteQuery(table, condition) Then
            deleteCustomer = "Customer DELETED: " & Me.accountNumber
        Else
            deleteCustomer = "Error Deleting Customer"
        End If
    End Function

    Public Function withdraw(ByVal _amount As Decimal) As String
        If _amount > Me.balance Then
            withdraw = "Error cash withdrawal: Insufficient fund, please input smaller amount"
        Else
            If _amount > 20000 Then
                withdraw = "Error cash withdrawal: Exceeded withdrawal limit"
            ElseIf _amount <= 0 Then
                withdraw = "Error cash withdrawal: Invalid amount"
            Else
                Dim totalAmount As Decimal = Transaction.getTransactionTotalAmount(Me.accountNumber, "CASH WITHDRAWAL") + _amount

                If totalAmount <= 20000 Then
                    Me.balance -= _amount

                    If updateBalance() Then
                        Dim message = addTransaction("CASH WITHDRAWAL", totalAmount)

                        If message.ToLower.Contains("error") Then
                            withdraw = message
                        Else
                            withdraw = "Please take the money"
                        End If
                    Else
                        withdraw = "Error Cash Withdrawal"
                    End If
                Else
                    withdraw = "Error cash withdrawal: Total amount of withdrawal for the day exceeds maximum limit"
                End If
                
            End If
        End If
    End Function

    Public Function deposit(ByVal _amount As Decimal) As String
        If _amount <= 0 Then
            deposit = "Error cash deposit: Invalid deposit amount, please input an amount"
        Else
            If _amount > 50000 Then
                deposit = "Error cash deposit: Exceeded maximum deposit"
            Else
                Dim totalAmount As Decimal = Transaction.getTransactionTotalAmount(Me.accountNumber, "CASH DEPOSIT") + _amount

                If totalAmount <= 50000 Then
                    Me.balance += _amount

                    If updateBalance() Then
                        Dim message = addTransaction("CASH DEPOSIT", totalAmount)

                        If message.ToLower.Contains("error") Then
                            deposit = message
                        Else
                            deposit = "Please insert the deposit envelop"
                        End If
                    Else
                        deposit = "Error Cash Deposit"
                    End If
                Else
                    deposit = "Error cash deposit: Total amount of deposit for the day exceeds maximum limit"
                End If
            End If
        End If
    End Function

    Public Function changePin(ByVal _oldPin As Integer, ByVal _newPin As Integer) As String
        Dim oldPin As String = SimplePINEncryption(_oldPin)
        Dim newPin As String = SimplePINEncryption(_newPin)

        Dim table As String = "customers"
        Dim fields As String = "[pin]"
        Dim condition As String = "[account_number]=" & Me.accountNumber & " AND [pin]='" & oldPin & "'"

        Dim recordReader As OleDbDataReader = selectQuery(table, fields, condition)

        Dim pin As String = ""

        While recordReader.Read() = True
            pin = recordReader.Item("pin")
        End While

        If pin = "" Then
            changePin = "Error Changing PIN: Wrong PIN provided"
        Else
            Dim fields1 As String() = {"pin"}
            Dim values As String() = {"'" & newPin & "'"}

            changePin = updateQuery(table, fields1, values, condition)
        End If
    End Function

    ' private methods
    Private Function addTransaction(ByVal _type As String, ByVal _totalAmount As Decimal)
        Dim deytime As String() = Split(Date.Now.ToString("MM-dd-yyyy HH:mm:ss"), " ")
        addTransaction = Transaction.addTransaction(Me.accountNumber, _type, deytime(0), deytime(1), Me.balance, _totalAmount)
    End Function

    Private Shared Function getCustomers(ByVal _condition As String) As Customer()
        Dim table As String = "customers"
        Dim fields As String = "[id]"

        Dim recordReader As OleDbDataReader = selectQuery(table, fields, _condition)

        Dim customer As Customer
        Dim records As List(Of Customer) = New List(Of Customer)

        While recordReader.Read() = True
            customer = New Customer(recordReader.Item("id"))
            records.Add(customer)
        End While

        getCustomers = records.ToArray

        recordReader.Close()
    End Function

    Private Shared Function getCustomer(ByVal _condition As String) As Customer
        Dim table As String = "customers"
        Dim fields As String = "[id]"
        Dim id As String = "000000"

        Dim recordReader As OleDbDataReader = selectQuery(table, fields, _condition)

        While recordReader.Read() = True
            id = recordReader.Item("id")
        End While

        Dim customer As Customer = New Customer(Integer.Parse(id))

        getCustomer = customer

        recordReader.Close()
    End Function

    Private Function updateBalance() As Boolean
        Dim table As String = "customers"
        Dim fields As String() = {"balance"}
        Dim values As String() = {Me.balance}
        Dim condition As String = "[account_number]=" & Me.accountNumber

        updateBalance = updateQuery(table, fields, values, condition)
    End Function
End Class
