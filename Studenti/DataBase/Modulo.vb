Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms

Module Modulo
    Public Primavolta As Boolean

    Public Conn As OleDb.OleDbConnection

    Public DA As OleDb.OleDbDataAdapter
    Public dt As New DataTable
    Public DASport As New OleDb.OleDbDataAdapter
    Public dtSport As New DataTable
    Public DASportStud As New OleDb.OleDbDataAdapter
    Public dtSportStud As New DataTable
    Public DAProv As New OleDb.OleDbDataAdapter
    Public dtProv As New DataTable
    Public DAProvStud As New OleDb.OleDbDataAdapter
    Public dtProvStud As New DataTable
    Public DaDs As New OleDb.OleDbDataAdapter
    Public ds As DataSet
    Public bs As BindingSource

    Public cmdLeggi As New OleDb.OleDbCommand
    Public cmdAggiungi As New OleDb.OleDbCommand
    Public cmdElimina As New OleDb.OleDbCommand
    Public cmdSalva As New OleDb.OleDbCommand
    Public cmdLeggiSportStud As New OleDb.OleDbCommand
    Public cmdLeggiProvStud As New OleDb.OleDbCommand

    Public cmdLeggiSport As New OleDb.OleDbCommand
    Public cmdAggiungiSport As New OleDb.OleDbCommand
    Public cmdEliminaSport As New OleDb.OleDbCommand
    Public cmdSalvaSport As New OleDb.OleDbCommand

    Public cmdLeggiProv As New OleDb.OleDbCommand
    Public cmdAggiungiProv As New OleDb.OleDbCommand
    Public cmdEliminaProv As New OleDb.OleDbCommand
    Public cmdSalvaProv As New OleDb.OleDbCommand

    Public cmdLeggids As New OleDb.OleDbCommand






    Public Sub ApriConn()
        Conn = New OleDb.OleDbConnection
        Conn.ConnectionString = "Provider = Microsoft.Jet.OleDb.4.0;Data Source = DBScuola.mdb"
        Conn.Open()
    End Sub

    Public Sub StudentiDaDt()
        Call ImpostaComandi()

        DA = New OleDb.OleDbDataAdapter(cmdLeggi)
        DA.Fill(dt)

        DAProvStud = New OleDbDataAdapter(cmdLeggiProvStud)
        DAProvStud.Fill(dtProvStud)

        DASportStud = New OleDbDataAdapter(cmdLeggiSportStud)
        DASportStud.Fill(dtSportStud)



    End Sub

    Public Sub SportDaDt()
        Call ImpostaComandiSport()

        DASport = New OleDb.OleDbDataAdapter(cmdLeggiSport)
        DASport.Fill(dtSport)
    End Sub

    Public Sub ProvDaDt()
        Call ImpostaComandiProv()

        DAProv = New OleDb.OleDbDataAdapter(cmdLeggiProv)
        DAProv.Fill(dtProv)
    End Sub


    Public Sub ChiudiConnSport()

        dtSport.Clear()
        DASport.Dispose()
        dtSport.Dispose()

        Conn.Close()
        Conn.Dispose()
    End Sub

    Public Sub ChiudiConnProv()

        dtProv.Clear()
        DAProv.Dispose()
        dtProv.Dispose()

        Conn.Close()
        Conn.Dispose()
    End Sub

    Public Sub ChiudiConn()

        dt.Clear()
        DA.Dispose()
        dt.Dispose()

        dtProvStud.Clear()
        DAProvStud.Dispose()
        dtProvStud.Dispose()

        dtSportStud.Clear()
        DASportStud.Dispose()
        dtSportStud.Dispose()


        Conn.Close()
        Conn.Dispose()
    End Sub

    Private Sub ImpostaComandi()
        cmdLeggi.Connection = Conn
        cmdLeggi.CommandType = CommandType.Text
        cmdLeggi.CommandText = "SELECT * FROM Studenti"

        cmdAggiungi.Connection = Conn
        cmdAggiungi.CommandType = CommandType.Text
        cmdAggiungi.CommandText = "INSERT INTO Studenti (Nome,Cognome,DataNascita,IDProvincia,IDSport) VALUES (?,?,?,?,?)"

        cmdElimina.Connection = Conn
        cmdElimina.CommandType = CommandType.Text
        cmdElimina.CommandText = "DELETE FROM Studenti WHERE IDStudente=?"

        cmdSalva.Connection = Conn
        cmdSalva.CommandType = CommandType.Text
        cmdSalva.CommandText = "UPDATE Studenti SET Nome=?, Cognome=?, DataNascita=?, IDProvincia=?, IDSport=?  WHERE IDStudente=?"

        cmdLeggiSportStud.Connection = Conn
        cmdLeggiSportStud.CommandType = CommandType.Text
        cmdLeggiSportStud.CommandText = "SELECT * FROM SportPreferito"

        cmdLeggiProvStud.Connection = Conn
        cmdLeggiProvStud.CommandType = CommandType.Text
        cmdLeggiProvStud.CommandText = "SELECT * FROM Province"


    End Sub

    Private Sub ImpostaComandiSport()
        cmdLeggiSport.Connection = Conn
        cmdLeggiSport.CommandType = CommandType.Text
        cmdLeggiSport.CommandText = "SELECT * FROM SportPreferito"

        cmdAggiungiSport.Connection = Conn
        cmdAggiungiSport.CommandType = CommandType.Text
        cmdAggiungiSport.CommandText = "INSERT INTO SportPreferito (Sport,Descrizione) VALUES (?,?)"

        cmdEliminaSport.Connection = Conn
        cmdEliminaSport.CommandType = CommandType.Text
        cmdEliminaSport.CommandText = "DELETE FROM SportPreferito WHERE IDSport=?"

        cmdSalvaSport.Connection = Conn
        cmdSalvaSport.CommandType = CommandType.Text
        cmdSalvaSport.CommandText = "UPDATE SportPreferito SET Sport=?, Descrizione=? WHERE IDSport=?"

    End Sub

    Private Sub ImpostaComandiProv()
        cmdLeggiProv.Connection = Conn
        cmdLeggiProv.CommandType = CommandType.Text
        cmdLeggiProv.CommandText = "SELECT * FROM Province"

        cmdAggiungiProv.Connection = Conn
        cmdAggiungiProv.CommandType = CommandType.Text
        cmdAggiungiProv.CommandText = "INSERT INTO Province (Nome,Sigla) VALUES (?,?)"

        cmdEliminaProv.Connection = Conn
        cmdEliminaProv.CommandType = CommandType.Text
        cmdEliminaProv.CommandText = "DELETE FROM Province WHERE IDProvincia=?"

        cmdSalvaProv.Connection = Conn
        cmdSalvaProv.CommandType = CommandType.Text
        cmdSalvaProv.CommandText = "UPDATE Province SET Nome=?, Sigla=? WHERE IDProvincia=?"
    End Sub

    Public Sub ImpostaDs()
        ds = New DataSet("SportGrid1")
        Call ImpostaComandiDs()

        DaDs = New OleDbDataAdapter(cmdLeggids)

        DaDs.Fill(ds, "SportGrid2")

        bs = New BindingSource
        bs.DataSource = ds
        bs.DataMember = "SportGrid2"

    End Sub

    Public Sub ImpostaComandiDs()

        cmdLeggids.Connection = Conn
        cmdLeggids.CommandType = CommandType.TableDirect
        cmdLeggids.CommandText = "SportPreferito"
    End Sub


End Module
