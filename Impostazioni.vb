Imports System.IO

Public Class Impostazioni

    Private grdModificato As Boolean = False
    Private domandeModificato As Boolean = False

    Private Sub Impostazioni_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim bs As New BindingSource
        bs.DataSource = Cartelle.LeggiGiocatori
        grdGiocatori.AutoGenerateColumns = False
        grdGiocatori.DataSource = bs

        lblDomande.Text = Cartelle.LeggiDomande.Count
        lblImmagini.Text = IO.Directory.GetFiles(Percorso, "*.png").Count

    End Sub

    Private Sub btnDomande_Click(sender As Object, e As EventArgs) Handles btnDomande.Click

        If Cartelle.LeggiDomande.Count > 0 Then
            If MsgBox("Esiste già un file domande, continuo?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2) = MsgBoxResult.No Then Return
        End If

        If Me.OpenFileDomande.ShowDialog = DialogResult.OK Then
            If CaricaDomande(Me.OpenFileDomande.FileName, chkIntestazione.Checked) Then
                domandeModificato = True
                Cartelle.InizializzaRisposte()
                lblDomande.Text = Cartelle.LeggiDomande.Count
            End If
        End If

    End Sub

    Private Sub lnkAvanti_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkAvanti.LinkClicked

        If grdGiocatori.RowCount = 1 Then
            MsgBox("Giocatori non inseriti!")
            Return
        End If

        If Cartelle.LeggiDomande.Count = 0 Then
            MsgBox("Domande non caricate!")
            Return
        End If

        If domandeModificato Then InizializzaImmagini()

        If grdModificato Or domandeModificato Then

            Dim gg As New List(Of Giocatore)
            For Each r As DataGridViewRow In grdGiocatori.Rows
                If Not String.IsNullOrWhiteSpace(r.Cells(0).Value) Then _
                gg.Add(New Giocatore() With {.IdGiocatore = r.Index + 1, .Nome = r.Cells(0).Value.ToString})
            Next
            SalvaGiocatori(gg)

            Dim rr As New List(Of Risposta)
            For i As Integer = 1 To Cartelle.LeggiDomande.Count
                For Each g As Giocatore In gg
                    rr.Add(New Risposta() With {.IdDomanda = i, .IdGiocatore = g.IdGiocatore, .Giocatore = g.Nome, .Punteggio = 0, .RispostaData = Nothing})
                Next
            Next
            SalvaRisultati(rr)

        End If

        Using q As New Quiz100
            q.Tempo = txtTempo.Value
            q.ShowDialog()
        End Using

    End Sub

    Private Sub btnImmagini_Click(sender As Object, e As EventArgs) Handles btnImmagini.Click
        If Me.OpenFileImmagini.ShowDialog = DialogResult.OK Then
            For Each s As String In Me.OpenFileImmagini.FileNames
                IO.File.Copy(s, IO.Path.Combine(Percorso, IO.Path.GetFileName(s)), True)
            Next
            lblImmagini.Text = Me.OpenFileImmagini.FileNames.Count.ToString
        End If
    End Sub

    Private Sub grdGiocatori_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grdGiocatori.EditingControlShowing

        If grdGiocatori.CurrentCell.ColumnIndex = 0 Then
            Dim tb As TextBox = TryCast(e.Control, TextBox)

            If tb IsNot Nothing Then
                AddHandler tb.KeyPress, AddressOf Risposta_KeyPress
            End If
        End If

    End Sub

    Private Sub Risposta_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        grdModificato = True
    End Sub

End Class