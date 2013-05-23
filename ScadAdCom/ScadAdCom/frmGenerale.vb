Public Class frmScadAdCom

    Private Sub mnuIns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuIns.Click
        Dim x As New frmDati

        x.MdiParent = Me

        x.Show()
    End Sub

    Private Sub mnuScadAd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuScadAd.Click
        Dim x As New frmScadAd

        x.MdiParent = Me

        x.Show()
    End Sub

    Private Sub mnuScadCom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuScadCom.Click
        Dim x As New frmScadCom

        x.MdiParent = Me

        x.Show()
    End Sub
End Class
