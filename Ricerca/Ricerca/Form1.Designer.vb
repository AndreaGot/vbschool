<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.grpRic = New System.Windows.Forms.GroupBox
        Me.lbl1 = New System.Windows.Forms.Label
        Me.lbl2 = New System.Windows.Forms.Label
        Me.lbl3 = New System.Windows.Forms.Label
        Me.txt3 = New System.Windows.Forms.TextBox
        Me.txt2 = New System.Windows.Forms.TextBox
        Me.txt1 = New System.Windows.Forms.TextBox
        Me.btn3 = New System.Windows.Forms.Button
        Me.btn2 = New System.Windows.Forms.Button
        Me.btn1 = New System.Windows.Forms.Button
        Me.lst3 = New System.Windows.Forms.ListBox
        Me.lst2 = New System.Windows.Forms.ListBox
        Me.lst1 = New System.Windows.Forms.ListBox
        Me.grpRic.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Fino a che numero?"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(176, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(149, 20)
        Me.TextBox1.TabIndex = 13
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(339, 29)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(60, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grpRic
        '
        Me.grpRic.Controls.Add(Me.lbl1)
        Me.grpRic.Controls.Add(Me.lbl2)
        Me.grpRic.Controls.Add(Me.lbl3)
        Me.grpRic.Controls.Add(Me.txt3)
        Me.grpRic.Controls.Add(Me.txt2)
        Me.grpRic.Controls.Add(Me.txt1)
        Me.grpRic.Controls.Add(Me.btn3)
        Me.grpRic.Controls.Add(Me.btn2)
        Me.grpRic.Controls.Add(Me.btn1)
        Me.grpRic.Controls.Add(Me.lst3)
        Me.grpRic.Controls.Add(Me.lst2)
        Me.grpRic.Controls.Add(Me.lst1)
        Me.grpRic.Enabled = False
        Me.grpRic.Location = New System.Drawing.Point(13, 64)
        Me.grpRic.Name = "grpRic"
        Me.grpRic.Size = New System.Drawing.Size(420, 326)
        Me.grpRic.TabIndex = 15
        Me.grpRic.TabStop = False
        Me.grpRic.Text = "Ricerca"
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Location = New System.Drawing.Point(6, 205)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(0, 13)
        Me.lbl1.TabIndex = 27
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(145, 205)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(0, 13)
        Me.lbl2.TabIndex = 26
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(286, 205)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(0, 13)
        Me.lbl3.TabIndex = 25
        '
        'txt3
        '
        Me.txt3.Location = New System.Drawing.Point(294, 149)
        Me.txt3.MaxLength = 5
        Me.txt3.Name = "txt3"
        Me.txt3.Size = New System.Drawing.Size(100, 20)
        Me.txt3.TabIndex = 14
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(150, 149)
        Me.txt2.MaxLength = 5
        Me.txt2.Name = "txt2"
        Me.txt2.Size = New System.Drawing.Size(100, 20)
        Me.txt2.TabIndex = 13
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(7, 149)
        Me.txt1.MaxLength = 5
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(100, 20)
        Me.txt1.TabIndex = 12
        '
        'btn3
        '
        Me.btn3.Location = New System.Drawing.Point(294, 175)
        Me.btn3.Name = "btn3"
        Me.btn3.Size = New System.Drawing.Size(75, 23)
        Me.btn3.TabIndex = 17
        Me.btn3.Text = "Ricerca 3"
        Me.btn3.UseVisualStyleBackColor = True
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(150, 175)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(75, 23)
        Me.btn2.TabIndex = 16
        Me.btn2.Text = "Ricerca 2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(7, 175)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 15
        Me.btn1.Text = "Ricerca 1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'lst3
        '
        Me.lst3.FormattingEnabled = True
        Me.lst3.Location = New System.Drawing.Point(294, 29)
        Me.lst3.Name = "lst3"
        Me.lst3.Size = New System.Drawing.Size(120, 95)
        Me.lst3.TabIndex = 20
        '
        'lst2
        '
        Me.lst2.FormattingEnabled = True
        Me.lst2.Location = New System.Drawing.Point(150, 29)
        Me.lst2.Name = "lst2"
        Me.lst2.Size = New System.Drawing.Size(120, 95)
        Me.lst2.TabIndex = 19
        '
        'lst1
        '
        Me.lst1.FormattingEnabled = True
        Me.lst1.Location = New System.Drawing.Point(7, 29)
        Me.lst1.Name = "lst1"
        Me.lst1.Size = New System.Drawing.Size(120, 95)
        Me.lst1.TabIndex = 18
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(442, 402)
        Me.Controls.Add(Me.grpRic)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Ricerca dicotomica di un numero"
        Me.grpRic.ResumeLayout(False)
        Me.grpRic.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents grpRic As System.Windows.Forms.GroupBox
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents txt3 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents btn3 As System.Windows.Forms.Button
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents lst3 As System.Windows.Forms.ListBox
    Friend WithEvents lst2 As System.Windows.Forms.ListBox
    Friend WithEvents lst1 As System.Windows.Forms.ListBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label

End Class
