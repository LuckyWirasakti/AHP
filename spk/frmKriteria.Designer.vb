<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmKriteria
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.gbx = New System.Windows.Forms.GroupBox()
        Me.cmdTutup = New System.Windows.Forms.Button()
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.cmdHapus = New System.Windows.Forms.Button()
        Me.nudUrutan = New System.Windows.Forms.NumericUpDown()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.lblUrutan = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx.SuspendLayout()
        CType(Me.nudUrutan, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(13, 13)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.Size = New System.Drawing.Size(529, 348)
        Me.dgv.TabIndex = 0
        '
        'gbx
        '
        Me.gbx.Controls.Add(Me.cmdTutup)
        Me.gbx.Controls.Add(Me.cmdSimpan)
        Me.gbx.Controls.Add(Me.cmdHapus)
        Me.gbx.Controls.Add(Me.nudUrutan)
        Me.gbx.Controls.Add(Me.txtKeterangan)
        Me.gbx.Controls.Add(Me.txtNama)
        Me.gbx.Controls.Add(Me.lblKeterangan)
        Me.gbx.Controls.Add(Me.lblNama)
        Me.gbx.Controls.Add(Me.lblUrutan)
        Me.gbx.Location = New System.Drawing.Point(548, 13)
        Me.gbx.Name = "gbx"
        Me.gbx.Size = New System.Drawing.Size(300, 348)
        Me.gbx.TabIndex = 1
        Me.gbx.TabStop = False
        Me.gbx.Text = "Input/Edit Box"
        '
        'cmdTutup
        '
        Me.cmdTutup.Location = New System.Drawing.Point(200, 261)
        Me.cmdTutup.Name = "cmdTutup"
        Me.cmdTutup.Size = New System.Drawing.Size(78, 39)
        Me.cmdTutup.TabIndex = 8
        Me.cmdTutup.Text = "Tutup"
        Me.cmdTutup.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(116, 261)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(78, 39)
        Me.cmdSimpan.TabIndex = 7
        Me.cmdSimpan.Text = "Tambahkan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cmdHapus
        '
        Me.cmdHapus.Location = New System.Drawing.Point(28, 261)
        Me.cmdHapus.Name = "cmdHapus"
        Me.cmdHapus.Size = New System.Drawing.Size(82, 39)
        Me.cmdHapus.TabIndex = 6
        Me.cmdHapus.Text = "Hapus Data"
        Me.cmdHapus.UseVisualStyleBackColor = True
        '
        'nudUrutan
        '
        Me.nudUrutan.Location = New System.Drawing.Point(105, 54)
        Me.nudUrutan.Name = "nudUrutan"
        Me.nudUrutan.Size = New System.Drawing.Size(120, 20)
        Me.nudUrutan.TabIndex = 5
        Me.nudUrutan.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(105, 131)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(173, 86)
        Me.txtKeterangan.TabIndex = 4
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(105, 93)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(173, 20)
        Me.txtNama.TabIndex = 3
        '
        'lblKeterangan
        '
        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Location = New System.Drawing.Point(23, 134)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(62, 13)
        Me.lblKeterangan.TabIndex = 2
        Me.lblKeterangan.Text = "Keterangan"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(23, 96)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(35, 13)
        Me.lblNama.TabIndex = 1
        Me.lblNama.Text = "Nama"
        '
        'lblUrutan
        '
        Me.lblUrutan.AutoSize = True
        Me.lblUrutan.Location = New System.Drawing.Point(23, 57)
        Me.lblUrutan.Name = "lblUrutan"
        Me.lblUrutan.Size = New System.Drawing.Size(39, 13)
        Me.lblUrutan.TabIndex = 0
        Me.lblUrutan.Text = "Urutan"
        '
        'frmKriteria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 373)
        Me.Controls.Add(Me.gbx)
        Me.Controls.Add(Me.dgv)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmKriteria"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Daftar Kriteria"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx.ResumeLayout(False)
        Me.gbx.PerformLayout()
        CType(Me.nudUrutan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents gbx As System.Windows.Forms.GroupBox
    Friend WithEvents lblKeterangan As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblUrutan As System.Windows.Forms.Label
    Friend WithEvents cmdTutup As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cmdHapus As System.Windows.Forms.Button
    Friend WithEvents nudUrutan As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
End Class
