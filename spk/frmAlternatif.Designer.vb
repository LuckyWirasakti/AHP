<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlternatif
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
        Me.cmdTutup = New System.Windows.Forms.Button()
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.cmdHapus = New System.Windows.Forms.Button()
        Me.txtKeterangan = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.lblKeterangan = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.dgv.Size = New System.Drawing.Size(493, 336)
        Me.dgv.TabIndex = 0
        '
        'cmdTutup
        '
        Me.cmdTutup.Location = New System.Drawing.Point(425, 465)
        Me.cmdTutup.Name = "cmdTutup"
        Me.cmdTutup.Size = New System.Drawing.Size(78, 25)
        Me.cmdTutup.TabIndex = 15
        Me.cmdTutup.Text = "Tutup"
        Me.cmdTutup.UseVisualStyleBackColor = True
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(341, 465)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(78, 25)
        Me.cmdSimpan.TabIndex = 14
        Me.cmdSimpan.Text = "Tambahkan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cmdHapus
        '
        Me.cmdHapus.Location = New System.Drawing.Point(253, 465)
        Me.cmdHapus.Name = "cmdHapus"
        Me.cmdHapus.Size = New System.Drawing.Size(82, 25)
        Me.cmdHapus.TabIndex = 13
        Me.cmdHapus.Text = "Hapus Data"
        Me.cmdHapus.UseVisualStyleBackColor = True
        '
        'txtKeterangan
        '
        Me.txtKeterangan.Location = New System.Drawing.Point(91, 394)
        Me.txtKeterangan.Multiline = True
        Me.txtKeterangan.Name = "txtKeterangan"
        Me.txtKeterangan.Size = New System.Drawing.Size(412, 65)
        Me.txtKeterangan.TabIndex = 12
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(91, 365)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(412, 20)
        Me.txtNama.TabIndex = 11
        '
        'lblKeterangan
        '
        Me.lblKeterangan.AutoSize = True
        Me.lblKeterangan.Location = New System.Drawing.Point(12, 394)
        Me.lblKeterangan.Name = "lblKeterangan"
        Me.lblKeterangan.Size = New System.Drawing.Size(49, 13)
        Me.lblKeterangan.TabIndex = 10
        Me.lblKeterangan.Text = "Informasi"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(12, 368)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(35, 13)
        Me.lblNama.TabIndex = 9
        Me.lblNama.Text = "Nama"
        '
        'frmAlternatif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 502)
        Me.Controls.Add(Me.cmdTutup)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.cmdHapus)
        Me.Controls.Add(Me.txtKeterangan)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.lblKeterangan)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.dgv)
        Me.Name = "frmAlternatif"
        Me.Text = "Daftar Alternatif"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents cmdTutup As System.Windows.Forms.Button
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cmdHapus As System.Windows.Forms.Button
    Friend WithEvents txtKeterangan As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents lblKeterangan As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
End Class
