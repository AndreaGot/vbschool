Public Class Form1
    Dim I As Integer
    Dim Vett1() As Single
    Dim Vett2() As Single
    Dim Vett3() As Single

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Focus()

    End Sub

    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        Dim Num1 As Single
        Dim Temp As Integer

        Num1 = Val(txt1.Text)

        Call babbol(Vett1)

        Temp = DicoTomica(Vett1, Num1)

        If Temp = UBound(Vett1) + 2 Then
            lbl1.Text = "Non ho trovato niente"
        Else
            lbl1.Text = "Ho trovato il numero" & vbCrLf & "da te richiesto" & vbCrLf & "nella posizione" & vbCrLf & "numero: " & CStr(Temp)
        End If
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        Dim Num2 As Single
        Dim Temp As Integer

        Num2 = Val(txt2.Text)

        Call babbol(Vett2)

        Temp = DicoTomica(Vett2, Num2)

        If Temp = UBound(Vett2) + 2 Then
            lbl2.Text = "Non ho trovato niente"
        Else
            lbl2.Text = "Ho trovato il numero" & vbCrLf & "da te richiesto" & vbCrLf & "nella posizione" & vbCrLf & "numero: " & CStr(Temp)
        End If
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        Dim Num3 As Single
        Dim Temp As Integer

        Num3 = Val(txt3.Text)

        Call babbol(Vett3)

        Temp = DicoTomica(Vett3, Num3)

        If Temp = UBound(Vett3) + 2 Then
            lbl3.Text = "Non ho trovato niente"
        Else
            lbl3.Text = "Ho trovato il numero" & vbCrLf & "da te richiesto" & vbCrLf & "nella posizione" & vbCrLf & "numero: " & CStr(Temp)
        End If
    End Sub

    Private Sub babbol(ByRef Vettore() As Single)
        Dim I As Integer
        Dim Scambiato As Boolean
        Dim fine As Integer

        Scambiato = True
        fine = UBound(Vettore) - 1

        Do While Scambiato = True And fine >= 0
            Scambiato = False
            For I = 0 To fine
                If Vettore(I) > Vettore(I + 1) Then
                    Call Scambia(Vettore(I), Vettore(I + 1))
                    Scambiato = True
                End If
            Next
            fine = fine - 1
        Loop
    End Sub

    Private Sub Scambia(ByRef Snum1 As Single, ByRef Snum2 As Single)
        Dim Parch As Single

        Parch = Snum1
        Snum1 = Snum2
        Snum2 = Parch
    End Sub

    Private Function DicoTomica(ByRef Vett() As Single, ByRef DaCerc As Single) As Integer
        Dim Trovato As Boolean
        Dim Centro As Integer
        Dim Destra As Integer
        Dim Sinistra As Integer
        Dim I As Integer


        Sinistra = 0
        Destra = UBound(Vett)

        Do

            Centro = (Destra + Sinistra) \ 2

            If Vett(Centro) = DaCerc Then
                I = Centro
                Trovato = True

            ElseIf Vett(Sinistra) = DaCerc Then
                I = Sinistra
                Trovato = True

            ElseIf Vett(Destra) = DaCerc Then
                I = Destra
                Trovato = True

            ElseIf DaCerc < Vett(Centro) Then
                Destra = Centro - 1
                Sinistra = Sinistra + 1
            Else
                Destra = Destra - 1
                Sinistra = Centro + 1
            End If

        Loop Until Trovato = True Or (Sinistra > Destra)

        If Trovato Then
            DicoTomica = I + 1
        Else
            DicoTomica = UBound(Vett) + 2

        End If
    End Function


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim NumNum As Integer
        Dim a As Integer

        NumNum = Val(TextBox1.Text)

        ReDim Vett1(NumNum - 1)
        ReDim Vett2(NumNum - 1)
        ReDim Vett3(NumNum - 1)



        For I = 0 To NumNum - 1

            Randomize()

            a = Int((NumNum - 1) * Rnd() + 1)
            lst1.Items.Add(a)
            Vett1(I) = a

            a = Int((NumNum - 1) * Rnd() + 1)
            lst2.Items.Add(a)
            Vett2(I) = a

            a = Int((NumNum - 1) * Rnd() + 1)
            lst3.Items.Add(a)
            Vett3(I) = a
        Next

        grpRic.Enabled = True
    End Sub

   
End Class
