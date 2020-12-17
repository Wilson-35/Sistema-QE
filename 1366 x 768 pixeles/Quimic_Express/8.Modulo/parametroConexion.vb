Imports MySql.Data.MySqlClient
Module parametroConexion
    Public operacionABM As String
    Public codigoABM As String
    Public conexion As MySqlConnection
    Public usuario As String
    Public idOperacion As String
    Public codigoUsuario As String
    Public nombreUsuario As String
    Public nivelUsuario As String
    Public estadoUsuario As String
    Public Permiso As String

    Public Sub abrirConexion()
        Dim servidor As String = "localhost"
        Dim usuarioP As String = "root"
        Dim password As String = "1234"
        Dim baseDatos As String = "quimicexpress"
        Dim puerto As String = "3305"
        Dim url As String
        url = "server=" & servidor & "; user=" & usuarioP & "; password=" &
            password & "; database=" & baseDatos & ";  port= " & puerto & ";"
        Try
            conexion = New MySqlConnection
            conexion.ConnectionString = url
            conexion.Open()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub cerrarConexion()
        Try
            conexion.Close()
        Catch ex As MySqlException
            MsgBox(ex.Message)
        End Try
    End Sub
End Module
