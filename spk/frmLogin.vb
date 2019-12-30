Imports MySql.Data.MySqlClient

Public Class frmLogin

    Dim c As New clsConn

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If (MessageBox.Show("Anda yakin akan Keluar?", "Keluar", MessageBoxButtons.OKCancel) = DialogResult.OK) Then
            Close()
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            Dim query As String = "SELECT * FROM otentikasi WHERE username = '" & txtUsername.Text & "' AND password = '" & txtPassword.Text & "'"
            Dim sqlcmd As MySqlCommand
            Dim sqlrd As MySqlDataReader

            c.myOpen()
            sqlcmd = New MySqlCommand(query, c.conn)
            sqlrd = sqlcmd.ExecuteReader
            sqlrd.Read()
            If sqlrd.HasRows Then
                Dim frm As New frmMainMenu
                frm.Show()
                Hide()
            Else
                MsgBox("Username atau Password yang anda masukkan salah")
                txtUsername.Clear()
                txtPassword.Clear()
            End If
            c.myClose()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class