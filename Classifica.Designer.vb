<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Classifica
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
        Me.Classific = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblMessaggio = New System.Windows.Forms.Label()
        CType(Me.grdGiocatori, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.grdGiocatori.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Giocatore, Me.Classific})
        Me.grdGiocatori.Location = New System.Drawing.Point(51, 31)
        Me.grdGiocatori.Name = "grdGiocatori"
        Me.grdGiocatori.Size = New System.Drawing.Size(333, 280)
        Me.grdGiocatori.TabIndex = 2
        '
        'Giocatore
        '
        Me.Giocatore.DataPropertyName = "Nome"
        Me.Giocatore.HeaderText = "Giocatore"
        Me.Giocatore.MaxInputLength = 3
        Me.Giocatore.Name = "Giocatore"
        Me.Giocatore.ReadOnly = True
        Me.Giocatore.Width = 150
        '
        'Classific
        '
        Me.Classific.DataPropertyName = "Punteggio"
        Me.Classific.HeaderText = "Punteggio"
        Me.Classific.Name = "Classific"
        Me.Classific.Width = 80
        '
        'lblMessaggio
        '
        Me.lblMessaggio.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lblMessaggio.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessaggio.ForeColor = System.Drawing.Color.Red
        Me.lblMessaggio.Location = New System.Drawing.Point(0, 379)
        Me.lblMessaggio.Name = "lblMessaggio"
        Me.lblMessaggio.Size = New System.Drawing.Size(491, 43)
        Me.lblMessaggio.TabIndex = 3
        Me.lblMessaggio.Text = "-"
        Me.lblMessaggio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Classifica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 422)
        Me.Controls.Add(Me.lblMessaggio)
        Me.Controls.Add(Me.grdGiocatori)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Classifica"
        Me.Text = "Classifica"
        CType(Me.grdGiocatori, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents grdGiocatori As DataGridView
    Friend WithEvents Giocatore As DataGridViewTextBoxColumn
    Friend WithEvents Classific As DataGridViewTextBoxColumn
    Friend WithEvents lblMessaggio As Label
End Class
