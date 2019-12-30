Public Class frmKriteria
    Dim c As New clsConn
    Dim currID As Integer 'untuk menyimpan id sementara pada saat mode edit

    Private Sub bersihkan()
        nudUrutan.Value = 1
        txtNama.Text = ""
        txtKeterangan.Text = ""
    End Sub

    Private Sub modeEdit()
        gbx.Text = "Penyuntingan"
        cmdSimpan.Text = "Simpan"
        cmdTutup.Text = "Batal"
        cmdHapus.Visible = True
    End Sub

    Private Sub modeBaru()
        gbx.Text = "Input data baru"
        cmdSimpan.Text = "Tambahkan"
        cmdTutup.Text = "Tutup"
        cmdHapus.Visible = False
        currID = 0
    End Sub

    Private Sub muatTable()
        c.loadTable("SELECT id_kriteria AS 'ID', urutan AS 'Nomer urut', nama_kriteria AS 'Nama Kriteria', keterangan AS 'Keterangan' FROM kriteria ORDER BY urutan ASC", c.conn)

        c.myOpen()
        If c.sqlDs.Tables.Count > 0 Then
            dgv.DataSource = c.sqlDs.Tables(0)
        End If
        c.myClose()

        dgv.Columns(0).Width = 30
        dgv.Columns(1).Width = 100
        dgv.Columns(2).Width = 120
        dgv.Columns(3).Width = 200
    End Sub

    Private Sub frmKriteria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call bersihkan()
        Call muatTable()
        Call modeBaru()
    End Sub

    Private Sub dgv_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgv.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgv.Rows(e.RowIndex)
            currID = row.Cells("ID").Value.ToString
            txtNama.Text = row.Cells("Nama Kriteria").Value.ToString
            nudUrutan.Value = row.Cells("Nomer urut").Value.ToString
            txtKeterangan.Text = row.Cells("Keterangan").Value.ToString
            Call modeEdit()
        End If
    End Sub

    Private Sub cmdTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTutup.Click
        If cmdTutup.Text = "Tutup" Then
            Me.Hide()
        Else
            Call bersihkan()
            Call modeBaru()
        End If
    End Sub


    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
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

        Dim lstField() As String = {"nama_kriteria", "urutan", "keterangan"}
        Dim lstData() As String = {txtNama.Text, nudUrutan.Value, txtKeterangan.Text}

        If cmdSimpan.Text = "Tambahkan" Then
            If c.insertData("kriteria", lstField, lstData) = True Then
                MsgBox("Data Telah Ditambahkan", vbInformation + vbOKOnly, c.namaProgram)
                Call bersihkan()
                Call muatTable()
                Call modeBaru()
            End If
        Else
            If c.updateData("kriteria", lstField, lstData, "id_kriteria", currID) = True Then
                MsgBox("Tersimpan", vbInformation + vbOKOnly, c.namaProgram)
                Call bersihkan()
                Call muatTable()
                Call modeBaru()
            End If
        End If
    End Sub

    Private Sub cmdHapus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdHapus.Click
        If currID > 0 Then
            If MsgBox("Apakah anda yakin untuk menghapus rekaman dengan ID = " & currID, vbCritical + vbYesNo, c.namaProgram) = vbYes Then
                If c.deleteData("kriteria", "id_kriteria", currID) = True Then
                    If c.runSql("DELETE FROM subkriteria WHERE id_kriteria ='" & currID & "'", c.conn) = True Then
                        If c.runSql("DELETE FROM pb WHERE kriteria = '" & currID & "' OR rowindex ='" & currID & "' OR colindex ='" & currID & "'", c.conn) = True Then
                            If c.runSql("DELETE FROM nilai_alternatif WHERE id_kriteria ='" & currID & "'", c.conn) = True Then
                                If c.runSql("DELETE FROM hasil WHERE id_kriteria='all' AND id_subkriteria ='" & currID & "'", c.conn) = True Then
                                    MsgBox("Data Telah dihapus", vbInformation + vbOKOnly, c.namaProgram)
                                    Call bersihkan()
                                    Call muatTable()
                                    Call modeBaru()
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub
End Class