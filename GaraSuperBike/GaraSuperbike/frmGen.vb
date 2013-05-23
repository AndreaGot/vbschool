Public Class frmGen

   
    Private Sub frmGen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim I As Integer


        ClassificaGen(VetTempTot, VetTemp1, VetTemp2, VetNome)

        For I = 0 To Dimen - 1
            lstNome.Items.Add(VetNome(I))
            lstTemp1.Items.Add(VetTemp1(I))
            lstTemp2.Items.Add(VetTemp2(I))
            lstTempTot.Items.Add(VetTempTot(I))
        Next

    End Sub
End Class