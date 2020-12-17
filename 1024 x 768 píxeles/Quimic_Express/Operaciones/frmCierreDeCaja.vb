Imports MySql.Data.MySqlClient
Public Class frmCierreDeCaja
    Dim adaptador As MySqlDataAdapter
    Dim comando As MySqlCommand
    Dim datos As DataSet

    Public Sub AbrirFormInPanel(ByVal Formhijo As Object)
        If (frmMenu.PanelContenedor.Controls.Count > 0) Then
            frmMenu.PanelContenedor.Controls.RemoveAt(0)
        End If

        Dim fh As Form = CType(Formhijo, Form)
        fh.TopLevel = False
        fh.Dock = DockStyle.Fill
        frmMenu.PanelContenedor.Controls.Add(fh)
        frmMenu.PanelContenedor.Tag = fh
        fh.Show()
    End Sub

    Private Sub frmCierreDeCaja_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call cargarGastos()
        Call cargarApertura()
        Call cargarVentas()
        Call totalCierre()
        txtUsuarioNombre.Text = nombreUsuario
    End Sub

    Public Sub cargarApertura()
        Dim sql As String
        sql = "select * from apertura where Id_Apertura= (select max(Id_Apertura)from apertura)"

        Try
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "xapertura")
            txtGApertura.Value = datos.Tables("xapertura").Rows(0).Item("Guarani")
            txtDApertura.Value = datos.Tables("xapertura").Rows(0).Item("Dolar")
            txtRApertura.Value = datos.Tables("xapertura").Rows(0).Item("Realb")
            txtPApertura.Value = datos.Tables("xapertura").Rows(0).Item("Peso")


        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()

        End Try
    End Sub

    Public Sub cargarGastos()
        Dim sql As String
        sql = "select * from consultagastos"

        Try
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "xgstos")
            txtGaGs.Value = datos.Tables("xgstos").Rows(0).Item("Guarani")
            txtGaUs.Value = datos.Tables("xgstos").Rows(0).Item("Dolar")
            TxtGaRs.Value = datos.Tables("xgstos").Rows(0).Item("Reales")
            txtGaPs.Value = datos.Tables("xgstos").Rows(0).Item("Peso")
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Sub

    Public Sub cargarVentas()
        Dim sql As String
        sql = "select * from consultacobros"

        Try
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "xvnta")
            txtVenGs.Value = datos.Tables("xvnta").Rows(0).Item("Guaranies")
            txtVenUs.Value = datos.Tables("xvnta").Rows(0).Item("Dolar")
            txtVenRs.Value = datos.Tables("xvnta").Rows(0).Item("Reales")
            txtVenPs.Value = datos.Tables("xvnta").Rows(0).Item("Pesos")
        Catch ex As MySqlException
            MsgBox(ex.Message)

        Finally
            cerrarConexion()

        End Try
    End Sub

    Public Sub totalCierre()
        txtCajaGs.Value = Val(txtGApertura.Value) + Val(txtVenGs.Value) - Val(txtGaGs.Value)
        txtCajaUs.Value = Val(txtDApertura.Value) + Val(txtVenUs.Value) - Val(txtGaUs.Value)
        txtCajaRs.Value = Val(txtRApertura.Value) + Val(txtVenRs.Value) - Val(TxtGaRs.Value)
        txtCajaPs.Value = Val(txtPApertura.Value) + Val(txtVenPs.Value) - Val(txtGaPs.Value)
    End Sub


    Private Sub btnCancelarApertura_Click(sender As Object, e As EventArgs) Handles btnCancelarApertura.Click
        Me.Close()
        AbrirFormInPanel(New frmOperaciones)
    End Sub

    Private Sub btnGuardarApertura_Click(sender As Object, e As EventArgs) Handles btnGuardarApertura.Click
        Dim sql As String
        Try
            abrirConexion()
            sql = "insert into cierrecaja(fecha,usuario,montoGs,montoUs,montoRs,montoPs) values(@fecha,@usuario,@montoGs,@montoUs,@montoRs,@montoPs)"
            comando = New MySqlCommand(sql, conexion)
            comando.Parameters.AddWithValue("@fecha", dpFecha.Value)
            comando.Parameters.AddWithValue("@usuario", txtUsuarioNombre.Text)
            comando.Parameters.AddWithValue("@montoGs", txtCajaGs.Value)
            comando.Parameters.AddWithValue("@montoUs", txtCajaUs.Value)
            comando.Parameters.AddWithValue("@montoRs", txtCajaRs.Value)
            comando.Parameters.AddWithValue("@montoPs", txtCajaPs.Value)

            comando.ExecuteNonQuery()

            MessageBox.Show("Cierre de caja exitoso")
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Sub

End Class