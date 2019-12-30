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
        Me.cmdSimpan = New System.Windows.Forms.Button()
        Me.cmdTutup = New System.Windows.Forms.Button()
        Me.gbxAHP = New System.Windows.Forms.GroupBox()
        Me.dgvAHP = New System.Windows.Forms.DataGridView()
        Me.gbxHasil = New System.Windows.Forms.GroupBox()
        Me.dgvHasil = New System.Windows.Forms.DataGridView()
        Me.gbxAHP.SuspendLayout()
        CType(Me.dgvAHP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxHasil.SuspendLayout()
        CType(Me.dgvHasil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdSimpan
        '
        Me.cmdSimpan.Location = New System.Drawing.Point(609, 366)
        Me.cmdSimpan.Name = "cmdSimpan"
        Me.cmdSimpan.Size = New System.Drawing.Size(118, 53)
        Me.cmdSimpan.TabIndex = 2
        Me.cmdSimpan.Text = "Simpan"
        Me.cmdSimpan.UseVisualStyleBackColor = True
        '
        'cmdTutup
        '
        Me.cmdTutup.Location = New System.Drawing.Point(733, 366)
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
        Me.gbxAHP.Size = New System.Drawing.Size(590, 406)
        Me.gbxAHP.TabIndex = 4
        Me.gbxAHP.TabStop = False
        Me.gbxAHP.Text = "AHP"
        '
        'dgvAHP
        '
        Me.dgvAHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAHP.Location = New System.Drawing.Point(7, 20)
        Me.dgvAHP.Name = "dgvAHP"
        Me.dgvAHP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvAHP.Size = New System.Drawing.Size(577, 380)
        Me.dgvAHP.TabIndex = 0
        '
        'gbxHasil
        '
        Me.gbxHasil.Controls.Add(Me.dgvHasil)
        Me.gbxHasil.Location = New System.Drawing.Point(610, 13)
        Me.gbxHasil.Name = "gbxHasil"
        Me.gbxHasil.Size = New System.Drawing.Size(241, 347)
        Me.gbxHasil.TabIndex = 5
        Me.gbxHasil.TabStop = False
        Me.gbxHasil.Text = "Ranking"
        '
        'dgvHasil
        '
        Me.dgvHasil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHasil.Location = New System.Drawing.Point(7, 20)
        Me.dgvHasil.Name = "dgvHasil"
        Me.dgvHasil.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvHasil.Size = New System.Drawing.Size(228, 321)
        Me.dgvHasil.TabIndex = 0
        '
        'frmAHP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 431)
        Me.Controls.Add(Me.gbxHasil)
        Me.Controls.Add(Me.gbxAHP)
        Me.Controls.Add(Me.cmdTutup)
        Me.Controls.Add(Me.cmdSimpan)
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
End Class
