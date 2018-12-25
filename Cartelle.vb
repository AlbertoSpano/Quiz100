Imports System.IO
Imports System.Reflection
Imports System.Text
Imports Newtonsoft.Json

Public Module Cartelle

    Public Function Percorso(ByVal Optional prodotto As String = "Quiz100") As String
        Dim assembly As Assembly = Assembly.GetExecutingAssembly()
        Dim localAppData As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
        Dim userFilePath As String = Path.Combine(localAppData, prodotto)
        userFilePath = Path.Combine(userFilePath, "Dati")
        Directory.CreateDirectory(userFilePath)
        Return userFilePath
    End Function

    Public Function FileGiocatori() As String
        Return IO.Path.Combine(Percorso, "Giocatori.json")
    End Function

    Public Function FileDomande() As String
        Return IO.Path.Combine(Percorso, "Domande.json")
    End Function

    Public Function FileRisposte() As String
        Return IO.Path.Combine(Percorso, "Risposte.json")
    End Function

    Private Function LeggiFile(filePath As String) As String
        If IO.File.Exists(filePath) Then
            Return IO.File.ReadAllText(filePath)
        Else
            Return String.Empty
        End If
    End Function

    Public Sub SalvaGiocatori(g As List(Of Giocatore))
        IO.File.WriteAllText(FileGiocatori, JsonConvert.SerializeObject(g))
    End Sub

    Public Sub SalvaDomande(d As List(Of Domanda))
        IO.File.WriteAllText(FileDomande, JsonConvert.SerializeObject(d))
    End Sub

    Public Sub SalvaRisultati(r As List(Of Risposta))
        IO.File.WriteAllText(FileRisposte, JsonConvert.SerializeObject(r))
    End Sub


    Public Function LeggiGiocatori() As List(Of Giocatore)
        Dim ret As List(Of Giocatore) = JsonConvert.DeserializeObject(Of List(Of Giocatore))(LeggiFile(FileGiocatori))
        If ret Is Nothing Then
            Return New List(Of Giocatore)
        Else
            Return ret
        End If
    End Function

    Public Function LeggiDomande() As List(Of Domanda)
        Dim ret As List(Of Domanda) = JsonConvert.DeserializeObject(Of List(Of Domanda))(LeggiFile(FileDomande))
        If ret Is Nothing Then
            Return New List(Of Domanda)
        Else
            Return ret
        End If
    End Function

    Public Function LeggiRisultati() As List(Of Risposta)
        Dim ret As List(Of Risposta) = JsonConvert.DeserializeObject(Of List(Of Risposta))(LeggiFile(FileRisposte))
        If ret Is Nothing Then
            Return New List(Of Risposta)
        Else
            Return ret
        End If
    End Function

    Public Function LeggiImmagine(DomandaId As Integer) As Image
        Dim nomeFIle As String = IO.Path.Combine(Percorso, DomandaId.ToString + ".png")
        If IO.File.Exists(nomeFIle) Then
            Return Image.FromFile(nomeFIle)
        Else
            Return Nothing
        End If
    End Function

    Public Function CaricaDomande(filepath As String, intestazione As Boolean) As Boolean
        Dim n As Integer = 0
        Dim dd As New List(Of Domanda)
        For Each riga In IO.File.ReadAllLines(filepath, Encoding.UTF8)
            n += 1
            ' // salta riga intestazione
            If n = 1 And intestazione Then Continue For
            ' // divide la riga 
            Dim s As String() = riga.Split(";")
            If s.Length < 3 Then
                MsgBox(String.Format("La riga {0} contiene un numero di colonne minore di tre!", n), MsgBoxStyle.Critical)
                Return False
            End If
            If Not IsNumeric(s(0)) Then
                MsgBox(String.Format("La riga {0}, colonna 1, deve contenere il numero della domanda!", n), MsgBoxStyle.Critical)
                Return False
            End If
            If Not IsNumeric(s(2)) Then
                MsgBox(String.Format("La riga {0}, colonna 3, non contiene una risposta numerica!", n), MsgBoxStyle.Critical)
                Return False
            End If
            dd.Add(New Domanda() With {.IdDomanda = CInt(s(0)), .Domanda = s(1), .Risposta = CInt(s(2))})
        Next
        SalvaDomande(dd)
        Return True
    End Function

    Public Sub InizializzaGiocatori()
        SalvaGiocatori(New List(Of Giocatore))
    End Sub

    Public Sub InizializzaDomande()
        SalvaDomande(New List(Of Domanda))
    End Sub

    Public Sub InizializzaRisposte()
        SalvaRisultati(New List(Of Risposta))
    End Sub

    Public Sub InizializzaImmagini()
        For Each s As String In IO.Directory.GetFiles(Percorso, "*.png")
            IO.File.Delete(s)
        Next
    End Sub

End Module
