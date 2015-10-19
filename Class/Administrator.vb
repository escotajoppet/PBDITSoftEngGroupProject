Imports System.Data.OleDb

Public Class Administrator
    Public Property id As Integer
    Public Property username As String
    Public Property password As String

    Public Sub New(ByVal _id As Integer)
        Dim table As String = "administrators"
        Dim fields As String = "[username], [password]"
        Dim condition As String = "[id]=" & _id

        Dim recordReader As OleDbDataReader = selectQuery(table, fields, condition)

        While recordReader.Read() = True
            Me.id = _id
            Me.username = recordReader.Item("username")
            Me.password = recordReader.Item("password")
        End While

        recordReader.Close()
    End Sub

    Public Shared Sub generateInitialAdmin()
        Dim table As String = "administrators"
        Dim fields As String = "[id]"
        Dim condition As String = "1"

        Dim recordReader As OleDbDataReader = selectQuery(table, fields, condition)

        If Not recordReader.HasRows Then
            Dim message As String = Administrator.addAdministrator("admin", "21232f297a57a5a743894a0e4a801fc3")

            Console.Out.WriteLine(message)
        End If
    End Sub

    Public Shared Function addAdministrator(ByVal _username As String, ByVal _password As String) As String
        Dim table As String = "administrators"
        Dim fields As String = "[username], [password]"
        Dim values As String = "'" & _username & "', '" & _password & "'"

        If addQuery(table, fields, values) Then
            addAdministrator = "Administrator ADDED: " & _username
        Else
            addAdministrator = "Error Adding Administrator"
        End If
    End Function

    Public Shared Function authenticated(ByVal _username As String, ByVal _password As String) As String
        Dim recordReader As OleDbDataReader

        Dim table As String = "administrators"
        Dim fields As String = "[id]"
        Dim condition As String = "[username]='" & _username.ToString & "' AND [password]='" & _password & "'"

        recordReader = selectQuery(table, fields, condition)

        If recordReader.HasRows Then
            authenticated = ""
        Else
            authenticated = "Error Authentication: Invalid Username/Wrong Password"
        End If

        recordReader.Close()
    End Function
End Class
