<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGen
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
        Me.lstTemp1 = New System.Windows.Forms.ListBox
        Me.lstTemp2 = New System.Windows.Forms.ListBox
        Me.lstNome = New System.Windows.Forms.ListBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lstTempTot = New System.Windows.Forms.ListBox
        Me.lblTempTot = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lstTemp1
        '
        Me.lstTemp1.FormattingEnabled = True
        Me.lstTemp1.Location = New System.Drawing.Point(106, 48)
        Me.lstTemp1.Name = "lstTemp1"
        Me.lstTemp1.Size = New System.Drawing.Size(69, 95)
        Me.lstTemp1.TabIndex = 6
        '
        'lstTemp2
        '
        Me.lstTemp2.FormattingEnabled = True
        Me.lstTemp2.Location = New System.Drawing.Point(189, 48)
        Me.lstTemp2.Name = "lstTemp2"
        Me.lstTemp2.Size = New System.Drawing.Size(69, 95)
        Me.lstTemp2.TabIndex = 5
        '
        'lstNome
        '
        Me.lstNome.FormattingEnabled = True
        Me.lstNome.Location = New System.Drawing.Point(23, 48)
        Me.lstNome.Name = "lstNome"
        Me.lstNome.Size = New System.Drawing.Size(69, 95)
        Me.lstNome.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tempo 1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(186, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Tempo 2"
        '
        'lstTempTot
        '
        Me.lstTempTot.FormattingEnabled = True
        Me.lstTempTot.Location = New System.Drawing.Point(275, 48)
        Me.lstTempTot.Name = "lstTempTot"
        Me.lstTempTot.Size = New System.Drawing.Size(100, 95)
        Me.lstTempTot.TabIndex = 10
        '
        'lblTempTot
        '
        Me.lblTempTot.AutoSize = True
        Me.lblTempTot.Location = New System.Drawing.Point(272, 22)
        Me.lblTempTot.Name = "lblTempTot"
        Me.lblTempTot.Size = New System.Drawing.Size(73, 13)
        Me.lblTempTot.TabIndex = 11
        Me.lblTempTot.Text = "Tempo Totale"
        '
        'frmGen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 180)
        Me.Controls.Add(Me.lblTempTot)
        Me.Controls.Add(Me.lstTempTot)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstTemp1)
        Me.Controls.Add(Me.lstTemp2)
        Me.Controls.Add(Me.lstNome)
        Me.Name = "frmGen"
        Me.Text = "Classifica generale"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstTemp1 As System.Windows.Forms.ListBox
    Friend WithEvents lstTemp2 As System.Windows.Forms.ListBox
    Friend WithEvents lstNome As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstTempTot As System.Windows.Forms.ListBox
    Friend WithEvents lblTempTot As System.Windows.Forms.Label
End Class
