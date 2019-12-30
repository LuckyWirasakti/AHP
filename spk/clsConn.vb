Imports MySql.Data.MySqlClient      'Library mysql
Imports System.String               'Manipulasi String

Public Class clsConn
    Public namaProgram As String = "SPK - AHP"
    Public conn As New MySqlConnection With {.ConnectionString = "server=localhost;userid=root;password=;database=spk"}
    Public sqlDs As DataSet 'akan digunakan untuk pengambilan data ke table

    Public Sub myOpen()
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub

    Public Sub myClose()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Protected Overrides Sub Finalize() 'Destructor
        Call myClose()
    End Sub

    Function runSql(ByVal pStr As String, ByVal pConn As MySqlConnection) As Boolean 'fungsi ini akan mengembalikan nilai boolean, yang dapat berfungsi untuk memeriksa apakah eksekusi berhasil atau tidak
        Dim result As Boolean
        Dim sqlCmd As MySqlCommand
        Try
            Call myOpen()
            sqlCmd = New MySqlCommand(pStr, pConn)
            sqlCmd.ExecuteNonQuery()
            result = True
        Catch ex As Exception
            MsgBox("[ERROR:000] " & ex.Message, vbCritical + vbOKOnly, namaProgram) 'code [ERROR:000] untuk menandai dimana letak error. akan mempermudahkan kita mencari letak kerusakan
            result = False
        Finally
            Call myClose()
        End Try
        Return result
    End Function

    Public Sub loadTable(ByVal pSql As String, ByVal pConn As MySqlConnection)
        Dim sqlCmd As MySqlCommand
        Dim sqlDa As MySqlDataAdapter

        Try
            Call myOpen()
            sqlCmd = New MySqlCommand(pSql, pConn)
            sqlDa = New MySqlDataAdapter(sqlCmd)
            sqlDs = New DataSet
            sqlDa.Fill(sqlDs)
        Catch ex As Exception
            MsgBox("[ERROR:001] " & ex.Message, vbCritical + vbOKOnly, namaProgram)
        Finally
            Call myClose()
        End Try
    End Sub

    Public Function insertData(ByVal pTable As String, ByVal pField() As String, ByVal pData() As String) As Boolean
        'membentuk perintah
        Dim result As Boolean
        Dim query As String = Empty
        Dim daftarField As String = Empty
        Dim daftarData As String = Empty

        If pField.Length = pData.Length Then
            Dim i As Integer = 0
            While i < pField.Length
                If i < 1 Then
                    daftarField = " " & pField(i)
                Else
                    daftarField &= ", " & pField(i)
                End If
                i += 1
            End While

            i = 0
            While i < pData.Length
                If i < 1 Then
                    daftarData = "'" & pData(i) & "'"
                Else
                    daftarData &= ",'" & pData(i) & "'"
                End If
                i += 1
            End While

            query = "INSERT INTO " & pTable & "(" & daftarField & ") VALUES (" & daftarData & ")"

            'eksekusi perintah
            Dim sqlcmd As MySqlCommand
            Try
                Call myOpen()
                sqlcmd = New MySqlCommand(query, conn)
                sqlcmd.ExecuteNonQuery()
                result = True
            Catch ex As Exception
                MsgBox("[ERROR:002] " & ex.Message, vbCritical + vbOKOnly, namaProgram)
                result = False
            Finally
                Call myClose()
            End Try
        Else
            MsgBox("Field dan Data tidak sesuai", vbCritical + vbOKOnly, namaProgram)
            result = False
        End If

        Return result
    End Function

    Public Function updateData(ByVal pTable As String, ByVal pField() As String, ByVal pData() As String, ByVal pFieldKey As String, ByVal pDataKey As String) As Boolean
        Dim result As Boolean
        If pData.Length = pField.Length Then
            Dim query As String = Empty
            Dim str As String = Empty
            Dim i As Integer = 0

            While i < pData.Length
                If i < 1 Then
                    str = " " & pField(i) & "='" & pData(i) & "'"
                Else
                    str &= ", " & pField(i) & "='" & pData(i) & "'"
                End If
                i += 1
            End While

            query = "UPDATE " & pTable & " SET " & str & " WHERE " & pFieldKey & "='" & pDataKey & "'"
            'eksekusi perintah
            Dim sqlcmd As MySqlCommand
            Try
                Call myOpen()
                sqlcmd = New MySqlCommand(query, conn)
                sqlcmd.ExecuteNonQuery()
                result = True
            Catch ex As Exception
                MsgBox("[ERROR:003] " & ex.Message, vbCritical + vbOKOnly, namaProgram)
                result = False
            Finally
                Call myClose()
            End Try
        Else
            MsgBox("Field dan Data tidak sesuai", vbCritical + vbOKOnly, namaProgram)
            result = False
        End If

        Return result
    End Function

    Public Function deleteData(ByVal pTable As String, ByVal pField As String, ByVal pKey As String) As Boolean
        Dim result As Boolean
        Dim sqlcmd As MySqlCommand
        Dim strcmd As String = "DELETE FROM " & pTable & " WHERE " & pField & " = '" & pKey & "'"

        Try
            Call myOpen()
            sqlcmd = New MySqlCommand(strcmd, conn)
            sqlcmd.ExecuteNonQuery()
            result = True
        Catch ex As Exception
            MsgBox("[ERROR:004] " & ex.Message, vbCritical + vbOKOnly, namaProgram)
            result = False
        Finally
            Call myClose()
        End Try
        Return result
    End Function

    Public Function ifExist(ByVal table As String, ByVal parameter() As String, ByVal parameterValue() As String) As Boolean
        Dim result As Boolean = False

        If parameter.Length = parameterValue.Length Then
            Dim sqlcmd As MySqlCommand
            Dim sqlrd As MySqlDataReader
            Dim strparameter As String = Empty

            Dim i As Integer = 0
            While i < parameter.Length
                If i < 1 Then
                    strparameter = " " & parameter(i) & "='" & parameterValue(i) & "'"
                Else
                    strparameter &= " and " & parameter(i) & "='" & parameterValue(i) & "'"
                End If
                i += 1
            End While

            Try
                Call myOpen()
                sqlcmd = New MySqlCommand("SELECT * FROM " & table & " WHERE " & strparameter, conn)
                sqlrd = sqlcmd.ExecuteReader
                sqlrd.Read()
                result = sqlrd.HasRows
                sqlrd.Close()
            Catch ex As Exception
                MsgBox("[ERROR:005] " & ex.Message, vbCritical + vbOKOnly, namaProgram)
                result = False
            Finally
                Call myClose()
            End Try
        Else
            result = False
            MsgBox("Ukuran parameter tidak sama !", vbCritical + vbOKOnly, namaProgram)
        End If

        Return result
    End Function

    Function getList(ByVal table As String, ByVal field As String) As String()
        Dim query As String = "SELECT " & field & " FROM " & table & " "
        Dim lst As New List(Of String)

        Dim sqlcmd As MySqlCommand
        Dim sqlrd As MySqlDataReader
        Try
            Call myOpen()
            sqlcmd = New MySqlCommand(query, conn)
            sqlrd = sqlcmd.ExecuteReader
            While sqlrd.Read = True
                lst.Add(sqlrd(0))
            End While
            sqlrd.Close()
        Catch ex As Exception
            lst = Nothing
            MsgBox("[ERROR:006] " & ex.Message, vbCritical + vbOKOnly, namaProgram)
        Finally
            myClose()
        End Try

        Return lst.ToArray
    End Function

    Function getList(ByVal table As String, ByVal field As String, ByVal orderby As String) As String()
        Dim query As String = "SELECT " & field & " FROM " & table & " ORDER BY " & orderby & " asc"
        Dim lst As New List(Of String)

        Dim sqlcmd As MySqlCommand
        Dim sqlrd As MySqlDataReader
        Try
            Call myOpen()
            sqlcmd = New MySqlCommand(query, conn)
            sqlrd = sqlcmd.ExecuteReader
            While sqlrd.Read = True
                lst.Add(sqlrd(0))
            End While
            sqlrd.Close()
        Catch ex As Exception
            lst = Nothing
            MsgBox("[ERROR:007] " & ex.Message, vbCritical + vbOKOnly, namaProgram)
        Finally
            Call myClose()
        End Try
        Return lst.ToArray
    End Function

    Function getList(ByVal table As String, ByVal field As String, ByVal parameter As String, ByVal parameterValue As String, ByVal orderby As String) As String()
        Dim query As String = "SELECT " & field & " FROM " & table & " WHERE " & parameter & " = '" & parameterValue & "' ORDER BY " & orderby & " asc"
        Dim lst As New List(Of String)

        Dim sqlcmd As MySqlCommand
        Dim sqlrd As MySqlDataReader
        Try
            Call myOpen()
            sqlcmd = New MySqlCommand(query, conn)
            sqlrd = sqlcmd.ExecuteReader
            While sqlrd.Read = True
                lst.Add(sqlrd(0))
            End While
            sqlrd.Close()
        Catch ex As Exception
            lst = Nothing
            MsgBox("[ERROR:008] " & ex.Message, vbCritical + vbOKOnly, namaProgram)
        Finally
            Call myClose()
        End Try
        Return lst.ToArray
    End Function
End Class
