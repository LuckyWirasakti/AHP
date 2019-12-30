Public Class frmSubKriteria
    Dim c As New clsConn
    Dim myIDkriteria() As String

    Dim currID As Integer

    Private Sub bersihkan()
        cmbPilihKriteria.Text = "-- Pilih --"
        nudUrutan.Value = 1
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

    Private Sub loadCMB()
        Dim lstKriteria() As String = c.getList("kriteria", "nama_kriteria", "urutan")
        cmbKriteria.Items.Clear()
        cmbPilihKriteria.Items.Clear()
        cmbKriteria.Items.Clear()
        cmbKriteria.Items.Add("All")
        For Each item As Object In lstKriteria
            cmbKriteria.Items.Add(item)
            cmbPilihKriteria.Items.Add(item)
        Next
        cmbKriteria.Text = "All"

        'get id
        myIDkriteria = c.getList("kriteria", "id_kriteria", "urutan")
    End Sub

    Private Sub muatTable()
        If cmbKriteria.Text = "All" Then
            c.loadTable("SELECT subkriteria.id_subkriteria AS 'ID', kriteria.nama_kriteria AS 'Kriteria', subkriteria.urutan AS 'Nomer urut', subkriteria.nama_subkriteria AS 'Nama Sub Kriteria', subkriteria.keterangan AS 'Keterangan' FROM subkriteria INNER JOIN kriteria ON kriteria.id_kriteria = subkriteria.id_kriteria ORDER BY kriteria.nama_kriteria ASC", c.conn)
        Else
            c.loadTable("SELECT subkriteria.id_subkriteria AS 'ID', kriteria.nama_kriteria AS 'Kriteria', subkriteria.urutan AS 'Nomer urut', subkriteria.nama_subkriteria AS 'Nama Sub Kriteria', subkriteria.keterangan AS 'Keterangan' FROM subkriteria INNER JOIN kriteria on kriteria.id_kriteria = subkriteria.id_kriteria AND kriteria.nama_kriteria = '" & cmbKriteria.Text & "' ORDER BY subkriteria.urutan", c.conn)
        End If

        If c.sqlDs.Tables.Count > 0 Then
            dgv.DataSource = c.sqlDs.Tables(0)
        Else
            MsgBox("Data Kosong !", vbInformation + vbOKOnly, "SPK - AHP")
        End If
    End Sub

    Private Sub frmSubKriteria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bersihkan()
        Call loadCMB()
        Call muatTable()
        Call modeBaru()
    End Sub

    Private Sub cmbKriteria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbKriteria.SelectedIndexChanged
        Call muatTable()
    End Sub

    Private Sub cmdTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTutup.Click
        If cmdTutup.Text = "Tutup" Then
            Me.Hide()
        Else
            Call modeBaru()
            Call bersihkan()
        End If
    End Sub

    Private Sub dgv_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgv.Rows(e.RowIndex)
            currID = row.Cells("ID").Value.ToString
            cmbPilihKriteria.Text = row.Cells("Kriteria").Value.ToString
            nudUrutan.Value = row.Cells("Nomer urut").Value.ToString
            txtNama.Text = row.Cells("Nama Sub Kriteria").Value.ToString
            txtKeterangan.Text = row.Cells("Keterangan").Value.ToString
            Call modeEdit()
        End If
    End Sub

    Private Sub cmdHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHapus.Click
        If currID > 0 Then
            If MsgBox("Apakah anda yakin untuk menghapus data dengan ID = " & currID, vbCritical + vbYesNo, c.namaProgram) = vbYes Then
                If c.deleteData("subkriteria", "id_subkriteria", currID) Then
                    'hapus semua relasi
                    If c.runSql("DELETE FROM pb WHERE kriteria ='" & myIDkriteria(cmbPilihKriteria.SelectedIndex) & "' AND (rowindex ='" & currID & "' OR colindex = '" & currID & "')", c.conn) = True Then
                        If c.runSql("DELETE FROM nilai_alternatif WHERE id_kriteria = '" & myIDkriteria(cmbPilihKriteria.SelectedIndex) & "' AND id_subkriteria ='" & currID & "'", c.conn) = True Then
                            If c.runSql("DELETE FROM hasil WHERE id_kriteria ='" & myIDkriteria(cmbPilihKriteria.SelectedIndex) & "' AND id_subkriteria ='" & currID & "'", c.conn) Then
                                MsgBox("Data Terhapus", vbInformation + vbOKOnly, c.namaProgram)
                                Call modeBaru()
                                Call bersihkan()
                                Call muatTable()
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub


    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        If cmbPilihKriteria.Text = "-- Pilih --" Or cmbPilihKriteria.Text = "" Then
            MsgBox("Harap pilih kriteria !", vbInformation + vbOKOnly, c.namaProgram)
            Exit Sub
        End If

        If txtNama.Text = "" Or txtNama.Text = Nothing Then
            MsgBox("Harap isi kolom Nama !", vbInformation + vbOKOnly, c.namaProgram)
            Exit Sub
        End If

        If nudUrutan.Value = Nothing Or nudUrutan.Value <= 0 Then
            MsgBox("Harap isi kolom nomer urutan dengan benar !", vbInformation + vbOKOnly, c.namaProgram)
            Exit Sub
        End If

        If txtKeterangan.Text = "" Or txtKeterangan.Text = Nothing Then
            txtKeterangan.Text = "-"
        End If

        Dim fields() As String = {"id_kriteria", "nama_subkriteria", "urutan", "keterangan"}
        Dim datas() As String = {myIDkriteria(cmbPilihKriteria.SelectedIndex), txtNama.Text, nudUrutan.Value, txtKeterangan.Text}

        If cmdSimpan.Text = "Simpan" Then
            If c.updateData("subkriteria", fields, datas, "id_subkriteria", currID) = True Then
                MsgBox("Data Telah Tersimpan", vbInformation + vbOKOnly, c.namaProgram)
                Call modeBaru()
                Call bersihkan()
                Call muatTable()
            End If
        Else
            If c.insertData("subkriteria", fields, datas) = True Then
                MsgBox("Data Telah Ditambahkan", vbInformation + vbOKOnly, c.namaProgram)
                Call modeBaru()
                Call bersihkan()
                Call muatTable()
            End If
        End If
    End Sub
End Class