<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCresc
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
        Me.txtNum = New System.Windows.Forms.TextBox
        Me.btnInsert = New System.Windows.Forms.Button
        Me.lstNum = New System.Windows.Forms.ListBox
        Me.grpInserimento = New System.Windows.Forms.GroupBox
        Me.btnSoStuf = New System.Windows.Forms.Button
        Me.grpScelta = New System.Windows.Forms.GroupBox
        Me.btnOk = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.rdbDecresc = New System.Windows.Forms.RadioButton
        Me.rdbCresc = New System.Windows.Forms.RadioButton
        Me.grpOrdinato = New System.Windows.Forms.GroupBox
        Me.lstOrdinata = New System.Windows.Forms.ListBox
        Me.grpInserimento.SuspendLayout()
        Me.grpScelta.SuspendLayout()
        Me.grpOrdinato.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(16, 36)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(100, 20)
        Me.txtNum.TabIndex = 0
        '
        'btnInsert
        '
        Me.btnInsert.Location = New System.Drawing.Point(187, 33)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(75, 23)
        Me.btnInsert.TabIndex = 3
        Me.btnInsert.Text = "Inserisci"
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'lstNum
        '
        Me.lstNum.FormattingEnabled = True
        Me.lstNum.Location = New System.Drawing.Point(28, 73)
        Me.lstNum.Name = "lstNum"
        Me.lstNum.Size = New System.Drawing.Size(144, 186)
        Me.lstNum.TabIndex = 4
        '
        'grpInserimento
        '
        Me.grpInserimento.Controls.Add(Me.btnSoStuf)
        Me.grpInserimento.Controls.Add(Me.lstNum)
        Me.grpInserimento.Controls.Add(Me.txtNum)
        Me.grpInserimento.Controls.Add(Me.btnInsert)
        Me.grpInserimento.Location = New System.Drawing.Point(29, 12)
        Me.grpInserimento.Name = "grpInserimento"
        Me.grpInserimento.Size = New System.Drawing.Size(270, 317)
        Me.grpInserimento.TabIndex = 5
        Me.grpInserimento.TabStop = False
        Me.grpInserimento.Text = "Inserimento"
        '
        'btnSoStuf
        '
        Me.btnSoStuf.Location = New System.Drawing.Point(177, 265)
        Me.btnSoStuf.Name = "btnSoStuf"
        Me.btnSoStuf.Size = New System.Drawing.Size(75, 35)
        Me.btnSoStuf.TabIndex = 5
        Me.btnSoStuf.Text = "Sono Stufo di Inserire"
        Me.btnSoStuf.UseVisualStyleBackColor = True
        '
        'grpScelta
        '
        Me.grpScelta.Controls.Add(Me.btnOk)
        Me.grpScelta.Controls.Add(Me.Label1)
        Me.grpScelta.Controls.Add(Me.rdbDecresc)
        Me.grpScelta.Controls.Add(Me.rdbCresc)
        Me.grpScelta.Enabled = False
        Me.grpScelta.Location = New System.Drawing.Point(305, 12)
        Me.grpScelta.Name = "grpScelta"
        Me.grpScelta.Size = New System.Drawing.Size(164, 143)
        Me.grpScelta.TabIndex = 6
        Me.grpScelta.TabStop = False
        Me.grpScelta.Text = "Scelta"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(99, 112)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(59, 25)
        Me.btnOk.TabIndex = 7
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ordina in modo:"
        '
        'rdbDecresc
        '
        Me.rdbDecresc.AutoSize = True
        Me.rdbDecresc.Location = New System.Drawing.Point(35, 85)
        Me.rdbDecresc.Name = "rdbDecresc"
        Me.rdbDecresc.Size = New System.Drawing.Size(86, 17)
        Me.rdbDecresc.TabIndex = 1
        Me.rdbDecresc.Text = "Decrescente"
        Me.rdbDecresc.UseVisualStyleBackColor = True
        '
        'rdbCresc
        '
        Me.rdbCresc.AutoSize = True
        Me.rdbCresc.Checked = True
        Me.rdbCresc.Location = New System.Drawing.Point(35, 60)
        Me.rdbCresc.Name = "rdbCresc"
        Me.rdbCresc.Size = New System.Drawing.Size(73, 17)
        Me.rdbCresc.TabIndex = 0
        Me.rdbCresc.TabStop = True
        Me.rdbCresc.Text = "Crescente"
        Me.rdbCresc.UseVisualStyleBackColor = True
        '
        'grpOrdinato
        '
        Me.grpOrdinato.Controls.Add(Me.lstOrdinata)
        Me.grpOrdinato.Enabled = False
        Me.grpOrdinato.Location = New System.Drawing.Point(305, 161)
        Me.grpOrdinato.Name = "grpOrdinato"
        Me.grpOrdinato.Size = New System.Drawing.Size(142, 211)
        Me.grpOrdinato.TabIndex = 7
        Me.grpOrdinato.TabStop = False
        Me.grpOrdinato.Text = "Lista Ordinata"
        '
        'lstOrdinata
        '
        Me.lstOrdinata.FormattingEnabled = True
        Me.lstOrdinata.Location = New System.Drawing.Point(23, 30)
        Me.lstOrdinata.Name = "lstOrdinata"
        Me.lstOrdinata.Size = New System.Drawing.Size(93, 160)
        Me.lstOrdinata.TabIndex = 5
        '
        'frmCresc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(483, 387)
        Me.Controls.Add(Me.grpOrdinato)
        Me.Controls.Add(Me.grpScelta)
        Me.Controls.Add(Me.grpInserimento)
        Me.Name = "frmCresc"
        Me.Text = "Form1"
        Me.grpInserimento.ResumeLayout(False)
        Me.grpInserimento.PerformLayout()
        Me.grpScelta.ResumeLayout(False)
        Me.grpScelta.PerformLayout()
        Me.grpOrdinato.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtNum As System.Windows.Forms.TextBox
    Friend WithEvents btnInsert As System.Windows.Forms.Button
    Friend WithEvents lstNum As System.Windows.Forms.ListBox
    Friend WithEvents grpInserimento As System.Windows.Forms.GroupBox
    Friend WithEvents btnSoStuf As System.Windows.Forms.Button
    Friend WithEvents grpScelta As System.Windows.Forms.GroupBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents rdbDecresc As System.Windows.Forms.RadioButton
    Friend WithEvents rdbCresc As System.Windows.Forms.RadioButton
    Friend WithEvents grpOrdinato As System.Windows.Forms.GroupBox
    Friend WithEvents lstOrdinata As System.Windows.Forms.ListBox

End Class
