Public Class frmNome

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNome.TextChanged
        btnOk.Enabled = True
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        nome = txtnome.text

        frmQuiz.Show()
        Me.Hide()


    End Sub
End Class