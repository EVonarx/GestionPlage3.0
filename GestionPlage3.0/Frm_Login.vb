Imports System.Data.SqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class Frm_Login

    'Le bouton pour valider son authentification
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim login As String = TxtLogin.Text
        Dim passwd As String = MD5Hash(TxtPasswd.Text)
        Dim authentificationOK As Boolean = False

        myConn = New SqlConnection(machainedeconnexion)

        myCmd = myConn.CreateCommand

        myCmd.CommandText = "SELECT * FROM ACCES"

        myConn.Open()
        myReader = myCmd.ExecuteReader()


        Do While myReader.Read()
            If (StrComp(myReader.GetString(1), login, CompareMethod.Text) = 0) And (StrComp(myReader.GetString(2), passwd, CompareMethod.Text) = 0) Then
                authentificationOK = True
            End If
        Loop

        myReader.Close()
        myConn.Close()

        If (authentificationOK) Then
            Me.Hide()
            Frm_Start.Show()
        Else
            LblError.Visible = True
        End If


    End Sub

    Function MD5Hash(ByVal password As String)
        Dim md5 As MD5 = New MD5CryptoServiceProvider()
        Dim result As Byte()
        result = md5.ComputeHash(Encoding.ASCII.GetBytes(password))

        Dim strBuilder As New StringBuilder()

        For i As Integer = 0 To result.Length - 1
            strBuilder.Append(result(i).ToString("x2"))
        Next



        Return strBuilder.ToString()
    End Function


End Class