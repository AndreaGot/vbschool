Public Class frmCresc
    Dim VettNum() As Integer
    Dim NumElem As Integer
    Private Sub btnInsert_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInsert.Click
        Dim Num As Integer

        Num = Val(txtNum.Text)
        ReDim Preserve VettNum(NumElem)

        VettNum(NumElem) = Num
        NumElem = NumElem + 1

        visualizza(VettNum, lstNum)

        txtNum.Clear()
        txtNum.Focus()
    End Sub

    Public Sub visualizza(ByVal Vett() As Integer, ByRef Lista As ListBox)
        Dim I As Integer

        Lista.Items.Clear()
        For I = 0 To UBound(Vett)
            Lista.Items.Add(Vett(I))
        Next
    End Sub

    Private Sub grpInserimento_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpInserimento.Enter
        NumElem = 0
    End Sub

    Private Sub btnSoStuf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSoStuf.Click
        grpInserimento.Enabled = False
        grpScelta.Enabled = True
        rdbCresc.Focus()
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim Scelta As Boolean

        Scelta = rdbCresc.Checked

            Call Ordina(VettNum, Scelta)

            grpOrdinato.Enabled = True
    End Sub

    Private Sub Ordina(ByRef vett() As Integer, ByVal Scelta As Boolean)
        Dim Fine As Integer
        Dim I As Integer
        Dim Scambiato As Boolean

        Fine = UBound(vett) - 1
        Scambiato = True
        Do While (Fine >= 0) And Scambiato
            Scambiato = False
            For I = 0 To Fine
                If Scelta Then
                    If vett(I) > vett(I + 1) Then
                        Call scambia(vett(I), vett(I + 1))
                        Scambiato = True
                    End If
                Else
                    If vett(I) < vett(I + 1) Then
                        Call Scambia(vett(I), vett(I + 1))
                        Scambiato = True
                    End If
                End If
            Next
            Fine = Fine - 1

        Loop

        Call visualizza(VettNum, lstOrdinata)
    End Sub

    Private Sub Scambia(ByRef Num1 As Integer, ByRef Num2 As Integer)
        Dim Porc As Integer
        Porc = Num1
        Num1 = Num2
        Num2 = Porc
    End Sub


End Class
