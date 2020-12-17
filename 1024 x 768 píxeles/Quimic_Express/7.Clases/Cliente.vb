Imports System.ComponentModel
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Cliente
#Region "Agregar Columnas"
    Private _Id As Integer
    Public Property Id_Cliente As Integer
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

    Private _Correo_Electronico As String
    Public Property Correo_Electronico As String
        Get
            Return _Correo_Electronico
        End Get
        Set(value As String)
            _Correo_Electronico = value
        End Set
    End Property


    Private _FechaDeNacimiento As Date
    Public Property FechaDeNacimiento As Date
        Get
            Return _FechaDeNacimiento
        End Get
        Set(value As Date)
            _FechaDeNacimiento = value
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

    Public Shared Function RecuperarTodosLosClientes() As BindingList(Of Cliente)
        Dim Retorno As New BindingList(Of Cliente)

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_ConsultarCliente"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParId", 0)

            Dim Lector As MySqlDataReader
            Lector = Comando.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read
                    Dim Obj As New Cliente

                    Obj.Id_Cliente = Lector.GetValue(0)
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

    Public Shared Function RecuperarUnCliente(ByVal Id_Cliente As Integer) As Cliente
        Dim Retorno As New Cliente

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_ConsultarCliente"
            Comando.Parameters.AddWithValue("ParOpcion", 2)
            Comando.Parameters.AddWithValue("ParId", Id_Cliente)

            Dim Lector As MySqlDataReader
            Lector = Comando.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read

                    Retorno.Id_Cliente = Lector.GetValue(0)
                    Retorno.Nombre = Lector.GetValue(1)
                    Retorno.Dirección = Lector.GetValue(2)
                    Retorno.Contacto = Lector.GetValue(3)
                    Retorno.Ruc = Lector.GetValue(4)
                    Retorno.Correo_Electronico = Lector.GetValue(5)
                    Retorno.FechaDeNacimiento = Lector.GetValue(6)
                    Retorno.Fecha = Lector.GetValue(7)

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

    Public Shared Function InsertarCliente(ByVal ObjCliente As Cliente) As Integer
        Dim Retorno As Integer

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_InsertarCliente"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParNombre", ObjCliente.Nombre)
            Comando.Parameters.AddWithValue("ParDirección", ObjCliente.Dirección)
            Comando.Parameters.AddWithValue("ParContacto", ObjCliente.Contacto)
            Comando.Parameters.AddWithValue("ParRuc", ObjCliente.Ruc)
            Comando.Parameters.AddWithValue("ParCorreoElectronico", ObjCliente.Correo_Electronico)
            Comando.Parameters.AddWithValue("ParFechaDeNacimiento", ObjCliente.FechaDeNacimiento)
            Comando.Parameters.AddWithValue("ParFecha", ObjCliente.Fecha)

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


    Public Shared Sub EditarCliente(ByVal ObjCliente As Cliente)

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_EditarCliente"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParNombre", ObjCliente.Nombre)
            Comando.Parameters.AddWithValue("ParDirección", ObjCliente.Dirección)
            Comando.Parameters.AddWithValue("ParContacto", ObjCliente.Contacto)
            Comando.Parameters.AddWithValue("ParRuc", ObjCliente.Ruc)
            Comando.Parameters.AddWithValue("ParCorreoElectronico", ObjCliente.Correo_Electronico)
            Comando.Parameters.AddWithValue("ParFechaDeNacimiento", ObjCliente.FechaDeNacimiento)
            Comando.Parameters.AddWithValue("ParFecha", ObjCliente.Fecha)
            Comando.Parameters.AddWithValue("ParId", ObjCliente.Id_Cliente)

            Comando.ExecuteNonQuery()

        Catch ex As Exception
            Throw
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try

    End Sub

    Public Shared Sub EliminarCliente(ByVal ObjCliente As Cliente)

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_EliminarCliente"
            Comando.Parameters.AddWithValue("ParOpcion", 1)

            Comando.Parameters.AddWithValue("ParId", ObjCliente.Id_Cliente)

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




