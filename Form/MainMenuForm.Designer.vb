<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainMenuForm
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.adminPageTab = New System.Windows.Forms.TabPage()
        Me.adminGB = New System.Windows.Forms.GroupBox()
        Me.newAdminBtn = New System.Windows.Forms.Button()
        Me.logOutBtn = New System.Windows.Forms.Button()
        Me.resetPinBtn = New System.Windows.Forms.Button()
        Me.trasactionReportBtn = New System.Windows.Forms.Button()
        Me.manageCustomersBtn = New System.Windows.Forms.Button()
        Me.addAdminGB = New System.Windows.Forms.GroupBox()
        Me.addAdminBtn = New System.Windows.Forms.Button()
        Me.newPasswordTB = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.newUsernameTB = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.resetPinGB = New System.Windows.Forms.GroupBox()
        Me.welcomeAdminGB = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.adminLogInBtn = New System.Windows.Forms.Button()
        Me.loginPasswordTB = New System.Windows.Forms.TextBox()
        Me.loginUsernameTB = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.customerPageTab = New System.Windows.Forms.TabPage()
        Me.welcomeGB = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.loginPinTB = New System.Windows.Forms.TextBox()
        Me.loginAccountNumberTB = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.authenticatedGB = New System.Windows.Forms.GroupBox()
        Me.changePinBtn = New System.Windows.Forms.Button()
        Me.endTransactionBtn = New System.Windows.Forms.Button()
        Me.cashWithdrawalBtn = New System.Windows.Forms.Button()
        Me.cashDepositBtn = New System.Windows.Forms.Button()
        Me.checkBalanceBtn = New System.Windows.Forms.Button()
        Me.changePinGB = New System.Windows.Forms.GroupBox()
        Me.confirmChangePinBtn = New System.Windows.Forms.Button()
        Me.newPin2TB = New System.Windows.Forms.TextBox()
        Me.newPinTB = New System.Windows.Forms.TextBox()
        Me.oldPinTB = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.withdrawGB = New System.Windows.Forms.GroupBox()
        Me.withdrawLbl = New System.Windows.Forms.Label()
        Me.clearWithdrawFieldBtn = New System.Windows.Forms.Button()
        Me.withdrawBtn = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.withdrawAmountTB = New System.Windows.Forms.TextBox()
        Me.Label99 = New System.Windows.Forms.Label()
        Me.depositGB = New System.Windows.Forms.GroupBox()
        Me.depositLbl = New System.Windows.Forms.Label()
        Me.depositClearBtn = New System.Windows.Forms.Button()
        Me.depositBtn = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.depositAmountTB = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.blankGB = New System.Windows.Forms.GroupBox()
        Me.checkBalanceGB = New System.Windows.Forms.GroupBox()
        Me.balanceLbl = New System.Windows.Forms.Label()
        Me.confirmResetPinBtn = New System.Windows.Forms.Button()
        Me.searchCustomerTB = New System.Windows.Forms.TextBox()
        Me.byCB = New System.Windows.Forms.ComboBox()
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
        Me.adminBlankGB = New System.Windows.Forms.GroupBox()
        Me.TabControl1.SuspendLayout()
        Me.adminPageTab.SuspendLayout()
        Me.adminGB.SuspendLayout()
        Me.addAdminGB.SuspendLayout()
        Me.resetPinGB.SuspendLayout()
        Me.welcomeAdminGB.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.customerPageTab.SuspendLayout()
        Me.welcomeGB.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.authenticatedGB.SuspendLayout()
        Me.changePinGB.SuspendLayout()
        Me.withdrawGB.SuspendLayout()
        Me.depositGB.SuspendLayout()
        Me.checkBalanceGB.SuspendLayout()
        CType(Me.customersDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.adminPageTab)
        Me.TabControl1.Controls.Add(Me.customerPageTab)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(560, 418)
        Me.TabControl1.TabIndex = 0
        '
        'adminPageTab
        '
        Me.adminPageTab.Controls.Add(Me.adminGB)
        Me.adminPageTab.Controls.Add(Me.welcomeAdminGB)
        Me.adminPageTab.Location = New System.Drawing.Point(4, 22)
        Me.adminPageTab.Name = "adminPageTab"
        Me.adminPageTab.Padding = New System.Windows.Forms.Padding(3)
        Me.adminPageTab.Size = New System.Drawing.Size(552, 392)
        Me.adminPageTab.TabIndex = 0
        Me.adminPageTab.Text = "Adminstrators"
        Me.adminPageTab.UseVisualStyleBackColor = True
        '
        'adminGB
        '
        Me.adminGB.Controls.Add(Me.newAdminBtn)
        Me.adminGB.Controls.Add(Me.logOutBtn)
        Me.adminGB.Controls.Add(Me.resetPinBtn)
        Me.adminGB.Controls.Add(Me.trasactionReportBtn)
        Me.adminGB.Controls.Add(Me.manageCustomersBtn)
        Me.adminGB.Controls.Add(Me.addAdminGB)
        Me.adminGB.Controls.Add(Me.adminBlankGB)
        Me.adminGB.Controls.Add(Me.resetPinGB)
        Me.adminGB.Location = New System.Drawing.Point(3, 6)
        Me.adminGB.Name = "adminGB"
        Me.adminGB.Size = New System.Drawing.Size(543, 383)
        Me.adminGB.TabIndex = 1
        Me.adminGB.TabStop = False
        '
        'newAdminBtn
        '
        Me.newAdminBtn.Location = New System.Drawing.Point(6, 322)
        Me.newAdminBtn.Name = "newAdminBtn"
        Me.newAdminBtn.Size = New System.Drawing.Size(123, 23)
        Me.newAdminBtn.TabIndex = 5
        Me.newAdminBtn.Text = "New Admistrator"
        Me.newAdminBtn.UseVisualStyleBackColor = True
        '
        'logOutBtn
        '
        Me.logOutBtn.Location = New System.Drawing.Point(6, 351)
        Me.logOutBtn.Name = "logOutBtn"
        Me.logOutBtn.Size = New System.Drawing.Size(123, 23)
        Me.logOutBtn.TabIndex = 4
        Me.logOutBtn.Text = "Log Out"
        Me.logOutBtn.UseVisualStyleBackColor = True
        '
        'resetPinBtn
        '
        Me.resetPinBtn.Location = New System.Drawing.Point(6, 73)
        Me.resetPinBtn.Name = "resetPinBtn"
        Me.resetPinBtn.Size = New System.Drawing.Size(123, 48)
        Me.resetPinBtn.TabIndex = 1
        Me.resetPinBtn.Text = "RESET PIN"
        Me.resetPinBtn.UseVisualStyleBackColor = True
        '
        'trasactionReportBtn
        '
        Me.trasactionReportBtn.Location = New System.Drawing.Point(6, 127)
        Me.trasactionReportBtn.Name = "trasactionReportBtn"
        Me.trasactionReportBtn.Size = New System.Drawing.Size(123, 48)
        Me.trasactionReportBtn.TabIndex = 2
        Me.trasactionReportBtn.Text = "TRASACTION REPORT"
        Me.trasactionReportBtn.UseVisualStyleBackColor = True
        '
        'manageCustomersBtn
        '
        Me.manageCustomersBtn.Location = New System.Drawing.Point(6, 19)
        Me.manageCustomersBtn.Name = "manageCustomersBtn"
        Me.manageCustomersBtn.Size = New System.Drawing.Size(123, 48)
        Me.manageCustomersBtn.TabIndex = 0
        Me.manageCustomersBtn.Text = "MANAGE CUSTOMERS"
        Me.manageCustomersBtn.UseVisualStyleBackColor = True
        '
        'addAdminGB
        '
        Me.addAdminGB.Controls.Add(Me.addAdminBtn)
        Me.addAdminGB.Controls.Add(Me.newPasswordTB)
        Me.addAdminGB.Controls.Add(Me.Label12)
        Me.addAdminGB.Controls.Add(Me.newUsernameTB)
        Me.addAdminGB.Controls.Add(Me.Label11)
        Me.addAdminGB.Location = New System.Drawing.Point(135, 19)
        Me.addAdminGB.Name = "addAdminGB"
        Me.addAdminGB.Size = New System.Drawing.Size(399, 355)
        Me.addAdminGB.TabIndex = 3
        Me.addAdminGB.TabStop = False
        Me.addAdminGB.Text = "Add Adminstrator"
        '
        'addAdminBtn
        '
        Me.addAdminBtn.Location = New System.Drawing.Point(284, 108)
        Me.addAdminBtn.Name = "addAdminBtn"
        Me.addAdminBtn.Size = New System.Drawing.Size(109, 23)
        Me.addAdminBtn.TabIndex = 8
        Me.addAdminBtn.Text = "Add Admin"
        Me.addAdminBtn.UseVisualStyleBackColor = True
        '
        'newPasswordTB
        '
        Me.newPasswordTB.Location = New System.Drawing.Point(70, 72)
        Me.newPasswordTB.Name = "newPasswordTB"
        Me.newPasswordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newPasswordTB.Size = New System.Drawing.Size(323, 20)
        Me.newPasswordTB.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Password:"
        '
        'newUsernameTB
        '
        Me.newUsernameTB.Location = New System.Drawing.Point(70, 30)
        Me.newUsernameTB.Name = "newUsernameTB"
        Me.newUsernameTB.Size = New System.Drawing.Size(323, 20)
        Me.newUsernameTB.TabIndex = 1
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(6, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 13)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Username:"
        '
        'resetPinGB
        '
        Me.resetPinGB.Controls.Add(Me.customersDGV)
        Me.resetPinGB.Controls.Add(Me.byCB)
        Me.resetPinGB.Controls.Add(Me.searchCustomerTB)
        Me.resetPinGB.Controls.Add(Me.confirmResetPinBtn)
        Me.resetPinGB.Location = New System.Drawing.Point(135, 19)
        Me.resetPinGB.Name = "resetPinGB"
        Me.resetPinGB.Size = New System.Drawing.Size(399, 355)
        Me.resetPinGB.TabIndex = 0
        Me.resetPinGB.TabStop = False
        Me.resetPinGB.Text = "Reset Pin"
        '
        'welcomeAdminGB
        '
        Me.welcomeAdminGB.Controls.Add(Me.GroupBox3)
        Me.welcomeAdminGB.Controls.Add(Me.Label17)
        Me.welcomeAdminGB.Controls.Add(Me.Label18)
        Me.welcomeAdminGB.Location = New System.Drawing.Point(3, 6)
        Me.welcomeAdminGB.Name = "welcomeAdminGB"
        Me.welcomeAdminGB.Size = New System.Drawing.Size(543, 383)
        Me.welcomeAdminGB.TabIndex = 6
        Me.welcomeAdminGB.TabStop = False
        Me.welcomeAdminGB.Text = "Welcome"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.adminLogInBtn)
        Me.GroupBox3.Controls.Add(Me.loginPasswordTB)
        Me.GroupBox3.Controls.Add(Me.loginUsernameTB)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Location = New System.Drawing.Point(117, 118)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(304, 99)
        Me.GroupBox3.TabIndex = 11
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Administrator Log In"
        '
        'adminLogInBtn
        '
        Me.adminLogInBtn.Location = New System.Drawing.Point(216, 67)
        Me.adminLogInBtn.Name = "adminLogInBtn"
        Me.adminLogInBtn.Size = New System.Drawing.Size(75, 23)
        Me.adminLogInBtn.TabIndex = 11
        Me.adminLogInBtn.Text = "Log In"
        Me.adminLogInBtn.UseVisualStyleBackColor = True
        '
        'loginPasswordTB
        '
        Me.loginPasswordTB.Location = New System.Drawing.Point(75, 41)
        Me.loginPasswordTB.Name = "loginPasswordTB"
        Me.loginPasswordTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.loginPasswordTB.Size = New System.Drawing.Size(216, 20)
        Me.loginPasswordTB.TabIndex = 10
        '
        'loginUsernameTB
        '
        Me.loginUsernameTB.Location = New System.Drawing.Point(75, 15)
        Me.loginUsernameTB.Name = "loginUsernameTB"
        Me.loginUsernameTB.Size = New System.Drawing.Size(216, 20)
        Me.loginUsernameTB.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 13)
        Me.Label15.TabIndex = 8
        Me.Label15.Text = "Password:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(11, 19)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 13)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Username:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(93, 62)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(347, 20)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "Enter your Username and Password to continue"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(123, 26)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(293, 29)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "WELCOME to our BANK"
        '
        'customerPageTab
        '
        Me.customerPageTab.Controls.Add(Me.welcomeGB)
        Me.customerPageTab.Controls.Add(Me.authenticatedGB)
        Me.customerPageTab.Location = New System.Drawing.Point(4, 22)
        Me.customerPageTab.Name = "customerPageTab"
        Me.customerPageTab.Padding = New System.Windows.Forms.Padding(3)
        Me.customerPageTab.Size = New System.Drawing.Size(552, 392)
        Me.customerPageTab.TabIndex = 1
        Me.customerPageTab.Text = "Customers"
        Me.customerPageTab.UseVisualStyleBackColor = True
        '
        'welcomeGB
        '
        Me.welcomeGB.Controls.Add(Me.GroupBox5)
        Me.welcomeGB.Controls.Add(Me.Label2)
        Me.welcomeGB.Controls.Add(Me.Label1)
        Me.welcomeGB.Location = New System.Drawing.Point(6, 6)
        Me.welcomeGB.Name = "welcomeGB"
        Me.welcomeGB.Size = New System.Drawing.Size(540, 380)
        Me.welcomeGB.TabIndex = 10
        Me.welcomeGB.TabStop = False
        Me.welcomeGB.Text = "Welcome"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.loginBtn)
        Me.GroupBox5.Controls.Add(Me.loginPinTB)
        Me.GroupBox5.Controls.Add(Me.loginAccountNumberTB)
        Me.GroupBox5.Controls.Add(Me.Label4)
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Location = New System.Drawing.Point(118, 118)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(304, 99)
        Me.GroupBox5.TabIndex = 8
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Customer Log In"
        '
        'loginBtn
        '
        Me.loginBtn.Location = New System.Drawing.Point(216, 67)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(75, 23)
        Me.loginBtn.TabIndex = 11
        Me.loginBtn.Text = "Authenticate"
        Me.loginBtn.UseVisualStyleBackColor = True
        '
        'loginPinTB
        '
        Me.loginPinTB.Location = New System.Drawing.Point(107, 41)
        Me.loginPinTB.Name = "loginPinTB"
        Me.loginPinTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.loginPinTB.Size = New System.Drawing.Size(184, 20)
        Me.loginPinTB.TabIndex = 10
        '
        'loginAccountNumberTB
        '
        Me.loginAccountNumberTB.Location = New System.Drawing.Point(107, 15)
        Me.loginAccountNumberTB.Name = "loginAccountNumberTB"
        Me.loginAccountNumberTB.Size = New System.Drawing.Size(184, 20)
        Me.loginAccountNumberTB.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 45)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "PIN:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Account Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(96, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(349, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter your Account Number and PIN to continue"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(124, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WELCOME to our BANK"
        '
        'authenticatedGB
        '
        Me.authenticatedGB.Controls.Add(Me.changePinBtn)
        Me.authenticatedGB.Controls.Add(Me.endTransactionBtn)
        Me.authenticatedGB.Controls.Add(Me.cashWithdrawalBtn)
        Me.authenticatedGB.Controls.Add(Me.cashDepositBtn)
        Me.authenticatedGB.Controls.Add(Me.checkBalanceBtn)
        Me.authenticatedGB.Controls.Add(Me.changePinGB)
        Me.authenticatedGB.Controls.Add(Me.withdrawGB)
        Me.authenticatedGB.Controls.Add(Me.depositGB)
        Me.authenticatedGB.Controls.Add(Me.blankGB)
        Me.authenticatedGB.Controls.Add(Me.checkBalanceGB)
        Me.authenticatedGB.Location = New System.Drawing.Point(6, 6)
        Me.authenticatedGB.Name = "authenticatedGB"
        Me.authenticatedGB.Size = New System.Drawing.Size(540, 380)
        Me.authenticatedGB.TabIndex = 0
        Me.authenticatedGB.TabStop = False
        '
        'changePinBtn
        '
        Me.changePinBtn.Location = New System.Drawing.Point(6, 322)
        Me.changePinBtn.Name = "changePinBtn"
        Me.changePinBtn.Size = New System.Drawing.Size(123, 23)
        Me.changePinBtn.TabIndex = 3
        Me.changePinBtn.Text = "Change PIN"
        Me.changePinBtn.UseVisualStyleBackColor = True
        '
        'endTransactionBtn
        '
        Me.endTransactionBtn.Location = New System.Drawing.Point(6, 351)
        Me.endTransactionBtn.Name = "endTransactionBtn"
        Me.endTransactionBtn.Size = New System.Drawing.Size(123, 23)
        Me.endTransactionBtn.TabIndex = 4
        Me.endTransactionBtn.Text = "End Transaction"
        Me.endTransactionBtn.UseVisualStyleBackColor = True
        '
        'cashWithdrawalBtn
        '
        Me.cashWithdrawalBtn.Location = New System.Drawing.Point(6, 73)
        Me.cashWithdrawalBtn.Name = "cashWithdrawalBtn"
        Me.cashWithdrawalBtn.Size = New System.Drawing.Size(123, 48)
        Me.cashWithdrawalBtn.TabIndex = 1
        Me.cashWithdrawalBtn.Text = "CASH WITHDRAWAL"
        Me.cashWithdrawalBtn.UseVisualStyleBackColor = True
        '
        'cashDepositBtn
        '
        Me.cashDepositBtn.Location = New System.Drawing.Point(6, 127)
        Me.cashDepositBtn.Name = "cashDepositBtn"
        Me.cashDepositBtn.Size = New System.Drawing.Size(123, 48)
        Me.cashDepositBtn.TabIndex = 2
        Me.cashDepositBtn.Text = "CASH DEPOSIT"
        Me.cashDepositBtn.UseVisualStyleBackColor = True
        '
        'checkBalanceBtn
        '
        Me.checkBalanceBtn.Location = New System.Drawing.Point(6, 19)
        Me.checkBalanceBtn.Name = "checkBalanceBtn"
        Me.checkBalanceBtn.Size = New System.Drawing.Size(123, 48)
        Me.checkBalanceBtn.TabIndex = 0
        Me.checkBalanceBtn.Text = "BALANCE INQUIRY"
        Me.checkBalanceBtn.UseVisualStyleBackColor = True
        '
        'changePinGB
        '
        Me.changePinGB.Controls.Add(Me.confirmChangePinBtn)
        Me.changePinGB.Controls.Add(Me.newPin2TB)
        Me.changePinGB.Controls.Add(Me.newPinTB)
        Me.changePinGB.Controls.Add(Me.oldPinTB)
        Me.changePinGB.Controls.Add(Me.Label9)
        Me.changePinGB.Controls.Add(Me.Label8)
        Me.changePinGB.Controls.Add(Me.Label5)
        Me.changePinGB.Location = New System.Drawing.Point(135, 19)
        Me.changePinGB.Name = "changePinGB"
        Me.changePinGB.Size = New System.Drawing.Size(399, 355)
        Me.changePinGB.TabIndex = 6
        Me.changePinGB.TabStop = False
        Me.changePinGB.Text = "Change PIN"
        '
        'confirmChangePinBtn
        '
        Me.confirmChangePinBtn.Location = New System.Drawing.Point(293, 125)
        Me.confirmChangePinBtn.Name = "confirmChangePinBtn"
        Me.confirmChangePinBtn.Size = New System.Drawing.Size(100, 23)
        Me.confirmChangePinBtn.TabIndex = 13
        Me.confirmChangePinBtn.Text = "Change PIN"
        Me.confirmChangePinBtn.UseVisualStyleBackColor = True
        '
        'newPin2TB
        '
        Me.newPin2TB.Location = New System.Drawing.Point(99, 99)
        Me.newPin2TB.Name = "newPin2TB"
        Me.newPin2TB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newPin2TB.Size = New System.Drawing.Size(294, 20)
        Me.newPin2TB.TabIndex = 12
        '
        'newPinTB
        '
        Me.newPinTB.Location = New System.Drawing.Point(99, 73)
        Me.newPinTB.Name = "newPinTB"
        Me.newPinTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.newPinTB.Size = New System.Drawing.Size(294, 20)
        Me.newPinTB.TabIndex = 11
        '
        'oldPinTB
        '
        Me.oldPinTB.Location = New System.Drawing.Point(99, 31)
        Me.oldPinTB.Name = "oldPinTB"
        Me.oldPinTB.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.oldPinTB.Size = New System.Drawing.Size(294, 20)
        Me.oldPinTB.TabIndex = 10
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 103)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(90, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Retype New PIN:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "New PIN:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Old PIN:"
        '
        'withdrawGB
        '
        Me.withdrawGB.Controls.Add(Me.withdrawLbl)
        Me.withdrawGB.Controls.Add(Me.clearWithdrawFieldBtn)
        Me.withdrawGB.Controls.Add(Me.withdrawBtn)
        Me.withdrawGB.Controls.Add(Me.Label6)
        Me.withdrawGB.Controls.Add(Me.withdrawAmountTB)
        Me.withdrawGB.Controls.Add(Me.Label99)
        Me.withdrawGB.Location = New System.Drawing.Point(135, 19)
        Me.withdrawGB.Name = "withdrawGB"
        Me.withdrawGB.Size = New System.Drawing.Size(399, 355)
        Me.withdrawGB.TabIndex = 4
        Me.withdrawGB.TabStop = False
        Me.withdrawGB.Text = "Withdraw"
        '
        'withdrawLbl
        '
        Me.withdrawLbl.AutoSize = True
        Me.withdrawLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.withdrawLbl.Location = New System.Drawing.Point(6, 99)
        Me.withdrawLbl.Name = "withdrawLbl"
        Me.withdrawLbl.Size = New System.Drawing.Size(0, 17)
        Me.withdrawLbl.TabIndex = 5
        '
        'clearWithdrawFieldBtn
        '
        Me.clearWithdrawFieldBtn.Location = New System.Drawing.Point(318, 187)
        Me.clearWithdrawFieldBtn.Name = "clearWithdrawFieldBtn"
        Me.clearWithdrawFieldBtn.Size = New System.Drawing.Size(75, 23)
        Me.clearWithdrawFieldBtn.TabIndex = 4
        Me.clearWithdrawFieldBtn.Text = "Clear Field"
        Me.clearWithdrawFieldBtn.UseVisualStyleBackColor = True
        '
        'withdrawBtn
        '
        Me.withdrawBtn.Location = New System.Drawing.Point(237, 187)
        Me.withdrawBtn.Name = "withdrawBtn"
        Me.withdrawBtn.Size = New System.Drawing.Size(75, 23)
        Me.withdrawBtn.TabIndex = 3
        Me.withdrawBtn.Text = "Withdraw"
        Me.withdrawBtn.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(201, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Please enter desired amount to withdraw:"
        '
        'withdrawAmountTB
        '
        Me.withdrawAmountTB.Location = New System.Drawing.Point(9, 161)
        Me.withdrawAmountTB.Name = "withdrawAmountTB"
        Me.withdrawAmountTB.Size = New System.Drawing.Size(384, 20)
        Me.withdrawAmountTB.TabIndex = 1
        '
        'Label99
        '
        Me.Label99.AutoSize = True
        Me.Label99.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label99.Location = New System.Drawing.Point(6, 33)
        Me.Label99.Name = "Label99"
        Me.Label99.Size = New System.Drawing.Size(271, 34)
        Me.Label99.TabIndex = 0
        Me.Label99.Text = "Minimum Withdrawal amount: Php 100" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Maximum Withdrawal amount: Php 20,000"
        '
        'depositGB
        '
        Me.depositGB.Controls.Add(Me.depositLbl)
        Me.depositGB.Controls.Add(Me.depositClearBtn)
        Me.depositGB.Controls.Add(Me.depositBtn)
        Me.depositGB.Controls.Add(Me.Label7)
        Me.depositGB.Controls.Add(Me.depositAmountTB)
        Me.depositGB.Controls.Add(Me.Label10)
        Me.depositGB.Location = New System.Drawing.Point(135, 19)
        Me.depositGB.Name = "depositGB"
        Me.depositGB.Size = New System.Drawing.Size(399, 355)
        Me.depositGB.TabIndex = 6
        Me.depositGB.TabStop = False
        Me.depositGB.Text = "Deposit"
        '
        'depositLbl
        '
        Me.depositLbl.AutoSize = True
        Me.depositLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.depositLbl.Location = New System.Drawing.Point(6, 99)
        Me.depositLbl.Name = "depositLbl"
        Me.depositLbl.Size = New System.Drawing.Size(0, 17)
        Me.depositLbl.TabIndex = 10
        '
        'depositClearBtn
        '
        Me.depositClearBtn.Location = New System.Drawing.Point(318, 187)
        Me.depositClearBtn.Name = "depositClearBtn"
        Me.depositClearBtn.Size = New System.Drawing.Size(75, 23)
        Me.depositClearBtn.TabIndex = 9
        Me.depositClearBtn.Text = "Clear Field"
        Me.depositClearBtn.UseVisualStyleBackColor = True
        '
        'depositBtn
        '
        Me.depositBtn.Location = New System.Drawing.Point(237, 187)
        Me.depositBtn.Name = "depositBtn"
        Me.depositBtn.Size = New System.Drawing.Size(75, 23)
        Me.depositBtn.TabIndex = 8
        Me.depositBtn.Text = "Deposit"
        Me.depositBtn.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 145)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(193, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Please enter desired amount to deposit:"
        '
        'depositAmountTB
        '
        Me.depositAmountTB.Location = New System.Drawing.Point(9, 161)
        Me.depositAmountTB.Name = "depositAmountTB"
        Me.depositAmountTB.Size = New System.Drawing.Size(384, 20)
        Me.depositAmountTB.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 33)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(250, 34)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Minimum Deposit amount: Php 100" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Maximum Deposit amount: Php 50,000"
        '
        'blankGB
        '
        Me.blankGB.Location = New System.Drawing.Point(135, 19)
        Me.blankGB.Name = "blankGB"
        Me.blankGB.Size = New System.Drawing.Size(399, 355)
        Me.blankGB.TabIndex = 1
        Me.blankGB.TabStop = False
        '
        'checkBalanceGB
        '
        Me.checkBalanceGB.Controls.Add(Me.balanceLbl)
        Me.checkBalanceGB.Location = New System.Drawing.Point(135, 19)
        Me.checkBalanceGB.Name = "checkBalanceGB"
        Me.checkBalanceGB.Size = New System.Drawing.Size(399, 355)
        Me.checkBalanceGB.TabIndex = 9
        Me.checkBalanceGB.TabStop = False
        Me.checkBalanceGB.Text = "Balance Inquiry"
        '
        'balanceLbl
        '
        Me.balanceLbl.AutoSize = True
        Me.balanceLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.balanceLbl.Location = New System.Drawing.Point(6, 33)
        Me.balanceLbl.Name = "balanceLbl"
        Me.balanceLbl.Size = New System.Drawing.Size(59, 17)
        Me.balanceLbl.TabIndex = 0
        Me.balanceLbl.Text = "Balance"
        '
        'confirmResetPinBtn
        '
        Me.confirmResetPinBtn.Location = New System.Drawing.Point(284, 326)
        Me.confirmResetPinBtn.Name = "confirmResetPinBtn"
        Me.confirmResetPinBtn.Size = New System.Drawing.Size(109, 23)
        Me.confirmResetPinBtn.TabIndex = 1
        Me.confirmResetPinBtn.Text = "Reset Pin"
        Me.confirmResetPinBtn.UseVisualStyleBackColor = True
        '
        'searchCustomerTB
        '
        Me.searchCustomerTB.Location = New System.Drawing.Point(9, 20)
        Me.searchCustomerTB.Name = "searchCustomerTB"
        Me.searchCustomerTB.Size = New System.Drawing.Size(272, 20)
        Me.searchCustomerTB.TabIndex = 2
        '
        'byCB
        '
        Me.byCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.byCB.FormattingEnabled = True
        Me.byCB.Items.AddRange(New Object() {"Account Number", "Last Name", "First Name"})
        Me.byCB.Location = New System.Drawing.Point(287, 19)
        Me.byCB.Name = "byCB"
        Me.byCB.Size = New System.Drawing.Size(106, 21)
        Me.byCB.TabIndex = 3
        '
        'customersDGV
        '
        Me.customersDGV.AllowUserToAddRows = False
        Me.customersDGV.AllowUserToDeleteRows = False
        Me.customersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.customersDGV.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.customersIDCol, Me.customersAccountNumberCol, Me.customersLastNameCol, Me.customersFirstNameCol, Me.customersMiddleNameCol, Me.customersPinCol, Me.customersAddressCol, Me.customersContactNumberCol, Me.customersBalanceCol})
        Me.customersDGV.Location = New System.Drawing.Point(9, 46)
        Me.customersDGV.Name = "customersDGV"
        Me.customersDGV.ReadOnly = True
        Me.customersDGV.RowHeadersVisible = False
        Me.customersDGV.Size = New System.Drawing.Size(384, 274)
        Me.customersDGV.TabIndex = 4
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
        'adminBlankGB
        '
        Me.adminBlankGB.Location = New System.Drawing.Point(135, 19)
        Me.adminBlankGB.Name = "adminBlankGB"
        Me.adminBlankGB.Size = New System.Drawing.Size(399, 355)
        Me.adminBlankGB.TabIndex = 6
        Me.adminBlankGB.TabStop = False
        '
        'mainMenuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 442)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "mainMenuForm"
        Me.Text = "Main Menu"
        Me.TabControl1.ResumeLayout(False)
        Me.adminPageTab.ResumeLayout(False)
        Me.adminGB.ResumeLayout(False)
        Me.addAdminGB.ResumeLayout(False)
        Me.addAdminGB.PerformLayout()
        Me.resetPinGB.ResumeLayout(False)
        Me.resetPinGB.PerformLayout()
        Me.welcomeAdminGB.ResumeLayout(False)
        Me.welcomeAdminGB.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.customerPageTab.ResumeLayout(False)
        Me.welcomeGB.ResumeLayout(False)
        Me.welcomeGB.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.authenticatedGB.ResumeLayout(False)
        Me.changePinGB.ResumeLayout(False)
        Me.changePinGB.PerformLayout()
        Me.withdrawGB.ResumeLayout(False)
        Me.withdrawGB.PerformLayout()
        Me.depositGB.ResumeLayout(False)
        Me.depositGB.PerformLayout()
        Me.checkBalanceGB.ResumeLayout(False)
        Me.checkBalanceGB.PerformLayout()
        CType(Me.customersDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents adminPageTab As System.Windows.Forms.TabPage
    Friend WithEvents customerPageTab As System.Windows.Forms.TabPage
    Friend WithEvents authenticatedGB As System.Windows.Forms.GroupBox
    Friend WithEvents withdrawGB As System.Windows.Forms.GroupBox
    Friend WithEvents cashWithdrawalBtn As System.Windows.Forms.Button
    Friend WithEvents cashDepositBtn As System.Windows.Forms.Button
    Friend WithEvents checkBalanceBtn As System.Windows.Forms.Button
    Friend WithEvents depositGB As System.Windows.Forms.GroupBox
    Friend WithEvents checkBalanceGB As System.Windows.Forms.GroupBox
    Friend WithEvents welcomeGB As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents loginBtn As System.Windows.Forms.Button
    Friend WithEvents loginPinTB As System.Windows.Forms.TextBox
    Friend WithEvents loginAccountNumberTB As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents endTransactionBtn As System.Windows.Forms.Button
    Friend WithEvents balanceLbl As System.Windows.Forms.Label
    Friend WithEvents blankGB As System.Windows.Forms.GroupBox
    Friend WithEvents Label99 As System.Windows.Forms.Label
    Friend WithEvents withdrawAmountTB As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents clearWithdrawFieldBtn As System.Windows.Forms.Button
    Friend WithEvents withdrawBtn As System.Windows.Forms.Button
    Friend WithEvents depositClearBtn As System.Windows.Forms.Button
    Friend WithEvents depositBtn As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents depositAmountTB As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents withdrawLbl As System.Windows.Forms.Label
    Friend WithEvents depositLbl As System.Windows.Forms.Label
    Friend WithEvents changePinBtn As System.Windows.Forms.Button
    Friend WithEvents changePinGB As System.Windows.Forms.GroupBox
    Friend WithEvents confirmChangePinBtn As System.Windows.Forms.Button
    Friend WithEvents newPin2TB As System.Windows.Forms.TextBox
    Friend WithEvents newPinTB As System.Windows.Forms.TextBox
    Friend WithEvents oldPinTB As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents adminGB As System.Windows.Forms.GroupBox
    Friend WithEvents resetPinBtn As System.Windows.Forms.Button
    Friend WithEvents trasactionReportBtn As System.Windows.Forms.Button
    Friend WithEvents manageCustomersBtn As System.Windows.Forms.Button
    Friend WithEvents newAdminBtn As System.Windows.Forms.Button
    Friend WithEvents logOutBtn As System.Windows.Forms.Button
    Friend WithEvents resetPinGB As System.Windows.Forms.GroupBox
    Friend WithEvents addAdminGB As System.Windows.Forms.GroupBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents newUsernameTB As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents newPasswordTB As System.Windows.Forms.TextBox
    Friend WithEvents addAdminBtn As System.Windows.Forms.Button
    Friend WithEvents welcomeAdminGB As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents adminLogInBtn As System.Windows.Forms.Button
    Friend WithEvents loginPasswordTB As System.Windows.Forms.TextBox
    Friend WithEvents loginUsernameTB As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents confirmResetPinBtn As System.Windows.Forms.Button
    Friend WithEvents searchCustomerTB As System.Windows.Forms.TextBox
    Friend WithEvents byCB As System.Windows.Forms.ComboBox
    Friend WithEvents customersDGV As System.Windows.Forms.DataGridView
    Friend WithEvents customersIDCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customersAccountNumberCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customersLastNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customersFirstNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customersMiddleNameCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customersPinCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customersAddressCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customersContactNumberCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents customersBalanceCol As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents adminBlankGB As System.Windows.Forms.GroupBox

End Class
