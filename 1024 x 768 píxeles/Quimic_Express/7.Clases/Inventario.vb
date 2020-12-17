Imports System.ComponentModel
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Inventario
#Region "Agregar Columnas"
    Private _Id As Integer
    Public Property Id_Inventario As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Private _Codigo_Barra As String
    Public Property Codigo_Barra As String
        Get
            Return _Codigo_Barra
        End Get
        Set(value As String)
            _Codigo_Barra = value
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


    Private _Proveedor As String
    Public Property Proveedor As String
        Get
            Return _Proveedor
        End Get
        Set(value As String)
            _Proveedor = value
        End Set
    End Property

    Private _Precio_Costo As Double
    Public Property Precio_Costo As Double
        Get
            Return _Precio_Costo
        End Get
        Set(value As Double)
            _Precio_Costo = value
        End Set
    End Property

    Private _Precio_Minimo As Double
    Public Property Precio_Minimo As Double
        Get
            Return _Precio_Minimo
        End Get
        Set(value As Double)
            _Precio_Minimo = value
        End Set
    End Property


    Private _Precio_Normal As Double
    Public Property Precio_Normal As Double
        Get
            Return _Precio_Normal
        End Get
        Set(value As Double)
            _Precio_Normal = value
        End Set
    End Property


    Private _Stock As String
    Public Property Stock As String
        Get
            Return _Stock
        End Get
        Set(value As String)
            _Stock = value
        End Set
    End Property


    Private _Foto As Image
    Public Property Foto As Image
        Get
            Return _Foto
        End Get
        Set(value As Image)
            _Foto = value
        End Set
    End Property
#End Region

    Public Shared Function Image2Byte(ByVal Img As Image) As Byte()
        If Img Is Nothing Then
            Return Nothing
        Else
            Dim converter As New ImageConverter
            Return converter.ConvertTo(Img, GetType(Byte()))
        End If
    End Function

    Public Shared Function Bytes2Image(ByVal bytes() As Byte) As Image
        If bytes Is Nothing Then
            Return Nothing
        Else
            Dim ms As New MemoryStream(bytes)
            Dim Img As Image = Nothing
            Try
                Img = Image.FromStream(ms)
            Catch ex As Exception

            End Try
            Return Img
        End If
    End Function

    Public Shared Function RecuperarTodosLosInventarios() As BindingList(Of Inventario)
        Dim Retorno As New BindingList(Of Inventario)

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_ConsultarInventario"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParId", 0)

            Dim Lector As MySqlDataReader
            Lector = Comando.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read
                    Dim Obj As New Inventario

                    Obj.Id_Inventario = Lector.GetValue(0)
                    Obj.Codigo_Barra = Lector.GetValue(1)
                    Obj.Descripción = Lector.GetValue(2)

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

    Public Shared Function RecuperarUnInventario(ByVal Id_Inventario As Integer) As Inventario
        Dim Retorno As New Inventario

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_ConsultarInventario"
            Comando.Parameters.AddWithValue("ParOpcion", 2)
            Comando.Parameters.AddWithValue("ParId", Id_Inventario)

            Dim Lector As MySqlDataReader
            Lector = Comando.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read

                    Retorno.Id_Inventario = Lector.GetValue(0)
                    Retorno.Codigo_Barra = Lector.GetValue(1)
                    Retorno.Descripción = Lector.GetValue(2)
                    Retorno.Marca = Lector.GetValue(3)
                    Retorno.Categoria = Lector.GetValue(4)
                    Retorno.Proveedor = Lector.GetValue(5)
                    Retorno.Precio_Costo = Lector.GetValue(6)
                    Retorno.Precio_Minimo = Lector.GetValue(7)
                    Retorno.Precio_Normal = Lector.GetValue(8)
                    Retorno.Stock = Lector.GetValue(9)
                    Retorno.Fecha = Lector.GetValue(11)

                    If Not IsDBNull(Lector.GetValue(10)) Then
                        Retorno.Foto = Bytes2Image(Lector.GetValue(10))
                    End If
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

    Public Shared Function InsertarInventario(ByVal ObjInventario As Inventario) As Integer
        Dim Retorno As Integer

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_InsertarInventario"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParidCodigoBarra", ObjInventario.Codigo_Barra)
            Comando.Parameters.AddWithValue("ParDescripción", ObjInventario.Descripción)
            Comando.Parameters.AddWithValue("ParidMarca", ObjInventario.Marca)
            Comando.Parameters.AddWithValue("Paridcategoria", ObjInventario.Categoria)
            Comando.Parameters.AddWithValue("Paridproveedor", ObjInventario.Proveedor)
            Comando.Parameters.AddWithValue("ParPrecioCosto", ObjInventario.Precio_Costo)
            Comando.Parameters.AddWithValue("ParPrecioMinimo", ObjInventario.Precio_Minimo)
            Comando.Parameters.AddWithValue("ParPrecioNormal", ObjInventario.Precio_Normal)
            Comando.Parameters.AddWithValue("ParStock", ObjInventario.Stock)
            Comando.Parameters.AddWithValue("ParFecha", ObjInventario.Fecha)

            If ObjInventario Is Nothing Then
                Comando.Parameters.AddWithValue("ParFoto", Nothing)
            Else
                Comando.Parameters.AddWithValue("ParFoto", Image2Byte(ObjInventario.Foto))
            End If
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


    Public Shared Sub EditarInventario(ByVal ObjInventario As Inventario)

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_EditarInventario"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParidCodigoBarra", ObjInventario.Codigo_Barra)
            Comando.Parameters.AddWithValue("ParDescripción", ObjInventario.Descripción)
            Comando.Parameters.AddWithValue("ParidMarca", ObjInventario.Marca)
            Comando.Parameters.AddWithValue("Paridcategoria", ObjInventario.Categoria)
            Comando.Parameters.AddWithValue("Paridproveedor", ObjInventario.Proveedor)
            Comando.Parameters.AddWithValue("ParPrecioCosto", ObjInventario.Precio_Costo)
            Comando.Parameters.AddWithValue("ParPrecioMinimo", ObjInventario.Precio_Minimo)
            Comando.Parameters.AddWithValue("ParPrecioNormal", ObjInventario.Precio_Normal)
            Comando.Parameters.AddWithValue("ParStock", ObjInventario.Stock)
            Comando.Parameters.AddWithValue("ParFecha", ObjInventario.Fecha)
            Comando.Parameters.AddWithValue("ParId", ObjInventario.Id_Inventario)


            If ObjInventario Is Nothing Then
                Comando.Parameters.AddWithValue("ParFoto", Nothing)
            Else
                Comando.Parameters.AddWithValue("ParFoto", Image2Byte(ObjInventario.Foto))
            End If

            Comando.ExecuteNonQuery()

        Catch ex As Exception
            Throw
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try

    End Sub

    Public Shared Sub EliminarInventario(ByVal ObjInventario As Inventario)

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_EliminarInventario"
            Comando.Parameters.AddWithValue("ParOpcion", 1)

            Comando.Parameters.AddWithValue("ParId", ObjInventario.Id_Inventario)

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
