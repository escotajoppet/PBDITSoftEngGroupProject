Imports System.Data.OleDb

Public Class mainMenuForm
    Private Sub mainMenuForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Administrator.generateInitialAdmin()

        welcomeGB.Show()
        authenticatedGB.Hide()
        welcomeAdminGB.Show()
        adminGB.Hide()
    End Sub

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
    End Sub

    Private Sub newAdminBtn_Click(sender As Object, e As EventArgs) Handles newAdminBtn.Click
        resetPinGB.Hide()
        addAdminGB.Show()
        adminBlankGB.Hide()
    End Sub

    Private Sub logOutBtn_Click(sender As Object, e As EventArgs) Handles logOutBtn.Click
        adminGB.Hide()
        welcomeAdminGB.Show()
    End Sub

    Private Sub addAdminBtn_Click(sender As Object, e As EventArgs) Handles addAdminBtn.Click
        Administrator.addAdministrator(
    End Sub
End Class
