Imports System.Data.SqlClient

Public Class Frm_Ajouter
    Private Sub Ajouter_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.VisibleChanged

        TxtSaisie.Text = ""
        CB_Info.Items.Clear()

        If ParamAjouter = "Responsable" Then
            Creer_Responsable()
        End If

        If ParamAjouter = "Region" Then
            Creer_Region()
        End If

        If ParamAjouter = "Departement" Then
            Creer_Departement()
        End If

        If ParamAjouter = "Ville" Then
            Creer_Ville()
        End If

        If ParamAjouter = "Plage" Then
            Creer_Plage()
        End If

        If ParamAjouter = "NTerrain" Then
            Creer_NTerrain()
        End If

    End Sub


    Private Sub Btn_Valider_Click(sender As Object, e As EventArgs) Handles Btn_Valider.Click

        TxtSaisie.Text = TxtSaisie.Text.ToUpper()

        If ParamAjouter = "Responsable" And TxtSaisie.Text <> "" Then
            myConn = New SqlConnection(machainedeconnexion)

            myCmd = myConn.CreateCommand
            myCmd.CommandText = "Insert into RESPONSABLE values ('" & TxtSaisie.Text & "')"

            myConn.Open()
            myReader = myCmd.ExecuteReader()

            myReader.Close()
            myConn.Close()

            MsgBox("Le responsable " & TxtSaisie.Text & " a été ajouté avec succès")

        End If


        If ParamAjouter = "Region" And TxtSaisie.Text <> "" Then

            Dim temp() As String = Split(CB_Selection.Text, "-")

            myConn = New SqlConnection(machainedeconnexion)

            myCmd = myConn.CreateCommand
            myCmd.CommandText = "Insert into Region values ('" & temp(0) & "', '" & TxtSaisie.Text & "')"

            myConn.Open()
            myReader = myCmd.ExecuteReader()

            myReader.Close()
            myConn.Close()

            MsgBox("La région " & TxtSaisie.Text & " a été ajoutée avec succès")

        End If

        If ParamAjouter = "Departement" And TxtSaisie.Text <> "" Then

            Dim temp() As String = Split(CB_Selection.Text, "-")

            myConn = New SqlConnection(machainedeconnexion)

            myCmd = myConn.CreateCommand
            myCmd.CommandText = "Insert into DEPARTEMENT values ('" & temp(0) & "', '" & TxtSaisie.Text & "')"

            myConn.Open()
            myReader = myCmd.ExecuteReader()

            myReader.Close()
            myConn.Close()

            MsgBox("Le département " & TxtSaisie.Text & " a été ajouté avec succès")

        End If

        If ParamAjouter = "Ville" And TxtSaisie.Text <> "" Then

            Dim temp() As String = Split(CB_Selection.Text, "-")

            myConn = New SqlConnection(machainedeconnexion)

            myCmd = myConn.CreateCommand
            myCmd.CommandText = "Insert into VILLE values ('" & temp(0) & "', '" & TxtSaisie.Text & "', '" & TxtBox_InfoSupplementaire1.Text & "', '" & TxtBox_InfoSupplementaire2.Text & "')"

            myConn.Open()
            myReader = myCmd.ExecuteReader()

            myReader.Close()
            myConn.Close()

            MsgBox("La ville " & TxtSaisie.Text & " a été ajoutée avec succès")

        End If

        If ParamAjouter = "Plage" And TxtSaisie.Text <> "" Then

            Dim temp() As String = Split(CB_Selection.Text, "-")

            myConn = New SqlConnection(machainedeconnexion)

            myCmd = myConn.CreateCommand
            myCmd.CommandText = "Insert into PLAGE values ('" & temp(0) & "', '" & TxtSaisie.Text & "', '" & TxtBox_InfoSupplementaire1.Text & "')"

            myConn.Open()
            myReader = myCmd.ExecuteReader()

            myReader.Close()
            myConn.Close()

            MsgBox("La plage " & TxtSaisie.Text & " a été ajoutée avec succès")

        End If


        If ParamAjouter = "NTerrain" And TxtSaisie.Text <> "" Then

            Dim temp() As String = Split(CB_Selection.Text, "-")

            myConn = New SqlConnection(machainedeconnexion)

            myCmd = myConn.CreateCommand

            myCmd.CommandText = "Insert into NATURE_TERRAIN values ('" & TxtSaisie.Text & "')"

            myConn.Open()
            myReader = myCmd.ExecuteReader()

            myReader.Close()
            myConn.Close()

            MsgBox("La nature du terrain " & TxtSaisie.Text & " a été ajoutée avec succès")

        End If

        Me.Hide()
        Frm_AjoutModifSupp.Show()
    End Sub

    Private Sub Btn_Annuler_Click(sender As Object, e As EventArgs) Handles Btn_Annuler.Click
        Me.Hide()
        Frm_AjoutModifSupp.Show()

    End Sub

    '-----------------------------------------------------------------------
    '-----------------------------------------------------------------------
    ' Fill
    '-----------------------------------------------------------------------
    '-----------------------------------------------------------------------

    Public Sub Fill_Responsable(cb As ComboBox)
        myConn = New SqlConnection(machainedeconnexion)

        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT * FROM RESPONSABLE order by STR_NOMRESPONSABLE"

        myConn.Open()
        myReader = myCmd.ExecuteReader()

        If (myReader.Read()) Then
            cb.Items.Add(myReader.GetDecimal(0) & " - " & myReader.GetString(1))
        End If

        Do While myReader.Read()
            cb.Items.Add(myReader.GetDecimal(0) & " - " & myReader.GetString(1))
        Loop

        myReader.Close()
        myConn.Close()
    End Sub


    Public Sub Fill_Region(cb As ComboBox)
        myConn = New SqlConnection(machainedeconnexion)

        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT * FROM REGION order by STR_NOMREGION"

        myConn.Open()
        myReader = myCmd.ExecuteReader()

        If (myReader.Read()) Then
            cb.Items.Add(myReader.GetDecimal(0) & " - " & myReader.GetString(2))
        End If

        Do While myReader.Read()
            cb.Items.Add(myReader.GetDecimal(0) & " - " & myReader.GetString(2))
        Loop

        myReader.Close()
        myConn.Close()
    End Sub

    Public Sub Fill_Departement(cb As ComboBox)

        myConn = New SqlConnection(machainedeconnexion)

        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT * FROM DEPARTEMENT order by STR_NOMDEPARTEMENT"

        myConn.Open()
        myReader = myCmd.ExecuteReader()

        If (myReader.Read()) Then
            cb.Items.Add(myReader.GetDecimal(0) & " - " & myReader.GetString(2))
        End If

        Do While myReader.Read()
            cb.Items.Add(myReader.GetDecimal(0) & " - " & myReader.GetString(2))
        Loop

        myReader.Close()
        myConn.Close()
    End Sub


    Public Sub Fill_Ville(cb As ComboBox)

        myConn = New SqlConnection(machainedeconnexion)

        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT * FROM VILLE order by STR_NOMVILLE"

        myConn.Open()
        myReader = myCmd.ExecuteReader()

        If (myReader.Read()) Then
            cb.Items.Add(myReader.GetDecimal(0) & " - " & myReader.GetString(2))
        End If

        Do While myReader.Read()
            cb.Items.Add(myReader.GetDecimal(0) & " - " & myReader.GetString(2))
        Loop

        myReader.Close()
        myConn.Close()

    End Sub

    Public Sub Fill_Plage(cb As ComboBox)

        myConn = New SqlConnection(machainedeconnexion)

        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT * FROM PLAGE order by STR_NOM_PLAGE"

        myConn.Open()
        myReader = myCmd.ExecuteReader()

        If (myReader.Read()) Then
            cb.Items.Add(myReader.GetDecimal(0) & " - " & myReader.GetString(2))
        End If

        Do While myReader.Read()
            cb.Items.Add(myReader.GetDecimal(0) & " - " & myReader.GetString(2))
        Loop

        myReader.Close()
        myConn.Close()

    End Sub


    Public Sub Fill_NTerrain(cb As ComboBox)

        myConn = New SqlConnection(machainedeconnexion)

        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT * FROM NATURE_TERRAIN order by STR_NATURE_TERRAIN"

        myConn.Open()
        myReader = myCmd.ExecuteReader()

        If (myReader.Read()) Then
            cb.Items.Add(myReader.GetDecimal(0) & " - " & myReader.GetString(1))
        End If

        Do While myReader.Read()
            cb.Items.Add(myReader.GetDecimal(0) & " - " & myReader.GetString(1))
        Loop

        myReader.Close()
        myConn.Close()

    End Sub

    '-----------------------------------------------------------------------
    '-----------------------------------------------------------------------
    ' GO GO GO
    '-----------------------------------------------------------------------
    '-----------------------------------------------------------------------

    Public Sub Creer_Responsable()
        Lbl_Titre.Text = "AJOUTER RESPONSABLE"

        Manage_Display()

        Lbl_Saisir2.Visible = False
        CB_Selection.Visible = False

        Lbl_Saisir0.Text = "Liste des responsables actuels"

        CB_Info.Text = "Liste des responsables"
        Fill_Responsable(CB_Info)

        Lbl_Saisir1.Text = "Nom du responsable"

    End Sub


    Public Sub Creer_Region()
        Lbl_Titre.Text = "AJOUTER REGION"

        Manage_Display()

        Lbl_Saisir0.Text = "Liste des régions actuelles"

        CB_Info.Text = "Liste des régions"
        Fill_Region(CB_Info)

        Lbl_Saisir1.Text = "Nom de la région"
        Lbl_Saisir2.Text = "Affecter un responsable à la région"
        Lbl_Saisir2.Visible = True

        CB_Selection.Text = "Choisir Responsable"
        Fill_Responsable(CB_Selection)
    End Sub
    Public Sub Creer_Departement()
        Lbl_Titre.Text = "AJOUTER DEPARTEMENT"

        Manage_Display()

        Lbl_Saisir0.Text = "Liste des départements actuels"

        CB_Info.Text = "Liste des départements"
        Fill_Departement(CB_Info)

        Lbl_Saisir1.Text = "Nom du département"

        Lbl_Saisir2.Text = "Affecter une région au département"
        Lbl_Saisir2.Visible = True

        CB_Selection.Text = "Choisir Region"
        Fill_Region(CB_Selection)
    End Sub


    Public Sub Creer_Ville()
        Lbl_Titre.Text = "AJOUTER VILLE"

        Manage_Display()

        Lbl_InfoSupplementaire1.Text = "Code Postal"
        Lbl_InfoSupplementaire2.Text = "Nombre de touristes par an"
        Lbl_InfoSupplementaire1.Visible = True
        Lbl_InfoSupplementaire2.Visible = True
        TxtBox_InfoSupplementaire1.Visible = True
        TxtBox_InfoSupplementaire2.Visible = True


        Lbl_Saisir0.Text = "Liste des villes actuelles"

        CB_Info.Text = "Liste des villes"
        Fill_Ville(CB_Info)

        Lbl_Saisir1.Text = "Nom de la ville"

        Lbl_Saisir2.Text = "Affecter un département à une ville"
        Lbl_Saisir2.Visible = True

        CB_Selection.Text = "Choisir Departement"
        Fill_Departement(CB_Selection)
    End Sub

    Public Sub Creer_Plage()
        Lbl_Titre.Text = "AJOUTER PLAGE"

        Manage_Display()

        Lbl_InfoSupplementaire1.Text = "Longueur de la plage"
        Lbl_InfoSupplementaire1.Visible = True
        TxtBox_InfoSupplementaire1.Visible = True

        Lbl_Saisir0.Text = "Liste des plages actuelles"

        CB_Info.Text = "Liste des plages"
        Fill_Plage(CB_Info)

        Lbl_Saisir1.Text = "Nom de la plage"

        Lbl_Saisir2.Text = "Affecter une ville à une plage"
        Lbl_Saisir2.Visible = True

        CB_Selection.Text = "Choisir Ville"
        Fill_Ville(CB_Selection)
    End Sub

    Public Sub Creer_NTerrain()
        Lbl_Titre.Text = "AJOUTER NATURE TERRAIN"

        Manage_Display()

        Lbl_Saisir0.Text = "Liste des natures de terrain actuelles"

        CB_Info.Text = "Liste des natures de terrain"
        Fill_NTerrain(CB_Info)

        Lbl_Saisir1.Text = "Nom de la nature du terrain"

        'Lbl_Saisir2.Text = "Affecter une plage à une nature de terrain"
        'Lbl_Saisir2.Visible = True

        'Fill_Plage(CB_Selection)

        Lbl_Saisir2.Visible = False
        CB_Selection.Visible = False

    End Sub

    Public Sub Manage_Display()
        Lbl_InfoSupplementaire1.Visible = False
        Lbl_InfoSupplementaire2.Visible = False
        TxtBox_InfoSupplementaire1.Visible = False
        TxtBox_InfoSupplementaire2.Visible = False

        TxtBox_InfoSupplementaire1.Text = ""
        TxtBox_InfoSupplementaire2.Text = ""

        CB_Info.Items.Clear()
        CB_Selection.Items.Clear()
        CB_Selection.Visible = True
    End Sub

End Class