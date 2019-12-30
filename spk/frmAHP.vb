Imports MySql.Data.MySqlClient

Public Class frmAHP
    Dim c As New clsConn

    Private Sub setHeader()
        'membuat colom
        Dim sqlcmd As MySqlCommand
        Dim sqlrd As MySqlDataReader
        Try
            c.myOpen()
            sqlcmd = New MySqlCommand("SELECT id_kriteria, nama_kriteria FROM kriteria ORDER BY urutan ASC", c.conn)
            sqlrd = sqlcmd.ExecuteReader

            If sqlrd.HasRows = True Then
                While sqlrd.Read = True
                    dgvAHP.Columns.Add(sqlrd("id_kriteria"), sqlrd("nama_kriteria"))
                End While
            End If

            dgvAHP.Columns.Add("Total", "Total")
        Catch ex As Exception
            MsgBox("[ERROR:FAHP1] " & ex.Message, vbCritical + vbOKOnly, c.namaProgram)
        Finally
            c.myClose()
        End Try

        'Membuat row
        Try
            c.myOpen()
            sqlcmd = New MySqlCommand("SELECT nama FROM alternatif ORDER BY id_alternatif ASC", c.conn)
            sqlrd = sqlcmd.ExecuteReader

            If sqlrd.HasRows = True Then
                Dim myi As Integer = 0
                While sqlrd.Read = True
                    dgvAHP.Rows.Add(1)
                    dgvAHP.Rows(myi).HeaderCell.Value = sqlrd("nama")
                    myi += 1
                End While
            End If
        Catch ex As Exception
            MsgBox("[ERROR:FAHP2] " & ex.Message, vbCritical + vbOKOnly, c.namaProgram)
        Finally
            c.myClose()
        End Try
    End Sub

    Private Sub setAHPCells()
        Dim sqlcmd As MySqlCommand
        Dim sqlrd As MySqlDataReader

        Try
            For i = 0 To dgvAHP.RowCount - 2
                For j = 0 To dgvAHP.Columns.Count - 2
                    Dim idAlternatif As Double
                    Dim idKriteria As Double
                    Dim idSubKriteria As Double

                    Dim nilaiKriteria As Double
                    'Dim nilaiSubKriteria As Double

                    c.myOpen()
                    'mencari nilai dari kriteria
                    sqlcmd = New MySqlCommand("SELECT hasil.hasil FROM hasil INNER JOIN kriteria ON hasil.id_subkriteria = kriteria.id_kriteria WHERE hasil.id_kriteria = 'all' AND kriteria.nama_kriteria = '" & dgvAHP.Columns(j).HeaderText & "'", c.conn)
                    sqlrd = sqlcmd.ExecuteReader
                    If sqlrd.HasRows = True Then
                        While sqlrd.Read = True
                            nilaiKriteria = sqlrd("hasil")
                        End While
                        sqlrd.Close()

                        'mencari id kriteria dan id subkriteria
                        c.myOpen()
                        sqlcmd = New MySqlCommand("SELECT kriteria.id_kriteria, alternatif.id_alternatif FROM kriteria, alternatif WHERE kriteria.nama_kriteria = '" & dgvAHP.Columns(j).HeaderText & "' AND alternatif.nama = '" & dgvAHP.Rows(i).HeaderCell.Value & "'", c.conn)
                        sqlrd = sqlcmd.ExecuteReader
                        If sqlrd.HasRows = True Then
                            While sqlrd.Read = True
                                idKriteria = sqlrd("id_kriteria")
                                idAlternatif = sqlrd("id_alternatif")
                            End While
                            sqlrd.Close()

                            'mencari id_subkriteria pada nilai alternatif
                            c.myOpen()
                            sqlcmd = New MySqlCommand("SELECT id_subkriteria FROM nilai_alternatif WHERE id_kriteria ='" & idKriteria & "' AND id_alternatif = '" & idAlternatif & "'", c.conn)
                            sqlrd = sqlcmd.ExecuteReader
                            If sqlrd.HasRows = True Then
                                While sqlrd.Read = True
                                    idSubKriteria = sqlrd("id_subkriteria")
                                End While
                                sqlrd.Close()

                                'mendapatkan nilai dari subkriteria
                                c.myOpen()
                                sqlcmd = New MySqlCommand("SELECT hasil FROM hasil WHERE id_kriteria = '" & idKriteria & "' AND id_subkriteria = '" & idSubKriteria & "'", c.conn)
                                sqlrd = sqlcmd.ExecuteReader
                                If sqlrd.HasRows = True Then
                                    While sqlrd.Read = True
                                        'rumus ahp
                                        dgvAHP.Item(j, i).Value = Format(Math.Round(Val(sqlrd("hasil")) * Val(nilaiKriteria), 3), "0.000")
                                    End While
                                Else
                                    MsgBox("Nilai dari subkriteria tidak ditemukan", vbInformation + vbOKOnly, c.namaProgram)
                                End If
                                sqlrd.Close()
                                c.myClose()
                            Else
                                MsgBox("Penilaian Alternatif " & dgvAHP.Rows(i).HeaderCell.Value & " tidak ditemukan", vbInformation + vbOKOnly, c.namaProgram)
                            End If
                            sqlrd.Close()
                            c.myClose()
                        Else
                            MsgBox("kriteria atau alternatif tidak ditemukan", vbInformation + vbOKOnly, c.namaProgram)
                        End If
                        sqlrd.Close()
                        c.myClose()
                    Else
                        MsgBox("Nilai dari kriteria " & dgvAHP.Columns(j).HeaderText & "tidak ditemukan", vbInformation + vbOKOnly, c.namaProgram)
                    End If
                    sqlrd.Close()
                    c.myClose()
                Next
            Next
        Catch ex As Exception
            MsgBox("[ERROR:LOAD1] " & ex.Message, vbInformation + vbOKOnly, c.namaProgram)
        Finally
            sqlrd.Close()
            c.myClose()
        End Try

        'Hitung total
        For i = 0 To dgvAHP.RowCount - 2
            Dim jumlah As Double = 0
            For j = 0 To dgvAHP.ColumnCount - 2
                jumlah += Val(dgvAHP.Item(j, i).Value)
            Next
            dgvAHP.Item(dgvAHP.ColumnCount - 1, i).Value = jumlah
        Next
    End Sub

    Private Sub bersihkan()
        For i = 0 To dgvAHP.RowCount - 2
            For j = 0 To dgvAHP.ColumnCount - 1
                dgvAHP.Item(j, i).Value = 0
            Next
        Next
    End Sub

    Private Sub simpan()
        c.runSql("DELETE FROM ahp", c.conn)

        For i = 0 To dgvAHP.RowCount - 2
            If Not dgvAHP.Rows(i).HeaderCell.Value = "" Then
                Dim sqlcmd As MySqlCommand
                Dim sqlrd As MySqlDataReader

                Try
                    c.myOpen()
                    sqlcmd = New MySqlCommand("SELECT id_alternatif FROm alternatif WHERE nama ='" & dgvAHP.Rows(i).HeaderCell.Value & "'", c.conn)
                    sqlrd = sqlcmd.ExecuteReader
                    Dim idAlter As String
                    While sqlrd.Read = True
                        idAlter = sqlrd("id_alternatif").ToString
                    End While
                    sqlrd.Close()
                    c.myClose()
                    Dim fields() As String = {"id_alternatif", "ahp"}
                    Dim datas() As String = {idAlter, dgvAHP.Item(dgvAHP.ColumnCount - 1, i).Value.ToString}
                    c.insertData("ahp", fields, datas)
                Catch ex As Exception
                    MsgBox("[ERROR:LOAD2] " & ex.Message, vbInformation + vbOKOnly, c.namaProgram)
                Finally
                    c.myClose()
                End Try
            End If
        Next
    End Sub

    Private Sub loadRanking()
        dgvHasil.Columns.Add("Nama", "Nama")
        dgvHasil.Columns.Add("Nilai AHP", "Nilai AHP")

        Dim sqlcmd As MySqlCommand
        Dim sqlrd As MySqlDataReader
        Try
            c.myOpen()
            sqlcmd = New MySqlCommand("SELECT alternatif.nama, ahp.ahp FROM ahp INNER JOIN alternatif ON alternatif.id_alternatif = ahp.id_alternatif ORDER BY ahp.ahp DESC", c.conn)
            sqlrd = sqlcmd.ExecuteReader

            If sqlrd.HasRows = True Then
                Dim i As Integer = 0
                While sqlrd.Read = True
                    dgvHasil.Rows.Add(1)
                    dgvHasil.Rows(i).HeaderCell.Value = (i + 1).ToString
                    dgvHasil.Item(0, i).Value = sqlrd("nama")
                    dgvHasil.Item(1, i).Value = sqlrd("ahp")
                    i += 1
                End While
            End If
            sqlrd.Close()
            c.myClose()
        Catch ex As Exception
            MsgBox("[ERROR:LOAD3] " & ex.Message, vbInformation + vbOKOnly, c.namaProgram)
        End Try
    End Sub

    Private Sub frmAHP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        setHeader()
        bersihkan()
        setAHPCells()
        simpan()
        loadRanking()
    End Sub

    Private Sub cmdTutup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTutup.Click
        Me.Hide()
    End Sub

    Private Sub cmdSimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpan.Click
        Call simpan()
        MsgBox("Tersimpan", vbInformation + vbOKOnly, c.namaProgram)
    End Sub

    Private Sub dgvAHP_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvAHP.CellBeginEdit
        e.Cancel = True
    End Sub

    Private Sub dgvHasil_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles dgvHasil.CellBeginEdit
        e.Cancel = True
    End Sub
End Class