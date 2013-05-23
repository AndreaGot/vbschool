<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupBik
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
        Me.mnuIns = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuDati = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuClass = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuParz = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuGen = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuEsci = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuIns, Me.mnuClass, Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(292, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuIns
        '
        Me.mnuIns.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuDati, Me.mnuEsci})
        Me.mnuIns.Name = "mnuIns"
        Me.mnuIns.Size = New System.Drawing.Size(79, 20)
        Me.mnuIns.Text = "Inserimento "
        '
        'mnuDati
        '
        Me.mnuDati.Name = "mnuDati"
        Me.mnuDati.Size = New System.Drawing.Size(152, 22)
        Me.mnuDati.Text = "Dati"
        '
        'mnuClass
        '
        Me.mnuClass.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuParz, Me.mnuGen})
        Me.mnuClass.Name = "mnuClass"
        Me.mnuClass.Size = New System.Drawing.Size(69, 20)
        Me.mnuClass.Text = "Classifiche"
        '
        'mnuParz
        '
        Me.mnuParz.Name = "mnuParz"
        Me.mnuParz.Size = New System.Drawing.Size(124, 22)
        Me.mnuParz.Text = "Parziali"
        '
        'mnuGen
        '
        Me.mnuGen.Name = "mnuGen"
        Me.mnuGen.Size = New System.Drawing.Size(124, 22)
        Me.mnuGen.Text = "Generali"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(24, 20)
        Me.ToolStripMenuItem1.Text = "?"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.AboutToolStripMenuItem.Text = "About.."
        '
        'mnuEsci
        '
        Me.mnuEsci.Name = "mnuEsci"
        Me.mnuEsci.Size = New System.Drawing.Size(152, 22)
        Me.mnuEsci.Text = "Esci"
        '
        'frmSupBik
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSupBik"
        Me.Text = "Gara di SuperBike"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuIns As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDati As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuClass As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuParz As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuGen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEsci As System.Windows.Forms.ToolStripMenuItem

End Class
