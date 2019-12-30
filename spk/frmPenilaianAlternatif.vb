Imports MySql.Data.MySqlClient

Public Class frmPenilaianAlternatif
    Dim c As New clsConn
    Dim namaAlternatif() As String
    Dim idAlternatif() As String

    Dim namaKriteria() As String
    Dim idKriteria() As String

    Dim namaSubKriteria() As String
    Dim idSubkriteria() As String

    Private Sub setHeader()
        dgv.Columns.Add("ID", "ID")
        dgv.Columns.Add("Nama", "Nama")
        'Load Kriteria
        For Each item As Object In namaKriteria
            dgv.Columns.Add(item, item)
        Next

        For Each col As DataGridViewColumn In dgv.Columns
            col.SortMode = DataGridViewColumnSortMode.Programmatic
        Next
    End Sub

    Private Sub loadRecord()
        'load data alternaitf 
        namaAlternatif = c.getList("alternatif", "nama", "id_alternatif")
        idAlternatif = c.getList("alternatif", "id_alternatif", "id_alternatif")

        If namaAlternatif.Any = True Then
            dgv.Rows.Add(namaAlternatif.Length)
            For i = 0 To namaAlternatif.Length - 1
                dgv.Item(0, i).Value = idAlternatif(i)
                dgv.Item(1, i).Value = namaAlternatif(i)
            Next
        End If

        Dim sqlcmd As MySqlCommand
        Dim sqlrd As MySqlDataReader
        Try
            c.myOpen()
            sqlcmd = New MySqlCommand("SELECT nilai_alternatif.id_alternatif, nilai_alternatif.id_kriteria, nilai_alternatif.id_subkriteria, subkriteria.nama_subkriteria FROM nilai_alternatif INNER JOIN subkriteria ON subkriteria.id_subkriteria = nilai_alternatif.id_subkriteria", c.conn)
            sqlrd = sqlcmd.ExecuteReader
            If sqlrd.HasRows = True Then
                While sqlrd.Read = True
                    dgv.Item(Array.IndexOf(idKriteria, sqlrd("id_kriteria").ToString) + 2, Array.IndexOf(idAlternatif, sqlrd("id_alternatif").ToString)).Value = sqlrd("nama_subkriteria")
                End While
            Else
                MsgBox("Tidak ditemukan nilai", vbCritical + vbOKOnly, c.namaProgram)
            End If
        Catch ex As Exception
            MsgBox("[ERROR:PA01] " & ex.Message, vbCritical + vbOKOnly, c.namaProgram)
        Finally
            sqlrd.Close()
            c.myClose()
        End Try
    End Sub

    Private Sub bersihkan()
        For i = 0 To dgv.Columns.Count - 1
            For j = 0 To dgv.Rows.Count - 1
                dgv.Item(i, j).Value = ""
            Next
        Next
    End Sub


    Private Sub frmPenilaianAlternatif_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        namaAlternatif = c.getList("alternatif", "nama", "id_alternatif")
        idAlternatif = c.getList("alternatif", "id_alternatif", "id_alternatif")

        If namaAlternatif.Any = False Then
            MsgBox("Alternatif tidak ditemukan", vbOKOnly + vbInformation, c.namaProgram)
        Else
            namaKriteria = c.getList("kriteria", "nama_kriteria", "urutan")
            idKriteria = c.getList("kriteria", "id_kriteria", "urutan")

            If namaKriteria.Any = False Then
                MsgBox("Kriteria tidak ditemukan", vbOKOnly + vbInformation, c.namaProgram)
            Else
                Call setHeader()
                Call bersihkan()
                Call loadRecord()
            End If
        End If
    End Sub

    Private Sub cmdTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTutup.Click
        Me.Hide()
    End Sub

    Private Sub dgv_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgv.CellBeginEdit
        If e.ColumnIndex > 1 Then
            If e.RowIndex >= 0 Then
                If e.RowIndex < namaAlternatif.Length Then
                    Dim cmbsub As New DataGridViewComboBoxCell
                    Dim sqlcmd As MySqlCommand
                    Dim sqlrd As MySqlDataReader
                    Try
                        c.myOpen()
                        sqlcmd = New MySqlCommand("SELECT nama_subkriteria FROM subkriteria WHERE id_kriteria ='" & idKriteria(Array.IndexOf(namaKriteria, dgv.Columns(e.ColumnIndex).HeaderText.ToString)) & "'", c.conn)
                        sqlrd = sqlcmd.ExecuteReader
                        cmbsub.Items.Clear()
                        While sqlrd.Read = True
                            cmbsub.Items.Add(sqlrd("nama_subkriteria"))
                        End While
                        dgv.Item(e.ColumnIndex, e.RowIndex) = cmbsub
                    Catch ex As Exception
                        MsgBox("[ERROR:PA02] " & ex.Message, vbCritical + vbOKOnly, c.namaProgram)
                    Finally
                        sqlrd.Close()
                        c.myClose()
                    End Try
                Else
                    e.Cancel = True
                End If
            Else
                e.Cancel = True
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        Dim terisi As Boolean = True
        For i = 2 To dgv.ColumnCount - 1
            For j = 0 To namaAlternatif.Length - 1
                If dgv.Item(i, j).Value = "" Then
                    terisi = False
                End If
            Next
        Next

        If terisi = True Then
            Dim sqlcmd As MySqlCommand
            Dim sqlrd As MySqlDataReader

            c.myOpen()
            sqlcmd = New MySqlCommand("DELETE FROM nilai_alternatif", c.conn)
            sqlcmd.ExecuteNonQuery()

            For i = 2 To dgv.ColumnCount - 1
                For j = 0 To namaAlternatif.Length - 1
                    c.myOpen()
                    Dim fields() As String = {"id_alternatif", "id_kriteria", "id_subkriteria"}
                    sqlcmd = New MySqlCommand("SELECT id_subkriteria FROM subkriteria WHERE nama_subkriteria ='" & dgv.Item(i, j).Value.ToString & "' AND id_kriteria ='" & idKriteria(Array.IndexOf(namaKriteria, dgv.Columns(i).HeaderText.ToString)) & "'", c.conn)
                    sqlrd = sqlcmd.ExecuteReader
                    sqlrd.Read()
                    Dim datas() As String = {dgv.Item(0, j).Value.ToString, idKriteria(Array.IndexOf(namaKriteria, dgv.Columns(i).HeaderText.ToString)), sqlrd("id_subkriteria")}
                    sqlrd.Close()
                    c.myClose()
                    c.insertData("nilai_alternatif", fields, datas)
                Next
            Next
            c.myOpen()
            MsgBox("Tersimpan", vbInformation + vbOKOnly, c.namaProgram)
        Else
            MsgBox("Mohon isi dengan benar", vbInformation + vbOKOnly, c.namaProgram)
        End If
    End Sub
End Class