Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btn_ajouter_Click(sender As Object, e As EventArgs) Handles btn_ajouter.Click
        Dim l As Livre
        l.ISBN = Txt_ISBN.Text
        l.titre = Txt_titre.Text
        l.auteur = Txt_auteur.Text
        AjouterLivre(l)

        If AjouterLivre(l) Then
            MessageBox.Show("Ajout du livre avec succes")
        Else
            MessageBox.Show("le tableau bibliotheque est saturé")
        End If
    End Sub
    Private Sub btn_afficher_Click(sender As Object, e As EventArgs) Handles btn_afficher.Click
        liste_des_livres.Show()
        Frm__afficher.Show()
    End Sub
End Class
