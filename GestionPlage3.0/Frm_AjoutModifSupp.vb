Public Class Frm_AjoutModifSupp
    Private Sub Btn_CreerResponsable_Click(sender As Object, e As EventArgs) Handles Btn_CreerResponsable.Click
        ParamAjouter = "Responsable"
        Me.Hide()
        Frm_Ajouter.Show()
    End Sub

    Private Sub Btn_CreerRegion_Click(sender As Object, e As EventArgs) Handles Btn_CreerRegion.Click
        ParamAjouter = "Region"
        Me.Hide()
        Frm_Ajouter.Show()
    End Sub

    Private Sub Btn_CreerDepartement_Click(sender As Object, e As EventArgs) Handles Btn_CreerDepartement.Click
        ParamAjouter = "Departement"
        Me.Hide()
        Frm_Ajouter.Show()
    End Sub

    Private Sub Btn_CreerVille_Click(sender As Object, e As EventArgs) Handles Btn_CreerVille.Click
        ParamAjouter = "Ville"
        Me.Hide()
        Frm_Ajouter.Show()
    End Sub

    Private Sub Btn_CreerPlage_Click(sender As Object, e As EventArgs) Handles Btn_CreerPlage.Click
        ParamAjouter = "Plage"
        Me.Hide()
        Frm_Ajouter.Show()
    End Sub

    Private Sub Btn_CreerNature_Click(sender As Object, e As EventArgs) Handles Btn_CreerNature.Click
        ParamAjouter = "NTerrain"
        Me.Hide()
        Frm_Ajouter.Show()
    End Sub


    Private Sub Btn_RetourMenu_Click(sender As Object, e As EventArgs) Handles Btn_RetourMenu.Click
        Me.Hide()
        Frm_Start.Show()
    End Sub

    Private Sub Btn_ModifResponsableRegion_Click(sender As Object, e As EventArgs) Handles Btn_AssocierResponsableRegion.Click
        ParamAjouter = "ResponsableRegion"
        Me.Hide()
        Frm_Associer.Show()
    End Sub



    Private Sub Btn_SuppNatTerrain_Click(sender As Object, e As EventArgs) Handles Btn_SuppNatTerrain.Click
        ParamAjouter = "NTerrain"
        Me.Hide()
        Frm_Supprimer.Show()
    End Sub

    Private Sub Btn_SuppPlage_Click(sender As Object, e As EventArgs) Handles Btn_SuppPlage.Click
        ParamAjouter = "Plage"
        Me.Hide()
        Frm_Supprimer.Show()
    End Sub

    Private Sub Btn_SuppVille_Click(sender As Object, e As EventArgs) Handles Btn_SuppVille.Click
        ParamAjouter = "Ville"
        Me.Hide()
        Frm_Supprimer.Show()
    End Sub

    Private Sub Btn_SuppDepart_Click(sender As Object, e As EventArgs) Handles Btn_SuppDepart.Click
        ParamAjouter = "Departement"
        Me.Hide()
        Frm_Supprimer.Show()
    End Sub

    Private Sub Btn_SuppRegion_Click(sender As Object, e As EventArgs) Handles Btn_SuppRegion.Click
        ParamAjouter = "Region"
        Me.Hide()
        Frm_Supprimer.Show()
    End Sub

    Private Sub Btn_SuppResp_Click(sender As Object, e As EventArgs) Handles Btn_SuppResp.Click
        ParamAjouter = "Responsable"
        Me.Hide()
        Frm_Supprimer.Show()
    End Sub

    Private Sub Btn_AssocierPlageNatureTerrain_Click(sender As Object, e As EventArgs) Handles Btn_AssocierPlageNatureTerrain.Click
        ParamAjouter = "PlageNatureTerrain"
        Me.Hide()
        Frm_Associer.Show()
    End Sub
End Class