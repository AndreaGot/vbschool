Public Class frmQuiz
    Dim Risp(9, 3) As String
    Dim Dom(9) As String
    Dim DovRispGiust(9) As Integer
    Dim casual As Integer
    Dim Cont, Cont1 As Integer


    Private Sub frmQuiz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cont1 = 0
        Cont = 0
        MsgBox("Benvenuto a Chi Vuol Essere Milionario sig. " & Nome & "!", MsgBoxStyle.Exclamation, "Welcome")


        Dom(0) = "Quando è stata scoperta l'america?"

        Risp(0, 0) = "1942"
        risp(0, 1) = "1492"
        Risp(0, 2) = "1472"
        Risp(0, 3) = "1292"
        DovRispGiust(0) = 2

        Dom(1) = "Mentre andavo alla fiera ho incontrato il sig. Rossi" & vbCrLf & "seguito dai suoi 2 figli, i quali avevano al" & vbCrLf & "guinzaglio ciascuno 3 cani, i quali avevano 5 pulci ciascuno... " & vbCrLf & "In totale quante persone stavano andando alla fiera??"

        risp(1, 0) = "33"
        risp(1, 1) = "1"
        risp(1, 2) = "27"
        risp(1, 3) = "3"
        DovRispGiust(1) = 2

        Dom(2) = "Quale fu il primo video fatto dai Metallica??"

        risp(2, 0) = "Nothing Else Matters"
        risp(2, 1) = "Master Of Puppets"
        risp(2, 2) = "One"
        Risp(2, 3) = "Enter Sandman"
        DovRispGiust(2) = 3

        dom(3) = "Chi ha inventato la lampadina??"

        risp(3, 0) = "Albert Einstein"
        risp(3, 1) = "Charlie Brown"
        risp(3, 2) = "Benjamin Franklin"
        Risp(3, 3) = "Thomas Edison"
        DovRispGiust(3) = 4

        dom(4) = "Chi ha inventato il telefono??"

        Risp(4, 0) = "Antonio Santi Giuseppe Meucci"
        Risp(4, 1) = "Giuseppe Santi Antonio Meucci"
        risp(4, 2) = "Andrea Volta"
        Risp(4, 3) = "Giuseppe Volta"
        DovRispGiust(4) = 1

        Dom(5) = "Quale altra opera costruì Gustave Eiffel oltre" & vbCrLf & "alla celebre torre parigina??"

        risp(5, 0) = "La Cattedrale di Notre Dame"
        risp(5, 1) = "La statua della Libertà"
        risp(5, 2) = "Il Big Ben"
        risp(5, 3) = "La torre di Pisa"
        DovRispGiust(5) = 2

        dom(6) = "Chi ha dipinto 'La Gioconda'??"

        risp(6, 0) = "Leonardo"
        risp(6, 1) = "Caravaggio"
        risp(6, 2) = "Michelangelo"
        risp(6, 3) = "Raffaello"
        DovRispGiust(6) = 1

        Dom(7) = "Quale attore interpreta il ruolo di" & vbCrLf & "Aragorn nel 'Signore degli Anelli'??"

        risp(7, 0) = "Elijah Wood "
        risp(7, 1) = "Ian McKellen "
        risp(7, 2) = "Orlando Bloom "
        Risp(7, 3) = "Viggo Mortensen "
        DovRispGiust(7) = 4

        dom(8) = "A quanti gradi farenheit l'acqua bolle??"

        risp(8, 0) = "220"
        risp(8, 1) = "212"
        risp(8, 2) = "200"
        risp(8, 3) = "32"
        DovRispGiust(8) = 2

        Dom(9) = "Quale stato americano ha come" & vbCrLf & "capitale Sacramento??"

        risp(9, 0) = "Florida"
        risp(9, 1) = "Washington"
        risp(9, 2) = "California"
        risp(9, 3) = "Texas"
        DovRispGiust(9) = 3

        Call visualizza(lblDomanda, rdbR1, rdbR2, rdbR3, rdbR4, Risp, Dom)

    End Sub
    Private Sub visualizza(ByRef label As Label, ByRef rdb1 As RadioButton, ByRef rdb2 As RadioButton, ByRef rdb3 As RadioButton, ByRef rdb4 As RadioButton, ByVal MatriceRisp(,) As String, ByVal VettoreDom() As String)

        Randomize()
        casual = Int(Rnd() * 10)

        label.Text = vettoredom(casual)
        rdb1.Text = matricerisp(casual, 0)
        rdb2.Text = matricerisp(casual, 1)
        rdb3.Text = matricerisp(casual, 2)
        rdb4.Text = matricerisp(casual, 3)

    End Sub

    
    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim Scelta As Integer
        Dim Risp1, Risp2, Risp3, Risp4 As Boolean

        

        Risp1 = rdbR1.Checked
        Risp2 = rdbR2.Checked
        Risp3 = rdbR3.Checked
        Risp4 = rdbR4.Checked

        If Risp1 = True Then
            Scelta = 1
        ElseIf Risp2 = True Then
            Scelta = 2
        ElseIf Risp3 = True Then
            Scelta = 3
        ElseIf Risp4 = True Then
            Scelta = 4
        End If


        If Scelta = DovRispGiust(casual) Then
            MsgBox("Bravo " & nome & " hai risposto correttamente!")
            lblGiust.Text = Cont + 1
        Else
            lblSbaià.Text = Cont1 + 1
        End If
    End Sub
End Class
