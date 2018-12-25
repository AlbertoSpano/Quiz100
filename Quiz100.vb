Imports System.Media

Public Class Quiz100

    Private Domande As List(Of Domanda)
    Private Risultati As List(Of Risposta)
    Private DomandaCorrente As Integer = 1

    Private grdModificato As Boolean = False
    Private editByCode As Boolean = True
    Dim formImg As Immagine

    Public Property Tempo As Integer

    Private Sub Quiz100_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        formImg = New Immagine

        CaricaRisposte()

        CaricaDomande()

        CaricaGiocatori()

    End Sub

    Private Sub CaricaGiocatori()

        grdModificato = False

        editByCode = True

        grdGiocatori.AutoGenerateColumns = False
        grdGiocatori.DataSource = Risultati.Where(Function(x) x.IdDomanda = DomandaCorrente).ToList

        editByCode = False

    End Sub

    Private Sub CaricaDomande()
        Domande = LeggiDomande()
        AvviaNuovaDomanda()
    End Sub

    Private Sub CaricaRisposte()
        Risultati = LeggiRisultati()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        StartTimer()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Me.pgBar.Value += 1

        Dim resuduo As Integer = Tempo - pgBar.Value

        Me.lblTempo.Text = String.Format("Restano: {0} s", resuduo)

        If resuduo <= 5 Then
            SystemSounds.Asterisk.Play()
        ElseIf resuduo <= 10 Then
            SystemSounds.Beep.Play()
        End If

        If Me.pgBar.Value = pgBar.Maximum Then StopTimer()

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        StopTimer()
    End Sub

    Private Sub StopTimer()
        Me.Timer1.Stop()
        Me.btnPrec.Enabled = (DomandaCorrente > 1)
        Me.btnSucc.Enabled = (DomandaCorrente < Domande.Count)
        Me.btnStop.Enabled = False
        Me.btnStart.Enabled = True
        Me.btnRisposta.Enabled = True
        Me.grdGiocatori.Enabled = True
        Me.btnClassifica.Enabled = True
        Me.lblTempo.Text = "Tempo scaduto!!"
        SystemSounds.Hand.Play()
    End Sub

    Private Sub StartTimer()

        SystemSounds.Exclamation.Play()

        Me.btnPrec.Enabled = False
        Me.btnSucc.Enabled = False
        Me.btnStop.Enabled = True
        Me.btnStart.Enabled = False
        Me.grdGiocatori.Enabled = False
        Me.btnRisposta.Enabled = False
        Me.btnClassifica.Enabled = False

        InizializzaProgress()

        Me.lblDomanda.Text = Domande(DomandaCorrente - 1).Domanda
        Me.Timer1.Interval = 1000
        Me.Timer1.Start()

    End Sub

    Private Sub btnSucc_Click(sender As Object, e As EventArgs) Handles btnSucc.Click
        If Not SalvaRisultati() Then Return
        DomandaCorrente += 1
        AvviaNuovaDomanda()
    End Sub

    Private Sub btnPrec_Click(sender As Object, e As EventArgs) Handles btnPrec.Click
        If Not SalvaRisultati() Then Return
        DomandaCorrente -= 1
        AvviaNuovaDomanda()
    End Sub

    Private Sub AvviaNuovaDomanda()
        lblTempo.Text = ""
        lblNum.Text = DomandaCorrente.ToString
        lblDomanda.Text = String.Format("Domanda n. {0}", DomandaCorrente)
        btnPrec.Enabled = (DomandaCorrente > 1)
        btnSucc.Enabled = (DomandaCorrente < Domande.Count)
        InizializzaProgress()
        CaricaGiocatori()
        formImg.Close()
        lnkImmagine.Enabled = Not LeggiImmagine(DomandaCorrente) Is Nothing
        If CheckRisposte() Then
            lblRisposta.Text = String.Format("Risposta esatta: {0}", Domande(DomandaCorrente - 1).Risposta)
            lblDomanda.Text = Domande.FirstOrDefault(Function(x) x.IdDomanda = DomandaCorrente).Domanda
            Me.btnRisposta.Enabled = False
        Else
            lblRisposta.Text = ""
            lblDomanda.Text = String.Format("Domanda n. {0}", DomandaCorrente)
            Me.btnRisposta.Enabled = True
        End If
    End Sub

    Private Sub InizializzaProgress()
        Me.pgBar.Value = 0
        Me.pgBar.Minimum = 0
        Me.pgBar.Maximum = Tempo
    End Sub

    Private Sub btnRisposta_Click(sender As Object, e As EventArgs) Handles btnRisposta.Click
        If CheckRisposte() Then
            lblRisposta.Text = String.Format("Risposta esatta: {0}", Domande(DomandaCorrente - 1).Risposta)
        Else
            MsgBox("Giocatori senza risultato!", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Function SalvaRisultati() As Boolean

        If Not grdModificato Then Return True

        If Not CheckRisposte() Then Return False

        Dim rCurr As List(Of Risposta) = Risultati.Where(Function(x) x.IdDomanda = DomandaCorrente).ToList

        For Each r As DataGridViewRow In grdGiocatori.Rows
            Dim rs As Integer = CInt(r.Cells(1).Value)
            Dim rc As Risposta = rCurr.FirstOrDefault(Function(x) x.Giocatore = r.Cells(0).Value)
            If rc IsNot Nothing Then
                rc.RispostaData = rs
            End If
        Next
        Cartelle.SalvaRisultati(Risultati)

        Return True

    End Function

    Private Sub grdGiocatori_RowValidated(sender As Object, e As DataGridViewCellEventArgs) Handles grdGiocatori.RowValidated
        If editByCode Then Return
        grdModificato = True
    End Sub

    Private Function CheckRisposte() As Boolean
        For Each r As DataGridViewRow In grdGiocatori.Rows
            If r.Cells(1).Value Is Nothing Then
                Return False
            End If
        Next
        Return True
    End Function

    Private Sub grdGiocatori_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles grdGiocatori.EditingControlShowing

        AddHandler e.Control.KeyPress, AddressOf Risposta_KeyPress

        If grdGiocatori.CurrentCell.ColumnIndex = 0 Then
            Dim tb As TextBox = TryCast(e.Control, TextBox)

            If tb IsNot Nothing Then
                AddHandler tb.KeyPress, AddressOf Risposta_KeyPress
            End If
        End If

    End Sub

    Private Sub Risposta_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnClassifica_Click(sender As Object, e As EventArgs) Handles btnClassifica.Click
        If Not SalvaRisultati() Then Return
        Using f As New Classifica
            f.ShowDialog()
        End Using
    End Sub

    Private Sub lnkImmagine_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lnkImmagine.LinkClicked
        If formImg.Visible Then Return
        Dim img As Image = LeggiImmagine(DomandaCorrente)
        If img Is Nothing Then Return
        formImg = New Immagine
        formImg.Img = img
        formImg.Show()
    End Sub

    Private Sub grdGiocatori_CellValidating(sender As Object, e As DataGridViewCellValidatingEventArgs) Handles grdGiocatori.CellValidating
        If e.ColumnIndex = 1 And IsNumeric(e.FormattedValue) Then
            If CInt(e.FormattedValue) > 100 Or CInt(e.FormattedValue) < 0 Then
                MsgBox("Valore compreso tra 0 e 100!", MsgBoxStyle.Information)
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Quiz100_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.PageDown Then
            If btnPrec.Enabled Then btnPrec_Click(btnPrec, Nothing)
        ElseIf e.KeyCode = Keys.PageUp Then
            If btnSucc.Enabled Then btnSucc_Click(btnSucc, Nothing)
        End If
    End Sub

End Class
