<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEsci = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDatabase = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuStudenti = New System.Windows.Forms.ToolStripMenuItem
        Me.GestioneProvinceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuSport = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuGriglia = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuDatabase})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(292, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEsci})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(35, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuEsci
        '
        Me.mnuEsci.Name = "mnuEsci"
        Me.mnuEsci.Size = New System.Drawing.Size(103, 22)
        Me.mnuEsci.Text = "&Esci"
        '
        'mnuDatabase
        '
        Me.mnuDatabase.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStudenti, Me.GestioneProvinceToolStripMenuItem, Me.mnuSport, Me.mnuGriglia})
        Me.mnuDatabase.Name = "mnuDatabase"
        Me.mnuDatabase.Size = New System.Drawing.Size(65, 20)
        Me.mnuDatabase.Text = "&Database"
        '
        'mnuStudenti
        '
        Me.mnuStudenti.Name = "mnuStudenti"
        Me.mnuStudenti.Size = New System.Drawing.Size(171, 22)
        Me.mnuStudenti.Text = "&Gestione Studenti"
        '
        'GestioneProvinceToolStripMenuItem
        '
        Me.GestioneProvinceToolStripMenuItem.Name = "GestioneProvinceToolStripMenuItem"
        Me.GestioneProvinceToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.GestioneProvinceToolStripMenuItem.Text = "&Gestione Province"
        '
        'mnuSport
        '
        Me.mnuSport.Name = "mnuSport"
        Me.mnuSport.Size = New System.Drawing.Size(171, 22)
        Me.mnuSport.Text = "&Gestione Sport"
        '
        'mnuGriglia
        '
        Me.mnuGriglia.Name = "mnuGriglia"
        Me.mnuGriglia.Size = New System.Drawing.Size(171, 22)
        Me.mnuGriglia.Text = "Gestione Griglia"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Menu"
        Me.Text = "Menu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuDatabase As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuStudenti As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuSport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEsci As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GestioneProvinceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGriglia As System.Windows.Forms.ToolStripMenuItem
End Class
