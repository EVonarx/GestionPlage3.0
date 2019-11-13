Imports System.Data.SqlClient

Public Class Frm_Associer


    Dim Temp_ID_Responsable As Integer = 0
    Dim Temp_ID_Plage As Integer = 0

    Private Sub Frm_Associer_Load(sender As Object, e As EventArgs) Handles MyBase.Load, MyBase.VisibleChanged

        Lbl_Info.Text = ""
        TxtBox_Info.Text = ""
        Lbl_Selection.Text = ""
        CB_Selection1.Text = ""
        CB_Selection2.Text = ""
        CB_Selection1.Items.Clear()
        CB_Selection2.Items.Clear()

        If ParamAjouter = "ResponsableRegion" Then
            Lbl_Info.Text = "Actuellement ce responsable s'occupe des régions suivantes :"
            Lbl_Selection.Text = "Associez Responsable et Région"
            CB_Selection1.Text = "Choissir Responsable"
            CB_Selection2.Text = "Choissir Région"
            Frm_Ajouter.Fill_Responsable(CB_Selection1)
            Frm_Ajouter.Fill_Region(CB_Selection2)
        End If

        If ParamAjouter = "PlageNatureTerrain" Then
            Lbl_Info.Text = "Actuellement cette plage a pour nature de terrain :"
            Lbl_Info.Text = ""
            Lbl_Selection.Text = "Associez Plage et Nature du terrain"
            CB_Selection1.Text = "Choissir Plage"
            CB_Selection2.Text = "Choissir Nature terrain"
            Frm_Ajouter.Fill_Plage(CB_Selection1)
            Frm_Ajouter.Fill_NTerrain(CB_Selection2)
        End If

    End Sub

    Private Sub Btn_OK_Click(sender As Object, e As EventArgs) Handles Btn_OK.Click

        'update ville set I_CodePostal = '50400' where id_ville = 17
        If ParamAjouter = "ResponsableRegion" Then
            'Responsable
            Dim temp1() As String = Split(CB_Selection1.Text, "-")
            'Région
            Dim temp2() As String = Split(CB_Selection2.Text, "-")

            'on cherche idResponsable selectionné
            Dim idResponsableS As Integer = temp1(0)

            'on update idResponsable dans la table Région où IdRegion = IdRegion sélectionné
            Dim IdRegionS As Integer = temp2(0)


            myConn = New SqlConnection(machainedeconnexion)

            myCmd = myConn.CreateCommand
            myCmd.CommandText = "update Region set Id_Responsable = " & temp1(0) & "where id_Region = " & temp2(0) & ""

            myConn.Open()
            myReader = myCmd.ExecuteReader()

            myReader.Close()
            myConn.Close()
        End If

        If ParamAjouter = "PlageNatureTerrain" Then
            'Plage
            Dim temp1() As String = Split(CB_Selection1.Text, "-")
            'NTerrain
            Dim temp2() As String = Split(CB_Selection2.Text, "-")

            'on cherche idPlage selectionné
            Dim idPlageS As Integer = temp1(0)

            'on cherche idNatureTerrain selectionné
            Dim IdNatureTerrainS As Integer = temp2(0)


            myConn = New SqlConnection(machainedeconnexion)

            myCmd = myConn.CreateCommand
            'on insert idPlage et IdNatureTerrain dans la table EstComposéDe
            myCmd.CommandText = "INSERT INTO Est_Compose_De VALUES ('" & temp1(0) & "', '" & temp2(0) & "')"

            myConn.Open()
            myReader = myCmd.ExecuteReader()

            myReader.Close()
            myConn.Close()

        End If

        Me.Hide()
        Frm_AjoutModifSupp.Show()

    End Sub

    Private Sub Btn_Annuler_Click(sender As Object, e As EventArgs) Handles Btn_Annuler.Click
        Me.Hide()
        Frm_AjoutModifSupp.Show()
    End Sub

    Private Sub CB_Selection1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CB_Selection1.SelectedIndexChanged


        Dim Temp_ID_NPlage() As Integer = {0, 0, 0, 0, 0}
        TxtBox_Info.Text = ""

        If ParamAjouter = "ResponsableRegion" Then

            Dim temp() As String = Split(CB_Selection1.Text, "-")
            Temp_ID_Responsable = temp(0)

            TxtBox_Info.Text = ""

            myConn = New SqlConnection(machainedeconnexion)

            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT * FROM REGION WHERE ID_RESPONSABLE = " & Temp_ID_Responsable

            myConn.Open()
            myReader = myCmd.ExecuteReader()

            Do While myReader.Read()
                TxtBox_Info.Text = TxtBox_Info.Text & " + " & myReader.GetString(2) & vbCrLf
            Loop


            myReader.Close()
            myConn.Close()
        End If

        If ParamAjouter = "PlageNatureTerrain" Then
            Dim temp() As String = Split(CB_Selection1.Text, "-")
            Temp_ID_Plage = temp(0)

            TxtBox_Info.Text = ""


            Dim i As Integer = 0

            myConn = New SqlConnection(machainedeconnexion)

            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT * FROM EST_COMPOSE_DE WHERE ID_PLAGE= " & Temp_ID_Plage

            myConn.Open()
            myReader = myCmd.ExecuteReader()

            Do While myReader.Read()
                Temp_ID_NPlage(i) = myReader.GetDecimal(1)
                i = i + 1
            Loop

            myReader.Close()
            myConn.Close()



            myConn = New SqlConnection(machainedeconnexion)

            myCmd = myConn.CreateCommand
            myCmd.CommandText = "SELECT * FROM NATURE_TERRAIN WHERE ID_NATURE_TERRAIN in (" & Temp_ID_NPlage(0) & ", " & Temp_ID_NPlage(1) & ", " & Temp_ID_NPlage(2) & ", " & Temp_ID_NPlage(3) & ", " & Temp_ID_NPlage(4) & ")"

            myConn.Open()
            myReader = myCmd.ExecuteReader()

            Do While myReader.Read()
                TxtBox_Info.Text = TxtBox_Info.Text & " + " & myReader.GetString(1) & vbCrLf
            Loop

            myReader.Close()
            myConn.Close()

        End If
    End Sub
End Class