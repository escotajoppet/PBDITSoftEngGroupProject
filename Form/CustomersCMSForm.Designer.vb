<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customersCMSForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.customersGB = New System.Windows.Forms.GroupBox()
        Me.byCB = New System.Windows.Forms.ComboBox()
        Me.searchCustomersTB = New System.Windows.Forms.TextBox()
        Me.customersDGV = New System.Windows.Forms.DataGridView()
        Me.customersIDCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customersAccountNumberCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customersLastNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customersFirstNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customersMiddleNameCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customersPinCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customersAddressCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customersContactNumberCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.customersBalanceCol = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.addCustomerBtn = New System.Windows.Forms.Button()
        Me.editCustomerBtn = New System.Windows.Forms.Button()
        Me.deleteCustomerBtn = New System.Windows.Forms.Button()
        Me.addEditCustomersGB = New System.Windows.Forms.GroupBox()
        Me.accountNumberLbl = New System.Windows.Forms.Label()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.addEditBtn = New System.Windows.Forms.Button()
        Me.contactNumberTB = New System.Windows.Forms.TextBox()
        Me.addressTB = New System.Windows.Forms.TextBox()
        Me.middleNameTB = New System.Windows.Forms.TextBox()
        Me.firstNameTB = New System.Windows.Forms.TextBox()
        Me.lastNameTB = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.backToMainMenuBtn = New System.Windows.Forms.Button()
        Me.customersGB.SuspendLayout()
        CType(Me.customersDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.addEditCustomersGB.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(295, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customers Management"
        '
        'customersGB
        '
        Me.customersGB.Controls.Add(Me.byCB)
        Me.customersGB.Controls.Add(Me.searchCustomersTB)
        Me.customersGB.Controls.Add(Me.customersDGV)
        Me.customersGB.Controls.Add(Me.addCustomerBtn)
        Me.customersGB.Controls.Add(Me.editCustomerBtn)
        Me.customersGB.Controls.Add(Me.deleteCustomerBtn)
        Me.customersGB.Location = New System.Drawing.Point(12, 41)
        Me.customersGB.Name = "customersGB"
        Me.customersGB.Size = New System.Drawing.Size(560, 389)
        Me.customersGB.TabIndex = 1
        Me.customersGB.TabStop = False
        '
        'byCB
        '
        Me.byCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.byCB.FormattingEnabled = True
        Me.byCB.Items.AddRange(New Object() {"Account Number", "Last Name", "First Name", "Middle Name", "Address"})
        Me.byCB.Location = New System.Drawing.Point(244, 22)
        Me.byCB.Name = "byCB"
        Me.byCB.Size = New System.Drawing.Size(91, 21)
        Me.byCB.TabIndex = 6
        '
        'searchCustomersTB
        '
        Me.searchCustomersTB.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.searchCustomersTB.Location = New System.Drawing.Point(6, 22)
        Me.searchCustomersTB.Name = "searchCustomersTB"
        Me.searchCustomersTB.Size = New System.Drawing.Size(232, 20)
        Me.searchCustomersTB.TabIndex = 4
        Me.searchCustomersTB.Text = "Search..."
        '
        'customersDGV
        '
        Me.customersDGV.AllowUserToAddRows = False
        Me.customersDGV.AllowUserToDeleteRows = False
        Me.customersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.customersDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.customersIDCol, Me.customersAccountNumberCol, Me.customersLastNameCol, Me.customersFirstNameCol, Me.customersMiddleNameCol, Me.customersPinCol, Me.customersAddressCol, Me.customersContactNumberCol, Me.customersBalanceCol})
        Me.customersDGV.Location = New System.Drawing.Point(6, 52)
        Me.customersDGV.Name = "customersDGV"
        Me.customersDGV.ReadOnly = True
        Me.customersDGV.RowHeadersVisible = False
        Me.customersDGV.Size = New System.Drawing.Size(548, 331)
        Me.customersDGV.TabIndex = 3
        '
        'customersIDCol
        '
        Me.customersIDCol.HeaderText = "ID"
        Me.customersIDCol.Name = "customersIDCol"
        Me.customersIDCol.ReadOnly = True
        Me.customersIDCol.Visible = False
        '
        'customersAccountNumberCol
        '
        Me.customersAccountNumberCol.HeaderText = "Account Number"
        Me.customersAccountNumberCol.Name = "customersAccountNumberCol"
        Me.customersAccountNumberCol.ReadOnly = True
        Me.customersAccountNumberCol.Width = 120
        '
        'customersLastNameCol
        '
        Me.customersLastNameCol.HeaderText = "Last Name"
        Me.customersLastNameCol.Name = "customersLastNameCol"
        Me.customersLastNameCol.ReadOnly = True
        '
        'customersFirstNameCol
        '
        Me.customersFirstNameCol.HeaderText = "First Name"
        Me.customersFirstNameCol.Name = "customersFirstNameCol"
        Me.customersFirstNameCol.ReadOnly = True
        '
        'customersMiddleNameCol
        '
        Me.customersMiddleNameCol.HeaderText = "Middle Name"
        Me.customersMiddleNameCol.Name = "customersMiddleNameCol"
        Me.customersMiddleNameCol.ReadOnly = True
        '
        'customersPinCol
        '
        Me.customersPinCol.HeaderText = "Personal Identification Number (PIN)"
        Me.customersPinCol.Name = "customersPinCol"
        Me.customersPinCol.ReadOnly = True
        Me.customersPinCol.Visible = False
        Me.customersPinCol.Width = 210
        '
        'customersAddressCol
        '
        Me.customersAddressCol.HeaderText = "Address"
        Me.customersAddressCol.Name = "customersAddressCol"
        Me.customersAddressCol.ReadOnly = True
        '
        'customersContactNumberCol
        '
        Me.customersContactNumberCol.HeaderText = "Contact Number"
        Me.customersContactNumberCol.Name = "customersContactNumberCol"
        Me.customersContactNumberCol.ReadOnly = True
        Me.customersContactNumberCol.Width = 120
        '
        'customersBalanceCol
        '
        Me.customersBalanceCol.HeaderText = "Balance"
        Me.customersBalanceCol.Name = "customersBalanceCol"
        Me.customersBalanceCol.ReadOnly = True
        '
        'addCustomerBtn
        '
        Me.addCustomerBtn.Image = Global.PBDITSoftEngGroupProject.My.Resources.Resources.add
        Me.addCustomerBtn.Location = New System.Drawing.Point(455, 19)
        Me.addCustomerBtn.Name = "addCustomerBtn"
        Me.addCustomerBtn.Size = New System.Drawing.Size(29, 27)
        Me.addCustomerBtn.TabIndex = 2
        Me.addCustomerBtn.UseVisualStyleBackColor = True
        '
        'editCustomerBtn
        '
        Me.editCustomerBtn.Image = Global.PBDITSoftEngGroupProject.My.Resources.Resources.edit
        Me.editCustomerBtn.Location = New System.Drawing.Point(490, 19)
        Me.editCustomerBtn.Name = "editCustomerBtn"
        Me.editCustomerBtn.Size = New System.Drawing.Size(29, 27)
        Me.editCustomerBtn.TabIndex = 1
        Me.editCustomerBtn.UseVisualStyleBackColor = True
        '
        'deleteCustomerBtn
        '
        Me.deleteCustomerBtn.Image = Global.PBDITSoftEngGroupProject.My.Resources.Resources.remove
        Me.deleteCustomerBtn.Location = New System.Drawing.Point(525, 19)
        Me.deleteCustomerBtn.Name = "deleteCustomerBtn"
        Me.deleteCustomerBtn.Size = New System.Drawing.Size(29, 27)
        Me.deleteCustomerBtn.TabIndex = 0
        Me.deleteCustomerBtn.UseVisualStyleBackColor = True
        '
        'addEditCustomersGB
        '
        Me.addEditCustomersGB.Controls.Add(Me.accountNumberLbl)
        Me.addEditCustomersGB.Controls.Add(Me.cancelBtn)
        Me.addEditCustomersGB.Controls.Add(Me.addEditBtn)
        Me.addEditCustomersGB.Controls.Add(Me.contactNumberTB)
        Me.addEditCustomersGB.Controls.Add(Me.addressTB)
        Me.addEditCustomersGB.Controls.Add(Me.middleNameTB)
        Me.addEditCustomersGB.Controls.Add(Me.firstNameTB)
        Me.addEditCustomersGB.Controls.Add(Me.lastNameTB)
        Me.addEditCustomersGB.Controls.Add(Me.Label7)
        Me.addEditCustomersGB.Controls.Add(Me.Label6)
        Me.addEditCustomersGB.Controls.Add(Me.Label5)
        Me.addEditCustomersGB.Controls.Add(Me.Label4)
        Me.addEditCustomersGB.Controls.Add(Me.Label3)
        Me.addEditCustomersGB.Controls.Add(Me.Label2)
        Me.addEditCustomersGB.Location = New System.Drawing.Point(12, 41)
        Me.addEditCustomersGB.Name = "addEditCustomersGB"
        Me.addEditCustomersGB.Size = New System.Drawing.Size(560, 389)
        Me.addEditCustomersGB.TabIndex = 7
        Me.addEditCustomersGB.TabStop = False
        '
        'accountNumberLbl
        '
        Me.accountNumberLbl.AutoSize = True
        Me.accountNumberLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.accountNumberLbl.Location = New System.Drawing.Point(102, 18)
        Me.accountNumberLbl.Name = "accountNumberLbl"
        Me.accountNumberLbl.Size = New System.Drawing.Size(152, 17)
        Me.accountNumberLbl.TabIndex = 16
        Me.accountNumberLbl.Text = "ACCOUNT NUMBER"
        '
        'cancelBtn
        '
        Me.cancelBtn.Location = New System.Drawing.Point(452, 360)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(102, 23)
        Me.cancelBtn.TabIndex = 15
        Me.cancelBtn.Text = "Cancel"
        Me.cancelBtn.UseVisualStyleBackColor = True
        '
        'addEditBtn
        '
        Me.addEditBtn.Location = New System.Drawing.Point(344, 360)
        Me.addEditBtn.Name = "addEditBtn"
        Me.addEditBtn.Size = New System.Drawing.Size(102, 23)
        Me.addEditBtn.TabIndex = 12
        Me.addEditBtn.UseVisualStyleBackColor = True
        '
        'contactNumberTB
        '
        Me.contactNumberTB.Location = New System.Drawing.Point(102, 331)
        Me.contactNumberTB.Name = "contactNumberTB"
        Me.contactNumberTB.Size = New System.Drawing.Size(452, 20)
        Me.contactNumberTB.TabIndex = 11
        '
        'addressTB
        '
        Me.addressTB.Location = New System.Drawing.Point(102, 268)
        Me.addressTB.Name = "addressTB"
        Me.addressTB.Size = New System.Drawing.Size(452, 20)
        Me.addressTB.TabIndex = 10
        '
        'middleNameTB
        '
        Me.middleNameTB.Location = New System.Drawing.Point(102, 205)
        Me.middleNameTB.Name = "middleNameTB"
        Me.middleNameTB.Size = New System.Drawing.Size(452, 20)
        Me.middleNameTB.TabIndex = 9
        '
        'firstNameTB
        '
        Me.firstNameTB.Location = New System.Drawing.Point(102, 142)
        Me.firstNameTB.Name = "firstNameTB"
        Me.firstNameTB.Size = New System.Drawing.Size(452, 20)
        Me.firstNameTB.TabIndex = 8
        '
        'lastNameTB
        '
        Me.lastNameTB.Location = New System.Drawing.Point(102, 79)
        Me.lastNameTB.Name = "lastNameTB"
        Me.lastNameTB.Size = New System.Drawing.Size(452, 20)
        Me.lastNameTB.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 335)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Contact Number:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 272)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 209)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Middle Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "First Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Last Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Account Number:"
        '
        'backToMainMenuBtn
        '
        Me.backToMainMenuBtn.Image = Global.PBDITSoftEngGroupProject.My.Resources.Resources.list
        Me.backToMainMenuBtn.Location = New System.Drawing.Point(543, 10)
        Me.backToMainMenuBtn.Name = "backToMainMenuBtn"
        Me.backToMainMenuBtn.Size = New System.Drawing.Size(29, 27)
        Me.backToMainMenuBtn.TabIndex = 7
        Me.backToMainMenuBtn.UseVisualStyleBackColor = True
        '
        'customersCMSForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 442)
        Me.Controls.Add(Me.backToMainMenuBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.customersGB)
        Me.Controls.Add(Me.addEditCustomersGB)
        Me.Name = "customersCMSForm"
        Me.Text = "Customers Management"
        Me.customersGB.ResumeLayout(False)
        Me.customersGB.PerformLayout()
        CType(Me.customersDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.addEditCustomersGB.ResumeLayout(False)
        Me.addEditCustomersGB.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents customersGB As System.Windows.Forms.GroupBox
    Friend WithEvents addCustomerBtn As System.Windows.Forms.Button
    Friend WithEvents editCustomerBtn As System.Windows.Forms.Button
    Friend WithEvents deleteCustomerBtn As System.Windows.Forms.Button
    Friend WithEvents searchCustomersTB As System.Windows.Forms.TextBox
    Friend WithEvents customersDGV As System.Windows.Forms.DataGridView
    Friend WithEvents byCB As System.Windows.Forms.ComboBox
    Friend WithEvents addEditCustomersGB As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents contactNumberTB As System.Windows.Forms.TextBox
    Friend WithEvents addressTB As System.Windows.Forms.TextBox
    Friend WithEvents middleNameTB As System.Windows.Forms.TextBox
    Friend WithEvents firstNameTB As System.Windows.Forms.TextBox
    Friend WithEvents lastNameTB As System.Windows.Forms.TextBox
    Friend WithEvents addEditBtn As System.Windows.Forms.Button
    Friend WithEvents cancelBtn As System.Windows.Forms.Button
    Friend WithEvents accountNumberLbl As System.Windows.Forms.Label
    Friend WithEvents customersIDCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customersAccountNumberCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customersLastNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customersFirstNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customersMiddleNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customersPinCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customersAddressCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customersContactNumberCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customersBalanceCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents backToMainMenuBtn As System.Windows.Forms.Button
End Class
