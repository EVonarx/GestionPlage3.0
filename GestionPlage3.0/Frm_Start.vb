Imports System.Data.SqlClient

Public Class Frm_Start
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Frm_Collabo.Show()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Frm_Plages.Show()
    End Sub

    Private Sub Btn_AjouModif_Click(sender As Object, e As EventArgs) Handles Btn_CreerSupprimer.Click
        Me.Hide()
        Frm_AjoutModifSupp.Show()
    End Sub

    Private Sub Btn_Quitter_Click(sender As Object, e As EventArgs) Handles Btn_Quitter.Click

        Frm_Collabo.Close()
        Frm_Associer.Close()
        Frm_Supprimer.Close()
        Frm_Ajouter.Close()
        Frm_AjoutModifSupp.Close()
        Frm_Plages.Close()
        Frm_NatureTerrain.Close()
        Frm_Login.Close()
        Me.Close()

    End Sub

    Private Sub Btn_NatureTerrain_Click(sender As Object, e As EventArgs) Handles Btn_NatureTerrain.Click
        Me.Hide()
        Frm_NatureTerrain.Show()
    End Sub
End Class
