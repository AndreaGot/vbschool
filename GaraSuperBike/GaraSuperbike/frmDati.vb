Public Class frmDati
    Dim I As Integer = 0

 
  
    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        '----------------dichiarazione
        Dim Nome As String
        Dim Tot1Man As Single
        Dim Tot2Man As Single
        '---------------- variabili temporanee
        Dim TempCent1 As Integer
        Dim TempSec1 As Integer
        Dim TempMin1 As Integer
        Dim TempCent2 As Integer
        Dim TempSec2 As Integer
        Dim TempMin2 As Integer

        '----------------input
        Nome = txtNome.Text
        TempCent1 = nudCent.Value
        TempCent2 = nudCent2.Value
        TempMin1 = nudMin.Value
        TempMin2 = nudMin2.Value
        TempSec1 = nudSec.Value
        TempSec2 = nudSec2.Value


        '---------------- tempo gara 1

        CalcolaTempo(TempCent1, TempSec1, TempMin1, Tot1Man)

        '--------------- tempo gara 2
        CalcolaTempo(TempCent2, TempSec2, TempMin2, Tot2Man)



        '--------------- output in lista

        lstNome.Items.Add(Nome)
        lstTemp1.Items.Add(Tot1Man)
        lstTemp2.Items.Add(Tot2Man)
        lstTempTot.Items.Add(Format((Tot1Man + Tot2Man), "#,##0.00"))

        '--------------- incremento contatore
        I = I + 1

        '--------------- attivazione bottone
        If I > 1 Then
            btnFine.Enabled = True
        End If

        If I = 1 Then
            lblDiciamolo.Text = "Hai inserito " & I & " Pilota"
        Else
            lblDiciamolo.Text = "Hai inserito " & I & " Piloti"
        End If

        txtNome.Text = ""
        nudCent.Value = "00"
        nudCent2.Value = "00"
        nudMin.Value = "00"
        nudMin2.Value = "00"
        nudSec.Value = "00"
        nudSec2.Value = "00"

    End Sub

    Private Sub CalcolaTempo(ByVal Centesimi As Integer, ByVal secondi As Integer, ByVal minuti As Integer, ByRef TempoManche As Single)

        TempoManche = minuti * 60 + secondi + (Centesimi / 100)
    End Sub

    Private Sub btnFine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFine.Click
        Dim x As Control

        ReDim VetNome(I - 1)
        ReDim VetTemp1(I - 1)
        ReDim VetTemp2(I - 1)
        ReDim VetTempTot(I - 1)


        For Dimen = 0 To I - 1

            VetNome(Dimen) = lstNome.Items.Item(Dimen)
            VetTemp1(Dimen) = lstTemp1.Items.Item(Dimen)
            VetTemp2(Dimen) = lstTemp2.Items.Item(Dimen)
            VetTempTot(Dimen) = lstTempTot.Items.Item(Dimen)


        Next

        For Each x In Me.Controls

            x.Enabled = False

        Next
        lblDiciamolo.Enabled = True

    End Sub

    Private Sub nudMin_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudMin.GotFocus
        nudMin.ResetText()
    End Sub

    Private Sub nudMin2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudMin2.GotFocus
        nudMin2.ResetText()

    End Sub

    Private Sub nudSec_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudSec.GotFocus
        nudSec.ResetText()

    End Sub

    Private Sub nudSec2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudSec2.GotFocus
        nudSec2.ResetText()
    End Sub

    Private Sub nudCent_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudCent.GotFocus
        nudCent.ResetText()
    End Sub

    Private Sub nudCent2_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles nudCent2.GotFocus
        nudCent2.ResetText()
    End Sub

End Class