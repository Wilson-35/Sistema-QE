Imports MySql.Data.MySqlClient
Public Class frmEditarCliente
    Private Sub frmEditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If operacionABM = "editar" Then
            lbltitulo.Text = "Consulta de Cliente - Editar: " & codigoABM
            Call buscarRegistro(codigoABM)
        End If
    End Sub

    Dim adaptador As MySqlDataAdapter
    Dim comando As MySqlCommand
    Dim datos As DataSet
    Private Sub buscarRegistro(codigo As Integer)
        Dim sql As String
        sql = "select * from cliente where id=" & codigo
        Try
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "xcliente")
            txtCodigo.Text = datos.Tables("xcliente").Rows(0).Item("id")
            txtNombres.Text = datos.Tables("xcliente").Rows(0).Item("nombres")
            txtApellidos.Text = datos.Tables("xcliente").Rows(0).Item("apellidos")
            txtDireccion.Text = datos.Tables("xcliente").Rows(0).Item("direccion")
            txtTelefono.Text = datos.Tables("xcliente").Rows(0).Item("contacto")
            txtfechadenacimiento.Text = datos.Tables("xcliente").Rows(0).Item("fechadenacimiento")
            txtRuc.Text = datos.Tables("xcliente").Rows(0).Item("ruc")
            txtCorreoE.Text = datos.Tables("xcliente").Rows(0).Item("correoelectronico")
        Catch ex As MySqlException
            MsgBox(ex.Message)
        Finally
            cerrarConexion()
        End Try
    End Sub

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

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim sql As String
        If Me.ValidateChildren = True And txtCorreoE.Text <> "" And txtNombres.Text <> "" And txtApellidos.Text <> "" And txtDireccion.Text <> "" And txtTelefono.Text <> "" And txtfechadenacimiento.Text <> "" And txtRuc.Text <> "" Then
            Try
                abrirConexion()
                sql = "update cliente set nombres= @nombres,apellidos=@apellidos,direccion=@direccion, contacto=@contacto, fechadenacimiento=@fechadenacimiento, ruc=@ruc, correoelectronico=@correoelectronico where id=@id"
                comando = New MySqlCommand(sql, conexion)
                comando.Parameters.AddWithValue("@id", txtCodigo.Text)
                comando.Parameters.AddWithValue("@nombres", txtNombres.Text)
                comando.Parameters.AddWithValue("@apellidos", txtApellidos.Text)
                comando.Parameters.AddWithValue("@direccion", txtDireccion.Text)
                comando.Parameters.AddWithValue("@contacto", txtTelefono.Text)
                comando.Parameters.AddWithValue("@fechadenacimiento", txtfechadenacimiento.Text)
                comando.Parameters.AddWithValue("@ruc", txtRuc.Text)
                comando.Parameters.AddWithValue("@correoelectronico", txtCorreoE.Text)
                comando.ExecuteNonQuery()
                MsgBox("Registro Guardado")
                Me.Close()
                frmConsultarUsuario.cargarRegistros("")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Debe Rellenar Todos Los Campos", "Registro de Usuario ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        AbrirFormInPanel(New frmConsultarCliente)
    End Sub

    Private Sub btnCancelar_Click_1(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        AbrirFormInPanel(New frmConsultarCliente)
    End Sub
End Class