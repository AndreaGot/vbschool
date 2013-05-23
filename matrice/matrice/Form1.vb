Public Class Form1
    Dim matr(,) As Integer

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i, j As Integer
        Dim rig As Integer
        Dim col As Integer

        rig = Val(numericupdown1.value)
        col = Val(numericupdown2.value)

        ReDim matr(rig - 1, col - 1)

        Label1.Text = UBound(matr)

        For i = 0 To rig - 1
            For j = 0 To col - 1
                matr(i, j) = Int(10 * Rnd() + 1)
            Next
        Next

    End Sub

    Private Sub visualizza(ByVal matrice(,) As Single, ByVal nr As Integer, ByVal nc As Integer)
    End Sub

End Class
