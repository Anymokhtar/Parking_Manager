Public Class GestionConnexion

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "mokhtar" And TextBox2.Text = "1234" Then
            GestionParking.Show()
            Me.Hide()
        Else
            MessageBox.Show("Le mot de passe n'est pas correct")
        End If
    End Sub

    
End Class