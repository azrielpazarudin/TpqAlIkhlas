Imports System.Data.SqlClient
Module Module1
    Public Conn As SqlConnection
    Public Da As SqlDataAdapter
    Public Ds As DataSet
    Public Cmd As SqlCommand
    Public Rd As SqlDataReader
    Public MyDb As String
    Public Sub connection()
        MyDb = "Data Source=DESKTOP-DNL0I54;initial catalog=tpqAlikhlas;integrated security=true"
        Conn = New SqlConnection(MyDb)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

End Module
