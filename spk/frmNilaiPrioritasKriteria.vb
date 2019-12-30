Imports MySql.Data.MySqlClient

Public Class frmNilaiPrioritasKriteria
    Dim c As New clsConn
    Dim sqlcmd As MySqlCommand
    Dim sqlrd As MySqlDataReader

    Private Sub cmdTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTutup.Click
        Me.Hide()
    End Sub

    Private Sub dgv_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgv.CellBeginEdit
        e.Cancel = True
    End Sub

    Private Sub frmNilaiPrioritasKriteria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        c.myOpen()
        Try
            sqlcmd = New MySqlCommand("SELECT hasil.id_subkriteria, kriteria.nama_kriteria, hasil.hasil FROM hasil INNER JOIN kriteria ON kriteria.id_kriteria = hasil.id_subkriteria WHERE hasil.id_kriteria = 'all' ORDER BY kriteria.urutan", c.conn)
            sqlrd = sqlcmd.ExecuteReader
            Dim lstIDKriteria As New List(Of String)
            If sqlrd.HasRows = False Then
                MsgBox("Tidak ditemukan data", vbInformation + vbOKOnly, c.namaProgram)
                sqlrd.Close()
                c.myClose()
                Exit Sub
            Else
                dgv.Columns.Add("", "")
                dgv.Rows.Add(3)
                Dim myI As Integer = 0
                While sqlrd.Read = True
                    lstIDKriteria.Add(sqlrd("id_subkriteria").ToString)
                    dgv.Item(myI, 0).Value = sqlrd("nama_kriteria")
                    dgv.Item(myI, 1).Value = Format(sqlrd("hasil"), "0.000")
                    myI += 1
                    dgv.Columns.Add("", "")
                End While
                dgv.Rows(0).DefaultCellStyle.BackColor = Color.Gray
                dgv.Rows(0).DefaultCellStyle.ForeColor = Color.White

                sqlrd.Close()
                c.myClose()

                For i = 0 To lstIDKriteria.Count - 1
                    c.myOpen()
                    sqlcmd = New MySqlCommand("SELECT subkriteria.nama_subkriteria, hasil.hasil FROM hasil INNER JOIN subkriteria ON subkriteria.id_subkriteria = hasil.id_subkriteria WHERE hasil.id_kriteria ='" & lstIDKriteria(i) & "' ORDER BY hasil.hasil DESC", c.conn)
                    sqlrd = sqlcmd.ExecuteReader
                    If sqlrd.HasRows = True Then
                        Dim row As Integer = 3
                        While sqlrd.Read = True
                            If dgv.RowCount < row + 2 Then
                                dgv.Rows.Add(2)
                            End If

                            dgv.Item(i, row).Value = sqlrd("nama_subkriteria")
                            dgv.Item(i, row + 1).Value = Format(sqlrd("hasil"), "0.000")

                            dgv.Rows(row).DefaultCellStyle.BackColor = Color.Gray
                            dgv.Rows(row).DefaultCellStyle.ForeColor = Color.White
                            row += 2
                        End While
                    End If
                    sqlrd.Close()
                    c.myClose()
                Next
            End If
        Catch ex As Exception
            MsgBox("[ERROR:NPK1] " & ex.Message, vbInformation + vbOKOnly, c.namaProgram)
        Finally
            c.myClose()
        End Try

        For Each col As DataGridViewColumn In dgv.Columns
            col.SortMode = DataGridViewColumnSortMode.Programmatic
        Next
    End Sub
End Class