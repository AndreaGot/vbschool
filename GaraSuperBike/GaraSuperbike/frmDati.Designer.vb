<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDati
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
        Me.txtNome = New System.Windows.Forms.TextBox
        Me.nudSec2 = New System.Windows.Forms.NumericUpDown
        Me.nudMin2 = New System.Windows.Forms.NumericUpDown
        Me.nudCent2 = New System.Windows.Forms.NumericUpDown
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lstNome = New System.Windows.Forms.ListBox
        Me.lstTemp1 = New System.Windows.Forms.ListBox
        Me.lstTemp2 = New System.Windows.Forms.ListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.nudCent = New System.Windows.Forms.NumericUpDown
        Me.nudMin = New System.Windows.Forms.NumericUpDown
        Me.nudSec = New System.Windows.Forms.NumericUpDown
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnFine = New System.Windows.Forms.Button
        Me.lblDiciamolo = New System.Windows.Forms.Label
        Me.lstTempTot = New System.Windows.Forms.ListBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        CType(Me.nudSec2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMin2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCent2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudCent, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSec, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(153, 34)
        Me.txtNome.MaxLength = 50
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(128, 20)
        Me.txtNome.TabIndex = 0
        '
        'nudSec2
        '
        Me.nudSec2.Location = New System.Drawing.Point(203, 125)
        Me.nudSec2.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudSec2.Name = "nudSec2"
        Me.nudSec2.Size = New System.Drawing.Size(34, 20)
        Me.nudSec2.TabIndex = 5
        '
        'nudMin2
        '
        Me.nudMin2.Location = New System.Drawing.Point(153, 125)
        Me.nudMin2.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nudMin2.Name = "nudMin2"
        Me.nudMin2.Size = New System.Drawing.Size(35, 20)
        Me.nudMin2.TabIndex = 4
        '
        'nudCent2
        '
        Me.nudCent2.Location = New System.Drawing.Point(252, 125)
        Me.nudCent2.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudCent2.Name = "nudCent2"
        Me.nudCent2.Size = New System.Drawing.Size(34, 20)
        Me.nudCent2.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nome Pilota"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tempo 1 Manche"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Tempo 2 Manche"
        '
        'lstNome
        '
        Me.lstNome.FormattingEnabled = True
        Me.lstNome.Location = New System.Drawing.Point(12, 195)
        Me.lstNome.Name = "lstNome"
        Me.lstNome.Size = New System.Drawing.Size(85, 95)
        Me.lstNome.TabIndex = 10
        '
        'lstTemp1
        '
        Me.lstTemp1.FormattingEnabled = True
        Me.lstTemp1.Location = New System.Drawing.Point(109, 195)
        Me.lstTemp1.Name = "lstTemp1"
        Me.lstTemp1.Size = New System.Drawing.Size(91, 95)
        Me.lstTemp1.TabIndex = 11
        '
        'lstTemp2
        '
        Me.lstTemp2.FormattingEnabled = True
        Me.lstTemp2.Location = New System.Drawing.Point(212, 195)
        Me.lstTemp2.Name = "lstTemp2"
        Me.lstTemp2.Size = New System.Drawing.Size(92, 95)
        Me.lstTemp2.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(190, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = ":"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(239, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = ":"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(239, 81)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(10, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = ":"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(190, 82)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = ":"
        '
        'nudCent
        '
        Me.nudCent.Location = New System.Drawing.Point(252, 79)
        Me.nudCent.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.nudCent.Name = "nudCent"
        Me.nudCent.Size = New System.Drawing.Size(34, 20)
        Me.nudCent.TabIndex = 3
        '
        'nudMin
        '
        Me.nudMin.Location = New System.Drawing.Point(153, 79)
        Me.nudMin.Maximum = New Decimal(New Integer() {60, 0, 0, 0})
        Me.nudMin.Name = "nudMin"
        Me.nudMin.Size = New System.Drawing.Size(35, 20)
        Me.nudMin.TabIndex = 1
        '
        'nudSec
        '
        Me.nudSec.Location = New System.Drawing.Point(203, 79)
        Me.nudSec.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.nudSec.Name = "nudSec"
        Me.nudSec.Size = New System.Drawing.Size(34, 20)
        Me.nudSec.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(320, 67)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(100, 42)
        Me.btnAdd.TabIndex = 7
        Me.btnAdd.Text = "Aggiungi"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnFine
        '
        Me.btnFine.Enabled = False
        Me.btnFine.Location = New System.Drawing.Point(320, 322)
        Me.btnFine.Name = "btnFine"
        Me.btnFine.Size = New System.Drawing.Size(99, 43)
        Me.btnFine.TabIndex = 9
        Me.btnFine.Text = "Finito"
        Me.btnFine.UseVisualStyleBackColor = True
        '
        'lblDiciamolo
        '
        Me.lblDiciamolo.AutoSize = True
        Me.lblDiciamolo.Location = New System.Drawing.Point(46, 339)
        Me.lblDiciamolo.Name = "lblDiciamolo"
        Me.lblDiciamolo.Size = New System.Drawing.Size(0, 13)
        Me.lblDiciamolo.TabIndex = 22
        '
        'lstTempTot
        '
        Me.lstTempTot.FormattingEnabled = True
        Me.lstTempTot.Location = New System.Drawing.Point(320, 195)
        Me.lstTempTot.Name = "lstTempTot"
        Me.lstTempTot.Size = New System.Drawing.Size(100, 95)
        Me.lstTempTot.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 175)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Nome"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(106, 175)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 13)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Tempo 1"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(209, 175)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 26
        Me.Label10.Text = "Tempo 2"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(317, 175)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Totale"
        '
        'frmDati
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 377)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lstTempTot)
        Me.Controls.Add(Me.lblDiciamolo)
        Me.Controls.Add(Me.btnFine)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nudCent)
        Me.Controls.Add(Me.nudMin)
        Me.Controls.Add(Me.nudSec)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstTemp2)
        Me.Controls.Add(Me.lstTemp1)
        Me.Controls.Add(Me.lstNome)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.nudCent2)
        Me.Controls.Add(Me.nudMin2)
        Me.Controls.Add(Me.nudSec2)
        Me.Controls.Add(Me.txtNome)
        Me.Name = "frmDati"
        Me.Text = "Dati"
        CType(Me.nudSec2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMin2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCent2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudCent, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSec, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents nudSec2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudMin2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudCent2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lstNome As System.Windows.Forms.ListBox
    Friend WithEvents lstTemp1 As System.Windows.Forms.ListBox
    Friend WithEvents lstTemp2 As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents nudCent As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudSec As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnFine As System.Windows.Forms.Button
    Friend WithEvents lblDiciamolo As System.Windows.Forms.Label
    Friend WithEvents lstTempTot As System.Windows.Forms.ListBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
