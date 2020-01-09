Imports MySql.Data.MySqlClient

Public Class frmLogin

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim mycmd As MySqlCommand
        Dim mysqlcon As MySqlConnection
        Dim read As MySqlDataReader
        Try
            mysqlcon = New MySqlConnection("server=localhost;user id=root;database=spk")
            mysqlcon.Open()
            mycmd = New MySqlCommand("SELECT * FROM otentikasi WHERE username = '" & tbxUsername.Text & "' and password = '" & tbxPassword.Text & "'", mysqlcon)
            read = mycmd.ExecuteReader
            Dim count As Integer
            count = 0
            While read.Read
                count = count + 1
            End While
            mysqlcon.Close()
            If count = 1 Then
                frmMainMenu.Show()
                Hide()
            ElseIf count > 1 Then
                MessageBox.Show("Username dan Password Sama")
            Else
                MessageBox.Show("Username dan Password Anda Salah")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class