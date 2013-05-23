<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScadAdCom
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
        Me.DatiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuIns = New System.Windows.Forms.ToolStripMenuItem
        Me.CalcolaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuScadAd = New System.Windows.Forms.ToolStripMenuItem
        Me.mnuScadCom = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DatiToolStripMenuItem, Me.CalcolaToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(292, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DatiToolStripMenuItem
        '
        Me.DatiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuIns})
        Me.DatiToolStripMenuItem.Name = "DatiToolStripMenuItem"
        Me.DatiToolStripMenuItem.Size = New System.Drawing.Size(38, 20)
        Me.DatiToolStripMenuItem.Text = "Dati"
        '
        'mnuIns
        '
        Me.mnuIns.Name = "mnuIns"
        Me.mnuIns.Size = New System.Drawing.Size(152, 22)
        Me.mnuIns.Text = "Inserisci"
        '
        'CalcolaToolStripMenuItem
        '
        Me.CalcolaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuScadAd, Me.mnuScadCom})
        Me.CalcolaToolStripMenuItem.Enabled = False
        Me.CalcolaToolStripMenuItem.Name = "CalcolaToolStripMenuItem"
        Me.CalcolaToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.CalcolaToolStripMenuItem.Text = "Calcola"
        '
        'mnuScadAd
        '
        Me.mnuScadAd.Name = "mnuScadAd"
        Me.mnuScadAd.Size = New System.Drawing.Size(181, 22)
        Me.mnuScadAd.Text = "Scadenza Adeguata"
        '
        'mnuScadCom
        '
        Me.mnuScadCom.Name = "mnuScadCom"
        Me.mnuScadCom.Size = New System.Drawing.Size(181, 22)
        Me.mnuScadCom.Text = "Scadenza Comune"
        '
        'frmScadAdCom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmScadAdCom"
        Me.Text = "Scadenza Adeguata e Comune"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DatiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuIns As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalcolaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuScadAd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuScadCom As System.Windows.Forms.ToolStripMenuItem

End Class
