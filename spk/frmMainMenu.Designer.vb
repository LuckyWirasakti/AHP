<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.InputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KriteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubKriteriaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AlternatifToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PerbandinganBerpasanganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KriteriaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubKriteriaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NilaiAlternatifToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OutputToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformasiNilaiPrioritasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AHPToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputToolStripMenuItem, Me.PerbandinganBerpasanganToolStripMenuItem, Me.NilaiAlternatifToolStripMenuItem, Me.OutputToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(749, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'InputToolStripMenuItem
        '
        Me.InputToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KriteriaToolStripMenuItem, Me.SubKriteriaToolStripMenuItem, Me.AlternatifToolStripMenuItem, Me.ToolStripSeparator1, Me.KeluarToolStripMenuItem})
        Me.InputToolStripMenuItem.Name = "InputToolStripMenuItem"
        Me.InputToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.InputToolStripMenuItem.Text = "Input"
        '
        'KriteriaToolStripMenuItem
        '
        Me.KriteriaToolStripMenuItem.Name = "KriteriaToolStripMenuItem"
        Me.KriteriaToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.KriteriaToolStripMenuItem.Text = "Kriteria"
        '
        'SubKriteriaToolStripMenuItem
        '
        Me.SubKriteriaToolStripMenuItem.Name = "SubKriteriaToolStripMenuItem"
        Me.SubKriteriaToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.SubKriteriaToolStripMenuItem.Text = "Sub Kriteria"
        '
        'AlternatifToolStripMenuItem
        '
        Me.AlternatifToolStripMenuItem.Name = "AlternatifToolStripMenuItem"
        Me.AlternatifToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.AlternatifToolStripMenuItem.Text = "Alternatif"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(131, 6)
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'PerbandinganBerpasanganToolStripMenuItem
        '
        Me.PerbandinganBerpasanganToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KriteriaToolStripMenuItem1, Me.SubKriteriaToolStripMenuItem1})
        Me.PerbandinganBerpasanganToolStripMenuItem.Name = "PerbandinganBerpasanganToolStripMenuItem"
        Me.PerbandinganBerpasanganToolStripMenuItem.Size = New System.Drawing.Size(164, 20)
        Me.PerbandinganBerpasanganToolStripMenuItem.Text = "Perbandingan Berpasangan"
        '
        'KriteriaToolStripMenuItem1
        '
        Me.KriteriaToolStripMenuItem1.Name = "KriteriaToolStripMenuItem1"
        Me.KriteriaToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
        Me.KriteriaToolStripMenuItem1.Text = "Kriteria"
        '
        'SubKriteriaToolStripMenuItem1
        '
        Me.SubKriteriaToolStripMenuItem1.Name = "SubKriteriaToolStripMenuItem1"
        Me.SubKriteriaToolStripMenuItem1.Size = New System.Drawing.Size(134, 22)
        Me.SubKriteriaToolStripMenuItem1.Text = "Sub Kriteria"
        '
        'NilaiAlternatifToolStripMenuItem
        '
        Me.NilaiAlternatifToolStripMenuItem.Name = "NilaiAlternatifToolStripMenuItem"
        Me.NilaiAlternatifToolStripMenuItem.Size = New System.Drawing.Size(95, 20)
        Me.NilaiAlternatifToolStripMenuItem.Text = "Nilai Alternatif"
        '
        'OutputToolStripMenuItem
        '
        Me.OutputToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformasiNilaiPrioritasToolStripMenuItem, Me.AHPToolStripMenuItem})
        Me.OutputToolStripMenuItem.Name = "OutputToolStripMenuItem"
        Me.OutputToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.OutputToolStripMenuItem.Text = "Output"
        '
        'InformasiNilaiPrioritasToolStripMenuItem
        '
        Me.InformasiNilaiPrioritasToolStripMenuItem.Name = "InformasiNilaiPrioritasToolStripMenuItem"
        Me.InformasiNilaiPrioritasToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.InformasiNilaiPrioritasToolStripMenuItem.Text = "Informasi Nilai Prioritas"
        '
        'AHPToolStripMenuItem
        '
        Me.AHPToolStripMenuItem.Name = "AHPToolStripMenuItem"
        Me.AHPToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.AHPToolStripMenuItem.Text = "AHP"
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(749, 395)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistem Pendukung Keputusan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents InputToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KriteriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubKriteriaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AlternatifToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PerbandinganBerpasanganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KriteriaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SubKriteriaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NilaiAlternatifToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OutputToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformasiNilaiPrioritasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AHPToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
