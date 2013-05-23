
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Data
Imports System.Data.oledb


Public Class Studenti


    Private m_currencymanager As CurrencyManager
    Dim Aggiungi As Boolean


    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Call ChiudiConn()
    End Sub
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'dt.Clear()
        'DA.Dispose()
        'dt.Dispose()

        dtProvStud.Clear()
        DAProvStud.Dispose()
        dtProvStud.Dispose()

        dtSportStud.Clear()
        DASportStud.Dispose()
        dtSportStud.Dispose()

        Call ApriConn()
        If Primavolta = False Then

        End If
        Call StudentiDaDt()

        Primavolta = True
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

        txtNome.Focus()
    End Sub
    Private Sub btnSalva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalva.Click
        Dim ID As Integer
        Dim IDSport As Integer
        Dim IDProvincia As Integer
        Dim Pos As Integer
        Dim Nome As String
        Dim Cognome As String
        Dim DataNascita As String

        Nome = txtNome.Text
        Cognome = txtCognome.Text
        DataNascita = txtDataNascita.Text
        IDSport = cmbSport.SelectedValue
        IDProvincia = cmbProv.SelectedValue


        Try
            If Not IsDate(DataNascita) Then
                MsgBox("Inserire una data valida")
                Exit Sub
            End If

            If Aggiungi Then
                cmdAggiungi.Parameters.Add(New OleDb.OleDbParameter("Nome", Nome))
                cmdAggiungi.Parameters.Add(New OleDb.OleDbParameter("Cognome", Cognome))
                cmdAggiungi.Parameters.Add(New OleDb.OleDbParameter("DataNascita", DataNascita))
                cmdAggiungi.Parameters.Add(New OleDb.OleDbParameter("IDProvincia", IDProvincia))
                cmdAggiungi.Parameters.Add(New OleDb.OleDbParameter("IDSport", IDSport))
                cmdAggiungi.ExecuteNonQuery()
                cmdAggiungi.Parameters.Clear()
                m_currencymanager.Position = m_currencymanager.Count - 1
                Call VisualizzaPosizione()
            Else
                Pos = m_currencymanager.Position
                ID = CInt(dt.Rows(Pos).Item("IDStudente"))
                cmdSalva.Parameters.Add(New OleDb.OleDbParameter("Nome", Nome))
                cmdSalva.Parameters.Add(New OleDb.OleDbParameter("Cognome", Cognome))
                cmdSalva.Parameters.Add(New OleDb.OleDbParameter("DataNascita", DataNascita))
                cmdSalva.Parameters.Add(New OleDb.OleDbParameter("IDProvincia", IDProvincia))
                cmdSalva.Parameters.Add(New OleDb.OleDbParameter("IDSport", IDSport))
                cmdSalva.Parameters.Add(New OleDb.OleDbParameter("IDStudente", ID))
                cmdSalva.ExecuteNonQuery()
                cmdSalva.Parameters.Clear()
            End If
            Aggiungi = False
            Call Disabilitasalva()
            Call DisabilitaText()
            Call Abilitanavigatore()

            dt.Clear()
            DA.Fill(dt)


            Call VisualizzaPosizione()

        Catch x As InvalidCastException
            '    MsgBox("Il record appena inserito non è modificabile")
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


            ID = CInt((dt.Rows(Pos).Item("IDStudente")))

            cmdElimina.Parameters.Add(New OleDb.OleDbParameter("IDStudente", ID))
            cmdElimina.ExecuteNonQuery()
            cmdElimina.Parameters.Clear()
        End If

        dt.Clear()
        DA.Fill(dt)

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

        m_currencymanager = DirectCast(Me.BindingContext(dt), CurrencyManager)
        m_currencymanager.Position = 0
    End Sub
    Private Sub AssociaCampi()
        txtCognome.DataBindings.Add("text", dt, "Cognome")
        txtNome.DataBindings.Add("text", dt, "Nome")
        txtID.DataBindings.Add("text", dt, "IDStudente")
        txtDataNascita.DataBindings.Add("text", dt, "DataNascita")

        cmbProv.DataBindings.Add("SelectedValue", dt, "IDProvincia")
        cmbProv.DataSource = dtProvStud
        cmbProv.DisplayMember = "Sigla"
        cmbProv.ValueMember = "IDProvincia"

        cmbSport.DataBindings.Add("SelectedValue", dt, "IDSport")
        cmbSport.DataSource = dtSportStud
        cmbSport.DisplayMember = "Sport"
        cmbSport.ValueMember = "IDSport"

    End Sub
    Private Sub DisabilitaText()
        txtCognome.Enabled = False
        txtNome.Enabled = False
        txtDataNascita.Enabled = False
        cmbSport.Enabled = False
        cmbProv.Enabled = False

    End Sub
    Private Sub AbilitaText()
        txtCognome.Enabled = True
        txtNome.Enabled = True
        txtDataNascita.Enabled = True
        cmbSport.Enabled = True
        cmbProv.Enabled = True
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
