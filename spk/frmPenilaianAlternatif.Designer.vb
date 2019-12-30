<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPenilaianAlternatif
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
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.cmdTutup = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(13, 13)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(747, 264)
        Me.dgv.TabIndex = 0
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(524, 283)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(115, 38)
        Me.cmdSimpan.TabIndex = 1
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cmdTutup
        '
        Me.cmdTutup.Location = New System.Drawing.Point(645, 283)
        Me.cmdTutup.Name = "cmdTutup"
        Me.cmdTutup.Size = New System.Drawing.Size(115, 38)
        Me.cmdTutup.TabIndex = 2
        Me.cmdTutup.Text = "Tutup"
        Me.cmdTutup.UseVisualStyleBackColor = True
        '
        'frmPenilaianAlternatif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 331)
        Me.Controls.Add(Me.cmdTutup)
        Me.Controls.Add(Me.cmdSimpan)
        Me.Controls.Add(Me.dgv)
        Me.Name = "frmPenilaianAlternatif"
        Me.Text = "Penilaian Alternatif"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cmdTutup As System.Windows.Forms.Button
End Class
