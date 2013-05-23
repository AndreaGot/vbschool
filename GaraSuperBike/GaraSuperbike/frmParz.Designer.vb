<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmParz
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
        Me.lstNome = New System.Windows.Forms.ListBox
        Me.lstTemp2 = New System.Windows.Forms.ListBox
        Me.lstTemp1 = New System.Windows.Forms.ListBox
        Me.btnCalcola = New System.Windows.Forms.Button
        Me.lstScelta = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'lstNome
        '
        Me.lstNome.FormattingEnabled = True
        Me.lstNome.Location = New System.Drawing.Point(25, 116)
        Me.lstNome.Name = "lstNome"
        Me.lstNome.Size = New System.Drawing.Size(90, 160)
        Me.lstNome.TabIndex = 1
        '
        'lstTemp2
        '
        Me.lstTemp2.FormattingEnabled = True
        Me.lstTemp2.Location = New System.Drawing.Point(239, 116)
        Me.lstTemp2.Name = "lstTemp2"
        Me.lstTemp2.Size = New System.Drawing.Size(88, 160)
        Me.lstTemp2.TabIndex = 2
        '
        'lstTemp1
        '
        Me.lstTemp1.FormattingEnabled = True
        Me.lstTemp1.Location = New System.Drawing.Point(129, 116)
        Me.lstTemp1.Name = "lstTemp1"
        Me.lstTemp1.Size = New System.Drawing.Size(95, 160)
        Me.lstTemp1.TabIndex = 3
        '
        'btnCalcola
        '
        Me.btnCalcola.Location = New System.Drawing.Point(25, 67)
        Me.btnCalcola.Name = "btnCalcola"
        Me.btnCalcola.Size = New System.Drawing.Size(90, 25)
        Me.btnCalcola.TabIndex = 4
        Me.btnCalcola.Text = "Mostra "
        Me.btnCalcola.UseVisualStyleBackColor = True
        '
        'lstScelta
        '
        Me.lstScelta.FormattingEnabled = True
        Me.lstScelta.Items.AddRange(New Object() {"Classifica della Prima Manche", "Classifica della Seconda Manche"})
        Me.lstScelta.Location = New System.Drawing.Point(25, 28)
        Me.lstScelta.Name = "lstScelta"
        Me.lstScelta.ScrollAlwaysVisible = True
        Me.lstScelta.Size = New System.Drawing.Size(176, 17)
        Me.lstScelta.TabIndex = 5
        '
        'frmParz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 324)
        Me.Controls.Add(Me.lstScelta)
        Me.Controls.Add(Me.btnCalcola)
        Me.Controls.Add(Me.lstTemp1)
        Me.Controls.Add(Me.lstTemp2)
        Me.Controls.Add(Me.lstNome)
        Me.Name = "frmParz"
        Me.Text = "Classifica parziale"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstNome As System.Windows.Forms.ListBox
    Friend WithEvents lstTemp2 As System.Windows.Forms.ListBox
    Friend WithEvents lstTemp1 As System.Windows.Forms.ListBox
    Friend WithEvents btnCalcola As System.Windows.Forms.Button
    Friend WithEvents lstScelta As System.Windows.Forms.ListBox
End Class
