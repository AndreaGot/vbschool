<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuiz
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rdbR4 = New System.Windows.Forms.RadioButton
        Me.rdbR3 = New System.Windows.Forms.RadioButton
        Me.rdbR2 = New System.Windows.Forms.RadioButton
        Me.rdbR1 = New System.Windows.Forms.RadioButton
        Me.lblDomanda = New System.Windows.Forms.Label
        Me.btnOk = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblSbaià = New System.Windows.Forms.Label
        Me.lblGiust = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblNumDomd = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbR4)
        Me.GroupBox1.Controls.Add(Me.rdbR3)
        Me.GroupBox1.Controls.Add(Me.rdbR2)
        Me.GroupBox1.Controls.Add(Me.rdbR1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(6, 170)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(378, 160)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Risposte"
        '
        'rdbR4
        '
        Me.rdbR4.AutoSize = True
        Me.rdbR4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbR4.ForeColor = System.Drawing.Color.Gainsboro
        Me.rdbR4.Location = New System.Drawing.Point(36, 132)
        Me.rdbR4.Name = "rdbR4"
        Me.rdbR4.Size = New System.Drawing.Size(14, 13)
        Me.rdbR4.TabIndex = 3
        Me.rdbR4.TabStop = True
        Me.rdbR4.UseVisualStyleBackColor = True
        '
        'rdbR3
        '
        Me.rdbR3.AutoSize = True
        Me.rdbR3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbR3.ForeColor = System.Drawing.Color.Gainsboro
        Me.rdbR3.Location = New System.Drawing.Point(36, 65)
        Me.rdbR3.Name = "rdbR3"
        Me.rdbR3.Size = New System.Drawing.Size(14, 13)
        Me.rdbR3.TabIndex = 2
        Me.rdbR3.TabStop = True
        Me.rdbR3.UseVisualStyleBackColor = True
        '
        'rdbR2
        '
        Me.rdbR2.AutoSize = True
        Me.rdbR2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbR2.ForeColor = System.Drawing.Color.Gainsboro
        Me.rdbR2.Location = New System.Drawing.Point(36, 100)
        Me.rdbR2.Name = "rdbR2"
        Me.rdbR2.Size = New System.Drawing.Size(14, 13)
        Me.rdbR2.TabIndex = 1
        Me.rdbR2.TabStop = True
        Me.rdbR2.UseVisualStyleBackColor = True
        '
        'rdbR1
        '
        Me.rdbR1.AutoSize = True
        Me.rdbR1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbR1.ForeColor = System.Drawing.Color.Gainsboro
        Me.rdbR1.Location = New System.Drawing.Point(36, 33)
        Me.rdbR1.Name = "rdbR1"
        Me.rdbR1.Size = New System.Drawing.Size(14, 13)
        Me.rdbR1.TabIndex = 0
        Me.rdbR1.TabStop = True
        Me.rdbR1.UseVisualStyleBackColor = True
        '
        'lblDomanda
        '
        Me.lblDomanda.AutoSize = True
        Me.lblDomanda.BackColor = System.Drawing.Color.Blue
        Me.lblDomanda.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomanda.ForeColor = System.Drawing.Color.Gainsboro
        Me.lblDomanda.Location = New System.Drawing.Point(11, 54)
        Me.lblDomanda.Name = "lblDomanda"
        Me.lblDomanda.Size = New System.Drawing.Size(28, 24)
        Me.lblDomanda.TabIndex = 1
        Me.lblDomanda.Text = "..."
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(171, 362)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(52, 30)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblSbaià)
        Me.GroupBox2.Controls.Add(Me.lblGiust)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.GroupBox2.Location = New System.Drawing.Point(28, 419)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(320, 93)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Punteggio"
        '
        'lblSbaià
        '
        Me.lblSbaià.AutoSize = True
        Me.lblSbaià.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSbaià.Location = New System.Drawing.Point(265, 52)
        Me.lblSbaià.Name = "lblSbaià"
        Me.lblSbaià.Size = New System.Drawing.Size(21, 24)
        Me.lblSbaià.TabIndex = 8
        Me.lblSbaià.Text = "0"
        '
        'lblGiust
        '
        Me.lblGiust.AutoSize = True
        Me.lblGiust.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGiust.Location = New System.Drawing.Point(265, 27)
        Me.lblGiust.Name = "lblGiust"
        Me.lblGiust.Size = New System.Drawing.Size(21, 24)
        Me.lblGiust.TabIndex = 7
        Me.lblGiust.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(189, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "N° Risposte Sbagliate:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(166, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "N° Risposte Esatte:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(175, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Sei alla domanda N°:"
        '
        'lblNumDomd
        '
        Me.lblNumDomd.AutoSize = True
        Me.lblNumDomd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumDomd.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.lblNumDomd.Location = New System.Drawing.Point(193, 9)
        Me.lblNumDomd.Name = "lblNumDomd"
        Me.lblNumDomd.Size = New System.Drawing.Size(19, 20)
        Me.lblNumDomd.TabIndex = 8
        Me.lblNumDomd.Text = "1"
        '
        'frmQuiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Blue
        Me.ClientSize = New System.Drawing.Size(506, 597)
        Me.Controls.Add(Me.lblNumDomd)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblDomanda)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmQuiz"
        Me.Text = "Quiz"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbR4 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbR3 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbR2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbR1 As System.Windows.Forms.RadioButton
    Friend WithEvents lblDomanda As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblSbaià As System.Windows.Forms.Label
    Friend WithEvents lblGiust As System.Windows.Forms.Label
    Friend WithEvents lblNumDomd As System.Windows.Forms.Label

End Class
