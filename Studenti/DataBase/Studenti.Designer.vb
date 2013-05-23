<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Studenti
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Studenti))
        Me.txtNome = New System.Windows.Forms.TextBox
        Me.txtCognome = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnModifica = New System.Windows.Forms.Button
        Me.btnElimina = New System.Windows.Forms.Button
        Me.grpOper = New System.Windows.Forms.GroupBox
        Me.btnAnnulla = New System.Windows.Forms.Button
        Me.btnSalva = New System.Windows.Forms.Button
        Me.grpConferma = New System.Windows.Forms.GroupBox
        Me.btnPrima = New System.Windows.Forms.Button
        Me.btnDopo = New System.Windows.Forms.Button
        Me.btnUltimo = New System.Windows.Forms.Button
        Me.btnPrimo = New System.Windows.Forms.Button
        Me.btnFine = New System.Windows.Forms.Button
        Me.txtPosizione = New System.Windows.Forms.TextBox
        Me.txtID = New System.Windows.Forms.TextBox
        Me.txtDataNascita = New System.Windows.Forms.MaskedTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbSport = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbProv = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.grpOper.SuspendLayout()
        Me.grpConferma.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(211, 62)
        Me.txtNome.MaxLength = 20
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(100, 21)
        Me.txtNome.TabIndex = 0
        '
        'txtCognome
        '
        Me.txtCognome.Location = New System.Drawing.Point(211, 89)
        Me.txtCognome.MaxLength = 20
        Me.txtCognome.Name = "txtCognome"
        Me.txtCognome.Size = New System.Drawing.Size(100, 21)
        Me.txtCognome.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(154, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Nome"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cognome"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(109, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Data di Nascita"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Location = New System.Drawing.Point(102, 20)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Aggiungi"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnModifica
        '
        Me.btnModifica.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnModifica.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModifica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnModifica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnModifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModifica.Location = New System.Drawing.Point(183, 20)
        Me.btnModifica.Name = "btnModifica"
        Me.btnModifica.Size = New System.Drawing.Size(75, 23)
        Me.btnModifica.TabIndex = 10
        Me.btnModifica.Text = "Modifica"
        Me.btnModifica.UseVisualStyleBackColor = False
        '
        'btnElimina
        '
        Me.btnElimina.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnElimina.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnElimina.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnElimina.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnElimina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnElimina.Location = New System.Drawing.Point(21, 20)
        Me.btnElimina.Name = "btnElimina"
        Me.btnElimina.Size = New System.Drawing.Size(75, 23)
        Me.btnElimina.TabIndex = 11
        Me.btnElimina.Text = "Elimina"
        Me.btnElimina.UseVisualStyleBackColor = False
        '
        'grpOper
        '
        Me.grpOper.Controls.Add(Me.btnElimina)
        Me.grpOper.Controls.Add(Me.btnModifica)
        Me.grpOper.Controls.Add(Me.btnAdd)
        Me.grpOper.Location = New System.Drawing.Point(225, 290)
        Me.grpOper.Name = "grpOper"
        Me.grpOper.Size = New System.Drawing.Size(275, 56)
        Me.grpOper.TabIndex = 4
        Me.grpOper.TabStop = False
        Me.grpOper.Text = "Operazioni"
        '
        'btnAnnulla
        '
        Me.btnAnnulla.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAnnulla.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAnnulla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAnnulla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAnnulla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAnnulla.Location = New System.Drawing.Point(22, 20)
        Me.btnAnnulla.Name = "btnAnnulla"
        Me.btnAnnulla.Size = New System.Drawing.Size(75, 23)
        Me.btnAnnulla.TabIndex = 0
        Me.btnAnnulla.Text = "Annulla"
        Me.btnAnnulla.UseVisualStyleBackColor = False
        '
        'btnSalva
        '
        Me.btnSalva.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnSalva.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalva.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalva.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSalva.Location = New System.Drawing.Point(103, 20)
        Me.btnSalva.Name = "btnSalva"
        Me.btnSalva.Size = New System.Drawing.Size(75, 23)
        Me.btnSalva.TabIndex = 1
        Me.btnSalva.Text = "Salva"
        Me.btnSalva.UseVisualStyleBackColor = False
        '
        'grpConferma
        '
        Me.grpConferma.Controls.Add(Me.btnSalva)
        Me.grpConferma.Controls.Add(Me.btnAnnulla)
        Me.grpConferma.Enabled = False
        Me.grpConferma.Location = New System.Drawing.Point(22, 290)
        Me.grpConferma.Name = "grpConferma"
        Me.grpConferma.Size = New System.Drawing.Size(197, 56)
        Me.grpConferma.TabIndex = 3
        Me.grpConferma.TabStop = False
        Me.grpConferma.Text = "Conferma"
        '
        'btnPrima
        '
        Me.btnPrima.Enabled = False
        Me.btnPrima.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrima.Location = New System.Drawing.Point(172, 226)
        Me.btnPrima.Name = "btnPrima"
        Me.btnPrima.Size = New System.Drawing.Size(33, 23)
        Me.btnPrima.TabIndex = 6
        Me.btnPrima.Text = "<"
        Me.btnPrima.UseVisualStyleBackColor = True
        '
        'btnDopo
        '
        Me.btnDopo.Enabled = False
        Me.btnDopo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDopo.Location = New System.Drawing.Point(317, 226)
        Me.btnDopo.Name = "btnDopo"
        Me.btnDopo.Size = New System.Drawing.Size(33, 23)
        Me.btnDopo.TabIndex = 7
        Me.btnDopo.Text = ">"
        Me.btnDopo.UseVisualStyleBackColor = True
        '
        'btnUltimo
        '
        Me.btnUltimo.Enabled = False
        Me.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnUltimo.Location = New System.Drawing.Point(356, 226)
        Me.btnUltimo.Name = "btnUltimo"
        Me.btnUltimo.Size = New System.Drawing.Size(33, 23)
        Me.btnUltimo.TabIndex = 9
        Me.btnUltimo.Text = ">>"
        Me.btnUltimo.UseVisualStyleBackColor = True
        '
        'btnPrimo
        '
        Me.btnPrimo.Enabled = False
        Me.btnPrimo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPrimo.Location = New System.Drawing.Point(134, 226)
        Me.btnPrimo.Name = "btnPrimo"
        Me.btnPrimo.Size = New System.Drawing.Size(33, 23)
        Me.btnPrimo.TabIndex = 8
        Me.btnPrimo.Text = "<<"
        Me.btnPrimo.UseVisualStyleBackColor = True
        '
        'btnFine
        '
        Me.btnFine.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnFine.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnFine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnFine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnFine.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFine.Location = New System.Drawing.Point(246, 352)
        Me.btnFine.Name = "btnFine"
        Me.btnFine.Size = New System.Drawing.Size(75, 23)
        Me.btnFine.TabIndex = 5
        Me.btnFine.Text = "Fine"
        Me.btnFine.UseVisualStyleBackColor = False
        '
        'txtPosizione
        '
        Me.txtPosizione.Enabled = False
        Me.txtPosizione.Location = New System.Drawing.Point(211, 226)
        Me.txtPosizione.Name = "txtPosizione"
        Me.txtPosizione.Size = New System.Drawing.Size(100, 21)
        Me.txtPosizione.TabIndex = 20
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(211, 12)
        Me.txtID.MaxLength = 20
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(100, 21)
        Me.txtID.TabIndex = 21
        '
        'txtDataNascita
        '
        Me.txtDataNascita.Location = New System.Drawing.Point(211, 116)
        Me.txtDataNascita.Mask = "00/00/0000"
        Me.txtDataNascita.Name = "txtDataNascita"
        Me.txtDataNascita.Size = New System.Drawing.Size(100, 21)
        Me.txtDataNascita.TabIndex = 2
        Me.txtDataNascita.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-99, 250)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(709, 13)
        Me.Label4.TabIndex = 22
        Me.Label4.Text = "_________________________________________________________________________________" & _
            "____________________________________"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-99, 263)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(709, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "_________________________________________________________________________________" & _
            "____________________________________"
        '
        'cmbSport
        '
        Me.cmbSport.Enabled = False
        Me.cmbSport.FormattingEnabled = True
        Me.cmbSport.Location = New System.Drawing.Point(211, 170)
        Me.cmbSport.Name = "cmbSport"
        Me.cmbSport.Size = New System.Drawing.Size(100, 21)
        Me.cmbSport.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(110, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Sport Preferito"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbProv
        '
        Me.cmbProv.Enabled = False
        Me.cmbProv.FormattingEnabled = True
        Me.cmbProv.Location = New System.Drawing.Point(211, 143)
        Me.cmbProv.Name = "cmbProv"
        Me.cmbProv.Size = New System.Drawing.Size(100, 21)
        Me.cmbProv.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(138, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Provincia"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Studenti
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(523, 395)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbProv)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbSport)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDataNascita)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.txtPosizione)
        Me.Controls.Add(Me.btnFine)
        Me.Controls.Add(Me.btnPrimo)
        Me.Controls.Add(Me.btnUltimo)
        Me.Controls.Add(Me.btnDopo)
        Me.Controls.Add(Me.btnPrima)
        Me.Controls.Add(Me.grpConferma)
        Me.Controls.Add(Me.grpOper)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCognome)
        Me.Controls.Add(Me.txtNome)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Studenti"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataBase"
        Me.grpOper.ResumeLayout(False)
        Me.grpConferma.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtCognome As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnModifica As System.Windows.Forms.Button
    Friend WithEvents btnElimina As System.Windows.Forms.Button
    Friend WithEvents grpOper As System.Windows.Forms.GroupBox
    Friend WithEvents btnAnnulla As System.Windows.Forms.Button
    Friend WithEvents btnSalva As System.Windows.Forms.Button
    Friend WithEvents grpConferma As System.Windows.Forms.GroupBox
    Friend WithEvents btnPrima As System.Windows.Forms.Button
    Friend WithEvents btnDopo As System.Windows.Forms.Button
    Friend WithEvents btnUltimo As System.Windows.Forms.Button
    Friend WithEvents btnPrimo As System.Windows.Forms.Button
    Friend WithEvents btnFine As System.Windows.Forms.Button
    Friend WithEvents txtPosizione As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtDataNascita As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbSport As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbProv As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label

End Class
