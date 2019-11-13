Imports System.Data.SqlClient

Public Class Frm_Plages
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Frm_Start.Show()
    End Sub

    Private Sub Frm_Plages_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim param0 As String = ""
        Dim param2 As String = ""
        Dim param3 As String = ""
        Dim param4 As String = ""
        Dim param5 As String = ""
        Dim param6 As String = ""
        Dim param7 As String = ""
        Dim temp_length As Integer = 0
        Dim temp_fill As String = ""

        TextBox1.Text = ""

        myConn = New SqlConnection(machainedeconnexion)

        myCmd = myConn.CreateCommand
        myCmd.CommandText = "Select STR_NOM_PLAGE, D_LONGUEUR_PLAGE, STR_NATURE_TERRAIN, STR_NOMVILLE, I_NBTOURISTE, STR_NOMDEPARTEMENT, STR_NOMREGION, STR_NOMRESPONSABLE from Plage 
inner Join EST_COMPOSE_DE on EST_COMPOSE_DE.ID_PLAGE = PLAGE.ID_PLAGE
inner Join NATURE_TERRAIN on NATURE_TERRAIN.ID_NATURE_TERRAIN = EST_COMPOSE_DE.ID_NATURE_TERRAIN
inner Join VILLE on VILLE.ID_VILLE = PLAGE.ID_Ville
inner Join DEPARTEMENT on DEPARTEMENT.ID_DEPARTEMENT = VILLE.ID_DEPARTEMENT
inner Join REGION on REGION.ID_REGION = DEPARTEMENT.ID_REGION
inner Join RESPONSABLE on RESPONSABLE.ID_RESPONSABLE = REGION.ID_RESPONSABLE
order by STR_NOM_PLAGE, D_LONGUEUR_PLAGE, STR_NATURE_TERRAIN, STR_NOMVILLE, I_NBTOURISTE, STR_NOMDEPARTEMENT, STR_NOMREGION, STR_NOMRESPONSABLE"



        myConn.Open()
        myReader = myCmd.ExecuteReader()
        While (myReader.Read())

            temp_length = (myReader.GetString(0)).Length()
            For i As Integer = temp_length To 19
                temp_fill += " "
            Next
            param0 = myReader.GetString(0) & temp_fill


            temp_fill = ""
            temp_length = (myReader.GetString(2)).Length()
            For i As Integer = temp_length To 14
                temp_fill += " "
            Next
            param2 = myReader.GetString(2) & temp_fill

            temp_fill = ""
            temp_length = (myReader.GetString(3)).Length()
            For i As Integer = temp_length To 14
                temp_fill += " "
            Next
            param3 = myReader.GetString(3) & temp_fill

            temp_fill = ""
            temp_length = (myReader.GetString(5)).Length()
            For i As Integer = temp_length To 14
                temp_fill += " "
            Next
            param5 = myReader.GetString(5) & temp_fill

            temp_fill = ""
            temp_length = (myReader.GetString(6)).Length()
            For i As Integer = temp_length To 14
                temp_fill += " "
            Next
            param6 = myReader.GetString(6) & temp_fill

            temp_fill = ""
            temp_length = (myReader.GetString(7)).Length()
            For i As Integer = temp_length To 14
                temp_fill += " "
            Next
            param7 = myReader.GetString(7) & temp_fill


            TextBox1.Text = TextBox1.Text & param0 & " ---      " & param2 & " ---      " & param3 & " ---      " & param5 & " ---      " & param6 & " ---      " & param7 & vbCrLf
            temp_fill = ""


        End While

        TextBox1.AppendText("FIN")
        myConn.Close()


    End Sub
End Class