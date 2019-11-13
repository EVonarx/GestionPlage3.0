Imports System.Data.SqlClient

Module Variables
    Public str_Nom As String = ""
    Public myConn As SqlConnection
    Public myCmd As SqlCommand
    Public myReader As SqlDataReader
    Public results As String
    Public machainedeconnexion = "Initial Catalog=GestionPlage3.0;Data Source=DESKTOP-ERIC\SQLEXPRESS;Integrated Security=SSPI;"

    Public ParamAjouter As String

End Module

