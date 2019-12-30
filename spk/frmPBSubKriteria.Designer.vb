<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPBSubKriteria
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbxRasio = New System.Windows.Forms.GroupBox()
        Me.dgvRasio = New System.Windows.Forms.DataGridView()
        Me.gbxPenjumlahan = New System.Windows.Forms.GroupBox()
        Me.dgvPenjumlahan = New System.Windows.Forms.DataGridView()
        Me.gbxPrioritas = New System.Windows.Forms.GroupBox()
        Me.dgvPrioritas = New System.Windows.Forms.DataGridView()
        Me.gbxPB = New System.Windows.Forms.GroupBox()
        Me.dgvPB = New System.Windows.Forms.DataGridView()
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.cmdTutup = New System.Windows.Forms.Button()
        Me.gbxHasil = New System.Windows.Forms.GroupBox()
        Me.dgvHasil = New System.Windows.Forms.DataGridView()
        Me.cmdProses = New System.Windows.Forms.Button()
        Me.cmbKriteria = New System.Windows.Forms.ComboBox()
        Me.gbxRasio.SuspendLayout()
        CType(Me.dgvRasio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPenjumlahan.SuspendLayout()
        CType(Me.dgvPenjumlahan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPrioritas.SuspendLayout()
        CType(Me.dgvPrioritas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxPB.SuspendLayout()
        CType(Me.dgvPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxHasil.SuspendLayout()
        CType(Me.dgvHasil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxRasio
        '
        Me.gbxRasio.Controls.Add(Me.dgvRasio)
        Me.gbxRasio.Location = New System.Drawing.Point(553, 298)
        Me.gbxRasio.Name = "gbxRasio"
        Me.gbxRasio.Size = New System.Drawing.Size(535, 280)
        Me.gbxRasio.TabIndex = 8
        Me.gbxRasio.TabStop = False
        Me.gbxRasio.Text = "Rasio Konsistensi"
        '
        'dgvRasio
        '
        Me.dgvRasio.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvRasio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRasio.Location = New System.Drawing.Point(7, 20)
        Me.dgvRasio.Name = "dgvRasio"
        Me.dgvRasio.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvRasio.Size = New System.Drawing.Size(522, 254)
        Me.dgvRasio.TabIndex = 0
        '
        'gbxPenjumlahan
        '
        Me.gbxPenjumlahan.Controls.Add(Me.dgvPenjumlahan)
        Me.gbxPenjumlahan.Location = New System.Drawing.Point(12, 298)
        Me.gbxPenjumlahan.Name = "gbxPenjumlahan"
        Me.gbxPenjumlahan.Size = New System.Drawing.Size(535, 280)
        Me.gbxPenjumlahan.TabIndex = 7
        Me.gbxPenjumlahan.TabStop = False
        Me.gbxPenjumlahan.Text = "Penjumlahan Setiap Baris"
        '
        'dgvPenjumlahan
        '
        Me.dgvPenjumlahan.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvPenjumlahan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPenjumlahan.Location = New System.Drawing.Point(7, 20)
        Me.dgvPenjumlahan.Name = "dgvPenjumlahan"
        Me.dgvPenjumlahan.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvPenjumlahan.Size = New System.Drawing.Size(522, 254)
        Me.dgvPenjumlahan.TabIndex = 0
        '
        'gbxPrioritas
        '
        Me.gbxPrioritas.Controls.Add(Me.dgvPrioritas)
        Me.gbxPrioritas.Location = New System.Drawing.Point(553, 12)
        Me.gbxPrioritas.Name = "gbxPrioritas"
        Me.gbxPrioritas.Size = New System.Drawing.Size(535, 280)
        Me.gbxPrioritas.TabIndex = 6
        Me.gbxPrioritas.TabStop = False
        Me.gbxPrioritas.Text = "Priority Vector Matriks Normalisasi"
        '
        'dgvPrioritas
        '
        Me.dgvPrioritas.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvPrioritas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPrioritas.Location = New System.Drawing.Point(7, 20)
        Me.dgvPrioritas.Name = "dgvPrioritas"
        Me.dgvPrioritas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvPrioritas.Size = New System.Drawing.Size(522, 254)
        Me.dgvPrioritas.TabIndex = 0
        '
        'gbxPB
        '
        Me.gbxPB.Controls.Add(Me.dgvPB)
        Me.gbxPB.Location = New System.Drawing.Point(12, 12)
        Me.gbxPB.Name = "gbxPB"
        Me.gbxPB.Size = New System.Drawing.Size(535, 280)
        Me.gbxPB.TabIndex = 5
        Me.gbxPB.TabStop = False
        Me.gbxPB.Text = "Matrik Perbandingan Berpasangan"
        '
        'dgvPB
        '
        Me.dgvPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPB.Location = New System.Drawing.Point(7, 20)
        Me.dgvPB.Name = "dgvPB"
        Me.dgvPB.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvPB.Size = New System.Drawing.Size(522, 254)
        Me.dgvPB.TabIndex = 0
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(1100, 463)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(207, 53)
        Me.cmdSimpan.TabIndex = 12
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cmdTutup
        '
        Me.cmdTutup.Location = New System.Drawing.Point(1100, 522)
        Me.cmdTutup.Name = "cmdTutup"
        Me.cmdTutup.Size = New System.Drawing.Size(207, 53)
        Me.cmdTutup.TabIndex = 11
        Me.cmdTutup.Text = "Tutup"
        Me.cmdTutup.UseVisualStyleBackColor = True
        '
        'gbxHasil
        '
        Me.gbxHasil.Controls.Add(Me.dgvHasil)
        Me.gbxHasil.Location = New System.Drawing.Point(1094, 23)
        Me.gbxHasil.Name = "gbxHasil"
        Me.gbxHasil.Size = New System.Drawing.Size(219, 325)
        Me.gbxHasil.TabIndex = 10
        Me.gbxHasil.TabStop = False
        Me.gbxHasil.Text = "Hasil"
        '
        'dgvHasil
        '
        Me.dgvHasil.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHasil.Location = New System.Drawing.Point(6, 20)
        Me.dgvHasil.Name = "dgvHasil"
        Me.dgvHasil.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvHasil.Size = New System.Drawing.Size(207, 295)
        Me.dgvHasil.TabIndex = 0
        '
        'cmdProses
        '
        Me.cmdProses.Location = New System.Drawing.Point(1100, 404)
        Me.cmdProses.Name = "cmdProses"
        Me.cmdProses.Size = New System.Drawing.Size(207, 53)
        Me.cmdProses.TabIndex = 9
        Me.cmdProses.Text = "Proses"
        Me.cmdProses.UseVisualStyleBackColor = True
        '
        'cmbKriteria
        '
        Me.cmbKriteria.FormattingEnabled = True
        Me.cmbKriteria.Location = New System.Drawing.Point(1100, 354)
        Me.cmbKriteria.Name = "cmbKriteria"
        Me.cmbKriteria.Size = New System.Drawing.Size(207, 21)
        Me.cmbKriteria.TabIndex = 13
        '
        'frmPBSubKriteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1322, 595)
        Me.Controls.Add(Me.cmbKriteria)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.cmdTutup)
        Me.Controls.Add(Me.gbxHasil)
        Me.Controls.Add(Me.cmdProses)
        Me.Controls.Add(Me.gbxRasio)
        Me.Controls.Add(Me.gbxPenjumlahan)
        Me.Controls.Add(Me.gbxPrioritas)
        Me.Controls.Add(Me.gbxPB)
        Me.Name = "frmPBSubKriteria"
        Me.Text = "Perbandingan Berpasangan Sub Kriteria"
        Me.gbxRasio.ResumeLayout(False)
        CType(Me.dgvRasio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPenjumlahan.ResumeLayout(False)
        CType(Me.dgvPenjumlahan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPrioritas.ResumeLayout(False)
        CType(Me.dgvPrioritas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxPB.ResumeLayout(False)
        CType(Me.dgvPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxHasil.ResumeLayout(False)
        CType(Me.dgvHasil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxRasio As System.Windows.Forms.GroupBox
    Friend WithEvents dgvRasio As System.Windows.Forms.DataGridView
    Friend WithEvents gbxPenjumlahan As System.Windows.Forms.GroupBox
    Friend WithEvents dgvPenjumlahan As System.Windows.Forms.DataGridView
    Friend WithEvents gbxPrioritas As System.Windows.Forms.GroupBox
    Friend WithEvents dgvPrioritas As System.Windows.Forms.DataGridView
    Friend WithEvents gbxPB As System.Windows.Forms.GroupBox
    Friend WithEvents dgvPB As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cmdTutup As System.Windows.Forms.Button
    Friend WithEvents gbxHasil As System.Windows.Forms.GroupBox
    Friend WithEvents dgvHasil As System.Windows.Forms.DataGridView
    Friend WithEvents cmdProses As System.Windows.Forms.Button
    Friend WithEvents cmbKriteria As System.Windows.Forms.ComboBox
End Class
