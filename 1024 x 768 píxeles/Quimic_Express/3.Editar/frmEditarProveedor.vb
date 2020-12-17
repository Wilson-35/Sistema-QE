Imports MySql.Data.MySqlClient
Public Class frmEditarProveedor
    Dim adaptador As MySqlDataAdapter
    Dim comando As MySqlCommand
    Dim datos As DataSet
    Private Sub frmEditarProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If operacionABM = "editar" Then
            lbltitulo.Text = "Consulta de Proveedor - Editar: " & codigoABM
            Call buscarRegistro(codigoABM)
        End If
    End Sub
    Private Sub buscarRegistro(codigo As Integer)
        Dim sql As String
        sql = "select * from proveedor where id=" & codigo
        Try
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "xproveedor")
            txtCodigo.Text = datos.Tables("xproveedor").Rows(0).Item("id")
            txtNombres.Text = datos.Tables("xproveedor").Rows(0).Item("nombres")
            txtApellidos.Text = datos.Tables("xproveedor").Rows(0).Item("apellidos")
            txtDireccion.Text = datos.Tables("xproveedor").Rows(0).Item("direccion")
            txtTelefono.Text = datos.Tables("xproveedor").Rows(0).Item("contacto")
            txtRuc.Text = datos.Tables("xproveedor").Rows(0).Item("ruc")
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
        If Me.ValidateChildren = True And txtNombres.Text <> "" And txtTelefono.Text <> "" And txtRuc.Text <> "" And txtApellidos.Text <> "" Then
            Try
                abrirConexion()
                sql = "update proveedor set nombres= @nombres,apellidos=@apellidos,direccion=@direccion, contacto=@contacto, ruc=@ruc where id=@id"
                comando = New MySqlCommand(sql, conexion)
                comando.Parameters.AddWithValue("@id", txtCodigo.Text)
                comando.Parameters.AddWithValue("@nombres", txtNombres.Text)
                comando.Parameters.AddWithValue("@apellidos", txtApellidos.Text)
                comando.Parameters.AddWithValue("@direccion", txtDireccion.Text)
                comando.Parameters.AddWithValue("@contacto", txtTelefono.Text)
                comando.Parameters.AddWithValue("@ruc", txtRuc.Text)
                comando.ExecuteNonQuery()
                MsgBox("Registro Guardado")
                Me.Close()
                frmConsultarProveedor.cargarRegistros("")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Debe Rellenar Todos Los Campos", "Registro de Proveedor ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
        AbrirFormInPanel(New frmConsultarProveedor)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        AbrirFormInPanel(New frmConsultarProveedor)
    End Sub
End Class