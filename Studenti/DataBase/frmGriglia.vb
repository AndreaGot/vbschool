Public Class frmGriglia

    Private Sub btnAggiorna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAggiorna.Click
        bs.EndEdit()
        Dim cb As New OleDb.OleDbCommandBuilder(DA)
        DA.Update(ds, "SportGrid2")


    End Sub

    Private Sub frmGriglia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ApriConn()
        Call ImpostaDs()
        Call ColonneGriglia()
        grdSport.DataSource = bs
    End Sub

    Private Sub ColonneGriglia()
        grdSport.DataSource = bs
        grdSport.Columns(0).Visible = False
        grdSport.Columns(1).Width = 350

    End Sub
End Class