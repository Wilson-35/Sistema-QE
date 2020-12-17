Imports System.ComponentModel
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Categoria
#Region "Agregar Columnas"
    Private _Id As Integer
    Public Property Id_Categoria As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Private _Descripción As String
    Public Property Descripción As String
        Get
            Return _Descripción
        End Get
        Set(value As String)
            _Descripción = value
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

    Public Shared Function RecuperarTodasLasCategorias() As BindingList(Of Categoria)
        Dim Retorno As New BindingList(Of Categoria)

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_ConsultarCategoria"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParId", 0)

            Dim Lector As MySqlDataReader
            Lector = Comando.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read
                    Dim Obj As New Categoria

                    Obj.Id_Categoria = Lector.GetValue(0)
                    Obj.Descripción = Lector.GetValue(1)

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

    Public Shared Function RecuperarUnaCategoria(ByVal Id_Categoria As Integer) As Categoria
        Dim Retorno As New Categoria

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_ConsultarCategoria"
            Comando.Parameters.AddWithValue("ParOpcion", 2)
            Comando.Parameters.AddWithValue("ParId", Id_Categoria)

            Dim Lector As MySqlDataReader
            Lector = Comando.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read

                    Retorno.Id_Categoria = Lector.GetValue(0)
                    Retorno.Descripción = Lector.GetValue(1)
                    Retorno.Fecha = Lector.GetValue(2)

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

    Public Shared Function InsertarCategoria(ByVal ObjCategoria As Categoria) As Integer
        Dim Retorno As Integer

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_InsertarCategoria"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParDescripción", ObjCategoria.Descripción)
            Comando.Parameters.AddWithValue("ParFecha", ObjCategoria.Fecha)

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

    Public Shared Sub EditarCategoria(ByVal ObjCategoria As Categoria)

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_EditarCategoria"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParDescripción", ObjCategoria.Descripción)
            Comando.Parameters.AddWithValue("ParFecha", ObjCategoria.Fecha)
            Comando.Parameters.AddWithValue("ParId", ObjCategoria.Id_Categoria)

            Comando.ExecuteNonQuery()

        Catch ex As Exception
            Throw
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try

    End Sub

    Public Shared Sub EliminarCategoria(ByVal ObjCategoria As Categoria)

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_EliminarCategoria"
            Comando.Parameters.AddWithValue("ParOpcion", 1)

            Comando.Parameters.AddWithValue("ParId", ObjCategoria.Id_Categoria)

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
