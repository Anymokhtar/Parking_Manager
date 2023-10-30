Public Class GestionUtilisateurs

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim nom As String = TextBox1.Text
        Dim tel As String = TextBox2.Text
        Dim email As String = TextBox3.Text
        Dim role As String = ComboBox1.Text
        Dim mdp As String = TextBox4.Text
        Dim confirmation As String = TextBox5.Text
        Dim statut As String = ""
        If (RadioButton1.Text = "Activer") Then
            statut = "Active"
        Else
            statut = "Desactiver"
        End If
        If (nom <> "" And email <> "" And mdp <> "") Then
            If (mdp = confirmation) Then

                Dim element As New ListViewItem(nom)

                element.SubItems.Add(tel)
                element.SubItems.Add(email)
                element.SubItems.Add(role)
                element.SubItems.Add(mdp)
                element.SubItems.Add(statut)
                listUtilisateurs.Items.Add(element)
                TextBox1.Clear()
                TextBox2.Clear()
                ComboBox1.Text = ""
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
            Else
                MessageBox.Show("Les deux mots de passes ne sont pas identiques ")
            End If
        Else
            MessageBox.Show("Veuillez remplir les champs obligatoires ")
        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If (listUtilisateurs.SelectedItems.Count > 0) Then

            TextBox1.Text = listUtilisateurs.SelectedItems(0).SubItems(0).Text
            TextBox2.Text = listUtilisateurs.SelectedItems(0).SubItems(1).Text
            TextBox3.Text = listUtilisateurs.SelectedItems(0).SubItems(2).Text
            TextBox4.Text = listUtilisateurs.SelectedItems(0).SubItems(4).Text

            Button1.Visible = True
            Button1.Enabled = False
            Button3.Visible = True
        Else
            MessageBox.Show("Aucun element selectionne!")
        End If



    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim nom As String = TextBox1.Text
        Dim tel As String = TextBox2.Text
        Dim email As String = TextBox3.Text
        Dim role As String = ComboBox1.Text
        Dim mdp As String = TextBox5.Text
        Dim confirmation As String = TextBox5.Text
        Dim statut As String = ""
        If (RadioButton1.Text = "Activer") Then
            statut = "Active"
        Else
            statut = "Desactiver"
        End If


        If (nom <> "" And email <> "" And mdp <> "") Then
            If (mdp = confirmation) Then

                Dim element As New ListViewItem(nom)

                element.SubItems.Add(tel)
                element.SubItems.Add(email)
                element.SubItems.Add(role)
                element.SubItems.Add(mdp)
                element.SubItems.Add(statut)

                listUtilisateurs.Items(listUtilisateurs.SelectedIndices(0)) = element
                Button2.Visible = True
                Button1.Enabled = True
                TextBox1.Clear()
                TextBox2.Clear()
                TextBox3.Clear()
                TextBox4.Clear()
                TextBox5.Clear()
            Else
                MessageBox.Show("Les deux mots de passes ne sont pas identiques ")
            End If
        Else
            MessageBox.Show("Veuillez remplir les champs obligatoires ")
        End If
        Button1.Enabled = True
        Button1.Visible = True
        Button3.Visible = False
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If (listUtilisateurs.SelectedItems.Count > 0) Then

            listUtilisateurs.Items(listUtilisateurs.SelectedIndices(0)).Remove()
            MessageBox.Show("le element est supprimer")
        Else

            MessageBox.Show("Aucun element selectionne !")
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        GestionParking.Show()
        Me.Hide()
    End Sub
End Class