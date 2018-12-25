<Serializable>
Public Class Domanda

    Public Property IdDomanda As Integer
    Public Property Domanda As String
    Public Property Risposta As Integer

End Class

<Serializable>
Public Class Giocatore

    Public Property IdGiocatore As Integer
    Public Property Nome As String
    Public Property Punteggio As Integer

End Class


<Serializable>
Public Class Risposta

    Public Property IdDomanda As Integer
    Public Property IdGiocatore As Integer
    Public Property Giocatore As String
    Public Property RispostaData As Integer?
    Public Property Punteggio As Integer

End Class
