Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.oledb

Public Class Province

    Private m_currencymanager As CurrencyManager
    Dim Aggiungi As Boolean
    Dim Primavolta As Boolean

    Private Sub btnPrimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrimo.Click
        m_currencymanager.Position = 0

        Call VisualizzaPosizione()
    End Sub

    Private Sub btnPrima_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrima.Click
        m_currencymanager.Position = m_currencymanager.Position - 1

        Call VisualizzaPosizione()
    End Sub

    Private Sub btnDopo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDopo.Click
        m_currencymanager.Position = m_currencymanager.Position + 1

        Call VisualizzaPosizione()
    End Sub

    Private Sub btnUltimo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUltimo.Click
        m_currencymanager.Position = m_currencymanager.Count - 1

        Call VisualizzaPosizione()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        m_currencymanager.AddNew()

        Aggiungi = True
        Call AbilitaSalva()
        Call AbilitaText()
        Call DisabilitaNavigatore()

        txtPosizione.Text = "Aggiunta"

        txtnomeprov.Focus()
    End Sub

    Private Sub btnSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalva.Click
        Dim ID As Integer
        Dim Pos As Integer
        Dim NomeProv As String
        Dim Sigla As String

        NomeProv = txtnomeprov.Text
        Sigla = txtsigla.Text

        Try

            If Aggiungi Then
                cmdAggiungiProv.Parameters.Add(New OleDb.OleDbParameter("Nome", NomeProv))
                cmdAggiungiProv.Parameters.Add(New OleDb.OleDbParameter("Sigla", Sigla))
                cmdAggiungiProv.ExecuteNonQuery()
                cmdAggiungiProv.Parameters.Clear()
                m_currencymanager.Position = m_currencymanager.Count - 1
                Call VisualizzaPosizione()
            Else
                Pos = m_currencymanager.Position
                ID = CInt(dtProv.Rows(Pos).Item("IDProvincia"))
                cmdSalvaProv.Parameters.Add(New OleDb.OleDbParameter("Nome", NomeProv))
                cmdSalvaProv.Parameters.Add(New OleDb.OleDbParameter("Sigla", Sigla))
                cmdSalvaProv.Parameters.Add(New OleDb.OleDbParameter("IDProvincia", ID))
                cmdSalvaProv.ExecuteNonQuery()
                cmdSalvaProv.Parameters.Clear()
            End If
            Aggiungi = False
            Call Disabilitasalva()
            Call DisabilitaText()
            Call Abilitanavigatore()

            dtProv.Clear()
            DAProv.Fill(dtProv)


            Call VisualizzaPosizione()

        Catch x As InvalidCastException
            MsgBox("Il record appena inserito non è modificabile")
        End Try
    End Sub

    Private Sub btnElimina_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElimina.Click
        Dim Pos As Integer
        Dim ID As Integer
        Dim msg As String
        Dim title As String
        Dim style As MsgBoxStyle
        Dim response As MsgBoxResult


        Pos = m_currencymanager.Position

        If Pos = -1 Then
            MsgBox("Non ci sono record eliminabili")
            Exit Sub
        End If

        msg = "Sei sicuro di volerlo eliminare?"   ' Define message.
        style = MsgBoxStyle.DefaultButton2 Or _
           MsgBoxStyle.Exclamation Or MsgBoxStyle.YesNo
        title = "Eliminazione Record"   ' Define title.
        ' Display message.
        response = MsgBox(msg, style, title)
        If response = MsgBoxResult.Yes Then   ' User chose Yes.


            ID = CInt((dtProv.Rows(Pos).Item("IDProvincia")))

            cmdEliminaProv.Parameters.Add(New OleDb.OleDbParameter("IDProvincia", ID))
            cmdEliminaProv.ExecuteNonQuery()
            cmdEliminaProv.Parameters.Clear()
        End If

        dtProv.Clear()
        DAProv.Fill(dtProv)

        m_currencymanager.Position = 0

        Call VisualizzaPosizione()

    End Sub

    Private Sub btnModifica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifica.Click
        Aggiungi = False

        If m_currencymanager.Position < 0 Then
            MsgBox("Nessun record presente")
            Exit Sub
        End If

        Call AbilitaSalva()
        Call AbilitaText()

        Call DisabilitaNavigatore()
    End Sub

    Private Sub btnFine_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFine.Click
        Me.Close()
    End Sub

    Private Sub btnAnnulla_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnnulla.Click
        m_currencymanager.CancelCurrentEdit()

        Call Disabilitasalva()
        Call DisabilitaText()
        Call Abilitanavigatore()
        Call VisualizzaPosizione()

    End Sub

    Private Sub AbilitaSalva()
        grpConferma.Enabled = True
        grpOper.Enabled = False
        btnFine.Enabled = False
    End Sub

    Private Sub Disabilitasalva()
        grpConferma.Enabled = False
        grpOper.Enabled = True
        btnFine.Enabled = True
    End Sub

    Private Sub AttivaCurrency()
        If Primavolta Then
            Primavolta = False
        Else
            m_currencymanager.Refresh()
        End If

        m_currencymanager = DirectCast(Me.BindingContext(dtProv), CurrencyManager)
        m_currencymanager.Position = 0
    End Sub

    Private Sub AssociaCampi()
        txtsigla.DataBindings.Add("text", dtProv, "Sigla")
        txtnomeprov.DataBindings.Add("text", dtProv, "Nome")
        txtID.DataBindings.Add("text", dtProv, "IDProvincia")

    End Sub

    Private Sub DisabilitaText()
        txtsigla.Enabled = False
        txtnomeprov.Enabled = False
    End Sub

    Private Sub AbilitaText()
        txtsigla.Enabled = True
        txtnomeprov.Enabled = True
    End Sub

    Private Sub Abilitanavigatore()
        btnPrimo.Enabled = True
        btnUltimo.Enabled = True
        btnPrima.Enabled = True
        btnDopo.Enabled = True
    End Sub

    Private Sub DisabilitaNavigatore()
        btnPrimo.Enabled = False
        btnUltimo.Enabled = False
        btnPrima.Enabled = False
        btnDopo.Enabled = False
    End Sub

    Private Sub VisualizzaPosizione()
        Dim totale As Integer
        Dim posizione As Integer
        Dim stringaposizione As String

        totale = m_currencymanager.Count
        posizione = m_currencymanager.Position + 1
        stringaposizione = CStr(posizione) & " di " & CStr(totale)
        txtPosizione.Text = stringaposizione

    End Sub

    Private Sub Province_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Call ChiudiConnProv()


    End Sub
 
    Private Sub Province_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ApriConn()
        Primavolta = True

        Call ProvDaDt()
        Call AttivaCurrency()
        Call Disabilitasalva()
        Call DisabilitaText()
        Call Abilitanavigatore()

        Call AssociaCampi()
        Call VisualizzaPosizione()
    End Sub
End Class