# PBDITSoftEngGroupProject
PBDIT Software Engineering Group Project (ATM)

# Group Project

Create a simple ATM program written in VB.NET.

Deadline of submission: November 7, 2015

Provide test cases for this project. (See last page for more information). Put your Project Source code in CD, user’s manual together with the test cases written in a spread sheet program (MS Excel).

A local bank intends to install a new automated teller machine to allow users (bank customers) to perform basic transactions

Initial specifications of a simple ATM program

	1. Each user (bank customer) can have only one account at the bank.

	2. The ATM user (bank customer) can
			a. View their account balance
			b. Withdraw cash
			c. Deposit funds

	3. The ATM Admin user can
			a. Create, update and delete customers account.
			b. Display customers’ transactions (both withdrawal and deposits) for the day

	4. There must be a user interface (Windows Form) for searching, creating, updating, and deleting customer accounts. Customer information must be saved in MS Access Database.

	5. When performing transactions, customer information must be retrieved from MS Access Database.

	6. There must be a user interface for deposits

	7. There must be a user interface for withdrawals.

	8. There must be a user interface for balance inquiry.

	9. There must be a report facility that displays all transactions (deposits and withdrawals) for the day.

	10.There must be data validation such as:
			a. Cannot withdraw more than the deposited amount.
			b. Cannot input an invalid amount.
			c. Customer must provide his/her account number and PIN when depositing, withdrawing and inquiring an amount.


# Assumptions
	1. The bank does not make any changes to the information in the database while using an ATM.

	2. There is unlimited cash in the ATM cash dispenser.

	3. There is no maintaining balance.

	4. For each account, the maximum total withdrawal amount for the day is 20,000 pesos.

	5. For each account, the maximum total deposit amount for the day is 50,000 pesos.

	6. PIN must be encrypted in the database. Use the SimplePINEncryption() function before saving the plain-text PIN to the database. Likewise, just use the same function to revert the encrypted PIN to plain-text.

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


	7. The bank trusts the ATM to access and manipulate the information in the database without significant security measures. Other complicated security issues are beyond of the project scope.


# ATM Sequence of Events

	# The admin user should experience the following events when maintaining bank customer records.

		1. The screen displays an ATM Admin screen which displays the following operations: “MANAGE Customer Info”, “RESET PIN”, “DISPLAY Transaction Report”

		2. When an admin user selects “MANAGE Customer Info”, a CRUD Screen is displayed

		3. When an admin user selects “RESET PIN”, a Reset PIN Screen is displayed.

		4. When an admin user selects “DISPLAY Transaction Report”, a Report Screen is displayed showing all transactions for the day. 


	# The (user) bank customer should experience the following sequence of events during authentication process:

		1. The screen displays “WELCOME to our BANK” and prompts the user to enter an account number and input a 6 digit account number.

		2. The screen prompts the user to input the 4 digit PIN associated with the specified account number

		3. If the user input a valid account number and the correct PIN, the screen displays the main menu. If the user input an invalid account number or an incorrect PIN, the screen displays “Invalid Account Number/Wrong PIN” and return to step 1 to restart the authentication process.


		After the ATM authenticates the user, the ATM main menu displays three (3) types of transactions: BALANCE INQUIRY, CASH WITHDRAWAL and CASH DEPOSIT. Also, there’s an option for the user to EXIT the system if he/she wishes to.

		If the user selects a “BALANCE INQUIRY”, the screen displays the user’s account balance. The ATM must retrieve the balance from the bank database. 


	# The (user) bank customer should experience the following sequence of events when a “WITHDRAWAL” is being selected.

		1. The screen displays a menu of standard withdrawal amount and an option to cancel the transaction.

		2. The user inputs desired withdrawal amount

		3. If the withdrawal amount is greater than the user’s account balance, the screen displays a message stating “Insufficient fund, please input smaller amount.” Then go back to step 1.

		4. If the withdrawal amount is less than or equal to the user’s account balance, the ATM debits the withdrawal amount from the user’s account in the bank’s database.

		5. If the withdrawal amount exceeds the withdrawal limit for the day the screen displays “Exceeded withdrawal limit.” Then proceed to step 1.

		6.

		7. The screen displays “Please take the money” and displays the remaining balance.

		8. Then go back to authentication process where a message displays “WELCOME to our BANK”


	# The (user) bank customer should experience the following sequence of events when a “DEPOSIT” is being selected.

		1. The screen prompts the user to input a deposit amount and an option to cancel the transaction.

		2. The user inputs desired deposit amount.

		3. If the deposit amount is zero or negative then the screen displays a message stating “Invalid deposit amount, please input an amount.” Then go back to step 1.

		4. If the deposit amount exceeds the maximum deposit amount then the screen displays a message “Exceeded maximum deposit”. Then proceed to step 1.

		5. The screen displays “Please insert the deposit envelop”. 

		6. The ATM credits the deposit amount from the user’s account in the bank’s database. (adds the deposit amount to the user’s account in the database)

		7. Then go back to authentication process where a message displays “WELCOME to our BANK”


# What is a test case?
“A test case has components that describe an input, action or event and an expected response, to determine if a feature of an application is working correctly.

Parts of a Test Case:

	Test ID – a unique identifier based on the given scenario

	Description – Describes a scenario to test. It has two parts:

		Pre-condition must be met in order for the test case to run and, Enter List of variables and their possible values used in the test case. 
		You can list specific values or describe value ranges. The test case should be performed once for each combination of values

	Expected Result – Expected outcome after execution of the given test.

	Actual Result - Actual result which is based on your running ATM program

	Pass/Fail – The test pass if the actual result meets the expected outcome of your test

Keep in mind while writing test cases that all your test cases should be simple and easy to understand. Don’t write explanations like essays. Be to the point.