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
End Class
