Public Class frmMainMenu
    Dim status As Int16 = 0
    Private Sub KeluarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub

    Private Sub KriteriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KriteriaToolStripMenuItem.Click
        Dim frm As New frmKriteria
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SubKriteriaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubKriteriaToolStripMenuItem.Click
        Dim frm As New frmSubKriteria
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub AlternatifToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AlternatifToolStripMenuItem.Click
        Dim frm As New frmAlternatif
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub KriteriaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KriteriaToolStripMenuItem1.Click
        Dim frm As New frmPBKriteria
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub SubKriteriaToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SubKriteriaToolStripMenuItem1.Click
        Dim frm As New frmPBSubKriteria
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub NilaiAlternatifToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NilaiAlternatifToolStripMenuItem.Click
        Dim frm As New frmPenilaianAlternatif
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub InformasiNilaiPrioritasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformasiNilaiPrioritasToolStripMenuItem.Click
        Dim frm As New frmNilaiPrioritasKriteria
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub AHPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AHPToolStripMenuItem.Click
        Dim frm As New frmAHP
        frm.MdiParent = Me
        frm.Show()
    End Sub

    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmMainMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        End
    End Sub
End Class