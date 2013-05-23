Module Dichiarazioni

    Public VetTemp1() As Single
    Public VetTemp2() As Single
    Public VetNome() As String
    Public VetTempTot() As Single
    Public Dimen As Integer


    Public Sub Classifica(ByRef Tempo() As Single, ByRef Tempo2() As Single)

        Dim I As Integer
        Dim H As Integer

        I = 0
        H = 0

        For I = 0 To Dimen - 2
            For H = I + 1 To Dimen - 1
                If Tempo(H) < Tempo(I) Then
                    Call scambia(Tempo(H), Tempo(I))
                    Call ScambiaNome(VetNome(H), VetNome(I))
                    Call scambia(Tempo2(H), Tempo2(I))
                End If
            Next
        Next
    End Sub

    Public Sub scambia(ByRef Temp1 As Single, ByRef Temp2 As Single)
        Dim Parc As Single
        Parc = Temp1
        Temp1 = Temp2
        Temp2 = Parc
    End Sub
    Public Sub ScambiaNome(ByRef Parola1 As String, ByRef Parola2 As String)
        Dim Parc As String
        Parc = Parola1
        Parola1 = Parola2
        Parola2 = Parc

    End Sub

    Public Sub ClassificaGen(ByRef TempTotali() As Single, ByRef TemParz1() As Single, ByRef TemParz2() As Single, ByVal Nomi() As String)

        Dim I As Integer
        Dim Scambiato As Boolean
        Dim Fine As Integer
        Fine = Dimen - 2
        Scambiato = True

        Do While (Fine >= 0) And (Scambiato)
            Scambiato = False

            For I = 0 To Fine
                If TempTotali(I) > TempTotali(I + 1) Then
                    Call scambia(TempTotali(I), TempTotali(I + 1))
                    Call ScambiaNome(Nomi(I), Nomi(I + 1))
                    Call scambia(TemParz1(I), TemParz1(I + 1))
                    Call scambia(TemParz2(I), TemParz2(I + 1))
                    Scambiato = True
                End If

            Next
        Loop
    End Sub
    

End Module
