Public Class Classifica

    Private msg As String() = {"Dai {0}, stai andando fortissimo!",
        "{0}, sei solo forte!",
        "{0}, sesi troppu togu!",
        "{0}, ma come fai essere così bravo!",
        "Ma dai {0}, vuoi proprio strafare!",
        "{0}, questo gioco è troppo facile per te!",
        "T'arrori {0}, am cumenti faisi!"}

    Private Sub Classifica_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim giocatori As List(Of Giocatore) = LeggiGiocatori()
        Dim risposte As List(Of Risposta) = LeggiRisultati()
        Dim domande As List(Of Domanda) = LeggiDomande()

        ' // assegna punteggi
        For Each d As Domanda In domande
            If risposte.Where(Function(x) x.RispostaData Is Nothing And x.IdDomanda = d.IdDomanda).Count > 0 Then Continue For
            For Each r As Risposta In risposte.Where(Function(x) x.IdDomanda = d.IdDomanda)
                Dim g As Giocatore = giocatori.FirstOrDefault(Function(x) x.IdGiocatore = r.IdGiocatore)
                r.Punteggio = Math.Abs(CInt(If(r.RispostaData Is Nothing, 0, r.RispostaData)) - d.Risposta)
                If r.Punteggio = 0 Then r.Punteggio = -10
            Next
        Next
        ' // totalizza
        For Each g As Giocatore In giocatori
            g.Punteggio = 0
            For Each r As Risposta In risposte.Where(Function(x) x.IdGiocatore = g.IdGiocatore)
                g.Punteggio += r.Punteggio
            Next
        Next

        grdGiocatori.AutoGenerateColumns = False
        grdGiocatori.DataSource = giocatori.OrderBy(Function(x) x.Punteggio).ToList

        Randomize(Now.Ticks)
        Dim n As Integer = (New Random).Next(0, msg.Count)
        lblMessaggio.Text = String.Format(msg(n), CType(grdGiocatori.DataSource, List(Of Giocatore)).Last.Nome)

    End Sub



End Class