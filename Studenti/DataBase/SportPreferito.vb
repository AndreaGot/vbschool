Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.oledb

Public Class SportPreferito

    Private m_currencymanager As CurrencyManager
    Dim Aggiungi As Boolean
    Dim Primavolta As Boolean

    Private Sub SportPreferito_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Call ChiudiConnSport()
    End Sub

    Private Sub SportPreferito_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ApriConn()
        Primavolta = True

        Call SportDaDt()
        Call AttivaCurrency()
        Call Disabilitasalva()
        Call DisabilitaText()
        Call Abilitanavigatore()

        Call AssociaCampi()
        Call VisualizzaPosizione()
    End Sub

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

        txtSport.Focus()
    End Sub

    Private Sub btnSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalva.Click
        Dim ID As Integer
        Dim Pos As Integer
        Dim Sport As String
        Dim Descrizione As String

        Sport = txtSport.Text
        Descrizione = txtDesc.Text

        Try

            If Aggiungi Then
                cmdAggiungiSport.Parameters.Add(New OleDb.OleDbParameter("Sport", Sport))
                cmdAggiungiSport.Parameters.Add(New OleDb.OleDbParameter("Descrizione", Descrizione))
                cmdAggiungiSport.ExecuteNonQuery()
                cmdAggiungiSport.Parameters.Clear()
                m_currencymanager.Position = m_currencymanager.Count - 1
                Call VisualizzaPosizione()
            Else
                Pos = m_currencymanager.Position
                ID = CInt(dtSport.Rows(Pos).Item("IDSport"))
                cmdSalvaSport.Parameters.Add(New OleDb.OleDbParameter("Sport", Sport))
                cmdSalvaSport.Parameters.Add(New OleDb.OleDbParameter("Descrizione", Descrizione))
                cmdSalvaSport.Parameters.Add(New OleDb.OleDbParameter("IDSport", ID))
                cmdSalvaSport.ExecuteNonQuery()
                cmdSalvaSport.Parameters.Clear()
            End If
            Aggiungi = False
            Call Disabilitasalva()
            Call DisabilitaText()
            Call Abilitanavigatore()

            dtSport.Clear()
            DASport.Fill(dtSport)


            Call VisualizzaPosizione()

        Catch x As InvalidCastException
            MsgBox("Il record appena inserito non � modificabile")
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


            ID = CInt((dtSport.Rows(Pos).Item("IDSport")))

            cmdEliminaSport.Parameters.Add(New OleDb.OleDbParameter("IDSport", ID))
            cmdEliminaSport.ExecuteNonQuery()
            cmdEliminaSport.Parameters.Clear()
        End If

        dtSport.Clear()
        DASport.Fill(dtSport)

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

        m_currencymanager = DirectCast(Me.BindingContext(dtSport), CurrencyManager)
        m_currencymanager.Position = 0
    End Sub

    Private Sub AssociaCampi()
        txtDesc.DataBindings.Add("text", dtSport, "Descrizione")
        txtSport.DataBindings.Add("text", dtSport, "Sport")
        txtID.DataBindings.Add("text", dtSport, "IDSport")

    End Sub

    Private Sub DisabilitaText()
        txtDesc.Enabled = False
        txtSport.Enabled = False
    End Sub

    Private Sub AbilitaText()
        txtDesc.Enabled = True
        txtSport.Enabled = True
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



    
End Class