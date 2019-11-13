
Imports System.Data.SqlClient
Public Class Frm_Collabo

    Dim Temp_ID_Responsable As Integer = 0



    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.VisibleChanged

        Txt_Region.Text = ""
        Txt_Donnees.Text = ""

        CB_Name.Items.Clear()
        CB_Name.Text = "Choississez un responsable"

        '-------------------------------------------------------------------------
        '-------------------------------------------------------------------------
        ' Liste des responsables dans Combo Box
        '-------------------------------------------------------------------------
        '-------------------------------------------------------------------------

        myConn = New SqlConnection(machainedeconnexion)

        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT * FROM RESPONSABLE"

        myConn.Open()
        myReader = myCmd.ExecuteReader()

        If (myReader.Read()) Then
            CB_Name.Items.Add(myReader.GetDecimal(0) & " - " & myReader.GetString(1))
        End If

        Do While myReader.Read()
            CB_Name.Items.Add(myReader.GetDecimal(0) & " - " & myReader.GetString(1))
        Loop

        myReader.Close()
        myConn.Close()

    End Sub


    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------
    ' CHANGEMENT DANS LA COMBOBOX
    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------
    Private Sub CB_Name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Name.SelectedIndexChanged

        Dim temp() As String = Split(CB_Name.Text, "-")
        Temp_ID_Responsable = temp(0)

        Txt_Region.Text = ""
        Txt_Donnees.Text = ""

        AffichagesDonnées()

    End Sub


    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------
    ' Affichage régions, départements, villes, plages, longueurs, natures attachés au responsable
    '-------------------------------------------------------------------------
    '-------------------------------------------------------------------------
    Private Sub AffichagesDonnées()
        '-------------------------------------------------------------------------
        '-------------------------------------------------------------------------
        ' Affichage de la liste de la région attachée au responsable
        '-------------------------------------------------------------------------
        '-------------------------------------------------------------------------
        Dim Temp_ID_Region() As Integer = {0, 0, 0, 0, 0}

        myConn = New SqlConnection(machainedeconnexion)

        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT * FROM REGION WHERE ID_RESPONSABLE = " & Temp_ID_Responsable

        myConn.Open()
        myReader = myCmd.ExecuteReader()

        Dim i As Integer = 0

        If (myReader.Read()) Then
            Temp_ID_Region(i) = myReader.GetDecimal(0)
            Txt_Region.Text = myReader.GetString(2)
            i += 1
        End If



        Do While myReader.Read()
            Temp_ID_Region(i) = myReader.GetDecimal(0)
            Txt_Region.Text = Txt_Region.Text & " + " & myReader.GetString(2)
            i += 1
        Loop


        myReader.Close()
        myConn.Close()


        '-------------------------------------------------------------------------
        '-------------------------------------------------------------------------
        ' Affichage départements, villes, plages, longueurs, natures
        '-------------------------------------------------------------------------
        '-------------------------------------------------------------------------

        Txt_Donnees.Text = ""
        myConn = New SqlConnection(machainedeconnexion)

        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select STR_NOMDEPARTEMENT, STR_NOMVILLE, STR_NOM_PLAGE, D_LONGUEUR_PLAGE, STR_NATURE_TERRAIN from DEPARTEMENT 
inner Join ville on ville.ID_DEPARTEMENT = DEPARTEMENT.ID_DEPARTEMENT 
inner Join PLAGE on plage.ID_VILLE = ville.ID_VILLE 
inner Join EST_COMPOSE_DE on EST_COMPOSE_DE.ID_PLAGE = Plage.ID_PLAGE
inner Join NATURE_TERRAIN on NATURE_TERRAIN.ID_NATURE_TERRAIN = EST_COMPOSE_DE.ID_NATURE_TERRAIN
where Departement.Id_Region in (" & Temp_ID_Region(0) & ", " & Temp_ID_Region(1) & ", " & Temp_ID_Region(2) & ", " & Temp_ID_Region(3) & ", " & Temp_ID_Region(4) & ") order by STR_NOMDEPARTEMENT, STR_NOMVILLE, STR_NOM_PLAGE, D_LONGUEUR_PLAGE, STR_NATURE_TERRAIN"

        'myCmd.CommandText = "Select STR_NOMDEPARTEMENT, STR_NOMVILLE, STR_NOM_PLAGE, D_LONGUEUR_PLAGE from DEPARTEMENT inner Join ville on ville.ID_DEPARTEMENT = DEPARTEMENT.ID_DEPARTEMENT inner Join PLAGE on plage.ID_VILLE = ville.ID_VILLE where Departement.Id_Region = " & Temp_ID_Region
        myConn.Open()
        myReader = myCmd.ExecuteReader()

        While (myReader.Read())
            Txt_Donnees.Text = Txt_Donnees.Text & myReader.GetString(0) & " --- " & myReader.GetString(1) & " --- " & myReader.GetString(2) & " --- " & myReader.GetString(3) & " --- " & myReader.GetString(4) & vbCrLf
        End While

        myReader.Close()
        myConn.Close()
    End Sub

    Private Sub Btn_Retour_Click(sender As Object, e As EventArgs) Handles Btn_Retour.Click
        Me.Hide()
        Frm_Start.Show()
    End Sub
End Class