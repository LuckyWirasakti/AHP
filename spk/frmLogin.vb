Imports MySql.Data.MySqlClient

Public Class frmLogin

    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        Dim c As New clsConn
        Dim sqlcmd As MySqlCommand
        Dim sqlrd As MySqlDataReader

        Try
            c.myOpen()
            sqlcmd = New MySqlCommand("SELECT * FROM otentikasi WHERE username = '" & tbxUsername.Text & "' and password = '" & tbxPassword.Text & "'", c.conn)
            sqlrd = sqlcmd.ExecuteReader
            If sqlrd.HasRows Then
                frmMainMenu.Show()
                Hide()
            Else
                MessageBox.Show("Username dan Password Anda Salah")
            End If
            c.myClose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class