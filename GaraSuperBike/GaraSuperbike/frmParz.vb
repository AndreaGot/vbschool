Public Class frmParz

    Private Sub btnCalcola_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalcola.Click
        Dim Scelta As Integer
        Dim i As Integer
        Scelta = lstScelta.SelectedIndex

        lstNome.Items.Clear()
        lstTemp1.Items.Clear()
        lstTemp2.Items.Clear()

        Select Case Scelta
            Case 0
                Call Classifica(VetTemp1, VetTemp2)

            Case 1
                Call Classifica(VetTemp2, VetTemp1)

            Case Else
                MsgBox("Scegliere in che ordine si vuole vengano mostrate le classifiche", MsgBoxStyle.Exclamation, "Attenzione Prego!")
                Exit Sub
        End Select

        For i = 0 To Dimen - 1
            lstNome.Items.Add(VetNome(i))
            lstTemp1.Items.Add(VetTemp1(i))
            lstTemp2.Items.Add(VetTemp2(i))
        Next

    End Sub

End Class