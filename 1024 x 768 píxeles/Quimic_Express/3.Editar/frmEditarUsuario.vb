Imports MySql.Data.MySqlClient
Public Class frmEditarUsuario
    Private Sub frmEditarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If operacionABM = "editar" Then
            lbltitulo.Text = "Consulta de Usuario - Editar: " & codigoABM
            Call buscarRegistro(codigoABM)
        End If
    End Sub

    Dim adaptador As MySqlDataAdapter
    Dim comando As MySqlCommand
    Dim datos As DataSet
    Private Sub buscarRegistro(codigo As Integer)
        Dim sql As String
        sql = "select * from usuario where id_usuario=" & codigo
        Try
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "xusuario")
            txtCodigo.Text = datos.Tables("xusuario").Rows(0).Item("id_Usuario")
            txtNombres.Text = datos.Tables("xusuario").Rows(0).Item("nombre")
            txtUsuario.Text = datos.Tables("xusuario").Rows(0).Item("Nombreusuario")
            txtPassword1.Text = datos.Tables("xusuario").Rows(0).Item("passwordUsuario")
            txtPassword2.Text = datos.Tables("xusuario").Rows(0).Item("passwordUsuario")
            txtCargo.Text = datos.Tables("xusuario").Rows(0).Item("cargo")
            txtCorreo.Text = datos.Tables("xusuario").Rows(0).Item("correoelectronico")
            txtContacto.Text = datos.Tables("xusuario").Rows(0).Item("contacto")

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
        If Me.ValidateChildren = True And txtNombres.Text <> "" And txtUsuario.Text <> "" And txtPassword1.Text <> "" And txtPassword2.Text <> "" And txtCargo.Text <> "" And txtCorreo.Text <> "" And txtContacto.Text <> "" Then
            If txtPassword1.Text <> txtPassword2.Text Then
                MessageBox.Show("Las Contraseñas Ingresadas No Coincide", "Verificar Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Try
                abrirConexion()


                sql = "update usuario set nombre= @nombre,Nombreusuario=@Nombreusuario, passwordUsuario=@passwordUsuario, cargo=@cargo, correoelectronico=@correoelectronico, contacto=@contacto where id_Usuario=@id_Usuario"
                comando = New MySqlCommand(sql, conexion)
                comando.Parameters.AddWithValue("@id_Usuario", txtCodigo.Text)
                comando.Parameters.AddWithValue("@nombre", txtNombres.Text)
                comando.Parameters.AddWithValue("@nombreusuario", txtUsuario.Text)
                comando.Parameters.AddWithValue("@passwordUsuario", txtPassword1.Text)
                comando.Parameters.AddWithValue("@cargo", txtCargo.Text)
                comando.Parameters.AddWithValue("@correoelectronico", txtCorreo.Text)
                comando.Parameters.AddWithValue("@contacto", txtContacto.Text)

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
        AbrirFormInPanel(New frmConsultarUsuario)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        AbrirFormInPanel(New frmConsultarUsuario)
    End Sub
End Class