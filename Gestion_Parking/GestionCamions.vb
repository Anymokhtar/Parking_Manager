Public Class GestionCamions

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Button5.Visible = False
        Dim chauffeur As String = TextBox1.Text
        Dim immatriculation As String = TextBox2.Text
        Dim tonnage As String = TextBox3.Text
        Dim datentre As String = DateTimePicker1.Value
        Dim datesortie As String = DateTimePicker2.Value
        Dim marque As String = GroupBox1.Text
        If RadioButton1.Checked Then
            marque = "Peugeot"

        ElseIf RadioButton2.Checked Then
            marque = "Citreon"
        ElseIf RadioButton3.Checked Then
            marque = TextBox4.Text
        End If
        If (chauffeur <> "" And immatriculation <> "" And tonnage <> "") Then
            Dim element As New ListViewItem(chauffeur)
            element.SubItems.Add(immatriculation)
            element.SubItems.Add(tonnage)
            element.SubItems.Add(marque)
            element.SubItems.Add(datentre)
            element.SubItems.Add(datesortie)
            ListCamions.Items.Add(element)
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            GroupBox1.Text = ""
        Else
            MessageBox.Show("Veuillez remplir les champs obligatoires ")
        End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        If (ListCamions.SelectedItems.Count > 0) Then
            TextBox1.Text = ListCamions.SelectedItems(0).SubItems(0).Text
            TextBox2.Text = ListCamions.SelectedItems(0).SubItems(1).Text
            TextBox3.Text = ListCamions.SelectedItems(0).SubItems(2).Text
            GroupBox1.Text = ListCamions.SelectedItems(0).SubItems(3).Text
            DateTimePicker1.Value = ListCamions.SelectedItems(0).SubItems(4).Text
            DateTimePicker2.Value = ListCamions.SelectedItems(0).SubItems(4).Text
            Button1.Visible = True
            Button1.Enabled = False
            Button5.Visible = True
        Else
            MessageBox.Show("Aucun element selectionne!")
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        If (ListCamions.SelectedItems.Count > 0) Then

            ListCamions.Items(ListCamions.SelectedIndices(0)).Remove()
            MessageBox.Show("element est supprimer")
        Else

            MessageBox.Show("Aucun element selectionne !")
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Button5.Visible = True
        Dim chauffeur As String = TextBox1.Text
        Dim immatriculation As String = TextBox2.Text
        Dim tonnage As String = TextBox3.Text
        Dim datentre As String = DateTimePicker1.Value
        Dim datesortie As String = DateTimePicker2.Value
        Dim marque As String = GroupBox1.Text
        If RadioButton1.Checked Then
            marque = "Peugeot"

        ElseIf RadioButton2.Checked Then
            marque = "Citreon"
        ElseIf RadioButton3.Checked Then
            marque = TextBox4.Text
        End If
        If (chauffeur <> "" And immatriculation <> "" And tonnage <> "") Then
            Dim element As New ListViewItem(chauffeur)
            element.SubItems.Add(immatriculation)
            element.SubItems.Add(tonnage)
            element.SubItems.Add(marque)
            element.SubItems.Add(datentre)
            element.SubItems.Add(datesortie)
            ListCamions.Items(ListCamions.SelectedIndices(0)) = element
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            GroupBox1.Text = ""
        Else
            MessageBox.Show("Veuillez remplir les champs obligatoires ")
        End If
        Button1.Visible = True
        Button1.Enabled = True
        Button5.Visible = False
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        GestionParking.Show()
        Me.Hide()
    End Sub
End Class