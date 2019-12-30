<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSubKriteria
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
        Me.gbxDGV = New System.Windows.Forms.GroupBox()
        Me.cmbKriteria = New System.Windows.Forms.ComboBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.gbxInput = New System.Windows.Forms.GroupBox()
        Me.cmdTutup = New System.Windows.Forms.Button()
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.cmdHapus = New System.Windows.Forms.Button()
        Me.cmbPilihKriteria = New System.Windows.Forms.ComboBox()
        Me.nudUrutan = New System.Windows.Forms.NumericUpDown()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblUrutan = New System.Windows.Forms.Label()
        Me.lblKriteria = New System.Windows.Forms.Label()
        Me.gbxDGV.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInput.SuspendLayout()
        CType(Me.nudUrutan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbxDGV
        '
        Me.gbxDGV.Controls.Add(Me.cmbKriteria)
        Me.gbxDGV.Controls.Add(Me.dgv)
        Me.gbxDGV.Location = New System.Drawing.Point(13, 13)
        Me.gbxDGV.Name = "gbxDGV"
        Me.gbxDGV.Size = New System.Drawing.Size(576, 371)
        Me.gbxDGV.TabIndex = 0
        Me.gbxDGV.TabStop = False
        Me.gbxDGV.Text = "Table Sub Kriteria"
        '
        'cmbKriteria
        '
        Me.cmbKriteria.FormattingEnabled = True
        Me.cmbKriteria.Location = New System.Drawing.Point(7, 19)
        Me.cmbKriteria.Name = "cmbKriteria"
        Me.cmbKriteria.Size = New System.Drawing.Size(563, 21)
        Me.cmbKriteria.TabIndex = 1
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(7, 46)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(563, 319)
        Me.dgv.TabIndex = 0
        '
        'gbxInput
        '
        Me.gbxInput.Controls.Add(Me.cmdTutup)
        Me.gbxInput.Controls.Add(Me.cmdSimpan)
        Me.gbxInput.Controls.Add(Me.cmdHapus)
        Me.gbxInput.Controls.Add(Me.cmbPilihKriteria)
        Me.gbxInput.Controls.Add(Me.nudUrutan)
        Me.gbxInput.Controls.Add(Me.txtKeterangan)
        Me.gbxInput.Controls.Add(Me.txtNama)
        Me.gbxInput.Controls.Add(Me.lblKeterangan)
        Me.gbxInput.Controls.Add(Me.lblNama)
        Me.gbxInput.Controls.Add(Me.lblUrutan)
        Me.gbxInput.Controls.Add(Me.lblKriteria)
        Me.gbxInput.Location = New System.Drawing.Point(596, 13)
        Me.gbxInput.Name = "gbxInput"
        Me.gbxInput.Size = New System.Drawing.Size(293, 365)
        Me.gbxInput.TabIndex = 1
        Me.gbxInput.TabStop = False
        Me.gbxInput.Text = "Input / Edit Data"
        '
        'cmdTutup
        '
        Me.cmdTutup.Location = New System.Drawing.Point(190, 270)
        Me.cmdTutup.Name = "cmdTutup"
        Me.cmdTutup.Size = New System.Drawing.Size(75, 42)
        Me.cmdTutup.TabIndex = 10
        Me.cmdTutup.Text = "Tutup"
        Me.cmdTutup.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(108, 270)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(75, 42)
        Me.cmdSimpan.TabIndex = 9
        Me.cmdSimpan.Text = "Tambahkan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cmdHapus
        '
        Me.cmdHapus.Location = New System.Drawing.Point(26, 270)
        Me.cmdHapus.Name = "cmdHapus"
        Me.cmdHapus.Size = New System.Drawing.Size(75, 42)
        Me.cmdHapus.TabIndex = 8
        Me.cmdHapus.Text = "Hapus"
        Me.cmdHapus.UseVisualStyleBackColor = True
        '
        'cmbPilihKriteria
        '
        Me.cmbPilihKriteria.FormattingEnabled = True
        Me.cmbPilihKriteria.Location = New System.Drawing.Point(110, 66)
        Me.cmbPilihKriteria.Name = "cmbPilihKriteria"
        Me.cmbPilihKriteria.Size = New System.Drawing.Size(164, 21)
        Me.cmbPilihKriteria.TabIndex = 7
        '
        'nudUrutan
        '
        Me.nudUrutan.Location = New System.Drawing.Point(111, 93)
        Me.nudUrutan.Name = "nudUrutan"
        Me.nudUrutan.Size = New System.Drawing.Size(120, 20)
        Me.nudUrutan.TabIndex = 6
        Me.nudUrutan.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(111, 145)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(163, 81)
        Me.txtKeterangan.TabIndex = 5
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(111, 119)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(163, 20)
        Me.txtNama.TabIndex = 4
        '
        'lblKeterangan
        '
        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Location = New System.Drawing.Point(15, 148)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(62, 13)
        Me.lblKeterangan.TabIndex = 3
        Me.lblKeterangan.Text = "Keterangan"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(15, 122)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(89, 13)
        Me.lblNama.TabIndex = 2
        Me.lblNama.Text = "Nama sub kriteria"
        '
        'lblUrutan
        '
        Me.lblUrutan.AutoSize = True
        Me.lblUrutan.Location = New System.Drawing.Point(15, 95)
        Me.lblUrutan.Name = "lblUrutan"
        Me.lblUrutan.Size = New System.Drawing.Size(59, 13)
        Me.lblUrutan.TabIndex = 1
        Me.lblUrutan.Text = "Nomer urut"
        '
        'lblKriteria
        '
        Me.lblKriteria.AutoSize = True
        Me.lblKriteria.Location = New System.Drawing.Point(15, 66)
        Me.lblKriteria.Name = "lblKriteria"
        Me.lblKriteria.Size = New System.Drawing.Size(39, 13)
        Me.lblKriteria.TabIndex = 0
        Me.lblKriteria.Text = "Kriteria"
        '
        'frmSubKriteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 390)
        Me.Controls.Add(Me.gbxInput)
        Me.Controls.Add(Me.gbxDGV)
        Me.Name = "frmSubKriteria"
        Me.Text = "Daftar Sub Kriteria"
        Me.gbxDGV.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInput.ResumeLayout(False)
        Me.gbxInput.PerformLayout()
        CType(Me.nudUrutan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbxDGV As System.Windows.Forms.GroupBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents gbxInput As System.Windows.Forms.GroupBox
    Friend WithEvents lblKeterangan As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblUrutan As System.Windows.Forms.Label
    Friend WithEvents lblKriteria As System.Windows.Forms.Label
    Friend WithEvents cmbKriteria As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPilihKriteria As System.Windows.Forms.ComboBox
    Friend WithEvents nudUrutan As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents cmdTutup As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cmdHapus As System.Windows.Forms.Button
End Class
