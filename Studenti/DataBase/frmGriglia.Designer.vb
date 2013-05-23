<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGriglia
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
        Me.grdSport = New System.Windows.Forms.DataGridView
        Me.btnAggiorna = New System.Windows.Forms.Button
        CType(Me.grdSport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdSport
        '
        Me.grdSport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdSport.Location = New System.Drawing.Point(40, 47)
        Me.grdSport.Name = "grdSport"
        Me.grdSport.Size = New System.Drawing.Size(573, 341)
        Me.grdSport.TabIndex = 0
        '
        'btnAggiorna
        '
        Me.btnAggiorna.Location = New System.Drawing.Point(95, 431)
        Me.btnAggiorna.Name = "btnAggiorna"
        Me.btnAggiorna.Size = New System.Drawing.Size(151, 55)
        Me.btnAggiorna.TabIndex = 1
        Me.btnAggiorna.Text = "Aggiorna"
        Me.btnAggiorna.UseVisualStyleBackColor = True
        '
        'frmGriglia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(665, 599)
        Me.Controls.Add(Me.btnAggiorna)
        Me.Controls.Add(Me.grdSport)
        Me.Name = "frmGriglia"
        Me.Text = "frmGriglia"
        CType(Me.grdSport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdSport As System.Windows.Forms.DataGridView
    Friend WithEvents btnAggiorna As System.Windows.Forms.Button
End Class
