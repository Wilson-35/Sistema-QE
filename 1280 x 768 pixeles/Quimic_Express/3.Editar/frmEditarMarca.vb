Imports MySql.Data.MySqlClient
Public Class frmEditarMarca
    Dim adaptador As MySqlDataAdapter
    Dim comando As MySqlCommand
    Dim datos As DataSet
    Private Sub frmEditarMarca_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If operacionABM = "editar" Then
            lbltitulo.Text = "Consulta de Marca - Editar: " & codigoABM
            Call buscarRegistro(codigoABM)
        End If
    End Sub
    Private Sub buscarRegistro(codigo As Integer)
        Dim sql As String
        sql = "select * from marca where id_Marca=" & codigo
        Try
            abrirConexion()
            adaptador = New MySqlDataAdapter(sql, conexion)
            datos = New DataSet
            adaptador.Fill(datos, "xproveedor")
            txtCodigo.Text = datos.Tables("xproveedor").Rows(0).Item("id_marca")
            txtDescripcion.Text = datos.Tables("xproveedor").Rows(0).Item("descripcion")

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
        If Me.ValidateChildren = True And txtDescripcion.Text <> "" Then
            Try
                abrirConexion()
                sql = "update marca set descripcion= @descripcion where id_marca=@id_marca"
                comando = New MySqlCommand(sql, conexion)
                comando.Parameters.AddWithValue("@id_marca", txtCodigo.Text)
                comando.Parameters.AddWithValue("@descripcion", txtDescripcion.Text)
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
        AbrirFormInPanel(New frmConsultarMarca)
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
        AbrirFormInPanel(New frmConsultarMarca)
    End Sub
End Class