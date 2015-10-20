Public Class customersCMSForm
    Dim selectedId As String
    Dim rowIndex As Integer

    Private Sub customersCMSForm_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        mainMenuForm.Show()
    End Sub

    Private Sub backToMainMenuBtn_Click(sender As Object, e As EventArgs) Handles backToMainMenuBtn.Click
        Me.Close()
    End Sub

    Private Sub customersCMSForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        byCB.SelectedItem = "Account Number"
        viewCustomersPage()
    End Sub

    Private Sub viewCustomersPage()
        populateCustomersDataGridView(customersDGV, Customer.all)
        addEditCustomersGB.Hide()
        customersGB.Show()

        rowIndex = -1
    End Sub

    Private Sub addEditCustomerPage(ByVal _action As String)
        customersGB.Hide()
        addEditCustomersGB.Show()

        If _action = "add" Then
            addEditCustomersGB.Text = "Add Customer"
            addEditBtn.Text = "Add Customer"

            accountNumberLbl.Text = Customer.generateAccountNumber().ToString
        Else
            addEditCustomersGB.Text = "Edit Customer"
            addEditBtn.Text = "Update Customer"
        End If
    End Sub

    Private Sub searchCustomersTB_Click(sender As Object, e As EventArgs) Handles searchCustomersTB.Click
        If searchCustomersTB.Text = "Search..." Then
            searchCustomersTB.Text = ""
            searchCustomersTB.ForeColor = Color.Black
        End If
    End Sub

    Private Sub customersDGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles customersDGV.CellClick
        rowIndex = e.RowIndex

        If rowIndex > -1 Then
            selectedId = customersDGV.Item("customersIDCol", e.RowIndex).Value
        End If
    End Sub

    Private Sub searchCustomersTB_KeyUp(sender As Object, e As KeyEventArgs) Handles searchCustomersTB.KeyUp
        search()
    End Sub

    Private Sub byCB_SelectedIndexChanged(sender As Object, e As EventArgs) Handles byCB.SelectedIndexChanged
        search()
    End Sub

    Private Sub search()
        Dim keyword As String = searchCustomersTB.Text
        Dim field As String = byCB.SelectedItem.ToString
        Dim condition As String

        If keyword.Length > 2 Then
            condition = "[" & field.Replace(" ", "_").ToLower & "] LIKE '%" & keyword & "%'"
        Else
            condition = "1"
        End If

        populateCustomersDataGridView(customersDGV, Customer.search(condition))
    End Sub

    Private Sub addCustomerBtn_Click(sender As Object, e As EventArgs) Handles addCustomerBtn.Click
        addEditCustomerPage("add")
    End Sub

    Private Sub editCustomerBtn_Click(sender As Object, e As EventArgs) Handles editCustomerBtn.Click
        If rowIndex > -1 Then
            Dim customer As Customer = New Customer(selectedId)

            accountNumberLbl.Text = customer.accountNumber
            lastNameTB.Text = customer.lastName
            firstNameTB.Text = customer.firstName
            middleNameTB.Text = customer.middleName
            addressTB.Text = customer.address
            contactNumberTB.Text = customer.contactNumber

            addEditCustomerPage("update")
        Else
            MsgBox("Please select a record to update", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        resetFields()
        viewCustomersPage()
    End Sub

    Private Sub addEditBtn_Click(sender As Object, e As EventArgs) Handles addEditBtn.Click
        If validateInputs() = "passed" Then
            Dim action As String
            Dim message As String

            Dim acctNo As Integer = Integer.Parse(accountNumberLbl.Text)
            Dim ln As String = lastNameTB.Text
            Dim fn As String = firstNameTB.Text
            Dim mn As String = middleNameTB.Text
            Dim ad As String = addressTB.Text
            Dim cn As String = contactNumberTB.Text

            Dim pin As String = generatePIN()

            If addEditBtn.Text = "Add Customer" Then
                action = "ADDED"
                message = Customer.addCustomer(acctNo, pin, ln, fn, mn, ad, cn, 5000.0)
            Else
                action = "UPDATED"
                Dim customer As Customer = New Customer(selectedId)

                message = customer.updateCustomer(acctNo, ln, fn, mn, ad, cn)
            End If

            If message.ToLower.Contains("error") Then
                MsgBox(message, MsgBoxStyle.Critical)
            Else
                If action = "ADDED" Then
                    MsgBox(message & vbCrLf & "New Account PIN: " & pin, MsgBoxStyle.Information)
                Else
                    MsgBox(message, MsgBoxStyle.Information)
                End If

                resetFields()
                viewCustomersPage()
            End If
        Else
            MsgBox(validateInputs(), MsgBoxStyle.Critical)
        End If
    End Sub

    Private Function validateInputs() As String
        Dim errors As String = ""

        If lastNameTB.Text = "" Then
            errors &= "Please Provide a last name" & vbCrLf
        End If

        If firstNameTB.Text = "" Then
            errors &= "Please Provide a first name" & vbCrLf
        End If

        If addressTB.Text = "" Then
            errors &= "Please Provide an address" & vbCrLf
        End If

        If contactNumberTB.Text = "" Then
            errors &= "Please Provide a contact detail" & vbCrLf
        End If

        If errors = "" Then
            errors = "passed"
        End If

        validateInputs = errors
    End Function

    Private Sub resetFields()
        accountNumberLbl.Text = "ACCOUNT NUMBER"
        lastNameTB.Text = ""
        firstNameTB.Text = ""
        middleNameTB.Text = ""
        addressTB.Text = ""
        contactNumberTB.Text = ""
    End Sub

    Private Sub deleteCustomerBtn_Click(sender As Object, e As EventArgs) Handles deleteCustomerBtn.Click
        If rowIndex > -1 Then
            Dim toDelete As String = customersDGV.Item("customersAccountNumberCol", rowIndex).Value
            Dim customer As Customer = New Customer(selectedId)
            Dim message As String = customer.deleteCustomer()

            If message.ToLower.Contains("error") Then
                MsgBox(message, MsgBoxStyle.Critical)
            Else
                rowIndex = rIndex(customersDGV, rowIndex)
                viewCustomersPage()

                MsgBox(message, MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Please select a Customer to delete", MsgBoxStyle.Critical)
        End If
    End Sub
End Class