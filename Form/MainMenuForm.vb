Imports System.Data.OleDb

Public Class mainMenuForm
    Dim rowIndex As Integer
    Dim selectedId As String

    Private Sub mainMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Administrator.generateInitialAdmin()

        welcomeGB.Show()
        authenticatedGB.Hide()
        welcomeAdminGB.Show()
        adminGB.Hide()
    End Sub

    ' CUSTOMERS
    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim accountNumber As Integer = Integer.Parse(loginAccountNumberTB.Text)
        Dim pin As String = SimplePINEncryption(loginPinTB.Text)
        Dim message As String = Customer.authenticated(accountNumber, pin)

        If message = "" Then
            loginAccountNumberTB.Clear()
            loginPinTB.Clear()

            authenticatedGB.Text = accountNumber
            checkBalanceGB.Hide()
            depositGB.Hide()
            withdrawGB.Hide()
            changePinGB.Hide()
            blankGB.Show()

            welcomeGB.Hide()
            authenticatedGB.Show()
        Else
            MsgBox(message, MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub checkBalanceBtn_Click(sender As Object, e As EventArgs) Handles checkBalanceBtn.Click
        Dim customer As Customer = customer.findByAccountNumber(Integer.Parse(authenticatedGB.Text))

        balanceLbl.Text = "Your Balance as of " & Date.Now.ToString("MMMM dd, yyyy HH:mm:ss") & " is:" & vbCrLf & vbCrLf & "        Php " & customer.balance

        resetFields()

        checkBalanceGB.Show()
        checkBalanceBtn.Enabled = False
    End Sub

    Private Sub cashDepositBtn_Click(sender As Object, e As EventArgs) Handles cashDepositBtn.Click
        Dim remainingAmount As Decimal = 50000 - Transaction.getTransactionTotalAmount(authenticatedGB.Text, "CASH DEPOSIT")

        depositLbl.Text = "Amount allowed to deposit for the day: Php "
        depositLbl.Text &= remainingAmount

        If remainingAmount <= 0 Then
            depositBtn.Enabled = False
        End If

        resetFields()

        depositGB.Show()
        cashDepositBtn.Enabled = False
    End Sub

    Private Sub cashWithdrawalBtn_Click(sender As Object, e As EventArgs) Handles cashWithdrawalBtn.Click
        Dim remainingAmount As Decimal = 20000 - Transaction.getTransactionTotalAmount(authenticatedGB.Text, "CASH WITHDRAWAL")

        withdrawLbl.Text = "Amount allowed to withdraw for the day: Php "
        withdrawLbl.Text &= remainingAmount

        If remainingAmount <= 0 Then
            withdrawBtn.Enabled = False
        End If

        resetFields()

        withdrawGB.Show()
        cashWithdrawalBtn.Enabled = False
    End Sub

    Private Sub changePinBtn_Click(sender As Object, e As EventArgs) Handles changePinBtn.Click
        resetFields()

        changePinGB.Show()
        changePinBtn.Enabled = False
    End Sub

    Private Sub clearWithdrawFieldBtn_Click(sender As Object, e As EventArgs) Handles clearWithdrawFieldBtn.Click
        withdrawAmountTB.Clear()
    End Sub

    Private Sub withdrawBtn_Click(sender As Object, e As EventArgs) Handles withdrawBtn.Click
        If IsNumeric(withdrawAmountTB.Text) Then
            Dim amount As Decimal = Decimal.Parse(withdrawAmountTB.Text)

            Dim customer As Customer = customer.findByAccountNumber(Integer.Parse(authenticatedGB.Text))
            Dim message As String = customer.withdraw(amount)

            If message.ToLower.Contains("error") Then
                MsgBox(message, MsgBoxStyle.Critical)
            Else
                message &= vbCrLf & "Your Balance Is now: Php " & customer.balance
                MsgBox(message, MsgBoxStyle.Information)
                endTransaction()
            End If
        Else
            MsgBox("Error: Invalid format of amount", MsgBoxStyle.Critical)
        End If

        withdrawAmountTB.Clear()
    End Sub

    Private Sub depositBtn_Click(sender As Object, e As EventArgs) Handles depositBtn.Click
        If IsNumeric(depositAmountTB.Text) Then
            Dim amount As Decimal = Decimal.Parse(depositAmountTB.Text)

            Dim customer As Customer = customer.findByAccountNumber(Integer.Parse(authenticatedGB.Text))
            Dim message As String = customer.deposit(amount)

            If message.ToLower.Contains("error") Then
                MsgBox(message, MsgBoxStyle.Critical)
            Else
                message &= vbCrLf & "Your Balance Is now: Php " & customer.balance
                MsgBox(message, MsgBoxStyle.Information)
                endTransaction()
            End If
        Else
            MsgBox("Error: Invalid format of amount", MsgBoxStyle.Critical)
        End If

        depositAmountTB.Clear()
    End Sub

    Private Sub endTransactionBtn_Click(sender As Object, e As EventArgs) Handles endTransactionBtn.Click
        endTransaction()
    End Sub

    Private Sub endTransaction()
        authenticatedGB.Text = ""
        resetFields()

        welcomeGB.Show()
        authenticatedGB.Hide()
    End Sub

    Private Sub resetFields()
        checkBalanceGB.Hide()
        depositGB.Hide()
        withdrawGB.Hide()
        blankGB.Hide()
        changePinGB.Hide()

        checkBalanceBtn.Enabled = True
        cashDepositBtn.Enabled = True
        cashWithdrawalBtn.Enabled = True
        changePinBtn.Enabled = True

        oldPinTB.Clear()
        newPinTB.Clear()
        newPin2TB.Clear()

        depositAmountTB.Clear()
        withdrawAmountTB.Clear()
    End Sub

    Private Sub depositClearBtn_Click(sender As Object, e As EventArgs) Handles depositClearBtn.Click
        depositAmountTB.Clear()
    End Sub

    Private Sub confirmChangePinBtn_Click(sender As Object, e As EventArgs) Handles confirmChangePinBtn.Click
        If newPinTB.Text <> newPin2TB.Text Then
            MsgBox("Error: PINs don't match", MsgBoxStyle.Critical)
        Else
            If IsNumeric(newPinTB.Text) Then
                Dim customer As Customer = customer.findByAccountNumber(authenticatedGB.Text)

                Dim message As String = customer.changePin(Integer.Parse(oldPinTB.Text), Integer.Parse(newPinTB.Text))

                If message.ToLower.Contains("error") Then
                    MsgBox(message, MsgBoxStyle.Critical)
                Else
                    MsgBox(authenticatedGB.Text & " sucessfully changed PIN", MsgBoxStyle.Information)
                    endTransaction()
                End If
            Else
                MsgBox("Error: PIN should be numeric", MsgBoxStyle.Critical)
            End If
        End If

        oldPinTB.Clear()
        newPinTB.Clear()
        newPin2TB.Clear()
    End Sub


    ' ADMINSTRATORS
    Private Sub adminLogInBtn_Click(sender As Object, e As EventArgs) Handles adminLogInBtn.Click
        Dim username As String = loginUsernameTB.Text
        Dim password As String = generateHash(loginPasswordTB.Text)

        Dim message As String = Administrator.authenticated(username, password)

        If message = "" Then
            loginUsernameTB.Clear()
            loginPasswordTB.Clear()

            welcomeAdminGB.Hide()
            adminGB.Show()
            adminBlankGB.Show()
            resetPinGB.Hide()
            addAdminGB.Hide()
            transactionReportGB.Hide()

            byCB.SelectedItem = "Account Number"
        Else
            MsgBox(message, MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub manageCustomersBtn_Click(sender As Object, e As EventArgs) Handles manageCustomersBtn.Click
        customersCMSForm.Show()
        Me.Hide()
    End Sub

    Private Sub resetPinBtn_Click(sender As Object, e As EventArgs) Handles resetPinBtn.Click
        resetPinGB.Show()
        addAdminGB.Hide()
        adminBlankGB.Hide()
        transactionReportGB.Hide()

        resetPinBtn.Enabled = False
        newAdminBtn.Enabled = True
        trasactionReportBtn.Enabled = True

        If searchCustomerTB.Text = "" Then
            populateCustomersDataGridView(customersDGV, Customer.all)
        End If
    End Sub

    Private Sub newAdminBtn_Click(sender As Object, e As EventArgs) Handles newAdminBtn.Click
        resetPinGB.Hide()
        addAdminGB.Show()
        adminBlankGB.Hide()
        transactionReportGB.Hide()

        resetPinBtn.Enabled = True
        newAdminBtn.Enabled = False
        trasactionReportBtn.Enabled = True
    End Sub

    Private Sub trasactionReportBtn_Click(sender As Object, e As EventArgs) Handles trasactionReportBtn.Click
        resetPinGB.Hide()
        addAdminGB.Hide()
        adminBlankGB.Hide()
        transactionReportGB.Show()

        resetPinBtn.Enabled = True
        newAdminBtn.Enabled = True
        trasactionReportBtn.Enabled = False

        datesCB.Items.Clear()

        Dim deyts As String() = Transaction.getDates()

        For Each deyt In deyts
            datesCB.Items.Add(Date.Parse(deyt).ToString("MMMM dd, yyyy"))
        Next

        datesCB.SelectedIndex = 0
        transactionsCB.SelectedIndex = 0
    End Sub

    Private Sub logOutBtn_Click(sender As Object, e As EventArgs) Handles logOutBtn.Click
        adminGB.Hide()
        welcomeAdminGB.Show()

        resetPinBtn.Enabled = True
        newAdminBtn.Enabled = True
        trasactionReportBtn.Enabled = True
    End Sub

    Private Sub addAdminBtn_Click(sender As Object, e As EventArgs) Handles addAdminBtn.Click
        Dim message As String = Administrator.addAdministrator(newUsernameTB.Text, generateHash(newPasswordTB.Text))

        If message.ToLower.Contains("error") Then
            MsgBox(message, MsgBoxStyle.Critical)
        Else
            MsgBox(message, MsgBoxStyle.Information)

            newUsernameTB.Clear()
            newPasswordTB.Clear()
        End If
    End Sub

    Private Sub searchCustomerTB_KeyUp(sender As Object, e As KeyEventArgs) Handles searchCustomerTB.KeyUp
        Dim keyword As String = searchCustomerTB.Text
        Dim field As String = byCB.SelectedItem.ToString
        Dim condition As String

        If keyword.Length > 2 Then
            condition = "[" & field.Replace(" ", "_").ToLower & "] LIKE '%" & keyword & "%'"
        Else
            condition = "1"
        End If

        populateCustomersDataGridView(customersDGV, Customer.search(condition))
    End Sub

    Private Sub customersDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles customersDGV.CellClick
        rowIndex = e.RowIndex

        If rowIndex > -1 Then
            selectedId = customersDGV.Item("customersIDCol", rowIndex).Value
        End If
    End Sub

    Private Sub confirmResetPinBtn_Click(sender As Object, e As EventArgs) Handles confirmResetPinBtn.Click
        Dim customer As Customer = New Customer(selectedId)

        Dim message As String = customer.resetPin()

        If message.ToLower.Contains("error") Then
            MsgBox(message, MsgBoxStyle.Critical)
        Else
            MsgBox(message, MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub datesCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles datesCB.SelectedIndexChanged
        transactions()
    End Sub

    Private Sub transactionsCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles transactionsCB.SelectedIndexChanged
        transactions()
    End Sub

    Private Sub transactions()
        Dim deyt As String = Date.Parse(datesCB.SelectedItem.ToString).ToString("MM-dd-yyyy")
        Dim type As String = transactionsCB.SelectedItem

        populateTransactionsDataGridView(transactionsDGV, Transaction.getTransactionForDay(deyt, type))
    End Sub
End Class
