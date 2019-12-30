Imports MySql.Data.MySqlClient
Imports System.String

Public Class frmPBKriteria
    Dim c As New clsConn
    Dim namaKriteria() As String
    Dim idKriteria() As String

    Dim jlhBulat As Integer = 3

    Private Sub setHeader()
        namaKriteria = c.getList("kriteria", "nama_kriteria", "urutan")
        idKriteria = c.getList("kriteria", "id_kriteria", "urutan")

        dgvPB.Columns.Clear()
        For Each item As Object In namaKriteria
            dgvPB.Columns.Add(item, item)
            dgvPrioritas.Columns.Add(item, item)
            dgvPenjumlahan.Columns.Add(item, item)
        Next

        dgvPB.Rows.Add(namaKriteria.Length)
        dgvPrioritas.Rows.Add(namaKriteria.Length)
        dgvPenjumlahan.Rows.Add(namaKriteria.Length)

        dgvRasio.Columns.Add("", "Jumlah per baris")
        dgvRasio.Columns.Add("", "Prioritas")
        dgvRasio.Columns.Add("", "Hasil")

        dgvRasio.Rows.Add(namaKriteria.Length)
        For i As Integer = 0 To (namaKriteria.Length - 1)
            dgvPB.Rows(i).HeaderCell.Value = namaKriteria(i)
            dgvPrioritas.Rows(i).HeaderCell.Value = namaKriteria(i)
            dgvPenjumlahan.Rows(i).HeaderCell.Value = namaKriteria(i)
            dgvRasio.Rows(i).HeaderCell.Value = namaKriteria(i)
        Next
        For Each col As DataGridViewColumn In dgvPB.Columns
            col.SortMode = DataGridViewColumnSortMode.Programmatic
        Next
        For Each col As DataGridViewColumn In dgvPrioritas.Columns
            col.SortMode = DataGridViewColumnSortMode.Programmatic
        Next
        For Each col As DataGridViewColumn In dgvPenjumlahan.Columns
            col.SortMode = DataGridViewColumnSortMode.Programmatic
        Next
        For Each col As DataGridViewColumn In dgvRasio.Columns
            col.SortMode = DataGridViewColumnSortMode.Programmatic
        Next
        For Each col As DataGridViewColumn In dgvHasil.Columns
            col.SortMode = DataGridViewColumnSortMode.Programmatic
        Next

        dgvPB.Rows(namaKriteria.Length).HeaderCell.Value = "Jumlah"
        dgvPrioritas.Rows(namaKriteria.Length).HeaderCell.Value = "Jumlah"
        dgvPenjumlahan.Columns.Add("", "Jumlah")
        dgvRasio.Rows(namaKriteria.Length).HeaderCell.Value = "Jumlah"

        dgvPrioritas.Columns.Add("", "Jumlah per baris")
        dgvPrioritas.Columns.Add("", "Prioritas")

        dgvHasil.Columns.Add("", "Hasil")
        dgvHasil.Rows.Add(4)
        dgvHasil.Rows(0).HeaderCell.Value = "λ maks"
        dgvHasil.Rows(1).HeaderCell.Value = "λ maks"
        dgvHasil.Rows(2).HeaderCell.Value = "λ maks"
        dgvHasil.Rows(3).HeaderCell.Value = "λ maks"
    End Sub

    Private Sub bersihkan()
        For i = 0 To namaKriteria.Length - 1
            For j = 0 To namaKriteria.Length - 1
                dgvPB.Item(j, i).Value = 1
            Next
        Next

        For i = 0 To namaKriteria.Length - 1
            dgvPB.Item(i, i).Value = 1
        Next
    End Sub

    Private Sub loadRecord()
        Dim sqlcmd As MySqlCommand
        Dim sqlrd As MySqlDataReader

        Try
            c.myOpen()
            sqlcmd = New MySqlCommand("SELECT * FROM pb WHERE kriteria='all'", c.conn)
            sqlrd = sqlcmd.ExecuteReader
            If sqlrd.HasRows = True Then
                While sqlrd.Read = True
                    dgvPB.Item(Array.IndexOf(idKriteria, sqlrd("colindex").ToString), Array.IndexOf(idKriteria, sqlrd("rowindex").ToString)).Value = Val(Format(sqlrd("nilai"), "0.000"))
                End While
                c.myClose()
            Else
                c.myClose()
                Call bersihkan()
            End If
        Catch ex As Exception
            MsgBox("[ERROR:PBK1] " & ex.Message, vbCritical + vbOKOnly, c.namaProgram)
        Finally
            c.myClose()
        End Try
    End Sub

    Private Sub setColorForEditAbleCell()
        For i = 0 To namaKriteria.Length - 1
            For j = 0 To namaKriteria.Length - 1
                If i < j Then
                    dgvPB.Rows(i).Cells(j).Style.BackColor = Color.Gray
                End If
            Next
        Next
    End Sub

    'Buat Matrik
    Private Sub hitungPB()
        For i = 0 To namaKriteria.Length - 1
            For j = 0 To namaKriteria.Length - 1
                If i > j Then
                    dgvPB.Item(j, i).Value = Format(Math.Round(1 / Val(dgvPB.Item(i, j).Value), jlhBulat), "0.000")
                End If
            Next
        Next

        For i = 0 To namaKriteria.Length - 1
            Dim jumlah As Double = 0
            For j = 0 To namaKriteria.Length - 1
                jumlah += Val(dgvPB.Item(i, j).Value)
            Next
            dgvPB.Item(i, namaKriteria.Length).Value = Format(Math.Round(jumlah, jlhBulat), "0.000")
        Next
    End Sub

    Private Sub hitungMatriksPrioritas()
        'menyamakan penyebut
        For i = 0 To namaKriteria.Length - 1
            For j = 0 To namaKriteria.Length - 1
                dgvPrioritas.Item(i, j).Value = Format(Math.Round(Val(dgvPB.Item(i, j).Value) / Val(dgvPB.Item(i, namaKriteria.Length).Value), jlhBulat), "0.000")
            Next
        Next

        'Penyebut
        For i = 0 To namaKriteria.Length - 1
            Dim jumlah As Double = 0
            For j = 0 To namaKriteria.Length - 1
                jumlah += dgvPrioritas.Item(i, j).Value
            Next
            dgvPrioritas.Item(i, namaKriteria.Length).Value = Format(Math.Round(jumlah, jlhBulat), "0.000")
        Next

        For i = 0 To namaKriteria.Length - 1
            Dim jumlah As Double = 0
            For j = 0 To namaKriteria.Length - 1
                jumlah += Val(dgvPrioritas.Item(j, i).Value)
            Next
            dgvPrioritas.Item(namaKriteria.Length, i).Value = Format(Math.Round(jumlah, jlhBulat), "0.000")
        Next

        For i = 0 To namaKriteria.Length - 1
            dgvPrioritas.Item(namaKriteria.Length + 1, i).Value = Format(Math.Round(Val(dgvPrioritas.Item(namaKriteria.Length, i).Value) / namaKriteria.Length, jlhBulat), "0.000")
        Next
    End Sub

    Private Sub hitungJumlahPerbaris()
        For i = 0 To namaKriteria.Length - 1
            Dim jumlah As Double = 0
            For j = 0 To namaKriteria.Length - 1
                dgvPenjumlahan.Item(j, i).Value = Format(Math.Round(Val(dgvPrioritas.Item(namaKriteria.Length + 1, j).Value) * Val(dgvPB.Item(j, i).Value), jlhBulat), "0.000")
                jumlah += Val(dgvPenjumlahan.Item(j, i).Value)
            Next
            dgvPenjumlahan.Item(namaKriteria.Length, i).Value = Format(Math.Round(jumlah, jlhBulat), "0.000")
        Next
    End Sub

    Private Sub hitungRasio()
        For i = 0 To namaKriteria.Length - 1
            dgvRasio.Item(0, i).Value = Val(dgvPenjumlahan.Item(namaKriteria.Length, i).Value)
        Next

        For i = 0 To namaKriteria.Length - 1
            dgvRasio.Item(1, i).Value = Val(dgvPrioritas.Item(namaKriteria.Length + 1, i).Value)
        Next

        For i = 0 To namaKriteria.Length - 1
            Dim jumlah As Double = 0
            For j = 0 To 1
                jumlah += Val(dgvRasio.Item(j, i).Value)
            Next
            dgvRasio.Item(2, i).Value = Format(Math.Round(jumlah, jlhBulat), "0.000")
        Next

        Dim ajumlah As Double = 0
        For i = 0 To namaKriteria.Length - 1
            ajumlah += Val(dgvRasio.Item(2, 1).Value)
        Next
        dgvRasio.Item(2, namaKriteria.Length).Value = Format(Math.Round(ajumlah, jlhBulat), "0.000")
    End Sub

    Private Sub hitungHasil()
        dgvHasil.Item(0, 0).Value = Format(Math.Round(Val(namaKriteria.Length) / Val(dgvRasio.Item(2, namaKriteria.Length).Value), jlhBulat), "0.000")

        dgvHasil.Item(0, 1).Value = Format(Math.Round(Val(dgvHasil.Item(0, 0).Value) - Val(namaKriteria.Length), jlhBulat), "0.000")
        dgvHasil.Item(0, 1).Value = Format(Math.Round(Val(dgvHasil.Item(0, 1).Value) / Val(namaKriteria.Length), jlhBulat), "0.000")

        dgvHasil.Item(0, 2).Value = Format(Math.Round(Val(dgvHasil.Item(0, 1).Value) / Val(NilaiIndeksRandom(namaKriteria.Length)), jlhBulat), "0.000")

        If Val(dgvHasil.Item(0, 2).Value) < 0.1 Then
            dgvHasil.Item(0, 3).Value = "Konsisten"
        Else
            dgvHasil.Item(0, 3).Value = "Tidak Konsisten"
        End If
    End Sub

    Private Sub proses()
        Call hitungPB()
        Call hitungMatriksPrioritas()
        Call hitungJumlahPerbaris()
        Call hitungRasio()
        Call hitungHasil()
    End Sub

    Private Sub frmPBKriteria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim mysqlcmd As MySqlCommand
        Dim mysqlrd As MySqlDataReader
        Try
            c.myOpen()
            mysqlcmd = New MySqlCommand("SELECT * FROM kriteria", c.conn)
            mysqlrd = mysqlcmd.ExecuteReader
            mysqlrd.Read()
            If mysqlrd.HasRows = True Then
                mysqlrd.Close()
                c.myClose()
                Call setHeader()
                Call bersihkan()
                Call setColorForEditAbleCell()
                Call loadRecord()
                Call proses()
            Else
                MsgBox("Tidak ditemuka kriteria", vbCritical + vbOKOnly, c.namaProgram)
            End If
        Catch ex As Exception
            MsgBox("[ERROR:PBK2] " & ex.Message, vbCritical + vbOKOnly, c.namaProgram)
        Finally
            c.myClose()
        End Try
    End Sub


    Private Sub dgvPB_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvPB.CellBeginEdit
        If e.ColumnIndex > e.RowIndex Then
            If e.ColumnIndex >= 0 Then
                If e.RowIndex >= 0 Then
                    Dim cmbSaaty As New DataGridViewComboBoxCell
                    cmbSaaty.Items.Clear()
                    cmbSaaty.Items.Add("0.111")
                    cmbSaaty.Items.Add("0.125")
                    cmbSaaty.Items.Add("0.143")
                    cmbSaaty.Items.Add("0.167")
                    cmbSaaty.Items.Add("0.200")
                    cmbSaaty.Items.Add("0.250")
                    cmbSaaty.Items.Add("0.333")
                    cmbSaaty.Items.Add("0.500")
                    cmbSaaty.Items.Add("2.000")
                    cmbSaaty.Items.Add("3.000")
                    cmbSaaty.Items.Add("4.000")
                    cmbSaaty.Items.Add("5.000")
                    cmbSaaty.Items.Add("6.000")
                    cmbSaaty.Items.Add("7.000")
                    cmbSaaty.Items.Add("8.000")
                    cmbSaaty.Items.Add("9.000")
                    dgvPB.Item(e.ColumnIndex, e.RowIndex) = cmbSaaty
                End If
            End If
        Else
            e.Cancel = True
        End If
    End Sub

    Private Sub cmdProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProses.Click
        Call proses()
    End Sub

    Private Sub cmdTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTutup.Click
        Me.Hide()
    End Sub


    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        Call proses()

        'update pb
        If c.deleteData("pb", "kriteria", "all") = True Then
            'nothing
        End If
        For i = 0 To namaKriteria.Length - 1
            For j = 0 To namaKriteria.Length - 1
                Dim fields() As String = {"kriteria", "colindex", "rowindex", "nilai"}
                Dim datas() As String = {"all", idKriteria(Array.IndexOf(namaKriteria, dgvPB.Columns(i).HeaderText.ToString)), idKriteria(Array.IndexOf(namaKriteria, dgvPB.Rows(j).HeaderCell.Value.ToString)), dgvPB.Item(i, j).Value.ToString}
                If c.insertData("pb", fields, datas) Then
                    'nothing
                End If
            Next
        Next

        'update nilai
        If c.deleteData("hasil", "id_kriteria", "all") = True Then
            'nothing
        End If
        For i = 0 To namaKriteria.Length - 1
            Dim fields() As String = {"id_kriteria", "id_subkriteria", "hasil"}
            Dim datas() As String = {"all", idKriteria(Array.IndexOf(namaKriteria, dgvRasio.Rows(i).HeaderCell.Value.ToString)), dgvRasio.Item(2, i).Value.ToString}
            If c.insertData("hasil", fields, datas) Then
                'nothing
            End If
        Next
        MsgBox("Tersimpan", vbInformation + vbOKOnly, c.namaProgram)
    End Sub

    Private Sub dgvPrioritas_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvPrioritas.CellBeginEdit
        e.Cancel = True
    End Sub

    Private Sub dgvPenjumlahan_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvPenjumlahan.CellBeginEdit
        e.Cancel = True
    End Sub

    Private Sub dgvRasio_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvRasio.CellBeginEdit
        e.Cancel = True
    End Sub

    Private Sub dgvHasil_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvHasil.CellBeginEdit
        e.Cancel = True
    End Sub
End Class