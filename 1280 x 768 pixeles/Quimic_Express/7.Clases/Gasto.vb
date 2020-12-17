Imports System.ComponentModel
Imports System.IO
Imports MySql.Data.MySqlClient
Public Class Gasto
#Region "AgregarColumnas"
    Private _Id As Integer
    Public Property Id_Gastos As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Private _Comprobante As String


    Private _Descripción As String
    Public Property Descripción As String
        Get
            Return _Descripción
        End Get
        Set(value As String)
            _Descripción = value
        End Set
    End Property


    Private _Guarani As Double
    Public Property Guarani As Double
        Get
            Return _Guarani
        End Get
        Set(value As Double)
            _Guarani = value
        End Set
    End Property

    Private _Dolar As Double
    Public Property Dolar As Double
        Get
            Return _Dolar
        End Get
        Set(value As Double)
            _Dolar = value
        End Set
    End Property

    Private _Real As Double
    Public Property Real As Double
        Get
            Return _Real
        End Get
        Set(value As Double)
            _Real = value
        End Set
    End Property

    Private _Peso As Double
    Public Property Peso As Double
        Get
            Return _Peso
        End Get
        Set(value As Double)
            _Peso = value
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

    Public Shared Function RecuperarTodosLosGastos() As BindingList(Of Gasto)
        Dim Retorno As New BindingList(Of Gasto)

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_ConsultarGasto"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParId", 0)

            Dim Lector As MySqlDataReader
            Lector = Comando.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read
                    Dim Obj As New Gasto

                    Obj.Id_Gastos = Lector.GetValue(0)
                    Obj.Descripción = Lector.GetValue(1)
                    Obj.Guarani = Lector.GetValue(2)
                    Obj.Dolar = Lector.GetValue(3)

                    Obj.Real = Lector.GetValue(4)
                    Obj.Peso = Lector.GetValue(5)



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

    Public Shared Function RecuperarUnGasto(ByVal Id_Gastos As Integer) As Gasto
        Dim Retorno As New Gasto

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()
            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_ConsultarGasto"
            Comando.Parameters.AddWithValue("ParOpcion", 2)
            Comando.Parameters.AddWithValue("ParId", Id_Gastos)

            Dim Lector As MySqlDataReader
            Lector = Comando.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read

                    Retorno.Id_Gastos = Lector.GetValue(0)
                    Retorno.Descripción = Lector.GetValue(1)

                    Retorno.Guarani = Lector.GetValue(2)
                    Retorno.Dolar = Lector.GetValue(3)
                    Retorno.Real = Lector.GetValue(4)
                    Retorno.Peso = Lector.GetValue(5)

                    Retorno.Estado = Lector.GetValue(6)
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

    Public Shared Function InsertarGasto(ByVal ObjGasto As Gasto) As Integer
        Dim Retorno As Integer

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_InsertarGasto"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParDescripción", ObjGasto.Descripción)

            Comando.Parameters.AddWithValue("ParGuarani", ObjGasto.Guarani)
            Comando.Parameters.AddWithValue("ParDolar", ObjGasto.Dolar)
            Comando.Parameters.AddWithValue("ParReal", ObjGasto.Real)
            Comando.Parameters.AddWithValue("ParPeso", ObjGasto.Peso)

            Comando.Parameters.AddWithValue("ParEstado", ObjGasto.Estado)
            Comando.Parameters.AddWithValue("ParFecha", ObjGasto.Fecha)

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

    Public Shared Sub EditarGasto(ByVal ObjGasto As Gasto)

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_EditarGasto"
            Comando.Parameters.AddWithValue("ParOpcion", 1)
            Comando.Parameters.AddWithValue("ParDescripción", ObjGasto.Descripción)

            Comando.Parameters.AddWithValue("ParGuarani", ObjGasto.Guarani)
            Comando.Parameters.AddWithValue("ParDolar", ObjGasto.Dolar)
            Comando.Parameters.AddWithValue("ParReal", ObjGasto.Real)
            Comando.Parameters.AddWithValue("ParPeso", ObjGasto.Peso)
            Comando.Parameters.AddWithValue("ParEstado", ObjGasto.Estado)
            Comando.Parameters.AddWithValue("ParFecha", ObjGasto.Fecha)
            Comando.Parameters.AddWithValue("ParId", ObjGasto.Id_Gastos)


            Comando.ExecuteNonQuery()

        Catch ex As Exception
            Throw
        Finally
            If Conexion.State = ConnectionState.Open Then
                Conexion.Close()
            End If
        End Try

    End Sub

    Public Shared Sub EliminarGasto(ByVal ObjGasto As Gasto)

        'Conexion a la base de datos
        Dim Conexion As New MySqlConnection
        Conexion.ConnectionString = "Server=localhost;Port=3305;DataBase=quimicexpress;Uid=root;Pwd=1234;"

        Try
            Conexion.Open()

            Dim Comando As New MySqlCommand
            Comando.Connection = Conexion
            Comando.CommandType = CommandType.StoredProcedure
            Comando.CommandText = "Pa_EliminarGasto"
            Comando.Parameters.AddWithValue("ParOpcion", 1)

            Comando.Parameters.AddWithValue("ParId", ObjGasto.Id_Gastos)

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

