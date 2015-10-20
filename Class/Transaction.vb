Imports System.Data.OleDb

Class Transaction
    Public Property id As Integer
    Public Property customerAccountNumber As Integer
    Public Property transactionType As String
    Public Property transactionDate As String
    Public Property transactionTime As String
    Public Property transactionBalance As Decimal
    Public Property transactionTotalAmount As Decimal

    Public Sub New(ByVal _id As Integer)
        Dim table As String = "transactions"
        Dim fields As String = "[customer_account_number], [transaction_type], [transaction_date], [transaction_time], [transaction_balance], [transaction_total_amount]"
        Dim condition As String = "[id]=" & _id

        Dim recordReader As OleDbDataReader = selectQuery(table, fields, condition)

        While recordReader.Read() = True
            Me.id = _id
            Me.customerAccountNumber = Integer.Parse(recordReader.Item("customer_account_number"))
            Me.transactionType = recordReader.Item("transaction_type")
            Me.transactionDate = recordReader.Item("transaction_date")
            Me.transactionTime = recordReader.Item("transaction_time")
            Me.transactionBalance = recordReader.Item("transaction_balance")
            Me.transactionTotalAmount = recordReader.Item("transaction_total_amount")
        End While

        recordReader.Close()
    End Sub

    Public Shared Function addTransaction(ByVal _accountNumber As Integer, ByVal _type As String, ByVal _date As String, ByVal _time As String, ByVal _balance As Decimal, ByVal _total As Decimal) As String
        Dim table As String = "transactions"
        Dim fields As String = "[customer_account_number], [transaction_type], [transaction_date], [transaction_time], [transaction_balance], [transaction_total_amount]"
        Dim values As String = _accountNumber & ", '" & _type & "', '" & _date & "', '" & _time & "', " & _balance & ", " & _total

        If addQuery(table, fields, values) Then
            addTransaction = ""
        Else
            addTransaction = "Error Adding Transaction"
        End If
    End Function

    Public Shared Function getTransactionTotalAmount(ByVal _accountNumber As Integer, ByVal _type As String) As Decimal
        Dim table As String = "transactions"
        Dim fields As String = "[transaction_total_amount]"
        Dim condition As String = "[customer_account_number]=" & _accountNumber & " AND [transaction_date]='" & Date.Now.ToString("MM-dd-yyyy") & "' AND [transaction_type]='" & _type & "'"

        Dim recordReader As OleDbDataReader = selectQuery(table, fields, condition)
        Dim totals As List(Of Decimal) = New List(Of Decimal)

        While recordReader.Read() = True
            totals.Add(Decimal.Parse(recordReader.Item("transaction_total_amount")))
        End While

        Dim tAmounts As Decimal() = totals.ToArray

        If tAmounts.Length > 0 Then
            getTransactionTotalAmount = tAmounts(tAmounts.Length - 1)
        Else
            getTransactionTotalAmount = 0
        End If
    End Function

    Public Shared Function getTransactionForDay(ByVal _date As String, ByVal _type As String) As Transaction()
        Dim table As String = "transactions"
        Dim fields As String = "[id]"
        Dim condition As String = "[transaction_date]='" & _date & "'"

        If _type = "WITHDRAWAL AND DEPOSIT" Then
            condition &= ""
        Else
            condition &= " AND [transaction_type]='" & _type & "'"
        End If

        Dim recordReader As OleDbDataReader = selectQuery(table, fields, condition)

        Dim transaction As Transaction
        Dim transactions As List(Of Transaction) = New List(Of Transaction)

        While recordReader.Read() = True
            transaction = New Transaction(recordReader.Item("id"))
            transactions.Add(transaction)
        End While

        getTransactionForDay = transactions.ToArray

        recordReader.Close()
    End Function

    Public Shared Function getDates() As String()
        Dim table As String = "transactions"
        Dim fields As String = "[transaction_date]"
        Dim condition As String = "1"

        Dim recordReader As OleDbDataReader = selectDistinctQuery(table, fields, condition)

        Dim dates As List(Of String) = New List(Of String)

        While recordReader.Read() = True
            dates.Add(recordReader.Item("transaction_date"))
        End While

        getDates = dates.ToArray
    End Function
End Class
