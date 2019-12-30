Public Class frmAlternatif
    Dim currID As Integer ' akan menyimpan id dari alternatif untuk sementara di saat mode edit
    Dim c As New clsConn

    Private Sub bersihkan()
        txtNama.Text = ""
        txtKeterangan.Text = ""
    End Sub

    Private Sub modeEdit()
        cmdSimpan.Text = "Simpan"
        cmdTutup.Text = "Batal"
        cmdHapus.Visible = True
    End Sub

    Private Sub modeBaru()
        cmdSimpan.Text = "Tambahkan"
        cmdTutup.Text = "Tutup"
        cmdHapus.Visible = False
        currID = 0
    End Sub

    Private Sub muatTable()
        c.loadTable("SELECT id_alternatif AS 'ID', nama AS 'Nama', informasi AS 'Informasi' FROM alternatif ORDER BY id_alternatif ASC", c.conn)

        If c.sqlDs.Tables.Count > 0 Then
            dgv.DataSource = c.sqlDs.Tables(0)
        Else
            MsgBox("Data tidak ditemukan !", vbInformation + vbOKOnly, c.namaProgram)
        End If
    End Sub

    Private Sub frmAlternatif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bersihkan()
        Call modeBaru()
        Call muatTable()
    End Sub

    Private Sub cmdTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTutup.Click
        If cmdTutup.Text = "Tutup" Then
            Me.Hide()
        Else
            Call bersihkan()
            Call modeBaru()
        End If
    End Sub

    Private Sub cmdHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHapus.Click
        'akan menghapus rekaman yang dimaksud pada table alternatif dan semua relasi yang berhubungan
        If currID > 0 Then
            If MsgBox("Anda yakin untuk menghapus data dengan ID = " & currID, vbCritical + vbYesNo, c.namaProgram) = vbYes Then
                If c.deleteData("alternatif", "id_alternatif", currID) = True Then
                    If c.runSql("DELETE FROM nilai_alternatif WHERE id_alternatif ='" & currID & "'", c.conn) = True Then
                        If c.runSql("DELETE FROM ahp WHERE id_alternatif ='" & currID & "'", c.conn) = True Then
                            MsgBox("Data terhapus", vbInformation + vbOKOnly, c.namaProgram)
                            Call bersihkan()
                            Call modeBaru()
                            Call muatTable()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        If txtNama.Text = "" Or txtNama.Text = Nothing Then
            MsgBox("Harap isi kolom Nama !", vbInformation + vbOKOnly, c.namaProgram)
            Exit Sub
        End If

        If txtKeterangan.Text = "" Or txtKeterangan.Text = Nothing Then
            txtKeterangan.Text = "-"
        End If

        Dim fields() As String = {"nama", "informasi"}
        Dim datas() As String = {txtNama.Text, txtKeterangan.Text}

        If cmdSimpan.Text = "Simpan" Then
            If c.updateData("alternatif", fields, datas, "id_alternatif", currID) = True Then
                MsgBox("Tersimpan", vbInformation + vbOKOnly, c.namaProgram)
                Call bersihkan()
                Call modeBaru()
                Call muatTable()
            End If
        Else
            If c.insertData("alternatif", fields, datas) = True Then
                MsgBox("data telah ditambah", vbInformation + vbOKOnly, c.namaProgram)
                Call bersihkan()
                Call modeBaru()
                Call muatTable()
            End If
        End If
    End Sub

    Private Sub dgv_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgv.Rows(e.RowIndex)
            currID = row.Cells("ID").Value.ToString
            txtNama.Text = row.Cells("Nama").Value.ToString
            txtKeterangan.Text = row.Cells("Informasi").Value.ToString
            Call modeEdit()
        End If
    End Sub
End Class