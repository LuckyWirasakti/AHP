<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAHP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAHP))
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.cmdTutup = New System.Windows.Forms.Button()
        Me.gbxAHP = New System.Windows.Forms.GroupBox()
        Me.dgvAHP = New System.Windows.Forms.DataGridView()
        Me.gbxHasil = New System.Windows.Forms.GroupBox()
        Me.dgvHasil = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.gbxAHP.SuspendLayout()
        CType(Me.dgvAHP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxHasil.SuspendLayout()
        CType(Me.dgvHasil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(814, 366)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(118, 53)
        Me.cmdSimpan.TabIndex = 2
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cmdTutup
        '
        Me.cmdTutup.Location = New System.Drawing.Point(1110, 366)
        Me.cmdTutup.Name = "cmdTutup"
        Me.cmdTutup.Size = New System.Drawing.Size(118, 53)
        Me.cmdTutup.TabIndex = 3
        Me.cmdTutup.Text = "Tutup"
        Me.cmdTutup.UseVisualStyleBackColor = True
        '
        'gbxAHP
        '
        Me.gbxAHP.Controls.Add(Me.dgvAHP)
        Me.gbxAHP.Location = New System.Drawing.Point(13, 13)
        Me.gbxAHP.Name = "gbxAHP"
        Me.gbxAHP.Size = New System.Drawing.Size(776, 406)
        Me.gbxAHP.TabIndex = 4
        Me.gbxAHP.TabStop = False
        Me.gbxAHP.Text = "AHP"
        '
        'dgvAHP
        '
        Me.dgvAHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAHP.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAHP.Location = New System.Drawing.Point(3, 16)
        Me.dgvAHP.Name = "dgvAHP"
        Me.dgvAHP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvAHP.Size = New System.Drawing.Size(770, 387)
        Me.dgvAHP.TabIndex = 0
        '
        'gbxHasil
        '
        Me.gbxHasil.Controls.Add(Me.dgvHasil)
        Me.gbxHasil.Location = New System.Drawing.Point(815, 13)
        Me.gbxHasil.Name = "gbxHasil"
        Me.gbxHasil.Size = New System.Drawing.Size(413, 347)
        Me.gbxHasil.TabIndex = 5
        Me.gbxHasil.TabStop = False
        Me.gbxHasil.Text = "Ranking"
        '
        'dgvHasil
        '
        Me.dgvHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHasil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHasil.Location = New System.Drawing.Point(3, 16)
        Me.dgvHasil.Name = "dgvHasil"
        Me.dgvHasil.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvHasil.Size = New System.Drawing.Size(407, 328)
        Me.dgvHasil.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(968, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 53)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Cetak"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PrintDocument1
        '
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'frmAHP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 431)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.gbxHasil)
        Me.Controls.Add(Me.gbxAHP)
        Me.Controls.Add(Me.cmdTutup)
        Me.Controls.Add(Me.cmdSimpan)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmAHP"
        Me.Text = "AHP"
        Me.gbxAHP.ResumeLayout(False)
        CType(Me.dgvAHP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxHasil.ResumeLayout(False)
        CType(Me.dgvHasil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdSimpan As System.Windows.Forms.Button
    Friend WithEvents cmdTutup As System.Windows.Forms.Button
    Friend WithEvents gbxAHP As System.Windows.Forms.GroupBox
    Friend WithEvents dgvAHP As System.Windows.Forms.DataGridView
    Friend WithEvents gbxHasil As System.Windows.Forms.GroupBox
    Friend WithEvents dgvHasil As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
