<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Impostazioni
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grdGiocatori = New System.Windows.Forms.DataGridView()
        Me.Giocatore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDomande = New System.Windows.Forms.Button()
        Me.OpenFileDomande = New System.Windows.Forms.OpenFileDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblDomande = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTempo = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblImmagini = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnImmagini = New System.Windows.Forms.Button()
        Me.chkIntestazione = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.lnkAvanti = New System.Windows.Forms.LinkLabel()
        Me.OpenFileImmagini = New System.Windows.Forms.OpenFileDialog()
        CType(Me.grdGiocatori, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTempo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdGiocatori
        '
        Me.grdGiocatori.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdGiocatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdGiocatori.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Giocatore})
        Me.grdGiocatori.Location = New System.Drawing.Point(27, 26)
        Me.grdGiocatori.Name = "grdGiocatori"
        Me.grdGiocatori.Size = New System.Drawing.Size(384, 468)
        Me.grdGiocatori.TabIndex = 0
        '
        'Giocatore
        '
        Me.Giocatore.DataPropertyName = "Nome"
        Me.Giocatore.HeaderText = "Giocatore"
        Me.Giocatore.Name = "Giocatore"
        Me.Giocatore.Width = 300
        '
        'btnDomande
        '
        Me.btnDomande.Location = New System.Drawing.Point(15, 267)
        Me.btnDomande.Name = "btnDomande"
        Me.btnDomande.Size = New System.Drawing.Size(150, 37)
        Me.btnDomande.TabIndex = 1
        Me.btnDomande.Text = "Carica domande"
        Me.btnDomande.UseVisualStyleBackColor = True
        '
        'OpenFileDomande
        '
        Me.OpenFileDomande.FileName = "*.csv"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(191, 277)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Domande lette:"
        '
        'lblDomande
        '
        Me.lblDomande.AutoSize = True
        Me.lblDomande.Location = New System.Drawing.Point(328, 277)
        Me.lblDomande.Name = "lblDomande"
        Me.lblDomande.Size = New System.Drawing.Size(15, 17)
        Me.lblDomande.TabIndex = 3
        Me.lblDomande.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(450, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Tempo per risposta:"
        '
        'txtTempo
        '
        Me.txtTempo.Location = New System.Drawing.Point(590, 24)
        Me.txtTempo.Maximum = New Decimal(New Integer() {120, 0, 0, 0})
        Me.txtTempo.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.txtTempo.Name = "txtTempo"
        Me.txtTempo.Size = New System.Drawing.Size(48, 23)
        Me.txtTempo.TabIndex = 5
        Me.txtTempo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtTempo.Value = New Decimal(New Integer() {45, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(24, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Separatore colonne:"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(170, 62)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(41, 23)
        Me.TextBox1.TabIndex = 7
        Me.TextBox1.Text = ";"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblImmagini)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.btnImmagini)
        Me.GroupBox1.Controls.Add(Me.chkIntestazione)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.TextBox4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblDomande)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnDomande)
        Me.GroupBox1.Location = New System.Drawing.Point(438, 85)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 409)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Domande"
        '
        'lblImmagini
        '
        Me.lblImmagini.AutoSize = True
        Me.lblImmagini.Location = New System.Drawing.Point(325, 334)
        Me.lblImmagini.Name = "lblImmagini"
        Me.lblImmagini.Size = New System.Drawing.Size(15, 17)
        Me.lblImmagini.TabIndex = 20
        Me.lblImmagini.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(191, 334)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 17)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Immagini lette:"
        '
        'btnImmagini
        '
        Me.btnImmagini.Location = New System.Drawing.Point(15, 324)
        Me.btnImmagini.Name = "btnImmagini"
        Me.btnImmagini.Size = New System.Drawing.Size(150, 37)
        Me.btnImmagini.TabIndex = 18
        Me.btnImmagini.Text = "Carica immagini"
        Me.btnImmagini.UseVisualStyleBackColor = True
        '
        'chkIntestazione
        '
        Me.chkIntestazione.AutoSize = True
        Me.chkIntestazione.Checked = True
        Me.chkIntestazione.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIntestazione.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkIntestazione.Location = New System.Drawing.Point(328, 195)
        Me.chkIntestazione.Name = "chkIntestazione"
        Me.chkIntestazione.Size = New System.Drawing.Size(12, 11)
        Me.chkIntestazione.TabIndex = 17
        Me.chkIntestazione.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 192)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(190, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Intestazioni nella prima riga:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Colonna 2:"
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.White
        Me.TextBox5.Location = New System.Drawing.Point(171, 158)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(172, 23)
        Me.TextBox5.TabIndex = 15
        Me.TextBox5.Text = "Risposta giusta  (0 - 100)"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Colonna 2:"
        '
        'TextBox4
        '
        Me.TextBox4.BackColor = System.Drawing.Color.White
        Me.TextBox4.Location = New System.Drawing.Point(171, 126)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(148, 23)
        Me.TextBox4.TabIndex = 13
        Me.TextBox4.Text = "Testo domanda"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 97)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Colonna 1:"
        '
        'TextBox3
        '
        Me.TextBox3.BackColor = System.Drawing.Color.White
        Me.TextBox3.Location = New System.Drawing.Point(171, 94)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.ReadOnly = True
        Me.TextBox3.Size = New System.Drawing.Size(148, 23)
        Me.TextBox3.TabIndex = 11
        Me.TextBox3.Text = "Numero domanda"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Formato file:"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(170, 30)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(41, 23)
        Me.TextBox2.TabIndex = 9
        Me.TextBox2.Text = "csv"
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lnkAvanti
        '
        Me.lnkAvanti.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkAvanti.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkAvanti.Location = New System.Drawing.Point(693, 24)
        Me.lnkAvanti.Name = "lnkAvanti"
        Me.lnkAvanti.Size = New System.Drawing.Size(110, 30)
        Me.lnkAvanti.TabIndex = 9
        Me.lnkAvanti.TabStop = True
        Me.lnkAvanti.Text = "Avanti ->"
        '
        'OpenFileImmagini
        '
        Me.OpenFileImmagini.FileName = "*.png"
        Me.OpenFileImmagini.Multiselect = True
        '
        'Impostazioni
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(832, 530)
        Me.Controls.Add(Me.lnkAvanti)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtTempo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.grdGiocatori)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Impostazioni"
        Me.Text = "Impostazioni"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.grdGiocatori, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTempo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grdGiocatori As DataGridView
    Friend WithEvents btnDomande As Button
    Friend WithEvents OpenFileDomande As OpenFileDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents lblDomande As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtTempo As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents chkIntestazione As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lnkAvanti As LinkLabel
    Friend WithEvents Giocatore As DataGridViewTextBoxColumn
    Friend WithEvents btnImmagini As Button
    Friend WithEvents OpenFileImmagini As OpenFileDialog
    Friend WithEvents lblImmagini As Label
    Friend WithEvents Label9 As Label
End Class
