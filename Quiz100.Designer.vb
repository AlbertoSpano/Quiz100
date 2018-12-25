<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Quiz100
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lnkImmagine = New System.Windows.Forms.LinkLabel()
        Me.btnClassifica = New System.Windows.Forms.Button()
        Me.lblTempo = New System.Windows.Forms.Label()
        Me.lblRisposta = New System.Windows.Forms.Label()
        Me.btnRisposta = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblNum = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pgBar = New System.Windows.Forms.ProgressBar()
        Me.btnSucc = New System.Windows.Forms.Button()
        Me.btnPrec = New System.Windows.Forms.Button()
        Me.lblDomanda = New System.Windows.Forms.Label()
        Me.grdGiocatori = New System.Windows.Forms.DataGridView()
        Me.Giocatore = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Risposta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.grdGiocatori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lnkImmagine)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnClassifica)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblTempo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblRisposta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnRisposta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnStop)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnStart)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblNum)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblDomanda)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grdGiocatori)
        Me.SplitContainer1.Size = New System.Drawing.Size(1025, 504)
        Me.SplitContainer1.SplitterDistance = 700
        Me.SplitContainer1.TabIndex = 1
        '
        'lnkImmagine
        '
        Me.lnkImmagine.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkImmagine.AutoSize = True
        Me.lnkImmagine.Location = New System.Drawing.Point(619, 294)
        Me.lnkImmagine.Name = "lnkImmagine"
        Me.lnkImmagine.Size = New System.Drawing.Size(74, 17)
        Me.lnkImmagine.TabIndex = 9
        Me.lnkImmagine.TabStop = True
        Me.lnkImmagine.Text = "Immagine"
        '
        'btnClassifica
        '
        Me.btnClassifica.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnClassifica.Location = New System.Drawing.Point(12, 373)
        Me.btnClassifica.Name = "btnClassifica"
        Me.btnClassifica.Size = New System.Drawing.Size(163, 35)
        Me.btnClassifica.TabIndex = 8
        Me.btnClassifica.Text = "Mostra classifica"
        Me.btnClassifica.UseVisualStyleBackColor = True
        '
        'lblTempo
        '
        Me.lblTempo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTempo.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTempo.Location = New System.Drawing.Point(197, 414)
        Me.lblTempo.Name = "lblTempo"
        Me.lblTempo.Size = New System.Drawing.Size(265, 35)
        Me.lblTempo.TabIndex = 7
        Me.lblTempo.Text = "-"
        Me.lblTempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblRisposta
        '
        Me.lblRisposta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblRisposta.AutoSize = True
        Me.lblRisposta.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRisposta.ForeColor = System.Drawing.Color.Red
        Me.lblRisposta.Location = New System.Drawing.Point(27, 314)
        Me.lblRisposta.Name = "lblRisposta"
        Me.lblRisposta.Size = New System.Drawing.Size(26, 32)
        Me.lblRisposta.TabIndex = 6
        Me.lblRisposta.Text = "-"
        '
        'btnRisposta
        '
        Me.btnRisposta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnRisposta.Enabled = False
        Me.btnRisposta.Location = New System.Drawing.Point(12, 414)
        Me.btnRisposta.Name = "btnRisposta"
        Me.btnRisposta.Size = New System.Drawing.Size(163, 35)
        Me.btnRisposta.TabIndex = 5
        Me.btnRisposta.Text = "Mostra risposta esatta"
        Me.btnRisposta.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStop.Enabled = False
        Me.btnStop.Location = New System.Drawing.Point(468, 392)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(107, 57)
        Me.btnStop.TabIndex = 4
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnStart.Location = New System.Drawing.Point(588, 392)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(107, 57)
        Me.btnStart.TabIndex = 3
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblNum
        '
        Me.lblNum.AutoSize = True
        Me.lblNum.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNum.Location = New System.Drawing.Point(25, 24)
        Me.lblNum.Name = "lblNum"
        Me.lblNum.Size = New System.Drawing.Size(30, 32)
        Me.lblNum.TabIndex = 2
        Me.lblNum.Text = "1"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.pgBar)
        Me.Panel1.Controls.Add(Me.btnSucc)
        Me.Panel1.Controls.Add(Me.btnPrec)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 468)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(698, 34)
        Me.Panel1.TabIndex = 1
        '
        'pgBar
        '
        Me.pgBar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pgBar.Location = New System.Drawing.Point(135, 5)
        Me.pgBar.Name = "pgBar"
        Me.pgBar.Size = New System.Drawing.Size(440, 23)
        Me.pgBar.Step = 1
        Me.pgBar.TabIndex = 2
        '
        'btnSucc
        '
        Me.btnSucc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSucc.Location = New System.Drawing.Point(597, 3)
        Me.btnSucc.Name = "btnSucc"
        Me.btnSucc.Size = New System.Drawing.Size(98, 28)
        Me.btnSucc.TabIndex = 1
        Me.btnSucc.Text = "Successiva"
        Me.btnSucc.UseVisualStyleBackColor = True
        '
        'btnPrec
        '
        Me.btnPrec.Enabled = False
        Me.btnPrec.Location = New System.Drawing.Point(12, 3)
        Me.btnPrec.Name = "btnPrec"
        Me.btnPrec.Size = New System.Drawing.Size(98, 28)
        Me.btnPrec.TabIndex = 0
        Me.btnPrec.Text = "Precedente"
        Me.btnPrec.UseVisualStyleBackColor = True
        '
        'lblDomanda
        '
        Me.lblDomanda.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDomanda.BackColor = System.Drawing.Color.White
        Me.lblDomanda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDomanda.Font = New System.Drawing.Font("Century Gothic", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDomanda.Location = New System.Drawing.Point(24, 71)
        Me.lblDomanda.Name = "lblDomanda"
        Me.lblDomanda.Size = New System.Drawing.Size(671, 223)
        Me.lblDomanda.TabIndex = 0
        Me.lblDomanda.Text = "Domanda"
        '
        'grdGiocatori
        '
        Me.grdGiocatori.AllowUserToAddRows = False
        Me.grdGiocatori.AllowUserToDeleteRows = False
        Me.grdGiocatori.AllowUserToResizeColumns = False
        Me.grdGiocatori.AllowUserToResizeRows = False
        Me.grdGiocatori.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.grdGiocatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdGiocatori.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Giocatore, Me.Risposta})
        Me.grdGiocatori.Location = New System.Drawing.Point(15, 12)
        Me.grdGiocatori.Name = "grdGiocatori"
        Me.grdGiocatori.Size = New System.Drawing.Size(294, 470)
        Me.grdGiocatori.TabIndex = 1
        '
        'Giocatore
        '
        Me.Giocatore.DataPropertyName = "Giocatore"
        Me.Giocatore.HeaderText = "Giocatore"
        Me.Giocatore.MaxInputLength = 30
        Me.Giocatore.Name = "Giocatore"
        Me.Giocatore.ReadOnly = True
        Me.Giocatore.Width = 150
        '
        'Risposta
        '
        Me.Risposta.DataPropertyName = "RispostaData"
        Me.Risposta.HeaderText = "Risposta"
        Me.Risposta.MaxInputLength = 3
        Me.Risposta.Name = "Risposta"
        Me.Risposta.Width = 80
        '
        'Timer1
        '
        '
        'Quiz100
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1025, 504)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Quiz100"
        Me.Text = "Quiz 0-100"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.grdGiocatori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents grdGiocatori As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDomanda As Label
    Friend WithEvents btnSucc As Button
    Friend WithEvents btnPrec As Button
    Friend WithEvents pgBar As ProgressBar
    Friend WithEvents lblNum As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents btnStop As Button
    Friend WithEvents btnRisposta As Button
    Friend WithEvents lblRisposta As Label
    Friend WithEvents lblTempo As Label
    Friend WithEvents btnClassifica As Button
    Friend WithEvents lnkImmagine As LinkLabel
    Friend WithEvents Giocatore As DataGridViewTextBoxColumn
    Friend WithEvents Risposta As DataGridViewTextBoxColumn
End Class
