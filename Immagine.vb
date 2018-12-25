Public Class Immagine

    Public Property Img As Image

    Private Sub Immagine_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlImage.BackgroundImage = Img
        Location = New Point(Screen.PrimaryScreen.Bounds.Width - Width, Location.Y)
    End Sub

End Class