Public Class frmParDisp
    Dim Numeri() As Integer
    Dim Posti As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Numero As Integer

        Numero = txtNome.Text

        ReDim Preserve Numeri(Posti)



        Numeri(Posti) = Numero





        Posti = Posti + 1


    End Sub

    Private Sub frmParDisp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Posti = 0

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim i As Integer

        For I = 0 To Posti - 1
            ListBox2.Items.Add(Numeri(I))
        Next
    End Sub
End Class
