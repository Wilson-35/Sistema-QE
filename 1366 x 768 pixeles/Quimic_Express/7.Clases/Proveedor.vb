Imports System.ComponentModel
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Proveedor
#Region "Agregar Columnas"
    Private _Id As Integer
    Public Property Id_Proveedor As Integer
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

    Private _Dirección As String
    Public Property Dirección As String
        Get
            Return _Dirección
        End Get
        Set(value As String)
            _Dirección = value
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

    Private _Ruc As String
    Public Property Ruc As String
        Get
            Return _Ruc
        End Get
        Set(value As String)
            _Ruc = value
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

    Public Shared Function RecuperarTodosLosProveedores() As BindingList(Of Proveedor)
        Dim Retorno As New BindingList(Of Proveedor)

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_ConsultarProveedor"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParId", 0)

            Dim Lector As MySqlDataReader
            Lector = Comando.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read
                    Dim Obj As New Proveedor

                    Obj.Id_Proveedor = Lector.GetValue(0)
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

    Public Shared Function RecuperarUnProveedor(ByVal Id_Proveedor As Integer) As Proveedor
        Dim Retorno As New Proveedor

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_ConsultarProveedor"
            Comando.Parameters.AddWithValue("ParOpcion", 2)
            Comando.Parameters.AddWithValue("ParId", Id_Proveedor)

            Dim Lector As MySqlDataReader
            Lector = Comando.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read

                    Retorno.Id_Proveedor = Lector.GetValue(0)
                    Retorno.Nombre = Lector.GetValue(1)
                    Retorno.Dirección = Lector.GetValue(2)
                    Retorno.Contacto = Lector.GetValue(3)
                    Retorno.Ruc = Lector.GetValue(4)
                    Retorno.Fecha = Lector.GetValue(5)

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

    Public Shared Function InsertarProveedor(ByVal ObjProveedor As Proveedor) As Integer
        Dim Retorno As Integer

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_InsertarProveedor"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParNombre", ObjProveedor.Nombre)
            Comando.Parameters.AddWithValue("ParDirección", ObjProveedor.Dirección)
            Comando.Parameters.AddWithValue("ParContacto", ObjProveedor.Contacto)
            Comando.Parameters.AddWithValue("ParRuc", ObjProveedor.Ruc)
            Comando.Parameters.AddWithValue("ParFecha", ObjProveedor.Fecha)

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


    Public Shared Sub EditarProveedor(ByVal ObjProveedor As Proveedor)

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_EditarProveedor"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParNombre", ObjProveedor.Nombre)
            Comando.Parameters.AddWithValue("ParDirección", ObjProveedor.Dirección)
            Comando.Parameters.AddWithValue("ParContacto", ObjProveedor.Contacto)
            Comando.Parameters.AddWithValue("ParRuc", ObjProveedor.Ruc)
            Comando.Parameters.AddWithValue("ParFecha", ObjProveedor.Fecha)
            Comando.Parameters.AddWithValue("ParId", ObjProveedor.Id_Proveedor)

            Comando.ExecuteNonQuery()

        Catch ex As Exception
            Throw
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try

    End Sub

    Public Shared Sub EliminarProveedor(ByVal ObjProveedor As Proveedor)

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_EliminarProveedor"
            Comando.Parameters.AddWithValue("ParOpcion", 1)

            Comando.Parameters.AddWithValue("ParId", ObjProveedor.Id_Proveedor)

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


