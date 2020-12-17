Imports System.ComponentModel
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Almacen
#Region "AgregarColumnas"
    Private _Id As Integer
    Public Property Id_Almacen As Integer
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

    Private _Marca As String
    Public Property Marca As String
        Get
            Return _Marca
        End Get
        Set(value As String)
            _Marca = value
        End Set
    End Property


    Private _Categoria As String
    Public Property Categoria As String
        Get
            Return _Categoria
        End Get
        Set(value As String)
            _Categoria = value
        End Set
    End Property


    Private _CantidadLitro As String
    Public Property CantidadLitro As String
        Get
            Return _CantidadLitro
        End Get
        Set(value As String)
            _CantidadLitro = value
        End Set
    End Property


    Private _CantidadKilo As String
    Public Property CantidadKilo As String
        Get
            Return _CantidadKilo
        End Get
        Set(value As String)
            _CantidadKilo = value
        End Set
    End Property

    Private _PrecioCosto As Double
    Public Property PrecioCosto As Double
        Get
            Return _PrecioCosto
        End Get
        Set(value As Double)
            _PrecioCosto = value
        End Set
    End Property


    Private _PrecioReventa As Double
    Public Property PrecioReventa As Double
        Get
            Return _PrecioReventa
        End Get
        Set(value As Double)
            _PrecioReventa = value
        End Set
    End Property

    Private _PrecioLitro As Double
    Public Property PrecioLitro As Double
        Get
            Return _PrecioLitro
        End Get
        Set(value As Double)
            _PrecioLitro = value
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

    Public Shared Function RecuperarTodosLosAlmacenes() As BindingList(Of Almacen)
        Dim Retorno As New BindingList(Of Almacen)

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_ConsultarAlmacen"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParId", 0)

            Dim Lector As MySqlDataReader
            Lector = Comando.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read
                    Dim Obj As New Almacen

                    Obj.Id_Almacen = Lector.GetValue(0)
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

    Public Shared Function RecuperarUnAlmacen(ByVal Id_Almacen As Integer) As Almacen
        Dim Retorno As New Almacen

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_ConsultarAlmacen"
            Comando.Parameters.AddWithValue("ParOpcion", 2)
            Comando.Parameters.AddWithValue("ParId", Id_Almacen)

            Dim Lector As MySqlDataReader
            Lector = Comando.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read

                    Retorno.Id_Almacen = Lector.GetValue(0)
                    Retorno.Descripción = Lector.GetValue(1)
                    Retorno.Marca = Lector.GetValue(2)
                    Retorno.Categoria = Lector.GetValue(3)
                    Retorno.CantidadLitro = Lector.GetValue(4)
                    Retorno.CantidadKilo = Lector.GetValue(5)
                    Retorno.PrecioCosto = Lector.GetValue(6)
                    Retorno.PrecioReventa = Lector.GetValue(7)
                    Retorno.PrecioLitro = Lector.GetValue(8)
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

    Public Shared Function InsertarAlmacen(ByVal ObjAlmacen As Almacen) As Integer
        Dim Retorno As Integer

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_InsertarAlmacen"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParDescripción", ObjAlmacen.Descripción)
            Comando.Parameters.AddWithValue("ParIdMarca", ObjAlmacen.Marca)
            Comando.Parameters.AddWithValue("ParIdCategoria", ObjAlmacen.Categoria)
            Comando.Parameters.AddWithValue("ParCantidadLitro", ObjAlmacen.CantidadLitro)
            Comando.Parameters.AddWithValue("ParCantidadKilo", ObjAlmacen.CantidadKilo)
            Comando.Parameters.AddWithValue("ParPrecioCosto", ObjAlmacen.PrecioCosto)
            Comando.Parameters.AddWithValue("ParPrecioReventa", ObjAlmacen.PrecioReventa)
            Comando.Parameters.AddWithValue("ParPrecioLitro", ObjAlmacen.PrecioLitro)
            Comando.Parameters.AddWithValue("ParFecha", ObjAlmacen.Fecha)

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

    Public Shared Sub EditarAlmacen(ByVal ObjAlmacen As Almacen)

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_EditarAlmacen"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParDescripción", ObjAlmacen.Descripción)
            Comando.Parameters.AddWithValue("ParIdMarca", ObjAlmacen.Marca)
            Comando.Parameters.AddWithValue("ParIdCategoria", ObjAlmacen.Categoria)
            Comando.Parameters.AddWithValue("ParCantidadLitro", ObjAlmacen.CantidadLitro)
            Comando.Parameters.AddWithValue("ParCantidadKilo", ObjAlmacen.CantidadKilo)
            Comando.Parameters.AddWithValue("ParPrecioCosto", ObjAlmacen.PrecioCosto)
            Comando.Parameters.AddWithValue("ParPrecioReventa", ObjAlmacen.PrecioReventa)
            Comando.Parameters.AddWithValue("ParPrecioLitro", ObjAlmacen.PrecioLitro)
            Comando.Parameters.AddWithValue("ParFecha", ObjAlmacen.Fecha)
            Comando.Parameters.AddWithValue("ParId", ObjAlmacen.Id_Almacen)


            Comando.ExecuteNonQuery()

        Catch ex As Exception
            Throw
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try

    End Sub

    Public Shared Sub EliminarAlmacen(ByVal ObjAlmacen As Almacen)

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_EliminarAlmacen"
            Comando.Parameters.AddWithValue("ParOpcion", 1)

            Comando.Parameters.AddWithValue("ParId", ObjAlmacen.Id_Almacen)

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
