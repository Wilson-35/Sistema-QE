Imports System.ComponentModel
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Marca
#Region "Agregar Columnas"
    Private _Id As Integer
    Public Property Id_Marca As Integer
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

    Public Shared Function RecuperarTodasLasMarcas() As BindingList(Of Marca)
        Dim Retorno As New BindingList(Of Marca)

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_ConsultarMarca"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParId", 0)

            Dim Lector As MySqlDataReader
            Lector = Comando.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read
                    Dim Obj As New Marca

                    Obj.Id_Marca = Lector.GetValue(0)
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

    Public Shared Function RecuperarUnaMarca(ByVal Id_Marca As Integer) As Marca
        Dim Retorno As New Marca

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_ConsultarMarca"
            Comando.Parameters.AddWithValue("ParOpcion", 2)
            Comando.Parameters.AddWithValue("ParId", Id_Marca)

            Dim Lector As MySqlDataReader
            Lector = Comando.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read

                    Retorno.Id_Marca = Lector.GetValue(0)
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

    Public Shared Function InsertarMarca(ByVal ObjMarca As Marca) As Integer
        Dim Retorno As Integer

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_InsertarMarca"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParDescripción", ObjMarca.Descripción)
            Comando.Parameters.AddWithValue("ParFecha", ObjMarca.Fecha)

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

    Public Shared Sub EditarMarca(ByVal ObjMarca As Marca)

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_EditarMarca"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParDescripción", ObjMarca.Descripción)
            Comando.Parameters.AddWithValue("ParFecha", ObjMarca.Fecha)
            Comando.Parameters.AddWithValue("ParId", ObjMarca.Id_Marca)

            Comando.ExecuteNonQuery()

        Catch ex As Exception
            Throw
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try

    End Sub

    Public Shared Sub EliminarMarca(ByVal ObjMarca As Marca)

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_EliminarMarca"
            Comando.Parameters.AddWithValue("ParOpcion", 1)

            Comando.Parameters.AddWithValue("ParId", ObjMarca.Id_Marca)

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



