Public Class frmSupBik

    Private Sub mnuDati_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuDati.Click
        Dim x As New frmDati

        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub mnuParz_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuParz.Click
        Dim x As New frmParz

        x.MdiParent = Me
        x.Show()
    End Sub

    Private Sub mnuGen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuGen.Click
        Dim x As New frmGen

        x.MdiParent = Me
        x.Show()
    End Sub

End Class
