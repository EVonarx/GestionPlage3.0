Imports System.Data.SqlClient

Public Class Frm_Supprimer

    Dim Temp_ID As Integer = 0
    Dim Temp_ID1 As String = 0
    Private Sub Frm_Supprimer_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.VisibleChanged

        If ParamAjouter = "Responsable" Then
            Lbl_Titre.Text = "Choississez le RESPONSABLE à supprimer"
            CB_Selection.Items.Clear()
            CB_Selection.Text = ""
            Frm_Ajouter.Fill_Responsable(CB_Selection)
        End If

        If ParamAjouter = "Region" Then
            Lbl_Titre.Text = "Choississez la REGION à supprimer"
            CB_Selection.Items.Clear()
            CB_Selection.Text = ""
            Frm_Ajouter.Fill_Region(CB_Selection)
        End If

        If ParamAjouter = "Departement" Then
            Lbl_Titre.Text = "Choississez le DEPARTEMENT à supprimer"
            CB_Selection.Items.Clear()
            CB_Selection.Text = ""
            Frm_Ajouter.Fill_Departement(CB_Selection)
        End If

        If ParamAjouter = "Ville" Then
            Lbl_Titre.Text = "Choississez la VILLE à supprimer"
            CB_Selection.Items.Clear()
            CB_Selection.Text = ""
            Frm_Ajouter.Fill_Ville(CB_Selection)
        End If

        If ParamAjouter = "Plage" Then
            Lbl_Titre.Text = "Choississez la PLAGE à supprimer"
            CB_Selection.Items.Clear()
            CB_Selection.Text = ""
            Frm_Ajouter.Fill_Plage(CB_Selection)
        End If

        If ParamAjouter = "NTerrain" Then
            Lbl_Titre.Text = "Choississez la NATURE DU TERRAIN à supprimer"
            CB_Selection.Items.Clear()
            CB_Selection.Text = ""
            Frm_Ajouter.Fill_NTerrain(CB_Selection)
        End If

    End Sub

    Private Sub Btn_Annuler_Click(sender As Object, e As EventArgs) Handles Btn_Annuler.Click
        Me.Hide()
        Frm_AjoutModifSupp.Show()
    End Sub

    Private Sub Btn_Supprimer_Click(sender As Object, e As EventArgs) Handles Btn_Supprimer.Click

        Dim result As Long = 0

        If ParamAjouter = "Responsable" Then


            If SuppressionPossible("SELECT * FROM REGION WHERE ID_RESPONSABLE = ") Then
                result = Supprimer("DELETE FROM RESPONSABLE WHERE ID_RESPONSABLE = ")

                If (result = -1) Then
                    MsgBox("Le responsable " & Temp_ID1 & " a été supprimé avec succès")
                Else
                    MsgBox("ERROR - Le responsable " & Temp_ID1 & " n'a pas été supprimé !!!!!!!")
                End If
            Else
                MsgBox("Suppression impossible : il y a encore une région rattachée au responsable !!!!!!!")
            End If

            'Je n'aurai pas besoin de faire le test ci-dessus puisque le responsable ne sera pas supprimer s'il y a encore une région qui le référence ;-) 
            '=> ce mécanisme est super 
            'Je fais tout de même le code ci-dessus pour ne pas tomber sur l'exception à l'exécution de la commande SQL
            'Supprimer("DELETE FROM RESPONSABLE WHERE ID_RESPONSABLE = ")


        End If

        If ParamAjouter = "Region" Then
            If SuppressionPossible("SELECT * FROM DEPARTEMENT WHERE ID_REGION = ") Then
                result = Supprimer("DELETE FROM REGION WHERE ID_REGION = ")

                If (result = -1) Then
                    MsgBox("La région " & Temp_ID1 & " a été supprimée avec succès")
                Else
                    MsgBox("ERROR - La région " & Temp_ID1 & " n'a pas été supprimée !!!!!!!")
                End If
            Else
                MsgBox("Suppression impossible : il y a encore un département rattaché à la région !!!!!!!")
            End If
        End If

        If ParamAjouter = "Departement" Then
            If SuppressionPossible("SELECT * FROM VILLE WHERE ID_DEPARTEMENT = ") Then
                result = Supprimer("DELETE FROM DEPARTEMENT WHERE ID_DEPARTEMENT = ")

                If (result = -1) Then
                    MsgBox("Le département " & Temp_ID1 & " a été supprimé avec succès")
                Else
                    MsgBox("ERROR - Le département " & Temp_ID1 & " n'a pas été supprimé !!!!!!!")
                End If
            Else
                MsgBox("Suppression impossible : il y a encore une ville rattachée au département !!!!!!!")
            End If
        End If

        If ParamAjouter = "Ville" Then
            If SuppressionPossible("SELECT * FROM PLAGE WHERE ID_VILLE = ") Then
                result = Supprimer("DELETE FROM VILLE WHERE ID_VILLE = ")

                If (result = -1) Then
                    MsgBox("La ville " & Temp_ID1 & " a été supprimée avec succès")
                Else
                    MsgBox("ERROR - La ville " & Temp_ID1 & " n'a pas été supprimée !!!!!!!")
                End If
            Else
                MsgBox("Suppression impossible : il y a encore une plage rattachée à la ville !!!!!!!")
            End If
        End If

        If ParamAjouter = "Plage" Then

            result = Supprimer("DELETE FROM EST_COMPOSE_DE WHERE ID_PLAGE = ")
            result = Supprimer("DELETE FROM PLAGE WHERE ID_PLAGE = ")

            If (result = 1) Then
                MsgBox("La plage " & Temp_ID1 & " a été supprimée avec succès")
            Else
                MsgBox("ERROR - La plage " & Temp_ID1 & " n'a pas été supprimée !!!!!!!")
            End If

        End If

        If ParamAjouter = "NTerrain" Then

            If SuppressionPossible("SELECT * FROM EST_COMPOSE_DE WHERE ID_NATURE_TERRAIN = ") Then
                result = Supprimer("DELETE FROM NATURE_TERRAIN WHERE ID_NATURE_TERRAIN = ")

                If (result = 1) Then
                    MsgBox("La nature de terrain " & Temp_ID1 & " a été supprimée avec succès")
                Else
                    MsgBox("ERROR - La nature de terrain " & Temp_ID1 & " n'a pas été supprimée !!!!!!!")
                End If
            Else
                MsgBox("Suppression impossible : il y a encore une plage rattachée à la nature du terrain !!!!!!!")
            End If

        End If

        Me.Hide()
        Frm_AjoutModifSupp.Show()
    End Sub

    Function SuppressionPossible(Requete As String) As String
        Dim result As Boolean = False

        Dim temp() As String = Split(CB_Selection.Text, "-")
        Temp_ID = temp(0)
        Temp_ID1 = temp(1)

        myConn = New SqlConnection(machainedeconnexion)

        myCmd = myConn.CreateCommand
        myCmd.CommandText = Requete & Temp_ID

        myConn.Open()
        myReader = myCmd.ExecuteReader()

        If (myReader.Read()) Then
            result = False
        Else
            result = True
        End If

        myReader.Close()
        myConn.Close()

        Return result

    End Function

    Function Supprimer(Requete As String) As Long
        Dim result As Long = 0

        Dim temp() As String = Split(CB_Selection.Text, "-")
        Temp_ID = temp(0)
        Temp_ID1 = temp(1)

        myConn = New SqlConnection(machainedeconnexion)

        myCmd = myConn.CreateCommand
        myCmd.CommandText = Requete & Temp_ID

        myConn.Open()

        Try
            myReader = myCmd.ExecuteReader()
        Catch ex As Exception
            MsgBox("ENREGISTREMENT IMPOSSIBLE A EFFACER !!!! IL Y A UNE REFERENCE DE CET ENREGISTREMENT VERS UE TABLE FILLE " & vbCrLf & ex.Message)
        End Try

        result = myReader.RecordsAffected

        myReader.Close()
        myConn.Close()

        Return result

    End Function

End Class