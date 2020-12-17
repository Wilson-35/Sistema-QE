Imports System.ComponentModel
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Usuario1
#Region "Agregar Columnas"
    Private _Id As Integer
    Public Property Id_Usuario As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Private _Nombre As String
    Public Property Nombre As String
        Get
            Return _Nombre
        End Get
        Set(value As String)
            _Nombre = value
        End Set
    End Property

    Private _NombreUsuario As String
    Public Property NombreUsuario As String
        Get
            Return _NombreUsuario
        End Get
        Set(value As String)
            _NombreUsuario = value
        End Set
    End Property


    Private _PasswordUsuario As String
    Public Property PasswordUsuario As String
        Get
            Return _PasswordUsuario
        End Get
        Set(value As String)
            _PasswordUsuario = value
        End Set
    End Property

    Private _Cargo As String
    Public Property Cargo As String
        Get
            Return _Cargo
        End Get
        Set(value As String)
            _Cargo = value
        End Set
    End Property

    Private _Correo_Electronico As String
    Public Property Correo_Electronico As String
        Get
            Return _Correo_Electronico
        End Get
        Set(value As String)
            _Correo_Electronico = value
        End Set
    End Property

    Private _Contacto As String
    Public Property Contacto As String
        Get
            Return _Contacto
        End Get
        Set(value As String)
            _Contacto = value
        End Set
    End Property

    Private _Estado As Integer
    Public Property Estado As Integer
        Get
            Return _Estado
        End Get
        Set(value As Integer)
            _Estado = value
        End Set
    End Property

    Private _Nivel As Integer
    Public Property Nivel As Integer
        Get
            Return _Nivel
        End Get
        Set(value As Integer)
            _Nivel = value
        End Set
    End Property

    Private _Fecha As Date
    Public Property Fecha As Date
        Get
            Return _Fecha
        End Get
        Set(value As Date)
            _Fecha = value
        End Set
    End Property


#End Region

    Public Shared Function RecuperarTodosLosUsuarios() As BindingList(Of Usuario1)
        Dim Retorno As New BindingList(Of Usuario1)

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_ConsultarUsuario"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParId", 0)

            Dim Lector As MySqlDataReader
            Lector = Comando.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read
                    Dim Obj As New Usuario1

                    Obj.Id_Usuario = Lector.GetValue(0)
                    Obj.Nombre = Lector.GetValue(1)

                    Retorno.Add(Obj)
                End While
            End If

        Catch ex As Exception
            Throw
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try

        Return Retorno
    End Function

    Public Shared Function RecuperarUnUsuario(ByVal Id_Usuario As Integer) As Usuario1
        Dim Retorno As New Usuario1

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_ConsultarUsuario"
            Comando.Parameters.AddWithValue("ParOpcion", 2)
            Comando.Parameters.AddWithValue("ParId", Id_Usuario)

            Dim Lector As MySqlDataReader
            Lector = Comando.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read

                    Retorno.Id_Usuario = Lector.GetValue(0)
                    Retorno.Nombre = Lector.GetValue(1)
                    Retorno.NombreUsuario = Lector.GetValue(2)
                    Retorno.PasswordUsuario = Lector.GetValue(3)
                    Retorno.Cargo = Lector.GetValue(4)
                    Retorno.Correo_Electronico = Lector.GetValue(5)
                    Retorno.Contacto = Lector.GetValue(6)
                    Retorno.Estado = Lector.GetValue(7)
                    Retorno.Nivel = Lector.GetValue(8)
                    Retorno.Fecha = Lector.GetValue(9)

                End While
            End If

        Catch ex As Exception
            Throw
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try

        Return Retorno
    End Function

    Public Shared Function InsertarUsuario(ByVal ObjUsuario As Usuario1) As Integer
        Dim Retorno As Integer

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_InsertarUsuario"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParNombre", ObjUsuario.Nombre)
            Comando.Parameters.AddWithValue("ParNombreUsuario", ObjUsuario.NombreUsuario)
            Comando.Parameters.AddWithValue("ParPasswordUsuario", ObjUsuario.PasswordUsuario)
            Comando.Parameters.AddWithValue("ParCargo", ObjUsuario.Cargo)
            Comando.Parameters.AddWithValue("ParCorreoElectronico", ObjUsuario.Correo_Electronico)
            Comando.Parameters.AddWithValue("ParContacto", ObjUsuario.Contacto)
            Comando.Parameters.AddWithValue("ParEstado", ObjUsuario.Estado)
            Comando.Parameters.AddWithValue("ParNivel", ObjUsuario.Nivel)
            Comando.Parameters.AddWithValue("ParFecha", ObjUsuario.Fecha)

            Retorno = Comando.ExecuteScalar

        Catch ex As Exception
            Throw
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try

        Return Retorno
    End Function


    Public Shared Sub EditarUsuario(ByVal ObjUsuario As Usuario1)

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_EditarUsuario"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParNombre", ObjUsuario.Nombre)
            Comando.Parameters.AddWithValue("ParNombreUsuario", ObjUsuario.NombreUsuario)
            Comando.Parameters.AddWithValue("ParPasswordUsuario", ObjUsuario.PasswordUsuario)
            Comando.Parameters.AddWithValue("ParCargo", ObjUsuario.Cargo)
            Comando.Parameters.AddWithValue("ParCorreoElectronico", ObjUsuario.Correo_Electronico)
            Comando.Parameters.AddWithValue("ParContacto", ObjUsuario.Contacto)
            Comando.Parameters.AddWithValue("ParEstado", ObjUsuario.Estado)
            Comando.Parameters.AddWithValue("ParNivel", ObjUsuario.Nivel)
            Comando.Parameters.AddWithValue("ParFecha", ObjUsuario.Fecha)
            Comando.Parameters.AddWithValue("ParId", ObjUsuario.Id_Usuario)

            Comando.ExecuteNonQuery()

        Catch ex As Exception
            Throw
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try

    End Sub

    Public Shared Sub EliminarUsuario(ByVal ObjUsuario As Usuario1)

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_EliminarUsuario"
            Comando.Parameters.AddWithValue("ParOpcion", 1)

            Comando.Parameters.AddWithValue("ParId", ObjUsuario.Id_Usuario)

            Comando.ExecuteNonQuery()

        Catch ex As Exception
            Throw
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try

    End Sub
End Class



