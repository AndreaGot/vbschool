Public Class Menu
    Private Sub StudentiToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuStudenti.Click
        Dim x As New Studenti
        x.MdiParent = Me
        x.Show()

    End Sub

    Private Sub SportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSport.Click
        Dim x As New SportPreferito
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub mnuEsci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuEsci.Click
        Me.Close()
    End Sub

    Private Sub GestioneProvinceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GestioneProvinceToolStripMenuItem.Click
        Dim x As New Province
        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub Menu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub mnuGriglia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGriglia.Click
        Dim x As New frmGriglia
        x.MdiParent = Me
        x.show()

    End Sub
End Class