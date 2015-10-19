Imports System.Data.OleDb

Module DatabaseConnection
    Dim dbCon As OleDbConnection = New OleDbConnection
    Dim recordReader As OleDbDataReader
    Dim cmd As OleDbCommand
    Dim sql As String

    Public Function selectQuery(ByVal _tableName As String, ByVal _fields As String, ByVal _condition As String) As OleDbDataReader
        If connectionEstablished() Then
            sql = "SELECT " & _fields & " FROM `" & _tableName & "` WHERE " & _condition

            Console.Out.WriteLine(sql)

            cmd = New OleDbCommand(sql, dbCon)
            recordReader = cmd.ExecuteReader()

            selectQuery = recordReader
        Else
            selectQuery = Nothing
            MsgBox("Error: can't establish connection to database", MsgBoxStyle.Critical)
        End If
    End Function

    Public Function addQuery(ByVal _tableName As String, ByVal _fields As String, ByVal _values As String) As Boolean
        If connectionEstablished() Then
            sql = "INSERT INTO `" & _tableName & "` (" & _fields & ") VALUES(" & _values & ")"

            Console.Out.WriteLine(sql)

            Try
                cmd = New OleDbCommand(sql, dbCon)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                addQuery = True
            Catch ex As Exception
                addQuery = False
                MsgBox("Error Adding Record: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                dbCon.Close()
            End Try
        Else
            addQuery = False
            MsgBox("Error: can't establish connection to database", MsgBoxStyle.Critical)
        End If
    End Function

    Public Function updateQuery(ByVal _tableName As String, ByVal _fields As Array, ByVal _values As Array, ByVal _condition As String) As Boolean
        If connectionEstablished() Then
            sql = "UPDATE `" & _tableName & "` SET "

            For i As Integer = 0 To _fields.Length - 1
                sql &= "[" & _fields(i) & "]=" & _values(i)

                If i < _fields.Length - 1 Then
                    sql &= ", "
                End If
            Next

            sql &= " WHERE " & _condition

            Try
                cmd = New OleDbCommand(sql, dbCon)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                updateQuery = True
            Catch ex As Exception
                updateQuery = False
                MsgBox("Error Updating Record: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                dbCon.Close()
            End Try
        Else
            updateQuery = False
            MsgBox("Error: can't establish connection to database", MsgBoxStyle.Critical)
        End If
    End Function

    Public Function deleteQuery(ByVal _tableName As String, ByVal _condition As String) As Boolean
        If connectionEstablished() Then
            sql = "DELETE FROM `" & _tableName & "` WHERE " & _condition

            Try
                cmd = New OleDbCommand(sql, dbCon)
                cmd.ExecuteNonQuery()
                cmd.Dispose()

                deleteQuery = True
            Catch ex As Exception
                deleteQuery = False
                MsgBox("Error Deleting Record: " & ex.Message, MsgBoxStyle.Critical)
            Finally
                dbCon.Close()
            End Try
        Else
            deleteQuery = False
            MsgBox("Error: can't establish connection to database", MsgBoxStyle.Critical)
        End If
    End Function

    Public Function connectionEstablished() As Boolean
        Try
            If dbCon.State = ConnectionState.Closed Then
                dbCon.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\PBDITSoftwareEngineeringGroupProjectDB.mdb"
                dbCon.Open()
                connectionEstablished = True
            Else
                If dbCon.State = ConnectionState.Open Then
                    connectionEstablished = True
                Else
                    connectionEstablished = False
                End If
            End If
        Catch ex As Exception
            MsgBox("Error Establishing Connetion: " & ex.Message)
            connectionEstablished = False
        End Try
    End Function
End Module
