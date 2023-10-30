Public Class GestionParking

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        GestionUtilisateurs.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        GestionVoituers.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        GestionCamions.Show()
        Me.Hide()
    End Sub
End Class
